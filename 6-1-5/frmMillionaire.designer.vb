Partial Public Class frmMillionaire
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
    Me.lblAmount = New System.Windows.Forms.Label()
    Me.txtAmount = New System.Windows.Forms.TextBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtWhen = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblAmount
    '
    Me.lblAmount.AutoSize = True
    Me.lblAmount.Location = New System.Drawing.Point(25, 14)
    Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblAmount.Name = "lblAmount"
    Me.lblAmount.Size = New System.Drawing.Size(126, 17)
    Me.lblAmount.TabIndex = 0
    Me.lblAmount.Text = "Amount deposited:"
    '
    'txtAmount
    '
    Me.txtAmount.Location = New System.Drawing.Point(154, 11)
    Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAmount.Name = "txtAmount"
    Me.txtAmount.Size = New System.Drawing.Size(123, 22)
    Me.txtAmount.TabIndex = 1
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(16, 41)
    Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(271, 36)
    Me.btnCalculate.TabIndex = 2
    Me.btnCalculate.Text = "Calculate Years to Become a Millionaire"
    '
    'txtWhen
    '
    Me.txtWhen.Location = New System.Drawing.Point(16, 85)
    Me.txtWhen.Margin = New System.Windows.Forms.Padding(4)
    Me.txtWhen.Name = "txtWhen"
    Me.txtWhen.ReadOnly = True
    Me.txtWhen.Size = New System.Drawing.Size(269, 22)
    Me.txtWhen.TabIndex = 3
    '
    'frmMillionaire
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(302, 115)
    Me.Controls.Add(Me.txtWhen)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtAmount)
    Me.Controls.Add(Me.lblAmount)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmMillionaire"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "6% Interest"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAmount As System.Windows.Forms.Label
  Friend WithEvents txtAmount As System.Windows.Forms.TextBox
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents txtWhen As System.Windows.Forms.TextBox

End Class
