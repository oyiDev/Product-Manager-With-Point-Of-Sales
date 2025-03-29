Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class ManageStock
    Private expiredate As Object

    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo As New ManageDataRefresher
        repo.GetManageStockData()
    End Sub

    'Private Sub dg_stock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_stock.CellFormatting

    '    Try
    '        ' Check if the column is the "expiry_date" column
    '        If dg_stock.Columns(e.ColumnIndex).Name = "expiredate" Then
    '            ' Ensure the cell is not empty
    '            If e.Value IsNot Nothing AndAlso IsDate(e.Value) Then
    '                Dim expiryDate As DateTime = Convert.ToDateTime(e.Value)
    '                Dim currentDate As DateTime = DateTime.Now
    '                Dim daysRemaining As Integer = (expiryDate - currentDate).Days

    '                ' If expiry date is within 30 days, turn cell red
    '                If daysRemaining <= 30 Then
    '                    e.CellStyle.BackColor = Drawing.Color.Red
    '                    e.CellStyle.ForeColor = Drawing.Color.White
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error in formatting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
End Class
