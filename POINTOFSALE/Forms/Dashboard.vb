Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim repo As New ProductRepo()
            repo.LoadTotalUser()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading users: " & ex.Message)
        End Try

        Try
            Dim repo As New ProductRepo()
            repo.LoadTotalProduct()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading users: " & ex.Message)
        End Try
    End Sub
End Class
