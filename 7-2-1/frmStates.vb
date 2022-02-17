Public Class frmStates

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim states() As String = IO.File.ReadAllLines("States.txt")
    Dim stateQuery1 = From state As String In states
                      Where state.Length = 5
                      Select state
    For Each state As String In stateQuery1
      lstStates.Items.Add(state)
    Next
    lstStates.Items.Add("")
    Dim stateQuery2 = From state As String In states
                      Where state.StartsWith("New")
                      Select state
    For Each state In stateQuery2
      lstStates.Items.Add(state)
    Next
  End Sub

End Class
