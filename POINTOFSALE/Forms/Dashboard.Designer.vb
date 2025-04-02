<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.dg_dashboard = New System.Windows.Forms.DataGridView()
        Me.totalUser_pnl = New System.Windows.Forms.Panel()
        Me.totalUser_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalProduct_pnl = New System.Windows.Forms.Panel()
        Me.LblTotalProduct = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminMainPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total_Supplierlbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dg_dashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totalUser_pnl.SuspendLayout()
        Me.totalProduct_pnl.SuspendLayout()
        Me.adminMainPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_dashboard
        '
        Me.dg_dashboard.BackgroundColor = System.Drawing.Color.White
        Me.dg_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dashboard.Location = New System.Drawing.Point(16, 216)
        Me.dg_dashboard.Name = "dg_dashboard"
        Me.dg_dashboard.Size = New System.Drawing.Size(839, 366)
        Me.dg_dashboard.TabIndex = 10
        '
        'totalUser_pnl
        '
        Me.totalUser_pnl.BackColor = System.Drawing.Color.Turquoise
        Me.totalUser_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalUser_pnl.Controls.Add(Me.totalUser_lbl)
        Me.totalUser_pnl.Controls.Add(Me.Label3)
        Me.totalUser_pnl.Location = New System.Drawing.Point(305, 58)
        Me.totalUser_pnl.Name = "totalUser_pnl"
        Me.totalUser_pnl.Size = New System.Drawing.Size(253, 109)
        Me.totalUser_pnl.TabIndex = 9
        '
        'totalUser_lbl
        '
        Me.totalUser_lbl.AutoSize = True
        Me.totalUser_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalUser_lbl.Location = New System.Drawing.Point(21, 54)
        Me.totalUser_lbl.Name = "totalUser_lbl"
        Me.totalUser_lbl.Size = New System.Drawing.Size(17, 18)
        Me.totalUser_lbl.TabIndex = 7
        Me.totalUser_lbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total User"
        '
        'totalProduct_pnl
        '
        Me.totalProduct_pnl.BackColor = System.Drawing.Color.DodgerBlue
        Me.totalProduct_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalProduct_pnl.Controls.Add(Me.LblTotalProduct)
        Me.totalProduct_pnl.Controls.Add(Me.Label1)
        Me.totalProduct_pnl.Location = New System.Drawing.Point(16, 58)
        Me.totalProduct_pnl.Name = "totalProduct_pnl"
        Me.totalProduct_pnl.Size = New System.Drawing.Size(246, 109)
        Me.totalProduct_pnl.TabIndex = 8
        '
        'LblTotalProduct
        '
        Me.LblTotalProduct.AutoSize = True
        Me.LblTotalProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalProduct.Location = New System.Drawing.Point(17, 54)
        Me.LblTotalProduct.Name = "LblTotalProduct"
        Me.LblTotalProduct.Size = New System.Drawing.Size(17, 18)
        Me.LblTotalProduct.TabIndex = 5
        Me.LblTotalProduct.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DASHBOARD"
        '
        'adminMainPanel
        '
        Me.adminMainPanel.BackColor = System.Drawing.Color.White
        Me.adminMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminMainPanel.Controls.Add(Me.Panel2)
        Me.adminMainPanel.Controls.Add(Me.dg_dashboard)
        Me.adminMainPanel.Controls.Add(Me.Label2)
        Me.adminMainPanel.Controls.Add(Me.Panel1)
        Me.adminMainPanel.Controls.Add(Me.totalUser_pnl)
        Me.adminMainPanel.Controls.Add(Me.totalProduct_pnl)
        Me.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminMainPanel.Name = "adminMainPanel"
        Me.adminMainPanel.Size = New System.Drawing.Size(896, 626)
        Me.adminMainPanel.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.total_Supplierlbl)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(602, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 109)
        Me.Panel2.TabIndex = 10
        '
        'total_Supplierlbl
        '
        Me.total_Supplierlbl.AutoSize = True
        Me.total_Supplierlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_Supplierlbl.Location = New System.Drawing.Point(21, 54)
        Me.total_Supplierlbl.Name = "total_Supplierlbl"
        Me.total_Supplierlbl.Size = New System.Drawing.Size(17, 18)
        Me.total_Supplierlbl.TabIndex = 7
        Me.total_Supplierlbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total Supplier"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(16, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 35)
        Me.Panel1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ZERO STOCK"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.adminMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dg_dashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totalUser_pnl.ResumeLayout(False)
        Me.totalUser_pnl.PerformLayout()
        Me.totalProduct_pnl.ResumeLayout(False)
        Me.totalProduct_pnl.PerformLayout()
        Me.adminMainPanel.ResumeLayout(False)
        Me.adminMainPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_dashboard As DataGridView
    Friend WithEvents totalUser_pnl As Panel
    Friend WithEvents totalUser_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalProduct_pnl As Panel
    Friend WithEvents LblTotalProduct As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adminMainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents total_Supplierlbl As Label
    Friend WithEvents Label5 As Label
End Class
