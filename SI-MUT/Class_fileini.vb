Public Class Class_fileini
#Region "API Calls"
    ' standard API declarations for INI access
    ' changing only "As Long" to "As Int32" (As Integer would work also)
    '-------------------------------------------------------------------
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
        Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpString As String,
        ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
        Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpDefault As String,
        ByVal lpReturnedString As String, ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
#End Region

    Private Function INIRead(ByVal INIPath As String,
                             ByVal SectionName As String,
                             ByVal KeyName As String,
                             ByVal DefaultValue As String) As String
        Dim n As Int32
        Dim sData As String
        sData = Space(1024)
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, sData, sData.Length, INIPath)
        If n > 0 Then
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function

    Public Function Baca_file_ini_perbaris(ByVal filepathnya As String, ByVal Kepalanya As String, ByVal subnya As String) As String
        Return INIRead(filepathnya, Kepalanya, subnya, "")
    End Function

    Public Function Baca_file_ini_perinduk(ByVal filepathnya As String, ByVal Kepalanya As String) As String
        Return INIRead(filepathnya, Kepalanya, Nothing, "")
    End Function

    Public Function Baca_file_ini_semuaisi(ByVal filepathnya As String) As String
        Return INIRead(filepathnya, Nothing, Nothing, "")
    End Function

    Public Sub Tulis_file_ini_perbaris(ByVal filepathnya As String, ByVal Kepalanya As String, ByVal subnya As String, ByVal isinya As String)
        Call WritePrivateProfileString(Kepalanya, subnya, isinya, filepathnya)
    End Sub

    Public Sub Hapus_file_ini_perbaris(ByVal filepathnya As String, ByVal Kepalanya As String, ByVal subnya As String) ' delete single line from section
        Call WritePrivateProfileString(Kepalanya, subnya, Nothing, filepathnya)
    End Sub

    Public Sub Hapus_file_ini_semuaisi(ByVal filepathnya As String, ByVal Kepalanya As String)
        Call WritePrivateProfileString(Nothing, Nothing, Nothing, filepathnya)
    End Sub
End Class
