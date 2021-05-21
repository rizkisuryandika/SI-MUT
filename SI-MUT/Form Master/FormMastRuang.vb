Imports MySql.Data.MySqlClient

Public Class FormMastRuang
    Private i As Integer = 0

    Private Sub load_awal()
        Try
            Me.tx_kode.Text = ""
            Me.tx_ruang.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub load_data()
        Try
            DGV1.DataSource = Data("Select * from tab_ruang")
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
            nomor = ekSkalar("select right(max(id_ruang),3) from tab_ruang")
        Catch ex As Exception
            nomor = 0
        End Try
        If nomor = 0 Then
            tx_kode.Text = "R001"
        Else
            tx_kode.Text = "R" & Format(nomor + 1, "000")
        End If
    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
        load_awal()
        get_nomor()
        ButtonSimpan.Text = "SIMPAN"
        ButtonHapus.Visible = False
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            Dim sqlku As String
            If ButtonSimpan.Text = "SIMPAN" Then
                sqlku = "insert into tab_ruang (ID_RUANG,NAMA_RUANG)
                                         values
                                            ('" & tx_kode.Text & "',
                                            '" & tx_ruang.Text & "')"
            Else
                sqlku = "UPDATE tab_ruang SET
                             NAMA_RUANG='" & tx_ruang.Text & "'
                             WHERE ID_RUANG='" & tx_kode.Text & "'"
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
            Dim sqlku As String = "DELETE FROM tab_ruang WHERE ID_RUANG = '" & tx_kode.Text & "'"
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
            dt = Data("Select * from tab_RUANG where ID_RUANG = '" & tx_kode.Text & "'")
            If dt.Rows.Count > 0 Then
                Me.tx_ruang.Text = dt.Rows(0).Item("NAMA_RUANG") & ""
                ButtonSimpan.Text = "UPDATE"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Try
            Me.tx_kode.Text = DGV1.Rows(i).Cells("ID_RUANG").Value
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