Public Class frmStates

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim states() As String = IO.File.ReadAllLines("States.txt")
    Dim stateQuery = From state In states
                     Order By state.Length, state Descending
                     Select state
    For Each state As String In stateQuery
      lstStates.Items.Add(state)
    Next
  End Sub

End Class
