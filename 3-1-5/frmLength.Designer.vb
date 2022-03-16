<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLength
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(108, 15)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(127, 36)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(108, 63)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(125, 68)
        Me.lstResults.TabIndex = 1
        '
        'frmLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 143)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnCompute)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLength"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert a Length"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompute As System.Windows.Forms.Button
  Friend WithEvents lstResults As System.Windows.Forms.ListBox

End Class
