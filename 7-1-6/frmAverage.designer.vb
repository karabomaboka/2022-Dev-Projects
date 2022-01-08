<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverage
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
    Me.btnGet = New System.Windows.Forms.Button()
    Me.lblAverage = New System.Windows.Forms.Label()
    Me.txtAverage = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnGet
    '
    Me.btnGet.Location = New System.Drawing.Point(67, 6)
    Me.btnGet.Margin = New System.Windows.Forms.Padding(4)
    Me.btnGet.Name = "btnGet"
    Me.btnGet.Size = New System.Drawing.Size(273, 36)
    Me.btnGet.TabIndex = 0
    Me.btnGet.Text = "Get Grades and Calculate Average"
    Me.btnGet.UseVisualStyleBackColor = True
    '
    'lblAverage
    '
    Me.lblAverage.AutoSize = True
    Me.lblAverage.Location = New System.Drawing.Point(142, 51)
    Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblAverage.Name = "lblAverage"
    Me.lblAverage.Size = New System.Drawing.Size(65, 17)
    Me.lblAverage.TabIndex = 2
    Me.lblAverage.Text = "Average:"
    '
    'txtAverage
    '
    Me.txtAverage.Location = New System.Drawing.Point(211, 48)
    Me.txtAverage.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAverage.Name = "txtAverage"
    Me.txtAverage.ReadOnly = True
    Me.txtAverage.Size = New System.Drawing.Size(53, 22)
    Me.txtAverage.TabIndex = 3
    '
    'frmAverage
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(407, 75)
    Me.Controls.Add(Me.txtAverage)
    Me.Controls.Add(Me.lblAverage)
    Me.Controls.Add(Me.btnGet)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmAverage"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Determine Average Grade"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGet As System.Windows.Forms.Button
  Friend WithEvents lblAverage As System.Windows.Forms.Label
  Friend WithEvents txtAverage As System.Windows.Forms.TextBox

End Class
