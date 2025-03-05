Imports System.Data.Odbc

Public Class adminMainForm
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboard.BackColor = Color.LightSteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        Dashboard.TopLevel = False
        Dashboard.FormBorderStyle = FormBorderStyle.None
        Dashboard.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click

        Dim res As Integer
        res = MessageBox.Show("Quit application?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If res = vbOK Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnManageSupplier_Click(sender As Object, e As EventArgs) Handles btnManageSupplier.Click
        btnDashboard.BackColor = Color.LightSteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        btnDashboard.BackColor = Color.LightSteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        InventoryDashboard.TopLevel = False
        InventoryDashboard.FormBorderStyle = FormBorderStyle.None
        InventoryDashboard.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(InventoryDashboard)
        InventoryDashboard.Show()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        btnDashboard.BackColor = Color.LightSteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageStock.TopLevel = False
        ManageStock.FormBorderStyle = FormBorderStyle.None
        ManageStock.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageStock)
        ManageStock.Show()
    End Sub

    Private Sub adminMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class