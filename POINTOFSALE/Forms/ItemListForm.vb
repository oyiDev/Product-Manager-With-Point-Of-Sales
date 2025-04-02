Imports System.Data.Common

Public Class ItemListForm

    Dim loadItem As New LoadItemData

    Private Sub ItemListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Dim cellFont As New Font("Arial", 10, FontStyle.Regular)
        DgItemList.DefaultCellStyle.Font = cellFont
        WhiteRow()
        loadItem.LoadItemData("")
    End Sub

    Private Sub WhiteRow()
        DgItemList.DefaultCellStyle.SelectionBackColor = Color.White
        DgItemList.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    End Sub

    Private Sub SkyBlueRow()
        DgItemList.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
        DgItemList.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.SkyBlue
    End Sub

    Private Sub ItemListForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                BtnClose.PerformClick()
            Case Keys.Enter
                BtnEnter.PerformClick()
            Case Keys.Down
                DgItemList.Focus()
                SkyBlueRow()
            Case Keys.Up
                DgItemList.Focus()
                SkyBlueRow()
            Case Keys.S
                If e.Control Then
                    TxtSearch.Focus()
                    WhiteRow()
                End If
        End Select
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        loadItem.LoadItemData(TxtSearch.Text.Trim())
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        loadItem.SelectItem()
        WhiteRow()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        POSForm.Enabled = True
        POSForm.txtBarcode.Focus()
        WhiteRow()
        Me.Hide()
    End Sub
End Class