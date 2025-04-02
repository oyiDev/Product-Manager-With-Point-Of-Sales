Public Class POSForm

    Private Sub POSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New OrderRepo
        Timer1.Start()
        repo.get_number()
        txtnumber.Hide()
        dgTransaction.DefaultCellStyle.SelectionBackColor = Color.White
        dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        Me.KeyPreview = True
        Try
            connect_me()
        Catch ex As Exception
            MessageBox.Show("Error connectinf to database: " & ex.Message)
        End Try
    End Sub

    Private Sub dgTransaction_KeyDown(sender As Object, e As KeyEventArgs) Handles dgTransaction.KeyDown
        Dim orderRepo As New OrderRepo
        Select Case e.KeyCode
            Case Keys.Enter
                If lblAction.Text = "DELETE" Then
                    orderRepo.DeleteItem(e)
                    dgTransaction.DefaultCellStyle.SelectionBackColor = Color.White
                    dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                ElseIf lblAction.Text = "EDIT" Then
                    orderRepo.EditItemQty()
                    dgTransaction.DefaultCellStyle.SelectionBackColor = Color.White
                    dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub POSForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F8
                BtnCashout.PerformClick()
            Case Keys.F9
                BtnItemList.PerformClick()
            Case Keys.F10
                BtnEditQty.PerformClick()
            Case Keys.F11
                BtnDelete.PerformClick()
            Case Keys.T
                If e.Control Then
                    BtnTransRecord.PerformClick()
                End If
            Case Keys.F12
                BtnSubTotal.PerformClick()
            Case Keys.X
                If e.Control Then
                    BtnExit.PerformClick()
                End If
            Case Keys.S
                If e.Control Then
                    BtnSales.PerformClick()
                End If
        End Select
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        txtBarcode.Text = System.Text.RegularExpressions.Regex.Replace(txtBarcode.Text, "[^0-9]", "")
        txtBarcode.SelectionStart = txtBarcode.Text.Length
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        Dim orderRepo As New OrderRepo
        If e.KeyCode = Keys.Enter Then
            orderRepo.ScanProduct(txtBarcode.Text.Trim)
            txtBarcode.Clear()
        End If
    End Sub

    Private Sub BtnCashout_Click(sender As Object, e As EventArgs) Handles BtnCashout.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("There is Nothing in Drawer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        DiscountForm.Show()
        DiscountForm.LblType.Text = "CASHOUT"
        DiscountForm.LblName.Text = "REMARK"
        DiscountForm.Lblnumber.Text = "AMOUNT"
        Me.Enabled = False
    End Sub

    Private Sub BtnItemList_Click(sender As Object, e As EventArgs) Handles BtnItemList.Click
        ItemListForm.ShowDialog()
        ItemListForm.TxtSearch.Focus()
    End Sub

    Private Sub BtnEditQty_Click(sender As Object, e As EventArgs) Handles BtnEditQty.Click
        If dgTransaction.Rows.Count = 0 OrElse (dgTransaction.Rows.Count = 1 AndAlso dgTransaction.Rows(0).IsNewRow) Then
            MessageBox.Show("There is Nothing to EDIT.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If dgTransaction.Rows.Count > 0 Then
            dgTransaction.Enabled = True
            lblAction.Text = "EDIT"
            dgTransaction.Focus()
            dgTransaction.DefaultCellStyle.SelectionBackColor = Color.Gold
            dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gold
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dgTransaction.Rows.Count = 0 OrElse (dgTransaction.Rows.Count = 1 AndAlso dgTransaction.Rows(0).IsNewRow) Then
            MessageBox.Show("There is Nothing to DELETE.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If dgTransaction.Rows.Count > 0 Then
            dgTransaction.Enabled = True
            lblAction.Text = "DELETE"
            dgTransaction.Focus()
            dgTransaction.DefaultCellStyle.SelectionBackColor = Color.Tomato
            dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Tomato
        End If
    End Sub

    Private Sub BtnTransRecord_Click(sender As Object, e As EventArgs) Handles BtnTransRecord.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("ther is No todays transactions.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        TransactionForm.ShowDialog()
    End Sub

    Private Sub BtnSubTotal_Click(sender As Object, e As EventArgs) Handles BtnSubTotal.Click
        If dgTransaction.Rows.Count = 0 OrElse (dgTransaction.Rows.Count = 1 AndAlso dgTransaction.Rows(0).IsNewRow) Then
            MessageBox.Show("There is Nothing to TRANSACT.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If dgTransaction.Rows.Count > 0 Then
            PaymentForm.Show()
            Me.Enabled = False
            PaymentForm.txtCash.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim res As Integer
        res = MessageBox.Show("Exit Application?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = vbOK Then
            LoginForm.Show()
            con.Close()
            LoginForm.TxtPassword.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
            MessageBox.Show("There is No transactions.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim repo As New OrderRepo
        repo.SalesReport()
        ReadingForm.ShowDialog()
    End Sub
End Class