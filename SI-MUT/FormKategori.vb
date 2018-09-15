Public Class FormKategori
    Sub IsiDGV()
        DGV_kategori.DataSource = Data("select * from tab_kategori")
    End Sub
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsiDGV()

    End Sub
End Class