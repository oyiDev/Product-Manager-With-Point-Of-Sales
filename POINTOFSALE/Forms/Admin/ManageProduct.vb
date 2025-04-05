Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class ManageProduct

    Dim productRepo As New ProductRepo
    Dim mdf As New ManageDataRefresher

    Private Sub CbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFilter.SelectedIndexChanged
        mdf.GetManageProductData("")
    End Sub

    Private Sub BtnAdd_MouseEnter(sender As Object, e As EventArgs) Handles BtnAdd.MouseEnter
        BtnAdd.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub BtnAdd_MouseLeave(sender As Object, e As EventArgs) Handles BtnAdd.MouseLeave
        BtnAdd.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TxtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProduct.TextChanged
        mdf.GetManageProductData(TxtSearchProduct.Text)
    End Sub

    Private Sub CbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFilter.SelectedIndexChanged
        mdf.GetManageProductData("")
    End Sub

    Private Sub BtnAdd_MouseEnter(sender As Object, e As EventArgs) Handles BtnAdd.MouseEnter
        BtnAdd.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub BtnAdd_MouseLeave(sender As Object, e As EventArgs) Handles BtnAdd.MouseLeave
        BtnAdd.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TxtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProduct.TextChanged
        mdf.GetManageProductData(TxtSearchProduct.Text)
        CbFilter.Text = "CATEGORY"
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        productRepo.Get_id()
        AddProduct.CbCategory.Text = "--SELECT--"
        AddProduct.FormatPriceTextBox(AddProduct.TxtPrice)
        AddProduct.TxtShow()
        AddProduct.BtnSave.Text = "SAVE"
        AddProduct.TxtBarcode.Focus()
        AddProduct.ShowDialog()
    End Sub


    Private Sub DgManageProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgManageProduct.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DgManageProduct.Rows(e.RowIndex)
                If DgManageProduct.Columns(e.ColumnIndex).Name = "editCol" Then
                    Dim result As DialogResult = MessageBox.Show("EDIT Product?", "EDIT Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        AddProduct.TxtId.Text = selectedRow.Cells("idCol").Value.ToString()
                        AddProduct.TxtBarcode.Text = selectedRow.Cells("barcodeCol").Value.ToString()
                        AddProduct.CbCategory.Text = selectedRow.Cells("categoryCol").Value.ToString()
                        AddProduct.TxtGenericname.Text = selectedRow.Cells("genericnameCol").Value.ToString()
                        AddProduct.TxtBrandname.Text = selectedRow.Cells("brandnameCol").Value.ToString()
                        AddProduct.TxtFormula.Text = selectedRow.Cells("formulaCol").Value.ToString()
                        AddProduct.TxtDescription.Text = selectedRow.Cells("descriptionCol").Value.ToString()
                        AddProduct.TxtPrice.Text = selectedRow.Cells("priceCol").Value.ToString()
                        AddProduct.Nqty.Text = selectedRow.Cells("qtyCol").Value.ToString()
                        AddProduct.TxtExpireDate.Text = CType(selectedRow.Cells("expireCol").Value, Date).ToString("yyyy-MM-dd")
                        AddProduct.LblQty.Hide()
                        AddProduct.Nqty.Hide()
                        AddProduct.LblExd.Hide()
                        AddProduct.TxtExpireDate.Hide()
                        AddProduct.LblDateFormat.Hide()
                        AddProduct.BtnSave.Text = "UPDATE"
                        AddProduct.ShowDialog()
                    End If
                ElseIf DgManageProduct.Columns(e.ColumnIndex).Name = "deleteCol" Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this product?", "DELETE Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        productRepo.DeleteProduct(selectedRow.Cells("idCol").Value.ToString())
                        CbFilter.Text = "CATEGORY"
                        mdf.GetManageProductData("")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub search_product_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProduct.TextChanged
        Dim repo As New ProductRepo
        repo.SearchProduct(TxtSearchProduct.Text.Trim())


    Private Sub DgManageProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgManageProduct.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DgManageProduct.Rows(e.RowIndex)
                If DgManageProduct.Columns(e.ColumnIndex).Name = "editCol" Then
                    Dim result As DialogResult = MessageBox.Show("EDIT Product?", "EDIT Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        AddProduct.TxtId.Text = selectedRow.Cells("idCol").Value.ToString()
                        AddProduct.TxtBarcode.Text = selectedRow.Cells("barcodeCol").Value.ToString()
                        AddProduct.CbCategory.Text = selectedRow.Cells("categoryCol").Value.ToString()
                        AddProduct.TxtGenericname.Text = selectedRow.Cells("genericnameCol").Value.ToString()
                        AddProduct.TxtBrandname.Text = selectedRow.Cells("brandnameCol").Value.ToString()
                        AddProduct.TxtFormula.Text = selectedRow.Cells("formulaCol").Value.ToString()
                        AddProduct.TxtDescription.Text = selectedRow.Cells("descriptionCol").Value.ToString()
                        AddProduct.TxtPrice.Text = selectedRow.Cells("priceCol").Value.ToString()
                        AddProduct.Nqty.Text = selectedRow.Cells("qtyCol").Value.ToString()
                        AddProduct.TxtExpireDate.Text = CType(selectedRow.Cells("expireCol").Value, Date).ToString("yyyy-MM-dd")
                        AddProduct.LblQty.Hide()
                        AddProduct.Nqty.Hide()
                        AddProduct.LblExd.Hide()
                        AddProduct.TxtExpireDate.Hide()
                        AddProduct.LblDateFormat.Hide()
                        AddProduct.BtnSave.Text = "UPDATE"
                        AddProduct.ShowDialog()
                    End If
                ElseIf DgManageProduct.Columns(e.ColumnIndex).Name = "deleteCol" Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this product?", "DELETE Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        productRepo.DeleteProduct(selectedRow.Cells("idCol").Value.ToString())
                        CbFilter.Text = "CATEGORY"
                        mdf.GetManageProductData("")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
End Class



