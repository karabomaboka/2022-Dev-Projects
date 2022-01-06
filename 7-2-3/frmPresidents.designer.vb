<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresidents
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
    Me.lstPres = New System.Windows.Forms.ListBox()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtFirstName = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lstPres
    '
    Me.lstPres.FormattingEnabled = True
    Me.lstPres.ItemHeight = 16
    Me.lstPres.Location = New System.Drawing.Point(44, 75)
    Me.lstPres.Margin = New System.Windows.Forms.Padding(4)
    Me.lstPres.Name = "lstPres"
    Me.lstPres.Size = New System.Drawing.Size(243, 100)
    Me.lstPres.TabIndex = 3
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(44, 33)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(244, 36)
    Me.btnDisplay.TabIndex = 2
    Me.btnDisplay.Text = "Display Presidents"
    Me.btnDisplay.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(49, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "First name:"
    '
    'txtFirstName
    '
    Me.txtFirstName.Location = New System.Drawing.Point(132, 6)
    Me.txtFirstName.Name = "txtFirstName"
    Me.txtFirstName.Size = New System.Drawing.Size(127, 22)
    Me.txtFirstName.TabIndex = 1
    '
    'frmPresidents
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(332, 182)
    Me.Controls.Add(Me.txtFirstName)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lstPres)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmPresidents"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "U.S. Presidents"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstPres As System.Windows.Forms.ListBox
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents Label1 As Label
  Friend WithEvents txtFirstName As TextBox
End Class
