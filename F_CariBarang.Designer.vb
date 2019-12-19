<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariNamaMenu = New System.Windows.Forms.TextBox()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.btnPilih = New System.Windows.Forms.Button()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Nama Menu"
        '
        'txtCariNamaMenu
        '
        Me.txtCariNamaMenu.Location = New System.Drawing.Point(133, 13)
        Me.txtCariNamaMenu.Name = "txtCariNamaMenu"
        Me.txtCariNamaMenu.Size = New System.Drawing.Size(859, 22)
        Me.txtCariNamaMenu.TabIndex = 1
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(4, 51)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.RowTemplate.Height = 24
        Me.dgvMenu.Size = New System.Drawing.Size(1001, 415)
        Me.dgvMenu.TabIndex = 2
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(4, 473)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(1001, 38)
        Me.btnPilih.TabIndex = 3
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'frmCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 523)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.txtCariNamaMenu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCariBarang"
        Me.Text = "F_CariBarang"
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariNamaMenu As System.Windows.Forms.TextBox
    Friend WithEvents dgvMenu As System.Windows.Forms.DataGridView
    Friend WithEvents btnPilih As System.Windows.Forms.Button
End Class
