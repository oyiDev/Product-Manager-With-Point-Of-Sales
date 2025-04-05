Imports System.Data.Odbc

Public Class ProductRepo

    Public Sub HighlightAvailableProduct(ByVal dgv As DataGridView, ByVal columnName As String)
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then ' Ensure we don't process the new row placeholder
                Dim cell As DataGridViewCell = row.Cells(columnName)
                If cell.Value IsNot Nothing AndAlso IsNumeric(cell.Value) AndAlso CInt(cell.Value) > 10 Then
                    cell.Style.BackColor = Color.Lime ' Highlight the cell in red
                    cell.Style.ForeColor = Color.Black ' Change text color for better visibility
                End If
            End If
        Next
    End Sub

    Public Sub HighlightZeroQtyCells(ByVal dgv As DataGridView, ByVal columnName As String)
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then ' Ensure we don't process the new row placeholder
                Dim cell As DataGridViewCell = row.Cells(columnName)
                If cell.Value IsNot Nothing AndAlso IsNumeric(cell.Value) AndAlso CInt(cell.Value) <= 10 Then
                    cell.Style.BackColor = Color.Tomato ' Highlight the cell in red
                    cell.Style.ForeColor = Color.White ' Change text color for better visibility
                End If
            End If
        Next
    End Sub

    Public Sub HighlightExpiredProduct(ByVal dgv As DataGridView, ByVal columnName As String)
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim cell As DataGridViewCell = row.Cells(columnName)
                If cell.Value IsNot Nothing AndAlso IsDate(cell.Value) AndAlso CDate(cell.Value) < Date.Today Then
                    cell.Style.BackColor = Color.Black ' Highlight expired products in Black
                    cell.Style.ForeColor = Color.White
                End If
            End If
        Next
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
            AddProduct.TxtBarcode.Focus()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading id..." & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub InnsertProduct()
        Dim query As String = "INSERT INTO products (id, category, barcode, genericname, brandname, formula, description, price, qty, expiredate) VALUES (?,?,?,?,?,?,?,?,?,?)"
        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", AddProduct.TxtId.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.CbCategory.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtBarcode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtGenericname.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtBrandname.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtFormula.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtDescription.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.Nqty.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtPrice.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtExpireDate.Text.Trim().ToUpper())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Product Added Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim mdf As New ManageDataRefresher
                AddProduct.AddProductTxtClear()
                Get_id()
                mdf.GetManageProductData("")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Inseting Product : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddProduct.TxtBarcode.Focus()
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteProduct(ByVal id As String)
        Dim query As String = "DELETE FROM products WHERE id = ?"
        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product Deleted Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Deleting Product : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub UpdateProduct()
        Dim query As String = "UPDATE products SET category = ?, barcode = ?, genericname = ?, brandname = ?, formula = ?, description = ?, price = ?, qty = ?, expiredate = ? WHERE id = ?"
        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", AddProduct.CbCategory.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtBarcode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtGenericname.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtBrandname.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtFormula.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtDescription.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtPrice.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.Nqty.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtExpireDate.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", AddProduct.TxtId.Text.Trim().ToUpper())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product Updated Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim mdf As New ManageDataRefresher
                AddProduct.AddProductTxtClear()
                mdf.GetManageProductData("")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Updating Product : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddProduct.TxtBarcode.Focus()
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ProductReport()
        Dim res As Integer = MessageBox.Show("Print report?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbYes Then
            Dim dt As New DataTable
            dt.Columns.Add("barcode", Type.GetType("System.String"))
            dt.Columns.Add("category", Type.GetType("System.String"))
            dt.Columns.Add("genericname", Type.GetType("System.String"))
            dt.Columns.Add("brandname", Type.GetType("System.String"))
            dt.Columns.Add("formula", Type.GetType("System.String"))
            dt.Columns.Add("description", Type.GetType("System.String"))
            dt.Columns.Add("price", Type.GetType("System.String"))

            ' Loop through the DataGridView rows and add them to the DataTable
            For Each row As DataGridViewRow In ManageProduct.DgManageProduct.Rows
                If Not row.IsNewRow Then
                    dt.Rows.Add(row.Cells("barcodeCol").Value.ToString(), row.Cells("categoryCol").Value.ToString(), row.Cells("genericnameCol").Value.ToString(),
                    row.Cells("brandnameCol").Value.ToString(), row.Cells("formulaCol").Value.ToString(), row.Cells("descriptionCol").Value.ToString(), row.Cells("priceCol").Value.ToString())
                End If
            Next

            PrintForm.Show()
            PrintForm.WindowState = FormWindowState.Maximized
            Dim report As New ProductReport
            report.SetDataSource(dt)

            'Print the report
            report.PrintToPrinter(1, False, 0, 0)
            PrintForm.CViewer.ReportSource = report
        Else
            MessageBox.Show("Without receipt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub PullProductExpired()
        Dim query As String = "SELECT * FROM products WHERE expiredate < ?"
        Try
            connect_me()

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", Date.Today)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Dim expiredProducts As New List(Of String)

                    ' Process each expired product
                    While reader.Read()
                        Dim id As String = If(IsDBNull(reader("id")), String.Empty, reader("id").ToString())
                        Dim category As String = If(IsDBNull(reader("category")), String.Empty, reader("category").ToString())
                        Dim barcode As String = If(IsDBNull(reader("barcode")), String.Empty, reader("barcode").ToString())
                        Dim genericName As String = If(IsDBNull(reader("genericname")), String.Empty, reader("genericname").ToString())
                        Dim brandName As String = If(IsDBNull(reader("brandname")), String.Empty, reader("brandname").ToString())
                        Dim formula As String = If(IsDBNull(reader("formula")), String.Empty, reader("formula").ToString())
                        Dim description As String = If(IsDBNull(reader("description")), String.Empty, reader("description").ToString())
                        Dim price As Decimal = If(IsDBNull(reader("price")), 0D, Convert.ToDecimal(reader("price")))
                        Dim qty As Integer = If(IsDBNull(reader("qty")), 0, Convert.ToInt32(reader("qty")))
                        Dim expireDate As DateTime = If(IsDBNull(reader("expiredate")), DateTime.MinValue, Convert.ToDateTime(reader("expiredate")))

                        expiredProducts.Add($"ID: {id}, Category: {category}, Barcode: {barcode}, Genericname: {genericName}, Expired on: {expireDate.ToShortDateString()}")
                    End While

                    ' Show expired products in a custom form with a print button
                    If expiredProducts.Count > 0 Then
                        Dim expiredForm As New ExpiredProductsForm(expiredProducts)
                        expiredForm.Show()
                        adminDashboard.Enabled = False
                    Else
                        MessageBox.Show("No expired products found.", "No Expired Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No expired products found.", "No Expired Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching expired products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteExpiredProducts()
        Try
            Dim query As String = "SELECT * FROM products WHERE expiredate < ?"
            connect_me() ' Connect to the database

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", Date.Today)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        ' Get the product ID
                        Dim id As String = reader("id").ToString()

                        ' Delete the expired product from the database
                        Dim deleteQuery As String = "DELETE FROM products WHERE id = ?"
                        Using deleteCmd As New OdbcCommand(deleteQuery, con)
                            deleteCmd.Parameters.AddWithValue("?", id)
                            deleteCmd.ExecuteNonQuery() ' Execute delete query
                            adminDashboard.Focus()
                        End Using
                    End While
                End If
            End Using
            adminDashboard.Focus()
        Catch ex As Exception
            MessageBox.Show("Error deleting expired products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Sub

    Public Sub RefillProduct(rowIndex As Integer)
        Try
            ' Get the current quantity of the product from the DataGridView
            Dim qty As Integer = Convert.ToInt32(ManageStock.DgManageStock.Rows(rowIndex).Cells("qty").Value)
            Dim id As Integer = Convert.ToInt32(ManageStock.DgManageStock.Rows(rowIndex).Cells("id").Value)

            ' Prompt the user for the quantity to refill
            Dim input As String = InputBox("Enter the quantity to refill for the product:", "Refill Product")


            If String.IsNullOrEmpty(input) Then
                ' User canceled the input or entered nothing
                Return ' Exit or handle as needed
            End If

            ' Check if input is a valid number
            Dim refillQty As Integer
            If Integer.TryParse(input, refillQty) Then
                ' Check if the input quantity is greater than 0
                If refillQty <= 0 Then
                    MessageBox.Show("Please enter a quantity greater than qty value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Check if the input quantity is more than the available quantity
                If refillQty > qty Then
                    ' Add the input quantity to the current stock quantity
                    Dim newQty As Integer = qty + refillQty
                    ManageStock.DgManageStock.Rows(rowIndex).Cells("qty").Value = newQty

                    ' Update the database with the new quantity (You can use your database update logic here)
                    UpdateProductQuantityInDatabase(id, newQty)

                    ' Show success message
                    MessageBox.Show($"Product has been refilled by {refillQty}. New quantity: {newQty}.", "Refill Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Refill quantity cannot be greater than the available stock quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Invalid input! Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error refilling products quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateProductQuantityInDatabase(id As Integer, newQty As Integer)
        Try
            connect_me()
            Dim query As String = "UPDATE Products SET qty = ? WHERE id = ?"

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", newQty)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
                Dim mdf As New ManageDataRefresher
                mdf.GetManageStockData()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating products quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub PullProductExpired()
        Dim query As String = "SELECT * FROM products WHERE expiredate < ?"
        Try
            connect_me()

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", Date.Today)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Dim expiredProducts As New List(Of String)

                    ' Process each expired product
                    While reader.Read()
                        Dim id As String = If(IsDBNull(reader("id")), String.Empty, reader("id").ToString())
                        Dim category As String = If(IsDBNull(reader("category")), String.Empty, reader("category").ToString())
                        Dim barcode As String = If(IsDBNull(reader("barcode")), String.Empty, reader("barcode").ToString())
                        Dim genericName As String = If(IsDBNull(reader("genericname")), String.Empty, reader("genericname").ToString())
                        Dim brandName As String = If(IsDBNull(reader("brandname")), String.Empty, reader("brandname").ToString())
                        Dim formula As String = If(IsDBNull(reader("formula")), String.Empty, reader("formula").ToString())
                        Dim description As String = If(IsDBNull(reader("description")), String.Empty, reader("description").ToString())
                        Dim price As Decimal = If(IsDBNull(reader("price")), 0D, Convert.ToDecimal(reader("price")))
                        Dim qty As Integer = If(IsDBNull(reader("qty")), 0, Convert.ToInt32(reader("qty")))
                        Dim expireDate As DateTime = If(IsDBNull(reader("expiredate")), DateTime.MinValue, Convert.ToDateTime(reader("expiredate")))

                        expiredProducts.Add($"ID: {id}, Category: {category}, Barcode: {barcode}, Genericname: {genericName}, Expired on: {expireDate.ToShortDateString()}")
                    End While

                    ' Show expired products in a custom form with a print button
                    If expiredProducts.Count > 0 Then
                        Dim expiredForm As New ExpiredProductsForm(expiredProducts)
                        expiredForm.Show()
                        adminDashboard.Enabled = False
                    Else
                        MessageBox.Show("No expired products found.", "No Expired Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No expired products found.", "No Expired Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching expired products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class
