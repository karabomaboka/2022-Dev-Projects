<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProps_Methods
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
    Me.lstValues = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(124, 12)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(249, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Values"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'lstValues
    '
    Me.lstValues.FormattingEnabled = True
    Me.lstValues.ItemHeight = 16
    Me.lstValues.Location = New System.Drawing.Point(124, 55)
    Me.lstValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstValues.Name = "lstValues"
    Me.lstValues.Size = New System.Drawing.Size(248, 116)
    Me.lstValues.TabIndex = 1
    '
    'frmProps_Methods
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(496, 185)
    Me.Controls.Add(Me.lstValues)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmProps_Methods"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Presidential Ages at Inauguration"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstValues As System.Windows.Forms.ListBox

End Class
