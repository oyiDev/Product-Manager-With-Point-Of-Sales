Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class ManageStock
    Private expiredate As Object

    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_me()
        Dim mycmd As New OdbcCommand("select category, genericname, expiredate, price, qty from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        dg_stock.DataSource = ds.Tables(0)
        dg_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dg_stock.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        dg_stock.Refresh()
    End Sub

    Private Sub dg_stock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_stock.CellFormatting

        Try
            ' Check if the column is the "expiry_date" column
            If dg_stock.Columns(e.ColumnIndex).Name = "expiredate" Then
                ' Ensure the cell is not empty
                If e.Value IsNot Nothing AndAlso IsDate(e.Value) Then
                    Dim expiryDate As DateTime = Convert.ToDateTime(e.Value)
                    Dim currentDate As DateTime = DateTime.Now
                    Dim daysRemaining As Integer = (expiryDate - currentDate).Days

                    ' If expiry date is within 30 days, turn cell red
                    If daysRemaining <= 30 Then
                        e.CellStyle.BackColor = Drawing.Color.Red
                        e.CellStyle.ForeColor = Drawing.Color.White
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error in formatting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If dg_stock.Columns(e.ColumnIndex).Name = "expiredate" Then
            If e.Value IsNot Nothing AndAlso Date.TryParse(e.Value.ToString(), Nothing) Then
                Dim expiryDate As Date = Date.Parse(e.Value.ToString())
                Dim daysRemaining As Integer = (expiryDate - Date.Today).Days

                If daysRemaining < 0 Then
                    e.CellStyle.BackColor = Drawing.Color.Red ' Expired
                    e.CellStyle.ForeColor = Drawing.Color.White
                ElseIf daysRemaining <= 7 Then
                    e.CellStyle.BackColor = Drawing.Color.Orange ' Expiring soon
                    e.CellStyle.ForeColor = Drawing.Color.Black
                Else
                    e.CellStyle.BackColor = Drawing.Color.LightGreen ' Safe
                    e.CellStyle.ForeColor = Drawing.Color.Black

                End If
            End If
        End If

    End Sub

    Private Sub pullout_Btn_Click(sender As Object, e As EventArgs) Handles pullout_Btn.Click
        Dim today As Date = Date.Today

        If dg_stock.Columns.Count = 0 Then
            MessageBox.Show("No columns found in DataGridView.")
            Exit Sub
        End If

        For Each col As DataGridViewColumn In dg_stock.Columns
            Debug.Print(col.Name)
        Next
        If dg_stock.Columns.Contains("expiredate") Then
            For i As Integer = dg_stock.Rows.Count - 1 To 0 Step -1
                If dg_stock.Rows(i).Cells("expiredate").Value IsNot Nothing Then
                    Dim expiredate As Date
                    If Date.TryParse(dg_stock.Rows(i).Cells("expiredate").Value.ToString(), expiredate) Then
                        If expiredate < today Then
                            dg_stock.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Red
                            dg_stock.Rows.RemoveAt(i)
                        End If
                    Else
                        MessageBox.Show("Invalid date format in row " & i)
                    End If
                End If
            Next
        Else
            MessageBox.Show("No expiry date column found in DataGridView.")
        End If
    End Sub
End Class
