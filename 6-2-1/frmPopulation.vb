Public Class frmPopulation

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display population from 2018 to 2022
    Dim pop As Double = 300000
    For yr As Integer = 2018 To 2022
      lstTable.Items.Add(yr & "     " & pop.ToString("N0"))
      pop += 0.03 * pop
    Next
  End Sub

End Class
