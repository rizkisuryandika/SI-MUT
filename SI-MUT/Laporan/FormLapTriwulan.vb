Imports MySql.Data.MySqlClient

Public Class FormLapTriwulan
    Private bs As New BindingSource()
    Private i As Integer
    Private dt As New DataTable
    Private id_ As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Try
            Dim sql As String = ""

            Me.DataGridView1.DataSource = Nothing

            Select Case cb_triwulan.Text
                Case "Semua"
                    sql = "SELECT tab_indikator.ID, tab_indruang.ID_RUANG, tab_ruang.NAMA_RUANG, tab_indikator.JUDUL as JUDUL_INDIKATOR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-01' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JAN,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-02' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as FEB,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-03' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as MAR,
                                        
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-01' and '" & cb_tahun.Text & "-03' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRI1,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-04' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as APR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-05' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as MEI,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-06' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JUN,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-04' and '" & cb_tahun.Text & "-06' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRI2,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-07' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JUL,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-08' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as AGU,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-09' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as SEP,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-07' and '" & cb_tahun.Text & "-09' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRI3,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-10' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as OKT,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-11' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as NOP,
			               IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-12' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as DES,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-10' and '" & cb_tahun.Text & "-12' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRI4

                           from tab_indruang
                           inner join tab_indikator on tab_indruang.ID_INDIKATOR=tab_indikator.ID
						   inner join tab_ruang on tab_indruang.id_ruang = tab_ruang.ID_RUANG
						   where tab_indruang.id_ruang Like '" & check_ruang() & "'
                           ORDER BY  tab_indruang.ID_RUANG,tab_indikator.id ASC"

                Case "Triwulan 1"
                    sql = "SELECT tab_indikator.ID, tab_indruang.ID_RUANG, tab_ruang.NAMA_RUANG, tab_indikator.JUDUL as JUDUL_INDIKATOR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-01' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JAN,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-02' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as FEB,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-03' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as MAR,
                                        
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-01' and '" & cb_tahun.Text & "-03' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRIWULAN1
                           
                           from tab_indruang
                           inner join tab_indikator on tab_indruang.ID_INDIKATOR=tab_indikator.ID
						   inner join tab_ruang on tab_indruang.id_ruang = tab_ruang.ID_RUANG
						   where tab_indruang.id_ruang Like '" & check_ruang() & "'
                           ORDER BY  tab_indruang.ID_RUANG,tab_indikator.id ASC"

                Case "Triwulan 2"
                    sql = "SELECT tab_indikator.ID, tab_indruang.ID_RUANG, tab_ruang.NAMA_RUANG, tab_indikator.JUDUL as JUDUL_INDIKATOR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-04' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as APR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-05' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as MEI,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-06' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JUN,

                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-04' and '" & cb_tahun.Text & "-06' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRIWULAN2
                           
                           from tab_indruang
                           inner join tab_indikator on tab_indruang.ID_INDIKATOR=tab_indikator.ID
						   inner join tab_ruang on tab_indruang.id_ruang = tab_ruang.ID_RUANG
						   where tab_indruang.id_ruang Like '" & check_ruang() & "'
                           ORDER BY  tab_indruang.ID_RUANG,tab_indikator.id ASC"

                Case "Triwulan 3"
                    sql = "SELECT tab_indikator.ID, tab_indruang.ID_RUANG, tab_ruang.NAMA_RUANG, tab_indikator.JUDUL as JUDUL_INDIKATOR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-07' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as JUL,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-08' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as AGU,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-09' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as SEP,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-07' and '" & cb_tahun.Text & "-09' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRIWULAN3
                           
                           from tab_indruang
                           inner join tab_indikator on tab_indruang.ID_INDIKATOR=tab_indikator.ID
						   inner join tab_ruang on tab_indruang.id_ruang = tab_ruang.ID_RUANG
						   where tab_indruang.id_ruang Like '" & check_ruang() & "'
                           ORDER BY  tab_indruang.ID_RUANG,tab_indikator.id ASC"

                Case "Triwulan 4"
                    sql = "SELECT tab_indikator.ID, tab_indruang.ID_RUANG, tab_ruang.NAMA_RUANG, tab_indikator.JUDUL as JUDUL_INDIKATOR,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-10' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as OKT,
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-11' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as NOP,
			               IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) = '" & cb_tahun.Text & "-12' and tab_hasil.id=tab_indikator.id GROUP BY LEFT(TGL,7), tab_indikator.id) AS INTEGER),0) as DES,
                           
                           IFNULL(CAST((SELECT (SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 FROM tab_hasil
                           where LEFT(TGL,7) BETWEEN '" & cb_tahun.Text & "-10' and '" & cb_tahun.Text & "-12' and tab_hasil.id=tab_indikator.id GROUP BY tab_indikator.id) AS INTEGER),0) as TRIWULAN4
                           
                           from tab_indruang
                           inner join tab_indikator on tab_indruang.ID_INDIKATOR=tab_indikator.ID
						   inner join tab_ruang on tab_indruang.id_ruang = tab_ruang.ID_RUANG
						   where tab_indruang.id_ruang Like '" & check_ruang() & "'
                           ORDER BY  tab_indruang.ID_RUANG,tab_indikator.id ASC"
            End Select

            dt = Data(sql)

            With Me.DataGridView1
                .DataSource = dt
                .Columns("ID").Visible = False
                .Columns("ID_RUANG").Visible = False
                .Columns("NAMA_RUANG").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns("JUDUL_INDIKATOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End With

            TX_cari.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function check_ruang()
        Try
            If semua.Checked = True Then
                Return "%"
            Else
                Return CBRuang.SelectedValue
            End If
        Catch ex As Exception
            Return "%"
        End Try
    End Function

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Try
            If Me.DataGridView1.RowCount > 0 Then
                If cb_triwulan.Text = "Semua" Then
                    Select Case e.ColumnIndex
                        Case = Me.DataGridView1.Columns("TRI1").Index
                            e.CellStyle.BackColor = Color.PaleTurquoise
                        Case = Me.DataGridView1.Columns("TRI2").Index
                            e.CellStyle.BackColor = Color.PaleGreen
                        Case = Me.DataGridView1.Columns("TRI3").Index
                            e.CellStyle.BackColor = Color.FromArgb(253, 221, 98)
                        Case = Me.DataGridView1.Columns("TRI4").Index
                            e.CellStyle.BackColor = Color.Tomato
                    End Select
                Else
                    If e.ColumnIndex = Me.DataGridView1.Columns(Me.DataGridView1.ColumnCount - 1).Index Then
                        e.CellStyle.BackColor = Color.PaleGreen
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormLapTriwulan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Format_DGV(Me.DataGridView1)
        isi_tahun()
        IsiComboRuang()
        Me.cb_tahun.SelectedIndex = 0
        Me.cb_triwulan.SelectedIndex = 0
        Me.cb_cari.SelectedIndex = 1
    End Sub

    Sub isi_tahun()
        For i As Integer = 2017 To DateTime.Today.Year
            cb_tahun.Items.Add(i)
        Next
    End Sub

    Sub IsiComboRuang()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select ID_RUANG,NAMA_RUANG from tab_ruang", StrKoneksi)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EkporDGV_ke_Excel(Me.DataGridView1, My.Application.Info.DirectoryPath & "LaporanTriwulan.xls")
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
            If dt.Rows.Count > 0 Then
                bs.DataSource = dt
                bs.Filter = String.Format("{0} LIKE '%{1}%'", cb_cari.Text, txcari)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
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

    Private Sub TX_cari_TextChanged(sender As Object, e As EventArgs) Handles TX_cari.TextChanged
        i = 0
        Me.Timer1.Enabled = True
        If Me.TX_cari.Text = "" Then
            btn_refresh.PerformClick()
        End If
    End Sub

    Private Sub semua_CheckedChanged(sender As Object, e As EventArgs) Handles semua.CheckedChanged
        If CBRuang.Enabled = False Then
            CBRuang.Enabled = True
        Else
            CBRuang.Enabled = False
        End If
    End Sub
End Class