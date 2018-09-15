
Imports MySql.Data.MySqlClient

Public Class F_Lap_Bulanan
    Sub IsiComboRuang()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_ruang", StrKoneksi)
                Da.Fill(Dt)
                With CBRuang
                    .DataSource = Dt
                    .ValueMember = "ID_RUANG"
                    .DisplayMember = "NAMA_RUANG"
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub F_Lap_Bulanan_Load(sender As Object, e As EventArgs) Handles Me.Load
        IsiComboRuang()
    End Sub

    Sub KondisiAwal()
        Dim Dt As New DataTable
        Dim Da As New MySqlDataAdapter("select ID,KATEGORI,JUDUL from tab_indikator", StrKoneksi)
        Da.Fill(Dt)
        DGV1.DataSource = Dt
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class