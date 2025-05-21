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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.addSupplierBtn = New System.Windows.Forms.Button()
        Me.dg_Supplier = New System.Windows.Forms.DataGridView()
        Me.adminMainPanel.SuspendLayout()
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Manage Supplier"
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.dg_Supplier)
        Me.adminMainPanel.Controls.Add(Me.addSupplierBtn)
        Me.adminMainPanel.Controls.Add(Me.Label1)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(875, 620)
        Me.adminMainPanel.TabIndex = 13
        '
        'addSupplierBtn
        '
        Me.addSupplierBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addSupplierBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addSupplierBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSupplierBtn.Location = New System.Drawing.Point(722, 30)
        Me.addSupplierBtn.Name = "addSupplierBtn"
        Me.addSupplierBtn.Size = New System.Drawing.Size(125, 44)
        Me.addSupplierBtn.TabIndex = 9
        Me.addSupplierBtn.Text = "ADD SUPPLIER"
        Me.addSupplierBtn.UseVisualStyleBackColor = False
        '
        'dg_Supplier
        '
        Me.dg_Supplier.AllowUserToAddRows = False
        Me.dg_Supplier.AllowUserToDeleteRows = False
        Me.dg_Supplier.AllowUserToResizeColumns = False
        Me.dg_Supplier.AllowUserToResizeRows = False
        Me.dg_Supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Supplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_Supplier.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_Supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Supplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dg_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Supplier.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Supplier.DefaultCellStyle = DataGridViewCellStyle11
        Me.dg_Supplier.Location = New System.Drawing.Point(26, 80)
        Me.dg_Supplier.Name = "dg_Supplier"
        Me.dg_Supplier.ReadOnly = True
        Me.dg_Supplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Supplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dg_Supplier.RowHeadersVisible = False
        Me.dg_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Supplier.ShowEditingIcon = False
        Me.dg_Supplier.ShowRowErrors = False
        Me.dg_Supplier.Size = New System.Drawing.Size(821, 504)
        Me.dg_Supplier.TabIndex = 25
        '
        'ManageSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(875, 620)
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageSupplier"
        Me.Text = "SupplierDashboard"
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        CType(Me.dg_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents addSupplierBtn As Button
    Friend WithEvents dg_Supplier As DataGridView
End Class
