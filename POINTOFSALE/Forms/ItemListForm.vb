Public Class ItemListForm
    Private Sub ItemListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Set font and color for all cells
        Dim cellFont As New Font("Arial", 10, FontStyle.Regular)
        Dim cellForeColor As Color = Color.Black
        Dim cellBackColor As Color = Color.White

        DgItemList.DefaultCellStyle.Font = cellFont
        DgItemList.DefaultCellStyle.ForeColor = cellForeColor
        DgItemList.DefaultCellStyle.BackColor = cellBackColor

        ' Set selection color for all cells
        Dim selectionForeColor As Color = Color.Black
        Dim selectionBackColor As Color = Color.SkyBlue

        DgItemList.DefaultCellStyle.SelectionForeColor = selectionForeColor
        DgItemList.DefaultCellStyle.SelectionBackColor = selectionBackColor

        Dim loadItem As New LoadItemData
        loadItem.LoadItemData("")
    End Sub

    Private Sub ItemListForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                BtnClose.PerformClick()
            Case Keys.Enter
                DgItemList.Focus()
                BtnEnter.PerformClick()
            Case Keys.Down
                DgItemList.Focus()
            Case Keys.Up
                DgItemList.Focus()
            Case Keys.S
                If e.Control Then
                    TxtSearch.Focus()
                End If
        End Select
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim loadItem As New LoadItemData
        loadItem.LoadItemData(TxtSearch.Text.Trim())
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim loadData As New LoadItemData
        loadData.SelectItem()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        POSForm.Enabled = True
        Me.Hide()
    End Sub
End Class