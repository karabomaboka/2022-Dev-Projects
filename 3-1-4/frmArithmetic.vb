Public Class frmArithmetic

  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    Dim a As Double
    Dim b As Double
    a = 2
    b = 3
    lstResults.Items.Clear()
    lstResults.Items.Add(Math.Sqrt(5 * b + 1))
    lstResults.Items.Add(Int(a ^ b + 0.8))
    lstResults.Items.Add(Math.Round(a / b, 3))
  End Sub

End Class
