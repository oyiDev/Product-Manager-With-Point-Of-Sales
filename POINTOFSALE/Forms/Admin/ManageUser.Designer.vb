<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdduser = New System.Windows.Forms.Button()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.DgManageUser = New System.Windows.Forms.DataGridView()
        Me.idCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usernameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdatCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedatCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.deleteCol = New System.Windows.Forms.DataGridViewButtonColumn()

        Me.TxtUserSearch = New System.Windows.Forms.TextBox()
        Me.searchBox = New System.Windows.Forms.PictureBox()


        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.DgManageUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage User"
        '
        'btnAdduser
        '
        Me.btnAdduser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdduser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdduser.Location = New System.Drawing.Point(722, 554)
        Me.btnAdduser.Name = "btnAdduser"
        Me.btnAdduser.Size = New System.Drawing.Size(125, 44)
        Me.btnAdduser.TabIndex = 10
        Me.btnAdduser.Text = "ADD USER"
        Me.btnAdduser.UseVisualStyleBackColor = False
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.DgManageUser)
        Me.adminMainPanel.Controls.Add(Me.searchBox)
        Me.adminMainPanel.Controls.Add(Me.TxtUserSearch)
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.btnAdduser)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(873, 618)
        Me.adminMainPanel.TabIndex = 11
        '
        'DgManageUser
        '
        Me.DgManageUser.AllowUserToAddRows = False
        Me.DgManageUser.AllowUserToDeleteRows = False
        Me.DgManageUser.AllowUserToResizeColumns = False
        Me.DgManageUser.AllowUserToResizeRows = False
        Me.DgManageUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgManageUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgManageUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgManageUser.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgManageUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgManageUser.Location = New System.Drawing.Point(25, 60)
        Me.DgManageUser.MultiSelect = False
        Me.DgManageUser.Name = "DgManageUser"
        Me.DgManageUser.ReadOnly = True
        Me.DgManageUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgManageUser.RowHeadersVisible = False
        Me.DgManageUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.DgManageUser.ShowEditingIcon = False
        Me.DgManageUser.ShowRowErrors = False
        Me.DgManageUser.Size = New System.Drawing.Size(821, 467)
        Me.DgManageUser.TabIndex = 24
        '
        'idCol
        '
        Me.idCol.HeaderText = "USER ID"
        Me.idCol.Name = "idCol"
        Me.idCol.ReadOnly = True
        '
        'firstnameCol
        '
        Me.firstnameCol.HeaderText = "FIRSTNAME"
        Me.firstnameCol.Name = "firstnameCol"
        Me.firstnameCol.ReadOnly = True
        '
        'lastnameCol
        '
        Me.lastnameCol.HeaderText = "LASTNAME"
        Me.lastnameCol.Name = "lastnameCol"
        Me.lastnameCol.ReadOnly = True
        '
        'usernameCol
        '
        Me.usernameCol.HeaderText = "USERNAME"
        Me.usernameCol.Name = "usernameCol"
        Me.usernameCol.ReadOnly = True
        '
        'usertypeCol
        '
        Me.usertypeCol.HeaderText = "USERTYPE"
        Me.usertypeCol.Name = "usertypeCol"
        Me.usertypeCol.ReadOnly = True
        '
        'createdatCol
        '
        Me.createdatCol.HeaderText = "CREATED AT"
        Me.createdatCol.Name = "createdatCol"
        Me.createdatCol.ReadOnly = True
        '
        'updatedatCol
        '
        Me.updatedatCol.HeaderText = "UPDATED AT"
        Me.updatedatCol.Name = "updatedatCol"
        Me.updatedatCol.ReadOnly = True
        '
        'editCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow
        Me.editCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.editCol.FillWeight = 45.0!
        Me.editCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editCol.HeaderText = "EDIT"
        Me.editCol.Name = "editCol"
        Me.editCol.ReadOnly = True
        '
        'deleteCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        Me.deleteCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.deleteCol.FillWeight = 46.0!
        Me.deleteCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteCol.HeaderText = "DELETE"
        Me.deleteCol.Name = "deleteCol"
        Me.deleteCol.ReadOnly = True
        '

        'TxtUserSearch
        '
        Me.TxtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUserSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserSearch.Location = New System.Drawing.Point(65, 45)
        Me.TxtUserSearch.Name = "TxtUserSearch"
        Me.TxtUserSearch.Size = New System.Drawing.Size(376, 26)
        Me.TxtUserSearch.TabIndex = 14
        '
        'searchBox
        '
        Me.searchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.searchBox.Image = CType(resources.GetObject("searchBox.Image"), System.Drawing.Image)
        Me.searchBox.Location = New System.Drawing.Point(26, 45)

        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(34, 26)
        Me.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchBox.TabIndex = 22
        Me.searchBox.TabStop = False

        '
        'TxtUserSearch
        '
        Me.TxtUserSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUserSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserSearch.Location = New System.Drawing.Point(437, 37)
        Me.TxtUserSearch.Name = "TxtUserSearch"
        Me.TxtUserSearch.Size = New System.Drawing.Size(410, 26)
        Me.TxtUserSearch.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ManageUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.DgManageUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdduser As Button
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUserSearch As TextBox
    Friend WithEvents searchBox As PictureBox
    Friend WithEvents DgManageUser As DataGridView
    Friend WithEvents idCol As DataGridViewTextBoxColumn
    Friend WithEvents firstnameCol As DataGridViewTextBoxColumn
    Friend WithEvents lastnameCol As DataGridViewTextBoxColumn
    Friend WithEvents usernameCol As DataGridViewTextBoxColumn
    Friend WithEvents usertypeCol As DataGridViewTextBoxColumn
    Friend WithEvents createdatCol As DataGridViewTextBoxColumn
    Friend WithEvents updatedatCol As DataGridViewTextBoxColumn
    Friend WithEvents editCol As DataGridViewButtonColumn
    Friend WithEvents deleteCol As DataGridViewButtonColumn
End Class
