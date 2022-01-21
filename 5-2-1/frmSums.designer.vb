<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSums
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
    Me.btnAddNumbers = New System.Windows.Forms.Button()
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnAddNumbers
    '
    Me.btnAddNumbers.Location = New System.Drawing.Point(33, 10)
    Me.btnAddNumbers.Margin = New System.Windows.Forms.Padding(4)
    Me.btnAddNumbers.Name = "btnAddNumbers"
    Me.btnAddNumbers.Size = New System.Drawing.Size(217, 36)
    Me.btnAddNumbers.TabIndex = 0
    Me.btnAddNumbers.Text = "Display Three Sums"
    Me.btnAddNumbers.UseVisualStyleBackColor = True
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = True
    Me.lstOutput.ItemHeight = 16
    Me.lstOutput.Location = New System.Drawing.Point(33, 55)
    Me.lstOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(216, 52)
    Me.lstOutput.TabIndex = 1
    '
    'frmSums
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 114)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.btnAddNumbers)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmSums"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sums"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAddNumbers As System.Windows.Forms.Button
  Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
