Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim repo As New ProductRepo()
            repo.LoadTotalCount("users", totalUser_lbl)
            repo.LoadTotalCount("products", totalProduct_lbl)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading... " & ex.Message)
        End Try
    End Sub
End Class
