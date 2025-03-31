Public Class adminDashboard

    Dim productRepo As New ProductRepo
    Dim Mdf As New ManageDataRefresher
    Private Sub BtnBoreder(btn As Button)
        btn.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mdf.GetDashboardData()
        Mdf.GetZeroProduct()

        BtnBoreder(btnDashboard)
        BtnBoreder(btnManageProduct)
        BtnBoreder(btnManageStock)
        BtnBoreder(btnManageSupplier)
        BtnBoreder(btnManageUser)
        BtnBoreder(btnExit)

        btnDashboard.BackColor = Color.SteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        DashboardPanelForm.TopLevel = False
        DashboardPanelForm.FormBorderStyle = FormBorderStyle.None
        DashboardPanelForm.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(DashboardPanelForm)
        DashboardPanelForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Mdf.GetDashboardData()

        btnDashboard.BackColor = Color.SteelBlue
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        DashboardPanelForm.TopLevel = False
        DashboardPanelForm.FormBorderStyle = FormBorderStyle.None
        DashboardPanelForm.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(DashboardPanelForm)
        DashboardPanelForm.Show()
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Mdf.GetManageProductData()
        productRepo.HighlightZeroQtyCells(ManageProduct.DgManageProduct, "qty")
        productRepo.HighlightAvailableProduct(ManageProduct.DgManageProduct, "qty")

        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.SteelBlue
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageProduct.TopLevel = False
        ManageProduct.FormBorderStyle = FormBorderStyle.None
        ManageProduct.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageProduct)
        ManageProduct.Show()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        Mdf.GetManageStockData()
        productRepo.HighlightAvailableProduct(ManageStock.DgStock, "qty")
        productRepo.HighlightZeroQtyCells(ManageStock.DgStock, "qty")
        productRepo.HighlightExpiredProduct(ManageStock.DgStock, "expiredate")

        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.SteelBlue
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageStock.TopLevel = False
        ManageStock.FormBorderStyle = FormBorderStyle.None
        ManageStock.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageStock)
        ManageStock.Show()
    End Sub

    Private Sub btnManageSupplier_Click(sender As Object, e As EventArgs) Handles btnManageSupplier.Click
        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.SteelBlue
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageSupplier.TopLevel = False
        ManageSupplier.FormBorderStyle = FormBorderStyle.None
        ManageSupplier.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageSupplier)
        ManageSupplier.Show()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Mdf.GetManageUserData()
        ManageUser.DgManageUser.Focus()

        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.SteelBlue

        adminMainPanel.Controls.Clear()

        ManageUser.TopLevel = False
        ManageUser.FormBorderStyle = FormBorderStyle.None
        ManageUser.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageUser)
        ManageUser.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As Integer
        res = MessageBox.Show("Quit application?", "Exit App", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = vbOK Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnExit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnExit.KeyPress
        btnExit.BackColor = Color.Tomato
    End Sub

    Private Sub btnExit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnExit.KeyDown
        btnExit.BackColor = Color.Tomato
    End Sub
End Class