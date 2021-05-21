Imports MySql.Data.MySqlClient

Public Class FormMastJenis
    Private i As Integer = 0

    Private Sub load_awal()
        Try
            Me.tx_kode.Text = ""
            Me.tx_jenis.Text = ""
            Me.status.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub load_data()
        Try
            DGV1.DataSource = Data("Select * from tab_jenis")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormMastJenis_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_awal()
        load_data()
        Format_DGV(DGV1)
        get_data()
    End Sub

    Private Sub get_nomor()
        Dim nomor As Integer
        Try
            nomor = ekSkalar("select right(max(id_jenis),3) from tab_jenis")
        Catch ex As Exception
            nomor = 0
        End Try
        If nomor = 0 Then
            tx_kode.Text = "J001"
        Else
            tx_kode.Text = "J" & Format(nomor + 1, "000")
        End If
    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
        load_awal()
        get_nomor()
        ButtonSimpan.Text = "SIMPAN"
        ButtonHapus.Visible = False
    End Sub

    Function sts() As Integer
        If status.Text = "AKTIF" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            Dim sqlku As String
            If ButtonSimpan.Text = "SIMPAN" Then
                sqlku = "insert into tab_jenis (ID_JENIS,NAMA,STATUS)
                                         values
                                            ('" & tx_kode.Text & "',
                                            '" & tx_jenis.Text & "',
                                            '" & sts() & "')"
            Else
                sqlku = "UPDATE tab_jenis SET
                             NAMA='" & tx_jenis.Text & "',
                             STATUS='" & sts() & "'
                             WHERE ID_JENIS='" & tx_kode.Text & "'"
            End If
            RUN_Transaction(sqlku)

            MsgBox("Sukses")
            ButtonBaru.PerformClick()
            load_data()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim sqlku As String = "DELETE FROM tab_jenis WHERE ID_JENIS = '" & tx_kode.Text & "'"
            RUN_Transaction(sqlku)

            MsgBox("Sukses")
            ButtonBaru.PerformClick()
            load_data()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub get_data()
        Try
            Dim dt As New DataTable
            dt = Data("Select * from tab_jenis where ID_JENIS = '" & tx_kode.Text & "'")
            If dt.Rows.Count > 0 Then
                Me.tx_jenis.Text = dt.Rows(0).Item("NAMA") & ""
                If dt.Rows(0).Item("STATUS") = "1" Then
                    status.SelectedItem = "AKTIF"
                Else
                    status.SelectedItem = "TDK AKTIF"
                End If
                ButtonSimpan.Text = "UPDATE"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Try
            Me.tx_kode.Text = DGV1.Rows(i).Cells("ID_JENIS").Value
            get_data()
            ButtonHapus.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellEnter
        If DGV1.RowCount > 0 Then
            i = DGV1.CurrentRow.Index
        End If
    End Sub
End Class