Public Class frmAverage

  Structure Grades
    Dim exam1 As Double
    Dim exam2 As Double
    Dim final As Double
  End Structure

  Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
    Dim scores As Grades
    Dim semesterAverage As Double
    GetGrades(scores)
    scores = CurveGrades(scores)
    semesterAverage = (scores.exam1 + scores.exam2 + 2 * scores.final) / 4
    txtOutput.Text = "Semester Average: " & semesterAverage.ToString("N2")
  End Sub

  Sub GetGrades(ByRef scores As Grades)
    scores.exam1 = 80
    scores.exam2 = 90
    scores.final = 95
  End Sub

  Function CurveGrades(scores As Grades) As Grades
    scores.exam1 += 3
    scores.exam2 += 4
    scores.final += 2
    Return scores
  End Function

End Class
