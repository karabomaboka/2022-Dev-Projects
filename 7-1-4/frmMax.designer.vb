<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMax
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
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(82, 13)
    Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(219, 36)
    Me.btnCalculate.TabIndex = 0
    Me.btnCalculate.Text = "Calculate Maximum"
    Me.btnCalculate.UseVisualStyleBackColor = True
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(82, 57)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.Size = New System.Drawing.Size(217, 22)
    Me.txtOutput.TabIndex = 1
    '
    'frmMax
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(382, 90)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnCalculate)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmMax"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Maximum via a Loop"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
