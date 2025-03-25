Public Class AddUser

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New UserRepo
        repo.Get_id()
        CbRole.Text = "--SELECT--"
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim repo As New UserRepo
        Try
            If TxtFname.Text = "" Or TxtLname.Text = "" Or CbRole.Text = "" Or TxtPass.Text = "" Or TxtCpass.Text = "" Then
                MessageBox.Show("All Fields Must Be Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf CbRole.Text = "--SELECT--" Then
                MessageBox.Show("SELECT ROLE / USERTYPE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not TxtCpass.Text.Trim().ToLower = TxtPass.Text.Trim().ToLower Then
                MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ManageUser.LblAction.Text = "/ EDIT" Then
                repo.EditUser()
                TxtFname.Clear()
                TxtLname.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                repo.LoadUser()
                repo.RowWhite()
                ManageUser.DgManageUser.Enabled = False
                Me.Hide()
            Else
                repo.InsertUser()
                MessageBox.Show("User added successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtFname.Clear()
                TxtLname.Clear()
                TxtPass.Clear()
                TxtCpass.Clear()
                repo.LoadUser()
                repo.RowWhite()
                ManageUser.DgManageUser.Enabled = False
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class