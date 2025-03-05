Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim repo As New ProductRepo()
            repo.LoadTotalUser()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading total users: " & ex.Message)
        End Try
    End Sub
End Class