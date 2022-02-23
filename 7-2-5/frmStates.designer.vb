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
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lstStates = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(98, 9)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(151, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display States"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'lstStates
    '
    Me.lstStates.FormattingEnabled = True
    Me.lstStates.ItemHeight = 16
    Me.lstStates.Location = New System.Drawing.Point(98, 53)
    Me.lstStates.Margin = New System.Windows.Forms.Padding(4)
    Me.lstStates.Name = "lstStates"
    Me.lstStates.Size = New System.Drawing.Size(149, 196)
    Me.lstStates.TabIndex = 1
    '
    'frmStates
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(347, 258)
    Me.Controls.Add(Me.lstStates)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmStates"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sorting with LINQ"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstStates As System.Windows.Forms.ListBox

End Class
