Public Class Form1

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click

        If Application.OpenForms().OfType(Of frm_users).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        'Mặc định Bar1 sẽ có 1 Tab
        'Thêm Tab
        Dim dci As New DevComponents.DotNetBar.DockContainerItem
        Dim pdc As New DevComponents.DotNetBar.PanelDockContainer
        dci.Text = "Hello"
        pdc.Name = "adduser"
        pdc.Style.Alignment = System.Drawing.StringAlignment.Center
        pdc.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        pdc.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        pdc.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        pdc.Style.GradientAngle = 90
        dci.Control = pdc
        dci.CanClose = DevComponents.DotNetBar.eDockContainerClose.No
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {dci})
        cur_dock_tab = Bar1.Items.Count() - 1
        'Me.Bar1.Refresh()
        'Hiển thị Form
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frm_users
        f.Owner = Me
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Bar1.SelectedDockContainerItem.Control.Controls.Add(f)
        Bar1.SelectedDockTab = cur_dock_tab
        f.Refresh()
        Bar1.Refresh()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        End
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dci As New DevComponents.DotNetBar.DockContainerItem
        Dim pdc As New DevComponents.DotNetBar.PanelDockContainer
        Dim cur_dock_tab As Integer
        dci.Text = "Hello"
        pdc.Name = "pdc"
        pdc.Style.Alignment = System.Drawing.StringAlignment.Center
        pdc.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        pdc.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        pdc.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        pdc.Style.GradientAngle = 90
        dci.Control = pdc
        dci.CanClose = DevComponents.DotNetBar.eDockContainerClose.No
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {dci})
        cur_dock_tab = Bar1.Items.Count()
    End Sub
End Class