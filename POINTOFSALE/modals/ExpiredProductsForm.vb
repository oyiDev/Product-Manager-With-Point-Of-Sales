Public Class ExpiredProductsForm

    Dim productRepo As New ProductRepo
    Dim mdf As New ManageDataRefresher

    Private printText As String
    Private printPos As Integer

    Public Sub New(expiredProducts As List(Of String))
        InitializeComponent()
        txtExpiredProducts.Text = String.Join(Environment.NewLine, expiredProducts)
        txtExpiredProducts.SelectionStart = 0
        txtExpiredProducts.SelectionLength = 0
        txtExpiredProducts.ScrollToCaret()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Initialize text and position
            printText = txtExpiredProducts.Text
            printPos = 0

            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf Me.PrintPage
            printDoc.Print()

            Me.Hide()
            adminDashboard.Enabled = True

            Dim result As DialogResult = MessageBox.Show("The expired products will be pullout from the system. Click 'OK' to confirm. 'Cancel' to Cancelled", "Delete Expired Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                adminDashboard.Focus()
                productRepo.DeleteExpiredProducts()
                mdf.GetManageStockData()
                MessageBox.Show("Expired products have been pullout from the system.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                adminDashboard.Focus()
                MessageBox.Show("Expired product pull out cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing expired products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_MouseEnter(sender As Object, e As EventArgs) Handles btnPrint.MouseEnter
        btnPrint.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim printFont As New Drawing.Font("Arial", 10)
        Dim layoutArea As New Drawing.SizeF(e.MarginBounds.Width, e.MarginBounds.Height)
        Dim layoutRect As New Drawing.RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, layoutArea.Width, layoutArea.Height)

        Dim format As New StringFormat()
        Dim charactersFitted As Integer
        Dim linesFilled As Integer

        ' Measure how much text fits on the page
        e.Graphics.MeasureString(printText.Substring(printPos), printFont, layoutArea, format, charactersFitted, linesFilled)

        ' Print that portion of the text
        e.Graphics.DrawString(printText.Substring(printPos, charactersFitted), printFont, Drawing.Brushes.Black, layoutRect)

        ' Update the position
        printPos += charactersFitted

        ' If there's more text to print, signal another page
        If printPos < printText.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
End Class