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
        Me.components = New System.ComponentModel.Container()
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mtbFirstTwoLetters = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstTwo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 16
        Me.lstStates.Items.AddRange(New Object() {"Delaware", "Pennsylvania", "New Jersey", "Georgia", "Connecticut", "Massachusetts", "Maryland", "South Carolina", "New Hampshire", "Virginia", "New York", "North Carolina", "Rhode Island", "Vermont", "Kentucky", "Tennessee", "Ohio", "Louisiana", "Indiana", "Mississippi", "Illinois", "Alabama", "Maine", "Montana", "Arkansas", "Michigan", "Florida", "Texas", "Iowa", "Wisconsin", "California", "Minnesota", "Oregon", "Kansas", "West Virginia", "Nevada", "Nebraska", "Colorado", "North Dakota", "South Dakota", "Montana", "Washington", "Idaho", "Wyoming", "Utah", "Oklahoma", "New Mexico", "Arizona", "Alaska", "Hawaii"})
        Me.lstStates.Location = New System.Drawing.Point(13, 37)
        Me.lstStates.Margin = New System.Windows.Forms.Padding(4)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(132, 196)
        Me.lstStates.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(156, 158)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(183, 22)
        Me.txtOutput.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(173, 91)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(149, 44)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search for State"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'mtbFirstTwoLetters
        '
        Me.mtbFirstTwoLetters.Location = New System.Drawing.Point(288, 46)
        Me.mtbFirstTwoLetters.Margin = New System.Windows.Forms.Padding(4)
        Me.mtbFirstTwoLetters.Mask = "LL"
        Me.mtbFirstTwoLetters.Name = "mtbFirstTwoLetters"
        Me.mtbFirstTwoLetters.Size = New System.Drawing.Size(27, 22)
        Me.mtbFirstTwoLetters.TabIndex = 0
        '
        'lblFirstTwo
        '
        Me.lblFirstTwo.Location = New System.Drawing.Point(174, 36)
        Me.lblFirstTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstTwo.Name = "lblFirstTwo"
        Me.lblFirstTwo.Size = New System.Drawing.Size(103, 42)
        Me.lblFirstTwo.TabIndex = 4
        Me.lblFirstTwo.Text = "First two letters of state:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "States:"
        '
        'frmStates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 245)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFirstTwo)
        Me.Controls.Add(Me.mtbFirstTwoLetters)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lstStates)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Timer1 As Timer
End Class
