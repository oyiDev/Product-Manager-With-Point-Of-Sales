<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageSupplier))
        Me.userId = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.userContact = New System.Windows.Forms.Label()
        Me.supplier_Id = New System.Windows.Forms.TextBox()
        Me.txt_supplierName = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.dg_Supplier = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.add_supplierBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userId
        '
        Me.userId.AutoSize = True
        Me.userId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userId.Location = New System.Drawing.Point(213, 115)
        Me.userId.Name = "userId"
        Me.userId.Size = New System.Drawing.Size(18, 16)
        Me.userId.TabIndex = 0
        Me.userId.Text = "Id"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(213, 158)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(44, 16)
        Me.userName.TabIndex = 1
        Me.userName.Text = "Name"
        '
        'userContact
        '
        Me.userContact.AutoSize = True
        Me.userContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userContact.Location = New System.Drawing.Point(548, 111)
        Me.userContact.Name = "userContact"
        Me.userContact.Size = New System.Drawing.Size(46, 16)
        Me.userContact.TabIndex = 2
        Me.userContact.Text = "Phone"
        '
        'supplier_Id
        '
        Me.supplier_Id.Location = New System.Drawing.Point(267, 114)
        Me.supplier_Id.Name = "supplier_Id"
        Me.supplier_Id.Size = New System.Drawing.Size(64, 20)
        Me.supplier_Id.TabIndex = 3
        '
        'txt_supplierName
        '
        Me.txt_supplierName.Location = New System.Drawing.Point(267, 157)
        Me.txt_supplierName.Name = "txt_supplierName"
        Me.txt_supplierName.Size = New System.Drawing.Size(121, 20)
        Me.txt_supplierName.TabIndex = 4
        '
        'txt_Phone
        '
        Me.txt_Phone.Location = New System.Drawing.Point(602, 111)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(121, 20)
        Me.txt_Phone.TabIndex = 5
        '
        'dg_Supplier
        '
        Me.dg_Supplier.AllowUserToAddRows = False
        Me.dg_Supplier.BackgroundColor = System.Drawing.Color.White
        Me.dg_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Supplier.Location = New System.Drawing.Point(112, 210)
        Me.dg_Supplier.Name = "dg_Supplier"
        Me.dg_Supplier.ReadOnly = True
        Me.dg_Supplier.Size = New System.Drawing.Size(842, 311)
        Me.dg_Supplier.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supplier Management"
        '
        'add_supplierBtn
        '
        Me.add_supplierBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add_supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_supplierBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_supplierBtn.Location = New System.Drawing.Point(773, 536)
        Me.add_supplierBtn.Name = "add_supplierBtn"
        Me.add_supplierBtn.Size = New System.Drawing.Size(181, 32)
        Me.add_supplierBtn.TabIndex = 9
        Me.add_supplierBtn.Text = "Add Supplier"
        Me.add_supplierBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(773, 536)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(612, 157)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(246, 20)
        Me.txt_Address.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Address"
        '
        'ManageSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1028, 580)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.add_supplierBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dg_Supplier)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_supplierName)
        Me.Controls.Add(Me.supplier_Id)
        Me.Controls.Add(Me.userContact)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.userId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageSupplier"
        Me.Text = "SupplierDashboard"
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userId As Label
    Friend WithEvents userName As Label
    Friend WithEvents userContact As Label
    Friend WithEvents supplier_Id As TextBox
    Friend WithEvents txt_supplierName As TextBox
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents dg_Supplier As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents add_supplierBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents Label2 As Label
End Class
