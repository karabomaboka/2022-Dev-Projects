Public Class frmPay

  Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
    'Calculate a person's weekly pay
    Dim hourlyWage, hoursWorked As Decimal
    hourlyWage = CDec(txtWage.Text)
    hoursWorked = CDec(txtHours.Text)
    txtEarnings.Text = (Pay(hourlyWage, hoursWorked)).ToString("C")
  End Sub

  Function Pay(wage As Decimal, hrs As Decimal) As Decimal
    'Calculate weekly pay with time-and-a-half for overtime
    Dim amount As Decimal
    Select Case hrs
      Case Is <= 40
        amount = wage * hrs
      Case Is > 40
        amount = (wage * 40) + ((1.5D * wage) * (hrs - 40))
    End Select
    Return amount
  End Function

End Class
