Public Class AddProduct

    Dim Mdf As New ManageDataRefresher
    Dim productRepo As New ProductRepo

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        TxtBarcode.Text = System.Text.RegularExpressions.Regex.Replace(TxtBarcode.Text, "[^0-9.,]", "")
        TxtBarcode.SelectionStart = TxtBarcode.Text.Length
    End Sub

    '----------------------------------- TEXT BOX PRICE -------------------------------------------------
    Public Sub FormatPriceTextBox(ByVal txt As TextBox)
        If Not String.IsNullOrWhiteSpace(txt.Text) AndAlso IsNumeric(txt.Text) Then
            txt.Text = Format(CDbl(txt.Text), "0.00") ' Format to two decimal places
        Else
            txt.Text = "0.00" ' Default if empty or invalid
        End If
    End Sub

    Private Sub TxtPrice_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPrice.KeyPress
        ' Allow numbers, one decimal point, and backspace
        Dim txt As TextBox = CType(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True ' Block invalid input
        End If

        ' Prevent multiple decimal points
        If e.KeyChar = "."c AndAlso txt.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrice_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtPrice.Leave
        FormatPriceTextBox(TxtPrice)
    End Sub

    '----------------------------------- TEXT BOX EXPIRE DATE -------------------------------------------------
    Private Sub FormatExpireDate(ByVal txt As TextBox)
        Dim parsedDate As Date
        If Date.TryParse(txt.Text, parsedDate) Then
            txt.Text = parsedDate.ToString("yyyy-MM-dd") ' Format to YYYY-MM-DD
        Else
            MessageBox.Show("Invalid date format! Please enter a valid date (YYYY-MM-DD).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return
        End If
    End Sub

    Private Sub expiry_date_TextChanged(sender As Object, e As EventArgs) Handles TxtExpireDate.TextChanged
        TxtExpireDate.Text = System.Text.RegularExpressions.Regex.Replace(TxtExpireDate.Text, "[^0-9 -]", "")
    End Sub

    Private Sub TxtExpireDate_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtExpireDate.Leave
        FormatExpireDate(TxtExpireDate)
    End Sub

    '------------------------------------- END ---------------------------------------------------------------------
    Private Sub TxtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtBarcode.Text = "" Then
                MessageBox.Show("Enter Barcode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                CbCategory.Focus()
            End If
        End If
    End Sub

    Private Sub TxtGenericname_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtGenericname.KeyDown
        If e.KeyCode = 13 Then
            If TxtGenericname.Text = "" Then
                MessageBox.Show("Enter Genericname", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtBrandname.Focus()
            End If
        End If
    End Sub

    Private Sub TxtBrandname_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBrandname.KeyDown
        If e.KeyCode = 13 Then
            If TxtBrandname.Text = "" Then
                MessageBox.Show("Enter Brandname", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtFormula.Focus()
            End If
        End If
    End Sub

    Private Sub TxtFormula_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFormula.KeyDown
        If e.KeyCode = 13 Then
            If TxtFormula.Text = "" Then
                MessageBox.Show("Enter Formulation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtDescription.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescription.KeyDown
        If e.KeyCode = 13 Then
            If TxtDescription.Text = "" Then
                MessageBox.Show("Enter Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtPrice.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            FormatPriceTextBox(TxtPrice)
            If TxtPrice.Text = "" Then
                MessageBox.Show("Enter Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Nqty.Focus()
            End If
        End If
    End Sub

    Private Sub Nqty_KeyDown(sender As Object, e As KeyEventArgs) Handles Nqty.KeyDown
        If e.KeyCode = 13 Then
            If Nqty.Text = "" Then
                MessageBox.Show("Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TxtExpireDate.Focus()
            End If
        End If
    End Sub

    Private Sub TxtExpireDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtExpireDate.KeyDown
        If e.KeyCode = 13 Then
            FormatExpireDate(TxtExpireDate)
            If TxtExpireDate.Text = "" Then
                MessageBox.Show("Enter Expiration date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                BtnSave.Focus()
            End If
        End If
    End Sub
    Private Sub BtnSave_MouseHover(sender As Object, e As EventArgs) Handles BtnSave.MouseHover
        BtnSave.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnSave_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnClose_MouseHover(sender As Object, e As EventArgs) Handles BtnClose.MouseHover
        BtnClose.BackColor = Color.Salmon
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(TxtBarcode.Text) OrElse
       String.IsNullOrWhiteSpace(TxtGenericname.Text) OrElse
       String.IsNullOrWhiteSpace(TxtBrandname.Text) OrElse
       String.IsNullOrWhiteSpace(TxtFormula.Text) OrElse
       String.IsNullOrWhiteSpace(TxtDescription.Text) OrElse
       String.IsNullOrWhiteSpace(Nqty.Text) OrElse
       String.IsNullOrWhiteSpace(TxtPrice.Text) OrElse
       CbCategory.Text = "--SELECT--" Then
            MessageBox.Show("All Fields Must be Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Val(TxtPrice.Text) = 0 AndAlso Nqty.Value = 0 Then
            MessageBox.Show("Price and Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If BtnSave.Text = "UPDATE" Then
            productRepo.UpdateProduct()
            Mdf.LoadTotalCount("products", DashboardPanelForm.LblTotalProduct)
            Me.Close()
            AddProductTxtClear()
            Return
        End If

        productRepo.InnsertProduct()
        Mdf.LoadTotalCount("products", DashboardPanelForm.LblTotalProduct)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        AddProductTxtClear()
    End Sub

    Public Sub AddProductTxtClear()
        TxtBarcode.Clear()
        TxtGenericname.Clear()
        TxtBrandname.Clear()
        TxtFormula.Clear()
        TxtDescription.Clear()
        TxtPrice.Text = "0.00"
        Nqty.Value = 0
        TxtBarcode.Clear()
        TxtExpireDate.Clear()
    End Sub

    Public Sub TxtShow()
        LblQty.Show()
        Nqty.Show()
        LblExd.Show()
        TxtExpireDate.Show()
        LblDateFormat.Show()
    End Sub
End Class