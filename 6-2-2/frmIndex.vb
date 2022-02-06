Public Class frmIndex

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display values of index ranging from 0 to n Step s
    Dim n, s As Decimal
    n = CDec(txtEnd.Text)
    s = CDec(txtStep.Text)
    lstValues.Items.Clear()
    For index As Decimal = 0 To n Step s
      lstValues.Items.Add(index)
    Next
  End Sub

End Class
