Public Class frmDistances

  Dim rm(,) As Double = {{0, 2054, 802, 738},
                         {2054, 0, 2786, 2706},
                         {802, 2786, 0, 100},
                         {738, 2706, 100, 0}}

  Function FindCityNum(city As String) As Integer
    Select Case city.ToUpper
      Case "CHICAGO"
        Return 1
      Case "LOS ANGELES"
        Return 2
      Case "NEW YORK"
        Return 3
      Case "PHILADELPHIA"
        Return 4
      Case Else
        Return 0
    End Select
  End Function

  Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
    Dim orig, dest As String
    Dim row, col As Integer 'Determine road mileage between cities
    orig = txtOrig.Text
    dest = txtDest.Text
    row = FindCityNum(orig)
    col = FindCityNum(dest)
    If (row <> 0) And (col <> 0) Then
      txtMiles.Text = CStr(rm(row - 1, col - 1))
    Else
      MessageBox.Show("Incorrect Origin and/or Destination", "Error")
    End If
  End Sub

End Class
