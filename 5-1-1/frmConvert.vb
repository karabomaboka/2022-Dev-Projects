Public Class frmConvert

  Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
    Dim fahrenheitTemp, celsiusTemp As Double
    fahrenheitTemp = CDbl(txtTempF.Text)
    celsiusTemp = FtoC(fahrenheitTemp)
    txtTempC.Text = CStr(celsiusTemp)
    'Note: The above four lines can be replaced with the single line
    'txtTempC.Text = CStr(FtoC(CDbl(txtTempF.Text)))
  End Sub

  Function FtoC(t As Double) As Double
    'Convert Fahrenheit temperature to Celsius
    Return Math.Round((5 / 9) * (t - 32), 2)
  End Function

End Class
