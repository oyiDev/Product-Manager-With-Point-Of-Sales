Imports System.Data.Odbc
Public Class ManageStock

    Dim Mdf As New ManageDataRefresher
    Dim productRepo As New ProductRepo
    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mdf.GetManageStockData()
        productRepo.HighlightAvailableProduct(DgStock, "qty")
        productRepo.HighlightZeroQtyCells(DgStock, "qty")
        productRepo.HighlightExpiredProduct(DgStock, "expiredate")
    End Sub
End Class
