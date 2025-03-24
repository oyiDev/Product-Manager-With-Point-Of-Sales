Imports System.Data.Odbc

Public Class ProductRepo
    Public Sub LoadTotalCount(tableName As String, label As Label)
        Try
            connect_me()
            Dim query As String = $"SELECT COUNT(*) FROM {tableName}"
            Using cmd As New OdbcCommand(query, con)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                label.Text = count.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching total count from {tableName}: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class





