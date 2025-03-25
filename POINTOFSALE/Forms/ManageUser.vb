Imports System.Data.Common

Public Class ManageUser
    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New UserRepo()
        Try
            repo.LoadUser()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading... " & ex.Message)
        End Try

        repo.RowWhite()
        DgManageUser.Enabled = False
        Me.KeyPreview = True
    End Sub

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        AddUser.TxtFname.Focus()
        AddUser.TxtId.Enabled = False
        AddUser.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        LblAction.Text = "/ DELETE"
        DgManageUser.Enabled = True
        DgManageUser.RowHeadersVisible = True
        DgManageUser.DefaultCellStyle.SelectionBackColor = Color.Tomato
        DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Tomato
        DgManageUser.Focus()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        LblAction.Text = "/ EDIT"
        DgManageUser.Enabled = True
        DgManageUser.RowHeadersVisible = True
        DgManageUser.DefaultCellStyle.SelectionBackColor = Color.Gold
        DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gold
        DgManageUser.Focus()
    End Sub

    Private Sub ManageUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim repo As New UserRepo
        Select Case e.KeyCode
            Case Keys.Enter
                If LblAction.Text = "/ DELETE" Then
                    repo.DeleteUser()
                    LblAction.Text = ""
                ElseIf LblAction.Text = "/ EDIT" Then
                    If DgManageUser.SelectedRows.Count > 0 Then
                        Dim selectedRow As DataGridViewRow = DgManageUser.SelectedRows(0)
                        AddUser.TxtId.Text = selectedRow.Cells("user_id").Value.ToString()
                        AddUser.TxtFname.Text = selectedRow.Cells("firstname").Value.ToString()
                        AddUser.TxtLname.Text = selectedRow.Cells("lastname").Value.ToString()
                        AddUser.TxtPass.Text = "" ' Password should not be displayed for security reasons
                        AddUser.CbRole.Text = selectedRow.Cells("Role").Value.ToString()
                        AddUser.Show()
                    Else
                        MessageBox.Show("Please select a user to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub
End Class