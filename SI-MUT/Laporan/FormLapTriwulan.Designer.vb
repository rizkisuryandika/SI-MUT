<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLapTriwulan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.TX_cari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBRuang = New System.Windows.Forms.ComboBox()
        Me.cb_tahun = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb_triwulan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.semua = New System.Windows.Forms.CheckBox()
        Me.cb_cari = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(510, 56)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(91, 33)
        Me.btn_refresh.TabIndex = 1
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'TX_cari
        '
        Me.TX_cari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_cari.Location = New System.Drawing.Point(243, 66)
        Me.TX_cari.Name = "TX_cari"
        Me.TX_cari.Size = New System.Drawing.Size(261, 23)
        Me.TX_cari.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pencarian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tahun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ruang"
        '
        'CBRuang
        '
        Me.CBRuang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRuang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBRuang.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRuang.FormattingEnabled = True
        Me.CBRuang.Location = New System.Drawing.Point(170, 6)
        Me.CBRuang.Name = "CBRuang"
        Me.CBRuang.Size = New System.Drawing.Size(334, 24)
        Me.CBRuang.TabIndex = 7
        '
        'cb_tahun
        '
        Me.cb_tahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tahun.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tahun.FormattingEnabled = True
        Me.cb_tahun.Location = New System.Drawing.Point(105, 36)
        Me.cb_tahun.Name = "cb_tahun"
        Me.cb_tahun.Size = New System.Drawing.Size(127, 24)
        Me.cb_tahun.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(607, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Export To Excel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cb_triwulan
        '
        Me.cb_triwulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_triwulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_triwulan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_triwulan.FormattingEnabled = True
        Me.cb_triwulan.Items.AddRange(New Object() {"Semua", "Triwulan 1", "Triwulan 2", "Triwulan 3", "Triwulan 4"})
        Me.cb_triwulan.Location = New System.Drawing.Point(312, 36)
        Me.cb_triwulan.Name = "cb_triwulan"
        Me.cb_triwulan.Size = New System.Drawing.Size(192, 24)
        Me.cb_triwulan.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Triwulan"
        '
        'Timer1
        '
        '
        'semua
        '
        Me.semua.AutoSize = True
        Me.semua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.semua.Location = New System.Drawing.Point(105, 10)
        Me.semua.Name = "semua"
        Me.semua.Size = New System.Drawing.Size(56, 17)
        Me.semua.TabIndex = 19
        Me.semua.Text = "Semua"
        Me.semua.UseVisualStyleBackColor = True
        '
        'cb_cari
        '
        Me.cb_cari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_cari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cari.FormattingEnabled = True
        Me.cb_cari.Items.AddRange(New Object() {"NAMA_RUANG", "JUDUL_INDIKATOR"})
        Me.cb_cari.Location = New System.Drawing.Point(105, 66)
        Me.cb_cari.Name = "cb_cari"
        Me.cb_cari.Size = New System.Drawing.Size(127, 24)
        Me.cb_cari.TabIndex = 17
        '
        'FormLapTriwulan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1032, 461)
        Me.Controls.Add(Me.semua)
        Me.Controls.Add(Me.TX_cari)
        Me.Controls.Add(Me.cb_triwulan)
        Me.Controls.Add(Me.cb_cari)
        Me.Controls.Add(Me.cb_tahun)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBRuang)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLapTriwulan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Triwulan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_refresh As Button
    Friend WithEvents TX_cari As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBRuang As ComboBox
    Friend WithEvents cb_tahun As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cb_triwulan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents semua As CheckBox
    Friend WithEvents cb_cari As ComboBox
End Class
