<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSubTotal = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnItemList = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtTransSubtotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.dgTransaction = New System.Windows.Forms.DataGridView()
        Me.barcodecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnCashout = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.BtnEditQty = New System.Windows.Forms.Button()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.BtnTransRecord = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRole = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSubTotal
        '
        Me.BtnSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubTotal.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSubTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubTotal.Location = New System.Drawing.Point(750, 500)
        Me.BtnSubTotal.Name = "BtnSubTotal"
        Me.BtnSubTotal.Size = New System.Drawing.Size(145, 40)
        Me.BtnSubTotal.TabIndex = 17
        Me.BtnSubTotal.Text = "(F12) SUBTOTAL"
        Me.BtnSubTotal.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(917, 534)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(231, 49)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "(Crl + x) - EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.Color.Tomato
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(447, 500)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(145, 40)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "(F11) DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnItemList
        '
        Me.BtnItemList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnItemList.BackColor = System.Drawing.Color.Silver
        Me.BtnItemList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItemList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItemList.Location = New System.Drawing.Point(141, 500)
        Me.BtnItemList.Name = "BtnItemList"
        Me.BtnItemList.Size = New System.Drawing.Size(145, 40)
        Me.BtnItemList.TabIndex = 24
        Me.BtnItemList.Text = "(F9) ITEMLIST"
        Me.BtnItemList.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(10, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "SCAN BARCODE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(141, 453)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(754, 31)
        Me.txtBarcode.TabIndex = 15
        '
        'txtTransSubtotal
        '
        Me.txtTransSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTransSubtotal.BackColor = System.Drawing.Color.MediumBlue
        Me.txtTransSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTransSubtotal.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransSubtotal.ForeColor = System.Drawing.Color.Gold
        Me.txtTransSubtotal.Location = New System.Drawing.Point(645, 6)
        Me.txtTransSubtotal.Name = "txtTransSubtotal"
        Me.txtTransSubtotal.ReadOnly = True
        Me.txtTransSubtotal.Size = New System.Drawing.Size(479, 47)
        Me.txtTransSubtotal.TabIndex = 12
        Me.txtTransSubtotal.Text = "₱ 0.00"
        Me.txtTransSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTransSubtotal)
        Me.Panel1.Controls.Add(Me.lblAction)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 63)
        Me.Panel1.TabIndex = 16
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.MediumBlue
        Me.lblAction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.White
        Me.lblAction.Location = New System.Drawing.Point(1, 7)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(137, 23)
        Me.lblAction.TabIndex = 7
        Me.lblAction.Text = "CASH SALES"
        '
        'dgTransaction
        '
        Me.dgTransaction.AllowUserToAddRows = False
        Me.dgTransaction.AllowUserToDeleteRows = False
        Me.dgTransaction.AllowUserToResizeColumns = False
        Me.dgTransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTransaction.BackgroundColor = System.Drawing.Color.White
        Me.dgTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgTransaction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barcodecol, Me.nameCol, Me.priceCol, Me.qtyCol, Me.amountCol})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransaction.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTransaction.Location = New System.Drawing.Point(10, 80)
        Me.dgTransaction.MultiSelect = False
        Me.dgTransaction.Name = "dgTransaction"
        Me.dgTransaction.ReadOnly = True
        Me.dgTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransaction.ShowCellErrors = False
        Me.dgTransaction.ShowCellToolTips = False
        Me.dgTransaction.ShowEditingIcon = False
        Me.dgTransaction.ShowRowErrors = False
        Me.dgTransaction.Size = New System.Drawing.Size(1138, 367)
        Me.dgTransaction.TabIndex = 13
        '
        'barcodecol
        '
        Me.barcodecol.HeaderText = "BARCODE"
        Me.barcodecol.Name = "barcodecol"
        Me.barcodecol.ReadOnly = True
        '
        'nameCol
        '
        Me.nameCol.HeaderText = "NAME"
        Me.nameCol.Name = "nameCol"
        Me.nameCol.ReadOnly = True
        '
        'priceCol
        '
        Me.priceCol.HeaderText = "PRICE"
        Me.priceCol.Name = "priceCol"
        Me.priceCol.ReadOnly = True
        '
        'qtyCol
        '
        Me.qtyCol.HeaderText = "QTY"
        Me.qtyCol.Name = "qtyCol"
        Me.qtyCol.ReadOnly = True
        '
        'amountCol
        '
        Me.amountCol.HeaderText = "AMOUNT"
        Me.amountCol.Name = "amountCol"
        Me.amountCol.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 560)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "DATE:"
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(254, 553)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(137, 23)
        Me.txtDate.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TIME:"
        '
        'txtTime
        '
        Me.txtTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(441, 554)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(137, 23)
        Me.txtTime.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 560)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "NAME:"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(633, 554)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(262, 23)
        Me.txtFullName.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtnCashout
        '
        Me.BtnCashout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCashout.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnCashout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCashout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCashout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashout.Location = New System.Drawing.Point(10, 500)
        Me.BtnCashout.Name = "BtnCashout"
        Me.BtnCashout.Size = New System.Drawing.Size(125, 40)
        Me.BtnCashout.TabIndex = 27
        Me.BtnCashout.Text = "(F8) CASH OUT"
        Me.BtnCashout.UseVisualStyleBackColor = False
        '
        'BtnSales
        '
        Me.BtnSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSales.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSales.ForeColor = System.Drawing.Color.Black
        Me.BtnSales.Location = New System.Drawing.Point(917, 453)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Size = New System.Drawing.Size(231, 51)
        Me.BtnSales.TabIndex = 0
        Me.BtnSales.Text = "(crl + S)  SALES"
        Me.BtnSales.UseVisualStyleBackColor = False
        '
        'BtnEditQty
        '
        Me.BtnEditQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditQty.BackColor = System.Drawing.Color.Orange
        Me.BtnEditQty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditQty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditQty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditQty.Location = New System.Drawing.Point(292, 500)
        Me.BtnEditQty.Name = "BtnEditQty"
        Me.BtnEditQty.Size = New System.Drawing.Size(149, 40)
        Me.BtnEditQty.TabIndex = 0
        Me.BtnEditQty.Text = "(F10) EDIT QTY"
        Me.BtnEditQty.UseVisualStyleBackColor = False
        '
        'txtnumber
        '
        Me.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtnumber.Location = New System.Drawing.Point(917, 508)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(231, 20)
        Me.txtnumber.TabIndex = 29
        '
        'BtnTransRecord
        '
        Me.BtnTransRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTransRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransRecord.Location = New System.Drawing.Point(598, 500)
        Me.BtnTransRecord.Name = "BtnTransRecord"
        Me.BtnTransRecord.Size = New System.Drawing.Size(145, 40)
        Me.BtnTransRecord.TabIndex = 30
        Me.BtnTransRecord.Text = "(Crl + L)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSACTION RECORD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnTransRecord.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Role:"
        '
        'TxtRole
        '
        Me.TxtRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRole.Location = New System.Drawing.Point(50, 553)
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.ReadOnly = True
        Me.TxtRole.Size = New System.Drawing.Size(145, 23)
        Me.TxtRole.TabIndex = 32
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1159, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnTransRecord)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.BtnSales)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEditQty)
        Me.Controls.Add(Me.BtnCashout)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSubTotal)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnItemList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSubTotal As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnItemList As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtTransSubtotal As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAction As Label
    Friend WithEvents dgTransaction As DataGridView
    Friend WithEvents barcodecol As DataGridViewTextBoxColumn
    Friend WithEvents nameCol As DataGridViewTextBoxColumn
    Friend WithEvents priceCol As DataGridViewTextBoxColumn
    Friend WithEvents qtyCol As DataGridViewTextBoxColumn
    Friend WithEvents amountCol As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnCashout As Button
    Friend WithEvents BtnSales As Button
    Friend WithEvents BtnEditQty As Button
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents BtnTransRecord As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRole As TextBox
End Class
