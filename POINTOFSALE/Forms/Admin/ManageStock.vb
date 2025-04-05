Imports System.Data.Odbc
Public Class ManageStock

    Dim Mdf As New ManageDataRefresher
    Dim productRepo As New ProductRepo

    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productRepo.HighlightAvailableProduct(DgStock, "qty")
        productRepo.HighlightZeroQtyCells(DgStock, "qty")
        productRepo.HighlightExpiredProduct(DgStock, "expiredate")
    End Sub

    Private Sub stockReportBtn_Click(sender As Object, e As EventArgs) Handles stockReportBtn.Click
        If Me.DgStock.Rows.Count = 0 OrElse (Me.DgStock.Rows.Count = 1 AndAlso Me.DgStock.Rows(0).IsNewRow) Then
            MessageBox.Show("No Report to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Dim report As New ProductReport
        productRepo.StockReport()
        Dim mdf As New ManageDataRefresher
        mdf.GetManageStockData()

    End Sub
End Class
