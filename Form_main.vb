Public Class Form_main
    Dim frm_normal_size = New Size(1220, 690)
    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Form_customers.MdiParent = Form_main.ActiveForm
        Form_customers.Dock = DockStyle.Fill
        Form_customers.Show()
        Me.Size = frm_normal_size
    End Sub

    Private Sub GamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamesToolStripMenuItem.Click
        Form_games.MdiParent = Form_main.ActiveForm
        Form_games.Dock = DockStyle.Fill
        Form_games.Show()
        Me.Size = frm_normal_size
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Form_category.MdiParent = Form_main.ActiveForm
        Form_category.Dock = DockStyle.Fill
        Form_category.Show()
        Me.Size = frm_normal_size
    End Sub
End Class