Public Class ChangePasswordForm

    Dim userRepo As New UserRepo

    Private Sub TxtOldPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtOldPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TxtOldPass.Text.Trim()) Then
                MessageBox.Show("Enter old password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtNewPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNewPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNewPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TxtNewPass.Text.Trim()) Then
                MessageBox.Show("Enter new password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtConfirmPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtConfirmPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtConfirmPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TxtConfirmPass.Text.Trim()) Then
                MessageBox.Show("Enter confirm password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                BtnUpdate.Focus()
            End If
        End If
    End Sub

    Private Sub BtnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles BtnUpdate.MouseEnter
        BtnUpdate.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles BtnUpdate.MouseLeave
        BtnUpdate.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnCancel_MouseEnter(sender As Object, e As EventArgs) Handles BtnCancel.MouseEnter
        BtnCancel.BackColor = Color.Tomato
    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave
        BtnCancel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim oldPassword As String = TxtOldPass.Text.Trim()
        Dim newPassword As String = TxtNewPass.Text.Trim()
        Dim confirmPassword As String = TxtConfirmPass.Text.Trim()

        If String.IsNullOrEmpty(oldPassword) Then
            MessageBox.Show("Enter old password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Enter new password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Enter confirm password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not newPassword.Trim().ToLower = confirmPassword.Trim().ToLower Then
            MessageBox.Show("Password does not match.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            userRepo.UpdatePassword()
            TxtOldPass.Clear()
            TxtNewPass.Clear()
            TxtConfirmPass.Clear()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        TxtOldPass.Clear()
        TxtNewPass.Clear()
        TxtConfirmPass.Clear()
    End Sub
End Class