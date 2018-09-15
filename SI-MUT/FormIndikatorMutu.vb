Imports MySql.Data.MySqlClient

Public Class FormIndikatorMutu
    Sub KondisiAwal()
        Dim Dt As New DataTable
        Dim Da As New MySqlDataAdapter("select ID,KATEGORI,JUDUL from tab_indikator", StrKoneksi)
        Da.Fill(Dt)
        DGV1.DataSource = Dt


        TextBox2.Enabled = False
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox4.Text = ""
        RichTextBox1.Enabled = False
        RichTextBox2.Enabled = False
        RichTextBox3.Enabled = False
        DGV1.ReadOnly = True

    End Sub
    Sub IsiComboRuang()
        Try
            Dim Dt As New DataTable
            Using Da As New MySqlDataAdapter("select * from tab_ruang", StrKoneksi)
                Da.Fill(Dt)
                With ComboBox1
                    .DataSource = Dt
                    .ValueMember = "ID_RUANG"
                    .DisplayMember = "NAMA_RUANG"
                End With
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub nomorTrans()
        Dim nomor As Integer
        Dim tgl As Integer
        Dim unik As Integer
        Try
            nomor = ekSkalar("select left(max(NOTRANS),3) from tab_hasil")
            tgl = ekSkalar("select right(max(NOTRANS),6) from tab_hasil")
            unik = Format(Now, "yyMMdd")
        Catch ex As Exception
            nomor = 0
        End Try
        'If nomor = 0 Then
        '    Label8.Text = "001IM-" & Format(Now, "yyMMdd")
        'ElseIf tgl = unik Then
        '    Label8.Text = Format(CInt(nomor) + 1, "000") & "IM-" & Format(Now, "yyMMdd")
        'Else
        '    Label8.Text = "001IM-" & Format(Now, "yyMMdd")
        'End If
        If Not tgl = unik Then
            Label8.Text = "001IM-" & Format(Now, "yyMMdd")
        Else
            Label8.Text = Format(CInt(nomor) + 1, "000") & "IM-" & Format(Now, "yyMMdd")
        End If

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call nomorTrans()
        Call IsiComboRuang()
    End Sub

    'Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
    '    Dim i As Integer
    '    i = DGV1.CurrentRow.Index
    '    TextBox2.Text = DGV1.Item(0, i).Value
    'End Sub

    Private Sub DGV1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        Dim i As Integer
        Dim RD As MySqlDataReader
        i = DGV1.CurrentRow.Index
        Using kon As New MySqlConnection(StrKoneksi)
            kon.Open()
            Dim cmd As New MySqlCommand("select * from tab_indikator where ID='" & DGV1.Item(0, i).Value & "'", kon)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                TextBox2.Focus()
            Else
                TextBox2.Text = RD.Item("ID")
                RichTextBox1.Text = RD.Item("JUDUL")
                RichTextBox2.Text = RD.Item("NUMERATOR")
                RichTextBox3.Text = RD.Item("DENUMERATOR")
                TextBox3.Focus()
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim hasil As String
            hasil = TextBox3.Text / TextBox4.Text * 100
            Using kon As New MySqlConnection(StrKoneksi)
                kon.Open()
                Dim sqlku As String = "insert into tab_hasil (NOTRANS,ID,TGL,NUMERATOR,DENUMERATOR,HASIL)
                                         values
                                            (
                                            '" & Label8.Text & "',
                                            '" & TextBox2.Text & "',
                                            '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "',
                                            '" & TextBox3.Text & "',
                                            '" & TextBox4.Text & "',
                                            '" & hasil & "'
                                                )"
                Dim cmd As New MySqlCommand(sqlku, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan")
                Call KondisiAwal()
                Call nomorTrans()
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim Dt As New DataTable
        Dim Da As New MySqlDataAdapter("SELECT ID,JUDUL,NUMERATOR,DENUMERATOR FROM tab_indikator left OUTER JOIN tab_indruang on tab_indikator.ID = tab_indruang.ID_INDIKATOR WHERE tab_indruang.ID_RUANG ='" & ComboBox1.SelectedValue.ToString() & "'", StrKoneksi)
        Da.Fill(Dt)
        DGV1.DataSource = Dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(ComboBox1.SelectedValue.ToString())
    End Sub
End Class