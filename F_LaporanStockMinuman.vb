Public Class frmLaporanStockMinuman
    Public Sub isiJumlah()
        cmbSetJumlah.Items.Clear()
        cmbSetJumlah.Items.Add("5")
        cmbSetJumlah.Items.Add("10")
        cmbSetJumlah.Items.Add("20")
    End Sub
    Private Sub F_LaporanStockMinuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.isiJumlah()
        rbSemua.Checked = True
        cmbSetJumlah.Enabled = False
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If rbSet.Checked Then
            frmLaporanStockMinumanPreview.CrystalReportViewer1.SelectionFormula = "{Command.stock_minuman} <= " & cmbSetJumlah.Text
        End If
        frmLaporanStockMinumanPreview.CrystalReportViewer1.Refresh()
        frmLaporanStockMinumanPreview.Show()
    End Sub

    Private Sub rbSemua_CheckedChanged(sender As Object, e As EventArgs) Handles rbSemua.CheckedChanged
        If rbSemua.Checked Then
            cmbSetJumlah.Enabled = False
        End If
    End Sub

    Private Sub rbSet_CheckedChanged(sender As Object, e As EventArgs) Handles rbSet.CheckedChanged
        If rbSet.Checked Then
            cmbSetJumlah.Enabled = True
        End If
    End Sub
End Class