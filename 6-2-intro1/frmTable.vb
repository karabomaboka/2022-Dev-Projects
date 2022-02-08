Public Class frmTable

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display a table of the first 5 numbers and their squares
    'Assume the font for lstTable is Courier New
    For i As Integer = 1 To 5
      lstTable.Items.Add(i & "  " & i ^ 2)
    Next
  End Sub

End Class
