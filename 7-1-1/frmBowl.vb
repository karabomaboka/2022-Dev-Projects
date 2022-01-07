Public Class frmBowl

  Private Sub btnWhoWon_Click(sender As Object, e As EventArgs) Handles btnWhoWon.Click
    Dim teamNames(3) As String
    Dim n As Integer
    'Place Super Bowl Winners into the array
    teamNames(0) = "Packers"
    teamNames(1) = "Packers"
    teamNames(2) = "Jets"

    teamNames(3) = "Chiefs"
    'Access array
    n = CInt(mtbNumber.Text)
    txtWinner.Text = teamNames(n - 1)
  End Sub

End Class


