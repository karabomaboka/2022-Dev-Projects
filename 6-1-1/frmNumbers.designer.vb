Partial Public Class frmNumbers
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
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lstNumbers = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(61, 15)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(160, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Numbers"
    '
    'lstNumbers
    '
    Me.lstNumbers.FormattingEnabled = True
    Me.lstNumbers.ItemHeight = 16
    Me.lstNumbers.Location = New System.Drawing.Point(61, 69)
    Me.lstNumbers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstNumbers.Name = "lstNumbers"
    Me.lstNumbers.Size = New System.Drawing.Size(159, 116)
    Me.lstNumbers.TabIndex = 1
    '
    'frmNumbers
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 199)
    Me.Controls.Add(Me.lstNumbers)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmNumbers"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "6-1-1"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstNumbers As System.Windows.Forms.ListBox

End Class
