Public Class ConTransForm
    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Dim res As Integer = MessageBox.Show("To day Sales is continue?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = vbOK Then
            POSForm.Enabled = True
            ReadingForm.Enabled = True
            TransactionForm.dgRecordTrans.Rows.Clear()
            ReadingForm.Hide()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Dim res As Integer = MessageBox.Show("Today's Sales is closed", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If res = vbOK Then
            ' Set StopScanActive to True (pause scanning)
            StopScanActive = True
            Console.WriteLine("The value of Stop scanning is: " & StopScanActive)

            Dim repo As New OrderRepo
            repo.ReadingFormater()
            repo.ClearDataGridView()

            TransactionForm.dgRecordTrans.Rows.Clear()
            POSForm.Enabled = True
            ReadingForm.Hide()
            Me.Hide()
        End If
    End Sub
End Class