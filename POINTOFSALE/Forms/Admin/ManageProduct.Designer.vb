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
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchProduct = New System.Windows.Forms.TextBox()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.productReportBtn = New System.Windows.Forms.Button()
        Me.CbFilter = New System.Windows.Forms.ComboBox()
        Me.DgManageProduct = New System.Windows.Forms.DataGridView()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgManageProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Product"
        '
        'TxtSearchProduct
        '
        Me.TxtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearchProduct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchProduct.Location = New System.Drawing.Point(57, 48)
        Me.TxtSearchProduct.Name = "TxtSearchProduct"
        Me.TxtSearchProduct.Size = New System.Drawing.Size(375, 26)
        Me.TxtSearchProduct.TabIndex = 20
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.Button1)
        Me.adminMainPanel.Controls.Add(Me.BtnAdd)
        Me.adminMainPanel.Controls.Add(Me.PictureBox2)
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Controls.Add(Me.productReportBtn)
        Me.adminMainPanel.Controls.Add(Me.CbFilter)
        Me.adminMainPanel.Controls.Add(Me.DgManageProduct)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.TxtSearchProduct)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(875, 620)
        Me.adminMainPanel.TabIndex = 32
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
        Me.BtnAdd.Location = New System.Drawing.Point(543, 554)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(149, 43)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "ADD PRODUCT"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources.filter
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(449, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(26, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
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
        Me.productReportBtn.Location = New System.Drawing.Point(698, 554)
        Me.productReportBtn.Name = "productReportBtn"
        Me.productReportBtn.Size = New System.Drawing.Size(149, 43)
        Me.productReportBtn.TabIndex = 26
        Me.productReportBtn.Text = "PRINT REPORT"
        Me.productReportBtn.UseVisualStyleBackColor = False
        '
        'CbFilter
        '
        Me.CbFilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CbFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFilter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFilter.FormattingEnabled = True
        Me.CbFilter.Items.AddRange(New Object() {"CATEGORY", "TABLETS  ", "INJECTIONS  ", "OINTMENTS  ", "DROPS  ", "INHALER  ", "LIQUID SYRUP  ", "VITAMINS (ADULTS)  ", "VITAMINS (KIDS)"})
        Me.CbFilter.Location = New System.Drawing.Point(480, 49)
        Me.CbFilter.Name = "CbFilter"
        Me.CbFilter.Size = New System.Drawing.Size(151, 25)
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
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.DgManageProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgManageProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCol, Me.barcodeCol, Me.categoryCol, Me.genericnameCol, Me.brandnameCol, Me.formulaCol, Me.descriptionCol, Me.priceCol, Me.qtyCol, Me.expireCol, Me.editCol, Me.deleteCol})
        Me.DgManageProduct.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle41.NullValue = Nothing
        DataGridViewCellStyle41.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.DefaultCellStyle = DataGridViewCellStyle41
        Me.DgManageProduct.Location = New System.Drawing.Point(26, 80)
        Me.DgManageProduct.Name = "DgManageProduct"
        Me.DgManageProduct.ReadOnly = True
        Me.DgManageProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgManageProduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.DgManageProduct.RowHeadersVisible = False
        Me.DgManageProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgManageProduct.ShowEditingIcon = False
        Me.DgManageProduct.ShowRowErrors = False
        Me.DgManageProduct.Size = New System.Drawing.Size(821, 467)
        Me.DgManageProduct.TabIndex = 23
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
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceCol.DefaultCellStyle = DataGridViewCellStyle37
        Me.priceCol.FillWeight = 59.84925!
        Me.priceCol.HeaderText = "PRICE"
        Me.priceCol.Name = "priceCol"
        Me.priceCol.ReadOnly = True
        '
        'qtyCol
        '
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyCol.DefaultCellStyle = DataGridViewCellStyle38
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
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle39.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Gold
        Me.editCol.DefaultCellStyle = DataGridViewCellStyle39
        Me.editCol.FillWeight = 48.96758!
        Me.editCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editCol.HeaderText = "EDIT"
        Me.editCol.Name = "editCol"
        Me.editCol.ReadOnly = True
        '
        'deleteCol
        '
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle40.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Red
        Me.deleteCol.DefaultCellStyle = DataGridViewCellStyle40
        Me.deleteCol.FillWeight = 48.96758!
        Me.deleteCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteCol.HeaderText = "DELETE"
        Me.deleteCol.Name = "deleteCol"
        Me.deleteCol.ReadOnly = True
        Me.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(772, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "VIew log"
        Me.Button1.UseVisualStyleBackColor = False
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgManageProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchProduct As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents DgManageProduct As DataGridView
    Friend WithEvents CbFilter As ComboBox
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
