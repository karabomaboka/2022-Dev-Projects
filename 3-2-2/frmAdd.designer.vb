Partial Public Class frmAdd
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

  Friend WithEvents txtFirstNum As System.Windows.Forms.TextBox
  Friend WithEvents txtSecondNum As System.Windows.Forms.TextBox
  Friend WithEvents btnCompute As System.Windows.Forms.Button
  Friend WithEvents lblSecondNum As System.Windows.Forms.Label
  Friend WithEvents lblSum As System.Windows.Forms.Label
  Friend WithEvents txtSum As System.Windows.Forms.TextBox
  Friend WithEvents lblFirstNum As System.Windows.Forms.Label

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.lblSecondNum = New System.Windows.Forms.Label()
    Me.lblSum = New System.Windows.Forms.Label()
    Me.txtSum = New System.Windows.Forms.TextBox()
    Me.btnCompute = New System.Windows.Forms.Button()
    Me.lblFirstNum = New System.Windows.Forms.Label()
    Me.txtSecondNum = New System.Windows.Forms.TextBox()
    Me.txtFirstNum = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblSecondNum
    '
    Me.lblSecondNum.AutoSize = True
    Me.lblSecondNum.Location = New System.Drawing.Point(22, 44)
    Me.lblSecondNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblSecondNum.Name = "lblSecondNum"
    Me.lblSecondNum.Size = New System.Drawing.Size(112, 17)
    Me.lblSecondNum.TabIndex = 4
    Me.lblSecondNum.Text = "Second number:"
    '
    'lblSum
    '
    Me.lblSum.AutoSize = True
    Me.lblSum.Location = New System.Drawing.Point(94, 119)
    Me.lblSum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblSum.Name = "lblSum"
    Me.lblSum.Size = New System.Drawing.Size(40, 17)
    Me.lblSum.TabIndex = 5
    Me.lblSum.Text = "Sum:"
    '
    'txtSum
    '
    Me.txtSum.Location = New System.Drawing.Point(136, 115)
    Me.txtSum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtSum.Name = "txtSum"
    Me.txtSum.ReadOnly = True
    Me.txtSum.Size = New System.Drawing.Size(125, 22)
    Me.txtSum.TabIndex = 6
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(75, 71)
    Me.btnCompute.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(167, 36)
    Me.btnCompute.TabIndex = 2
    Me.btnCompute.Text = "Compute Sum"
    '
    'lblFirstNum
    '
    Me.lblFirstNum.AutoSize = True
    Me.lblFirstNum.Location = New System.Drawing.Point(43, 14)
    Me.lblFirstNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblFirstNum.Name = "lblFirstNum"
    Me.lblFirstNum.Size = New System.Drawing.Size(91, 17)
    Me.lblFirstNum.TabIndex = 3
    Me.lblFirstNum.Text = "First number:"
    '
    'txtSecondNum
    '
    Me.txtSecondNum.Location = New System.Drawing.Point(136, 41)
    Me.txtSecondNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtSecondNum.Name = "txtSecondNum"
    Me.txtSecondNum.Size = New System.Drawing.Size(125, 22)
    Me.txtSecondNum.TabIndex = 1
    '
    'txtFirstNum
    '
    Me.txtFirstNum.Location = New System.Drawing.Point(136, 11)
    Me.txtFirstNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtFirstNum.Name = "txtFirstNum"
    Me.txtFirstNum.Size = New System.Drawing.Size(125, 22)
    Me.txtFirstNum.TabIndex = 0
    '
    'frmAdd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 145)
    Me.Controls.Add(Me.txtSum)
    Me.Controls.Add(Me.lblSum)
    Me.Controls.Add(Me.lblSecondNum)
    Me.Controls.Add(Me.lblFirstNum)
    Me.Controls.Add(Me.btnCompute)
    Me.Controls.Add(Me.txtSecondNum)
    Me.Controls.Add(Me.txtFirstNum)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmAdd"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Addition"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private components As System.ComponentModel.IContainer

End Class
