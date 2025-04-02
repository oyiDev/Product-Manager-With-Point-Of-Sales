Public Class ManageUser

    Dim userRepo As New UserRepo
    Dim mdf As New ManageDataRefresher

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdf.GetManageUserData()
        Me.KeyPreview = True
        LblAction.Hide()
    End Sub

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        Dim repo As New UserRepo
        repo.Get_id()
        AddUser.ShowDialog()
        AddUser.TxtFname.Focus()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        LblAction.Text = "/ DELETE"
        DgManageUser.DefaultCellStyle.SelectionBackColor = Color.Tomato
        DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Tomato
        DgManageUser.Focus()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        LblAction.Text = "/ EDIT"
        DgManageUser.DefaultCellStyle.SelectionBackColor = Color.Gold
        DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gold
        DgManageUser.Focus()
    End Sub

    Private Sub ManageUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If LblAction.Text = "/ DELETE" Then
                    userRepo.DeleteUser()
                    LblAction.Text = ""
                ElseIf LblAction.Text = "/ EDIT" Then
                    If DgManageUser.SelectedRows.Count > 0 Then
                        Dim selectedRow As DataGridViewRow = DgManageUser.SelectedRows(0)
                        AddUser.TxtId.Text = selectedRow.Cells("USER ID").Value.ToString()
                        AddUser.TxtFname.Text = selectedRow.Cells("FIRSTNAME").Value.ToString()
                        AddUser.TxtLname.Text = selectedRow.Cells("LASTNAME").Value.ToString()
                        AddUser.TxtUsername.Text = selectedRow.Cells("USERNAME").Value.ToString()
                        AddUser.TxtPass.Text = "" ' Password should not be displayed for security reasons
                        AddUser.CbRole.Text = selectedRow.Cells("ROLE").Value.ToString()
                        DgManageUser.DefaultCellStyle.SelectionBackColor = Color.White
                        DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                        AddUser.ShowDialog()
                    Else
                        MessageBox.Show("Please select a user to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub
End Class