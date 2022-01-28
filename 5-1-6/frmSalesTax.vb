Public Class Form1

  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Dim amount = CDec(txtAmount.Text)
    txtSalesTax.Text = CalculateSalesTax(amount)
  End Sub

  Function CalculateSalesTax(amount As Decimal) As String
    Const SALES_TAX_RATE = 0.05
    If amount < 0 Then
      MessageBox.Show("The amount of the purchase must not be negative.")
      Exit Function
    End If
    Return (amount * SALES_TAX_RATE).ToString("C")
  End Function
End Class
