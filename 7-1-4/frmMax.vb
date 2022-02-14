
Public Class frmMax

  Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
    'Calculate the maximum age at inauguration for the last 9 presidents
    Dim ages() As Integer = {56, 61, 52, 69, 64, 46, 54, 47, 70}
    Dim max As Integer = ages(0)
    For i = 1 To ages.Count - 1
      If ages(i) > max Then
        max = ages(i)
      End If
    Next
    txtOutput.Text = "The greatest age is " & max & "."
  End Sub

End Class
