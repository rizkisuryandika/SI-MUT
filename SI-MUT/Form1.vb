Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(StrKoneksi)
        Using kon As New MySql.Data.MySqlClient.MySqlConnection(StrKoneksi)
            kon.Open()
            MsgBox("sukses")
        End Using
    End Sub
End Class