Public Class frmArithmetic

  Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
    lstResults.Items.Clear()
    lstResults.Items.Add(3 + 2)
    lstResults.Items.Add(3 - 2)
    lstResults.Items.Add(3 * 2)
    lstResults.Items.Add(3 / 2)
    lstResults.Items.Add(3 ^ 2)
    lstResults.Items.Add(2 * (3 + 4))
  End Sub

  Private Sub frmArithmetic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

  End Sub
End Class
