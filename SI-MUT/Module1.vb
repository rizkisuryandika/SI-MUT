Imports MySql.Data.MySqlClient
Imports excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports Npgsql

Module Module1

    Public Function lockoneksi() As String
        Return My.Application.Info.DirectoryPath & "\koneksi.conf"
    End Function

    Function StrKoneksi() As String
        Dim ini As New Class_fileini
        Try
            If Not File.Exists(lockoneksi) Then
                File.Create(lockoneksi).Dispose()
                ini.Tulis_file_ini_perbaris(lockoneksi, "CON", "PORT", "3306")
                ini.Tulis_file_ini_perbaris(lockoneksi, "CON", "SERVER", "192.168.88.98")
                ini.Tulis_file_ini_perbaris(lockoneksi, "CON", "USERID", "simut")
                ini.Tulis_file_ini_perbaris(lockoneksi, "CON", "PASSWORD", "simrsit")
                ini.Tulis_file_ini_perbaris(lockoneksi, "CON", "DATABASE", "dbmutu")
            End If
            Dim koneksi_string As String
            koneksi_string = "Port =" & ini.Baca_file_ini_perbaris(lockoneksi, "CON", "PORT") & ";
                              Server=" & ini.Baca_file_ini_perbaris(lockoneksi, "CON", "SERVER") & ";
                              Database=" & ini.Baca_file_ini_perbaris(lockoneksi, "CON", "DATABASE") & ";
                              Uid=" & ini.Baca_file_ini_perbaris(lockoneksi, "CON", "USERID") & ";
                              Pwd=" & ini.Baca_file_ini_perbaris(lockoneksi, "CON", "PASSWORD") & ";
                              SslMode=none;"
            Return koneksi_string
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function ekSkalar(ByVal sqlNya As String) As String
        Using kon As New Npgsql.NpgsqlConnection(StrKoneksi)
            kon.Open()
            Dim cmd As New NpgsqlCommand(sqlNya, kon)
            ekSkalar = cmd.ExecuteScalar
        End Using
    End Function

    Function Data(ByVal sqlNya As String) As DataTable
        Dim Dt As New DataTable
        Dim Da As New MySqlDataAdapter(sqlNya, StrKoneksi)
        Da.Fill(Dt)
        Data = Dt
    End Function

    Public Function FormatTanggal(ByVal tanggal As DateTimePicker, Optional ByVal formatnya As String = "yyyy-MM-dd")
        Return Format(tanggal.Value, formatnya)
    End Function

    'Function Fsimpan(ByVal SqlSim As String) As MySqlCommand
    '    Using kon As New MySqlConnection(StrKoneksi)
    '        kon.Open()
    '        Dim cmd As New MySqlCommand(sqlku, kon)
    '        cmd.ExecuteNonQuery()
    'End Function

    Public Function RUN_Transaction(ByVal SQL As String) As Boolean
        Using con As New MySqlConnection(StrKoneksi)
            Dim runCmd As New MySqlCommand(SQL, con)
            con.Open()
            Dim sqlTran As MySqlTransaction = con.BeginTransaction()
            Try
                runCmd.Transaction = sqlTran
                runCmd.ExecuteNonQuery()
                sqlTran.Commit()
                Return True
            Catch ex As Exception
                sqlTran.Rollback()
                MsgBox(ex.Message)
                Return False
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Public Function RUN_Scalar(ByVal SQL As String) As Object
        Using con As New MySqlConnection(StrKoneksi)
            Dim selectCmd As New MySqlCommand(SQL, con)
            con.Open()
            Dim sqlTran As MySqlTransaction = con.BeginTransaction()
            Try
                selectCmd.Transaction = sqlTran
                Return selectCmd.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Public Sub Format_DGV(ByVal DGVnya As DataGridView)
        Try
            With DGVnya
                .AllowUserToResizeRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToAddRows = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .BorderStyle = BorderStyle.None
                .RowHeadersWidth = 20
                .RowTemplate.Height = 25
                .RowHeadersVisible = False
                .RowHeadersBorderStyle = BorderStyle.FixedSingle
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True
                .MultiSelect = False
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub EkporDGV_ke_Excel(ByVal DataGridView1 As DataGridView, ByVal NamaLokasiFile As String)

        Try
            If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then
                Exit Sub
            End If

            Dim dset As New DataSet 'Creating dataset to export
            dset.Tables.Add() 'add table to dataset
            'add column to that table
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
            Next
            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridView1.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    dr1(j) = DataGridView1.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim excel As New excel.Application
            Dim wBook As excel.Workbook
            Dim wSheet As excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            wSheet.Columns.AutoFit()
            Dim strFileName As String = NamaLokasiFile
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            excel.Workbooks.Open(strFileName)
            excel.Visible = True

        Catch ex As Exception
            MsgBox(" Ekspor ke file excel gagal !  " & Err.Description, vbExclamation, "Informasi")
        End Try
    End Sub

    Public Function convertbln_angkaketext(ByVal bln As String) As String
        Dim nil As String = ""
        Select Case bln
            Case "01"
                nil = "Januari"
            Case "02"
                nil = "Februari"
            Case "03"
                nil = "Maret"
            Case "04"
                nil = "April"
            Case "05"
                nil = "Mei"
            Case "06"
                nil = "Juni"
            Case "07"
                nil = "Juli"
            Case "08"
                nil = "Agustus"
            Case "09"
                nil = "September"
            Case "10"
                nil = "Oktober"
            Case "11"
                nil = "Nopember"
            Case "12"
                nil = "Desember"
        End Select
        Return nil
    End Function

    Public Function convertbln_textkeangka(ByVal bln As String) As String
        Dim nil As String = ""
        Select Case bln
            Case "Januari"
                nil = "01"
            Case "Februari"
                nil = "02"
            Case "Maret"
                nil = "03"
            Case "April"
                nil = "04"
            Case "Mei"
                nil = "05"
            Case "Juni"
                nil = "06"
            Case "Juli"
                nil = "07"
            Case "Agustus"
                nil = "08"
            Case "September"
                nil = "09"
            Case "Oktober"
                nil = "10"
            Case "Nopember"
                nil = "11"
            Case "Desember"
                nil = "12"
        End Select
        Return nil
    End Function

End Module
