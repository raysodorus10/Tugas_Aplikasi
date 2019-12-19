<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanStockMinuman
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSemua = New System.Windows.Forms.RadioButton()
        Me.rbSet = New System.Windows.Forms.RadioButton()
        Me.cmbSetJumlah = New System.Windows.Forms.ComboBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSetJumlah)
        Me.GroupBox1.Controls.Add(Me.rbSet)
        Me.GroupBox1.Controls.Add(Me.rbSemua)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Filter |"
        '
        'rbSemua
        '
        Me.rbSemua.AutoSize = True
        Me.rbSemua.Location = New System.Drawing.Point(31, 32)
        Me.rbSemua.Name = "rbSemua"
        Me.rbSemua.Size = New System.Drawing.Size(134, 21)
        Me.rbSemua.TabIndex = 0
        Me.rbSemua.TabStop = True
        Me.rbSemua.Text = "Semua Minuman"
        Me.rbSemua.UseVisualStyleBackColor = True
        '
        'rbSet
        '
        Me.rbSet.Location = New System.Drawing.Point(31, 60)
        Me.rbSet.Name = "rbSet"
        Me.rbSet.Size = New System.Drawing.Size(128, 24)
        Me.rbSet.TabIndex = 1
        Me.rbSet.TabStop = True
        Me.rbSet.Text = "Set Jumlah <="
        Me.rbSet.UseVisualStyleBackColor = True
        '
        'cmbSetJumlah
        '
        Me.cmbSetJumlah.FormattingEnabled = True
        Me.cmbSetJumlah.Location = New System.Drawing.Point(165, 60)
        Me.cmbSetJumlah.Name = "cmbSetJumlah"
        Me.cmbSetJumlah.Size = New System.Drawing.Size(181, 24)
        Me.cmbSetJumlah.TabIndex = 2
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(43, 121)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(122, 55)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(190, 121)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(122, 55)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'frmLaporanStockMinuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 184)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLaporanStockMinuman"
        Me.Text = "F_LaporanStockMinuman"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSetJumlah As System.Windows.Forms.ComboBox
    Friend WithEvents rbSet As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemua As System.Windows.Forms.RadioButton
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
