Public Class frmCariBarang
    Public Shared sementara As String
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT id, kode_menu, nama_menu, type_menu, harga_menu FROM tb_menu ORDER BY nama_menu"
        Dim strtabel As String = "tb_menu"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvMenu.DataSource = (ds.Tables("tb_menu"))
        dgvMenu.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvMenu.Columns(0).HeaderText = "ID"
        dgvMenu.Columns(1).HeaderText = "KODE MENU"
        dgvMenu.Columns(2).HeaderText = "NAMA MENU"
        dgvMenu.Columns(3).HeaderText = "TYPE MENU"
        dgvMenu.Columns(4).HeaderText = "HARGA MENU"

        dgvMenu.Columns(0).Width = 30
        dgvMenu.Columns(1).Width = 80
        dgvMenu.Columns(2).Width = 100
        dgvMenu.Columns(3).Width = 50
        dgvMenu.Columns(4).Width = 250

        dgvMenu.Columns(0).Visible = False
    End Sub
    Public Sub RefreshForm()
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
    End Sub
    Private Sub F_CariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()
        txtCariNamaMenu.Text = ""
        txtCariNamaMenu.Focus()
    End Sub

    Private Sub txtCariNamaMenu_TextChanged(sender As Object, e As EventArgs) Handles txtCariNamaMenu.TextChanged
        Dim strtampil As String = "SELECT id, kode_menu, nama_menu, type_menu, harga_menu FROM tb_menu WHERE nama_menu LIKE '%" & _
                                  txtCariNamaMenu.Text & "%' ORDER BY nama_menu"
        Dim strtabel As String = "tb_menu"
        Call TampilData(strtampil, strtabel)
        dgvMenu.DataSource = (ds.Tables("tb_menu"))
        dgvMenu.ReadOnly = True
        Call Me.JudulGrid()
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        Dim SQLCari As String
        Dim id_menu As String

        id_menu = dgvMenu.Rows.Item(dgvMenu.CurrentRow.Index).Cells(0).Value
        SQLCari = "SELECT * FROM tb_menu WHERE id = '" & id_menu & "'"
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = SQLCari
        dr = cmd.ExecuteReader
        If dr.Read Then
            frmPenjualan.txtKodeMenu.Text = dr.Item("kode_menu")
            frmPenjualan.txtQty.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub dgvMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellDoubleClick
        Call Me.btnPilih_Click(sender, e)
    End Sub
End Class