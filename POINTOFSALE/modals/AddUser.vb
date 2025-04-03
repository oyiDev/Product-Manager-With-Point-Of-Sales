Public Class AddUser
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdd_MouseEnter(sender As Object, e As EventArgs) Handles BtnSave.MouseEnter
        BtnSave.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnAdd_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub BtnCancel_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.BackColor = Color.Tomato
    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TxtFname_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFname.KeyDown
        If e.KeyCode = 13 Then
            If TxtFname.Text = "" Then
                MessageBox.Show("Enter First Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtLname.Focus()
            End If
        End If
    End Sub

    Private Sub Txtlname_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLname.KeyDown
        If e.KeyCode = 13 Then
            If TxtLname.Text = "" Then
                MessageBox.Show("Enter Last Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub CbRole_KeyDown(sender As Object, e As KeyEventArgs) Handles CbRole.KeyDown
        If e.KeyCode = 13 Then
            If CbRole.Text = "" Then
                MessageBox.Show("Select User Type", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = 13 Then
            If TxtUsername.Text = "" Then
                MessageBox.Show("Enter User Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = 13 Then
            If TxtPass.Text = "" Then
                MessageBox.Show("Enter Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtCpass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCpass.KeyDown
        If e.KeyCode = 13 Then
            If TxtCpass.Text = "" Then
                MessageBox.Show("Confirm Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                BtnSave.Focus()
            End If
        End If
    End Sub

    Private Sub BtnChangepass_Click(sender As Object, e As EventArgs) Handles BtnChangepass.Click
        ChangePasswordForm.TxtOldPass.Focus()
        ChangePasswordForm.ShowDialog()
    End Sub

    Private Sub BtnChangepass_MouseEnter(sender As Object, e As EventArgs) Handles BtnChangepass.MouseEnter
        BtnChangepass.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnChangepass_MouseLeave(sender As Object, e As EventArgs) Handles BtnChangepass.MouseLeave
        BtnChangepass.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim userRepo As New UserRepo
        Dim mdf As New ManageDataRefresher
        Try
            If TxtFname.Text = "" Or TxtLname.Text = "" Or CbRole.Text = "" Or TxtUsername.Text = "" Then
                MessageBox.Show("All Fields Must Be Completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CbRole.Text = "--SELECT--" Then
                MessageBox.Show("SELECT ROLE / USERTYPE.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf BtnSave.Text = "Update" Then
                userRepo.EditUser()
                TxtFname.Clear()
                TxtLname.Clear()
                TxtUsername.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                Me.Close()
            ElseIf TxtFname.Text = "" Or TxtLname.Text = "" Or CbRole.Text = "" Or TxtUsername.Text = "" Or TxtPass.Text = "" Or TxtCpass.Text = "" Then
                MessageBox.Show("All Fields Must Be Completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CbRole.Text = "--SELECT--" Then
                MessageBox.Show("SELECT ROLE / USERTYPE.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not TxtCpass.Text.Trim().ToLower = TxtPass.Text.Trim().ToLower Then
                MessageBox.Show("Incorrect Password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                userRepo.InsertUser()
                TxtFname.Clear()
                TxtLname.Clear()
                TxtUsername.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        TxtFname.Clear()
        TxtLname.Clear()
        TxtUsername.Clear()
        TxtPass.Clear()
        TxtCpass.Clear()
    End Sub
End Class