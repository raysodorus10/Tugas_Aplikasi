Public Class F_MasterMenu
    Dim id_mastermenu As Integer
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT * FROM tb_menu ORDER BY nama_menu"
        Dim strtabel As String = "tb_menu"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvMasterMenu.DataSource = (ds.Tables("tb_menu"))
        dgvMasterMenu.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvMasterMenu.Columns(0).HeaderText = "ID"
        dgvMasterMenu.Columns(1).HeaderText = "KODE MENU"
        dgvMasterMenu.Columns(2).HeaderText = "NAMA MENU"
        dgvMasterMenu.Columns(3).HeaderText = "TYPE MENU"
        dgvMasterMenu.Columns(4).HeaderText = "HARGA MENU"
        dgvMasterMenu.Columns(0).Width = 30
        dgvMasterMenu.Columns(1).Width = 80
        dgvMasterMenu.Columns(2).Width = 100
        dgvMasterMenu.Columns(3).Width = 100
        dgvMasterMenu.Columns(4).Width = 100
        dgvMasterMenu.Columns(0).Visible = False
    End Sub
    Private Sub RefreshForm()
        txtKodeMasterMenu.Clear()
        txtNamaMenu.Clear()
        cmbTipeMenu.SelectedIndex = -1
        txtHargaMenu.Clear()

        txtKodeMasterMenu.Enabled = False
        txtNamaMenu.Enabled = False
        cmbTipeMenu.Enabled = False
        txtHargaMenu.Enabled = False

        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        dgvMasterMenu.Focus()
    End Sub
    Private Sub ClearForm()
        txtKodeMasterMenu.Clear()
        txtNamaMenu.Clear()
        cmbTipeMenu.SelectedIndex = -1
        txtHargaMenu.Clear()

        txtKodeMasterMenu.Enabled = False
        txtNamaMenu.Enabled = True
        cmbTipeMenu.Enabled = True
        txtHargaMenu.Enabled = True

        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtNamaMenu.Focus()
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long

        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_menu WHERE kode_menu IN (SELECT MAX(kode_menu) FROM tb_menu)"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(dr.GetString(0)) + 1
        End If
        Return Microsoft.VisualBasic.Right("000" & no, 3)
    End Function
    Private Sub prosesSimpan()
        Dim SQLSelect, SQLSimpan As String
        SQLSelect = "SELECT nama_menu FROM tb_menu WHERE nama_menu like '" & txtNamaMenu.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Nama Menu sudah ada!", vbInformation, "Tambah Data ")
        Else
            SQLSimpan = "INSERT INTO tb_menu (kode_menu, nama_menu, type_menu, harga_menu) VALUES ('" & txtKodeMasterMenu.Text & "', '" & txtNamaMenu.Text & "', '" & cmbTipeMenu.SelectedIndex.ToString & "', '" & txtHargaMenu.Text & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub prosesUpdate()
        Dim SQLSelect, SQLUpdate As String
        SQLSelect = "SELECT nama_menu FROM tb_menu WHERE nama_menu like '" & txtNamaMenu.Text & "' AND id != '" & id_mastermenu & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Nama Menu sudah ada!", vbInformation, "Tambah Data ")
        Else
            SQLUpdate = "UPDATE tb_menu SET nama_menu = '" & txtNamaMenu.Text & "', type_menu = '" & cmbTipeMenu.SelectedIndex.ToString & "', harga_menu = '" & txtHargaMenu.Text & "' WHERE id = '" & id_mastermenu & "'"
            Call KoneksiDB.ProsesSQL(SQLUpdate)
            MsgBox("Data berhasil diupdate", vbInformation, "Tambah Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub F_MasterMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()

        cmbTipeMenu.Items.Add("Makanan")
        cmbTipeMenu.Items.Add("Minuman")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Me.ClearForm()

        btnSimpan.Enabled = True
        btnBatal.Enabled = True

        btnSimpan.Text = "Simpan"
        txtKodeMasterMenu.Text = Me.AutoKode
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodeMasterMenu.Text = "") Or (txtNamaMenu.Text = "") Or (txtHargaMenu.Text = "") Or (cmbTipeMenu.SelectedIndex = -1) Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
        Else
            If btnSimpan.Text = "Simpan" Then
                Call Me.prosesSimpan()
            ElseIf btnSimpan.Text = "Update" Then
                Call Me.prosesUpdate()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim SQLCari As String
        If dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_mastermenu = dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(0).Value()
            SQLCari = "SELECT * FROM tb_menu WHERE id = '" & id_mastermenu & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtKodeMasterMenu.Text = dr.Item("kode_menu")
                txtNamaMenu.Text = dr.Item("nama_menu")

                If dr.Item("type_menu") = 0 Then
                    cmbTipeMenu.SelectedIndex = 0
                Else
                    cmbTipeMenu.SelectedIndex = 1
                End If
                cmbTipeMenu.Text = dr.Item("type_menu")
                txtHargaMenu.Text = dr.Item("harga_menu")

                txtKodeMasterMenu.Enabled = False
                txtNamaMenu.Enabled = True
                cmbTipeMenu.Enabled = True
                txtHargaMenu.Enabled = True

                btnSimpan.Enabled = True
                btnBatal.Enabled = True
                btnSimpan.Text = "Update"
                txtNamaMenu.Focus()
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, sMenu, SQLHapus, SQLCek, cek As String
        If dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_mastermenu = dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(0).Value()
            sMenu = dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(2).Value()

            SQLCek = "SELECT DISTINCT a.kode_menu FROM tb_menu AS a INNER JOIN tb_transaksi_detail AS b ON a.kode_menu = b.kode_menu WHERE a.id = '" & id_mastermenu & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCek
            dr = cmd.ExecuteReader
            If dr.Read Then
                cek = dr.Item("kode_menu")
            End If

            Hapus = MessageBox.Show("Yakin data " & sMenu & " mau dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes And dgvMasterMenu.Rows.Item(dgvMasterMenu.CurrentRow.Index).Cells(1).Value <> cek Then
                SQLHapus = "DELETE FROM tb_menu WHERE id = '" & id_mastermenu & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data ")
                Call Me.RefreshForm()
            ElseIf Hapus = MsgBoxResult.No Then
                Exit Sub
            Else
                MsgBox("Data Tidak Boleh Di Hapus !!, Ada Transaksi !", vbInformation, "Hapus Data")
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.RefreshForm()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub

    Private Sub txtCariMasterMenu_TextChanged(sender As Object, e As EventArgs) Handles txtCariMasterMenu.TextChanged
        Dim strtampil As String = "SELECT * FROM tb_menu WHERE nama_menu like '%" & txtCariMasterMenu.Text & "%' ORDER BY nama_menu "
        Dim strtabel As String = "tb_menu"
        Call TampilData(strtampil, strtabel)
        dgvMasterMenu.DataSource = (ds.Tables("tb_menu"))
        dgvMasterMenu.ReadOnly = True
        Call Me.JudulGrid()
    End Sub

End Class