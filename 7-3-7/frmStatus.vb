Public Class frmStatus

  Structure FullName
    Dim firstName As String
    Dim lastName As String
  End Structure

  Structure Student
    Dim name As FullName
    Dim credits() As Integer
  End Structure

  Private Sub btnGet_Click(sender As System.Object, e As System.EventArgs) Handles btnGet.Click
    Dim numYears As Integer
    Dim person As Student
    txtResult.Clear()
    person.name.firstName = InputBox("First Name:")
    person.name.lastName = InputBox("Last Name:")
    numYears = CInt(InputBox("Number of years completed:"))
    ReDim person.credits(numYears - 1)
    For i As Integer = 0 To numYears - 1
      person.credits(i) = CInt(InputBox("Credits in year " & i + 1))
    Next
    DetermineStatus(person)
  End Sub

  Sub DetermineStatus(person As Student)
    Dim query = From num In person.credits
                Select num
    Dim total As Integer = query.Sum
    If (total >= 120) Then
      txtResult.Text = person.name.firstName & " " &
               person.name.lastName & " has enough credits to graduate."
    Else
      txtResult.Text = person.name.firstName & " " &
                       person.name.lastName & " needs " &
                       (120 - total) & " more credits to graduate."
    End If
  End Sub

End Class
