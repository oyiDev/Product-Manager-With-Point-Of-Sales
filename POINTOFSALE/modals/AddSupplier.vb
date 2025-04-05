Public Class AddSupplier
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        txtId.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim supplierRepo As New SupplierRepo
        Dim mdf As New ManageDataRefresher
        Try
            If txtName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Then
                MessageBox.Show("All Fields Must Be Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                supplierRepo.InsertSupplier()
                txtName.Clear()
                txtPhone.Clear()
                txtAddress.Clear()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class