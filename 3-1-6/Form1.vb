Public Class Form1

  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Dim balance As Decimal
    Dim interestRate As Decimal
    balance = 1025.45D
    interestRate = 0.04D
    balance = balance + interestRate * balance
    lstResult.Items.Add(Math.Round(balance, 2))
  End Sub

End Class
