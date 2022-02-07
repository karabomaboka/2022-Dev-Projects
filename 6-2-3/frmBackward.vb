Public Class frmBackward

  Private Sub btnReverse_Click(sender As System.Object, e As System.EventArgs) Handles btnReverse.Click
    txtBackward.Text = Reverse(txtWord.Text)
  End Sub

  Function Reverse(info As String) As String
    Dim m As Integer, temp As String = ""
    m = info.Length
    For j As Integer = m - 1 To 0 Step -1
      temp &= info.Substring(j, 1)
    Next
    Return temp
  End Function

End Class
