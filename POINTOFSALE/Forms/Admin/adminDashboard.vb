Public Class adminDashboard

    Dim productRepo As New ProductRepo
    Dim Mdf As New ManageDataRefresher

    Private Sub BtnBoreder(btn As Button)
        btn.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mdf.GetDashboardDatas()
        Mdf.GetZeroProduct()
        productRepo.HighlightAvailableProduct(ManageStock.DgManageStock, "QTY")
        productRepo.HighlightZeroQtyCells(ManageStock.DgManageStock, "QTY")
        productRepo.HighlightExpiredProduct(ManageStock.DgManageStock, "EXPIRY DATE")

        BtnBoreder(btnDashboard)
        BtnBoreder(btnManageProduct)
        BtnBoreder(btnManageStock)
        BtnBoreder(btnManageSupplier)
        BtnBoreder(btnManageUser)
        BtnBoreder(btnExit)

        btnDashboard.BackColor = Color.SteelBlue
        btnDashboard.ForeColor = Color.White

        adminMainPanel.Controls.Clear()

        DashboardPanelForm.TopLevel = False
        DashboardPanelForm.FormBorderStyle = FormBorderStyle.None
        DashboardPanelForm.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(DashboardPanelForm)
        DashboardPanelForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Mdf.GetDashboardDatas()

        btnDashboard.ForeColor = Color.White
        btnDashboard.BackColor = Color.SteelBlue

        btnManageProduct.ForeColor = Color.Black
        btnManageProduct.BackColor = Color.White

        btnManageStock.ForeColor = Color.Black
        btnManageStock.BackColor = Color.White

        btnManageSupplier.ForeColor = Color.Black
        btnManageSupplier.BackColor = Color.White

        btnManageUser.ForeColor = Color.Black
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        DashboardPanelForm.TopLevel = False
        DashboardPanelForm.FormBorderStyle = FormBorderStyle.None
        DashboardPanelForm.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(DashboardPanelForm)
        DashboardPanelForm.Show()
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Mdf.GetManageProductData("")
        ManageProduct.CbFilter.Text = "CATEGORY"
        ManageProduct.TxtSearchProduct.Clear()

        btnDashboard.ForeColor = Color.Black
        btnDashboard.BackColor = Color.White

        btnManageProduct.BackColor = Color.SteelBlue
        btnManageProduct.ForeColor = Color.White

        btnManageStock.ForeColor = Color.Black
        btnManageStock.BackColor = Color.White

        btnManageSupplier.ForeColor = Color.Black
        btnManageSupplier.BackColor = Color.White

        btnManageUser.ForeColor = Color.Black
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
        productRepo.HighlightAvailableProduct(ManageStock.DgManageStock, "QTY")
        productRepo.HighlightZeroQtyCells(ManageStock.DgManageStock, "QTY")
        productRepo.HighlightExpiredProduct(ManageStock.DgManageStock, "EXPIRY DATE")

        btnDashboard.ForeColor = Color.Black
        btnDashboard.BackColor = Color.White

        btnManageProduct.ForeColor = Color.Black
        btnManageProduct.BackColor = Color.White

        btnManageStock.ForeColor = Color.Black
        btnManageStock.BackColor = Color.White

        btnManageStock.ForeColor = Color.White
        btnManageStock.BackColor = Color.SteelBlue

        btnManageSupplier.ForeColor = Color.Black
        btnManageSupplier.BackColor = Color.White

        btnManageUser.ForeColor = Color.Black
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageStock.TopLevel = False
        ManageStock.FormBorderStyle = FormBorderStyle.None
        ManageStock.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageStock)
        ManageStock.Show()
    End Sub

    Private Sub btnManageSupplier_Click(sender As Object, e As EventArgs) Handles btnManageSupplier.Click
        Mdf.GetSupplierData()

        btnDashboard.ForeColor = Color.Black
        btnDashboard.BackColor = Color.White

        btnManageProduct.ForeColor = Color.Black
        btnManageProduct.BackColor = Color.White

        btnManageStock.ForeColor = Color.Black
        btnManageStock.BackColor = Color.White

        btnManageSupplier.ForeColor = Color.White
        btnManageSupplier.BackColor = Color.SteelBlue

        btnManageUser.ForeColor = Color.Black
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageSupplier.TopLevel = False
        ManageSupplier.FormBorderStyle = FormBorderStyle.None
        ManageSupplier.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageSupplier)
        ManageSupplier.Show()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Mdf.GetManageUserData("")
        ManageUser.TxtUserSearch.Clear()

        btnDashboard.ForeColor = Color.Black
        btnDashboard.BackColor = Color.White

        btnManageProduct.ForeColor = Color.Black
        btnManageProduct.BackColor = Color.White

        btnManageStock.ForeColor = Color.Black
        btnManageStock.BackColor = Color.White

        btnManageSupplier.ForeColor = Color.Black
        btnManageSupplier.BackColor = Color.White

        btnManageUser.ForeColor = Color.White
        btnManageUser.BackColor = Color.SteelBlue

        adminMainPanel.Controls.Clear()

        ManageUser.TopLevel = False
        ManageUser.FormBorderStyle = FormBorderStyle.None
        ManageUser.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageUser)
        ManageUser.Show()
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.Tomato
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As Integer
        res = MessageBox.Show("Quit application?", "Exit App", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = vbOK Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub adminDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim res As Integer
        res = MessageBox.Show("Quit application?", "Exit App", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = vbOK Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class