<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.AddUserPanel = New System.Windows.Forms.Panel()
        Me.CbRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCpass = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddUserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(361, 338)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 32)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(463, 338)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(96, 32)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Save"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'AddUserPanel
        '
        Me.AddUserPanel.BackColor = System.Drawing.Color.White
        Me.AddUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddUserPanel.Controls.Add(Me.CbRole)
        Me.AddUserPanel.Controls.Add(Me.BtnAdd)
        Me.AddUserPanel.Controls.Add(Me.Label4)
        Me.AddUserPanel.Controls.Add(Me.BtnCancel)
        Me.AddUserPanel.Controls.Add(Me.TxtLname)
        Me.AddUserPanel.Controls.Add(Me.Label3)
        Me.AddUserPanel.Controls.Add(Me.TxtCpass)
        Me.AddUserPanel.Controls.Add(Me.TxtFname)
        Me.AddUserPanel.Controls.Add(Me.Label6)
        Me.AddUserPanel.Controls.Add(Me.Label2)
        Me.AddUserPanel.Controls.Add(Me.TxtPass)
        Me.AddUserPanel.Controls.Add(Me.Label5)
        Me.AddUserPanel.Controls.Add(Me.TxtId)
        Me.AddUserPanel.Controls.Add(Me.Label1)
        Me.AddUserPanel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserPanel.Location = New System.Drawing.Point(12, 12)
        Me.AddUserPanel.Name = "AddUserPanel"
        Me.AddUserPanel.Size = New System.Drawing.Size(613, 402)
        Me.AddUserPanel.TabIndex = 1
        '
        'CbRole
        '
        Me.CbRole.BackColor = System.Drawing.Color.White
        Me.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbRole.FormattingEnabled = True
        Me.CbRole.Items.AddRange(New Object() {"--SELECT--", "Admin", "Cashier"})
        Me.CbRole.Location = New System.Drawing.Point(56, 267)
        Me.CbRole.Name = "CbRole"
        Me.CbRole.Size = New System.Drawing.Size(238, 25)
        Me.CbRole.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User Type / Role"
        '
        'TxtLname
        '
        Me.TxtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLname.Location = New System.Drawing.Point(56, 197)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(238, 25)
        Me.TxtLname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lastname"
        '
        'TxtCpass
        '
        Me.TxtCpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCpass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpass.Location = New System.Drawing.Point(341, 134)
        Me.TxtCpass.Name = "TxtCpass"
        Me.TxtCpass.Size = New System.Drawing.Size(218, 25)
        Me.TxtCpass.TabIndex = 8
        '
        'TxtFname
        '
        Me.TxtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFname.Location = New System.Drawing.Point(56, 134)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(238, 25)
        Me.TxtFname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name:"
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(341, 70)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(218, 25)
        Me.TxtPass.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password:"
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(56, 70)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(238, 25)
        Me.TxtId.TabIndex = 9
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id:"
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.AddUserPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.AddUserPanel.ResumeLayout(False)
        Me.AddUserPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents AddUserPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCpass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbRole As ComboBox
End Class
