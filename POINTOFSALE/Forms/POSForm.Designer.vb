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
        Me.btnSubtotal = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnItemList = New System.Windows.Forms.Button()
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
        Me.BtnRecord = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbNumber = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.bnt9 = New System.Windows.Forms.Button()
        Me.btnSlash = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnZRead = New System.Windows.Forms.Button()
        Me.BtnEditQty = New System.Windows.Forms.Button()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GbNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubtotal
        '
        Me.btnSubtotal.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubtotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubtotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtotal.Location = New System.Drawing.Point(598, 500)
        Me.btnSubtotal.Name = "btnSubtotal"
        Me.btnSubtotal.Size = New System.Drawing.Size(145, 40)
        Me.btnSubtotal.TabIndex = 17
        Me.btnSubtotal.Text = "(F12) SUBTOTAL"
        Me.btnSubtotal.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(765, 534)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(216, 49)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "(Crl + x) - EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(447, 500)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(145, 40)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "(F11) DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnItemList
        '
        Me.btnItemList.BackColor = System.Drawing.Color.Orange
        Me.btnItemList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemList.Location = New System.Drawing.Point(141, 500)
        Me.btnItemList.Name = "btnItemList"
        Me.btnItemList.Size = New System.Drawing.Size(145, 40)
        Me.btnItemList.TabIndex = 24
        Me.btnItemList.Text = "(F9) ITEMLIST"
        Me.btnItemList.UseVisualStyleBackColor = False
        '
        'Button1
        '
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
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(141, 453)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(602, 31)
        Me.txtBarcode.TabIndex = 15
        '
        'txtTransSubtotal
        '
        Me.txtTransSubtotal.BackColor = System.Drawing.Color.MediumBlue
        Me.txtTransSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTransSubtotal.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransSubtotal.ForeColor = System.Drawing.Color.Gold
        Me.txtTransSubtotal.Location = New System.Drawing.Point(240, 6)
        Me.txtTransSubtotal.Name = "txtTransSubtotal"
        Me.txtTransSubtotal.ReadOnly = True
        Me.txtTransSubtotal.Size = New System.Drawing.Size(479, 47)
        Me.txtTransSubtotal.TabIndex = 12
        Me.txtTransSubtotal.Text = "₱ 0.00"
        Me.txtTransSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTransSubtotal)
        Me.Panel1.Controls.Add(Me.lblAction)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 63)
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
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.dgTransaction.Size = New System.Drawing.Size(733, 367)
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
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 566)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "DATE:"
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(63, 559)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(137, 23)
        Me.txtDate.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 566)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TIME:"
        '
        'txtTime
        '
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(250, 560)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(137, 23)
        Me.txtTime.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(389, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "NAME:"
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(442, 560)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(301, 23)
        Me.txtFullName.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtnRecord
        '
        Me.BtnRecord.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecord.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecord.Location = New System.Drawing.Point(10, 500)
        Me.BtnRecord.Name = "BtnRecord"
        Me.BtnRecord.Size = New System.Drawing.Size(125, 40)
        Me.BtnRecord.TabIndex = 27
        Me.BtnRecord.Text = "(F8) CASH OUT"
        Me.BtnRecord.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(749, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 63)
        Me.Panel2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POINT OF SALES"
        '
        'GbNumber
        '
        Me.GbNumber.Controls.Add(Me.btnClear)
        Me.GbNumber.Controls.Add(Me.btn3)
        Me.GbNumber.Controls.Add(Me.btn6)
        Me.GbNumber.Controls.Add(Me.bnt9)
        Me.GbNumber.Controls.Add(Me.btnSlash)
        Me.GbNumber.Controls.Add(Me.btn0)
        Me.GbNumber.Controls.Add(Me.btn2)
        Me.GbNumber.Controls.Add(Me.btn1)
        Me.GbNumber.Controls.Add(Me.btn5)
        Me.GbNumber.Controls.Add(Me.btn4)
        Me.GbNumber.Controls.Add(Me.btn8)
        Me.GbNumber.Controls.Add(Me.btn7)
        Me.GbNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GbNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbNumber.Location = New System.Drawing.Point(749, 81)
        Me.GbNumber.Name = "GbNumber"
        Me.GbNumber.Size = New System.Drawing.Size(247, 366)
        Me.GbNumber.TabIndex = 28
        Me.GbNumber.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(164, 249)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 64)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(164, 179)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(68, 64)
        Me.btn3.TabIndex = 0
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(164, 109)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(68, 64)
        Me.btn6.TabIndex = 0
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'bnt9
        '
        Me.bnt9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bnt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnt9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt9.Location = New System.Drawing.Point(164, 39)
        Me.bnt9.Name = "bnt9"
        Me.bnt9.Size = New System.Drawing.Size(68, 64)
        Me.bnt9.TabIndex = 0
        Me.bnt9.Text = "9"
        Me.bnt9.UseVisualStyleBackColor = False
        '
        'btnSlash
        '
        Me.btnSlash.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSlash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlash.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlash.Location = New System.Drawing.Point(16, 249)
        Me.btnSlash.Name = "btnSlash"
        Me.btnSlash.Size = New System.Drawing.Size(68, 64)
        Me.btnSlash.TabIndex = 0
        Me.btnSlash.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn0.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(90, 249)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(68, 64)
        Me.btn0.TabIndex = 0
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(90, 179)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(68, 64)
        Me.btn2.TabIndex = 0
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(16, 179)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(68, 64)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(90, 109)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(68, 64)
        Me.btn5.TabIndex = 0
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(16, 109)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(68, 64)
        Me.btn4.TabIndex = 0
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(90, 39)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(68, 64)
        Me.btn8.TabIndex = 0
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(16, 39)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(68, 64)
        Me.btn7.TabIndex = 0
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnZRead
        '
        Me.btnZRead.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnZRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZRead.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZRead.ForeColor = System.Drawing.Color.Black
        Me.btnZRead.Location = New System.Drawing.Point(765, 453)
        Me.btnZRead.Name = "btnZRead"
        Me.btnZRead.Size = New System.Drawing.Size(216, 51)
        Me.btnZRead.TabIndex = 0
        Me.btnZRead.Text = "(crl + Z) Z - READ"
        Me.btnZRead.UseVisualStyleBackColor = False
        '
        'BtnEditQty
        '
        Me.BtnEditQty.BackColor = System.Drawing.Color.Silver
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
        Me.txtnumber.Location = New System.Drawing.Point(765, 510)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(216, 20)
        Me.txtnumber.TabIndex = 29
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.btnZRead)
        Me.Controls.Add(Me.GbNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEditQty)
        Me.Controls.Add(Me.BtnRecord)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubtotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnItemList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GbNumber.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubtotal As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnItemList As Button
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
    Friend WithEvents BtnRecord As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GbNumber As GroupBox
    Friend WithEvents btn7 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents bnt9 As Button
    Friend WithEvents btnSlash As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btnZRead As Button
    Friend WithEvents BtnEditQty As Button
    Friend WithEvents txtnumber As TextBox
End Class
