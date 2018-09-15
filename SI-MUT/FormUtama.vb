Imports MySql.Data

Public Class FormUtama
    Private Sub IndikatorMutuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndikatorMutuToolStripMenuItem.Click
        FormMastIndikator.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_datetime.Text = Now
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conn As New MySqlClient.MySqlConnection

        Try
            conn.ConnectionString = StrKoneksi()
            conn.Open()
            MsgBox("sukses")

        Catch ex As MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub IndikatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndikatorToolStripMenuItem.Click

        FormJenis.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DGV1.DataSource = Data("select * from tab_user")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lb_datetime.Text = Now
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        FormKategori.Show()
    End Sub

    Private Sub IndikatorMutuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IndikatorMutuToolStripMenuItem1.Click
        FormIndikatorMutu.Show()
    End Sub

    Private Sub BulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulananToolStripMenuItem.Click
        F_Lap_Bulanan.Show()
    End Sub
End Class
