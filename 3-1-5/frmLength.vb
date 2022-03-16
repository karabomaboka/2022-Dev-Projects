Public Class frmLength

  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    Dim totalInches As Integer
    Dim feet As Integer
    Dim inches As Integer
    totalInches = 41
    feet = totalInches \ 12
    inches = totalInches Mod 12
    lstResults.Items.Add(feet)
    lstResults.Items.Add(inches)
  End Sub

End Class
