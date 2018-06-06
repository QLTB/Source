Public Class frm_position

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(9).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class