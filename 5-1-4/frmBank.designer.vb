Partial Public Class frmBank
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

  Friend WithEvents lblAmount As System.Windows.Forms.Label
  Friend WithEvents lblRate As System.Windows.Forms.Label
  Friend WithEvents lblNumComp As System.Windows.Forms.Label
  Friend WithEvents lblNumYears As System.Windows.Forms.Label
  Friend WithEvents lblBalance As System.Windows.Forms.Label
  Friend WithEvents btnCompute As System.Windows.Forms.Button

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.btnCompute = New System.Windows.Forms.Button()
    Me.lblNumComp = New System.Windows.Forms.Label()
    Me.lblRate = New System.Windows.Forms.Label()
    Me.lblAmount = New System.Windows.Forms.Label()
    Me.lblNumYears = New System.Windows.Forms.Label()
    Me.lblBalance = New System.Windows.Forms.Label()
    Me.txtBalance = New System.Windows.Forms.TextBox()
    Me.txtAmount = New System.Windows.Forms.TextBox()
    Me.txtRate = New System.Windows.Forms.TextBox()
    Me.txtNumComp = New System.Windows.Forms.TextBox()
    Me.txtNumYrs = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(41, 183)
    Me.btnCompute.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(189, 37)
    Me.btnCompute.TabIndex = 8
    Me.btnCompute.Text = "Compute Balance"
    '
    'lblNumComp
    '
    Me.lblNumComp.Location = New System.Drawing.Point(12, 92)
    Me.lblNumComp.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblNumComp.Name = "lblNumComp"
    Me.lblNumComp.Size = New System.Drawing.Size(165, 39)
    Me.lblNumComp.TabIndex = 4
    Me.lblNumComp.Text = "Number of times interest is compounded per year:"
    '
    'lblRate
    '
    Me.lblRate.AutoSize = True
    Me.lblRate.Location = New System.Drawing.Point(24, 57)
    Me.lblRate.Margin = New System.Windows.Forms.Padding(5, 4, 1, 4)
    Me.lblRate.Name = "lblRate"
    Me.lblRate.Size = New System.Drawing.Size(152, 17)
    Me.lblRate.TabIndex = 2
    Me.lblRate.Text = "Annual rate of interest:"
    '
    'lblAmount
    '
    Me.lblAmount.AutoSize = True
    Me.lblAmount.Location = New System.Drawing.Point(17, 14)
    Me.lblAmount.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblAmount.Name = "lblAmount"
    Me.lblAmount.Size = New System.Drawing.Size(161, 17)
    Me.lblAmount.TabIndex = 0
    Me.lblAmount.Text = "Amount of bank deposit:"
    '
    'lblNumYears
    '
    Me.lblNumYears.AutoSize = True
    Me.lblNumYears.Location = New System.Drawing.Point(59, 148)
    Me.lblNumYears.Margin = New System.Windows.Forms.Padding(5, 4, 1, 4)
    Me.lblNumYears.Name = "lblNumYears"
    Me.lblNumYears.Size = New System.Drawing.Size(117, 17)
    Me.lblNumYears.TabIndex = 6
    Me.lblNumYears.Text = "Number of years:"
    '
    'lblBalance
    '
    Me.lblBalance.AutoSize = True
    Me.lblBalance.Location = New System.Drawing.Point(29, 233)
    Me.lblBalance.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblBalance.Name = "lblBalance"
    Me.lblBalance.Size = New System.Drawing.Size(63, 17)
    Me.lblBalance.TabIndex = 9
    Me.lblBalance.Text = "Balance:"
    '
    'txtBalance
    '
    Me.txtBalance.Location = New System.Drawing.Point(101, 228)
    Me.txtBalance.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtBalance.Name = "txtBalance"
    Me.txtBalance.ReadOnly = True
    Me.txtBalance.Size = New System.Drawing.Size(151, 22)
    Me.txtBalance.TabIndex = 10
    '
    'txtAmount
    '
    Me.txtAmount.Location = New System.Drawing.Point(181, 14)
    Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAmount.Name = "txtAmount"
    Me.txtAmount.Size = New System.Drawing.Size(71, 22)
    Me.txtAmount.TabIndex = 1
    '
    'txtRate
    '
    Me.txtRate.Location = New System.Drawing.Point(181, 58)
    Me.txtRate.Margin = New System.Windows.Forms.Padding(4)
    Me.txtRate.Name = "txtRate"
    Me.txtRate.Size = New System.Drawing.Size(71, 22)
    Me.txtRate.TabIndex = 3
    '
    'txtNumComp
    '
    Me.txtNumComp.Location = New System.Drawing.Point(181, 102)
    Me.txtNumComp.Margin = New System.Windows.Forms.Padding(4)
    Me.txtNumComp.Name = "txtNumComp"
    Me.txtNumComp.Size = New System.Drawing.Size(71, 22)
    Me.txtNumComp.TabIndex = 5
    '
    'txtNumYrs
    '
    Me.txtNumYrs.Location = New System.Drawing.Point(181, 146)
    Me.txtNumYrs.Margin = New System.Windows.Forms.Padding(4)
    Me.txtNumYrs.Name = "txtNumYrs"
    Me.txtNumYrs.Size = New System.Drawing.Size(71, 22)
    Me.txtNumYrs.TabIndex = 7
    '
    'frmBank
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(272, 267)
    Me.Controls.Add(Me.txtNumYrs)
    Me.Controls.Add(Me.txtNumComp)
    Me.Controls.Add(Me.txtRate)
    Me.Controls.Add(Me.txtAmount)
    Me.Controls.Add(Me.txtBalance)
    Me.Controls.Add(Me.lblBalance)
    Me.Controls.Add(Me.lblNumYears)
    Me.Controls.Add(Me.lblNumComp)
    Me.Controls.Add(Me.lblRate)
    Me.Controls.Add(Me.lblAmount)
    Me.Controls.Add(Me.btnCompute)
    Me.Location = New System.Drawing.Point(13, 13)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmBank"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Bank"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtBalance As System.Windows.Forms.TextBox
  Friend WithEvents txtAmount As System.Windows.Forms.TextBox
  Friend WithEvents txtRate As System.Windows.Forms.TextBox
  Friend WithEvents txtNumComp As System.Windows.Forms.TextBox
  Friend WithEvents txtNumYrs As System.Windows.Forms.TextBox
  Private components As System.ComponentModel.IContainer

End Class
