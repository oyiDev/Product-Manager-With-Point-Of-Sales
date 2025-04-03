Imports System.Data.Odbc

Public Class SupplierRepo

    Public Sub InsertSupplier()

        Dim mdf As New ManageDataRefresher
        Dim id As String = AddSupplier.txtId.Text.Trim().ToUpper
        Dim name As String = AddSupplier.txtName.Text.Trim().ToUpper
        Dim phone As String = AddSupplier.txtPhone.Text.Trim().ToUpper
        Dim address As String = AddSupplier.txtAddress.Text.Trim().ToUpper
        Dim query As String = "INSERT INTO supplier (id, name, phone, address) VALUES (?, ?, ?, ?)"

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", name)
                cmd.Parameters.AddWithValue("?", phone)
                cmd.Parameters.AddWithValue("?", address)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier Added Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mdf.GetSupplierData()
            End Using
        Catch ex As Exception
            MessageBox.Show("Supplier is already added" & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub getSupplier_Id()
        Try
            connect_me()
            Dim number As Integer = 0

            If number = 0 Then
                Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(id), 0) FROM supplier", con)
                number = Convert.ToInt32(cmdnumber.ExecuteScalar())
            End If

            ' Assign the next transaction number
            AddSupplier.txtId.Text = (number + 1).ToString()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading id..." & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub EditSupplier()
        Dim id As String = AddSupplier.txtId.Text.Trim().ToUpper()
        Dim name As String = AddSupplier.txtName.Text.Trim().ToUpper()
        Dim phone As String = AddSupplier.txtPhone.Text.Trim().ToUpper()
        Dim address As String = AddSupplier.txtAddress.Text.Trim().ToUpper()

        Dim query As String = "UPDATE supplier SET name = ?, phone = ?, address = ?, WHERE id = ?"

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", name)
                cmd.Parameters.AddWithValue("?", phone)
                cmd.Parameters.AddWithValue("?", address)

            End Using
            MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class