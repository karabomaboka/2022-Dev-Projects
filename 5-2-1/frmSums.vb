Public Class frmSums

  Private Sub btnAddNumbers_Click(sender As Object, e As EventArgs) Handles btnAddNumbers.Click
    DisplaySum(1, 2)
    Dim x As Double = 3
    Dim y As Double = 4
    DisplaySum(x, y)
    DisplaySum(2 * x, y + 5)
  End Sub

  Sub DisplaySum(num1 As Double, num2 As Double)
    Dim z As Double
    z = num1 + num2
    lstOutput.Items.Add("The sum of " & num1 & " and " & num2 & " is " & z & ".")
  End Sub

End Class
