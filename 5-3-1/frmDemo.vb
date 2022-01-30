Public Class frmDemo

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Illustrate that a change in value of parameter does not alter the
    'value of the argument
    Dim amt As Double = 2
    lstResults.Items.Add(amt & " from event procedure")
    Triple(amt)
    lstResults.Items.Add(amt & " from event procedure")
  End Sub

  Sub Triple(num As Double)
    'Triple a number
    lstResults.Items.Add(num & " from Sub procedure")
    num = 3 * num
    lstResults.Items.Add(num & " from Sub procedure")
  End Sub

End Class
