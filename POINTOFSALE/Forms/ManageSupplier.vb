Imports System.Data.Odbc

Public Class ManageSupplier
    Private Sub add_supplierBtn_Click(sender As Object, e As EventArgs) Handles add_supplierBtn.Click

        Dim sn As String = txt_supplierName.Text.Trim
        Dim ph As String = txt_Phone.Text.Trim
        Dim ad As String = txt_Address.Text.Trim

        Try
            connect_me()
            Dim mycmd As New OdbcCommand

            With mycmd
                .Connection = con
                .CommandText = "INSERT INTO `supplier` (`name`, `phone` ,`address`) VALUES (?,?,?)"
                .Parameters.AddWithValue("@name", sn)
                .Parameters.AddWithValue("@phone", ph)
                .Parameters.AddWithValue("@address", ad)

                .ExecuteNonQuery()
            End With

            MessageBox.Show("Add Supplier Success!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshMe()
            txt_supplierName.Clear()
            txt_Phone.Clear()
            txt_Address.Clear()

        Catch ex As Exception
            Console.WriteLine("Error" & ex.Message)
            MessageBox.Show("Error Adding" & ex.Message)
        End Try
    End Sub

    Private Sub ManageSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMe()
    End Sub

    Private Sub RefreshMe()
        connect_me()

        Dim mycmd As New OdbcCommand("select * from supplier", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New Data.DataSet

        da.Fill(ds, "supplier")

        dg_Supplier.DataSource = ds.Tables(0)
        dg_Supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dg_Supplier.BackColor = Drawing.Color.White
        dg_Supplier.Refresh()
    End Sub
End Class