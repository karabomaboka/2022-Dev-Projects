Public Class frmSort

  Private Sub btnSort_Click(sender As System.Object, e As System.EventArgs) Handles btnSort.Click
    Dim nums() As Integer = {3, 6, 4, 1}
    Dim numQuery = From num In nums
                   Order By num Ascending
                   Select num
    For Each n As Integer In numQuery
      lstOutput.Items.Add(n)
    Next
  End Sub

End Class
