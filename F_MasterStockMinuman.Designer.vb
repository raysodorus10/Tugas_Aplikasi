<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MasterStockMinuman
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbNamaMenu = New System.Windows.Forms.ComboBox()
        Me.txtStockMinuman = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtKodeMasterMenu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariMasterMenu = New System.Windows.Forms.TextBox()
        Me.dgvMasterStockMinuman = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMasterStockMinuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(833, 317)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(110, 48)
        Me.btnTutup.TabIndex = 9
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbNamaMenu)
        Me.GroupBox2.Controls.Add(Me.txtStockMinuman)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.txtKodeMasterMenu)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(581, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 304)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Tambah Master Stock Minuman |"
        '
        'cmbNamaMenu
        '
        Me.cmbNamaMenu.FormattingEnabled = True
        Me.cmbNamaMenu.Location = New System.Drawing.Point(154, 61)
        Me.cmbNamaMenu.Name = "cmbNamaMenu"
        Me.cmbNamaMenu.Size = New System.Drawing.Size(208, 24)
        Me.cmbNamaMenu.TabIndex = 11
        '
        'txtStockMinuman
        '
        Me.txtStockMinuman.Location = New System.Drawing.Point(154, 152)
        Me.txtStockMinuman.Name = "txtStockMinuman"
        Me.txtStockMinuman.Size = New System.Drawing.Size(208, 22)
        Me.txtStockMinuman.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock Menu"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(252, 204)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(110, 48)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(123, 204)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(110, 48)
        Me.btnSimpan.TabIndex = 4
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtKodeMasterMenu
        '
        Me.txtKodeMasterMenu.Location = New System.Drawing.Point(154, 107)
        Me.txtKodeMasterMenu.Name = "txtKodeMasterMenu"
        Me.txtKodeMasterMenu.Size = New System.Drawing.Size(208, 22)
        Me.txtKodeMasterMenu.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Master Menu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCariMasterMenu)
        Me.GroupBox1.Controls.Add(Me.dgvMasterStockMinuman)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 363)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Entri Master Stock Minuman |"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(419, 311)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 43)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(283, 311)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(105, 43)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(7, 311)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(105, 43)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari"
        '
        'txtCariMasterMenu
        '
        Me.txtCariMasterMenu.Location = New System.Drawing.Point(64, 27)
        Me.txtCariMasterMenu.Name = "txtCariMasterMenu"
        Me.txtCariMasterMenu.Size = New System.Drawing.Size(501, 22)
        Me.txtCariMasterMenu.TabIndex = 1
        '
        'dgvMasterStockMinuman
        '
        Me.dgvMasterStockMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterStockMinuman.Location = New System.Drawing.Point(7, 61)
        Me.dgvMasterStockMinuman.Name = "dgvMasterStockMinuman"
        Me.dgvMasterStockMinuman.RowTemplate.Height = 24
        Me.dgvMasterStockMinuman.Size = New System.Drawing.Size(558, 243)
        Me.dgvMasterStockMinuman.TabIndex = 0
        '
        'F_MasterStockMinuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 375)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_MasterStockMinuman"
        Me.Text = "F_MasterStockMinuman"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMasterStockMinuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStockMinuman As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtKodeMasterMenu As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariMasterMenu As System.Windows.Forms.TextBox
    Friend WithEvents dgvMasterStockMinuman As System.Windows.Forms.DataGridView
    Friend WithEvents cmbNamaMenu As System.Windows.Forms.ComboBox
End Class
