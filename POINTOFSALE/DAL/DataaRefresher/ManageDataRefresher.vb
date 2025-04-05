Imports System.Data.Odbc

Public Class ManageDataRefresher

    Dim productRepo As New ProductRepo
    Public Sub GetZeroProduct()
        Try
            connect_me()
            Dim query As String = "SELECT qty AS QTY, genericname AS `GENERIC NAME`, brandname AS `BRANDNAME`, category AS CATEGORY FROM products WHERE qty = 0"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "products")

            DashboardPanelForm.DashboardDgZeroProduct.DataSource = ds.Tables(0)
            DashboardPanelForm.DashboardDgZeroProduct.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error Loading Data...: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub LoadTotalCount(tableName As String, label As Label)
        Try
            connect_me()
            Dim query As String = $"SELECT COUNT(*) FROM {tableName}"
            Using cmd As New OdbcCommand(query, con)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                label.Text = count.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching total count from {tableName}: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetDashboardData()
        Try
            connect_me()
            Dim repo As New ProductRepo()
            LoadTotalCount("users", DashboardPanelForm.totalUser_lbl)
            LoadTotalCount("products", DashboardPanelForm.LblTotalProduct)
            LoadTotalCount("supplier", DashboardPanelForm.total_Supplierlbl)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading... " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetManageProductData()
        Try
            connect_me()
            Dim query As String = "SELECT barcode AS BARCODE, category AS CATEGORY, genericname AS GENERICNAME, brandname AS BRANDNAME,
                                    formula AS FORMULA, description AS DESCRIPTION, price AS PRICE, qty AS QTY FROM products ORDER BY created_at ASC"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "products")

            ManageProduct.DgManageProduct.DataSource = ds.Tables(0)
            productRepo.HighlightZeroQtyCells(ManageProduct.DgManageProduct, "qty")
            productRepo.HighlightAvailableProduct(ManageProduct.DgManageProduct, "qty")
            ManageProduct.DgManageProduct.ClearSelection()
            ManageProduct.DgManageProduct.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show("Error Loading Data...: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetManageStockData()
        Try
            connect_me()
            Dim query As String = "SELECT id AS ID, category AS CATEGORY, genericname AS `GENERIC NAME`, expiredate AS `EXPIRY DATE`, qty AS QTY FROM products
                               ORDER BY CASE WHEN qty BETWEEN 0 AND 10 THEN qty ELSE 11 END, CASE WHEN qty BETWEEN 0 AND 10 THEN 0 ELSE 1 END, expiredate DESC"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "products")

            ' Set data source
            ManageStock.DgManageStock.DataSource = ds.Tables(0)

            ' Highlight logic
            productRepo.HighlightAvailableProduct(ManageStock.DgManageStock, "qty")
            productRepo.HighlightZeroQtyCells(ManageStock.DgManageStock, "qty")
            productRepo.HighlightExpiredProduct(ManageStock.DgManageStock, "EXPIRY DATE")

            ' Add Refill button column if not already present
            If Not ManageStock.DgManageStock.Columns.Contains("REFILL") Then
                Dim refillButton As New DataGridViewButtonColumn()
                refillButton.Name = "REFILL"
                refillButton.HeaderText = "REFILL"
                refillButton.Text = "Refill"
                refillButton.UseColumnTextForButtonValue = True
                ManageStock.DgManageStock.Columns.Add(refillButton)
            End If

        Catch ex As Exception
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
            MessageBox.Show("Error loading stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetSupplierData()
        Try
            connect_me()
            Dim query As String = "SELECT id AS ID, name AS NAME, phone AS PHONE, address AS ADDRESS FROM supplier"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "supplier")

            ManageSupplier.dg_Supplier.DataSource = ds.Tables(0)
            ManageSupplier.dg_Supplier.Refresh()
        Catch ex As Exception
>>>>>>> Stashed changes
            MessageBox.Show("Error Loading Data...: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

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

            TransactionForm.dgRecordTrans.DataSource = ds.Tables(0)
            TransactionForm.dgRecordTrans.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error fetching today's transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetManageUserData()
        Try
            connect_me()
            Dim query As String = "SELECT id AS `USER ID`, firstname AS FIRSTNAME, lastname As LASTNAME, username AS USERNAME, usertype AS ROLE, created_at AS `CREATED AT`, updated_at AS `UPDATED AT` FROM users"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "users")

            ManageUser.DgManageUser.DataSource = ds.Tables(0)
            ManageUser.DgManageUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error Loading Data...: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
