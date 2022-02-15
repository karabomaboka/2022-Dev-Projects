Partial Public Class frmBowl
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
    Me.lblNumber = New System.Windows.Forms.Label()
    Me.mtbNumber = New System.Windows.Forms.MaskedTextBox()
    Me.btnWhoWon = New System.Windows.Forms.Button()
    Me.lblWinner = New System.Windows.Forms.Label()
    Me.txtWinner = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblNumber
    '
    Me.lblNumber.AutoSize = True
    Me.lblNumber.Location = New System.Drawing.Point(11, 16)
    Me.lblNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblNumber.Name = "lblNumber"
    Me.lblNumber.Size = New System.Drawing.Size(134, 17)
    Me.lblNumber.TabIndex = 0
    Me.lblNumber.Text = "Number from 1 to 4:"
    '
    'mtbNumber
    '
    Me.mtbNumber.Location = New System.Drawing.Point(148, 12)
    Me.mtbNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.mtbNumber.Mask = "0"
    Me.mtbNumber.Name = "mtbNumber"
    Me.mtbNumber.Size = New System.Drawing.Size(35, 22)
    Me.mtbNumber.TabIndex = 1
    '
    'btnWhoWon
    '
    Me.btnWhoWon.Location = New System.Drawing.Point(205, 6)
    Me.btnWhoWon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnWhoWon.Name = "btnWhoWon"
    Me.btnWhoWon.Size = New System.Drawing.Size(103, 36)
    Me.btnWhoWon.TabIndex = 2
    Me.btnWhoWon.Text = "Who Won?"
    '
    'lblWinner
    '
    Me.lblWinner.AutoSize = True
    Me.lblWinner.Location = New System.Drawing.Point(67, 65)
    Me.lblWinner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblWinner.Name = "lblWinner"
    Me.lblWinner.Size = New System.Drawing.Size(98, 17)
    Me.lblWinner.TabIndex = 3
    Me.lblWinner.Text = "Winning team:"
    '
    'txtWinner
    '
    Me.txtWinner.Location = New System.Drawing.Point(172, 62)
    Me.txtWinner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtWinner.Name = "txtWinner"
    Me.txtWinner.ReadOnly = True
    Me.txtWinner.Size = New System.Drawing.Size(83, 22)
    Me.txtWinner.TabIndex = 4
    '
    'frmBowl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(324, 102)
    Me.Controls.Add(Me.txtWinner)
    Me.Controls.Add(Me.lblWinner)
    Me.Controls.Add(Me.btnWhoWon)
    Me.Controls.Add(Me.mtbNumber)
    Me.Controls.Add(Me.lblNumber)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmBowl"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Super Bowl"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblNumber As System.Windows.Forms.Label
  Friend WithEvents mtbNumber As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnWhoWon As System.Windows.Forms.Button
  Friend WithEvents lblWinner As System.Windows.Forms.Label
  Friend WithEvents txtWinner As System.Windows.Forms.TextBox

End Class
