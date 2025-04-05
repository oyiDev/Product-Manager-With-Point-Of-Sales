Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text

Public Class UserRepo

    Dim userInfo As New UserInfo
    Dim mdf As New ManageDataRefresher

    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Public Function GetUserRole(username As String, password As String) As UserInfo
        'Dim userInfo As New UserInfo()
        Dim hashedPassword As String = HashPassword(password)

        Try
            connect_me()
            Dim query As String = "SELECT id, usertype, firstname, lastname, username, password FROM users WHERE username = ? AND password = ?"
            Dim cmd As New OdbcCommand(query, con)

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", hashedPassword)

            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                userInfo.UserId = reader("id").ToString()
                userInfo.Role = reader("usertype").ToString()
                userInfo.Firstname = reader("firstname").ToString()
                userInfo.lastname = reader("lastname").ToString()
                userInfo.Username = reader("username").ToString()
                userInfo.Password = reader("password").ToString()
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
        Return userInfo
    End Function

    Public Sub DisplayUserInfo()
        POSForm.txtDate.Text = DateAndTime.Now.ToString("MM/dd/yyyy")

        Dim usertype As String = userInfo.Role
        Dim password As String = LoginForm.TxtPassword.Text.Trim()

        Dim userRepo As New UserRepo()
        Dim userInfo1 As UserInfo = userRepo.GetUserRole(usertype, password)

        POSForm.TxtRole.Text = usertype

        If userInfo IsNot Nothing AndAlso Not String.IsNullOrEmpty(userInfo.Role) Then
            POSForm.txtFullName.Text = $"{userInfo.Firstname} {userInfo.lastname}"
        Else
            MessageBox.Show("Invalid user type or password.", "Info")
        End If
    End Sub

    Public Sub Get_id()
        Try
            connect_me()
            Dim number As Integer = 0

            If number = 0 Then
                Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(id), 0) FROM users", con)
                number = Convert.ToInt32(cmdnumber.ExecuteScalar())
            End If

            ' Assign the next transaction number
            AddUser.TxtId.Text = (number + 1).ToString()
        Catch ex As Exception
            MessageBox.Show("Error Get id: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub InsertUser()
        Dim userInfo As New UserInfo
        Dim id As String = AddUser.TxtId.Text.Trim().ToUpper
        Dim firstName As String = AddUser.TxtFname.Text.Trim().ToUpper
        Dim lastName As String = AddUser.TxtLname.Text.Trim().ToUpper
        Dim userName As String = AddUser.TxtUsername.Text.Trim().ToUpper
        Dim passWord As String = AddUser.TxtPass.Text.Trim().ToUpper
        Dim role As String = AddUser.CbRole.Text.Trim().ToUpper

        Dim passwordHash As String = HashPassword(passWord)
        Dim query As String = "INSERT INTO users (id, firstname, lastname, username, password, usertype) VALUES (?, ?, ?, ?, ?, ?)"

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", firstName)
                cmd.Parameters.AddWithValue("?", lastName)
                cmd.Parameters.AddWithValue("?", userName)
                cmd.Parameters.AddWithValue("?", passwordHash)
                cmd.Parameters.AddWithValue("?", role)
                cmd.ExecuteNonQuery()

                MessageBox.Show("User ADDED Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mdf.GetManageUserData("")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub EditUser()
        Dim id As String = AddUser.TxtId.Text.Trim().ToUpper()
        Dim firstname As String = AddUser.TxtFname.Text.Trim().ToUpper()
        Dim lastname As String = AddUser.TxtLname.Text.Trim().ToUpper()
        Dim username As String = AddUser.TxtUsername.Text.Trim().ToUpper()
        Dim password As String = AddUser.TxtPass.Text.Trim()
        Dim role As String = AddUser.CbRole.Text

        Dim query As String
        If String.IsNullOrEmpty(password) Then
            query = "UPDATE users SET firstname = ?, lastname = ?, username = ?, usertype = ? WHERE id = ?"
        Else
            Dim passwordHash As String = HashPassword(password)
            query = "UPDATE users SET firstname = ?, lastname = ?, username = ?, password = ?, usertype = ? WHERE id = ?"
        End If

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", firstname)
                cmd.Parameters.AddWithValue("?", lastname)
                cmd.Parameters.AddWithValue("?", username)
                If Not String.IsNullOrEmpty(password) Then
                    Dim passwordHash As String = HashPassword(password)
                    cmd.Parameters.AddWithValue("?", passwordHash)
                End If
                cmd.Parameters.AddWithValue("?", role)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User UPDATED successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mdf.GetManageUserData("")
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteUser(ByVal id As String)
        Dim query As String = "DELETE FROM users WHERE id = ?"
        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("User DELETED Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Deleting User : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function ValidateOldPassword(userId As String, oldPassword As String) As Boolean
        Dim isValid As Boolean = False
        Try
            connect_me()
            Dim query As String = "SELECT password FROM users WHERE id = ?"
            Dim cmd As New OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", userId)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim storedPasswordHash As String = reader("password").ToString()
                Dim inputPasswordHash As String = HashPassword(oldPassword)
                isValid = storedPasswordHash = inputPasswordHash
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error validating old password: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()
        End Try
        Return isValid
    End Function

    Public Sub UpdatePassword()
        Dim id As String = AddUser.TxtId.Text.Trim() 'userInfo.UserId
        Dim oldPassword As String = ChangePasswordForm.TxtOldPass.Text.Trim()
        Dim newPassword As String = ChangePasswordForm.TxtNewPass.Text.Trim()

        Console.WriteLine("id: " & id)

        If ValidateOldPassword(id, oldPassword) Then
            Dim newPasswordHash As String = HashPassword(newPassword)
            Dim query As String = "UPDATE users SET password = ? WHERE id = ?"
            Try
                connect_me()
                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("?", newPasswordHash)
                    cmd.Parameters.AddWithValue("?", id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Password UPDATED successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ChangePasswordForm.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating password: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
