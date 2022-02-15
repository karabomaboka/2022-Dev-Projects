Public Class frmBowl

  Dim teamNames() As String
  Dim numGames As Integer
  'The file SBWinners includes 2013

  Private Sub frmBowl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    teamNames = IO.File.ReadAllLines("SBWinners.txt")
    numGames = teamNames.Count
    'Note: "Me" refers to the form
    Me.Text = "First " & numGames & " Super Bowls"
    'Specify the caption of the Add Winner button
    btnAddWinner.Text = "Add Winner of Game " & (numGames + 1)
  End Sub

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display the numbers of the games won by the team in the text box
    Dim noWinsFlag As Boolean = True   'Flag to detect if any wins
    lstGamesWon.Items.Clear()
    For i As Integer = 0 To numGames - 1
      If teamNames(i).ToUpper = txtName.Text.ToUpper Then
        lstGamesWon.Items.Add(i + 1)
        noWinsFlag = False
      End If
    Next
    If noWinsFlag Then
      lstGamesWon.Items.Add("No Games Won")
    End If
  End Sub

  Private Sub btnAddWinner_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWinner.Click
    'Add winner of next Super Bowl to the array
    Dim prompt As String
    'Add one more element to the array
    ReDim Preserve teamNames(numGames)
    numGames += 1
    'Request the name of the next winner
    prompt = "Enter winner of game #" & numGames & "."
    teamNames(numGames - 1) = InputBox(prompt, "Super Bowl")
    'Update the title bar of the form and the caption of the button
    Me.Text = "First " & numGames & " Super Bowls"
    btnAddWinner.Text = "Add Winner of Game " & (numGames + 1)
  End Sub

End Class