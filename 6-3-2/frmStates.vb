Public Class frmStates

  Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
    Dim letters As String = mtbFirstTwoLetters.Text.ToUpper
    Dim foundFlag As Boolean = False  'indicates whetber state has been found
    Dim i As Integer = -1   'index of the state currently considered
    Do Until (foundFlag) Or (i = lstStates.Items.Count - 1)
      i += 1
      If CStr(lstStates.Items(i)).ToUpper.StartsWith(letters) Then
        foundFlag = True
      End If
    Loop
    If foundFlag Then
      txtOutput.Text = CStr(lstStates.Items(i)) & " is state #" & (i + 1) & "."
    Else
      txtOutput.Text = "No state begins with " & mtbFirstTwoLetters.Text & "."
    End If
  End Sub

End Class
