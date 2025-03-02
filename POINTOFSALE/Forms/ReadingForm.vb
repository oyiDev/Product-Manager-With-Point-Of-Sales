Public Class ReadingForm

    Dim repo As New OrderRepo

    Private Sub ReadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repo.Zread()
    End Sub

    Private Sub c1_TextChanged(sender As Object, e As EventArgs) Handles c1.TextChanged, c5.TextChanged, c10.TextChanged, c20.TextChanged, p50.TextChanged, p100.TextChanged, p200.TextChanged, p500.TextChanged, p1000.TextChanged
        repo.Zread()
    End Sub

    Private Sub BtnPost_Click(sender As Object, e As EventArgs) Handles BtnPost.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("No transactions.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        repo.SaveTransactionsToDatabase()
        repo.PrintZread()
        ConTransForm.Show()
        Me.Enabled = False
    End Sub

    Private Sub BtnPrintDenomination_Click(sender As Object, e As EventArgs) Handles BtnPrintDenomination.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("No transactions to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        repo.PrintZread()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        POSForm.Enabled = True
        Me.Hide()
    End Sub
End Class