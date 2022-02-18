Public Class frmNumbers

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim nums() As Integer = {5, 12, 8, 7, 11}
    Dim numQuery1 = From num In nums
                    Where num > 7
                    Select num
    For Each num As Integer In numQuery1
      lstBox.Items.Add(num)
    Next
    lstBox.Items.Add("Largest number: " & numQuery1.Max)
    lstBox.Items.Add("Second number: " & numQuery1(1))
    lstBox.Items.Add("Sum of numbers: " & numQuery1.Sum)
    lstBox.Items.Add("")
    Dim numQuery2 = From num In nums
                    Where num Mod 2 = 0
                    Select num
    lstBox.Items.Add("Number of even numbers: " & numQuery2.Count)
    lstBox.Items.Add("Average of even numbers: " & numQuery2.Average)
    lstBox.Items.Add("Last even number: " & numQuery2.Last)
  End Sub

End Class
