Public Class frmEvaluate

  Private Sub btnEvaluate_Click(sender As System.Object, e As System.EventArgs) Handles btnEvaluate.Click
    Dim str1, str2, str3 As String
    str1 = "Quick as "
    str2 = "a wink"
    lstResults.Items.Clear()
    lstResults.Items.Add(str1.Substring(0, 7))
    lstResults.Items.Add(str1.IndexOf("c"))
    lstResults.Items.Add(str1.Substring(0, 3))
    lstResults.Items.Add((str1 & str2).Substring(6, 6))
    lstResults.Items.Add((str1 & str2).ToUpper)
    lstResults.Items.Add(str1.Trim & str2)
    str3 = str2.Substring(str2.Length - 4)
    lstResults.Items.Add("The average " & str3 & " lasts .1 second.")
  End Sub

End Class
