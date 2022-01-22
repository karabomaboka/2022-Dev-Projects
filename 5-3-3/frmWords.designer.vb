<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWords
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtFirst = New System.Windows.Forms.TextBox()
    Me.txtSecond = New System.Windows.Forms.TextBox()
    Me.btnSort = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(60, 11)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(73, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "First word:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(39, 42)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 17)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Second word:"
    '
    'txtFirst
    '
    Me.txtFirst.Location = New System.Drawing.Point(140, 7)
    Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
    Me.txtFirst.Name = "txtFirst"
    Me.txtFirst.Size = New System.Drawing.Size(132, 22)
    Me.txtFirst.TabIndex = 2
    '
    'txtSecond
    '
    Me.txtSecond.Location = New System.Drawing.Point(140, 39)
    Me.txtSecond.Margin = New System.Windows.Forms.Padding(4)
    Me.txtSecond.Name = "txtSecond"
    Me.txtSecond.Size = New System.Drawing.Size(132, 22)
    Me.txtSecond.TabIndex = 3
    '
    'btnSort
    '
    Me.btnSort.Location = New System.Drawing.Point(33, 71)
    Me.btnSort.Margin = New System.Windows.Forms.Padding(4)
    Me.btnSort.Name = "btnSort"
    Me.btnSort.Size = New System.Drawing.Size(241, 36)
    Me.btnSort.TabIndex = 4
    Me.btnSort.Text = "Sort and Display Words"
    Me.btnSort.UseVisualStyleBackColor = True
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(33, 114)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = True
    Me.txtOutput.Size = New System.Drawing.Size(240, 22)
    Me.txtOutput.TabIndex = 5
    '
    'frmWords
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(307, 149)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnSort)
    Me.Controls.Add(Me.txtSecond)
    Me.Controls.Add(Me.txtFirst)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmWords"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "beauty"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtFirst As System.Windows.Forms.TextBox
  Friend WithEvents txtSecond As System.Windows.Forms.TextBox
  Friend WithEvents btnSort As System.Windows.Forms.Button
  Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
