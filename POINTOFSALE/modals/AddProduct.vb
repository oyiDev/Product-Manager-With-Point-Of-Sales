Public Class AddProduct
    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New ProductRepo
        repo.Get_id()
        CbCategory.Text = "--SELECT--"
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(txt_barcode.Text) OrElse
       String.IsNullOrWhiteSpace(txt_generic.Text) OrElse
       String.IsNullOrWhiteSpace(txt_brand.Text) OrElse
       String.IsNullOrWhiteSpace(txt_formula.Text) OrElse
       String.IsNullOrWhiteSpace(txt_description.Text) OrElse
       String.IsNullOrWhiteSpace(txt_price.Text) OrElse
       String.IsNullOrWhiteSpace(txt_qty.Text) OrElse
       CbCategory.Text = "--SELECT--" Then

            MessageBox.Show("All Fields Must Be Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed with product insertion
        Dim repo As New ProductRepo
        repo.InnsertProduct()
        repo.getProductData()
        repo.LoadTotalCount("products", Dashboard.LblTotalProduct)
        Me.Hide()
    End Sub
End Class