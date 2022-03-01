Partial Public Class frmAverage
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
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(30, 10)
    Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(296, 36)
    Me.btnCalculate.TabIndex = 0
    Me.btnCalculate.Text = "Get Data and Determine Semester Average" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(16, 58)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = True
    Me.txtOutput.Size = New System.Drawing.Size(321, 22)
    Me.txtOutput.TabIndex = 1
    Me.txtOutput.Text = " "
    '
    'frmAverage
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(356, 95)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnCalculate)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmAverage"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Semester Average"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
