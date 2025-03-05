<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.totalProduct_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg_dashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totalUser_pnl.SuspendLayout()
        Me.totalProduct_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_dashboard
        '
        Me.dg_dashboard.BackgroundColor = System.Drawing.Color.White
        Me.dg_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dashboard.Location = New System.Drawing.Point(154, 193)
        Me.dg_dashboard.Name = "dg_dashboard"
        Me.dg_dashboard.Size = New System.Drawing.Size(721, 335)
        Me.dg_dashboard.TabIndex = 7
        '
        'totalUser_pnl
        '
        Me.totalUser_pnl.BackColor = System.Drawing.Color.LightBlue
        Me.totalUser_pnl.Controls.Add(Me.totalUser_lbl)
        Me.totalUser_pnl.Controls.Add(Me.Label3)
        Me.totalUser_pnl.Location = New System.Drawing.Point(542, 53)
        Me.totalUser_pnl.Name = "totalUser_pnl"
        Me.totalUser_pnl.Size = New System.Drawing.Size(222, 109)
        Me.totalUser_pnl.TabIndex = 6
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
        Me.totalProduct_pnl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totalProduct_pnl.Controls.Add(Me.totalProduct_lbl)
        Me.totalProduct_pnl.Controls.Add(Me.Label1)
        Me.totalProduct_pnl.Location = New System.Drawing.Point(281, 53)
        Me.totalProduct_pnl.Name = "totalProduct_pnl"
        Me.totalProduct_pnl.Size = New System.Drawing.Size(222, 109)
        Me.totalProduct_pnl.TabIndex = 5
        '
        'totalProduct_lbl
        '
        Me.totalProduct_lbl.AutoSize = True
        Me.totalProduct_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalProduct_lbl.Location = New System.Drawing.Point(17, 54)
        Me.totalProduct_lbl.Name = "totalProduct_lbl"
        Me.totalProduct_lbl.Size = New System.Drawing.Size(17, 18)
        Me.totalProduct_lbl.TabIndex = 5
        Me.totalProduct_lbl.Text = "0"
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
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 580)
        Me.Controls.Add(Me.dg_dashboard)
        Me.Controls.Add(Me.totalUser_pnl)
        Me.Controls.Add(Me.totalProduct_pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.dg_dashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totalUser_pnl.ResumeLayout(False)
        Me.totalUser_pnl.PerformLayout()
        Me.totalProduct_pnl.ResumeLayout(False)
        Me.totalProduct_pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_dashboard As DataGridView
    Friend WithEvents totalUser_pnl As Panel
    Friend WithEvents totalUser_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalProduct_pnl As Panel
    Friend WithEvents totalProduct_lbl As Label
    Friend WithEvents Label1 As Label
End Class
