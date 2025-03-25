Imports System.Data.Odbc

Public Class ProductRepo
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

    Public Sub DeleteProduct()
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            RowWhite()
        Else
            Try
                ' Get selected user info
                Dim selectedRow As DataGridViewRow = InventoryDashboard.DgProduct.Rows(InventoryDashboard.DgProduct.CurrentCell.RowIndex)
                Dim barcode As String = selectedRow.Cells("barcode").Value.ToString()

                ' Connect to the database and delete the user
                connect_me()
                Dim query As String = "DELETE FROM products WHERE barcode = ?"
                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("?", barcode)
                    cmd.ExecuteNonQuery()
                End Using

                ' Refresh the DataGridView after deletion
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RowWhite()
                LoadUser()
            Catch ex As Exception
                MessageBox.Show("Error deleting Product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Public Sub LoadUser()
        Try
            Dim mycmd As New OdbcCommand("SELECT id, category AS Category, barcode AS Barcode, genericname AS Genericname, brandname AS Brandname,
formula AS Formula, description AS Description, price AS Price, qty AS Qty, created_at, updated_at FROM products", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New Data.DataSet
            da.Fill(ds, "products")

            InventoryDashboard.DgProduct.DataSource = ds.Tables(0)
            InventoryDashboard.DgProduct.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
            'ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
            InventoryDashboard.DgProduct.Refresh()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading... " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub RowWhite()
        InventoryDashboard.DgProduct.RowHeadersVisible = False
        InventoryDashboard.DgProduct.Enabled = False
        InventoryDashboard.DgProduct.DefaultCellStyle.SelectionBackColor = Color.White
        InventoryDashboard.DgProduct.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    End Sub

    Public Sub getProductData()
        connect_me()
        Dim mycmd As New OdbcCommand("select * from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        InventoryDashboard.DgProduct.DataSource = ds.Tables(0)
        InventoryDashboard.DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        InventoryDashboard.DgProduct.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        'dg_transaction.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Gainsboro
        InventoryDashboard.DgProduct.Refresh()
    End Sub

    Public Sub SearchProduct(searchTerm As String)
        Try
            connect_me()
            Dim query As String = "SELECT * FROM products WHERE barcode LIKE ? OR genericname LIKE ? OR brandname LIKE ? OR id LIKE ?"

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")

                Dim adapter As New OdbcDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                InventoryDashboard.DgProduct.DataSource = table
                InventoryDashboard.DgProduct.Refresh()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Loading Item: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class


