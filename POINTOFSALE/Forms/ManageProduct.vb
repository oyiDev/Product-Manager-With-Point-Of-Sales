Public Class ManageProduct

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New ProductRepo
        'repo.getProductData()
        'repo.WrapProductData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddProduct.ShowDialog()
    End Sub

    'Public Sub SearchProductsByAlphabet(ByVal dgv As DataGridView, ByVal firstLetter As String)
    '    Try
    '        ' Ensure DataGridView is not empty
    '        If DgProduct.Rows.Count = 0 Then
    '            MessageBox.Show("No products available to search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        ' Loop through all rows
    '        For Each row As DataGridViewRow In dgv.Rows
    '            If row.Cells("ProductName").Value IsNot Nothing Then
    '                Dim productName As String = row.Cells("ProductName").Value.ToString()

    '                ' Check if the product name starts with the specified letter
    '                If productName.StartsWith(firstLetter, StringComparison.OrdinalIgnoreCase) Then
    '                    row.DefaultCellStyle.BackColor = Color.LightBlue ' Highlight matching rows
    '                    row.Visible = True
    '                Else
    '                    row.DefaultCellStyle.BackColor = Color.White
    '                    row.Visible = False ' Hide non-matching rows
    '                End If
    '            End If
    '        Next

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub dg_product_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Ensure the user is not clicking on the header row
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow = DgProduct.Rows(e.RowIndex)

        '    ' Populate textboxes with the selected row's data
        '    cb_category.Text = row.Cells("category").Value.ToString()
        '    txt_barcode.Text = row.Cells("barcode").Value.ToString()
        '    txt_generic.Text = row.Cells("genericname").Value.ToString()
        '    txt_brand.Text = row.Cells("brandname").Value.ToString()
        '    txt_formula.Text = row.Cells("formula").Value.ToString()
        '    txt_description.Text = row.Cells("description").Value.ToString()
        '    txt_price.Text = row.Cells("price").Value.ToString()
        '    txt_qty.Text = row.Cells("qty").Value.ToString()

        'End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs)
        '    ' Ensure a row is selected
        '    If DgProduct.SelectedRows.Count > 0 Then
        '        Dim selectedRow As DataGridViewRow = DgProduct.SelectedRows(0)

        '        ' Update DataGridView with new values
        '        selectedRow.Cells("category").Value = cb_category.Text
        '        selectedRow.Cells("barcode").Value = txt_barcode.Text
        '        selectedRow.Cells("genericname").Value = txt_generic.Text
        '        selectedRow.Cells("brandname").Value = txt_brand.Text
        '        selectedRow.Cells("formula").Value = txt_formula.Text
        '        selectedRow.Cells("description").Value = txt_description.Text
        '        selectedRow.Cells("price").Value = txt_price.Text
        '        selectedRow.Cells("qty").Value = txt_qty.Text

        '    Else
        '        MessageBox.Show("Please select a product to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If
    End Sub

    Private Sub expiry_date_ValueChanged(sender As Object, e As EventArgs)
        'expiry_date.Format = DateTimePickerFormat.Custom
        'expiry_date.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub search_product_TextChanged(sender As Object, e As EventArgs) Handles search_product.TextChanged
        Dim repo As New ProductRepo
        repo.SearchProduct(search_product.Text.Trim())
    End Sub
End Class



