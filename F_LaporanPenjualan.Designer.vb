<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanPenjualan
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
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSemua = New System.Windows.Forms.RadioButton()
        Me.rbMakanTempat = New System.Windows.Forms.RadioButton()
        Me.rbBungkus = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpTglAkhir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpTglAwal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Seleksi Tanggal Penjualan |"
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Location = New System.Drawing.Point(151, 73)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(200, 22)
        Me.dtpTglAkhir.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Akhir"
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.Location = New System.Drawing.Point(151, 33)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(200, 22)
        Me.dtpTglAwal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Awal"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(27, 145)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(134, 47)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(197, 144)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(134, 47)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbBungkus)
        Me.GroupBox2.Controls.Add(Me.rbMakanTempat)
        Me.GroupBox2.Controls.Add(Me.rbSemua)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 125)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Filter |"
        '
        'rbSemua
        '
        Me.rbSemua.AutoSize = True
        Me.rbSemua.Location = New System.Drawing.Point(25, 28)
        Me.rbSemua.Name = "rbSemua"
        Me.rbSemua.Size = New System.Drawing.Size(170, 21)
        Me.rbSemua.TabIndex = 0
        Me.rbSemua.TabStop = True
        Me.rbSemua.Text = "Semua Jenis Pesanan"
        Me.rbSemua.UseVisualStyleBackColor = True
        '
        'rbMakanTempat
        '
        Me.rbMakanTempat.AutoSize = True
        Me.rbMakanTempat.Location = New System.Drawing.Point(25, 56)
        Me.rbMakanTempat.Name = "rbMakanTempat"
        Me.rbMakanTempat.Size = New System.Drawing.Size(138, 21)
        Me.rbMakanTempat.TabIndex = 1
        Me.rbMakanTempat.TabStop = True
        Me.rbMakanTempat.Text = "Makan di Tempat"
        Me.rbMakanTempat.UseVisualStyleBackColor = True
        '
        'rbBungkus
        '
        Me.rbBungkus.AutoSize = True
        Me.rbBungkus.Location = New System.Drawing.Point(25, 84)
        Me.rbBungkus.Name = "rbBungkus"
        Me.rbBungkus.Size = New System.Drawing.Size(84, 21)
        Me.rbBungkus.TabIndex = 2
        Me.rbBungkus.TabStop = True
        Me.rbBungkus.Text = "Bungkus"
        Me.rbBungkus.UseVisualStyleBackColor = True
        '
        'frmLaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 204)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLaporanPenjualan"
        Me.Text = "F_LaporanPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbBungkus As System.Windows.Forms.RadioButton
    Friend WithEvents rbMakanTempat As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemua As System.Windows.Forms.RadioButton
End Class
