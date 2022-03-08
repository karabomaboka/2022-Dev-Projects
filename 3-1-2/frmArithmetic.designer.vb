Partial Public Class frmArithmetic
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

  Friend WithEvents lstResults As System.Windows.Forms.ListBox
  Friend WithEvents btnCompute As System.Windows.Forms.Button

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.Container

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(71, 140)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(141, 36)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(71, 15)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(137, 116)
        Me.lstResults.TabIndex = 0
        '
        'frmArithmetic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 183)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lstResults)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmArithmetic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3-1-2"
        Me.ResumeLayout(False)

    End Sub

End Class
