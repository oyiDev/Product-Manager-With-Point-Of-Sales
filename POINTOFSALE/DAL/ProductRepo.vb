Imports System.Data.Odbc

Public Class ProductRepo
    Public Sub getProductData()
        connect_me()
        Dim mycmd As New OdbcCommand("select * from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        ManageProduct.DgProduct.DataSource = ds.Tables(0)
        ManageProduct.DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ManageProduct.DgProduct.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        'dg_transaction.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Gainsboro
        ManageProduct.DgProduct.Refresh()
    End Sub

    Public Sub Get_id()
        Try
            connect_me()
            Dim number As Integer = 0

            If number = 0 Then
                Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(id), 0) FROM products", con)
                number = Convert.ToInt32(cmdnumber.ExecuteScalar())
            End If

            ' Assign the next transaction number
            AddProduct.TxtId.Text = (number + 1).ToString()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading id..." & ex.Message)
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

    Public Sub InnsertProduct()
        Dim id As String = AddProduct.TxtId.Text.Trim()
        Dim ct As String = AddProduct.CbCategory.Text.Trim()
        Dim br As String = AddProduct.txt_barcode.Text.Trim
        Dim gn As String = AddProduct.txt_generic.Text.Trim
        Dim bn As String = AddProduct.txt_brand.Text.Trim
        Dim fm As String = AddProduct.txt_formula.Text.Trim
        Dim dp As String = AddProduct.txt_description.Text.Trim
        Dim pr As String = AddProduct.txt_price.Text.Trim
        Dim qt As String = AddProduct.txt_qty.Text.Trim
        Dim ed As Date = AddProduct.expiry_date.Value

        Dim query As String = "INSERT INTO products (id, category, barcode, genericname, brandname, formula, description, price, qty, expiredate) VALUES (?,?,?,?,?,?,?,?,?,?)"

        ' If String.IsNullOrWhiteSpace(ct) OrElse
        'String.IsNullOrWhiteSpace(br) OrElse
        'String.IsNullOrWhiteSpace(gn) OrElse
        'String.IsNullOrWhiteSpace(bn) OrElse
        'String.IsNullOrWhiteSpace(fm) OrElse
        'String.IsNullOrWhiteSpace(dp) OrElse
        'String.IsNullOrWhiteSpace(pr) OrElse
        'String.IsNullOrWhiteSpace(qt) Then

        '     ' Show error message
        '     MessageBox.Show("Please fill in all fields before adding a product.",
        '                 "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '     Exit Sub ' Stop execution if validation fails
        ' End If

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", ct)
                cmd.Parameters.AddWithValue("?", br)
                cmd.Parameters.AddWithValue("?", gn)
                cmd.Parameters.AddWithValue("?", bn)
                cmd.Parameters.AddWithValue("?", fm)
                cmd.Parameters.AddWithValue("?", dp)
                cmd.Parameters.AddWithValue("?", pr)
                cmd.Parameters.AddWithValue("?", qt)
                cmd.Parameters.AddWithValue("?", ed)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Product Added Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    'Public Sub DeleteProduct()
    '    ' Confirm deletion
    '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    '    If result = DialogResult.No Then
    '        RowWhite()
    '    Else
    '        Try
    '            ' Get selected user info
    '            Dim selectedRow As DataGridViewRow = ManageProduct.DgProduct.Rows(ManageProduct.DgProduct.CurrentCell.RowIndex)
    '            Dim barcode As String = selectedRow.Cells("barcode").Value.ToString()

    '            ' Connect to the database and delete the user
    '            connect_me()
    '            Dim query As String = "DELETE FROM products WHERE barcode = ?"
    '            Using cmd As New OdbcCommand(query, con)
    '                cmd.Parameters.AddWithValue("?", barcode)
    '                cmd.ExecuteNonQuery()
    '            End Using

    '            ' Refresh the DataGridView after deletion
    '            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            RowWhite()
    '            LoadUser()
    '        Catch ex As Exception
    '            MessageBox.Show("Error deleting Product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Finally
    '            con.Close()
    '        End Try
    '    End If
    'End Sub

    'Public Sub LoadUser()
    '    Try
    '        Dim mycmd As New OdbcCommand("SELECT id, category AS Category, barcode AS Barcode, genericname AS Genericname, brandname AS Brandname,
    '                                    formula AS Formula, description AS Description, price AS Price, qty AS Qty, created_at, updated_at FROM products", con)
    '        Dim da As New OdbcDataAdapter(mycmd)
    '        Dim ds As New Data.DataSet
    '        da.Fill(ds, "products")

    '        ManageProduct.DgProduct.DataSource = ds.Tables(0)
    '        ManageProduct.DgProduct.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
    '        'ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    '        ManageProduct.DgProduct.Refresh()
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred while loading... " & ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

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

                ManageProduct.DgProduct.DataSource = table
                ManageProduct.DgProduct.Refresh()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Loading Item: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub RowWhite()
        ManageProduct.DgProduct.RowHeadersVisible = False
        ManageProduct.DgProduct.Enabled = False
        ManageProduct.DgProduct.DefaultCellStyle.SelectionBackColor = Color.White
        ManageProduct.DgProduct.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    End Sub

    Public Sub WrapProductData(dg As DataGridView)
        dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
        dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg.DefaultCellStyle.SelectionBackColor = Color.White
        dg.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    End Sub
End Class


