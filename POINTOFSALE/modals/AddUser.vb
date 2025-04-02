Public Class AddUser
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbRole.Text = "--SELECT--"
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        TxtFname.Clear()
        TxtLname.Clear()
        TxtUsername.Clear()
        TxtPass.Clear()
        TxtCpass.Clear()
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
                BtnAdd.Focus()
            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim userRepo As New UserRepo
        Dim mdf As New ManageDataRefresher
        Try
            If TxtFname.Text = "" Or TxtLname.Text = "" Or CbRole.Text = "" Or TxtPass.Text = "" Or TxtCpass.Text = "" Then
                MessageBox.Show("All Fields Must Be Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf CbRole.Text = "--SELECT--" Then
                MessageBox.Show("SELECT ROLE / USERTYPE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not TxtCpass.Text.Trim().ToLower = TxtPass.Text.Trim().ToLower Then
                MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ManageUser.LblAction.Text = "/ EDIT" Then
                userRepo.EditUser()
                TxtFname.Clear()
                TxtLname.Clear()
                TxtUsername.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                mdf.GetManageUserData()
                ManageUser.DgManageUser.DefaultCellStyle.SelectionBackColor = Color.White
                ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                Me.Hide()
            Else
                userRepo.InsertUser()
                TxtFname.Clear()
                TxtLname.Clear()
                TxtUsername.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                mdf.GetManageUserData()
                ManageUser.DgManageUser.DefaultCellStyle.SelectionBackColor = Color.White
                ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                ManageUser.DgManageUser.Enabled = False
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class