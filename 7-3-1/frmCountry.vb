Public Class frmCountry

  Structure Nation
    Dim name As String
    Dim continent As String
    Dim population As Double  'in millions
    Dim area As Double        'in square miles
  End Structure

  Dim country As Nation       'class-level variable

  Private Sub frmCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'Assign values to country's member variables
    Dim line As String = "China,Asia,1355.7,3696100"
    Dim data() As String = line.Split(","c)
    country.name = data(0)
    country.continent = data(1)
    country.population = CDbl(data(2))
    country.area = CDbl(data(3))
  End Sub

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    'Display data in text boxes
    txtName.Text = country.name
    txtContinent.Text = country.continent
    txtPop.Text = (1000000 * country.population).ToString("N0")
    txtArea.Text = (country.area).ToString("N0") & " square miles"
    txtDensity.Text = (1000000 * country.population / country.area).ToString("N") &
                      " people per square mile"
  End Sub

End Class
