Public Class ConTransForm
    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Dim res As Integer = MessageBox.Show("To day transaction is continue?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = vbOK Then
            POSForm.Enabled = True
            ReadingForm.Enabled = True
            TransactionForm.dgRecordTrans.Rows.Clear()
            ReadingForm.Hide()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Dim res As DialogResult = MessageBox.Show("Today's transaction is closed", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If res = DialogResult.OK Then
            ' Set StopScanActive to True (pause scanning)
            StopScan.StopScanActive = True

            Dim repo As New OrderRepo
            repo.ClearRedings()
            repo.ClearDataGridView()

            ReadingForm.Enabled = True
            POSForm.Enabled = True
            ReadingForm.Hide()
            Me.Hide()
        End If
    End Sub
End Class