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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lstLastTen = New System.Windows.Forms.ListBox()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lstStates
    '
    Me.lstStates.FormattingEnabled = True
    Me.lstStates.ItemHeight = 16
    Me.lstStates.Items.AddRange(New Object() {"Delaware", "Pennsylvania", "New Jersey", "Georgia", "Connecticut", "Massachusetts", "Maryland", "South Carolina", "New Hampshire", "Virginia", "New York", "North Carolina", "Rhode Island", "Vermont", "Kentucky", "Tennessee", "Ohio", "Louisiana", "Indiana", "Mississippi", "Illinois", "Alabama", "Maine", "Montana", "Arkansas", "Michigan", "Florida", "Texas", "Iowa", "Wisconsin", "California", "Minnesota", "Oregon", "Kansas", "West Virginia", "Nevada", "Nebraska", "Colorado", "North Dakota", "South Dakota", "Montana", "Washington", "Idaho", "Wyoming", "Utah", "Oklahoma", "New Mexico", "Arizona", "Alaska", "Hawaii"})
    Me.lstStates.Location = New System.Drawing.Point(24, 37)
    Me.lstStates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstStates.Name = "lstStates"
    Me.lstStates.Size = New System.Drawing.Size(132, 196)
    Me.lstStates.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(24, 12)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(52, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "States:"
    '
    'lstLastTen
    '
    Me.lstLastTen.FormattingEnabled = True
    Me.lstLastTen.ItemHeight = 16
    Me.lstLastTen.Location = New System.Drawing.Point(181, 69)
    Me.lstLastTen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstLastTen.Name = "lstLastTen"
    Me.lstLastTen.Size = New System.Drawing.Size(99, 164)
    Me.lstLastTen.TabIndex = 3
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(181, 12)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(100, 47)
    Me.btnDisplay.TabIndex = 4
    Me.btnDisplay.Text = "Display Last Ten States"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'frmStates
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(307, 245)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lstLastTen)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstStates)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmStates"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "U.S. States"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstStates As System.Windows.Forms.ListBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lstLastTen As System.Windows.Forms.ListBox
  Friend WithEvents btnDisplay As System.Windows.Forms.Button


End Class
