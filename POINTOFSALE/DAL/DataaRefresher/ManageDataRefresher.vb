Imports System.Data.Odbc

Public Class ManageDataRefresher

    Dim productRepo As New ProductRepo

    Private Sub Format_QtyColumn(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If DashboardPanelForm.DashboardDgZeroProduct.Columns(e.ColumnIndex).Name = "QTY" Then
            e.CellStyle.ForeColor = Color.Tomato
            e.CellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        End If
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

    Public Sub GetZeroProduct()
        Try
            connect_me()
            Dim query As String = "SELECT qty AS QTY, genericname AS `GENERIC NAME`, brandname AS `BRANDNAME`, category AS CATEGORY FROM products WHERE qty = 0"
            Dim cmd As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim ds As New Data.DataSet

            da.Fill(ds, "products")

            With DashboardPanelForm.DashboardDgZeroProduct
                .DataSource = ds.Tables(0)
                .Refresh()
                .ClearSelection()
                .CurrentCell = Nothing
            End With

            ' Apply formatting event
            AddHandler DashboardPanelForm.DashboardDgZeroProduct.CellFormatting, AddressOf Format_QtyColumn
            ManageStock.DgStock.DataSource = ds.Tables(0)
            ManageStock.DgStock.ClearSelection()
            ManageStock.DgStock.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show("Error Loading Data...: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetDashboardDatas()
        Try
            connect_me()
            GetZeroProduct()
            LoadTotalCount("users", DashboardPanelForm.totalUser_lbl)
            LoadTotalCount("products", DashboardPanelForm.LblTotalProduct)
            LoadTotalCount("supplier", DashboardPanelForm.total_Supplierlbl)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading Dashboard " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub GetManageProductData(searchTerm As String)
        Try
            connect_me()
            Dim query As String = "SELECT id, barcode, category, genericname, brandname, formula, description, price, qty, expiredate FROM products WHERE 1=1"

            ' Apply search filter
            If Not String.IsNullOrEmpty(searchTerm) Then
                query &= " AND (barcode LIKE ? OR genericname LIKE ? OR brandname LIKE ?)"
            End If

            ' Apply category filter
            If ManageProduct.CbFilter.SelectedIndex > 0 Then ' Ignore "--SELECT--"
                query &= " AND category = ?"
            End If

            query &= " ORDER BY CASE WHEN qty <= 10 THEN 0 ELSE 1 END, qty ASC"

            Dim cmd As New OdbcCommand(query, con)

            ' Add search parameters
            If Not String.IsNullOrEmpty(searchTerm) Then
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
            End If

            ' Add category parameter
            If ManageProduct.CbFilter.SelectedIndex > 0 Then
                cmd.Parameters.AddWithValue("?", ManageProduct.CbFilter.SelectedItem.ToString())
            End If

            Dim adapter As New OdbcDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ManageProduct.DgManageProduct.Rows.Clear()

            For Each row As DataRow In table.Rows
                ManageProduct.DgManageProduct.Rows.Add(row("id"), row("barcode"), row("category"), row("genericname"), row("brandname"), row("formula"), row("description"), row("price"), row("qty"), row("expiredate"), "EDIT", "DELETE")
            Next

            ManageProduct.DgManageProduct.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Error Loading Stock : " & ex.Message)
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

    Public Sub GetManageUserData(searchTerm As String)
        Try
            connect_me()
            Dim query As String = "SELECT id, firstname, lastname, username, usertype, created_at, updated_at FROM users"

            If Not String.IsNullOrEmpty(searchTerm) Then
                query &= " WHERE id LIKE ? OR firstname LIKE ? OR lastname LIKE ? OR username LIKE ?"
            End If

            query &= " ORDER BY updated_at DESC"

            Dim cmd As New OdbcCommand(query, con)
            If Not String.IsNullOrEmpty(searchTerm) Then
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
                cmd.Parameters.AddWithValue("?", searchTerm & "%")
            End If
            Dim adapter As New OdbcDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ManageUser.DgManageUser.Rows.Clear()

            For Each row As DataRow In table.Rows
                ManageUser.DgManageUser.Rows.Add(row("id"), row("firstname"), row("lastname"), row("username"), row("usertype"), row("created_at"), row("updated_at"), "EDIT", "DELETE")
            Next

            ManageUser.DgManageUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class
