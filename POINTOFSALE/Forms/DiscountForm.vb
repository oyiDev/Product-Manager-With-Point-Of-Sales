Public Class DiscountForm

    Private Sub DiscountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New OrderRepo
        repo.get_id()
        lblid.Hide()
    End Sub

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
        repo.get_id()

        Dim name As String = TxtName.Text.Trim.ToLower()
        Dim id As String = TxtIdNum.Text.Trim.ToLower()

        If name = "" Then
            MessageBox.Show("Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf id = "" Then
            MessageBox.Show("Enter ID Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If LblType.Text = "DISCOUNT" Then
                MessageBox.Show("The Discount is 20%")
                repo.TransactionWithDiscount()
                PaymentForm.Enabled = True
                PaymentForm.txtCash.Focus()
                Me.Hide()
                TxtName.Clear()
                TxtIdNum.Clear()
            ElseIf LblType.Text = "CASHOUT" Then
                repo.RecordCashOut()
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        POSForm.Enabled = True
        POSForm.txtBarcode.Focus()
        PaymentForm.Enabled = True
        Me.Hide()
    End Sub
End Class