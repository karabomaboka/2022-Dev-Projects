Partial Public Class frmBackward
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()>
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.lblName = New System.Windows.Forms.Label()
    Me.btnReverse = New System.Windows.Forms.Button()
    Me.txtBackward = New System.Windows.Forms.TextBox()
    Me.txtWord = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblName
    '
    Me.lblName.Location = New System.Drawing.Point(69, 11)
    Me.lblName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(81, 22)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Enter word:"
    '
    'btnReverse
    '
    Me.btnReverse.Location = New System.Drawing.Point(65, 43)
    Me.btnReverse.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnReverse.Name = "btnReverse"
    Me.btnReverse.Size = New System.Drawing.Size(203, 36)
    Me.btnReverse.TabIndex = 2
    Me.btnReverse.Text = "Reverse Letters"
    '
    'txtBackward
    '
    Me.txtBackward.Location = New System.Drawing.Point(109, 87)
    Me.txtBackward.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtBackward.Name = "txtBackward"
    Me.txtBackward.ReadOnly = True
    Me.txtBackward.Size = New System.Drawing.Size(113, 22)
    Me.txtBackward.TabIndex = 3
    '
    'txtWord
    '
    Me.txtWord.Location = New System.Drawing.Point(155, 10)
    Me.txtWord.Margin = New System.Windows.Forms.Padding(4)
    Me.txtWord.Name = "txtWord"
    Me.txtWord.Size = New System.Drawing.Size(113, 22)
    Me.txtWord.TabIndex = 1
    '
    'frmBackward
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(332, 118)
    Me.Controls.Add(Me.txtWord)
    Me.Controls.Add(Me.txtBackward)
    Me.Controls.Add(Me.btnReverse)
    Me.Controls.Add(Me.lblName)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmBackward"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Write Backward"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents btnReverse As System.Windows.Forms.Button
  Friend WithEvents txtBackward As System.Windows.Forms.TextBox
  Friend WithEvents txtWord As System.Windows.Forms.TextBox
End Class
