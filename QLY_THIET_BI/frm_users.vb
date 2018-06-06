Public Class frm_users

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        'MessageBox.Show(Form1.Bar1.SelectedDockTab)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(Form1.Bar1.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

    End Sub
End Class