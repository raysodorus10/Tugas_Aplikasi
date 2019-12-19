Public Class F_MasterStockMinuman
    Dim id_masterstockminuman As Integer
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT a.id, b.nama_menu,a.stock_minuman FROM tb_stock_minuman AS a INNER JOIN tb_menu AS b ON a.kode_menu = b.kode_menu ORDER BY a.kode_menu"
        Dim strtabel As String = "tb_stock_minuman"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvMasterStockMinuman.DataSource = (ds.Tables("tb_stock_minuman"))
        dgvMasterStockMinuman.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvMasterStockMinuman.Columns(0).HeaderText = "ID"
        dgvMasterStockMinuman.Columns(1).HeaderText = "NAMA MINUMAN"
        dgvMasterStockMinuman.Columns(2).HeaderText = "STOCK"

        dgvMasterStockMinuman.Columns(0).Width = 30
        dgvMasterStockMinuman.Columns(1).Width = 80
        dgvMasterStockMinuman.Columns(2).Width = 200

        dgvMasterStockMinuman.Columns(0).Visible = False
    End Sub
    Private Sub RefreshForm()
        cmbNamaMenu.Text = ""
        txtKodeMasterMenu.Clear()
        txtStockMinuman.Clear()

        cmbNamaMenu.Enabled = False
        txtKodeMasterMenu.Enabled = False
        txtStockMinuman.Enabled = False

        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        dgvMasterStockMinuman.Focus()
    End Sub
    Private Sub ClearForm()
        cmbNamaMenu.Text = ""
        txtKodeMasterMenu.Clear()
        txtStockMinuman.Clear()

        cmbNamaMenu.Enabled = True
        txtKodeMasterMenu.Enabled = False
        txtStockMinuman.Enabled = True

        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        cmbNamaMenu.Focus()
    End Sub
    Public Sub isiNamaMinuman()
        Dim SQL As String = "SELECT * FROM tb_menu WHERE type_menu = '1'"
        da = New Data.Odbc.OdbcDataAdapter(SQL, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbNamaMenu.DataSource = dt
            cmbNamaMenu.ValueMember = "kode_menu"
            cmbNamaMenu.DisplayMember = "nama_menu"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    
    Private Sub prosesSimpan()
        Dim SQLSelect, SQLSimpan As String
        If Trim(txtKodeMasterMenu.Text) = "" Or Trim(txtStockMinuman.Text) = "" Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Stock")
        Else
            SQLSelect = "SELECT kode_menu FROM tb_stock_minuman WHERE kode_menu LIKE '" & txtKodeMasterMenu.Text & "'"
            If KoneksiDB.CariData(SQLSelect) Then
                SQLSimpan = "UPDATE tb_stock_minuman SET stock_minuman = stock_minuman + " & Val(txtStockMinuman.Text) & " WHERE kode_menu LIKE '" & txtKodeMasterMenu.Text & "'"
            Else
                SQLSimpan = "INSERT INTO tb_stock_minuman (kode_menu, stock_minuman) VALUES ('" & txtKodeMasterMenu.Text & "', '" & txtStockMinuman.Text & "')"
            End If
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Stock Minuman")
            Call Me.RefreshForm()
            Call Me.ClearForm()
        End If
    End Sub
    Private Sub F_MasterStockMinuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.isiNamaMinuman()
        Call Me.RefreshForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, sNamaMenu, SQLHapus As String

        id_masterstockminuman = dgvMasterStockMinuman.Rows.Item(dgvMasterStockMinuman.CurrentRow.Index).Cells(0).Value
        sNamaMenu = dgvMasterStockMinuman.Rows.Item(dgvMasterStockMinuman.CurrentRow.Index).Cells(2).Value

        Hapus = MessageBox.Show("Yakin data " & sNamaMenu & " mau dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Hapus = MsgBoxResult.Yes Then
            SQLHapus = "DELETE FROM tb_stock_minuman WHERE id = '" & id_masterstockminuman & "'"
            Call KoneksiDB.ProsesSQL(SQLHapus)
            MsgBox("Data terhapus!", vbInformation, "Hapus Data")

            Call Me.RefreshForm()
        End If
    End Sub

    Private Sub txtCariMasterMenu_TextChanged(sender As Object, e As EventArgs) Handles txtCariMasterMenu.TextChanged
        Dim strtampil As String = "SELECT a.kode_menu, b.nama_menu, a.stock_minuman FROM tb_stock_minuman AS a INNER JOIN tb_menu AS b ON a.kode_menu = b.kode_menu WHERE b.nama_menu LIKE '" & txtCariMasterMenu.Text & "'"
        Dim strtabel As String = "tb_stock_minuman"
        Call TampilData(strtampil, strtabel)
        dgvMasterStockMinuman.DataSource = (ds.Tables("tb_stock_minuman"))
        dgvMasterStockMinuman.ReadOnly = True
        Call Me.JudulGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.RefreshForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbNamaMenu.Text = "" Or txtStockMinuman.Text = "" Then
            MsgBox("Data belum lengkap !", vbInformation, "Tambah Data")
        Else
            Call Me.prosesSimpan()
        End If
    End Sub

    Private Sub cmbNamaMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaMenu.SelectedIndexChanged
        txtKodeMasterMenu.Text = cmbNamaMenu.SelectedValue.ToString
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Me.ClearForm()

        btnSimpan.Enabled = True
        btnBatal.Enabled = True
    End Sub
End Class