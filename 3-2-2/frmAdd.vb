Public Class frmAdd

  Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
    Dim num1, num2, sum As Double
    num1 = CDbl(txtFirstNum.Text)
    num2 = CDbl(txtSecondNum.Text)
    sum = num1 + num2
    txtSum.Text = CStr(sum)
  End Sub

End Class
