<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
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
    Me.btnSort = New System.Windows.Forms.Button()
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnSort
    '
    Me.btnSort.Location = New System.Drawing.Point(83, 10)
    Me.btnSort.Margin = New System.Windows.Forms.Padding(4)
    Me.btnSort.Name = "btnSort"
    Me.btnSort.Size = New System.Drawing.Size(180, 36)
    Me.btnSort.TabIndex = 0
    Me.btnSort.Text = "Sort Numbers"
    Me.btnSort.UseVisualStyleBackColor = True
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = True
    Me.lstOutput.ItemHeight = 16
    Me.lstOutput.Location = New System.Drawing.Point(128, 57)
    Me.lstOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(84, 68)
    Me.lstOutput.TabIndex = 1
    '
    'frmSort
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(347, 134)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.btnSort)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmSort"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sorting with LINQ"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnSort As System.Windows.Forms.Button
  Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
