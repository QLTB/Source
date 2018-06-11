Public Class frm_main

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        If Application.OpenForms().OfType(Of frm_user).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm người dùng", "adduser")
        'Binding frm_users to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_user, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        End
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click
        If Application.OpenForms().OfType(Of frm_user_update).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Cập nhật người dùng", "updateuser")
        'Binding frm_user_update to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_user_update, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        If Application.OpenForms().OfType(Of frm_access_rights).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Quyền truy cập", "accessright")
        'Binding frm_access_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_access_rights, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        If Application.OpenForms().OfType(Of frm_grant_rights).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Quyền truy cập", "accessright")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_grant_rights, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub
End Class