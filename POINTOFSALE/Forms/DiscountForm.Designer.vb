<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountForm
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
        Me.LblName = New System.Windows.Forms.Label()
        Me.Lblnumber = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtIdNum = New System.Windows.Forms.TextBox()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.lbldisType = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(53, 49)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(41, 14)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name:"
        '
        'Lblnumber
        '
        Me.Lblnumber.AutoSize = True
        Me.Lblnumber.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnumber.Location = New System.Drawing.Point(53, 102)
        Me.Lblnumber.Name = "Lblnumber"
        Me.Lblnumber.Size = New System.Drawing.Size(67, 14)
        Me.Lblnumber.TabIndex = 1
        Me.Lblnumber.Text = "ID number:"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(56, 66)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(255, 27)
        Me.TxtName.TabIndex = 2
        '
        'TxtIdNum
        '
        Me.TxtIdNum.BackColor = System.Drawing.Color.White
        Me.TxtIdNum.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdNum.Location = New System.Drawing.Point(56, 119)
        Me.TxtIdNum.Name = "TxtIdNum"
        Me.TxtIdNum.Size = New System.Drawing.Size(255, 27)
        Me.TxtIdNum.TabIndex = 3
        '
        'BtnEnter
        '
        Me.BtnEnter.BackColor = System.Drawing.Color.Lime
        Me.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnter.Location = New System.Drawing.Point(236, 164)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnter.TabIndex = 4
        Me.BtnEnter.Text = "ENTER"
        Me.BtnEnter.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(155, 164)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "CANCEL"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'lbldisType
        '
        Me.lbldisType.AutoSize = True
        Me.lbldisType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisType.Location = New System.Drawing.Point(6, 9)
        Me.lbldisType.Name = "lbldisType"
        Me.lbldisType.Size = New System.Drawing.Size(83, 13)
        Me.lbldisType.TabIndex = 5
        Me.lbldisType.Text = "discount type"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(347, 9)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(12, 15)
        Me.lblid.TabIndex = 5
        Me.lblid.Text = "0"
        '
        'DiscountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(371, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lbldisType)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.TxtIdNum)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Lblnumber)
        Me.Controls.Add(Me.LblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DiscountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents Lblnumber As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtIdNum As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents lbldisType As Label
    Friend WithEvents lblid As Label
End Class
