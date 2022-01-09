Public Class frmStates

  Dim states() As String = IO.File.ReadAllLines("States.txt")

  Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
    Dim n As Integer, state As String
    state = txtState.Text
    n = Array.IndexOf(states, state)
    If n <> -1 Then
      txtOutput.Text = state & " was state number " & n + 1 & "."
    Else
      MessageBox.Show("Re-enter a state name.", "Error")
      txtState.Clear()
      txtState.Focus()
    End If
  End Sub

 End Class
