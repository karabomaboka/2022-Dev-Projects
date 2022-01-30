Partial Public Class frmDemo
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

  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstResults As System.Windows.Forms.ListBox

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.Container

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.lstResults = New System.Windows.Forms.ListBox()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lstResults
    '
    Me.lstResults.ItemHeight = 16
    Me.lstResults.Location = New System.Drawing.Point(46, 59)
    Me.lstResults.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lstResults.Name = "lstResults"
    Me.lstResults.Size = New System.Drawing.Size(189, 84)
    Me.lstResults.TabIndex = 1
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(45, 10)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(192, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Results"
    '
    'frmDemo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 154)
    Me.Controls.Add(Me.lstResults)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmDemo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "5-3-1"
    Me.ResumeLayout(False)

  End Sub

End Class
