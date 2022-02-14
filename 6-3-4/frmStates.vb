Public Class frmStates

  Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
    Dim letters As String = mtbFirstTwoLetters.Text.ToUpper
    Dim i As Integer = 0   'index of the state currently considered
    Do Until (CStr(lstStates.Items(i)).ToUpper >= letters) Or
             (i = lstStates.Items.Count - 1)
      i += 1
    Loop
    If CStr(lstStates.Items(i)).ToUpper.StartsWith(letters) Then
      txtOutput.Text = CStr(lstStates.Items(i)) & " begins with " &
                       mtbFirstTwoLetters.Text & "."
    Else
      txtOutput.Text = "No state begins with " & mtbFirstTwoLetters.Text & "."
    End If
  End Sub

End Class
