Public Class Form_category
    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomersTableAdapter.FillBy(Me.Game_cafeDataSet1.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click

    End Sub
End Class