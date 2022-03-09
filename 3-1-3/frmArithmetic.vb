Public Class frmArithmetic

  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    Dim n As Double
    Dim root As Double
    n = 6.76
    root = Math.Sqrt(n)
    lstResults.Items.Clear()
    lstResults.Items.Add(root)
    lstResults.Items.Add(Int(n))
    lstResults.Items.Add(Math.Round(n, 1))
  End Sub

End Class
