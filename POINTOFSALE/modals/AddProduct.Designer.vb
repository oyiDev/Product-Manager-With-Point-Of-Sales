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
        Me.BrnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.expiry_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barcode_lbl = New System.Windows.Forms.Label()
        Me.category_lbl = New System.Windows.Forms.Label()
        Me.gen_lbl = New System.Windows.Forms.Label()
        Me.brand_lbl = New System.Windows.Forms.Label()
        Me.formulation_lbl = New System.Windows.Forms.Label()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.qty_lbl = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_generic = New System.Windows.Forms.TextBox()
        Me.txt_formula = New System.Windows.Forms.TextBox()
        Me.CbCategory = New System.Windows.Forms.ComboBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BrnCancel)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.expiry_date)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.barcode_lbl)
        Me.Panel1.Controls.Add(Me.category_lbl)
        Me.Panel1.Controls.Add(Me.gen_lbl)
        Me.Panel1.Controls.Add(Me.brand_lbl)
        Me.Panel1.Controls.Add(Me.formulation_lbl)
        Me.Panel1.Controls.Add(Me.description_lbl)
        Me.Panel1.Controls.Add(Me.price_lbl)
        Me.Panel1.Controls.Add(Me.txt_qty)
        Me.Panel1.Controls.Add(Me.qty_lbl)
        Me.Panel1.Controls.Add(Me.txt_price)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.txt_barcode)
        Me.Panel1.Controls.Add(Me.txt_description)
        Me.Panel1.Controls.Add(Me.txt_generic)
        Me.Panel1.Controls.Add(Me.txt_formula)
        Me.Panel1.Controls.Add(Me.CbCategory)
        Me.Panel1.Controls.Add(Me.txt_brand)
        Me.Panel1.Location = New System.Drawing.Point(15, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 459)
        Me.Panel1.TabIndex = 0
        '
        'BrnCancel
        '
        Me.BrnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrnCancel.Location = New System.Drawing.Point(181, 403)
        Me.BrnCancel.Name = "BrnCancel"
        Me.BrnCancel.Size = New System.Drawing.Size(111, 31)
        Me.BrnCancel.TabIndex = 50
        Me.BrnCancel.Text = "Cancel"
        Me.BrnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(298, 403)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 31)
        Me.BtnSave.TabIndex = 50
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'expiry_date
        '
        Me.expiry_date.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expiry_date.Location = New System.Drawing.Point(141, 355)
        Me.expiry_date.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.expiry_date.Name = "expiry_date"
        Me.expiry_date.Size = New System.Drawing.Size(268, 25)
        Me.expiry_date.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Expire date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "id:"
        '
        'barcode_lbl
        '
        Me.barcode_lbl.AutoSize = True
        Me.barcode_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode_lbl.Location = New System.Drawing.Point(26, 61)
        Me.barcode_lbl.Name = "barcode_lbl"
        Me.barcode_lbl.Size = New System.Drawing.Size(76, 17)
        Me.barcode_lbl.TabIndex = 32
        Me.barcode_lbl.Text = "Barcode:"
        '
        'category_lbl
        '
        Me.category_lbl.AutoSize = True
        Me.category_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_lbl.Location = New System.Drawing.Point(26, 97)
        Me.category_lbl.Name = "category_lbl"
        Me.category_lbl.Size = New System.Drawing.Size(80, 17)
        Me.category_lbl.TabIndex = 33
        Me.category_lbl.Text = "Category:"
        '
        'gen_lbl
        '
        Me.gen_lbl.AutoSize = True
        Me.gen_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen_lbl.Location = New System.Drawing.Point(23, 136)
        Me.gen_lbl.Name = "gen_lbl"
        Me.gen_lbl.Size = New System.Drawing.Size(116, 17)
        Me.gen_lbl.TabIndex = 34
        Me.gen_lbl.Text = "Generic name:"
        '
        'brand_lbl
        '
        Me.brand_lbl.AutoSize = True
        Me.brand_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brand_lbl.Location = New System.Drawing.Point(23, 172)
        Me.brand_lbl.Name = "brand_lbl"
        Me.brand_lbl.Size = New System.Drawing.Size(102, 17)
        Me.brand_lbl.TabIndex = 35
        Me.brand_lbl.Text = "Brand name:"
        '
        'formulation_lbl
        '
        Me.formulation_lbl.AutoSize = True
        Me.formulation_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formulation_lbl.Location = New System.Drawing.Point(24, 209)
        Me.formulation_lbl.Name = "formulation_lbl"
        Me.formulation_lbl.Size = New System.Drawing.Size(100, 17)
        Me.formulation_lbl.TabIndex = 36
        Me.formulation_lbl.Text = "Formulation:"
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_lbl.Location = New System.Drawing.Point(26, 246)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(97, 17)
        Me.description_lbl.TabIndex = 37
        Me.description_lbl.Text = "Description:"
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_lbl.Location = New System.Drawing.Point(24, 283)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(52, 17)
        Me.price_lbl.TabIndex = 38
        Me.price_lbl.Text = "Price:"
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(141, 317)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(268, 25)
        Me.txt_qty.TabIndex = 47
        '
        'qty_lbl
        '
        Me.qty_lbl.AutoSize = True
        Me.qty_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_lbl.Location = New System.Drawing.Point(24, 317)
        Me.qty_lbl.Name = "qty_lbl"
        Me.qty_lbl.Size = New System.Drawing.Size(38, 17)
        Me.qty_lbl.TabIndex = 39
        Me.qty_lbl.Text = "Qty:"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(141, 280)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(268, 25)
        Me.txt_price.TabIndex = 46
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(141, 16)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(268, 25)
        Me.TxtId.TabIndex = 40
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_barcode
        '
        Me.txt_barcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(141, 58)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(268, 25)
        Me.txt_barcode.TabIndex = 40
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(141, 243)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(268, 25)
        Me.txt_description.TabIndex = 45
        '
        'txt_generic
        '
        Me.txt_generic.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_generic.Location = New System.Drawing.Point(141, 133)
        Me.txt_generic.Name = "txt_generic"
        Me.txt_generic.Size = New System.Drawing.Size(268, 25)
        Me.txt_generic.TabIndex = 41
        '
        'txt_formula
        '
        Me.txt_formula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula.Location = New System.Drawing.Point(141, 206)
        Me.txt_formula.Name = "txt_formula"
        Me.txt_formula.Size = New System.Drawing.Size(268, 25)
        Me.txt_formula.TabIndex = 44
        '
        'CbCategory
        '
        Me.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCategory.FormattingEnabled = True
        Me.CbCategory.Items.AddRange(New Object() {"--SELECT--", "Tablets", "Injections", "Ointments", "Drops", "Inhaler", "Liquid Syrup", "Vitamins (Adults)", "Vitamins (Kids)"})
        Me.CbCategory.Location = New System.Drawing.Point(141, 97)
        Me.CbCategory.Name = "CbCategory"
        Me.CbCategory.Size = New System.Drawing.Size(268, 25)
        Me.CbCategory.TabIndex = 42
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(141, 169)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(268, 25)
        Me.txt_brand.TabIndex = 43
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents expiry_date As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents barcode_lbl As Label
    Friend WithEvents category_lbl As Label
    Friend WithEvents gen_lbl As Label
    Friend WithEvents brand_lbl As Label
    Friend WithEvents formulation_lbl As Label
    Friend WithEvents description_lbl As Label
    Friend WithEvents price_lbl As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents qty_lbl As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_generic As TextBox
    Friend WithEvents txt_formula As TextBox
    Friend WithEvents CbCategory As ComboBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents BrnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
End Class
