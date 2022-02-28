Public Class frmColleges

  Structure College
    Dim name As String
    Dim state As String
    Dim yearFounded As Integer
  End Structure

  Dim colleges() As College

  Private Sub frmColleges_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'Place the data for each college into the array schools
    Dim schools() = IO.File.ReadAllLines("Colleges.txt")
    Dim n = schools.Count - 1
    ReDim colleges(n)
    Dim data(2) As String
    For i As Integer = 0 To n
      data = schools(i).Split(","c)
      colleges(i).name = data(0)
      colleges(i).state = data(1)
      colleges(i).yearFounded = CInt(data(2))
    Next
    Dim query = From institution In colleges
                Order By institution.name
                Select institution
    For Each institution In query
      lstColleges.Items.Add(institution.name)
    Next
  End Sub

  Private Sub lstColleges_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstColleges.SelectedIndexChanged
    Dim query = From institution In colleges
                Where institution.name = lstColleges.Text
                Select institution
    txtState.Text = query.First.state
    txtYear.Text = CStr(query.First.yearFounded)
  End Sub

End Class
