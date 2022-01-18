<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverage
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
    Me.SuspendLayout()
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(40, 24)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(116, 39)
    Me.btnCompute.TabIndex = 0
    Me.btnCompute.Text = "Determine Average of Numbers"
    Me.btnCompute.UseVisualStyleBackColor = True
    '
    'frmAverage
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(204, 97)
    Me.Controls.Add(Me.btnCompute)
    Me.Name = "frmAverage"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "6-1-3"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
