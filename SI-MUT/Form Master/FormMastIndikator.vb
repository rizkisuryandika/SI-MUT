Imports MySql.Data.MySqlClient

Public Class FormMastIndikator
    Dim i, rowdgv1, rowdgv2 As Integer
    Private bs As New BindingSource()

    Private Function cbaktif() As Integer
        If cb_status.Text = "AKTIF" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Sub KondisiAwal()
        Dim Dt As New DataTable
        Dim Da As New MySqlDataAdapter("select * from tab_indikator", StrKoneksi)
        Da.Fill(Dt)
        DGV1.DataSource = Dt

        tx_satuan.SelectedIndex = 0
        cb_status.SelectedIndex = 0
        cb_status.Text = ""
        tx_satuan.Text = ""
        tx_standart.Text = ""

        tx_judul.Text = ""
        tx_numerator.Text = ""
        tx_denumerator.Text = ""

        nomorInd()

        ID_INDIKATOR.Enabled = False

        ButtonSimpan.Visible = True
        ButtonHapus.Visible = False
    End Sub

    Sub IsiComboJenis()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_jenis", StrKoneksi)
                Da.Fill(Dt)
                With cb_jenis
                    .DataSource = Dt
                    .ValueMember = "ID_JENIS"
                    .DisplayMember = "NAMA"
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub IsiComboKategori()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_kategori", StrKoneksi)
                Da.Fill(Dt)
                With cb_kategori
                    .DataSource = Dt
                    .ValueMember = "ID_KATEGORI"
                    .DisplayMember = "NAMA"
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub isidgvruang()
        Try
            With DGV2
                .Columns.Clear()
                .DataSource = Nothing

                Dim col1, col2, col3 As New DataGridViewTextBoxColumn
                col1.Name = "ID_RUANG"
                col2.Name = "ID_INDIKATOR"
                col3.Name = "NAMA_RUANG"
                .Columns.Add(col1)
                .Columns.Add(col2)
                .Columns.Add(col3)

                .ColumnHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .Columns("ID_RUANG").Visible = False
                .Columns("ID_INDIKATOR").Visible = False
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub getdgvruang()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select tab_indruang.idr,tab_indruang.id_ruang,tab_ruang.nama_ruang from tab_indruang
                                              left outer join tab_ruang on tab_indruang.id_ruang = tab_ruang.id_ruang
                                              where ID_INDIKATOR = '" & ID_INDIKATOR.Text & "'", StrKoneksi)
                Da.Fill(Dt)
                With DGV2
                    .Columns.Clear()
                    .DataSource = Nothing
                    .DataSource = Dt

                    .ColumnHeadersVisible = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("IDR").Visible = False
                    .Columns("ID_RUANG").Visible = False
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub nomorInd()
        Dim nomor As Integer
        Try
            nomor = ekSkalar("select right(max(id),3) from tab_indikator")
        Catch ex As Exception
            nomor = 0
        End Try
        If nomor = 0 Then
            ID_INDIKATOR.Text = "I001"
        Else
            ID_INDIKATOR.Text = "I" & Format(nomor + 1, "000")
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonBaru.PerformClick()
        IsiComboJenis()
        IsiComboKategori()
        Format_DGV(DGV1)
    End Sub

    Sub saveruang()
        Try
            For Each dr As DataGridViewRow In DGV2.Rows
                Dim sqlku As String = "insert into tab_indruang (ID_INDIKATOR,ID_RUANG)
                                         values
                                            ('" & ID_INDIKATOR.Text & "',
                                            '" & dr.Cells("ID_RUANG").Value & "')"
                RUN_Transaction(sqlku)
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            Using kon As New MySqlConnection(StrKoneksi)
                kon.Open()
                Dim sqlku As String
                If ButtonSimpan.Text = "SIMPAN" Then
                    sqlku = "insert into tab_indikator
                                         values
                                            ('" & ID_INDIKATOR.Text & "',
                                            '" & cb_jenis.SelectedValue & "',
                                            '" & cb_kategori.SelectedValue & "',
                                            '" & tx_judul.Text & "',
                                            '" & tx_numerator.Text & "',
                                            '" & tx_denumerator.Text & "',
                                            '" & tx_satuan.Text & "',
                                            '" & tx_standart.Text & "',
                                            0)"
                Else
                    sqlku = "UPDATE tab_indikator SET
                             JENIS='" & cb_jenis.SelectedValue & "',
                             KATEGORI='" & cb_kategori.SelectedValue & "',
                             JUDUL='" & tx_judul.Text & "',
                             NUMERATOR='" & tx_numerator.Text & "',
                             DENUMERATOR='" & tx_denumerator.Text & "',
                             SATUAN='" & tx_satuan.Text & "',
                             STANDAR='" & tx_standart.Text & "',
                             STATUS='" & cbaktif() & "'
                             WHERE ID='" & ID_INDIKATOR.Text & "'"
                End If
                RUN_Transaction(sqlku)

                If ButtonSimpan.Text = "SIMPAN" Then
                    saveruang()
                End If

                MsgBox("Sukses")

            End Using
            ButtonBaru.PerformClick()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
        KondisiAwal()
        isidgvruang()
        ButtonSimpan.Text = "SIMPAN"
        ButtonHapus.Visible = False
    End Sub

    Private Sub get_data()
        Try
            Dim dt As New DataTable
            dt = Data("SELECT * FROM tab_indikator where ID = '" & ID_INDIKATOR.Text & "'")
            If dt.Rows.Count > 0 Then
                cb_jenis.SelectedValue = dt.Rows(0).Item("JENIS") & ""
                cb_kategori.SelectedValue = dt.Rows(0).Item("KATEGORI") & ""
                Dim i As String
                If dt.Rows(0).Item("STATUS") = 0 Then
                    i = "TIDAK AKTIF"
                Else
                    i = "AKTIF"
                End If
                cb_status.SelectedItem = i
                tx_satuan.Text = dt.Rows(0).Item("SATUAN") & ""
                tx_standart.Text = dt.Rows(0).Item("STANDAR") & ""

                tx_judul.Text = dt.Rows(0).Item("JUDUL") & ""
                tx_numerator.Text = dt.Rows(0).Item("NUMERATOR") & ""
                tx_denumerator.Text = dt.Rows(0).Item("DENUMERATOR") & ""

                dt = New DataTable
                dt = Data("SELECT * from tab_indruang where ID_INDIKATOR = '" & ID_INDIKATOR.Text & "'")
                getdgvruang()

                ButtonHapus.Visible = True
                ButtonSimpan.Visible = True
                btn_minruang.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseDoubleClick
        If DGV1.RowCount > 0 Then
            ID_INDIKATOR.Text = DGV1.Rows(rowdgv1).Cells(0).Value
            get_data()
            ButtonSimpan.Text = "UPDATE"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_addruang.Click
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_ruang", StrKoneksi)
                Da.Fill(Dt)
                With lsb_ruang
                    .Visible = True
                    .DataSource = Dt
                    .ValueMember = "ID_RUANG"
                    .DisplayMember = "NAMA_RUANG"
                    .Height = 173
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub lsb_ruang_MouseDoubleClick(sender As Object, e As EventArgs) Handles lsb_ruang.MouseDoubleClick
        Try
            Dim x As Integer = MessageBox.Show("Tambah Ruang " & lsb_ruang.Text, "", MessageBoxButtons.OKCancel)
            If x = MsgBoxResult.Ok Then
                If ButtonSimpan.Text = "SIMPAN" Then
                    Dim row As String() = New String() {lsb_ruang.SelectedValue, ID_INDIKATOR.Text, lsb_ruang.Text}
                    DGV2.Rows.Add(row)
                Else
                    Dim sqlku As String = "insert into tab_indruang (ID_INDIKATOR,ID_RUANG)
                                           values ('" & ID_INDIKATOR.Text & "','" & lsb_ruang.SelectedValue & "')"
                    RUN_Transaction(sqlku)
                    getdgvruang()
                End If
                Me.lsb_ruang.Visible = False
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DGV2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellEnter
        If DGV2.RowCount > 0 Then
            rowdgv2 = DGV2.CurrentRow.Index
        End If
    End Sub

    Private Sub DGV1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellEnter
        If DGV1.RowCount > 0 Then
            rowdgv1 = DGV1.CurrentRow.Index
        End If
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim sqlku As String = "DELETE FROM tab_indruang WHERE ID_INDIKATOR = '" & ID_INDIKATOR.Text & "'"
            RUN_Transaction(sqlku)

            Dim sqlku2 As String = "DELETE FROM tab_indikator WHERE ID = '" & ID_INDIKATOR.Text & "'"
            RUN_Transaction(sqlku2)
            MsgBox("Sukses")

            ButtonBaru.PerformClick()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using f As New FormMastJenis
            f.ShowDialog()
        End Using
        IsiComboJenis()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Using f As New FormMastKategori
            f.ShowDialog()
        End Using
        IsiComboKategori()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tx_cari.TextChanged
        i = 0
        Me.Timer1.Enabled = True
        If Me.tx_cari.Text = "" Then
            ButtonBaru.PerformClick()
        End If
    End Sub

    Private Function txcari() As String
        If TX_cari.Text = "" Then
            Return "%"
        Else
            Return TX_cari.Text
        End If
    End Function
    Private Sub search_cari()
        Try
            If Me.DGV1.RowCount > 0 Then
                bs.DataSource = Me.DGV1.DataSource
                bs.Filter = String.Format("{0} LIKE '%{1}%'", "JUDUL", txcari)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i <> 2 Then
            i += 1
        Else
            search_cari()
            Me.Timer1.Enabled = False
        End If
    End Sub

    Private Sub btn_minruang_Click(sender As Object, e As EventArgs) Handles btn_minruang.Click
        Try
            Dim x As Integer = MessageBox.Show("Hapus Ruang " & DGV2.Rows(rowdgv2).Cells("NAMA_RUANG").Value, "", MessageBoxButtons.OKCancel)
            If x = MsgBoxResult.Ok Then
                If ButtonSimpan.Text = "SIMPAN" Then
                    DGV2.Rows.RemoveAt(rowdgv2)
                Else
                    Dim sqlku As String = "DELETE FROM tab_indruang WHERE IDR = '" & DGV2.Rows(rowdgv2).Cells("IDR").Value & "'"
                    RUN_Transaction(sqlku)
                    getdgvruang()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class
