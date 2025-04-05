Imports System.Data.Odbc

Public Class ManageUser

    Dim userRepo As New UserRepo
    Dim mdf As New ManageDataRefresher

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtUserSearch.TextChanged
        mdf.GetManageUserData(TxtUserSearch.Text.Trim())
    End Sub

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        AddUser.LblPassword.Visible = True
        AddUser.TxtPass.Visible = True
        AddUser.LblCpassword.Visible = True
        AddUser.TxtCpass.Visible = True
        AddUser.BtnSave.Text = "Save"
        AddUser.BtnChangepass.Hide()
        userRepo.Get_id()
        AddUser.CbRole.Text = "--SELECT--"
        AddUser.TxtFname.Focus()
        AddUser.ShowDialog()
    End Sub

    Private Sub btnAdduser_MouseEnter(sender As Object, e As EventArgs) Handles btnAdduser.MouseEnter
        btnAdduser.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub btnAdduser_MouseLeave(sender As Object, e As EventArgs) Handles btnAdduser.MouseLeave
        btnAdduser.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub DgManageUser_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = DgManageUser.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If DgManageUser.Columns(e.ColumnIndex).Name = "deleteCol" Then
                DgManageUser.Cursor = Cursors.Hand
            ElseIf DgManageUser.Columns(e.ColumnIndex).Name = "editCol" Then
                DgManageUser.Cursor = Cursors.Hand
            End If
        End If
    End Sub

    Private Sub DgManageUser_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = DgManageUser.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If DgManageUser.Columns(e.ColumnIndex).Name = "deleteCol" OrElse DgManageUser.Columns(e.ColumnIndex).Name = "editCol" Then
                DgManageUser.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub DgManageUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgManageUser.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgManageUser.Rows(e.RowIndex)
            If DgManageUser.Columns(e.ColumnIndex).Name = "editCol" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to EDIT this user?", "Confirm Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    AddUser.TxtId.Text = selectedRow.Cells("idCol").Value.ToString()
                    AddUser.TxtFname.Text = selectedRow.Cells("firstnameCol").Value.ToString()
                    AddUser.TxtLname.Text = selectedRow.Cells("lastnameCol").Value.ToString()
                    AddUser.TxtUsername.Text = selectedRow.Cells("usernameCol").Value.ToString()
                    AddUser.CbRole.Text = selectedRow.Cells("usertypeCol").Value.ToString()
                    AddUser.LblPassword.Visible = False
                    AddUser.TxtPass.Visible = False
                    AddUser.LblCpassword.Visible = False
                    AddUser.TxtCpass.Visible = False
                    AddUser.BtnSave.Text = "Update"
                    AddUser.BtnChangepass.Show()
                    AddUser.ShowDialog()
                End If
            ElseIf DgManageUser.Columns(e.ColumnIndex).Name = "deleteCol" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this User?", "DELETE Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    userRepo.DeleteUser(selectedRow.Cells("idCol").Value.ToString())
                    mdf.GetManageUserData("")
                End If
            End If
        End If
    End Sub
End Class