Public Class ReadingForm
    Private Sub BtnPost_Click(sender As Object, e As EventArgs) Handles BtnPost.Click
        Dim repo As New OrderRepo
        repo.SaveTransactionsToDatabase()
    End Sub
End Class