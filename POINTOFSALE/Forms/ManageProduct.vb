Public Class ManageProduct

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New ProductRepo
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddProduct.ShowDialog()
    End Sub

    Private Sub search_product_TextChanged(sender As Object, e As EventArgs) Handles search_product.TextChanged
        Dim repo As New ProductRepo
        repo.SearchProduct(search_product.Text.Trim())
    End Sub
End Class



