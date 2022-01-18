Public Class frmNumbers

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display the numbers from 1 to 7
    Dim num As Integer = 1
    Do While num <= 7
      lstNumbers.Items.Add(num)
      num += 1    'Add 1 to the value of num.
    Loop
  End Sub

End Class
