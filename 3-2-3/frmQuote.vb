Public Class frmQuote

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim quote1, quote2, quote As String
    quote1 = "The ballgame isn't over, "
    quote2 = "until it's over."
    quote = quote1 & quote2
    txtOutput.Text = quote & " Yogi Berra"
  End Sub

End Class
