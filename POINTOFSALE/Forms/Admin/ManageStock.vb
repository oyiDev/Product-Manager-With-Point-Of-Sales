Public Class ManageStock

    Dim mdf As New ManageDataRefresher
    Dim productRepo As New ProductRepo
<<<<<<< Updated upstream
    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mdf.GetManageStockData()
        productRepo.HighlightAvailableProduct(DgStock, "qty")
        productRepo.HighlightZeroQtyCells(DgStock, "qty")
        productRepo.HighlightExpiredProduct(DgStock, "expiredate")
=======

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        mdf.GetManageStockData()
>>>>>>> Stashed changes
    End Sub
    Private Sub btnPullout_MouseEnter(sender As Object, e As EventArgs) Handles btnPullout.MouseEnter
        btnPullout.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnPullout_MouseLeave(sender As Object, e As EventArgs) Handles btnPullout.MouseLeave
        btnPullout.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnPullout_Click(sender As Object, e As EventArgs) Handles btnPullout.Click
        productRepo.PullProductExpired()
    End Sub

    Private Sub DgManageStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgManageStock.CellClick
        If e.ColumnIndex >= 0 AndAlso DgManageStock.Columns(e.ColumnIndex).Name = "REFILL" AndAlso e.RowIndex >= 0 Then
            Dim expireDate As Date
            Dim qty As Integer = Convert.ToInt32(DgManageStock.Rows(e.RowIndex).Cells("qty").Value)
            Date.TryParse(DgManageStock.Rows(e.RowIndex).Cells("expiry date").Value.ToString(), expireDate)


            If expireDate <= Date.Today Then
                MessageBox.Show("Refill is not available for expired products.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If qty <= 10 Then
                productRepo.RefillProduct(e.RowIndex)
            Else
                MessageBox.Show("Refill is only available for stock under equal to 10.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub DgManageStock_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DgManageStock.CellPainting
        If e.ColumnIndex >= 0 AndAlso DgManageStock.Columns(e.ColumnIndex).Name = "REFILL" AndAlso e.RowIndex >= 0 Then
            ' Define cell and padding
            Dim cellBounds As Rectangle = e.CellBounds
            Dim paddedBounds As New Rectangle(cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width - 5, cellBounds.Height - 5)

            Dim isSelected As Boolean = DgManageStock.Rows(e.RowIndex).Selected
            Dim qty As Integer = Convert.ToInt32(DgManageStock.Rows(e.RowIndex).Cells("qty").Value)

            ' Convert expiredate safely
            Dim expireDate As Date
            Date.TryParse(DgManageStock.Rows(e.RowIndex).Cells("expiry date").Value.ToString(), expireDate)

            ' Only enable if qty <= 10 AND NOT expired
            Dim isEnabled As Boolean = (qty <= 10) AndAlso (expireDate >= Date.Today)

            ' Background color
            Dim backgroundBrush As Brush = If(isSelected, Brushes.SteelBlue, Brushes.WhiteSmoke)
            e.Graphics.FillRectangle(backgroundBrush, cellBounds)

            ' Border (popup effect)
            ControlPaint.DrawBorder(e.Graphics, paddedBounds, Color.Gray, ButtonBorderStyle.Solid)

            ' Text color based on selection & enable state
            Dim textColor As Color = If(isSelected, Color.White, If(isEnabled, Color.SteelBlue, Color.Gray))
            Dim buttonText As String = "Refill"

            ' Draw text
            TextRenderer.DrawText(e.Graphics, buttonText, e.CellStyle.Font, paddedBounds, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

            e.Handled = True
        End If
    End Sub
End Class