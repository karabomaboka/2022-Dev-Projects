Public Class frmTable

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim row, entry As String
    lstTable.Items.Clear()
    For j As Integer = 1 To 3
      row = ""
      For k As Integer = 1 To 3
        entry = j & " x " & k & " = " & (j * k)
        row &= entry & "    "
      Next
      lstTable.Items.Add(row)
    Next
  End Sub

End Class
