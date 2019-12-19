Public Class frmPenjualan
    Dim sKodeMenu, sNamaMenu As String
    Dim iStock As Integer
    Dim dHargaBarang, dSubTotal As String
    Dim bEditQty As Boolean
    Dim jenis_pesanan As String
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT * FROM tb_keranjang"
        Dim strtabel As String = "tb_keranjang"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvKeranjang.DataSource = (ds.Tables("tb_keranjang"))
        dgvKeranjang.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvKeranjang.Columns(0).HeaderText = "ID"
        dgvKeranjang.Columns(1).HeaderText = "KODE MENU"
        dgvKeranjang.Columns(2).HeaderText = "NAMA MENU"
        dgvKeranjang.Columns(3).HeaderText = "QTY"
        dgvKeranjang.Columns(4).HeaderText = "HARGA JUAL"
        dgvKeranjang.Columns(5).HeaderText = "SUB TOTAL"

        dgvKeranjang.Columns(0).Width = 50
        dgvKeranjang.Columns(1).Width = 50
        dgvKeranjang.Columns(2).Width = 100
        dgvKeranjang.Columns(3).Width = 50
        dgvKeranjang.Columns(4).Width = 150
        dgvKeranjang.Columns(5).Width = 200

        dgvKeranjang.Columns(0).Visible = False
        dgvKeranjang.RowHeadersVisible = False

        For i As Byte = 3 To 5
            dgvKeranjang.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKeranjang.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next i
    End Sub
    Public Sub RefreshForm()
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        lblTotal.Text = Format(HitungTotal, "#,###")
        txtTotalHarga.Text = HitungTotal()
        bEditQty = False
    End Sub
    Public Sub ClearForm()
        txtKodeMenu.Text = ""
        txtQty.Text = "1"
        txtKodeMenu.Focus()
    End Sub
    Private Sub HapusKeranjang()
        Dim SQLHapus, SQLSelect As String

        SQLSelect = "SELECT * FROM tb_keranjang"
        If KoneksiDB.CariData(SQLSelect) Then
            SQLHapus = "DELETE FROM tb_keranjang"
            Call KoneksiDB.ProsesSQL(SQLHapus)
        End If
        Call Me.RefreshForm()
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long

        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT RIGHT (no_transaksi, 5) AS a FROM tb_transaksi ORDER BY a DESC"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 5)) + 1
        End If
        Return Format(dtpTglTransaksi.Value, "ddMMyyyy") + "-" + Format(Val(no), "00000")
    End Function
    Private Function HitungTotal() As Double
        Dim Total As Double
        For i As Integer = 0 To dgvKeranjang.RowCount - 1
            Total += dgvKeranjang.Rows(i).Cells(5).Value
        Next i
        Return Total
    End Function
    Private Function CariDataBarang(Kd As String) As Boolean
        Dim Ada As Boolean
        Dim SQLCari As String

        If frmCariBarang.sementara = "menu" Then
            SQLCari = "SELECT a.*, IF(b.stock_minuman IS NULL, 99, b.stock_minuman) AS stock_minuman FROM tb_menu AS a LEFT OUTER JOIN tb_stock_minuman AS b ON a.kode_menu = b.kode_menu WHERE a.kode_menu LIKE '" & Kd & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader
            If dr.Read Then
                Ada = True
                sNamaMenu = dr.Item("nama_menu")
                iStock = dr.Item("stock_minuman")
                dHargaBarang = dr.Item("harga_menu")
                dSubTotal = dHargaBarang * CDbl(Me.txtQty.Text)
            Else
                Ada = False
            End If
        End If
        Return Ada
    End Function
    Private Sub TambahKeranjang()
        Dim SQLSelect, SQLSimpan As String
        If Trim(txtKodeMenu.Text) = "" Or Trim(txtQty.Text) = "" Then
            MsgBox("Data belum lengkap !", vbInformation, "Tambah Data")
            txtKodeMenu.Focus()
        Else
            SQLSelect = "SELECT kode_menu FROM tb_keranjang WHERE kode_menu LIKE '" & txtKodeMenu.Text & "'"
            If KoneksiDB.CariData(SQLSelect) Then
                If bEditQty Then
                    SQLSimpan = "UPDATE tb_keranjang SET qty = " & Val(txtQty.Text) & ", sub_total = harga_jual * (" & _
                                Val(txtQty.Text) & ") WHERE kode_menu LIKE '" & txtKodeMenu.Text & "'"
                Else
                    SQLSimpan = "UPDATE tb_keranjang SET qty = qty + " & Val(txtQty.Text) & ", sub_total = harga_jual * qty " & _
                                "WHERE kode_menu LIKE '" & txtKodeMenu.Text & "'"
                End If
            Else
                SQLSimpan = "INSERT INTO tb_keranjang (kode_menu, nama_menu, qty, harga_jual, sub_total) VALUES ('" & txtKodeMenu.Text & "', '" & _
                            sNamaMenu & "', '" & txtQty.Text & "', '" & dHargaBarang & "', '" & dSubTotal & "')"
            End If
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            Call Me.RefreshForm()
            Call Me.ClearForm()
        End If
    End Sub
    Private Sub UpdateStockMenu(Stock As Integer)
        Dim SQLSelect, SQLSimpan As String

        SQLSelect = "SELECT type_menu FROM tb_menu WHERE type_menu = '1' "
        If KoneksiDB.CariData(SQLSelect) Then
            SQLSimpan = "UPDATE tb_stock_minuman SET stock_minuman = " & Val(txtQty.Text) & " WHERE kode_menu LIKE '" * txtKodeMenu.Text & "'"
        End If
    End Sub
    Private Sub HapusData()
        Dim Hapus, sNamaMenu, SQLHapus As String
        Dim id_menu As String

        id_menu = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(0).Value
        sNamaMenu = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(2).Value

        Hapus = MessageBox.Show("Yakin data " & sNamaMenu & " mau dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Hapus = MsgBoxResult.Yes Then
            SQLHapus = "DELETE FROM tb_keranjang WHERE id = '" & id_menu & "'"
            Call KoneksiDB.ProsesSQL(SQLHapus)
            MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub F_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call RefreshForm()
        txtNomorTransaksi.Text = ""
        txtNomorTransaksi.Enabled = False
        dtpTglTransaksi.Value = Now
        Call ClearForm()
        Call HapusKeranjang()

        txtTotalHarga.Text = ""
        txtDibayar.Text = ""
        txtKembali.Text = ""
        rbMakanTempat.Checked = True

        txtTotalHarga.Enabled = False
        txtKembali.Enabled = False

        Me.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCariBarang.Show()
    End Sub

    Private Sub txtKodeMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeMenu.KeyPress
        Dim iQty As Integer = 0
        Dim SQLSet As String
        Dim tes As String

        If e.KeyChar = Chr(13) Then
            frmCariBarang.sementara = "menu"
            If Me.CariDataBarang(Me.txtKodeMenu.Text) Then
                Dim SQLSelect = "SELECT * FROM tb_keranjang WHERE kode_menu LIKE '" & Me.txtKodeMenu.Text & "'"
                If KoneksiDB.CariData(SQLSelect) Then
                    SQLSelect = "SELECT SUM(qty) AS sumqty FROM tb_keranjang WHERE kode_menu LIKE '" & Me.txtKodeMenu.Text & "'"
                    cmd = New Odbc.OdbcCommand
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = SQLSelect
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        iQty = dr.Item("sumqty")
                    End If
                End If

                SQLSet = "SELECT type_menu FROM tb_menu"
                cmd = New Odbc.OdbcCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = SQLSet
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    tes = dr.Item("type_menu")
                End If
                If tes = "1" Then
                    If Val(txtQty.Text) + iQty > iStock Then
                        MsgBox("Stock tidak mencukupi", vbInformation, "Transaksi")
                        txtQty.Focus()
                    Else
                        Call Me.TambahKeranjang()
                    End If
                ElseIf tes = "0" Then
                    Call Me.TambahKeranjang()
                End If
            Else
                MsgBox("Data tidak ditemukan !!!", vbInformation, "Cari Data")
            End If
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        Call Me.txtKodeMenu_KeyPress(sender, e)
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click
        Call Me.HapusData()
        Call Me.RefreshForm()
    End Sub

    Private Sub dgvKeranjang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeranjang.CellContentClick
        txtKodeMenu.Text = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(1).Value
        txtQty.Text = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(3).Value
        bEditQty = True
        txtQty.Focus()
    End Sub

    Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
        If txtTotalHarga.Text <> "" And txtDibayar.Text <> "" Then
            txtKembali.Text = Format(Val(txtDibayar.Text) - Val(txtTotalHarga.Text), "#,###")
        Else
            txtKembali.Text = "0"
        End If
    End Sub

    Private Sub txtDibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDibayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Simpan, SQLSimpan1, SQLSimpan2, SQLSimpan3, jenis As String
        If rbMakanTempat.Checked Then
            jenis = "M"
        ElseIf rbBungkus.Checked Then
            jenis = "B"
        End If

        If txtDibayar.Text = "" Then
            MsgBox("Transaksi belum dibayar", vbInformation, "Transaksi Penjualan")
            Exit Sub
        End If

        If txtTotalHarga.Text = "" Then
            MsgBox("Tidak ada data transaksi!", vbInformation, "Pilih Data")
            Exit Sub
        End If

        Dim sementara As String
        sementara = Strings.Left(txtKembali.Text, 1)
        If sementara = "-" Then
            MsgBox("Uang kurang cukup")
            Exit Sub
        End If

        Simpan = MessageBox.Show("Data akan disimpan ?", "Transaksi Penjualan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Simpan = MsgBoxResult.Yes Then
            If dtpTglTransaksi.Value > Now Then
                MsgBox(dtpTglTransaksi.Value.ToString + Now.ToString + "Tanggal Transaksi Penjualan melewati hari ini")
                Exit Sub
            End If

            For i As Integer = 0 To dgvKeranjang.RowCount - 2
                SQLSimpan2 = "INSERT INTO tb_transaksi_detail (no_transaksi, kode_menu, harga, jumlah, sub_total) VALUES ('" & txtNomorTransaksi.Text & "', '" & _
                             dgvKeranjang.Rows(i).Cells(1).Value & "', '" & dgvKeranjang.Rows(i).Cells(4).Value & "', '" & _
                             dgvKeranjang.Rows(i).Cells(3).Value & "', '" & dgvKeranjang.Rows(i).Cells(5).Value & "')"
                SQLSimpan3 = "UPDATE tb_stock_minuman SET stock_minuman = stock_minuman - " & dgvKeranjang.Rows(i).Cells(3).Value & _
                             " WHERE kode_menu LIKE '" & dgvKeranjang.Rows(i).Cells(1).Value & "'"
                Call KoneksiDB.ProsesSQL(SQLSimpan2)
                Call KoneksiDB.ProsesSQL(SQLSimpan3)
            Next i
            SQLSimpan1 = "INSERT INTO tb_transaksi (no_transaksi, tgl_transaksi, jenis_transaksi, total) VALUES ('" & txtNomorTransaksi.Text & "', '" & _
                         Format(dtpTglTransaksi.Value, "yyyy-MM-dd") & "', '" & jenis_pesanan & "', '" & txtTotalHarga.Text & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan1)

            MsgBox("Data sudah tersimpan", vbInformation, "Transaksi Penjualan")
            Dim kembalian As String = Val(txtDibayar.Text) - Val(txtTotalHarga.Text)
            frmNotaPenjualanPreview.nota_penjualan(txtNomorTransaksi.Text, kembalian)
            frmNotaPenjualanPreview.ShowDialog()

            Call Me.F_Penjualan_Load(sender, e)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.F_Penjualan_Load(sender, e)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub dtpTglTransaksi_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglTransaksi.ValueChanged
        txtNomorTransaksi.Text = Me.AutoKode
    End Sub

    Private Sub rbMakanTempat_CheckedChanged(sender As Object, e As EventArgs) Handles rbMakanTempat.CheckedChanged
        If rbMakanTempat.Checked Then
            jenis_pesanan = "Makan di Tempat"
        End If
    End Sub

    Private Sub rbBungkus_CheckedChanged(sender As Object, e As EventArgs) Handles rbBungkus.CheckedChanged
        If rbBungkus.Checked Then
            jenis_pesanan = "Bungkus"
        End If
    End Sub
End Class