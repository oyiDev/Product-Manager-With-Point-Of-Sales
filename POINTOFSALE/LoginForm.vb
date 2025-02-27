Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUsername.Text = "Admin"
        txtPassword.Focus()
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = 13 Then
            If txtPassword.Text = "" Then
                MessageBox.Show("Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                btnLogin.Focus()
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userRepo As New UserRepo
        Dim usertype As String = cbUsername.Text.ToLower.Trim
        Dim password As String = txtPassword.Text.ToLower.Trim
        Dim userInfo As UserInfo = userRepo.GetUserRole(usertype, password)

        If password = "" Then
            MessageBox.Show("Enter password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()

        ElseIf userInfo IsNot Nothing AndAlso userInfo.Role = "admin" Then
            MessageBox.Show("Welcome Admin!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Admin Dash Board
            txtPassword.Clear()
            Me.Hide()

        ElseIf userInfo IsNot Nothing AndAlso userInfo.Role = "cashier" Then
            MessageBox.Show("Welcome Cashier!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            POSForm.Show()
            POSForm.txtBarcode.Focus()
            userRepo.DisplayUserInfo()
            Me.Hide()

        Else
            MessageBox.Show("Invalid password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
End Class
