Imports System.Data.Odbc
Public Class InventoryDashboard
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        Dim ct As String = cb_category.Text.Trim
        Dim br As String = txt_barcode.Text.Trim
        Dim gn As String = txt_generic.Text.Trim
        Dim bn As String = txt_brand.Text.Trim
        Dim fm As String = txt_formula.Text.Trim
        Dim dp As String = txt_description.Text.Trim
        Dim pr As String = txt_price.Text.Trim
        Dim qt As String = txt_qty.Text.Trim
        Dim ed As Date = expiry_date.Value

        Try
            connect_me()
            Dim mycmd As New OdbcCommand

            With mycmd
                .Connection = con
                .CommandText = "INSERT INTO `products` (`category`, `barcode` ,`genericname`, `brandname`, `formula`, `description`, `price`, `qty`, `expiredate`) VALUES (?,?,?,?,?,?,?,?,?)"
                .Parameters.AddWithValue("@category", ct)
                .Parameters.AddWithValue("@barcode", br)
                .Parameters.AddWithValue("@genericname", gn)
                .Parameters.AddWithValue("@brandname", bn)
                .Parameters.AddWithValue("@formula", fm)
                .Parameters.AddWithValue("@description", dp)
                .Parameters.AddWithValue("@price", pr)
                .Parameters.AddWithValue("@qty", qt)
                .Parameters.AddWithValue("@expiredate", ed)
                .ExecuteNonQuery()


            End With
            MessageBox.Show("Add product success!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshMe()
            cb_category.Enabled = True
            txt_barcode.Clear()
            txt_generic.Clear()
            txt_brand.Clear()
            txt_formula.Clear()
            txt_description.Clear()
            txt_price.Clear()
            txt_qty.Clear()

        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
            MessageBox.Show("Error Adding" & ex.Message)
        End Try

    End Sub

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMe()
    End Sub
    Private Sub RefreshMe()

        connect_me()

        Dim mycmd As New OdbcCommand("select * from products", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "products")

        dg_product.DataSource = ds.Tables(0)
        dg_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dg_product.RowsDefaultCellStyle.BackColor = Drawing.Color.White
        'dg_transaction.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Gainsboro
        dg_product.Refresh()

    End Sub

    Public Sub search_product_TextChanged(sender As Object, e As EventArgs) Handles search_product.TextChanged
        Dim productRepo As New ProductRepo()
        'productRepo.SearchProduct(search_product.Text)
    End Sub

    Private Sub dg_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_product.CellClick
        ' Ensure the user is not clicking on the header row
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dg_product.Rows(e.RowIndex)

            ' Populate textboxes with the selected row's data
            cb_category.Text = row.Cells("category").Value.ToString()
            txt_barcode.Text = row.Cells("barcode").Value.ToString()
            txt_generic.Text = row.Cells("genericname").Value.ToString()
            txt_brand.Text = row.Cells("brandname").Value.ToString()
            txt_formula.Text = row.Cells("formula").Value.ToString()
            txt_description.Text = row.Cells("description").Value.ToString()
            txt_price.Text = row.Cells("price").Value.ToString()
            txt_qty.Text = row.Cells("qty").Value.ToString()

        End If
    End Sub
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        ' Ensure a row is selected
        If dg_product.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dg_product.SelectedRows(0)

            ' Update DataGridView with new values
            selectedRow.Cells("category").Value = cb_category.Text
            selectedRow.Cells("barcode").Value = txt_barcode.Text
            selectedRow.Cells("genericname").Value = txt_generic.Text
            selectedRow.Cells("brandname").Value = txt_brand.Text
            selectedRow.Cells("formula").Value = txt_formula.Text
            selectedRow.Cells("description").Value = txt_description.Text
            selectedRow.Cells("price").Value = txt_price.Text
            selectedRow.Cells("qty").Value = txt_qty.Text

        Else
            MessageBox.Show("Please select a product to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click

    End Sub

    Private Sub expiry_date_ValueChanged(sender As Object, e As EventArgs) Handles expiry_date.ValueChanged
        expiry_date.Format = DateTimePickerFormat.Custom
        expiry_date.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub dg_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_product.CellContentClick

    End Sub
End Class
