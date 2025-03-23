Imports System.Data.Odbc

Public Class ProductRepo
    Public Sub LoadTotalUser()

        Try
            Dim query As String = "SELECT COUNT(*) FROM users"
            Using cmd As New OdbcCommand(query, con)
                Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Dashboard.totalUser_lbl.Text = userCount.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadTotalProduct()

        Try
            Dim query As String = "SELECT COUNT(*) FROM products"
            Using cmd As New OdbcCommand(query, con)
                Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Dashboard.totalProduct_lbl.Text = userCount.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class





