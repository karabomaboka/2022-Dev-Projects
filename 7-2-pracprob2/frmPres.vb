Public Class frmPres

  Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
    Dim presidents() As String = IO.File.ReadAllLines("USPres.txt")
    Dim query = From pres In presidents
                Where pres.EndsWith("Eisenhower")
                Select pres
    txtFullName.Text = query.First
  End Sub

End Class
