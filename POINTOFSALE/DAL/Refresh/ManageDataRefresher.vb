Imports System.Data.Odbc

Public Class ManageDataRefresher
    Public Sub GetTransactionTodaysData()
        Try
            connect_me()
            Dim query As String = "SELECT * FROM transactions WHERE DATE(transaction_date) = CURDATE()"
            Dim mycmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "transactions")

            TransactionForm.dgRecordTrans.Rows.Clear()

            ' Add data to existing columns
            For Each row As DataRow In ds.Tables(0).Rows
                TransactionForm.dgRecordTrans.Rows.Add(row("transaction_id"), row("name"), row("user_type"), row("transaction_date"), row("total_amount"), row("payment_method"), row("discount"))
            Next

            TransactionForm.dgRecordTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            TransactionForm.dgRecordTrans.RowsDefaultCellStyle.BackColor = Drawing.Color.White
            TransactionForm.dgRecordTrans.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error fetching today's transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetManageStockData()
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
