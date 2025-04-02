Public Class TransactionForm

    Dim loadItem As New LoadItemData

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cellFont As New Font("Arial", 9, FontStyle.Regular)
        Dim cellForeColor As Color = Color.Black
        Dim cellBackColor As Color = Color.White

        dgRecordTrans.DefaultCellStyle.Font = cellFont
        dgRecordTrans.DefaultCellStyle.ForeColor = cellForeColor
        dgRecordTrans.DefaultCellStyle.BackColor = cellBackColor

        Dim selectionForeColor As Color = Color.Black
        Dim selectionBackColor As Color = Color.White

        dgRecordTrans.DefaultCellStyle.SelectionForeColor = selectionForeColor
        dgRecordTrans.DefaultCellStyle.SelectionBackColor = selectionBackColor

        'loadItem.LoadItemData("")
        Dim getData As New LoadItemData
        getData.LoadItemData("")
    End Sub
End Class