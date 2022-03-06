Public Class frmCountry

  Structure Nation
    Dim name As String
    Dim continent As String
    Dim population As Double  'in millions
    Dim area As Double        'in square miles
  End Structure

  Dim nations(192) As Nation

  Private Sub frmCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'Place the contents of UN.txt into the array nations
    Dim line As String
    Dim data() As String
    Dim countries() As String = IO.File.ReadAllLines("UN.txt")
    For i As Integer = 0 To 192
      line = countries(i)
      data = line.Split(","c)
      nations(i).name = data(0)
      nations(i).continent = data(1)
      nations(i).population = CDbl(data(2))
      nations(i).area = CDbl(data(3))
    Next
  End Sub

  Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
    Dim query = From country In nations
                Order By country.population Descending
                Select country.name
    lstCountries.Items.Clear()
    For Each countryName As String In query
      lstCountries.Items.Add(countryName)
    Next
  End Sub

End Class
