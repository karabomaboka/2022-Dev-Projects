Public Class frmMovie

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim response As Integer = 0, quotation As String = ""
    Do While (response < 1) Or (response > 3)
      response = CInt(InputBox("Enter a number from 1 to 3."))
    Loop
    Select Case response
      Case 1
        quotation = "Plastics."
      Case 2
        quotation = "Rosebud."
      Case 3
        quotation = "That's all folks."
    End Select
    txtQuotation.Text = quotation
  End Sub

End Class
