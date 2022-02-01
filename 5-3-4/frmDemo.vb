Public Class frmDemo

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Demonstrate the local nature of variables
    Dim x As Double = 2
    lstResults.Items.Clear()
    lstResults.Items.Add(x & " : event procedure")
    Trivial()
    lstResults.Items.Add(x & " : event procedure")
    Trivial()
    lstResults.Items.Add(x & " : event procedure")
  End Sub

  Sub Trivial()
    'Do something trivial
    Dim x As Double
    lstResults.Items.Add(x & " : Sub procedure")
    x = 3
    lstResults.Items.Add(x & " : Sub procedure")
  End Sub

End Class
