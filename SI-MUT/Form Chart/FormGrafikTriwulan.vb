Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class FormGrafikTriwulan

    Private Function id_ruang() As String
        If semua.Checked = True Then
            Return "%"
        Else
            Return cb_ruang.SelectedValue
        End If
    End Function

    Private Sub get_data()
        Try
            Dim dt As New DataTable
            dt = Data("select 
                            CASE
		                            WHEN MID(tab_hasil.TGL,6,2) = '01' THEN 'JAN'
		                            WHEN MID(tab_hasil.TGL,6,2) = '02' THEN 'FEB'
		                            WHEN MID(tab_hasil.TGL,6,2) = '03' THEN 'MAR'
		                            WHEN MID(tab_hasil.TGL,6,2) = '04' THEN 'APR'
		                            WHEN MID(tab_hasil.TGL,6,2) = '05' THEN 'MEI'
		                            WHEN MID(tab_hasil.TGL,6,2) = '06' THEN 'JUN'
		                            WHEN MID(tab_hasil.TGL,6,2) = '07' THEN 'JUL'
		                            WHEN MID(tab_hasil.TGL,6,2) = '08' THEN 'AUG'
		                            WHEN MID(tab_hasil.TGL,6,2) = '09' THEN 'SEP'
		                            WHEN MID(tab_hasil.TGL,6,2) = '10' THEN 'OKT'
		                            WHEN MID(tab_hasil.TGL,6,2) = '11' THEN 'NOP'
		                            WHEN MID(tab_hasil.TGL,6,2) = '12' THEN 'DES'
                            END as BULAN, LEFT(tab_hasil.TGL,4) as TAHUN,
                            IFNULL(CAST((SUM(tab_hasil.NUMERATOR)/SUM(tab_hasil.DENUMERATOR))*100 AS INTEGER),0) as NILAI,
                            tab_indikator.STANDAR as SDR
			           from tab_hasil
                       LEFT OUTER JOIN tab_indikator on tab_hasil.ID=tab_indikator.ID
                       LEFT OUTER JOIN tab_indruang on tab_indikator.ID = tab_indruang.ID_INDIKATOR
                       where tab_indruang.ID_RUANG LIKE '" & id_ruang() & "' and
                                    tab_hasil.ID='" & cb_indikator.SelectedValue & "' and
                                    LEFT(tab_hasil.TGL,7) BETWEEN '" & cb_tahun.Text & "-" & convertbln_textkeangka(cb_bln1.Text) & "' and
                                    '" & cb_tahun.Text & "-" & convertbln_textkeangka(cb_bln2.Text) & "'
					   GROUP BY BULAN
					   ORDER BY tab_hasil.TGL ASC")
            With Me.Chart1
                .DataSource = dt
                .ChartAreas.Clear()
                .Series.Clear()
                .Legends.Clear()
                .Titles.Clear()

                .ChartAreas.Add(New ChartArea With {.Name = "areachart"})
                .ChartAreas("areachart").AxisX.MajorGrid.Enabled = False
                .ChartAreas("areachart").AxisY.MajorGrid.LineColor = Color.LightGray
                .ChartAreas("areachart").AxisY.Title = "Nilai Indeks / Triwulan"


                .Titles.Add("Title1")
                .Titles("Title1").Text = ekSkalar("Select JUDUL from tab_indikator where ID='" & cb_indikator.SelectedValue & "'")
                .Titles("Title1").Font = New Font("Tahoma", 12, FontStyle.Bold)

                .Titles.Add("Title2")
                .Titles("Title2").Text = ekSkalar("Select NUMERATOR from tab_indikator where ID='" & cb_indikator.SelectedValue & "'")
                .Titles("Title2").Font = New Font("Tahoma", 8, FontStyle.Regular)

                .Legends.Add("legendchart")
                .Legends("legendchart").Docking = Docking.Bottom
                .Legends("legendchart").Alignment = StringAlignment.Center
                '.Legends("legendchart").Title = "Indeks"

                Dim s1, s2, s3 As New Series
                With s1
                    .ChartArea = "areachart"
                    .Name = "Nilai Mutu"
                    .BorderWidth = 2
                    .IsValueShownAsLabel = False
                    '.LabelForeColor = Color.DimGray
                    .ChartType = SeriesChartType.FastLine
                    .XValueType = ChartValueType.Int32
                    .XValueMember = "BULAN"
                    .YValueType = ChartValueType.Double
                    .YValueMembers = "NILAI"
                    .Color = Color.LimeGreen
                End With

                With s2
                    .ChartArea = "areachart"
                    .Name = "Point"
                    .IsValueShownAsLabel = True
                    .LabelForeColor = Color.DimGray
                    .ChartType = SeriesChartType.Point
                    .XValueType = ChartValueType.Int32
                    .XValueMember = "BULAN"
                    .YValueType = ChartValueType.Double
                    .YValueMembers = "NILAI"
                    .Color = Color.Teal
                End With

                With s3
                    .ChartArea = "areachart"
                    .Name = "Nilai Standart"
                    .BorderWidth = 2
                    .IsValueShownAsLabel = False
                    '.LabelForeColor = Color.DimGray
                    .ChartType = SeriesChartType.FastLine
                    .XValueType = ChartValueType.Int32
                    .XValueMember = "BULAN"
                    .YValueType = ChartValueType.Double
                    .YValueMembers = "SDR"
                    .Color = Color.IndianRed
                End With

                .Series.Add(s1)
                .Series.Add(s2)
                .Series.Add(s3)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Chart1.SaveImage(My.Application.Info.DirectoryPath & "\Grafik\GrafikIndeksPertahun.png", Imaging.ImageFormat.Png)
            MsgBox("Sukses")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub isi_indikator()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select distinct ID,JUDUL from tab_indikator 
                                              inner join tab_indruang on tab_indikator.ID = tab_indruang.ID_INDIKATOR
                                              where tab_indruang.ID_RUANG like '" & id_ruang() & "'", StrKoneksi)
                Da.Fill(Dt)
                With cb_indikator
                    .DataSource = Dt
                    .ValueMember = "ID"
                    .DisplayMember = "JUDUL"
                End With
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Sub isi_ruang()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_ruang", StrKoneksi)
                Da.Fill(Dt)
                With cb_ruang
                    .DataSource = Dt
                    .ValueMember = "ID_RUANG"
                    .DisplayMember = "NAMA_RUANG"
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub isi_tahun()
        For i As Integer = 2017 To DateTime.Today.Year
            cb_tahun.Items.Add(i)
        Next
    End Sub

    Private Sub FormLapTahunan_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi_tahun()
        isi_ruang()
        cb_bln1.SelectedIndex = 0
        cb_bln2.SelectedIndex = 0
        cb_tahun.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Chart1.Printing.PrintPreview()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim stream As New IO.MemoryStream()
            Chart1.SaveImage(stream, Imaging.ImageFormat.Png)
            Dim bmp As New Bitmap(stream)
            Clipboard.SetDataObject(bmp)
            MsgBox("Sukses")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        get_data()
    End Sub

    Private Sub cb_ruang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_ruang.SelectedValueChanged
        isi_indikator()
    End Sub

    Private Sub semua_CheckedChanged(sender As Object, e As EventArgs) Handles semua.CheckedChanged
        If cb_ruang.Enabled = False Then
            cb_ruang.Enabled = True
        Else
            cb_ruang.Enabled = False
        End If
        isi_indikator()
    End Sub


End Class