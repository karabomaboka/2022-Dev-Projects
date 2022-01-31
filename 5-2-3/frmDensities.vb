Public Class frmDensities

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    DescribeTask()
    CalculateDensity("Hawaii", 1420000, 6471)
  End Sub

  Sub DescribeTask()
    lstOutput.Items.Clear()
    lstOutput.Items.Add("This program displays the")
    lstOutput.Items.Add("population density of the last state")
    lstOutput.Items.Add("to become part of the United States.")
  End Sub

  Sub CalculateDensity(state As String, pop As Double, area As Double)
    Dim density As Double
    density = pop / area
    lstOutput.Items.Add("")
    lstOutput.Items.Add("The population density of " & state & " is")
    lstOutput.Items.Add(density.ToString("N1") & " people per square mile.")
  End Sub

End Class
