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
    Me.components = New System.ComponentModel.Container()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lstCountries = New System.Windows.Forms.ListBox()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(56, 12)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(138, 62)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display Nations by Population"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'lstCountries
    '
    Me.lstCountries.FormattingEnabled = True
    Me.lstCountries.ItemHeight = 16
    Me.lstCountries.Location = New System.Drawing.Point(56, 85)
    Me.lstCountries.Name = "lstCountries"
    Me.lstCountries.Size = New System.Drawing.Size(138, 132)
    Me.lstCountries.TabIndex = 1
    '
    'frmCountry
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(250, 229)
    Me.Controls.Add(Me.lstCountries)
    Me.Controls.Add(Me.btnDisplay)
    Me.Name = "frmCountry"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "U.N."
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents btnDisplay As Button
  Friend WithEvents lstCountries As ListBox
  Friend WithEvents Timer1 As Timer
End Class
