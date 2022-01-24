Partial Public Class frmConvert
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

  Friend WithEvents txtTempC As System.Windows.Forms.TextBox
  Friend WithEvents btnConvert As System.Windows.Forms.Button
  Friend WithEvents lblTempF As System.Windows.Forms.Label

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.lblTempF = New System.Windows.Forms.Label()
    Me.txtTempC = New System.Windows.Forms.TextBox()
    Me.lblTempC = New System.Windows.Forms.Label()
    Me.txtTempF = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnConvert
    '
    Me.btnConvert.Location = New System.Drawing.Point(56, 39)
    Me.btnConvert.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.Size = New System.Drawing.Size(204, 36)
    Me.btnConvert.TabIndex = 2
    Me.btnConvert.Text = "Convert to Celsius"
    '
    'lblTempF
    '
    Me.lblTempF.AutoSize = True
    Me.lblTempF.Location = New System.Drawing.Point(32, 11)
    Me.lblTempF.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblTempF.Name = "lblTempF"
    Me.lblTempF.Size = New System.Drawing.Size(176, 17)
    Me.lblTempF.TabIndex = 0
    Me.lblTempF.Text = "Temperature (Fahrenheit):"
    Me.lblTempF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txtTempC
    '
    Me.txtTempC.Location = New System.Drawing.Point(209, 84)
    Me.txtTempC.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtTempC.Name = "txtTempC"
    Me.txtTempC.ReadOnly = True
    Me.txtTempC.Size = New System.Drawing.Size(75, 22)
    Me.txtTempC.TabIndex = 4
    '
    'lblTempC
    '
    Me.lblTempC.AutoSize = True
    Me.lblTempC.Location = New System.Drawing.Point(55, 88)
    Me.lblTempC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblTempC.Name = "lblTempC"
    Me.lblTempC.Size = New System.Drawing.Size(153, 17)
    Me.lblTempC.TabIndex = 3
    Me.lblTempC.Text = "Temperature (Celsius):"
    '
    'txtTempF
    '
    Me.txtTempF.Location = New System.Drawing.Point(209, 8)
    Me.txtTempF.Margin = New System.Windows.Forms.Padding(4)
    Me.txtTempF.Name = "txtTempF"
    Me.txtTempF.Size = New System.Drawing.Size(75, 22)
    Me.txtTempF.TabIndex = 1
    '
    'frmConvert
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(317, 115)
    Me.Controls.Add(Me.txtTempF)
    Me.Controls.Add(Me.lblTempC)
    Me.Controls.Add(Me.lblTempF)
    Me.Controls.Add(Me.txtTempC)
    Me.Controls.Add(Me.btnConvert)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmConvert"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " Temperature"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblTempC As System.Windows.Forms.Label
  Friend WithEvents txtTempF As System.Windows.Forms.TextBox
  Private components As System.ComponentModel.IContainer

End Class
