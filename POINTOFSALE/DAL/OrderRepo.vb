Imports System.Data.Odbc

Public Class OrderRepo

    Dim cmd As OdbcCommand
    Dim reader As OdbcDataReader

    Public Sub ScanProduct(barcode As String)

        Dim query As String = "SELECT barcode, genericname, price, qty, (price * qty) as amount FROM products WHERE barcode = ?"

        Try
            cmd = New OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", barcode)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim productName As String = reader("genericname").ToString()
                Dim productPrice As String = Convert.ToDecimal(reader("price"))
                Dim productQty As String = Convert.ToInt32(reader("qty"))

                'Check if the product quantity is lower then equal zero
                If productQty <= 0 Then
                    MessageBox.Show("Transaction cannot proceed. product quantity is zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                'Check if the product is existed in the Datagrid
                Dim rowExist As Boolean = False

                For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
                    If row.Cells("barcodeCol").Value IsNot Nothing AndAlso row.Cells("barcodeCol").Value.ToString() = barcode Then
                        Dim currentQty As Integer = Convert.ToInt32(row.Cells("qtyCol").Value)
                        row.Cells("qtyCol").Value = currentQty + 1
                        row.Cells("amountCol").Value = (currentQty + 1) * productPrice
                        rowExist = True
                        Exit For
                    End If
                Next

                If Not rowExist Then
                    POSForm.dgTransaction.Rows.Add(barcode, productName, productPrice, 1, productPrice)
                End If

                UpdateTransactionTotal()
            Else
                MessageBox.Show("Prouct not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Fetching Product: ", "Error", MessageBoxButtons.OK, CType(MessageBoxIcon.Error & ex.Message, MessageBoxIcon))
        End Try
    End Sub

    Private Sub UpdateTransactionTotal()
        Dim subTotal As Decimal = 0

        ' Calculate the subtotal
        For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
            subTotal += Convert.ToDecimal(row.Cells("amountCol").Value)
        Next

        ' Calculate tax 12% VAT
        Dim taxRate As Decimal = 0.12
        Dim tax As Decimal = subTotal * taxRate

        ' Calculate total amount
        Dim totalAmount As Decimal = subTotal + tax

        ' Display the calculated values
        POSForm.txtTransSubtotal.Text = "₱ " & subTotal.ToString("N2")
        PaymentForm.txtAmount.Text = "₱ " & subTotal.ToString("N2")
        PaymentForm.txtCash.Text = totalAmount.ToString("N2")
        PaymentForm.txtChange.Text = "₱ 00.00"
        PaymentForm.TxtVat.Text = "₱ " & tax.ToString("N2")
        PaymentForm.txtGtotal.Text = "₱ " & totalAmount.ToString("N2")
    End Sub

    Public Sub TransactionWithDiscount()
        Dim subTotal As Decimal = 0

        ' Calculate the subtotal
        For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
            subTotal += Convert.ToDecimal(row.Cells("amountCol").Value)
        Next

        ' Apply discount of 20%
        Dim discountPercentage As Decimal = 0.2
        Dim discount As Decimal = subTotal * discountPercentage
        Dim subtotalAfterDiscount As Decimal = subTotal - discount

        ' Calculate tax 12% VAT
        Dim taxRate As Decimal = 0.12
        Dim tax As Decimal = subtotalAfterDiscount * taxRate

        ' Calculate total amount
        Dim totalAmount As Decimal = subtotalAfterDiscount + tax

        ' Display the calculated values
        POSForm.txtTransSubtotal.Text = "₱ " & subTotal.ToString("N2")
        PaymentForm.txtAmount.Text = "₱ " & subTotal.ToString("N2")
        PaymentForm.txtCash.Text = totalAmount.ToString("N2")
        PaymentForm.txtChange.Text = "₱ " & discountPercentage.ToString("N2")
        PaymentForm.txtDiscount.Text = "₱ " & discount.ToString("N2")
        PaymentForm.TxtVat.Text = "₱ " & tax.ToString("N2")
        PaymentForm.txtGtotal.Text = "₱ " & totalAmount.ToString("N2")
    End Sub
    Public Sub RecordCashOut()
        Try
            Dim query As String = "INSERT INTO cashout (id, name, user_type, created_at, amount, remarks) VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OdbcCommand(query, con)
                ' Add parameters in correct order
                cmd.Parameters.AddWithValue("?", DiscountForm.lblid.Text.Trim().ToString)
                cmd.Parameters.AddWithValue("?", POSForm.txtFullName.Text.Trim().ToString)
                cmd.Parameters.AddWithValue("?", LoginForm.cbUsername.Text.Trim().ToLower.ToString)
                cmd.Parameters.AddWithValue("?", DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"))
                cmd.Parameters.AddWithValue("?", Convert.ToDecimal(DiscountForm.TxtIdNum.Text.Trim).ToString())
                cmd.Parameters.AddWithValue("?", DiscountForm.TxtName.Text.Trim().ToLower)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Cashout successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OpenCashDrawer()
                DiscountForm.TxtIdNum.Clear()
                DiscountForm.TxtName.Clear()
                POSForm.Enabled = True
                DiscountForm.Hide()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during cash out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.Print(ex.ToString()) ' Print full error details for debugging
        End Try
    End Sub

    Public Sub OpenCashDrawer()
        Try
            Dim printerName As String = "Your Printer Name Here" ' Set your receipt printer name
            Dim openDrawerCommand As Byte() = {27, 112, 0, 25, 250} ' ESC/POS Command for cash drawer

            'RawPrinterHelper.SendBytesToPrinter(printerName, openDrawerCommand)
        Catch ex As Exception
            MessageBox.Show("Failed to open cash drawer: " & ex.Message, "Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AddDiscount()
        Dim name As String = DiscountForm.TxtName.Text.Trim.ToLower()
        Dim id As String = DiscountForm.TxtIdNum.Text.Trim.ToLower()

        If name = "" Then
            MessageBox.Show("Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf id = "" Then
            MessageBox.Show("Enter ID Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If DiscountForm.lbldisType.Text = "SENIOR" Then
                MessageBox.Show("The SENIOR discount is 20%")
                TransactionWithDiscount()
                PaymentForm.Enabled = True
                PaymentForm.txtCash.Focus()
                DiscountForm.Hide()
                DiscountForm.TxtName.Clear()
                DiscountForm.TxtIdNum.Clear()
            ElseIf DiscountForm.lbldisType.Text = "PWD" Then
                MessageBox.Show("The PWD discount is 20%")
                TransactionWithDiscount()
                PaymentForm.Enabled = True
                PaymentForm.txtCash.Focus()
                DiscountForm.Hide()
                DiscountForm.TxtName.Clear()
                DiscountForm.TxtIdNum.Clear()
            Else
                RecordCashOut()
            End If
        End If
    End Sub

    Public Sub UpdateSubtotal(amount As Decimal)
        Dim currentSubtotal As Decimal = Convert.ToDecimal(POSForm.txtTransSubtotal.Text.Substring(1))
        currentSubtotal -= amount
        PaymentForm.txtAmount.Text = "₱ " & currentSubtotal.ToString("N2")
        PaymentForm.txtCash.Text = "₱ " & currentSubtotal.ToString("N2")
        PaymentForm.txtGtotal.Text = "₱ " & currentSubtotal.ToString("N2")
    End Sub

    Public Sub PrintReceipt()
        Dim res As Integer = MessageBox.Show("Print receipt?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbYes Then
            Dim dt As New DataTable
            dt.Columns.Add("qty", Type.GetType("System.String"))
            dt.Columns.Add("name", Type.GetType("System.String"))
            dt.Columns.Add("amount", Type.GetType("System.String"))
            dt.Columns.Add("cash", Type.GetType("System.String"))
            dt.Columns.Add("change", Type.GetType("System.String"))
            dt.Columns.Add("discount", Type.GetType("System.String"))
            dt.Columns.Add("vat", Type.GetType("System.String"))

            ' Loop through the DataGridView rows and add them to the DataTable
            For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
                If Not row.IsNewRow Then
                    dt.Rows.Add(row.Cells("qtyCol").Value.ToString(), row.Cells("nameCol").Value.ToString(), row.Cells("amountCol").Value.ToString(),
                            PaymentForm.txtCash.Text, PaymentForm.txtChange.Text, PaymentForm.txtDiscount.Text, PaymentForm.TxtVat.Text)
                End If
            Next

            PrintForm.Show()
            ' Load the report
            Dim report As New ReceiptReport
            'report.Load("C:\Users\Rip\source\repos\Manage-Product-with-Point-Of-Sale\POINTOFSALE\Reports\ReceiptReport.rpt")
            ' Set the data source of the report
            report.SetDataSource(dt)
            ' Print the report
            report.PrintToPrinter(1, False, 0, 0)
            PrintForm.CViewer.ReportSource = report
        Else
            MessageBox.Show("Without receipt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub UpdateInventory()
        For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
            Dim brcode As String = row.Cells("barcodeCol").Value.ToString()
            Dim qtySold As Integer = Convert.ToInt32(row.Cells("qtyCol").Value)

            'Decrease the qty in tbl product
            Dim updateQuery As String = "UPDATE products SET qty = qty - ? WHERE barcode = ?"

            Try
                cmd = New OdbcCommand(updateQuery, con)
                cmd.Parameters.AddWithValue("?", qtySold)
                cmd.Parameters.AddWithValue("?", brcode)
                cmd.ExecuteNonQuery()
                ItemListForm.DgItemList.Refresh()
            Catch ex As Exception
                MessageBox.Show("Error Updating Inventory: " & ex.Message)
            End Try
        Next
    End Sub

    Public Sub DeleteItem(e)
        If e.KeyCode = Keys.Enter Then
            Dim subtotalText As String = POSForm.txtTransSubtotal.Text.Replace("₱", "").Trim()
            Dim totalAmount As Decimal
            If Decimal.TryParse(subtotalText, totalAmount) Then
                For Each row As DataGridViewRow In POSForm.dgTransaction.SelectedRows
                    If Not row.IsNewRow Then
                        Dim rowAmount As Decimal = Convert.ToDecimal(row.Cells("amountCol").Value)
                        totalAmount -= rowAmount
                        POSForm.dgTransaction.Rows.Remove(row)

                        ' Update the subtotal in PaymentForm
                        UpdateSubtotal(rowAmount)
                    End If
                Next
                POSForm.txtTransSubtotal.Text = "₱ " & totalAmount.ToString("N2")
                POSForm.lblAction.Text = "CASH SALES"
                POSForm.dgTransaction.Enabled = False
                POSForm.txtBarcode.Focus()
            End If
        End If
    End Sub

    Public Sub EditItemQty()
        If POSForm.dgTransaction.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = POSForm.dgTransaction.SelectedRows(0)
            Dim barcode As String = selectedRow.Cells("barcodeCol").Value.ToString()
            Dim newQty As Integer
            Dim input As String

            Do
                input = InputBox("Enter new quantity:", "Edit Quantity", selectedRow.Cells("qtyCol").Value.ToString())
                If String.IsNullOrEmpty(input) Then
                    ' User clicked Cancel
                    POSForm.lblAction.Text = "CASH SALES"
                    POSForm.dgTransaction.Enabled = False
                    POSForm.txtBarcode.Focus()
                    Exit Sub
                ElseIf Integer.TryParse(input, newQty) AndAlso newQty > 0 Then
                    EditProductQuantity(barcode, newQty)
                    Exit Do
                Else
                    MessageBox.Show("Invalid quantity entered. Please enter a valid whole number greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop While True
        Else
            MessageBox.Show("Please select a product to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub EditProductQuantity(barcode As String, newQty As Integer)
        For Each row As DataGridViewRow In POSForm.dgTransaction.Rows
            If row.Cells("barcodeCol").Value IsNot Nothing AndAlso row.Cells("barcodeCol").Value.ToString() = barcode Then
                Dim productPrice As Decimal = Convert.ToDecimal(row.Cells("priceCol").Value)
                row.Cells("qtyCol").Value = newQty
                row.Cells("amountCol").Value = newQty * productPrice
                UpdateTransactionTotal()
                POSForm.lblAction.Text = "CASH SALES"
                POSForm.dgTransaction.Enabled = False
                POSForm.txtBarcode.Focus()
                Exit Sub
            End If
        Next
        MessageBox.Show("Product not found in the transaction", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub AddTransaction()
        Try
            Dim usertype1 As String = LoginForm.cbUsername.Text.ToLower.Trim
            Dim password As String = LoginForm.txtPassword.Text.ToLower.Trim

            Dim userRepo As New UserRepo()
            Dim userInfo As UserInfo = userRepo.GetUserRole(usertype1, password)

            Dim transactionID As Integer = Convert.ToInt32(POSForm.txtnumber.Text)
            Dim name As String = POSForm.txtFullName.Text.Trim
            Dim userType As String = userInfo.Role
            Dim transactionDate As String = DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")
            Dim totalAmount As Decimal = Convert.ToDecimal(PaymentForm.txtGtotal.Text.Replace("₱", "").Trim())
            Dim paymentMethod As String = "Cash"
            Dim discount As Decimal = Convert.ToDecimal(PaymentForm.txtDiscount.Text.Replace("₱", "").Trim())

            TransactionForm.dgRecordTrans.Rows.Add(transactionID, name, userType, transactionDate, totalAmount, paymentMethod, discount)
            get_number()
        Catch ex As Exception
            MessageBox.Show("Error adding transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SaveTransactionsToDatabase()
        Try
            If TransactionForm.dgRecordTrans.Rows.Count = 0 OrElse (TransactionForm.dgRecordTrans.Rows.Count = 1 AndAlso TransactionForm.dgRecordTrans.Rows(0).IsNewRow) Then
                MessageBox.Show("No transactions to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            For Each row As DataGridViewRow In TransactionForm.dgRecordTrans.Rows
                If Not row.IsNewRow Then

                    Dim query As String = "INSERT INTO transactions (transaction_id, name, user_type, transaction_date, total_amount, payment_method, discount) VALUES (?, ?, ?, ?, ?, ?, ?)"

                    Dim mycmd As New OdbcCommand(query, con)
                    mycmd.Parameters.AddWithValue("?", row.Cells("idCol").Value.ToString())
                    mycmd.Parameters.AddWithValue("?", row.Cells("nameCol").Value.ToString())
                    mycmd.Parameters.AddWithValue("?", row.Cells("usertypeCol").Value.ToString())
                    mycmd.Parameters.AddWithValue("?", Convert.ToDateTime(row.Cells("transactiondateCol").Value).ToString("yyyy-MM-dd HH:mm:ss"))
                    mycmd.Parameters.AddWithValue("?", Convert.ToDecimal(row.Cells("totalamountCol").Value).ToString())
                    mycmd.Parameters.AddWithValue("?", row.Cells("paymentmethodCol").Value.ToString())
                    mycmd.Parameters.AddWithValue("?", Convert.ToDecimal(row.Cells("discountCol").Value).ToString())
                    mycmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Transactions saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TransactionForm.dgRecordTrans.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub get_number()
        Dim number As Integer = 0

        ' Loop through DataGridView to find the highest idCol value
        For Each row As DataGridViewRow In TransactionForm.dgRecordTrans.Rows
            If Not row.IsNewRow AndAlso row.Cells("idCol").Value IsNot Nothing Then
                Dim rowId As Integer
                If Integer.TryParse(row.Cells("idCol").Value.ToString(), rowId) Then
                    number = Math.Max(number, rowId)
                End If
            End If
        Next

        ' If DataGridView is empty, fetch max ID from the database
        If number = 0 Then
            Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(transaction_id), 0) FROM transactions", con)
            number = Convert.ToInt32(cmdnumber.ExecuteScalar())
        End If

        ' Assign the next transaction number
        POSForm.txtnumber.Text = (number + 1).ToString()
    End Sub

    Public Sub get_id()
        Dim number As Integer = 0

        If number = 0 Then
            Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(id), 0) FROM cashout", con)
            number = Convert.ToInt32(cmdnumber.ExecuteScalar())
        End If

        ' Assign the next transaction number
        DiscountForm.lblid.Text = (number + 1).ToString()
    End Sub

    Public Sub Zread()
        Try
            Dim NetAmount As Double
            Dim OthersPayment As Double = 0
            Dim DiscountAmount As Double
            Dim CashSales As Double
            Dim TotalCashOut As Double
            Dim TotalCash As Double
            Dim Variance As Double
            Dim DenominationTotal As Double

            ' Denomination Breakdown
            Dim P1000 As Integer, P500 As Integer, P200 As Integer, P100 As Integer, P50 As Integer
            Dim C20 As Integer, C10 As Integer, C5 As Integer, C1 As Integer

            ' Calculate total cash sales and discount
            Dim totalTransactionAmount As Decimal = 0
            Dim totalTransactionDiscount As Decimal = 0

            For Each row As DataGridViewRow In TransactionForm.dgRecordTrans.Rows
                If Not row.IsNewRow Then
                    totalTransactionAmount += Convert.ToDecimal(row.Cells("totalamountCol").Value)
                    totalTransactionDiscount += Convert.ToDecimal(row.Cells("discountCol").Value)
                End If
            Next

            ' Retrieve total cash out for today from database
            Dim query As String = "SELECT COALESCE(SUM(amount), 0) FROM cashout WHERE DATE(created_at) = CURDATE()"
            Using cmd As New OdbcCommand(query, con)
                Dim totalCashOutResult As Object = cmd.ExecuteScalar()
                TotalCashOut = If(IsDBNull(totalCashOutResult), 0D, Convert.ToDecimal(totalCashOutResult))
            End Using

            ' Get Denomination Breakdown
            If Not Integer.TryParse(ReadingForm.p1000.Text.Trim, P1000) Then P1000 = 0
            If Not Integer.TryParse(ReadingForm.p500.Text.Trim, P500) Then P500 = 0
            If Not Integer.TryParse(ReadingForm.p200.Text.Trim, P200) Then P200 = 0
            If Not Integer.TryParse(ReadingForm.p100.Text.Trim, P100) Then P100 = 0
            If Not Integer.TryParse(ReadingForm.p50.Text.Trim, P50) Then P50 = 0
            If Not Integer.TryParse(ReadingForm.c20.Text.Trim, C20) Then C20 = 0
            If Not Integer.TryParse(ReadingForm.c10.Text.Trim, C10) Then C10 = 0
            If Not Integer.TryParse(ReadingForm.c5.Text.Trim, C5) Then C5 = 0
            If Not Integer.TryParse(ReadingForm.c1.Text.Trim, C1) Then C1 = 0

            ' Update labels with denomination values
            ReadingForm.LblP1000.Text = Format(P1000 * 1000, "#,##0.00")
            ReadingForm.LblP500.Text = Format(P500 * 500, "#,##0.00")
            ReadingForm.LblP200.Text = Format(P200 * 200, "#,##0.00")
            ReadingForm.LblP100.Text = Format(P100 * 100, "#,##0.00")
            ReadingForm.LblP50.Text = Format(P50 * 50, "#,##0.00")
            ReadingForm.LblC20.Text = Format(C20 * 20, "#,##0.00")
            ReadingForm.LblC10.Text = Format(C10 * 10, "#,##0.00")
            ReadingForm.LblC5.Text = Format(C5 * 5, "#,##0.00")
            ReadingForm.LblC1.Text = Format(C1 * 1, "#,##0.00")

            ' Calculate Denomination Total
            DenominationTotal = (P1000 * 1000) + (P500 * 500) + (P200 * 200) + (P100 * 100) + (P50 * 50) + (C20 * 20) + (C10 * 10) + (C5 * 5) + (C1 * 1)

            ReadingForm.lblTCashCount.Text = Format(DenominationTotal, "#,##0.00")

            ' Calculate totals
            CashSales = totalTransactionAmount
            DiscountAmount = totalTransactionDiscount
            NetAmount = CashSales + OthersPayment - DiscountAmount
            TotalCash = CashSales - TotalCashOut
            Variance = DenominationTotal - TotalCash

            ' Display results in the form
            ReadingForm.TxtNetAmount.Text = Format(NetAmount, "#,##0.00")
            ReadingForm.TxtOthersPayment.Text = Format(OthersPayment, "#,##0.00")
            ReadingForm.TxtTDiscount.Text = Format(DiscountAmount, "#,##0.00")
            ReadingForm.TxtCashSales.Text = Format(CashSales, "#,##0.00")
            ReadingForm.TxtTCashOut.Text = Format(TotalCashOut, "#,##0.00")
            ReadingForm.TxtTotalCash.Text = Format(TotalCash, "#,##0.00")
            ReadingForm.TxtVariance.Text = Format(Variance, "#,##0.00")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PrintZread()
        Try
            MessageBox.Show("Printing Z-reading...")

            ' Create a new DataTable
            Dim dt As New DataTable
            dt.Columns.Add("netamount", Type.GetType("System.String"))
            dt.Columns.Add("cashsales", Type.GetType("System.String"))
            dt.Columns.Add("otherpayment", Type.GetType("System.String"))
            dt.Columns.Add("discoun", Type.GetType("System.String"))
            dt.Columns.Add("cashout", Type.GetType("System.String"))
            dt.Columns.Add("cash", Type.GetType("System.String"))
            dt.Columns.Add("variance", Type.GetType("System.String"))
            dt.Columns.Add("cashcount", Type.GetType("System.String"))
            dt.Columns.Add("thiskawnt", Type.GetType("System.String"))

            ' Ensure the form controls are accessible
            Dim netAmount As String = ReadingForm.TxtNetAmount.Text
            Dim cashSales As String = ReadingForm.TxtCashSales.Text
            Dim otherPayment As String = ReadingForm.TxtOthersPayment.Text
            Dim Tdiscount As String = ReadingForm.TxtTDiscount.Text
            Dim totalCashOut As String = ReadingForm.TxtTCashOut.Text
            Dim totalCash As String = ReadingForm.TxtTotalCash.Text
            Dim variance As String = ReadingForm.TxtVariance.Text
            Dim TCashCount As String = ReadingForm.lblTCashCount.Text
            Dim thiskawnt As String = ReadingForm.TxtTDiscount.Text

            ' Add a new row with the values
            dt.Rows.Add(netAmount, cashSales, otherPayment, Tdiscount, totalCashOut, totalCash, variance, TCashCount, thiskawnt)

            PrintForm.Show()
            ' Load the report
            Dim report As New ZreadReport()
            'report.Load("C:\Users\Rip\source\repos\Manage-Product-with-Point-Of-Sale\POINTOFSALE\Reports\ReceiptReport.rpt")
            ' Set the data source of the report
            report.SetDataSource(dt)
            ' Print the report
            report.PrintToPrinter(1, False, 0, 0)
            PrintForm.CViewer.ReportSource = report

            MessageBox.Show("Z-reading printed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error printing Z-read: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClearDataGridView()
        POSForm.dgTransaction.Rows.Clear()
        POSForm.lblAction.Text = "CASH SALES"
        POSForm.txtTransSubtotal.Text = "₱ 00.00"
        PaymentForm.txtAmount.Text = "₱ 00.00"
        PaymentForm.txtCash.Text = "₱ 00.00"
        PaymentForm.txtChange.Text = "₱ 00.00"
        PaymentForm.TxtVat.Text = "₱ 00.00"
        PaymentForm.txtDiscount.Text = "₱ 00.00"
        PaymentForm.txtGtotal.Text = "₱ 00.00"
    End Sub
End Class
