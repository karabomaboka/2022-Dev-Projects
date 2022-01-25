Public Class frmVowelWords

  Private Sub btnDetermine_Click() Handles btnDetermine.Click
    Dim word As String
    word = txtWord.Text.ToUpper
    If IsVowelWord(word) Then
      txtOutput.Text = word & " contains every vowel."
    Else
      txtOutput.Text = word & " does not contain every vowel."
    End If
  End Sub

  Function IsVowelWord(word As String) As Boolean
    'Return False if any of the 5 vowels are not in the word.
    'Otherwise, return True
    If word.IndexOf("A") = -1 Then
      Return False
    End If
    If word.IndexOf("E") = -1 Then
      Return False
    End If
    If word.IndexOf("I") = -1 Then
      Return False
    End If
    If word.IndexOf("O") = -1 Then
      Return False
    End If
    If word.IndexOf("U") = -1 Then
      Return False
    End If
    Return True 'All vowels are present.
  End Function

End Class
