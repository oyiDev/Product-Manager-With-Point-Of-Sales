Public Class ManageProduct

    Dim productRepo As New ProductRepo
    Dim mdf As New ManageDataRefresher
    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdf.GetManageProductData()
        productRepo.HighlightZeroQtyCells(DgManageProduct, "qty")
        productRepo.HighlightAvailableProduct(DgManageProduct, "qty")
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddProduct.ShowDialog()
        productRepo.Get_id()
        AddProduct.TxtBarcode.Focus()
    End Sub
    Private Sub search_product_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProduct.TextChanged
        Dim repo As New ProductRepo
        repo.SearchProduct(TxtSearchProduct.Text.Trim())
    End Sub
End Class



