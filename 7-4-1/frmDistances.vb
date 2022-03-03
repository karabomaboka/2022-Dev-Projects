Public Class frmDistances

  Dim rm(,) As Double = {{0, 2054, 802, 738},
                         {2054, 0, 2786, 2706},
                         {802, 2786, 0, 100},
                         {738, 2706, 100, 0}}

  Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
    'Determine road mileage between cities
    Dim row, col As Integer
    row = CInt(mtbOrig.Text)
    col = CInt(mtbDest.Text)
    If (row >= 1 And row <= 4) And (col >= 1 And col <= 4) Then
      txtMiles.Text = CStr(rm(row - 1, col - 1))
    Else
      MessageBox.Show("Origin and Destination must be numbers from 1 to 4", "Error")
    End If
  End Sub

End Class
