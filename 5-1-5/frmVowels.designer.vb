<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVowelWords
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.lblWord = New System.Windows.Forms.Label()
    Me.txtWord = New System.Windows.Forms.TextBox()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lblWord
    '
    Me.lblWord.AutoSize = True
    Me.lblWord.Location = New System.Drawing.Point(55, 13)
    Me.lblWord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblWord.Name = "lblWord"
    Me.lblWord.Size = New System.Drawing.Size(92, 17)
    Me.lblWord.TabIndex = 0
    Me.lblWord.Text = "Enter a word:"
    '
    'txtWord
    '
    Me.txtWord.Location = New System.Drawing.Point(155, 10)
    Me.txtWord.Margin = New System.Windows.Forms.Padding(4)
    Me.txtWord.Name = "txtWord"
    Me.txtWord.Size = New System.Drawing.Size(132, 22)
    Me.txtWord.TabIndex = 1
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(9, 82)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.Size = New System.Drawing.Size(325, 22)
    Me.txtOutput.TabIndex = 2
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(31, 39)
    Me.btnDetermine.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(280, 36)
    Me.btnDetermine.TabIndex = 3
    Me.btnDetermine.Text = "Determine If Word Contains Every Vowel"
    Me.btnDetermine.UseVisualStyleBackColor = True
    '
    'frmVowelWords
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(342, 115)
    Me.Controls.Add(Me.btnDetermine)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.txtWord)
    Me.Controls.Add(Me.lblWord)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmVowelWords"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Vowel Words"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblWord As System.Windows.Forms.Label
  Friend WithEvents txtWord As System.Windows.Forms.TextBox
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox
  Friend WithEvents btnDetermine As System.Windows.Forms.Button

End Class
