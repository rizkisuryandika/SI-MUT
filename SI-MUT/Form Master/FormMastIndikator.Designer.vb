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
        Me.components = New System.ComponentModel.Container()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.btn_addruang = New System.Windows.Forms.Button()
        Me.btn_minruang = New System.Windows.Forms.Button()
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
        Me.ButtonBaru = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.lsb_ruang = New System.Windows.Forms.ListBox()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.tx_judul = New System.Windows.Forms.TextBox()
        Me.tx_numerator = New System.Windows.Forms.TextBox()
        Me.tx_denumerator = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tx_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AllowUserToResizeRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(378, 259)
        Me.DGV2.MultiSelect = False
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.RowHeadersVisible = False
        Me.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV2.Size = New System.Drawing.Size(249, 83)
        Me.DGV2.TabIndex = 2
        '
        'btn_addruang
        '
        Me.btn_addruang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addruang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addruang.Location = New System.Drawing.Point(633, 259)
        Me.btn_addruang.Name = "btn_addruang"
        Me.btn_addruang.Size = New System.Drawing.Size(33, 33)
        Me.btn_addruang.TabIndex = 9
        Me.btn_addruang.Text = "+"
        Me.btn_addruang.UseVisualStyleBackColor = True
        '
        'btn_minruang
        '
        Me.btn_minruang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minruang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minruang.Location = New System.Drawing.Point(633, 310)
        Me.btn_minruang.Name = "btn_minruang"
        Me.btn_minruang.Size = New System.Drawing.Size(33, 33)
        Me.btn_minruang.TabIndex = 9
        Me.btn_minruang.Text = "-"
        Me.btn_minruang.UseVisualStyleBackColor = True
        '
        'tx_satuan
        '
        Me.tx_satuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tx_satuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tx_satuan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_satuan.FormattingEnabled = True
        Me.tx_satuan.Items.AddRange(New Object() {"Persen", "Permil"})
        Me.tx_satuan.Location = New System.Drawing.Point(114, 259)
        Me.tx_satuan.Name = "tx_satuan"
        Me.tx_satuan.Size = New System.Drawing.Size(239, 24)
        Me.tx_satuan.TabIndex = 2
        '
        'cb_kategori
        '
        Me.cb_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_kategori.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kategori.FormattingEnabled = True
        Me.cb_kategori.Location = New System.Drawing.Point(114, 52)
        Me.cb_kategori.Name = "cb_kategori"
        Me.cb_kategori.Size = New System.Drawing.Size(335, 24)
        Me.cb_kategori.TabIndex = 2
        '
        'cb_status
        '
        Me.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_status.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cb_status.Location = New System.Drawing.Point(114, 318)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(239, 24)
        Me.cb_status.TabIndex = 8
        '
        'cb_jenis
        '
        Me.cb_jenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_jenis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Location = New System.Drawing.Point(114, 22)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(335, 24)
        Me.cb_jenis.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Denumerator"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numerator"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul Indikator"
        '
        'Kategori
        '
        Me.Kategori.AutoSize = True
        Me.Kategori.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kategori.Location = New System.Drawing.Point(18, 55)
        Me.Kategori.Name = "Kategori"
        Me.Kategori.Size = New System.Drawing.Size(55, 16)
        Me.Kategori.TabIndex = 0
        Me.Kategori.Text = "Kategori"
        '
        'lb_Jenis
        '
        Me.lb_Jenis.AutoSize = True
        Me.lb_Jenis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Jenis.Location = New System.Drawing.Point(18, 25)
        Me.lb_Jenis.Name = "lb_Jenis"
        Me.lb_Jenis.Size = New System.Drawing.Size(36, 16)
        Me.lb_Jenis.TabIndex = 0
        Me.lb_Jenis.Text = "Jenis"
        '
        'ID_INDIKATOR
        '
        Me.ID_INDIKATOR.BackColor = System.Drawing.Color.White
        Me.ID_INDIKATOR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_INDIKATOR.Location = New System.Drawing.Point(516, 22)
        Me.ID_INDIKATOR.Name = "ID_INDIKATOR"
        Me.ID_INDIKATOR.ReadOnly = True
        Me.ID_INDIKATOR.Size = New System.Drawing.Size(150, 27)
        Me.ID_INDIKATOR.TabIndex = 1
        '
        'tx_standart
        '
        Me.tx_standart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_standart.Location = New System.Drawing.Point(114, 289)
        Me.tx_standart.Name = "tx_standart"
        Me.tx_standart.Size = New System.Drawing.Size(239, 23)
        Me.tx_standart.TabIndex = 7
        '
        'Kode
        '
        Me.Kode.AutoSize = True
        Me.Kode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(477, 28)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(36, 16)
        Me.Kode.TabIndex = 0
        Me.Kode.Text = "Kode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Standar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Satuan"
        '
        'ButtonBaru
        '
        Me.ButtonBaru.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonBaru.FlatAppearance.BorderSize = 0
        Me.ButtonBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBaru.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBaru.ForeColor = System.Drawing.Color.White
        Me.ButtonBaru.Location = New System.Drawing.Point(21, 358)
        Me.ButtonBaru.Name = "ButtonBaru"
        Me.ButtonBaru.Size = New System.Drawing.Size(90, 35)
        Me.ButtonBaru.TabIndex = 9
        Me.ButtonBaru.Text = "BARU"
        Me.ButtonBaru.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonSimpan.FlatAppearance.BorderSize = 0
        Me.ButtonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSimpan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.ForeColor = System.Drawing.Color.White
        Me.ButtonSimpan.Location = New System.Drawing.Point(142, 358)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(90, 35)
        Me.ButtonSimpan.TabIndex = 9
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(9, 438)
        Me.DGV1.MultiSelect = False
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(674, 212)
        Me.DGV1.TabIndex = 2
        '
        'lsb_ruang
        '
        Me.lsb_ruang.FormattingEnabled = True
        Me.lsb_ruang.Location = New System.Drawing.Point(378, 348)
        Me.lsb_ruang.Name = "lsb_ruang"
        Me.lsb_ruang.Size = New System.Drawing.Size(288, 17)
        Me.lsb_ruang.TabIndex = 10
        Me.lsb_ruang.Visible = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonHapus.FlatAppearance.BorderSize = 0
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.White
        Me.ButtonHapus.Location = New System.Drawing.Point(263, 358)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(90, 35)
        Me.ButtonHapus.TabIndex = 12
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        Me.ButtonHapus.Visible = False
        '
        'tx_judul
        '
        Me.tx_judul.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_judul.Location = New System.Drawing.Point(114, 82)
        Me.tx_judul.Multiline = True
        Me.tx_judul.Name = "tx_judul"
        Me.tx_judul.Size = New System.Drawing.Size(552, 53)
        Me.tx_judul.TabIndex = 1
        '
        'tx_numerator
        '
        Me.tx_numerator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_numerator.Location = New System.Drawing.Point(114, 141)
        Me.tx_numerator.Multiline = True
        Me.tx_numerator.Name = "tx_numerator"
        Me.tx_numerator.Size = New System.Drawing.Size(552, 53)
        Me.tx_numerator.TabIndex = 1
        '
        'tx_denumerator
        '
        Me.tx_denumerator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_denumerator.Location = New System.Drawing.Point(114, 200)
        Me.tx_denumerator.Multiline = True
        Me.tx_denumerator.Name = "tx_denumerator"
        Me.tx_denumerator.Size = New System.Drawing.Size(552, 53)
        Me.tx_denumerator.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(560, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "M. KATEGORI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(448, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "M. JENIS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tx_cari
        '
        Me.tx_cari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cari.Location = New System.Drawing.Point(114, 409)
        Me.tx_cari.Name = "tx_cari"
        Me.tx_cari.Size = New System.Drawing.Size(552, 23)
        Me.tx_cari.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Pencarian"
        '
        'Timer1
        '
        '
        'FormMastIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(690, 662)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.lsb_ruang)
        Me.Controls.Add(Me.btn_addruang)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btn_minruang)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonBaru)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.tx_satuan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb_kategori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_jenis)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tx_cari)
        Me.Controls.Add(Me.tx_standart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_denumerator)
        Me.Controls.Add(Me.tx_numerator)
        Me.Controls.Add(Me.tx_judul)
        Me.Controls.Add(Me.ID_INDIKATOR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_Jenis)
        Me.Controls.Add(Me.Kategori)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMastIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "S"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_kategori As ComboBox
    Friend WithEvents cb_jenis As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Kategori As Label
    Friend WithEvents lb_Jenis As Label
    Friend WithEvents tx_standart As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ID_INDIKATOR As TextBox
    Friend WithEvents Kode As Label
    Protected WithEvents DGV1 As DataGridView
    Friend WithEvents ButtonBaru As Button
    Friend WithEvents tx_satuan As ComboBox
    Protected WithEvents DGV2 As DataGridView
    Friend WithEvents btn_minruang As Button
    Friend WithEvents btn_addruang As Button
    Friend WithEvents lsb_ruang As ListBox
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents tx_judul As TextBox
    Friend WithEvents tx_numerator As TextBox
    Friend WithEvents tx_denumerator As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tx_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class
