Partial Public Class frmEvaluate
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
    Me.lstResults = New System.Windows.Forms.ListBox
    Me.btnEvaluate = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lstResults
    '
    Me.lstResults.FormattingEnabled = True
    Me.lstResults.Location = New System.Drawing.Point(13, 13)
    Me.lstResults.Name = "lstResults"
    Me.lstResults.Size = New System.Drawing.Size(178, 95)
    Me.lstResults.TabIndex = 0
    '
    'btnEvaluate
    '
    Me.btnEvaluate.Location = New System.Drawing.Point(13, 114)
    Me.btnEvaluate.Name = "btnEvaluate"
    Me.btnEvaluate.Size = New System.Drawing.Size(178, 31)
    Me.btnEvaluate.TabIndex = 1
    Me.btnEvaluate.Text = "Evaluate Expressions"
    '
    'frmEvaluate
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(206, 154)
    Me.Controls.Add(Me.btnEvaluate)
    Me.Controls.Add(Me.lstResults)
    Me.Name = "frmEvaluate"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "3-2-5"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstResults As System.Windows.Forms.ListBox
  Friend WithEvents btnEvaluate As System.Windows.Forms.Button

End Class
