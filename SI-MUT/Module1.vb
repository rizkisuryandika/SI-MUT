Imports MySql.Data.MySqlClient

Module Module1

    Function StrKoneksi() As String
        'Dim cb As MySqlBaseConnectionStringBuilder
        'cb.Server = "localhost"
        'cb.UserID = "root"
        'cb.Password = ""
        'cb.SslMode = "none"
        'StrKoneksi = cb.ToString
        StrKoneksi = "server=localhost;
                        uid=root;
                        pwd=;
                        database=dbmutu;
                        sslMode=none"

    End Function

    Function ekSkalar(ByVal sqlNya As String) As String
        Using kon As New MySqlConnection(StrKoneksi)
            kon.Open()
            Dim cmd As New MySqlCommand(sqlNya, kon)
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

End Module
