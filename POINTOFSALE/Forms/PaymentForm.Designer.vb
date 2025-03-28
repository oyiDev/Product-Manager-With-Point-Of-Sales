<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentForm
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
        Me.btnPayEnter = New System.Windows.Forms.Button()
        Me.BtnDiscount = New System.Windows.Forms.Button()
        Me.txtGtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtVat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPayEnter
        '
        Me.btnPayEnter.BackColor = System.Drawing.Color.Lime
        Me.btnPayEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayEnter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayEnter.Location = New System.Drawing.Point(417, 537)
        Me.btnPayEnter.Name = "btnPayEnter"
        Me.btnPayEnter.Size = New System.Drawing.Size(81, 41)
        Me.btnPayEnter.TabIndex = 20
        Me.btnPayEnter.Text = "ENTER"
        Me.btnPayEnter.UseVisualStyleBackColor = False
        '
        'BtnDiscount
        '
        Me.BtnDiscount.BackColor = System.Drawing.Color.Silver
        Me.BtnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDiscount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiscount.Location = New System.Drawing.Point(21, 537)
        Me.BtnDiscount.Name = "BtnDiscount"
        Me.BtnDiscount.Size = New System.Drawing.Size(144, 41)
        Me.BtnDiscount.TabIndex = 17
        Me.BtnDiscount.Text = "(crl + s) DISCOUNT"
        Me.BtnDiscount.UseVisualStyleBackColor = False
        '
        'txtGtotal
        '
        Me.txtGtotal.BackColor = System.Drawing.Color.Black
        Me.txtGtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGtotal.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGtotal.ForeColor = System.Drawing.Color.Lime
        Me.txtGtotal.Location = New System.Drawing.Point(172, 7)
        Me.txtGtotal.Name = "txtGtotal"
        Me.txtGtotal.ReadOnly = True
        Me.txtGtotal.Size = New System.Drawing.Size(297, 47)
        Me.txtGtotal.TabIndex = 1
        Me.txtGtotal.Text = "0.00"
        Me.txtGtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(-1, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 46)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TOTAL"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtGtotal)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(21, 446)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(477, 70)
        Me.Panel5.TabIndex = 15
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.Black
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Silver
        Me.txtDiscount.Location = New System.Drawing.Point(171, 7)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(297, 47)
        Me.txtDiscount.TabIndex = 1
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(-3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 46)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DISCOUNT"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.Black
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChange.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Yellow
        Me.txtChange.Location = New System.Drawing.Point(171, 7)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(297, 47)
        Me.txtChange.TabIndex = 1
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtDiscount)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(21, 370)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(477, 70)
        Me.Panel4.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(-3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 46)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CHANGE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtChange)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(21, 177)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(477, 70)
        Me.Panel3.TabIndex = 13
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Black
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCash.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.txtCash.Location = New System.Drawing.Point(171, 7)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(297, 47)
        Me.txtCash.TabIndex = 1
        Me.txtCash.Text = "0.00"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(-3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 46)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CASH"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtCash)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(21, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(477, 70)
        Me.Panel2.TabIndex = 12
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Black
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(172, 7)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(297, 47)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(-3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AMOUNT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 70)
        Me.Panel1.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TxtVat)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(21, 294)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(477, 70)
        Me.Panel6.TabIndex = 14
        '
        'TxtVat
        '
        Me.TxtVat.BackColor = System.Drawing.Color.Black
        Me.TxtVat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVat.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVat.ForeColor = System.Drawing.Color.Silver
        Me.TxtVat.Location = New System.Drawing.Point(171, 7)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.ReadOnly = True
        Me.TxtVat.Size = New System.Drawing.Size(297, 47)
        Me.TxtVat.TabIndex = 1
        Me.TxtVat.Text = "0.00"
        Me.TxtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(-3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 46)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "VAT"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(318, 537)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(81, 41)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.Text = "(ESC) CANCEL"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnPayEnter)
        Me.Controls.Add(Me.BtnDiscount)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPayEnter As Button
    Friend WithEvents BtnDiscount As Button
    Friend WithEvents txtGtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtVat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnClose As Button
End Class
