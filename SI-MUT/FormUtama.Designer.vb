<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndikatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndikatorMutuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndikatorMutuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TriwulanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lb_datetime = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(81, 26)
        '
        'FToolStripMenuItem
        '
        Me.FToolStripMenuItem.Name = "FToolStripMenuItem"
        Me.FToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.FToolStripMenuItem.Text = "F"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.InputToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.UtilityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(642, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(124, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KategoriToolStripMenuItem, Me.IndikatorToolStripMenuItem, Me.IndikatorMutuToolStripMenuItem, Me.RuangToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'IndikatorToolStripMenuItem
        '
        Me.IndikatorToolStripMenuItem.Name = "IndikatorToolStripMenuItem"
        Me.IndikatorToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.IndikatorToolStripMenuItem.Text = "Jenis"
        '
        'IndikatorMutuToolStripMenuItem
        '
        Me.IndikatorMutuToolStripMenuItem.Name = "IndikatorMutuToolStripMenuItem"
        Me.IndikatorMutuToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.IndikatorMutuToolStripMenuItem.Text = "Indikator Mutu"
        '
        'RuangToolStripMenuItem
        '
        Me.RuangToolStripMenuItem.Name = "RuangToolStripMenuItem"
        Me.RuangToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.RuangToolStripMenuItem.Text = "Ruang"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndikatorMutuToolStripMenuItem1})
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'IndikatorMutuToolStripMenuItem1
        '
        Me.IndikatorMutuToolStripMenuItem1.Name = "IndikatorMutuToolStripMenuItem1"
        Me.IndikatorMutuToolStripMenuItem1.Size = New System.Drawing.Size(182, 24)
        Me.IndikatorMutuToolStripMenuItem1.Text = "Indikator Mutu"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulananToolStripMenuItem, Me.TriwulanToolStripMenuItem, Me.TahunanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'BulananToolStripMenuItem
        '
        Me.BulananToolStripMenuItem.Name = "BulananToolStripMenuItem"
        Me.BulananToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.BulananToolStripMenuItem.Text = "Bulanan"
        '
        'TriwulanToolStripMenuItem
        '
        Me.TriwulanToolStripMenuItem.Name = "TriwulanToolStripMenuItem"
        Me.TriwulanToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.TriwulanToolStripMenuItem.Text = "Triwulan"
        '
        'TahunanToolStripMenuItem
        '
        Me.TahunanToolStripMenuItem.Name = "TahunanToolStripMenuItem"
        Me.TahunanToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.TahunanToolStripMenuItem.Text = "Tahunan"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tes Koneksi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(19, 160)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(603, 150)
        Me.DGV1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(547, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Show User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lb_datetime
        '
        Me.lb_datetime.BackColor = System.Drawing.Color.Transparent
        Me.lb_datetime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lb_datetime.Location = New System.Drawing.Point(463, 27)
        Me.lb_datetime.Name = "lb_datetime"
        Me.lb_datetime.Size = New System.Drawing.Size(176, 25)
        Me.lb_datetime.TabIndex = 5
        Me.lb_datetime.Text = "datetime"
        Me.lb_datetime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(642, 322)
        Me.Controls.Add(Me.lb_datetime)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SI-MUT"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndikatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndikatorMutuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RuangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndikatorMutuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lb_datetime As Label
    Friend WithEvents BulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TriwulanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TahunanToolStripMenuItem As ToolStripMenuItem
End Class
