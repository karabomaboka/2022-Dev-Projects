<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDensities
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
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(58, 7)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(241, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Density"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = True
    Me.lstOutput.ItemHeight = 16
    Me.lstOutput.Location = New System.Drawing.Point(58, 52)
    Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(240, 100)
    Me.lstOutput.TabIndex = 1
    '
    'frmDensities
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(357, 160)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmDensities"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Density of a State"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
