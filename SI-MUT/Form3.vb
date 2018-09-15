Imports MySql.Data.MySqlClient


Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim Dt As New DataTable
            Dim Da As New MySqlDataAdapter(RichTextBox1.Text, StrKoneksi)
            Da.Fill(Dt)
            DGV1.DataSource = Dt
            MsgBox("Sukses")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

End Class