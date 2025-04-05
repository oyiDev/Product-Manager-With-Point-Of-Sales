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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProduct))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchProduct = New System.Windows.Forms.TextBox()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.productReportBtn = New System.Windows.Forms.Button()
        Me.CbFilter = New System.Windows.Forms.ComboBox()
        Me.DgManageProduct = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.searchBox = New System.Windows.Forms.PictureBox()
        Me.idCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formulaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expireCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.deleteCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.DgManageProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Product"
        '
        'TxtSearchProduct
        '
        Me.TxtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchProduct.Location = New System.Drawing.Point(60, 45)
        Me.TxtSearchProduct.Name = "TxtSearchProduct"
        Me.TxtSearchProduct.Size = New System.Drawing.Size(375, 27)
        Me.TxtSearchProduct.TabIndex = 20
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.productReportBtn)
        Me.adminMainPanel.Controls.Add(Me.CbFilter)
        Me.adminMainPanel.Controls.Add(Me.DgManageProduct)
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.BtnAdd)
        Me.adminMainPanel.Controls.Add(Me.PictureBox2)
        Me.adminMainPanel.Controls.Add(Me.searchBox)
        Me.adminMainPanel.Controls.Add(Me.TxtSearchProduct)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(875, 620)
        Me.adminMainPanel.TabIndex = 32
        '
        'productReportBtn
        '
        Me.productReportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productReportBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.productReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.productReportBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.productReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.productReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.productReportBtn.Location = New System.Drawing.Point(559, 557)
        Me.productReportBtn.Name = "productReportBtn"
        Me.productReportBtn.Size = New System.Drawing.Size(149, 43)
        Me.productReportBtn.TabIndex = 26
        Me.productReportBtn.Text = "PRODUCT REPORT"
        Me.productReportBtn.UseVisualStyleBackColor = False
        '
        'CbFilter
        '
        Me.CbFilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CbFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFilter.FormattingEnabled = True
        Me.CbFilter.Items.AddRange(New Object() {"CATEGORY", "TABLETS  ", "INJECTIONS  ", "OINTMENTS  ", "DROPS  ", "INHALER  ", "LIQUID SYRUP  ", "VITAMINS (ADULTS)  ", "VITAMINS (KIDS)"})
        Me.CbFilter.Location = New System.Drawing.Point(487, 44)
        Me.CbFilter.Name = "CbFilter"
        Me.CbFilter.Size = New System.Drawing.Size(151, 28)
        Me.CbFilter.TabIndex = 24
        '
        'DgManageProduct
        '
        Me.DgManageProduct.AllowUserToAddRows = False
        Me.DgManageProduct.AllowUserToDeleteRows = False
        Me.DgManageProduct.AllowUserToResizeColumns = False
        Me.DgManageProduct.AllowUserToResizeRows = False
        Me.DgManageProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgManageProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgManageProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgManageProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgManageProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgManageProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgManageProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCol, Me.barcodeCol, Me.categoryCol, Me.genericnameCol, Me.brandnameCol, Me.formulaCol, Me.descriptionCol, Me.priceCol, Me.qtyCol, Me.expireCol, Me.editCol, Me.deleteCol})
        Me.DgManageProduct.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgManageProduct.Location = New System.Drawing.Point(26, 80)
        Me.DgManageProduct.Name = "DgManageProduct"
        Me.DgManageProduct.ReadOnly = True
        Me.DgManageProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgManageProduct.RowHeadersVisible = False
        Me.DgManageProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgManageProduct.ShowEditingIcon = False
        Me.DgManageProduct.ShowRowErrors = False
        Me.DgManageProduct.Size = New System.Drawing.Size(821, 467)
        Me.DgManageProduct.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(722, 557)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(125, 44)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "ADD PRODUCT"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources.filter__2_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(456, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'searchBox
        '
        Me.searchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Image = CType(resources.GetObject("searchBox.Image"), System.Drawing.Image)
        Me.searchBox.Location = New System.Drawing.Point(26, 45)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(34, 28)
        Me.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchBox.TabIndex = 21
        Me.searchBox.TabStop = False
        '
        'idCol
        '
        Me.idCol.FillWeight = 40.0!
        Me.idCol.HeaderText = "ID"
        Me.idCol.Name = "idCol"
        Me.idCol.ReadOnly = True
        Me.idCol.Visible = False
        '
        'barcodeCol
        '
        Me.barcodeCol.FillWeight = 108.8168!
        Me.barcodeCol.HeaderText = "BARCODE"
        Me.barcodeCol.Name = "barcodeCol"
        Me.barcodeCol.ReadOnly = True
        '
        'categoryCol
        '
        Me.categoryCol.FillWeight = 108.8168!
        Me.categoryCol.HeaderText = "CATEGORY"
        Me.categoryCol.Name = "categoryCol"
        Me.categoryCol.ReadOnly = True
        '
        'genericnameCol
        '
        Me.genericnameCol.FillWeight = 108.8168!
        Me.genericnameCol.HeaderText = "GENERICNAME"
        Me.genericnameCol.Name = "genericnameCol"
        Me.genericnameCol.ReadOnly = True
        '
        'brandnameCol
        '
        Me.brandnameCol.FillWeight = 108.8168!
        Me.brandnameCol.HeaderText = "BRANDNAME"
        Me.brandnameCol.Name = "brandnameCol"
        Me.brandnameCol.ReadOnly = True
        '
        'formulaCol
        '
        Me.formulaCol.FillWeight = 108.8168!
        Me.formulaCol.HeaderText = "FORMULA"
        Me.formulaCol.Name = "formulaCol"
        Me.formulaCol.ReadOnly = True
        '
        'descriptionCol
        '
        Me.descriptionCol.FillWeight = 108.8168!
        Me.descriptionCol.HeaderText = "DESCRIPTION"
        Me.descriptionCol.Name = "descriptionCol"
        Me.descriptionCol.ReadOnly = True
        '
        'priceCol
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceCol.DefaultCellStyle = DataGridViewCellStyle9
        Me.priceCol.FillWeight = 59.84925!
        Me.priceCol.HeaderText = "PRICE"
        Me.priceCol.Name = "priceCol"
        Me.priceCol.ReadOnly = True
        '
        'qtyCol
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyCol.DefaultCellStyle = DataGridViewCellStyle10
        Me.qtyCol.FillWeight = 55.0!
        Me.qtyCol.HeaderText = "QTY"
        Me.qtyCol.Name = "qtyCol"
        Me.qtyCol.ReadOnly = True
        Me.qtyCol.Visible = False
        '
        'expireCol
        '
        Me.expireCol.FillWeight = 45.0!
        Me.expireCol.HeaderText = "EXP"
        Me.expireCol.Name = "expireCol"
        Me.expireCol.ReadOnly = True
        Me.expireCol.Visible = False
        '
        'editCol
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gold
        Me.editCol.DefaultCellStyle = DataGridViewCellStyle11
        Me.editCol.FillWeight = 48.96758!
        Me.editCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editCol.HeaderText = "EDIT"
        Me.editCol.Name = "editCol"
        Me.editCol.ReadOnly = True
        '
        'deleteCol
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Red
        Me.deleteCol.DefaultCellStyle = DataGridViewCellStyle12
        Me.deleteCol.FillWeight = 48.96758!
        Me.deleteCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteCol.HeaderText = "DELETE"
        Me.deleteCol.Name = "deleteCol"
        Me.deleteCol.ReadOnly = True
        Me.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ManageProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 620)
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryDashboard"
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.DgManageProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtSearchProduct As TextBox
    Friend WithEvents searchBox As PictureBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents DgManageProduct As DataGridView
    Friend WithEvents CbFilter As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents productReportBtn As Button
    Friend WithEvents idCol As DataGridViewTextBoxColumn
    Friend WithEvents barcodeCol As DataGridViewTextBoxColumn
    Friend WithEvents categoryCol As DataGridViewTextBoxColumn
    Friend WithEvents genericnameCol As DataGridViewTextBoxColumn
    Friend WithEvents brandnameCol As DataGridViewTextBoxColumn
    Friend WithEvents formulaCol As DataGridViewTextBoxColumn
    Friend WithEvents descriptionCol As DataGridViewTextBoxColumn
    Friend WithEvents priceCol As DataGridViewTextBoxColumn
    Friend WithEvents qtyCol As DataGridViewTextBoxColumn
    Friend WithEvents expireCol As DataGridViewTextBoxColumn
    Friend WithEvents editCol As DataGridViewButtonColumn
    Friend WithEvents deleteCol As DataGridViewButtonColumn
End Class
