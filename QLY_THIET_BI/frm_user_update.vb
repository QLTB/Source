Public Class frm_user_update

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(frm_main.Bar1.SelectedDockTab)
        Me.Close()
    End Sub
End Class