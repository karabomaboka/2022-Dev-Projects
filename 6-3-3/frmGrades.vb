Public Class frmGrades

  Private Sub btnRecord_Click(sender As System.Object, e As System.EventArgs) Handles btnRecord.Click
    lstGrades.Items.Add(txtGrade.Text)
    txtGrade.Clear()
    txtGrade.Focus()
  End Sub

  Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
    Dim sum As Double = 0
    Dim maxGrade As Double = 0
    If lstGrades.Items.Count > 0 Then   'condition is true when the list box is nonempty
      For i As Integer = 0 To lstGrades.Items.Count - 1
        sum += CDbl(lstGrades.Items(i))
        If CDbl(lstGrades.Items(i)) > maxGrade Then
          maxGrade = CDbl(lstGrades.Items(i))
        End If
      Next
      txtAverage.Text = (sum / lstGrades.Items.Count).ToString("N2")
      txtHighest.Text = CStr(maxGrade)
    Else
      MessageBox.Show("You must first enter some grades.")
    End If
  End Sub

End Class
