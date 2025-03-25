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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdduser = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgManageUser = New System.Windows.Forms.DataGridView()
        Me.LblAction = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgManageUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage User"
        '
        'btnAdduser
        '
        Me.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdduser.Location = New System.Drawing.Point(721, 47)
        Me.btnAdduser.Name = "btnAdduser"
        Me.btnAdduser.Size = New System.Drawing.Size(125, 33)
        Me.btnAdduser.TabIndex = 10
        Me.btnAdduser.Text = "ADD USER"
        Me.btnAdduser.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(721, 544)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(125, 33)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Controls.Add(Me.DgManageUser)
        Me.adminMainPanel.Controls.Add(Me.LblAction)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.BtnEdit)
        Me.adminMainPanel.Controls.Add(Me.BtnDelete)
        Me.adminMainPanel.Controls.Add(Me.btnAdduser)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(873, 596)
        Me.adminMainPanel.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'DgManageUser
        '
        Me.DgManageUser.AllowUserToAddRows = False
        Me.DgManageUser.AllowUserToDeleteRows = False
        Me.DgManageUser.AllowUserToResizeColumns = False
        Me.DgManageUser.AllowUserToResizeRows = False
        Me.DgManageUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgManageUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgManageUser.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgManageUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgManageUser.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgManageUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgManageUser.Location = New System.Drawing.Point(27, 86)
        Me.DgManageUser.MultiSelect = False
        Me.DgManageUser.Name = "DgManageUser"
        Me.DgManageUser.ReadOnly = True
        Me.DgManageUser.RowHeadersVisible = False
        Me.DgManageUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgManageUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgManageUser.Size = New System.Drawing.Size(819, 448)
        Me.DgManageUser.TabIndex = 11
        '
        'LblAction
        '
        Me.LblAction.AutoSize = True
        Me.LblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAction.Location = New System.Drawing.Point(141, 21)
        Me.LblAction.Name = "LblAction"
        Me.LblAction.Size = New System.Drawing.Size(0, 18)
        Me.LblAction.TabIndex = 9
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Location = New System.Drawing.Point(590, 544)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(125, 33)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ManageUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgManageUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdduser As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents DgManageUser As DataGridView
    Friend WithEvents BtnEdit As Button
    Friend WithEvents LblAction As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
