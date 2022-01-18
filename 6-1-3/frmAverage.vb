Public Class frmAverage

  Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
    Dim num As Double = 0
    Dim count As Integer = 0
    Dim sum As Double = 0
    Dim prompt As String = "Enter a nonnegative number. " &
                           "Enter -1 to terminate entering numbers."
    num = CDbl(InputBox(prompt))
    Do While num >= 0
      count += 1
      sum += num
      num = CDbl(InputBox(prompt))
    Loop
    If count > 0 Then
      MessageBox.Show("Average: " & sum / count)
    Else
      MessageBox.Show("No nonnegative numbers were entered.")
    End If
  End Sub

End Class
