<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryDashboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barcode_lbl = New System.Windows.Forms.Label()
        Me.category_lbl = New System.Windows.Forms.Label()
        Me.gen_lbl = New System.Windows.Forms.Label()
        Me.brand_lbl = New System.Windows.Forms.Label()
        Me.formulation_lbl = New System.Windows.Forms.Label()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.qty_lbl = New System.Windows.Forms.Label()
        Me.dg_product = New System.Windows.Forms.DataGridView()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.txt_generic = New System.Windows.Forms.TextBox()
        Me.cb_category = New System.Windows.Forms.ComboBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_formula = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.search_product = New System.Windows.Forms.TextBox()
        Me.searchBox = New System.Windows.Forms.PictureBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.addBox = New System.Windows.Forms.PictureBox()
        Me.updateBox = New System.Windows.Forms.PictureBox()
        Me.deleteBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.expiry_date = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Product"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'barcode_lbl
        '
        Me.barcode_lbl.AutoSize = True
        Me.barcode_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode_lbl.Location = New System.Drawing.Point(20, 126)
        Me.barcode_lbl.Name = "barcode_lbl"
        Me.barcode_lbl.Size = New System.Drawing.Size(54, 13)
        Me.barcode_lbl.TabIndex = 2
        Me.barcode_lbl.Text = "Barcode"
        '
        'category_lbl
        '
        Me.category_lbl.AutoSize = True
        Me.category_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_lbl.Location = New System.Drawing.Point(20, 162)
        Me.category_lbl.Name = "category_lbl"
        Me.category_lbl.Size = New System.Drawing.Size(57, 13)
        Me.category_lbl.TabIndex = 3
        Me.category_lbl.Text = "Category"
        '
        'gen_lbl
        '
        Me.gen_lbl.AutoSize = True
        Me.gen_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen_lbl.Location = New System.Drawing.Point(17, 201)
        Me.gen_lbl.Name = "gen_lbl"
        Me.gen_lbl.Size = New System.Drawing.Size(85, 13)
        Me.gen_lbl.TabIndex = 4
        Me.gen_lbl.Text = "Generic name"
        '
        'brand_lbl
        '
        Me.brand_lbl.AutoSize = True
        Me.brand_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brand_lbl.Location = New System.Drawing.Point(17, 237)
        Me.brand_lbl.Name = "brand_lbl"
        Me.brand_lbl.Size = New System.Drawing.Size(74, 13)
        Me.brand_lbl.TabIndex = 5
        Me.brand_lbl.Text = "Brand name"
        '
        'formulation_lbl
        '
        Me.formulation_lbl.AutoSize = True
        Me.formulation_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formulation_lbl.Location = New System.Drawing.Point(18, 274)
        Me.formulation_lbl.Name = "formulation_lbl"
        Me.formulation_lbl.Size = New System.Drawing.Size(72, 13)
        Me.formulation_lbl.TabIndex = 6
        Me.formulation_lbl.Text = "Formulation"
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_lbl.Location = New System.Drawing.Point(20, 311)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(71, 13)
        Me.description_lbl.TabIndex = 7
        Me.description_lbl.Text = "Description"
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_lbl.Location = New System.Drawing.Point(18, 348)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(36, 13)
        Me.price_lbl.TabIndex = 8
        Me.price_lbl.Text = "Price"
        '
        'qty_lbl
        '
        Me.qty_lbl.AutoSize = True
        Me.qty_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_lbl.Location = New System.Drawing.Point(18, 382)
        Me.qty_lbl.Name = "qty_lbl"
        Me.qty_lbl.Size = New System.Drawing.Size(26, 13)
        Me.qty_lbl.TabIndex = 9
        Me.qty_lbl.Text = "Qty"
        '
        'dg_product
        '
        Me.dg_product.AllowUserToAddRows = False
        Me.dg_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_product.BackgroundColor = System.Drawing.Color.White
        Me.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_product.Location = New System.Drawing.Point(228, 66)
        Me.dg_product.Name = "dg_product"
        Me.dg_product.ReadOnly = True
        Me.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_product.Size = New System.Drawing.Size(772, 500)
        Me.dg_product.TabIndex = 10
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(108, 123)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(114, 20)
        Me.txt_barcode.TabIndex = 11
        '
        'txt_generic
        '
        Me.txt_generic.Location = New System.Drawing.Point(108, 198)
        Me.txt_generic.Name = "txt_generic"
        Me.txt_generic.Size = New System.Drawing.Size(114, 20)
        Me.txt_generic.TabIndex = 13
        '
        'cb_category
        '
        Me.cb_category.FormattingEnabled = True
        Me.cb_category.Items.AddRange(New Object() {"Tablets", "Injections", "Ointments", "Drops", "Inhaler", "Liquid Syrup", "Vitamins (Adults)", "Vitamins (Kids)"})
        Me.cb_category.Location = New System.Drawing.Point(108, 162)
        Me.cb_category.Name = "cb_category"
        Me.cb_category.Size = New System.Drawing.Size(114, 21)
        Me.cb_category.TabIndex = 14
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(108, 234)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(114, 20)
        Me.txt_brand.TabIndex = 15
        '
        'txt_formula
        '
        Me.txt_formula.Location = New System.Drawing.Point(108, 271)
        Me.txt_formula.Name = "txt_formula"
        Me.txt_formula.Size = New System.Drawing.Size(114, 20)
        Me.txt_formula.TabIndex = 16
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(108, 308)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(114, 20)
        Me.txt_description.TabIndex = 17
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(108, 345)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(114, 20)
        Me.txt_price.TabIndex = 18
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(108, 382)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(114, 20)
        Me.txt_qty.TabIndex = 19
        '
        'search_product
        '
        Me.search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_product.Location = New System.Drawing.Point(687, 21)
        Me.search_product.Name = "search_product"
        Me.search_product.Size = New System.Drawing.Size(313, 29)
        Me.search_product.TabIndex = 20
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(651, 21)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(30, 29)
        Me.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchBox.TabIndex = 21
        Me.searchBox.TabStop = False
        '
        'add_btn
        '
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(228, 572)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(114, 36)
        Me.add_btn.TabIndex = 22
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Location = New System.Drawing.Point(396, 572)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(121, 36)
        Me.update_btn.TabIndex = 24
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(565, 572)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(116, 36)
        Me.delete_btn.TabIndex = 25
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'addBox
        '
        Me.addBox.Location = New System.Drawing.Point(231, 576)
        Me.addBox.Name = "addBox"
        Me.addBox.Size = New System.Drawing.Size(30, 29)
        Me.addBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addBox.TabIndex = 26
        Me.addBox.TabStop = False
        '
        'updateBox
        '
        Me.updateBox.Location = New System.Drawing.Point(399, 576)
        Me.updateBox.Name = "updateBox"
        Me.updateBox.Size = New System.Drawing.Size(30, 29)
        Me.updateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.updateBox.TabIndex = 28
        Me.updateBox.TabStop = False
        '
        'deleteBox
        '
        Me.deleteBox.Location = New System.Drawing.Point(568, 576)
        Me.deleteBox.Name = "deleteBox"
        Me.deleteBox.Size = New System.Drawing.Size(30, 29)
        Me.deleteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deleteBox.TabIndex = 29
        Me.deleteBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Expire date"
        '
        'expiry_date
        '
        Me.expiry_date.Location = New System.Drawing.Point(108, 420)
        Me.expiry_date.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.expiry_date.Name = "expiry_date"
        Me.expiry_date.Size = New System.Drawing.Size(114, 20)
        Me.expiry_date.TabIndex = 31
        '
        'InventoryDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 619)
        Me.Controls.Add(Me.expiry_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.deleteBox)
        Me.Controls.Add(Me.updateBox)
        Me.Controls.Add(Me.addBox)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.search_product)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_formula)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.cb_category)
        Me.Controls.Add(Me.txt_generic)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.dg_product)
        Me.Controls.Add(Me.qty_lbl)
        Me.Controls.Add(Me.price_lbl)
        Me.Controls.Add(Me.description_lbl)
        Me.Controls.Add(Me.formulation_lbl)
        Me.Controls.Add(Me.brand_lbl)
        Me.Controls.Add(Me.gen_lbl)
        Me.Controls.Add(Me.category_lbl)
        Me.Controls.Add(Me.barcode_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryDashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barcode_lbl As Label
    Friend WithEvents category_lbl As Label
    Friend WithEvents gen_lbl As Label
    Friend WithEvents brand_lbl As Label
    Friend WithEvents formulation_lbl As Label
    Friend WithEvents description_lbl As Label
    Friend WithEvents price_lbl As Label
    Friend WithEvents qty_lbl As Label
    Friend WithEvents dg_product As DataGridView
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents txt_generic As TextBox
    Friend WithEvents cb_category As ComboBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_formula As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents search_product As TextBox
    Friend WithEvents searchBox As PictureBox
    Friend WithEvents add_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents addBox As PictureBox
    Friend WithEvents updateBox As PictureBox
    Friend WithEvents deleteBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents expiry_date As DateTimePicker
End Class
