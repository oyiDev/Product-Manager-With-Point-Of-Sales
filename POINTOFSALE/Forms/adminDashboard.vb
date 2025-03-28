Public Class adminDashboard

    Dim DataRefresher As New ManageDataRefresher
    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.FlatAppearance.BorderSize = 0
        btnManageProduct.FlatAppearance.BorderSize = 0
        btnManageStock.FlatAppearance.BorderSize = 0
        btnManageSupplier.FlatAppearance.BorderSize = 0
        btnManageUser.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.BorderSize = 0

        btnDashboard.Focus()
        btnDashboard.BackColor = Color.DodgerBlue
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        btnDashboard.BackColor = Color.DodgerBlue
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

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Dim repo As New ProductRepo
        repo.getProductData()
        repo.WrapProductData()

        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.DodgerBlue
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

    'Private Sub RefreshMe()
    '    connect_me()
    '    Dim mycmd As New OdbcCommand("select * from products", con)
    '    Dim da As New OdbcDataAdapter(mycmd)
    '    Dim ds As New Data.DataSet
    '    da.Fill(ds, "products")
    '    btnDashboard.Refresh()
    'End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        DataRefresher.ManageStockLoadDataRefresh()
        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.DodgerBlue
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
        btnManageSupplier.BackColor = Color.DodgerBlue
        btnManageUser.BackColor = Color.White

        adminMainPanel.Controls.Clear()

        ManageSupplier.TopLevel = False
        ManageSupplier.FormBorderStyle = FormBorderStyle.None
        ManageSupplier.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageSupplier)
        ManageSupplier.Show()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click

        btnDashboard.BackColor = Color.White
        btnManageProduct.BackColor = Color.White
        btnManageStock.BackColor = Color.White
        btnManageSupplier.BackColor = Color.White
        btnManageUser.BackColor = Color.DodgerBlue

        adminMainPanel.Controls.Clear()

        ManageUser.TopLevel = False
        ManageUser.FormBorderStyle = FormBorderStyle.None
        ManageUser.Dock = DockStyle.Fill

        adminMainPanel.Controls.Add(ManageUser)
        ManageUser.Show()
    End Sub
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As Integer
        res = MessageBox.Show("Quit application?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If res = vbOK Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class