Public Class frmWords

  Private Sub btnSort_Click(sender As System.Object, e As System.EventArgs) Handles btnSort.Click
    Dim word1 As String = txtFirst.Text
    Dim word2 As String = txtSecond.Text
    If (word2 < word1) Then
      SwapWords(word1, word2)
    End If
    txtOutput.Text = word1 & " before " & word2
  End Sub

  Sub SwapWords(ByRef word1 As String, ByRef word2 As String)
    Dim temp As String
    temp = word1
    word1 = word2
    word2 = temp
  End Sub

End Class
