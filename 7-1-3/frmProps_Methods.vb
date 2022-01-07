Public Class frmProps_Methods

  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim ages(44) As Integer
    Dim temp() As String = IO.File.ReadAllLines("AgesAtInaugural.txt")
    For i As Integer = 0 To 44
      ages(i) = CInt(temp(i))
    Next
    lstValues.Items.Add("Trump: " & ages(ages.Count - 1))
    lstValues.Items.Add("Washington: " & ages.First)
    lstValues.Items.Add("Trump: " & ages.Last)
    lstValues.Items.Add("Oldest age: " & ages.Max)
    lstValues.Items.Add("Youngest age: " & ages.Min)
    lstValues.Items.Add("Average age: " & (ages.Average).ToString("N"))
    lstValues.Items.Add("Average age: " & (ages.Sum / ages.Count).ToString("N"))
  End Sub

End Class
