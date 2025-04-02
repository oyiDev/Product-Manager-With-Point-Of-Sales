<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemListForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgItemList = New System.Windows.Forms.DataGridView()
        Me.barcodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH :"
        '
        'TxtSearch
        '
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(126, 6)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(847, 30)
        Me.TxtSearch.TabIndex = 1
        '
        'BtnEnter
        '
        Me.BtnEnter.BackColor = System.Drawing.Color.Lime
        Me.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnter.ForeColor = System.Drawing.Color.Black
        Me.BtnEnter.Location = New System.Drawing.Point(883, 628)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(90, 35)
        Me.BtnEnter.TabIndex = 3
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(742, 628)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(130, 35)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "ESE - CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(169, 628)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GENERIC NAME,"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(269, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BRAND NAME"
        '
        'DgItemList
        '
        Me.DgItemList.AllowUserToAddRows = False
        Me.DgItemList.AllowUserToDeleteRows = False
        Me.DgItemList.AllowUserToResizeColumns = False
        Me.DgItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DgItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgItemList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barcodeCol, Me.genericnameCol, Me.brandnameCol, Me.priceCol, Me.qtyCol})
        Me.DgItemList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgItemList.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgItemList.Location = New System.Drawing.Point(11, 43)
        Me.DgItemList.Name = "DgItemList"
        Me.DgItemList.ReadOnly = True
        Me.DgItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgItemList.Size = New System.Drawing.Size(962, 579)
        Me.DgItemList.TabIndex = 4
        '
        'barcodeCol
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        Me.barcodeCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.barcodeCol.HeaderText = "BARCODE"
        Me.barcodeCol.Name = "barcodeCol"
        Me.barcodeCol.ReadOnly = True
        '
        'genericnameCol
        '
        Me.genericnameCol.HeaderText = "GENERICNAME"
        Me.genericnameCol.Name = "genericnameCol"
        Me.genericnameCol.ReadOnly = True
        '
        'brandnameCol
        '
        Me.brandnameCol.HeaderText = "BRANDNAME"
        Me.brandnameCol.Name = "brandnameCol"
        Me.brandnameCol.ReadOnly = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(98, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "BARCODE,"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 628)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SEARCH BY :"
        '
        'ItemListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 682)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgItemList)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item List"
        CType(Me.DgItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgItemList As DataGridView
    Friend WithEvents barcodeCol As DataGridViewTextBoxColumn
    Friend WithEvents genericnameCol As DataGridViewTextBoxColumn
    Friend WithEvents brandnameCol As DataGridViewTextBoxColumn
    Friend WithEvents priceCol As DataGridViewTextBoxColumn
    Friend WithEvents qtyCol As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
