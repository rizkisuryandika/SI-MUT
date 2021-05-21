<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMastRuang
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
        Me.tx_kode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_ruang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBaru = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tx_kode
        '
        Me.tx_kode.Location = New System.Drawing.Point(75, 12)
        Me.tx_kode.Name = "tx_kode"
        Me.tx_kode.Size = New System.Drawing.Size(149, 20)
        Me.tx_kode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'tx_ruang
        '
        Me.tx_ruang.Location = New System.Drawing.Point(75, 38)
        Me.tx_ruang.Multiline = True
        Me.tx_ruang.Name = "tx_ruang"
        Me.tx_ruang.Size = New System.Drawing.Size(271, 50)
        Me.tx_ruang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label1"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(257, 94)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(90, 35)
        Me.ButtonHapus.TabIndex = 15
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        Me.ButtonHapus.Visible = False
        '
        'ButtonBaru
        '
        Me.ButtonBaru.Location = New System.Drawing.Point(13, 94)
        Me.ButtonBaru.Name = "ButtonBaru"
        Me.ButtonBaru.Size = New System.Drawing.Size(90, 35)
        Me.ButtonBaru.TabIndex = 13
        Me.ButtonBaru.Text = "BARU"
        Me.ButtonBaru.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(135, 94)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(90, 35)
        Me.ButtonSimpan.TabIndex = 14
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(12, 135)
        Me.DGV1.MultiSelect = False
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(335, 246)
        Me.DGV1.TabIndex = 16
        '
        'FormMastRuang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 393)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonBaru)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tx_ruang)
        Me.Controls.Add(Me.tx_kode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMastRuang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RUANG"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx_kode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_ruang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonBaru As Button
    Friend WithEvents ButtonSimpan As Button
    Protected WithEvents DGV1 As DataGridView
End Class
