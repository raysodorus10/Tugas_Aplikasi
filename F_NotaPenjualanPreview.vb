Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class frmNotaPenjualanPreview
    Dim cryReport As New ReportDocument
    Dim RepLocation = Path.GetFullPath( _
            Path.Combine(Application.StartupPath, "..\..\"))
    Private Sub frmNotaPenjualanPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub nota_penjualan(ByVal no_transaksi As String, ByVal kembalian As String)
        cryReport.Load(RepLocation & "N_Penjualan.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("no_transaksi", no_transaksi)
        cryReport.SetParameterValue("kembalian", kembalian)
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
End Class