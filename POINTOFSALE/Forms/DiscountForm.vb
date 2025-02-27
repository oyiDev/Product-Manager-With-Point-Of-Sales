Public Class DiscountForm

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = 13 Then
            If TxtName.Text = "" Then
                MessageBox.Show("Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtIdNum.Focus()
            End If
        End If
    End Sub

    Private Sub TxtIdNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtIdNum.KeyDown
        If e.KeyCode = 13 Then
            If TxtIdNum.Text = "" Then
                MessageBox.Show("Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                BtnEnter.Focus()
            End If
        End If
    End Sub

    Private Sub TxtIdNum_TextChanged(sender As Object, e As EventArgs) Handles TxtIdNum.TextChanged
        TxtIdNum.Text = System.Text.RegularExpressions.Regex.Replace(TxtIdNum.Text, "[^0-9]", "")
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim repo As New OrderRepo
        repo.AddDiscount()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PaymentForm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub DiscountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class