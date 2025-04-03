<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.AddUserPanel = New System.Windows.Forms.Panel()
        Me.BtnChangepass = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.CbRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCpass = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.LblCpassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddUserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(391, 340)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(88, 32)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(485, 340)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(88, 32)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'AddUserPanel
        '
        Me.AddUserPanel.BackColor = System.Drawing.Color.White
        Me.AddUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddUserPanel.Controls.Add(Me.BtnChangepass)
        Me.AddUserPanel.Controls.Add(Me.Label7)
        Me.AddUserPanel.Controls.Add(Me.TxtUsername)
        Me.AddUserPanel.Controls.Add(Me.CbRole)
        Me.AddUserPanel.Controls.Add(Me.BtnSave)
        Me.AddUserPanel.Controls.Add(Me.Label4)
        Me.AddUserPanel.Controls.Add(Me.BtnClose)
        Me.AddUserPanel.Controls.Add(Me.TxtLname)
        Me.AddUserPanel.Controls.Add(Me.Label3)
        Me.AddUserPanel.Controls.Add(Me.TxtCpass)
        Me.AddUserPanel.Controls.Add(Me.TxtFname)
        Me.AddUserPanel.Controls.Add(Me.LblCpassword)
        Me.AddUserPanel.Controls.Add(Me.Label2)
        Me.AddUserPanel.Controls.Add(Me.TxtPass)
        Me.AddUserPanel.Controls.Add(Me.LblPassword)
        Me.AddUserPanel.Controls.Add(Me.TxtId)
        Me.AddUserPanel.Controls.Add(Me.Label1)
        Me.AddUserPanel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserPanel.Location = New System.Drawing.Point(12, 11)
        Me.AddUserPanel.Name = "AddUserPanel"
        Me.AddUserPanel.Size = New System.Drawing.Size(621, 430)
        Me.AddUserPanel.TabIndex = 1
        '
        'BtnChangepass
        '
        Me.BtnChangepass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnChangepass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangepass.Location = New System.Drawing.Point(254, 339)
        Me.BtnChangepass.Name = "BtnChangepass"
        Me.BtnChangepass.Size = New System.Drawing.Size(131, 32)
        Me.BtnChangepass.TabIndex = 13
        Me.BtnChangepass.Text = "Change password"
        Me.BtnChangepass.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 60)
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(335, 79)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(238, 23)
        '
        'CbRole
        '
        Me.CbRole.BackColor = System.Drawing.Color.White
        Me.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbRole.FormattingEnabled = True
        Me.CbRole.Items.AddRange(New Object() {"--SELECT--", "Admin", "Cashier"})
        Me.CbRole.Location = New System.Drawing.Point(50, 272)
        Me.CbRole.Name = "CbRole"
        Me.CbRole.Size = New System.Drawing.Size(238, 26)
        Me.CbRole.TabIndex = 10
        '
        'Label4
        '

        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 254)
        '
        'TxtLname
        '
        Me.TxtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLname.Location = New System.Drawing.Point(50, 206)

        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 190)

        '
        'TxtCpass
        '
        Me.TxtCpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCpass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpass.Location = New System.Drawing.Point(335, 206)
        Me.TxtCpass.Name = "TxtCpass"
        Me.TxtCpass.Size = New System.Drawing.Size(238, 25)
        '
        'TxtFname
        '
        Me.TxtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFname.Location = New System.Drawing.Point(50, 143)
        '
        'LblCpassword
        '
        Me.LblCpassword.AutoSize = True
        Me.LblCpassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpassword.Location = New System.Drawing.Point(332, 188)
        Me.LblCpassword.Name = "LblCpassword"
        Me.LblCpassword.Size = New System.Drawing.Size(130, 15)
        Me.LblCpassword.TabIndex = 5
        Me.LblCpassword.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 125)
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(335, 142)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(238, 25)
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(332, 126)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(75, 15)
        Me.LblPassword.TabIndex = 6
        Me.LblPassword.Text = "Password:"
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Enabled = False

        Me.TxtId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(50, 79)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 63)
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(645, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.AddUserPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.AddUserPanel.ResumeLayout(False)
        Me.AddUserPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents AddUserPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCpass As TextBox
    Friend WithEvents LblCpassword As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents CbRole As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BtnChangepass As Button
End Class
