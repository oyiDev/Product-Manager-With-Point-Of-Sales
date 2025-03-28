Imports System.Data.Odbc

Public Class ManageDataRefresher

    Public Sub ManageStockLoadDataRefresh()
        connect_me()
        Dim mycmd As New OdbcCommand("select category, genericname, expiredate, price, qty from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        ManageStock.dg_stock.DataSource = ds.Tables(0)
        ManageStock.dg_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ManageStock.dg_stock.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        ManageStock.dg_stock.Refresh()
    End Sub

    Public Sub ManageProductLoadDataRefresh()
        connect_me()
        Dim mycmd As New OdbcCommand("select category, genericname, expiredate, price, qty from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        ManageStock.dg_stock.DataSource = ds.Tables(0)
        ManageStock.dg_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ManageStock.dg_stock.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        ManageStock.dg_stock.Refresh()
    End Sub
End Class
