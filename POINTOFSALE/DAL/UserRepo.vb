Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text

Public Class UserRepo

    Dim userInfo As New UserInfo

    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Public Sub InsertUser()
        Dim id As String = AddUser.TxtId.Text.Trim()
        Dim firstname As String = AddUser.TxtFname.Text.Trim()
        Dim lastname As String = AddUser.TxtLname.Text.Trim()
        Dim password As String = AddUser.TxtPass.Text.Trim().ToLower
        Dim role As String = AddUser.CbRole.Text

        Dim passwordHash As String = HashPassword(password)
        Dim query As String = "INSERT INTO users (user_id, firstname, lastname, password_hash, user_type) VALUES (?, ?, ?, ?, ?)"

        Try
            connect_me()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", firstname)
                cmd.Parameters.AddWithValue("?", lastname)
                cmd.Parameters.AddWithValue("?", passwordHash)
                cmd.Parameters.AddWithValue("?", role)

                cmd.ExecuteNonQuery()
                MessageBox.Show("User Added Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function GetUserRole(username As String, password As String) As UserInfo
        'Dim userInfo As New UserInfo()
        Dim hashedPassword As String = HashPassword(password)

        Try
            connect_me()
            Dim query As String = "SELECT id, usertype, firstname, lastname, username FROM users WHERE username = ? AND password = ?"
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
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
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

        If userInfo IsNot Nothing AndAlso Not String.IsNullOrEmpty(userInfo.Role) Then
            POSForm.txtFullName.Text = $"{userInfo.Firstname} {userInfo.lastname}"
        Else
            MessageBox.Show("Invalid user type or password.")
        End If
    End Sub

    Public Sub LoadUser()
        Try
            Dim mycmd As New OdbcCommand("SELECT user_id, firstname AS Firstname, lastname AS Lastname, user_type AS Role, created_at, updated_at FROM users", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New Data.DataSet
            da.Fill(ds, "users")

            ManageUser.DgManageUser.DataSource = ds.Tables(0)
            ManageUser.DgManageUser.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
            'ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
            ManageUser.DgManageUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading... " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Get_id()
        Try
            connect_me()
            Dim number As Integer = 0

            If number = 0 Then
                Dim cmdnumber As New OdbcCommand("SELECT IFNULL(MAX(user_id), 0) FROM users", con)
                number = Convert.ToInt32(cmdnumber.ExecuteScalar())
            End If

            ' Assign the next transaction number
            AddUser.TxtId.Text = (number + 1).ToString()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading id..." & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteUser()
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            RowWhite()
            AddUser.Hide()
        Else
            Try
                ' Get selected user info
                Dim selectedRow As DataGridViewRow = ManageUser.DgManageUser.Rows(ManageUser.DgManageUser.CurrentCell.RowIndex)
                Dim id As String = selectedRow.Cells("user_id").Value.ToString()

                ' Connect to the database and delete the user
                connect_me()
                Dim query As String = "DELETE FROM users WHERE user_id = ?"
                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("?", id)
                    cmd.ExecuteNonQuery()
                End Using

                ' Refresh the DataGridView after deletion
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RowWhite()
                LoadUser()
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub EditUser()
        Dim result As DialogResult = MessageBox.Show("Edit?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            RowWhite()
            AddUser.Hide()
        Else
            Dim id As String = AddUser.TxtId.Text.Trim()
            Dim firstname As String = AddUser.TxtFname.Text.Trim()
            Dim lastname As String = AddUser.TxtLname.Text.Trim()
            Dim password As String = AddUser.TxtPass.Text.Trim().ToLower()
            Dim role As String = AddUser.CbRole.Text

            Dim passwordHash As String = HashPassword(password)
            Dim query As String = "UPDATE users SET firstname = ?, lastname = ?, password_hash = ?, user_type = ? WHERE user_id = ?"

            Try
                connect_me()
                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("?", firstname)
                    cmd.Parameters.AddWithValue("?", lastname)
                    cmd.Parameters.AddWithValue("?", passwordHash)
                    cmd.Parameters.AddWithValue("?", role)
                    cmd.Parameters.AddWithValue("?", id)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub RowWhite()
        ManageUser.DgManageUser.RowHeadersVisible = False
        ManageUser.DgManageUser.Enabled = False
        ManageUser.DgManageUser.DefaultCellStyle.SelectionBackColor = Color.White
        ManageUser.DgManageUser.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
    End Sub
End Class
