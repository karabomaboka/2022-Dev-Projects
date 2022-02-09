Public Class frmTable

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display a table of the first 5 numbers and their squares
    Dim i As Integer
    i = 1
    Do While i <= 5
      lstTable.Items.Add(i & "  " & i ^ 2)
      i += 1    'Add 1 to i
    Loop
  End Sub

End Class
