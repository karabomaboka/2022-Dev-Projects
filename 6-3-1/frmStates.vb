Public Class frmStates

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim n As Integer = lstStates.Items.Count
    For i As Integer = (n - 1) To (n - 10) Step -1
      lstLastTen.Items.Add(lstStates.Items(i))
    Next
  End Sub

End Class
