Public Class frmFirstName

  Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
    'Determine a person's first name
    Dim fullName As String
    fullName = txtFullName.Text
    txtFirstname.Text = FirstName(fullName)
  End Sub

  Function FirstName(fullName As String) As String
    'Extract the first name from a full name
    Dim firstSpace As Integer
    firstSpace = fullName.IndexOf(" ")
    Return fullName.Substring(0, firstSpace)
  End Function

End Class
