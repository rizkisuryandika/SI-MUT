<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGrafikHarian
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
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.semua = New System.Windows.Forms.CheckBox()
        Me.cb_bln = New System.Windows.Forms.ComboBox()
        Me.cb_tahun = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_ruang = New System.Windows.Forms.ComboBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.cb_indikator = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
        Me.Chart1.Location = New System.Drawing.Point(12, 100)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.Chart1.Size = New System.Drawing.Size(801, 337)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(722, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save As Image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(625, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(528, 444)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'semua
        '
        Me.semua.AutoSize = True
        Me.semua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.semua.Location = New System.Drawing.Point(72, 10)
        Me.semua.Name = "semua"
        Me.semua.Size = New System.Drawing.Size(56, 17)
        Me.semua.TabIndex = 29
        Me.semua.Text = "Semua"
        Me.semua.UseVisualStyleBackColor = True
        '
        'cb_bln
        '
        Me.cb_bln.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_bln.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_bln.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_bln.FormattingEnabled = True
        Me.cb_bln.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember"})
        Me.cb_bln.Location = New System.Drawing.Point(72, 66)
        Me.cb_bln.Name = "cb_bln"
        Me.cb_bln.Size = New System.Drawing.Size(161, 24)
        Me.cb_bln.TabIndex = 26
        '
        'cb_tahun
        '
        Me.cb_tahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tahun.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tahun.FormattingEnabled = True
        Me.cb_tahun.Location = New System.Drawing.Point(239, 66)
        Me.cb_tahun.Name = "cb_tahun"
        Me.cb_tahun.Size = New System.Drawing.Size(96, 24)
        Me.cb_tahun.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Bulan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ruang"
        '
        'cb_ruang
        '
        Me.cb_ruang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ruang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_ruang.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ruang.FormattingEnabled = True
        Me.cb_ruang.Location = New System.Drawing.Point(137, 6)
        Me.cb_ruang.Name = "cb_ruang"
        Me.cb_ruang.Size = New System.Drawing.Size(494, 24)
        Me.cb_ruang.TabIndex = 21
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(341, 65)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(96, 24)
        Me.btn_refresh.TabIndex = 20
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'cb_indikator
        '
        Me.cb_indikator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_indikator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_indikator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_indikator.FormattingEnabled = True
        Me.cb_indikator.Location = New System.Drawing.Point(72, 36)
        Me.cb_indikator.Name = "cb_indikator"
        Me.cb_indikator.Size = New System.Drawing.Size(559, 24)
        Me.cb_indikator.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Indikator"
        '
        'FormGrafikHarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(826, 489)
        Me.Controls.Add(Me.semua)
        Me.Controls.Add(Me.cb_bln)
        Me.Controls.Add(Me.cb_indikator)
        Me.Controls.Add(Me.cb_tahun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_ruang)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGrafikHarian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grafik Per Hari"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents semua As CheckBox
    Friend WithEvents cb_bln As ComboBox
    Friend WithEvents cb_tahun As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_ruang As ComboBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents cb_indikator As ComboBox
    Friend WithEvents Label3 As Label
End Class
