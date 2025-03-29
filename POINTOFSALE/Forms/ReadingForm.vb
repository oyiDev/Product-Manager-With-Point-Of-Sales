Public Class ReadingForm

    Dim orderrepo As New OrderRepo

    Private Sub ReadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderrepo.SalesReport()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("No transactions to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        orderrepo.PrintSalesReport()
        'ConTransForm.Show()
        TxtNetAmount.Text = ".00"
        TxtOthersPayment.Text = ".00"
        TxtTDiscount.Text = ".00"
        TxtCashSales.Text = ".00"
        TxtTCashOut.Text = ".00"
        TxtTotalCash.Text = ".00"
        Me.Hide()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        POSForm.Enabled = True
        POSForm.txtBarcode.Focus()
        Me.Hide()
    End Sub
End Class