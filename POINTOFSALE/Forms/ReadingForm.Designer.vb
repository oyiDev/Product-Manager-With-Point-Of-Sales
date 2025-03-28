<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadingForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNetAmount = New System.Windows.Forms.TextBox()
        Me.TxtOthersPayment = New System.Windows.Forms.TextBox()
        Me.TxtCashSales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTCashOut = New System.Windows.Forms.TextBox()
        Me.TxtTotalCash = New System.Windows.Forms.TextBox()
        Me.TxtVariance = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPost = New System.Windows.Forms.Button()
        Me.TxtTDiscount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(47, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NET AMOUNT                  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(47, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "OTHERS PAYMENT        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(47, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TOTAL DISCOUNT         :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(47, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CASH SALES                  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(250, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "---------------------------------------"
        '
        'TxtNetAmount
        '
        Me.TxtNetAmount.BackColor = System.Drawing.Color.Black
        Me.TxtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNetAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNetAmount.ForeColor = System.Drawing.Color.Lime
        Me.TxtNetAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtNetAmount.Location = New System.Drawing.Point(247, 50)
        Me.TxtNetAmount.Name = "TxtNetAmount"
        Me.TxtNetAmount.ReadOnly = True
        Me.TxtNetAmount.Size = New System.Drawing.Size(200, 18)
        Me.TxtNetAmount.TabIndex = 1
        Me.TxtNetAmount.Text = ".00"
        Me.TxtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOthersPayment
        '
        Me.TxtOthersPayment.BackColor = System.Drawing.Color.Black
        Me.TxtOthersPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOthersPayment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOthersPayment.ForeColor = System.Drawing.Color.Gold
        Me.TxtOthersPayment.Location = New System.Drawing.Point(247, 86)
        Me.TxtOthersPayment.Name = "TxtOthersPayment"
        Me.TxtOthersPayment.ReadOnly = True
        Me.TxtOthersPayment.Size = New System.Drawing.Size(200, 18)
        Me.TxtOthersPayment.TabIndex = 1
        Me.TxtOthersPayment.Text = ".00"
        Me.TxtOthersPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCashSales
        '
        Me.TxtCashSales.BackColor = System.Drawing.Color.Black
        Me.TxtCashSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCashSales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCashSales.ForeColor = System.Drawing.Color.Gold
        Me.TxtCashSales.Location = New System.Drawing.Point(247, 163)
        Me.TxtCashSales.Name = "TxtCashSales"
        Me.TxtCashSales.ReadOnly = True
        Me.TxtCashSales.Size = New System.Drawing.Size(200, 18)
        Me.TxtCashSales.TabIndex = 1
        Me.TxtCashSales.Text = ".00"
        Me.TxtCashSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(47, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "T. CASH OUT                  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(47, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TOTAL CASH                  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(47, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "VARIANCE                      :"
        '
        'TxtTCashOut
        '
        Me.TxtTCashOut.BackColor = System.Drawing.Color.Black
        Me.TxtTCashOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTCashOut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTCashOut.ForeColor = System.Drawing.Color.Gold
        Me.TxtTCashOut.Location = New System.Drawing.Point(253, 228)
        Me.TxtTCashOut.Name = "TxtTCashOut"
        Me.TxtTCashOut.ReadOnly = True
        Me.TxtTCashOut.Size = New System.Drawing.Size(200, 18)
        Me.TxtTCashOut.TabIndex = 1
        Me.TxtTCashOut.Text = ".00"
        Me.TxtTCashOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalCash
        '
        Me.TxtTotalCash.BackColor = System.Drawing.Color.Black
        Me.TxtTotalCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalCash.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCash.ForeColor = System.Drawing.Color.Lime
        Me.TxtTotalCash.Location = New System.Drawing.Point(253, 268)
        Me.TxtTotalCash.Name = "TxtTotalCash"
        Me.TxtTotalCash.ReadOnly = True
        Me.TxtTotalCash.Size = New System.Drawing.Size(200, 18)
        Me.TxtTotalCash.TabIndex = 1
        Me.TxtTotalCash.Text = ".00"
        Me.TxtTotalCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtVariance
        '
        Me.TxtVariance.BackColor = System.Drawing.Color.Black
        Me.TxtVariance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVariance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVariance.ForeColor = System.Drawing.Color.Silver
        Me.TxtVariance.Location = New System.Drawing.Point(253, 306)
        Me.TxtVariance.Name = "TxtVariance"
        Me.TxtVariance.ReadOnly = True
        Me.TxtVariance.Size = New System.Drawing.Size(200, 18)
        Me.TxtVariance.TabIndex = 1
        Me.TxtVariance.Text = ".00"
        Me.TxtVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(379, 516)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(90, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnPost
        '
        Me.BtnPost.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPost.Location = New System.Drawing.Point(199, 516)
        Me.BtnPost.Name = "BtnPost"
        Me.BtnPost.Size = New System.Drawing.Size(160, 37)
        Me.BtnPost.TabIndex = 4
        Me.BtnPost.Text = "PRINT REPORT"
        Me.BtnPost.UseVisualStyleBackColor = False
        '
        'TxtTDiscount
        '
        Me.TxtTDiscount.BackColor = System.Drawing.Color.Black
        Me.TxtTDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTDiscount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTDiscount.ForeColor = System.Drawing.Color.Gold
        Me.TxtTDiscount.Location = New System.Drawing.Point(247, 123)
        Me.TxtTDiscount.Name = "TxtTDiscount"
        Me.TxtTDiscount.Size = New System.Drawing.Size(200, 18)
        Me.TxtTDiscount.TabIndex = 8
        Me.TxtTDiscount.Text = ".00"
        Me.TxtTDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ReadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(501, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtTDiscount)
        Me.Controls.Add(Me.BtnPost)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtTCashOut)
        Me.Controls.Add(Me.TxtVariance)
        Me.Controls.Add(Me.TxtCashSales)
        Me.Controls.Add(Me.TxtOthersPayment)
        Me.Controls.Add(Me.TxtTotalCash)
        Me.Controls.Add(Me.TxtNetAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNetAmount As TextBox
    Friend WithEvents TxtOthersPayment As TextBox
    Friend WithEvents TxtCashSales As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTCashOut As TextBox
    Friend WithEvents TxtTotalCash As TextBox
    Friend WithEvents TxtVariance As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnPost As Button
    Friend WithEvents TxtTDiscount As TextBox
End Class
