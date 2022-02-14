<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStates
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
    Me.lstStates = New System.Windows.Forms.ListBox()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.btnSearch = New System.Windows.Forms.Button()
    Me.mtbFirstTwoLetters = New System.Windows.Forms.MaskedTextBox()
    Me.lblFirstTwo = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lstStates
    '
    Me.lstStates.FormattingEnabled = True
    Me.lstStates.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Montana", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
    Me.lstStates.Location = New System.Drawing.Point(17, 29)
    Me.lstStates.Name = "lstStates"
    Me.lstStates.Size = New System.Drawing.Size(100, 160)
    Me.lstStates.Sorted = True
    Me.lstStates.TabIndex = 0
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(62, 195)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = True
    Me.txtOutput.Size = New System.Drawing.Size(140, 20)
    Me.txtOutput.TabIndex = 1
    '
    'btnSearch
    '
    Me.btnSearch.Location = New System.Drawing.Point(136, 89)
    Me.btnSearch.Name = "btnSearch"
    Me.btnSearch.Size = New System.Drawing.Size(112, 60)
    Me.btnSearch.TabIndex = 2
    Me.btnSearch.Text = "Search For State"
    Me.btnSearch.UseVisualStyleBackColor = True
    '
    'mtbFirstTwoLetters
    '
    Me.mtbFirstTwoLetters.Location = New System.Drawing.Point(218, 32)
    Me.mtbFirstTwoLetters.Mask = "LL"
    Me.mtbFirstTwoLetters.Name = "mtbFirstTwoLetters"
    Me.mtbFirstTwoLetters.Size = New System.Drawing.Size(21, 20)
    Me.mtbFirstTwoLetters.TabIndex = 0
    '
    'lblFirstTwo
    '
    Me.lblFirstTwo.Location = New System.Drawing.Point(133, 29)
    Me.lblFirstTwo.Name = "lblFirstTwo"
    Me.lblFirstTwo.Size = New System.Drawing.Size(77, 26)
    Me.lblFirstTwo.TabIndex = 4
    Me.lblFirstTwo.Text = "First two letters of state:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(14, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "States:"
    '
    'frmStates
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(265, 225)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblFirstTwo)
    Me.Controls.Add(Me.mtbFirstTwoLetters)
    Me.Controls.Add(Me.btnSearch)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.lstStates)
    Me.Name = "frmStates"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "U.S. States"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstStates As System.Windows.Forms.ListBox
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox
  Friend WithEvents btnSearch As System.Windows.Forms.Button
  Friend WithEvents mtbFirstTwoLetters As System.Windows.Forms.MaskedTextBox
  Friend WithEvents lblFirstTwo As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
