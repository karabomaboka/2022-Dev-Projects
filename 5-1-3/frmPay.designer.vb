Partial Public Class frmPay
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

  Friend WithEvents lblWage As System.Windows.Forms.Label
  Friend WithEvents lblHours As System.Windows.Forms.Label
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents lblEarnings As System.Windows.Forms.Label
  Friend WithEvents txtEarnings As System.Windows.Forms.TextBox

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.lblHours = New System.Windows.Forms.Label()
    Me.txtEarnings = New System.Windows.Forms.TextBox()
    Me.lblWage = New System.Windows.Forms.Label()
    Me.lblEarnings = New System.Windows.Forms.Label()
    Me.txtWage = New System.Windows.Forms.TextBox()
    Me.txtHours = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(16, 89)
    Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(228, 36)
    Me.btnCalculate.TabIndex = 4
    Me.btnCalculate.Text = "Calculate Earnings for the Week"
    '
    'lblHours
    '
    Me.lblHours.AutoSize = True
    Me.lblHours.Location = New System.Drawing.Point(21, 57)
    Me.lblHours.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblHours.Name = "lblHours"
    Me.lblHours.Size = New System.Drawing.Size(99, 17)
    Me.lblHours.TabIndex = 2
    Me.lblHours.Text = "Hours worked:"
    '
    'txtEarnings
    '
    Me.txtEarnings.Location = New System.Drawing.Point(127, 138)
    Me.txtEarnings.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtEarnings.Name = "txtEarnings"
    Me.txtEarnings.ReadOnly = True
    Me.txtEarnings.Size = New System.Drawing.Size(103, 22)
    Me.txtEarnings.TabIndex = 6
    '
    'lblWage
    '
    Me.lblWage.AutoSize = True
    Me.lblWage.Location = New System.Drawing.Point(31, 18)
    Me.lblWage.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblWage.Name = "lblWage"
    Me.lblWage.Size = New System.Drawing.Size(90, 17)
    Me.lblWage.TabIndex = 0
    Me.lblWage.Text = "Hourly wage:"
    '
    'lblEarnings
    '
    Me.lblEarnings.AutoSize = True
    Me.lblEarnings.Location = New System.Drawing.Point(55, 142)
    Me.lblEarnings.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblEarnings.Name = "lblEarnings"
    Me.lblEarnings.Size = New System.Drawing.Size(68, 17)
    Me.lblEarnings.TabIndex = 5
    Me.lblEarnings.Text = "Earnings:"
    '
    'txtWage
    '
    Me.txtWage.Location = New System.Drawing.Point(127, 15)
    Me.txtWage.Margin = New System.Windows.Forms.Padding(4)
    Me.txtWage.Name = "txtWage"
    Me.txtWage.Size = New System.Drawing.Size(103, 22)
    Me.txtWage.TabIndex = 1
    '
    'txtHours
    '
    Me.txtHours.Location = New System.Drawing.Point(127, 53)
    Me.txtHours.Margin = New System.Windows.Forms.Padding(4)
    Me.txtHours.Name = "txtHours"
    Me.txtHours.Size = New System.Drawing.Size(103, 22)
    Me.txtHours.TabIndex = 3
    '
    'frmPay
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(260, 172)
    Me.Controls.Add(Me.txtHours)
    Me.Controls.Add(Me.txtWage)
    Me.Controls.Add(Me.txtEarnings)
    Me.Controls.Add(Me.lblEarnings)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.lblHours)
    Me.Controls.Add(Me.lblWage)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmPay"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Pay"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtWage As System.Windows.Forms.TextBox
  Friend WithEvents txtHours As System.Windows.Forms.TextBox
  Private components As System.ComponentModel.IContainer

End Class
