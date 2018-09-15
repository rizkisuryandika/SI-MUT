<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMastIndikator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clb_inruang = New System.Windows.Forms.CheckedListBox()
        Me.tx_denumerator = New System.Windows.Forms.RichTextBox()
        Me.tx_numerator = New System.Windows.Forms.RichTextBox()
        Me.tx_judul = New System.Windows.Forms.RichTextBox()
        Me.tx_satuan = New System.Windows.Forms.ComboBox()
        Me.cb_kategori = New System.Windows.Forms.ComboBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.cb_jenis = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Kategori = New System.Windows.Forms.Label()
        Me.lb_Jenis = New System.Windows.Forms.Label()
        Me.ID_INDIKATOR = New System.Windows.Forms.TextBox()
        Me.tx_standart = New System.Windows.Forms.TextBox()
        Me.Kode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonBaru = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.clb_inruang)
        Me.Panel1.Controls.Add(Me.tx_denumerator)
        Me.Panel1.Controls.Add(Me.tx_numerator)
        Me.Panel1.Controls.Add(Me.tx_judul)
        Me.Panel1.Controls.Add(Me.tx_satuan)
        Me.Panel1.Controls.Add(Me.cb_kategori)
        Me.Panel1.Controls.Add(Me.cb_status)
        Me.Panel1.Controls.Add(Me.cb_jenis)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Kategori)
        Me.Panel1.Controls.Add(Me.lb_Jenis)
        Me.Panel1.Controls.Add(Me.ID_INDIKATOR)
        Me.Panel1.Controls.Add(Me.tx_standart)
        Me.Panel1.Controls.Add(Me.Kode)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 344)
        Me.Panel1.TabIndex = 0
        '
        'clb_inruang
        '
        Me.clb_inruang.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_inruang.FormattingEnabled = True
        Me.clb_inruang.Location = New System.Drawing.Point(242, 257)
        Me.clb_inruang.Name = "clb_inruang"
        Me.clb_inruang.Size = New System.Drawing.Size(155, 76)
        Me.clb_inruang.TabIndex = 9
        '
        'tx_denumerator
        '
        Me.tx_denumerator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_denumerator.Location = New System.Drawing.Point(119, 197)
        Me.tx_denumerator.Name = "tx_denumerator"
        Me.tx_denumerator.Size = New System.Drawing.Size(578, 54)
        Me.tx_denumerator.TabIndex = 5
        Me.tx_denumerator.Text = ""
        '
        'tx_numerator
        '
        Me.tx_numerator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_numerator.Location = New System.Drawing.Point(119, 135)
        Me.tx_numerator.Name = "tx_numerator"
        Me.tx_numerator.Size = New System.Drawing.Size(578, 54)
        Me.tx_numerator.TabIndex = 4
        Me.tx_numerator.Text = ""
        '
        'tx_judul
        '
        Me.tx_judul.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_judul.Location = New System.Drawing.Point(119, 73)
        Me.tx_judul.Name = "tx_judul"
        Me.tx_judul.Size = New System.Drawing.Size(578, 54)
        Me.tx_judul.TabIndex = 3
        Me.tx_judul.Text = ""
        '
        'tx_satuan
        '
        Me.tx_satuan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_satuan.FormattingEnabled = True
        Me.tx_satuan.Items.AddRange(New Object() {"Persen", "Permil"})
        Me.tx_satuan.Location = New System.Drawing.Point(119, 257)
        Me.tx_satuan.Name = "tx_satuan"
        Me.tx_satuan.Size = New System.Drawing.Size(100, 24)
        Me.tx_satuan.TabIndex = 2
        '
        'cb_kategori
        '
        Me.cb_kategori.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kategori.FormattingEnabled = True
        Me.cb_kategori.Location = New System.Drawing.Point(119, 46)
        Me.cb_kategori.Name = "cb_kategori"
        Me.cb_kategori.Size = New System.Drawing.Size(335, 24)
        Me.cb_kategori.TabIndex = 2
        '
        'cb_status
        '
        Me.cb_status.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Location = New System.Drawing.Point(119, 309)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(100, 24)
        Me.cb_status.TabIndex = 8
        '
        'cb_jenis
        '
        Me.cb_jenis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Location = New System.Drawing.Point(119, 19)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(335, 24)
        Me.cb_jenis.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Denumerator"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numerator"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul Indikator"
        '
        'Kategori
        '
        Me.Kategori.AutoSize = True
        Me.Kategori.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kategori.Location = New System.Drawing.Point(23, 49)
        Me.Kategori.Name = "Kategori"
        Me.Kategori.Size = New System.Drawing.Size(55, 16)
        Me.Kategori.TabIndex = 0
        Me.Kategori.Text = "Kategori"
        '
        'lb_Jenis
        '
        Me.lb_Jenis.AutoSize = True
        Me.lb_Jenis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Jenis.Location = New System.Drawing.Point(23, 25)
        Me.lb_Jenis.Name = "lb_Jenis"
        Me.lb_Jenis.Size = New System.Drawing.Size(36, 16)
        Me.lb_Jenis.TabIndex = 0
        Me.lb_Jenis.Text = "Jenis"
        '
        'ID_INDIKATOR
        '
        Me.ID_INDIKATOR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_INDIKATOR.Location = New System.Drawing.Point(547, 19)
        Me.ID_INDIKATOR.Name = "ID_INDIKATOR"
        Me.ID_INDIKATOR.Size = New System.Drawing.Size(150, 23)
        Me.ID_INDIKATOR.TabIndex = 1
        '
        'tx_standart
        '
        Me.tx_standart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_standart.Location = New System.Drawing.Point(119, 283)
        Me.tx_standart.Name = "tx_standart"
        Me.tx_standart.Size = New System.Drawing.Size(100, 23)
        Me.tx_standart.TabIndex = 7
        '
        'Kode
        '
        Me.Kode.AutoSize = True
        Me.Kode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(486, 19)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(36, 16)
        Me.Kode.TabIndex = 0
        Me.Kode.Text = "Kode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Standar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Satuan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonBatal)
        Me.GroupBox1.Controls.Add(Me.ButtonBaru)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(468, 19)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(90, 35)
        Me.ButtonHapus.TabIndex = 12
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(355, 19)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(90, 35)
        Me.ButtonBatal.TabIndex = 11
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonBaru
        '
        Me.ButtonBaru.Location = New System.Drawing.Point(129, 19)
        Me.ButtonBaru.Name = "ButtonBaru"
        Me.ButtonBaru.Size = New System.Drawing.Size(90, 35)
        Me.ButtonBaru.TabIndex = 9
        Me.ButtonBaru.Text = "BARU"
        Me.ButtonBaru.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(242, 19)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(90, 35)
        Me.ButtonSimpan.TabIndex = 9
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(9, 429)
        Me.DGV1.MultiSelect = False
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(718, 221)
        Me.DGV1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(403, 257)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 69)
        Me.ListBox1.TabIndex = 10
        '
        'FormMastIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 662)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMastIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Indikator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_denumerator As RichTextBox
    Friend WithEvents tx_numerator As RichTextBox
    Friend WithEvents tx_judul As RichTextBox
    Friend WithEvents cb_kategori As ComboBox
    Friend WithEvents cb_jenis As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Kategori As Label
    Friend WithEvents lb_Jenis As Label
    Friend WithEvents tx_standart As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ID_INDIKATOR As TextBox
    Friend WithEvents Kode As Label
    Protected WithEvents DGV1 As DataGridView
    Friend WithEvents clb_inruang As CheckedListBox
    Friend WithEvents ButtonBaru As Button
    Friend WithEvents tx_satuan As ComboBox
    Friend WithEvents ListBox1 As ListBox
End Class
