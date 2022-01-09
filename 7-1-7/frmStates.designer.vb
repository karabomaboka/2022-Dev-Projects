<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStates
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtState = New System.Windows.Forms.TextBox()
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(41, 10)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(84, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "State name:"
    '
    'txtState
    '
    Me.txtState.Location = New System.Drawing.Point(129, 7)
    Me.txtState.Margin = New System.Windows.Forms.Padding(4)
    Me.txtState.Name = "txtState"
    Me.txtState.Size = New System.Drawing.Size(132, 22)
    Me.txtState.TabIndex = 1
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(41, 39)
    Me.btnDetermine.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(221, 36)
    Me.btnDetermine.TabIndex = 2
    Me.btnDetermine.Text = "Determine Order"
    Me.btnDetermine.UseVisualStyleBackColor = True
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(19, 82)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = True
    Me.txtOutput.Size = New System.Drawing.Size(264, 22)
    Me.txtOutput.TabIndex = 3
    '
    'frmStates
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(302, 115)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnDetermine)
    Me.Controls.Add(Me.txtState)
    Me.Controls.Add(Me.Label1)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmStates"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "U.S. States"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtState As System.Windows.Forms.TextBox
  Friend WithEvents btnDetermine As System.Windows.Forms.Button
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
