Public Class frmAverage

  Private Sub btnGet_Click(sender As System.Object, e As System.EventArgs) Handles btnGet.Click
    Dim numGrades As Integer = CInt(InputBox("Number of grades: ", "Grades"))
    txtAverage.Text = CStr(GetGrades(numGrades).Average)
  End Sub

  Function GetGrades(numGrades As Integer) As Double()
    Dim grades(numGrades - 1) As Double
    For i As Integer = 1 To numGrades
      grades(i - 1) = CDbl(InputBox("Grade #" & i & ": ", "Get Grade"))
    Next
    Return grades
  End Function

End Class
