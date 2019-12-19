Public Class F_MainMenu

    Private Sub MasterMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterMenuToolStripMenuItem.Click
        F_MasterMenu.MdiParent = Me
        F_MasterMenu.Show()
    End Sub

    Private Sub MasterStockMinumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterStockMinumanToolStripMenuItem.Click
        F_MasterStockMinuman.MdiParent = Me
        F_MasterStockMinuman.Show()
    End Sub

    Private Sub F_MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SQLSelect, status As String
        SQLSelect = "SELECT level from tb_users WHERE username = '" & frmLogin.txtUsername.Text & "'"
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader
        If dr.Read Then
            status = dr.Item("level")
        End If

        If status <> "ADMIN" Then
            DataMasterToolStripMenuItem.Enabled = False
            LaporanToolStripMenuItem.Enabled = False
        Else
            DataMasterToolStripMenuItem.Enabled = True
            LaporanToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        frmPenjualan.MdiParent = Me
        frmPenjualan.Show()
    End Sub

    Private Sub DataStockMinumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStockMinumanToolStripMenuItem.Click
        frmLaporanStockMinuman.MdiParent = Me
        frmLaporanStockMinuman.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        frmLaporanPenjualan.MdiParent = Me
        frmLaporanPenjualan.Show()
    End Sub
End Class