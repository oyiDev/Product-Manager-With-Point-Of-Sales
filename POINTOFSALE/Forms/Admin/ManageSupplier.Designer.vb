<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageSupplier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.addSupplierBtn = New System.Windows.Forms.Button()
        Me.dg_Supplier = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Manage Supplier"
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.addSupplierBtn)
        Me.adminMainPanel.Controls.Add(Me.dg_Supplier)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Controls.Add(Me.PictureBox1)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(875, 598)
        Me.adminMainPanel.TabIndex = 13
        '
        'addSupplierBtn
        '
        Me.addSupplierBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addSupplierBtn.BackColor = System.Drawing.Color.Transparent
        Me.addSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addSupplierBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSupplierBtn.Location = New System.Drawing.Point(734, 39)
        Me.addSupplierBtn.Name = "addSupplierBtn"
        Me.addSupplierBtn.Size = New System.Drawing.Size(118, 32)
        Me.addSupplierBtn.TabIndex = 9
        Me.addSupplierBtn.Text = "ADD SUPPLIER"
        Me.addSupplierBtn.UseVisualStyleBackColor = False
        '
        'dg_Supplier
        '
        Me.dg_Supplier.AllowUserToAddRows = False
        Me.dg_Supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Supplier.BackgroundColor = System.Drawing.Color.White
        Me.dg_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Supplier.Location = New System.Drawing.Point(19, 85)
        Me.dg_Supplier.Name = "dg_Supplier"
        Me.dg_Supplier.ReadOnly = True
        Me.dg_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Supplier.Size = New System.Drawing.Size(833, 486)
        Me.dg_Supplier.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ManageSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(875, 598)
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageSupplier"
        Me.Text = "SupplierDashboard"
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents dg_Supplier As DataGridView
    Friend WithEvents addSupplierBtn As Button
End Class
