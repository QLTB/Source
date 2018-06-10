Module general
    Public Function add_tab(ByRef bar As DevComponents.DotNetBar.Bar, ByVal title As String, ByVal name As String) As Integer
        Dim dci As New DevComponents.DotNetBar.DockContainerItem
        Dim pdc As New DevComponents.DotNetBar.PanelDockContainer
        dci.Text = title
        pdc.Name = name
        pdc.Style.Alignment = System.Drawing.StringAlignment.Center
        pdc.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        pdc.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        pdc.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        pdc.Style.GradientAngle = 90
        dci.Control = pdc
        dci.CanClose = DevComponents.DotNetBar.eDockContainerClose.No
        bar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {dci})
        Return bar.Items.Count() - 1
    End Function
    Public Sub binding_form_to_docktab(ByRef bar As DevComponents.DotNetBar.Bar, ByVal f As Form, ByVal curtab As Integer)
        f.Owner = frm_main
        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        bar.SelectedDockTab = curtab
        bar.SelectedDockContainerItem.Control.Controls.Add(f)
        bar.Refresh()
    End Sub
End Module
