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
        Me.BtnPrintDenomination = New System.Windows.Forms.Button()
        Me.BtnPost = New System.Windows.Forms.Button()
        Me.c1 = New System.Windows.Forms.TextBox()
        Me.c5 = New System.Windows.Forms.TextBox()
        Me.c10 = New System.Windows.Forms.TextBox()
        Me.c20 = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.p50 = New System.Windows.Forms.TextBox()
        Me.p100 = New System.Windows.Forms.TextBox()
        Me.p200 = New System.Windows.Forms.TextBox()
        Me.p500 = New System.Windows.Forms.TextBox()
        Me.p1000 = New System.Windows.Forms.TextBox()
        Me.LblC1 = New System.Windows.Forms.Label()
        Me.LblC5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblC20 = New System.Windows.Forms.Label()
        Me.LblC10 = New System.Windows.Forms.Label()
        Me.LblP50 = New System.Windows.Forms.Label()
        Me.LblP100 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblP200 = New System.Windows.Forms.Label()
        Me.LblP500 = New System.Windows.Forms.Label()
        Me.LblP1000 = New System.Windows.Forms.Label()
        Me.lblTCashCount = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtTDiscount = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(591, 36)
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
        Me.Label2.Location = New System.Drawing.Point(591, 72)
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
        Me.Label3.Location = New System.Drawing.Point(591, 112)
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
        Me.Label4.Location = New System.Drawing.Point(591, 149)
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
        Me.Label5.Location = New System.Drawing.Point(794, 176)
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
        Me.TxtNetAmount.Location = New System.Drawing.Point(791, 36)
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
        Me.TxtOthersPayment.Location = New System.Drawing.Point(791, 72)
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
        Me.TxtCashSales.Location = New System.Drawing.Point(791, 149)
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
        Me.Label6.Location = New System.Drawing.Point(591, 213)
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
        Me.Label7.Location = New System.Drawing.Point(591, 253)
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
        Me.Label8.Location = New System.Drawing.Point(591, 292)
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
        Me.TxtTCashOut.Location = New System.Drawing.Point(791, 213)
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
        Me.TxtTotalCash.Location = New System.Drawing.Point(791, 253)
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
        Me.TxtVariance.Location = New System.Drawing.Point(791, 291)
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
        Me.BtnClose.Location = New System.Drawing.Point(901, 524)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(90, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnPrintDenomination
        '
        Me.BtnPrintDenomination.BackColor = System.Drawing.Color.Lime
        Me.BtnPrintDenomination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintDenomination.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintDenomination.Location = New System.Drawing.Point(576, 524)
        Me.BtnPrintDenomination.Name = "BtnPrintDenomination"
        Me.BtnPrintDenomination.Size = New System.Drawing.Size(202, 37)
        Me.BtnPrintDenomination.TabIndex = 3
        Me.BtnPrintDenomination.Text = "PRINT DENOMINATION"
        Me.BtnPrintDenomination.UseVisualStyleBackColor = False
        '
        'BtnPost
        '
        Me.BtnPost.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPost.Location = New System.Drawing.Point(791, 524)
        Me.BtnPost.Name = "BtnPost"
        Me.BtnPost.Size = New System.Drawing.Size(90, 37)
        Me.BtnPost.TabIndex = 4
        Me.BtnPost.Text = "POST"
        Me.BtnPost.UseVisualStyleBackColor = False
        '
        'c1
        '
        Me.c1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(100, 78)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(70, 25)
        Me.c1.TabIndex = 6
        Me.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c5
        '
        Me.c5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c5.Location = New System.Drawing.Point(100, 163)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(70, 25)
        Me.c5.TabIndex = 6
        Me.c5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c10
        '
        Me.c10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c10.Location = New System.Drawing.Point(100, 245)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(70, 25)
        Me.c10.TabIndex = 6
        Me.c10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c20
        '
        Me.c20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c20.Location = New System.Drawing.Point(100, 333)
        Me.c20.Name = "c20"
        Me.c20.Size = New System.Drawing.Size(70, 25)
        Me.c20.TabIndex = 6
        Me.c20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._1000
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(265, 364)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(160, 79)
        Me.PictureBox9.TabIndex = 5
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._500
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Location = New System.Drawing.Point(265, 279)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(160, 79)
        Me.PictureBox8.TabIndex = 5
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._200
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Location = New System.Drawing.Point(265, 194)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(160, 79)
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._100
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(265, 109)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(160, 79)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._50
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(265, 24)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(160, 79)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._20
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(12, 279)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._10
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(12, 194)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._5
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(12, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POINTOFSALE.My.Resources.Resources._1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'p50
        '
        Me.p50.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p50.Location = New System.Drawing.Point(431, 78)
        Me.p50.Name = "p50"
        Me.p50.Size = New System.Drawing.Size(70, 25)
        Me.p50.TabIndex = 6
        Me.p50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p100
        '
        Me.p100.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p100.Location = New System.Drawing.Point(431, 163)
        Me.p100.Name = "p100"
        Me.p100.Size = New System.Drawing.Size(70, 25)
        Me.p100.TabIndex = 6
        Me.p100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p200
        '
        Me.p200.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p200.Location = New System.Drawing.Point(431, 245)
        Me.p200.Name = "p200"
        Me.p200.Size = New System.Drawing.Size(70, 25)
        Me.p200.TabIndex = 6
        Me.p200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p500
        '
        Me.p500.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p500.Location = New System.Drawing.Point(431, 333)
        Me.p500.Name = "p500"
        Me.p500.Size = New System.Drawing.Size(70, 25)
        Me.p500.TabIndex = 6
        Me.p500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p1000
        '
        Me.p1000.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1000.Location = New System.Drawing.Point(431, 418)
        Me.p1000.Name = "p1000"
        Me.p1000.Size = New System.Drawing.Size(70, 25)
        Me.p1000.TabIndex = 6
        Me.p1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblC1
        '
        Me.LblC1.AutoSize = True
        Me.LblC1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC1.ForeColor = System.Drawing.Color.White
        Me.LblC1.Location = New System.Drawing.Point(176, 86)
        Me.LblC1.Name = "LblC1"
        Me.LblC1.Size = New System.Drawing.Size(31, 17)
        Me.LblC1.TabIndex = 7
        Me.LblC1.Text = "0.0"
        '
        'LblC5
        '
        Me.LblC5.AutoSize = True
        Me.LblC5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC5.ForeColor = System.Drawing.Color.White
        Me.LblC5.Location = New System.Drawing.Point(176, 171)
        Me.LblC5.Name = "LblC5"
        Me.LblC5.Size = New System.Drawing.Size(31, 17)
        Me.LblC5.TabIndex = 7
        Me.LblC5.Text = "0.0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(176, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(176, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "0.0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(176, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "0.0"
        '
        'LblC20
        '
        Me.LblC20.AutoSize = True
        Me.LblC20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC20.ForeColor = System.Drawing.Color.White
        Me.LblC20.Location = New System.Drawing.Point(176, 341)
        Me.LblC20.Name = "LblC20"
        Me.LblC20.Size = New System.Drawing.Size(31, 17)
        Me.LblC20.TabIndex = 7
        Me.LblC20.Text = "0.0"
        '
        'LblC10
        '
        Me.LblC10.AutoSize = True
        Me.LblC10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC10.ForeColor = System.Drawing.Color.White
        Me.LblC10.Location = New System.Drawing.Point(176, 256)
        Me.LblC10.Name = "LblC10"
        Me.LblC10.Size = New System.Drawing.Size(31, 17)
        Me.LblC10.TabIndex = 7
        Me.LblC10.Text = "0.0"
        '
        'LblP50
        '
        Me.LblP50.AutoSize = True
        Me.LblP50.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP50.ForeColor = System.Drawing.Color.White
        Me.LblP50.Location = New System.Drawing.Point(507, 86)
        Me.LblP50.Name = "LblP50"
        Me.LblP50.Size = New System.Drawing.Size(31, 17)
        Me.LblP50.TabIndex = 7
        Me.LblP50.Text = "0.0"
        '
        'LblP100
        '
        Me.LblP100.AutoSize = True
        Me.LblP100.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP100.ForeColor = System.Drawing.Color.White
        Me.LblP100.Location = New System.Drawing.Point(507, 171)
        Me.LblP100.Name = "LblP100"
        Me.LblP100.Size = New System.Drawing.Size(31, 17)
        Me.LblP100.TabIndex = 7
        Me.LblP100.Text = "0.0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(507, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 17)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "0.0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(507, 341)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 17)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(507, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 17)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "0.0"
        '
        'LblP200
        '
        Me.LblP200.AutoSize = True
        Me.LblP200.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP200.ForeColor = System.Drawing.Color.White
        Me.LblP200.Location = New System.Drawing.Point(507, 256)
        Me.LblP200.Name = "LblP200"
        Me.LblP200.Size = New System.Drawing.Size(31, 17)
        Me.LblP200.TabIndex = 7
        Me.LblP200.Text = "0.0"
        '
        'LblP500
        '
        Me.LblP500.AutoSize = True
        Me.LblP500.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP500.ForeColor = System.Drawing.Color.White
        Me.LblP500.Location = New System.Drawing.Point(507, 341)
        Me.LblP500.Name = "LblP500"
        Me.LblP500.Size = New System.Drawing.Size(31, 17)
        Me.LblP500.TabIndex = 7
        Me.LblP500.Text = "0.0"
        '
        'LblP1000
        '
        Me.LblP1000.AutoSize = True
        Me.LblP1000.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP1000.ForeColor = System.Drawing.Color.White
        Me.LblP1000.Location = New System.Drawing.Point(507, 426)
        Me.LblP1000.Name = "LblP1000"
        Me.LblP1000.Size = New System.Drawing.Size(31, 17)
        Me.LblP1000.TabIndex = 7
        Me.LblP1000.Text = "0.0"
        '
        'lblTCashCount
        '
        Me.lblTCashCount.AutoSize = True
        Me.lblTCashCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCashCount.ForeColor = System.Drawing.Color.Lime
        Me.lblTCashCount.Location = New System.Drawing.Point(440, 495)
        Me.lblTCashCount.Name = "lblTCashCount"
        Me.lblTCashCount.Size = New System.Drawing.Size(49, 17)
        Me.lblTCashCount.TabIndex = 7
        Me.lblTCashCount.Text = "00.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label25.Location = New System.Drawing.Point(262, 495)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(172, 17)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "TOTAL CASH COUNT :"
        '
        'TxtTDiscount
        '
        Me.TxtTDiscount.BackColor = System.Drawing.Color.Black
        Me.TxtTDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTDiscount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTDiscount.ForeColor = System.Drawing.Color.Gold
        Me.TxtTDiscount.Location = New System.Drawing.Point(791, 109)
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
        Me.ClientSize = New System.Drawing.Size(1009, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtTDiscount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblTCashCount)
        Me.Controls.Add(Me.LblP1000)
        Me.Controls.Add(Me.LblP500)
        Me.Controls.Add(Me.LblC20)
        Me.Controls.Add(Me.LblP200)
        Me.Controls.Add(Me.LblC10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblP100)
        Me.Controls.Add(Me.LblP50)
        Me.Controls.Add(Me.LblC5)
        Me.Controls.Add(Me.LblC1)
        Me.Controls.Add(Me.p1000)
        Me.Controls.Add(Me.p500)
        Me.Controls.Add(Me.c20)
        Me.Controls.Add(Me.p200)
        Me.Controls.Add(Me.c10)
        Me.Controls.Add(Me.p100)
        Me.Controls.Add(Me.c5)
        Me.Controls.Add(Me.p50)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnPost)
        Me.Controls.Add(Me.BtnPrintDenomination)
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
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnPrintDenomination As Button
    Friend WithEvents BtnPost As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents c1 As TextBox
    Friend WithEvents c5 As TextBox
    Friend WithEvents c10 As TextBox
    Friend WithEvents c20 As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents p50 As TextBox
    Friend WithEvents p100 As TextBox
    Friend WithEvents p200 As TextBox
    Friend WithEvents p500 As TextBox
    Friend WithEvents p1000 As TextBox
    Friend WithEvents LblC1 As Label
    Friend WithEvents LblC5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LblC20 As Label
    Friend WithEvents LblC10 As Label
    Friend WithEvents LblP50 As Label
    Friend WithEvents LblP100 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LblP200 As Label
    Friend WithEvents LblP500 As Label
    Friend WithEvents LblP1000 As Label
    Friend WithEvents lblTCashCount As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtTDiscount As TextBox
End Class
