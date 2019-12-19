<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenjualan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbBungkus = New System.Windows.Forms.RadioButton()
        Me.rbMakanTempat = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtpTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtNomorTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeMenu = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBungkus)
        Me.GroupBox1.Controls.Add(Me.rbMakanTempat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.dtpTglTransaksi)
        Me.GroupBox1.Controls.Add(Me.txtNomorTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1166, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbBungkus
        '
        Me.rbBungkus.AutoSize = True
        Me.rbBungkus.Location = New System.Drawing.Point(517, 68)
        Me.rbBungkus.Name = "rbBungkus"
        Me.rbBungkus.Size = New System.Drawing.Size(84, 21)
        Me.rbBungkus.TabIndex = 7
        Me.rbBungkus.TabStop = True
        Me.rbBungkus.Text = "Bungkus"
        Me.rbBungkus.UseVisualStyleBackColor = True
        '
        'rbMakanTempat
        '
        Me.rbMakanTempat.AutoSize = True
        Me.rbMakanTempat.Location = New System.Drawing.Point(517, 41)
        Me.rbMakanTempat.Name = "rbMakanTempat"
        Me.rbMakanTempat.Size = New System.Drawing.Size(138, 21)
        Me.rbMakanTempat.TabIndex = 6
        Me.rbMakanTempat.TabStop = True
        Me.rbMakanTempat.Text = "Makan di Tempat"
        Me.rbMakanTempat.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Jenis Pesanan"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(796, 26)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(139, 46)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Label8"
        '
        'dtpTglTransaksi
        '
        Me.dtpTglTransaksi.Location = New System.Drawing.Point(176, 60)
        Me.dtpTglTransaksi.Name = "dtpTglTransaksi"
        Me.dtpTglTransaksi.Size = New System.Drawing.Size(311, 22)
        Me.dtpTglTransaksi.TabIndex = 3
        '
        'txtNomorTransaksi
        '
        Me.txtNomorTransaksi.Location = New System.Drawing.Point(176, 22)
        Me.txtNomorTransaksi.Name = "txtNomorTransaksi"
        Me.txtNomorTransaksi.Size = New System.Drawing.Size(311, 22)
        Me.txtNomorTransaksi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaksi Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1166, 363)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Daftar Menu |"
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(6, 22)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RowTemplate.Height = 24
        Me.dgvKeranjang.Size = New System.Drawing.Size(1154, 327)
        Me.dgvKeranjang.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kode Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jumlah"
        '
        'txtKodeMenu
        '
        Me.txtKodeMenu.Location = New System.Drawing.Point(21, 35)
        Me.txtKodeMenu.Name = "txtKodeMenu"
        Me.txtKodeMenu.Size = New System.Drawing.Size(425, 22)
        Me.txtKodeMenu.TabIndex = 2
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(21, 81)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(425, 22)
        Me.txtQty.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(453, 35)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(68, 23)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCari)
        Me.GroupBox3.Controls.Add(Me.txtQty)
        Me.GroupBox3.Controls.Add(Me.txtKodeMenu)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 485)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 118)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtKembali)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDibayar)
        Me.GroupBox4.Controls.Add(Me.txtTotalHarga)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(533, 485)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 118)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "| Pembayaran |"
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(106, 86)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(205, 22)
        Me.txtKembali.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kembali"
        '
        'txtDibayar
        '
        Me.txtDibayar.Location = New System.Drawing.Point(106, 60)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(205, 22)
        Me.txtDibayar.TabIndex = 3
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(106, 30)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(205, 22)
        Me.txtTotalHarga.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dibayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Harga"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnKeluar)
        Me.GroupBox5.Controls.Add(Me.btnBatal)
        Me.GroupBox5.Controls.Add(Me.btnSimpan)
        Me.GroupBox5.Location = New System.Drawing.Point(856, 485)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 118)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(207, 21)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 86)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(108, 22)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(92, 86)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(7, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(94, 86)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusDataToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 28)
        '
        'HapusDataToolStripMenuItem
        '
        Me.HapusDataToolStripMenuItem.Name = "HapusDataToolStripMenuItem"
        Me.HapusDataToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.HapusDataToolStripMenuItem.Text = "Hapus Data"
        '
        'frmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 611)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPenjualan"
        Me.Text = "F_Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents dtpTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNomorTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvKeranjang As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeMenu As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDibayar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents rbBungkus As System.Windows.Forms.RadioButton
    Friend WithEvents rbMakanTempat As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
