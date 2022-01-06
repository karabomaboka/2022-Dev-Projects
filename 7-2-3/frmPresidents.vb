Public Class frmPresidents

  Dim presidents() As String = IO.File.ReadAllLines("USPres.txt")

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim presQuery = From pres In presidents
                    Where FirstName(pres) = txtFirstName.Text
                    Select IncludeTitle(pres)
    lstPres.Items.Clear()
    For Each pres As String In presQuery
      lstPres.Items.Add(pres)
    Next
  End Sub

  Function FirstName(name As String) As String
    'Extract the first name from a full name
    Dim parsedName() As String = name.Split(" "c)
    Return parsedName.First
  End Function

  Function IncludeTitle(pres As String) As String
    Return "President " & pres
  End Function

End Class
