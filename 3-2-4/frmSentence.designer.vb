Partial Public Class frmSentence
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.btnDisplay = New System.Windows.Forms.Button
    Me.txtOutput = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(13, 12)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(177, 34)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Sentence"
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(13, 52)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = True
    Me.txtOutput.Size = New System.Drawing.Size(177, 20)
    Me.txtOutput.TabIndex = 1
    '
    'frmSentence
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(203, 85)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnDisplay)
    Me.Name = "frmSentence"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "3-2-4"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
