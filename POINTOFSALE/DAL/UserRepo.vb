Imports System.Data.Odbc

Public Class UserRepo
    Public Function GetUserRole(usertype As String, password As String) As UserInfo

        Dim userInfo As New UserInfo()

        Try
            connect_me()
            Dim query As String = "SELECT user_id, user_type, firstname, lastname FROM users WHERE user_type = ? AND password_hash = ?"
            Dim cmd As New OdbcCommand(query, con)

            cmd.Parameters.AddWithValue("@usertype", usertype)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                userInfo.UserId = reader("user_id").ToString()
                userInfo.Role = reader("user_type").ToString()
                userInfo.Firstname = reader("firstname").ToString()
                userInfo.lastname = reader("lastname").ToString()
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return userInfo
    End Function

    Public Sub DisplayUserInfo()
        POSForm.txtDate.Text = DateAndTime.Now.ToString("MM/dd/yyyy")

        Dim usertype As String = LoginForm.cbUsername.Text.ToLower.Trim
        Dim password As String = LoginForm.txtPassword.Text.ToLower.Trim

        Dim userRepo As New UserRepo()
        Dim userInfo As UserInfo = userRepo.GetUserRole(usertype, password)

        If userInfo IsNot Nothing AndAlso Not String.IsNullOrEmpty(userInfo.Role) Then
            POSForm.txtFullName.Text = $"{userInfo.Firstname} {userInfo.lastname}"
        Else
            MessageBox.Show("Invalid user type or password.")
        End If
    End Sub
End Class
