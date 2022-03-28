Public Class frmSentence

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim str As String, numOfKeys As Integer
    str = "The piano keyboard has "
    numOfKeys = 88
    txtOutput.Text = str & numOfKeys & " keys."
  End Sub

End Class
