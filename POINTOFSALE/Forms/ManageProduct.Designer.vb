<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProduct))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_product = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.DgProduct = New System.Windows.Forms.DataGridView()
        Me.LblAction = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addBox = New System.Windows.Forms.PictureBox()
        Me.searchBox = New System.Windows.Forms.PictureBox()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.DgProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Product"
        '
        'search_product
        '
        Me.search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_product.Location = New System.Drawing.Point(544, 26)
        Me.search_product.Name = "search_product"
        Me.search_product.Size = New System.Drawing.Size(313, 29)
        Me.search_product.TabIndex = 20
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(743, 537)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 36)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.DgProduct)
        Me.adminMainPanel.Controls.Add(Me.LblAction)
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Controls.Add(Me.addBox)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.BtnAdd)
        Me.adminMainPanel.Controls.Add(Me.searchBox)
        Me.adminMainPanel.Controls.Add(Me.search_product)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(875, 598)
        Me.adminMainPanel.TabIndex = 32
        '
        'DgProduct
        '
        Me.DgProduct.AllowUserToAddRows = False
        Me.DgProduct.AllowUserToDeleteRows = False
        Me.DgProduct.AllowUserToResizeColumns = False
        Me.DgProduct.AllowUserToResizeRows = False
        Me.DgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProduct.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgProduct.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgProduct.Location = New System.Drawing.Point(11, 74)
        Me.DgProduct.MultiSelect = False
        Me.DgProduct.Name = "DgProduct"
        Me.DgProduct.ReadOnly = True
        Me.DgProduct.RowHeadersVisible = False
        Me.DgProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProduct.Size = New System.Drawing.Size(846, 448)
        Me.DgProduct.TabIndex = 33
        '
        'LblAction
        '
        Me.LblAction.AutoSize = True
        Me.LblAction.Location = New System.Drawing.Point(246, 40)
        Me.LblAction.Name = "LblAction"
        Me.LblAction.Size = New System.Drawing.Size(0, 13)
        Me.LblAction.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'addBox
        '
        Me.addBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addBox.Image = CType(resources.GetObject("addBox.Image"), System.Drawing.Image)
        Me.addBox.Location = New System.Drawing.Point(746, 541)
        Me.addBox.Name = "addBox"
        Me.addBox.Size = New System.Drawing.Size(30, 29)
        Me.addBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addBox.TabIndex = 26
        Me.addBox.TabStop = False
        '
        'searchBox
        '
        Me.searchBox.Image = CType(resources.GetObject("searchBox.Image"), System.Drawing.Image)
        Me.searchBox.Location = New System.Drawing.Point(504, 26)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(34, 29)
        Me.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchBox.TabIndex = 21
        Me.searchBox.TabStop = False
        '
        'ManageProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 598)
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryDashboard"
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.DgProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents search_product As TextBox
    Friend WithEvents searchBox As PictureBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents addBox As PictureBox
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents LblAction As Label
    Friend WithEvents DgProduct As DataGridView
End Class
