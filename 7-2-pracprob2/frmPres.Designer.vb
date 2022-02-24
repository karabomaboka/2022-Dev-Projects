<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPres
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
    Me.btnFind = New System.Windows.Forms.Button()
    Me.txtFullName = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnFind
    '
    Me.btnFind.Location = New System.Drawing.Point(104, 15)
    Me.btnFind.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnFind.Name = "btnFind"
    Me.btnFind.Size = New System.Drawing.Size(185, 55)
    Me.btnFind.TabIndex = 0
    Me.btnFind.Text = "Find Full Name of President Eisenhower"
    Me.btnFind.UseVisualStyleBackColor = True
    '
    'txtFullName
    '
    Me.txtFullName.Location = New System.Drawing.Point(78, 82)
    Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtFullName.Name = "txtFullName"
    Me.txtFullName.Size = New System.Drawing.Size(233, 22)
    Me.txtFullName.TabIndex = 1
    '
    'frmPres
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(388, 127)
    Me.Controls.Add(Me.txtFullName)
    Me.Controls.Add(Me.btnFind)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "frmPres"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "President's Full Name"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnFind As System.Windows.Forms.Button
  Friend WithEvents txtFullName As System.Windows.Forms.TextBox

End Class
