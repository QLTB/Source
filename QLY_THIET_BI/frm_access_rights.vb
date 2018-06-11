Public Class frm_access_rights

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(2).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(frm_main.Bar1.SelectedDockTab)
        Me.Close()
    End Sub
End Class