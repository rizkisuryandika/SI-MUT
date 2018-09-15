Imports MySql.Data.MySqlClient

Public Class FormMastIndikator
    Dim rowdgv As Integer

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

        cb_jenis.Text = "Pilih Jenis Indikator"
        cb_kategori.Text = "Pilih Kategori Indikator"
        cb_status.Text = ""
        tx_satuan.Text = ""
        tx_standart.Text = ""

        tx_judul.Text = ""
        tx_numerator.Text = ""
        tx_denumerator.Text = ""
        ID_INDIKATOR.Enabled = False

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

    Sub IsiCekList()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_ruang", StrKoneksi)
                Da.Fill(Dt)
                With clb_inruang
                    .DataSource = Dt
                    .ValueMember = "ID_RUANG"
                    .DisplayMember = "NAMA_RUANG"
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

    Sub SaveIndRuang()
        Try
            If ButtonSimpan.Text = "UPDATE" Then
                Using kon As New MySqlConnection(StrKoneksi)
                    kon.Open()
                    Dim sqlku As String = "DELETE FROM tab_indruang WHERE ID_INDIKATOR = '" & ID_INDIKATOR.Text & "'"
                    Dim cmd As New MySqlCommand(sqlku, kon)
                    cmd.ExecuteNonQuery()
                End Using
            End If
            For Each item In clb_inruang.CheckedItems
                Using kon As New MySqlConnection(StrKoneksi)
                    kon.Open()
                    Dim sqlku As String = "insert into tab_indruang (ID_INDIKATOR,ID_RUANG)
                                         values
                                            ('" & ID_INDIKATOR.Text & "',
                                            '" & item("ID_RUANG") & "')"
                    Dim cmd As New MySqlCommand(sqlku, kon)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call IsiComboJenis()
        Call IsiComboKategori()
        Call nomorInd()
        Call IsiCekList()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim nomor As Integer = ekSkalar("select right(max(id),3) from tab_jenis")
        tx_satuan.Text = "J" & Format(CInt(nomor) + 1, "000")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Dim nomor As String
        Using kon As New MySqlConnection(StrKoneksi)
            kon.Open()
            Dim cmd As New MySqlCommand("select max(id_user) from tab_user", kon)
            nomor = cmd.ExecuteScalar
            nomor = CInt(nomor) + 1
            nomor = "I" & Format(CInt(nomor), "000")
            ID_INDIKATOR.Text = nomor
            'MsgBox(nomor)
        End Using
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
                Dim cmd As New MySqlCommand(sqlku, kon)
                cmd.ExecuteNonQuery()
                'SaveIndRuang()
                MsgBox("Sukses")
                KondisiAwal()
                IsiComboJenis()
                IsiComboKategori()
                nomorInd()
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub DGV1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellEnter
        If DGV1.RowCount > 0 Then
            rowdgv = DGV1.CurrentRow.Index
            'tx_satuan.Text = DGV1.Rows(rowdgv).Cells(6).Value
        End If
        'Dim nomor As String
        'nomor = DGV1.Rows(1).Cells(3).Value
    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
        KondisiAwal()
        ButtonSimpan.Text = "SIMPAN"
    End Sub

    Private Sub get_data()
        'Try
        Dim dt As New DataTable
            dt = Data("SELECT * FROM tab_indikator where ID = '" & ID_INDIKATOR.Text & "'")
            If dt.Rows.Count > 0 Then
                cb_jenis.SelectedText = dt.Rows(0).Item("JENIS") & ""
                cb_kategori.SelectedText = dt.Rows(0).Item("KATEGORI") & ""
                cb_status.Text = dt.Rows(0).Item("STATUS") & ""
                tx_satuan.Text = dt.Rows(0).Item("SATUAN") & ""
                tx_standart.Text = dt.Rows(0).Item("STANDAR") & ""

                tx_judul.Text = dt.Rows(0).Item("JUDUL") & ""
                tx_numerator.Text = dt.Rows(0).Item("NUMERATOR") & ""
                tx_denumerator.Text = dt.Rows(0).Item("DENUMERATOR") & ""

                dt = New DataTable
                dt = Data("SELECT * from tab_indruang where ID_INDIKATOR = '" & ID_INDIKATOR.Text & "'")
            If dt.Rows.Count > 0 Then

                Dim i As Integer = 0

                For Each row As DataRow In dt.Rows
                    For Each li As DataRowView In clb_inruang.Items

                        'MsgBox(li("ID_RUANG").ToString)
                        If row.Item("ID_RUANG") = li("ID_RUANG").ToString Then
                            'clb_inruang.SelectedVal

                            Exit For
                        End If
                    Next
                Next
            End If
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub DGV1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseDoubleClick
        If DGV1.RowCount > 0 Then
            ID_INDIKATOR.Text = DGV1.Rows(rowdgv).Cells(0).Value
            get_data()
            ButtonSimpan.Text = "UPDATE"
        End If
    End Sub
End Class