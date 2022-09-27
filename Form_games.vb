Public Class Form_games
    Private Sub GamesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GamesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Game_cafeDataSet1)

    End Sub

    Private Sub Form_games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Game_cafeDataSet1.games' table. You can move, or remove it, as needed.
        Me.GamesTableAdapter.Fill(Me.Game_cafeDataSet1.games)

    End Sub
End Class