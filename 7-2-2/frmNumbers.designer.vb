<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
    Me.lstBox = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(48, 11)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(207, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Numbers"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'lstBox
    '
    Me.lstBox.FormattingEnabled = True
    Me.lstBox.ItemHeight = 16
    Me.lstBox.Location = New System.Drawing.Point(49, 57)
    Me.lstBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstBox.Name = "lstBox"
    Me.lstBox.Size = New System.Drawing.Size(204, 164)
    Me.lstBox.TabIndex = 1
    '
    'frmNumbers
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(302, 228)
    Me.Controls.Add(Me.lstBox)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmNumbers"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Numbers"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstBox As System.Windows.Forms.ListBox

End Class
