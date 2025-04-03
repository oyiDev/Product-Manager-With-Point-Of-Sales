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
End Class


