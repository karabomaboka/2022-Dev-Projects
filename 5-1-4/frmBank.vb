Public Class frmBank

  Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
    'Find the future value of a bank deposit
    Dim p As Decimal = CDec(txtAmount.Text)
    Dim r As Decimal = CDec(txtRate.Text)
    Dim m As Integer = CInt(txtNumComp.Text)
    Dim t As Integer = CInt(txtNumYrs.Text)
    Dim balance As Decimal = FutureValue(p, r, m, t)
    txtBalance.Text = balance.ToString("C")
  End Sub

  Function FutureValue(p As Decimal, r As Decimal, m As Integer, t As Integer) As Decimal
    'Find the future value of a bank savings account
    'p  principal, the amount deposited
    'r  annual rate of interest in decimal form
    'm  number of times interest is compounded per year
    't  number of years
    Dim i As Decimal     'interest rate per period
    Dim n As Integer     'total number of times interest is compounded
    i = r / m
    n = m * t
    Return CDec(p * ((1 + i) ^ n))
  End Function

End Class
