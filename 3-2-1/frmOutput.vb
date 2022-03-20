Public Class frmOutput

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim president As String
    president = "George Washington"
    lstOutput.Items.Clear()
    lstOutput.Items.Add("president")
    lstOutput.Items.Add(president)
  End Sub

End Class
