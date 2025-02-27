Imports System.Data.Common
Imports System.Threading.Tasks

Public Class PaymentForm

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        txtCash.Text = System.Text.RegularExpressions.Regex.Replace(txtCash.Text, "[^0-9.,]", "")
        txtCash.SelectionStart = txtCash.Text.Length
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        Dim price As Decimal
        If e.KeyCode = Keys.Enter Then
            If Decimal.TryParse(txtCash.Text, price) Then
                ' Format with commas and two decimal places
                txtCash.Text = price.ToString("N2")
                txtCash.SelectionStart = txtCash.Text.Length
            End If
            btnPayEnter.PerformClick()
        End If

        Select Case e.KeyCode
            Case Keys.Escape
                BtnClose.PerformClick()
            Case Keys.S
                If e.Control Then
                    BtnSenior.PerformClick()
                End If
            Case Keys.P
                If e.Control Then
                    BtnPwd.PerformClick()
                End If
        End Select
    End Sub

    Private firstClick As Boolean = True

    Private Async Sub btnPayEnter_Click(sender As Object, e As EventArgs) Handles btnPayEnter.Click
        Try
            Dim total As Decimal = Convert.ToDecimal(txtGtotal.Text.Substring(1))
            Dim cash As Decimal = Convert.ToDecimal(txtCash.Text)

            If cash >= total Then
                Dim change As Decimal = cash - total
                txtChange.Text = "₱" & change.ToString("F1")

                ' Change txtCash font color to black temporarily
                Dim originalColor As Color = txtCash.ForeColor
                txtCash.ForeColor = Color.Black
                Await Task.Delay(100)
                txtCash.ForeColor = originalColor

                ' On first click, just show change
                If firstClick Then
                    firstClick = False
                    Return
                End If

                ' On second click, complete transaction
                Dim order As New OrderRepo
                order.UpdateInventory()
                order.PrintReceipt()
                'order.RecordTransaction()
                order.AddTransaction()
                order.ClearDataGridView()

                Dim loadItem As New LoadItemData
                loadItem.LoadItemData("")

                MessageBox.Show("Transaction Completed Successfully")
                POSForm.Enabled = True
                POSForm.txtBarcode.Focus()
                Me.Hide()
            Else
                MessageBox.Show("Insufficient amount received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCash.Text = txtGtotal.Text
                txtCash.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSenior_Click(sender As Object, e As EventArgs) Handles BtnSenior.Click
        DiscountForm.lbldisType.Text = "SENIOR"
        DiscountForm.Show()
        DiscountForm.TxtName.Focus()
        Me.Enabled = False
    End Sub

    Private Sub BtnPwd_Click(sender As Object, e As EventArgs) Handles BtnPwd.Click
        DiscountForm.lbldisType.Text = "PWD"
        DiscountForm.Show()
        DiscountForm.TxtName.Focus()
        Me.Enabled = False
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim repo As New OrderRepo
        repo.ClearDataGridView()
        POSForm.Enabled = True
        Me.Hide()
    End Sub
End Class