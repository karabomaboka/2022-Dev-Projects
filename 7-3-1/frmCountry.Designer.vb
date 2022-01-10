<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountry
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
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.txtContinent = New System.Windows.Forms.TextBox()
    Me.txtPop = New System.Windows.Forms.TextBox()
    Me.txtArea = New System.Windows.Forms.TextBox()
    Me.lblName = New System.Windows.Forms.Label()
    Me.lblContinent = New System.Windows.Forms.Label()
    Me.lblPop = New System.Windows.Forms.Label()
    Me.lblArea = New System.Windows.Forms.Label()
    Me.txtDensity = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(51, 8)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(173, 29)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Data"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(106, 47)
    Me.txtName.Name = "txtName"
    Me.txtName.ReadOnly = True
    Me.txtName.Size = New System.Drawing.Size(155, 20)
    Me.txtName.TabIndex = 1
    '
    'txtContinent
    '
    Me.txtContinent.Location = New System.Drawing.Point(106, 77)
    Me.txtContinent.Name = "txtContinent"
    Me.txtContinent.ReadOnly = True
    Me.txtContinent.Size = New System.Drawing.Size(155, 20)
    Me.txtContinent.TabIndex = 2
    '
    'txtPop
    '
    Me.txtPop.Location = New System.Drawing.Point(106, 107)
    Me.txtPop.Name = "txtPop"
    Me.txtPop.ReadOnly = True
    Me.txtPop.Size = New System.Drawing.Size(155, 20)
    Me.txtPop.TabIndex = 3
    '
    'txtArea
    '
    Me.txtArea.Location = New System.Drawing.Point(106, 137)
    Me.txtArea.Name = "txtArea"
    Me.txtArea.ReadOnly = True
    Me.txtArea.Size = New System.Drawing.Size(155, 20)
    Me.txtArea.TabIndex = 4
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(12, 51)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(88, 13)
    Me.lblName.TabIndex = 5
    Me.lblName.Text = "Name of country:"
    '
    'lblContinent
    '
    Me.lblContinent.AutoSize = True
    Me.lblContinent.Location = New System.Drawing.Point(45, 81)
    Me.lblContinent.Name = "lblContinent"
    Me.lblContinent.Size = New System.Drawing.Size(55, 13)
    Me.lblContinent.TabIndex = 6
    Me.lblContinent.Text = "Continent:"
    '
    'lblPop
    '
    Me.lblPop.AutoSize = True
    Me.lblPop.Location = New System.Drawing.Point(40, 111)
    Me.lblPop.Name = "lblPop"
    Me.lblPop.Size = New System.Drawing.Size(60, 13)
    Me.lblPop.TabIndex = 7
    Me.lblPop.Text = "Population:"
    '
    'lblArea
    '
    Me.lblArea.AutoSize = True
    Me.lblArea.Location = New System.Drawing.Point(68, 141)
    Me.lblArea.Name = "lblArea"
    Me.lblArea.Size = New System.Drawing.Size(32, 13)
    Me.lblArea.TabIndex = 8
    Me.lblArea.Text = "Area:"
    '
    'txtDensity
    '
    Me.txtDensity.Location = New System.Drawing.Point(107, 167)
    Me.txtDensity.Name = "txtDensity"
    Me.txtDensity.ReadOnly = True
    Me.txtDensity.Size = New System.Drawing.Size(155, 20)
    Me.txtDensity.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(55, 171)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Density:"
    '
    'frmCountry
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(274, 195)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtDensity)
    Me.Controls.Add(Me.lblArea)
    Me.Controls.Add(Me.lblPop)
    Me.Controls.Add(Me.lblContinent)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.txtArea)
    Me.Controls.Add(Me.txtPop)
    Me.Controls.Add(Me.txtContinent)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.btnDisplay)
    Me.Name = "frmCountry"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Country Data"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtContinent As System.Windows.Forms.TextBox
  Friend WithEvents txtPop As System.Windows.Forms.TextBox
  Friend WithEvents txtArea As System.Windows.Forms.TextBox
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblContinent As System.Windows.Forms.Label
  Friend WithEvents lblPop As System.Windows.Forms.Label
  Friend WithEvents lblArea As System.Windows.Forms.Label
  Friend WithEvents txtDensity As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
