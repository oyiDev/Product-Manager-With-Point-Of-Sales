Public Class POSForm

    Private Sub POSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New OrderRepo
        Timer1.Start()
        repo.get_number()
        txtnumber.Hide()
        dgTransaction.Enabled = False
        dgTransaction.DefaultCellStyle.SelectionBackColor = Color.White
        dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        Me.KeyPreview = True

        Try
            connect_me()
        Catch ex As Exception
            MessageBox.Show("Error connectinf to database: " & ex.Message)
        End Try
    End Sub

    Private Sub POSForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F8
                BtnRecord.PerformClick()
            Case Keys.F9
                btnItemList.PerformClick()
            Case Keys.F10
                If dgTransaction.Rows.Count > 0 Then
                    BtnEditQty.PerformClick()
                End If
            Case Keys.F11
                If dgTransaction.Rows.Count > 0 Then
                    btnDelete.PerformClick()
                End If
            Case Keys.F12
                If dgTransaction.Rows.Count > 0 Then
                    btnSubtotal.PerformClick()
                End If
            Case Keys.X
                If e.Control Then
                    btnExit.PerformClick()
                End If
            Case Keys.Z
                If e.Control Then
                    btnZRead.PerformClick()
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

    Private Sub btnSubtotal_Click(sender As Object, e As EventArgs) Handles btnSubtotal.Click
        If dgTransaction.Rows.Count > 0 Then
            PaymentForm.Show()
            Me.Enabled = False
            PaymentForm.txtCash.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgTransaction.Rows.Count > 0 Then
            dgTransaction.Enabled = True
            lblAction.Text = "DELETE"
            dgTransaction.Focus()
            dgTransaction.DefaultCellStyle.SelectionBackColor = Color.Tomato
            dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Tomato
        End If
    End Sub

    Private Sub BtnEditQty_Click(sender As Object, e As EventArgs) Handles BtnEditQty.Click
        If dgTransaction.Rows.Count > 0 Then
            dgTransaction.Enabled = True
            lblAction.Text = "EDIT"
            dgTransaction.Focus()
            dgTransaction.DefaultCellStyle.SelectionBackColor = Color.Gold
            dgTransaction.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gold
        End If
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As Integer
        res = MessageBox.Show("Exit Application?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = vbOK Then
            LoginForm.Show()
            con.Close()
            LoginForm.txtPassword.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub btnItemList_Click(sender As Object, e As EventArgs) Handles btnItemList.Click
        ItemListForm.Show()
        Me.Enabled = False
        ItemListForm.TxtSearch.Focus()
        ItemListForm.DgItemList.Refresh()
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, bnt9.Click
        Dim button As Button = CType(sender, Button)
        txtBarcode.Text &= button.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBarcode.Clear()
    End Sub

    Private Sub btnZRead_Click(sender As Object, e As EventArgs) Handles btnZRead.Click
        ReadingForm.Show()
        ReadingForm.c1.Focus()
        Me.Enabled = False
    End Sub

    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles BtnRecord.Click
        DiscountForm.Show()
        DiscountForm.lbldisType.Text = "CASH OUT"
        DiscountForm.LblName.Text = "REMARK"
        DiscountForm.Lblnumber.Text = "AMOUNT"
        Me.Enabled = False
    End Sub
End Class