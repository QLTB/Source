Public Class frm_main

    Private Sub SuperTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs)

    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonBar1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LabelItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SuperTabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_change_pass
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(1).Visible = True
        Bar1.SelectedDockTab = 1
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(1).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Bar1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bar1.ItemClick

    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_access_rights
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(2).Visible = True
        Bar1.SelectedDockTab = 2
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(2).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_department
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(3).Visible = True
        Bar1.SelectedDockTab = 3
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(3).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_type_of_equipment
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(4).Visible = True
        Bar1.SelectedDockTab = 4
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(4).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_position
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(5).Visible = True
        Bar1.SelectedDockTab = 5
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(5).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_type_of_equipment
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(7).Visible = True
        Bar1.SelectedDockTab = 7
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(7).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click

    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_inventory
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(8).Visible = True
        Bar1.SelectedDockTab = 8
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(8).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_position
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(9).Visible = True
        Bar1.SelectedDockTab = 9
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(9).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_department
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(10).Visible = True
        Bar1.SelectedDockTab = 10
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(10).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_employees
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(11).Visible = True
        Bar1.SelectedDockTab = 11
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(11).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_users
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.Visible = True
        Bar1.Items(0).Visible = True
        Bar1.SelectedDockTab = 0
        'f.MdiParent = Bar1.SelectedDockContainerItem.Control
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        'f.Visible = True
        Bar1.Items(0).Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibbonBar5_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonBar5.ItemClick

    End Sub

    Private Sub RibbonPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonPanel1.Click

    End Sub

    Private Sub PanelDockContainer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelDockContainer1.Click

    End Sub

    Private Sub PanelDockContainer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelDockContainer2.Click

    End Sub

    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        End
    End Sub
End Class