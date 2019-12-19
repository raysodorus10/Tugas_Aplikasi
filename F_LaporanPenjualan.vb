Public Class frmLaporanPenjualan

    Private Sub frmLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpTglAwal.Value = Now
        Me.dtpTglAkhir.Value = Now
        rbSemua.Checked = True
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If rbSemua.Checked = True Then
            If dtpTglAwal.Value > dtpTglAkhir.Value Then
                MsgBox("Perbaiki Tanggal", vbInformation, "Tanggal")
            Else
                frmLaporanPenjualanPreview.CrystalReportViewer1.SelectionFormula = "{Command.tgl_transaksi} IN DateValue (" & dtpTglAwal.Value.ToString("yyyy,MM,dd") & ") TO DateValue (" & dtpTglAkhir.Value.ToString("yyyy,MM,dd") & ")"
                frmLaporanPenjualanPreview.CrystalReportViewer1.Refresh()
                frmLaporanPenjualanPreview.Show()
            End If
        ElseIf rbMakanTempat.Checked Then
            If dtpTglAwal.Value > dtpTglAkhir.Value Then
                MsgBox("Perbaiki Tanggal", vbInformation, "Tanggal")
            Else
                frmLaporanPenjualanPreview.CrystalReportViewer1.SelectionFormula = "{Command.tgl_transaksi} IN DateValue (" & dtpTglAwal.Value.ToString("yyyy,MM,dd") & ") TO DateValue (" & dtpTglAkhir.Value.ToString("yyyy,MM,dd") & ")" & " AND {Command.jenis_transaksi} = 'Makan di Tempat'"
                frmLaporanPenjualanPreview.CrystalReportViewer1.Refresh()
                frmLaporanPenjualanPreview.Show()
            End If
        ElseIf rbBungkus.Checked Then
            If dtpTglAwal.Value > dtpTglAkhir.Value Then
                MsgBox("Perbaiki Tanggal", vbInformation, "Tanggal")
            Else
                frmLaporanPenjualanPreview.CrystalReportViewer1.SelectionFormula = "{Command.tgl_transaksi} IN DateValue (" & dtpTglAwal.Value.ToString("yyyy,MM,dd") & ") TO DateValue (" & dtpTglAkhir.Value.ToString("yyyy,MM,dd") & ")" & " AND {Command.jenis_transaksi} = 'Bungkus '"
                frmLaporanPenjualanPreview.CrystalReportViewer1.Refresh()
                frmLaporanPenjualanPreview.Show()
            End If
        End If
    End Sub
End Class