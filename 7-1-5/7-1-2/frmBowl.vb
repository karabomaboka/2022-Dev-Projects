Public Class frmBowl

  'Dim teamNames(3) As String

  'Private Sub frmBowl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
  '  'Place Super Bowl Winners into the array
  '  teamNames(0) = "Packers"
  '  teamNames(1) = "Packers"
  '  teamNames(2) = "Jets"
  '  teamNames(3) = "Chiefs"
  'End Sub


  Dim teamNames() As String = {"Packers", "Packers", "Jets", "Chiefs"}

  Private Sub btnWhoWon_Click(sender As System.Object, e As System.EventArgs) Handles btnWhoWon.Click
    Dim n As Integer
    n = CInt(mtbNumber.Text)
    txtWinner.Text = teamNames(n - 1)
  End Sub






End Class
