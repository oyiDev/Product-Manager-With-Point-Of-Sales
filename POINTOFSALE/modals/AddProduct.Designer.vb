<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtExpireDate = New System.Windows.Forms.TextBox()
        Me.Nqty = New System.Windows.Forms.NumericUpDown()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblDateFormat = New System.Windows.Forms.Label()
        Me.LblExd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barcode_lbl = New System.Windows.Forms.Label()
        Me.category_lbl = New System.Windows.Forms.Label()
        Me.gen_lbl = New System.Windows.Forms.Label()
        Me.brand_lbl = New System.Windows.Forms.Label()
        Me.formulation_lbl = New System.Windows.Forms.Label()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtBarcode = New System.Windows.Forms.TextBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.TxtGenericname = New System.Windows.Forms.TextBox()
        Me.TxtFormula = New System.Windows.Forms.TextBox()
        Me.CbCategory = New System.Windows.Forms.ComboBox()
        Me.TxtBrandname = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Nqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtExpireDate)
        Me.Panel1.Controls.Add(Me.Nqty)
        Me.Panel1.Controls.Add(Me.TxtPrice)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.LblDateFormat)
        Me.Panel1.Controls.Add(Me.LblExd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.barcode_lbl)
        Me.Panel1.Controls.Add(Me.category_lbl)
        Me.Panel1.Controls.Add(Me.gen_lbl)
        Me.Panel1.Controls.Add(Me.brand_lbl)
        Me.Panel1.Controls.Add(Me.formulation_lbl)
        Me.Panel1.Controls.Add(Me.description_lbl)
        Me.Panel1.Controls.Add(Me.price_lbl)
        Me.Panel1.Controls.Add(Me.LblQty)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.TxtBarcode)
        Me.Panel1.Controls.Add(Me.TxtDescription)
        Me.Panel1.Controls.Add(Me.TxtGenericname)
        Me.Panel1.Controls.Add(Me.TxtFormula)
        Me.Panel1.Controls.Add(Me.CbCategory)
        Me.Panel1.Controls.Add(Me.TxtBrandname)
        Me.Panel1.Location = New System.Drawing.Point(8, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 579)
        Me.Panel1.TabIndex = 0
        '
        'TxtExpireDate
        '
        Me.TxtExpireDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExpireDate.Location = New System.Drawing.Point(164, 434)
        Me.TxtExpireDate.Name = "TxtExpireDate"
        Me.TxtExpireDate.Size = New System.Drawing.Size(280, 25)
        Me.TxtExpireDate.TabIndex = 54
        '
        'Nqty
        '
        Me.Nqty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nqty.Location = New System.Drawing.Point(164, 396)
        Me.Nqty.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Nqty.Name = "Nqty"
        Me.Nqty.Size = New System.Drawing.Size(280, 25)
        Me.Nqty.TabIndex = 53
        '
        'TxtPrice
        '
        Me.TxtPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(164, 364)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(280, 25)
        Me.TxtPrice.TabIndex = 52
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(204, 503)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(111, 31)
        Me.BtnClose.TabIndex = 50
        Me.BtnClose.Text = "CANCEL"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(321, 503)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(123, 31)
        Me.BtnSave.TabIndex = 50
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'LblDateFormat
        '
        Me.LblDateFormat.AutoSize = True
        Me.LblDateFormat.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateFormat.Location = New System.Drawing.Point(161, 462)
        Me.LblDateFormat.Name = "LblDateFormat"
        Me.LblDateFormat.Size = New System.Drawing.Size(71, 15)
        Me.LblDateFormat.TabIndex = 48
        Me.LblDateFormat.Text = "(YYYY-MM-DD)"
        '
        'LblExd
        '
        Me.LblExd.AutoSize = True
        Me.LblExd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExd.Location = New System.Drawing.Point(42, 442)
        Me.LblExd.Name = "LblExd"
        Me.LblExd.Size = New System.Drawing.Size(96, 17)
        Me.LblExd.TabIndex = 48
        Me.LblExd.Text = "Expire date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "id:"
        '
        'barcode_lbl
        '
        Me.barcode_lbl.AutoSize = True
        Me.barcode_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode_lbl.Location = New System.Drawing.Point(42, 104)
        Me.barcode_lbl.Name = "barcode_lbl"
        Me.barcode_lbl.Size = New System.Drawing.Size(76, 17)
        Me.barcode_lbl.TabIndex = 32
        Me.barcode_lbl.Text = "Barcode:"
        '
        'category_lbl
        '
        Me.category_lbl.AutoSize = True
        Me.category_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_lbl.Location = New System.Drawing.Point(42, 143)
        Me.category_lbl.Name = "category_lbl"
        Me.category_lbl.Size = New System.Drawing.Size(80, 17)
        Me.category_lbl.TabIndex = 33
        Me.category_lbl.Text = "Category:"
        '
        'gen_lbl
        '
        Me.gen_lbl.AutoSize = True
        Me.gen_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen_lbl.Location = New System.Drawing.Point(42, 179)
        Me.gen_lbl.Name = "gen_lbl"
        Me.gen_lbl.Size = New System.Drawing.Size(116, 17)
        Me.gen_lbl.TabIndex = 34
        Me.gen_lbl.Text = "Generic name:"
        '
        'brand_lbl
        '
        Me.brand_lbl.AutoSize = True
        Me.brand_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brand_lbl.Location = New System.Drawing.Point(42, 215)
        Me.brand_lbl.Name = "brand_lbl"
        Me.brand_lbl.Size = New System.Drawing.Size(102, 17)
        Me.brand_lbl.TabIndex = 35
        Me.brand_lbl.Text = "Brand name:"
        '
        'formulation_lbl
        '
        Me.formulation_lbl.AutoSize = True
        Me.formulation_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formulation_lbl.Location = New System.Drawing.Point(42, 247)
        Me.formulation_lbl.Name = "formulation_lbl"
        Me.formulation_lbl.Size = New System.Drawing.Size(100, 17)
        Me.formulation_lbl.TabIndex = 36
        Me.formulation_lbl.Text = "Formulation:"
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_lbl.Location = New System.Drawing.Point(42, 284)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(97, 17)
        Me.description_lbl.TabIndex = 37
        Me.description_lbl.Text = "Description:"
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_lbl.Location = New System.Drawing.Point(42, 367)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(52, 17)
        Me.price_lbl.TabIndex = 38
        Me.price_lbl.Text = "Price:"
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQty.Location = New System.Drawing.Point(42, 404)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(38, 17)
        Me.LblQty.TabIndex = 39
        Me.LblQty.Text = "Qty:"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(164, 54)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(280, 25)
        Me.TxtId.TabIndex = 40
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBarcode
        '
        Me.TxtBarcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(164, 96)
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(280, 25)
        Me.TxtBarcode.TabIndex = 40
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(164, 281)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(280, 69)
        Me.TxtDescription.TabIndex = 45
        '
        'TxtGenericname
        '
        Me.TxtGenericname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGenericname.Location = New System.Drawing.Point(164, 171)
        Me.TxtGenericname.Name = "TxtGenericname"
        Me.TxtGenericname.Size = New System.Drawing.Size(280, 25)
        Me.TxtGenericname.TabIndex = 41
        '
        'TxtFormula
        '
        Me.TxtFormula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFormula.Location = New System.Drawing.Point(164, 244)
        Me.TxtFormula.Name = "TxtFormula"
        Me.TxtFormula.Size = New System.Drawing.Size(280, 25)
        Me.TxtFormula.TabIndex = 44
        '
        'CbCategory
        '
        Me.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCategory.FormattingEnabled = True
        Me.CbCategory.Items.AddRange(New Object() {"--SELECT--", "Tablets", "Injections", "Ointments", "Drops", "Inhaler", "Liquid Syrup", "Vitamins (Adults)", "Vitamins (Kids)"})
        Me.CbCategory.Location = New System.Drawing.Point(164, 135)
        Me.CbCategory.Name = "CbCategory"
        Me.CbCategory.Size = New System.Drawing.Size(280, 25)
        Me.CbCategory.TabIndex = 42
        '
        'TxtBrandname
        '
        Me.TxtBrandname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBrandname.Location = New System.Drawing.Point(164, 207)
        Me.TxtBrandname.Name = "TxtBrandname"
        Me.TxtBrandname.Size = New System.Drawing.Size(280, 25)
        Me.TxtBrandname.TabIndex = 43
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(522, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Nqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblExd As Label
    Friend WithEvents barcode_lbl As Label
    Friend WithEvents category_lbl As Label
    Friend WithEvents gen_lbl As Label
    Friend WithEvents brand_lbl As Label
    Friend WithEvents formulation_lbl As Label
    Friend WithEvents description_lbl As Label
    Friend WithEvents price_lbl As Label
    Friend WithEvents LblQty As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents TxtGenericname As TextBox
    Friend WithEvents TxtFormula As TextBox
    Friend WithEvents CbCategory As ComboBox
    Friend WithEvents TxtBrandname As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Nqty As NumericUpDown
    Friend WithEvents TxtBarcode As TextBox
    Friend WithEvents TxtExpireDate As TextBox
    Friend WithEvents LblDateFormat As Label
End Class
