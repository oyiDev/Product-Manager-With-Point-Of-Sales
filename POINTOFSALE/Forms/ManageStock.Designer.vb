<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageStock
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
        Me.pullout_Btn = New System.Windows.Forms.Button()
        Me.dg_stock = New System.Windows.Forms.DataGridView()
        CType(Me.dg_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pullout_Btn
        '
        Me.pullout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pullout_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pullout_Btn.Location = New System.Drawing.Point(780, 548)
        Me.pullout_Btn.Name = "pullout_Btn"
        Me.pullout_Btn.Size = New System.Drawing.Size(162, 39)
        Me.pullout_Btn.TabIndex = 1
        Me.pullout_Btn.Text = "Pull Out"
        Me.pullout_Btn.UseVisualStyleBackColor = True
        '
        'dg_stock
        '
        Me.dg_stock.AllowUserToAddRows = False
        Me.dg_stock.BackgroundColor = System.Drawing.Color.White
        Me.dg_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_stock.Location = New System.Drawing.Point(170, 30)
        Me.dg_stock.Name = "dg_stock"
        Me.dg_stock.ReadOnly = True
        Me.dg_stock.Size = New System.Drawing.Size(772, 500)
        Me.dg_stock.TabIndex = 3
        '
        'ManageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 599)
        Me.Controls.Add(Me.dg_stock)
        Me.Controls.Add(Me.pullout_Btn)
        Me.Name = "ManageStock"
        Me.Text = "ManageStock"
        CType(Me.dg_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pullout_Btn As Button
    Friend WithEvents dg_stock As DataGridView
End Class
