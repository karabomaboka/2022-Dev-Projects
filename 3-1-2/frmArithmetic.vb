Public Class frmArithmetic

  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    Dim a As Double
    Dim b As Double = 3
    lstResults.Items.Clear()
    lstResults.Items.Add(a)
    lstResults.Items.Add(b)
    a = 5
    lstResults.Items.Add(a * (2 + b))
  End Sub

End Class
