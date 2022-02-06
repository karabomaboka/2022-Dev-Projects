Partial Public Class frmIndex
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
    Me.lblN = New System.Windows.Forms.Label()
    Me.lblS = New System.Windows.Forms.Label()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lstValues = New System.Windows.Forms.ListBox()
    Me.txtStep = New System.Windows.Forms.TextBox()
    Me.txtEnd = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblN
    '
    Me.lblN.AutoSize = True
    Me.lblN.Location = New System.Drawing.Point(74, 11)
    Me.lblN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblN.Name = "lblN"
    Me.lblN.Size = New System.Drawing.Size(20, 17)
    Me.lblN.TabIndex = 0
    Me.lblN.Text = "n:"
    '
    'lblS
    '
    Me.lblS.AutoSize = True
    Me.lblS.Location = New System.Drawing.Point(178, 10)
    Me.lblS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblS.Name = "lblS"
    Me.lblS.Size = New System.Drawing.Size(19, 17)
    Me.lblS.TabIndex = 2
    Me.lblS.Text = "s:"
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(45, 36)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(222, 36)
    Me.btnDisplay.TabIndex = 4
    Me.btnDisplay.Text = "Display Values of Index"
    '
    'lstValues
    '
    Me.lstValues.FormattingEnabled = True
    Me.lstValues.ItemHeight = 16
    Me.lstValues.Location = New System.Drawing.Point(74, 81)
    Me.lstValues.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lstValues.Name = "lstValues"
    Me.lstValues.Size = New System.Drawing.Size(165, 100)
    Me.lstValues.TabIndex = 5
    '
    'txtStep
    '
    Me.txtStep.Location = New System.Drawing.Point(198, 7)
    Me.txtStep.Margin = New System.Windows.Forms.Padding(4)
    Me.txtStep.Name = "txtStep"
    Me.txtStep.Size = New System.Drawing.Size(41, 22)
    Me.txtStep.TabIndex = 3
    '
    'txtEnd
    '
    Me.txtEnd.Location = New System.Drawing.Point(93, 7)
    Me.txtEnd.Margin = New System.Windows.Forms.Padding(4)
    Me.txtEnd.Name = "txtEnd"
    Me.txtEnd.Size = New System.Drawing.Size(41, 22)
    Me.txtEnd.TabIndex = 1
    '
    'frmIndex
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(312, 199)
    Me.Controls.Add(Me.txtEnd)
    Me.Controls.Add(Me.txtStep)
    Me.Controls.Add(Me.lstValues)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lblS)
    Me.Controls.Add(Me.lblN)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmIndex"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Index Values"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblN As System.Windows.Forms.Label
  Friend WithEvents lblS As System.Windows.Forms.Label
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstValues As System.Windows.Forms.ListBox
  Friend WithEvents txtStep As System.Windows.Forms.TextBox
  Friend WithEvents txtEnd As System.Windows.Forms.TextBox

End Class
