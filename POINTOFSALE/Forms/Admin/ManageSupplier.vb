Imports System.Data.Odbc

Public Class ManageSupplier
    Private Sub addSupplierBtn_Click(sender As Object, e As EventArgs) Handles addSupplierBtn.Click
        'Dim supplierRepo As New SupplierRepo
        'supplierRepo.getSupplier_Id()
        'AddSupplier.ShowDialog()
        'AddSupplier.txtName.Focus()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs)
        dg_Supplier.DefaultCellStyle.SelectionBackColor = Color.Tomato
        dg_Supplier.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Tomato
        dg_Supplier.Focus()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs)
        dg_Supplier.DefaultCellStyle.SelectionBackColor = Color.Gold
        dg_Supplier.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gold
        dg_Supplier.Focus()
    End Sub
End Class