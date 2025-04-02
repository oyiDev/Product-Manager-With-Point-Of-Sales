<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionForm
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
        Me.dgRecordTrans = New System.Windows.Forms.DataGridView()
        Me.idCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transactiondateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalamountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentmethodCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgRecordTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgRecordTrans
        '
        Me.dgRecordTrans.AllowUserToAddRows = False
        Me.dgRecordTrans.AllowUserToDeleteRows = False
        Me.dgRecordTrans.AllowUserToResizeColumns = False
        Me.dgRecordTrans.AllowUserToResizeRows = False
        Me.dgRecordTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRecordTrans.BackgroundColor = System.Drawing.Color.White
        Me.dgRecordTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecordTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCol, Me.nameCol, Me.usertypeCol, Me.transactiondateCol, Me.totalamountCol, Me.paymentmethodCol, Me.discountCol})
        Me.dgRecordTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRecordTrans.Location = New System.Drawing.Point(0, 0)
        Me.dgRecordTrans.Name = "dgRecordTrans"
        Me.dgRecordTrans.ReadOnly = True
        Me.dgRecordTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgRecordTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecordTrans.Size = New System.Drawing.Size(962, 548)
        Me.dgRecordTrans.TabIndex = 0
        '
        'idCol
        '
        Me.idCol.HeaderText = "id"
        Me.idCol.Name = "idCol"
        Me.idCol.ReadOnly = True
        '
        'nameCol
        '
        Me.nameCol.HeaderText = "NAME"
        Me.nameCol.Name = "nameCol"
        Me.nameCol.ReadOnly = True
        '
        'usertypeCol
        '
        Me.usertypeCol.HeaderText = "USERTYPE"
        Me.usertypeCol.Name = "usertypeCol"
        Me.usertypeCol.ReadOnly = True
        '
        'transactiondateCol
        '
        Me.transactiondateCol.HeaderText = "DATE"
        Me.transactiondateCol.Name = "transactiondateCol"
        Me.transactiondateCol.ReadOnly = True
        '
        'totalamountCol
        '
        Me.totalamountCol.HeaderText = "TOTALAMOUNT"
        Me.totalamountCol.Name = "totalamountCol"
        Me.totalamountCol.ReadOnly = True
        '
        'paymentmethodCol
        '
        Me.paymentmethodCol.HeaderText = "PAYMENTMETHOD"
        Me.paymentmethodCol.Name = "paymentmethodCol"
        Me.paymentmethodCol.ReadOnly = True
        '
        'discountCol
        '
        Me.discountCol.HeaderText = "DISCOUNT"
        Me.discountCol.Name = "discountCol"
        Me.discountCol.ReadOnly = True
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 548)
        Me.Controls.Add(Me.dgRecordTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransactionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Record For Today"
        CType(Me.dgRecordTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgRecordTrans As DataGridView
    Friend WithEvents idCol As DataGridViewTextBoxColumn
    Friend WithEvents nameCol As DataGridViewTextBoxColumn
    Friend WithEvents usertypeCol As DataGridViewTextBoxColumn
    Friend WithEvents transactiondateCol As DataGridViewTextBoxColumn
    Friend WithEvents totalamountCol As DataGridViewTextBoxColumn
    Friend WithEvents paymentmethodCol As DataGridViewTextBoxColumn
    Friend WithEvents discountCol As DataGridViewTextBoxColumn
End Class
