Public Class frmFoodLabel

  Structure NutFact
    Dim nutrient As String   'name of one of the five nutrients
    Dim amount As Double     'amount of the nutrient in the meal
  End Structure

  Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
    Dim servings(9) As Double
    Dim nutFacts(4) As NutFact           'This array of structures has an element
    '                                     for each nutrient.
    GetAmounts(servings)                 'input
    nutFacts = ProcessData(servings)     'processing
    ShowData(nutFacts)                   'output
  End Sub

  Sub GetAmounts(ByRef servings() As Double)
    Dim foods() As String = IO.File.ReadAllLines("Foods.txt")
    'Get the number of servings of each food.
    For i As Integer = 0 To 9
      servings(i) = CDbl(InputBox("How many servings of " & foods(i)))
    Next
  End Sub

  Function ProcessData(servings() As Double) As NutFact()
    Dim nutrients() As String = IO.File.ReadAllLines("Nutrients.txt")
    Dim nutTable(,) As Double = {{23, 3, 0.3, 8100, 93},
                                 {160, 2, 1, 9230, 46},
                                 {230, 10, 3, 120, 343},
                                 {85, 8, 0, 500, 302},
                                 {65, 3, 1, 0, 24},
                                 {178, 3.8, 0.9, 0, 18},
                                 {110, 2, 1, 2510, 30},
                                 {156, 2.4, 0.4, 7000, 80},
                                 {575, 126.8, 3.6, 0, 73},
                                 {405, 28.8, 26.6, 984, 190}}
    Dim nutritionFacts(4) As NutFact  'This array of structures has an 
    '                                  element for each nutrient.
    For i As Integer = 0 To 4
      nutritionFacts(i).nutrient = nutrients(i)  'Place the name of a nutrient
      '                                           into an array element. 
      'The next five lines calculate the total amount of the nutrient
      'in the meal and place it into the array element.
      Dim sum As Double = 0
      For k As Integer = 0 To 9
        sum += servings(k) * nutTable(k, i)
      Next
      nutritionFacts(i).amount = sum  'Place the amount of the nutrient into
      '                                the array element.
    Next
    Return nutritionFacts
  End Function

  Sub ShowData(nutFacts() As NutFact)
    'Create a query and use it to place the data from the array
    'of structures into a DataGridView control.
    Dim query = From element In nutFacts
                Let Nutrient = element.nutrient
                Let Amount = (element.amount).ToString("N")
                Select Nutrient, Amount
    dgvOutput.DataSource = query.ToList
    dgvOutput.CurrentCell = Nothing
  End Sub

End Class
