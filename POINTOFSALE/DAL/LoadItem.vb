Imports System.Data.Odbc

Public Class LoadItemData
    Public Sub LoadItemData(searchTerm As String)
        Try
            connect_me()
            Dim query As String = "SELECT barcode, genericname, brandname, price, qty FROM products"

            If Not String.IsNullOrEmpty(searchTerm) Then
                query &= " WHERE barcode LIKE ? OR genericname LIKE ? OR brandname LIKE ?"
            End If

            Dim cmd As New OdbcCommand(query, con)
            If Not String.IsNullOrEmpty(searchTerm) Then
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
                cmd.Parameters.AddWithValue("?", "%" & searchTerm & "%")
            End If
            Dim adapter As New OdbcDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ItemListForm.DgItemList.Rows.Clear()

            For Each row As DataRow In table.Rows
                ItemListForm.DgItemList.Rows.Add(row("barcode"), row("genericname"), row("brandname"), row("price"), row("qty"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error Loading Item: " & ex.Message)
        End Try
    End Sub

    Public Sub SelectItem()
        If ItemListForm.DgItemList.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewRow = ItemListForm.DgItemList.SelectedRows(0)
            Dim barcode As String = selectedRows.Cells("barcodeCol").Value.ToString

            Dim OrderRepo As New OrderRepo()
            OrderRepo.ScanProduct(barcode)

            POSForm.Enabled = True
            ItemListForm.TxtSearch.Clear()
            ItemListForm.Hide()
        End If
    End Sub
End Class