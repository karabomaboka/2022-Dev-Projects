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
    Dim n As Integer = schools.Count - 1
    ReDim colleges(n)
    Dim data() As String   'hold data for a single college
    For i As Integer = 0 To n
      data = schools(i).Split(","c)
      colleges(i).name = data(0)
      colleges(i).state = data(1)
      colleges(i).yearFounded = CInt(data(2))
    Next
  End Sub

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display the colleges in Colleges.txt located in the given state
    Dim collegeQuery = From col In colleges
                       Where col.state = mtbState.Text.ToUpper
                       Order By col.name Ascending
                       Select col.name, col.yearFounded
    dgvColleges.DataSource = collegeQuery.ToList
    dgvColleges.CurrentCell = Nothing
  End Sub

End Class
