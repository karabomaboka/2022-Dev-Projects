Public Class frmMillionaire

  Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
    Dim balance As Double, numYears As Integer
    balance = CDbl(txtAmount.Text)
    Do While balance < 1000000
      balance += 0.06 * balance
      numYears += 1
    Loop
    txtWhen.Text = "In " & numYears &
       " years you will have a million dollars."
  End Sub

End Class
