Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
        TxtUsername.Text = "Ally1"
        TxtPassword.Text = "123"
        btnLogin.Focus()
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = 13 Then
            If TxtUsername.Text = "" Then
                MessageBox.Show("Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = 13 Then
            If TxtPassword.Text = "" Then
                MessageBox.Show("Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                btnLogin.Focus()
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userRepo As New UserRepo
        Dim username As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()
        Dim userInfo As UserInfo = userRepo.GetUserRole(username, password)

        If userInfo IsNot Nothing AndAlso userInfo.Role = "ADMIN" Then
            MessageBox.Show("Welcome Admin!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPassword.Clear()
            TxtUsername.Clear()
            adminDashboard.Show()
            Me.Hide()
        ElseIf userInfo IsNot Nothing AndAlso userInfo.Role = "CASHIER" Then
            MessageBox.Show("Welcome Cashier!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPassword.Clear()
            TxtUsername.Clear()
            POSForm.Show()
            POSForm.txtBarcode.Focus()
            userRepo.DisplayUserInfo()
            Me.Hide()
        Else
            MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Clear()
            TxtPassword.Clear()
        End If
    End Sub
End Class
