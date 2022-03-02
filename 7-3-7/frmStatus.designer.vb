Partial Public Class frmStatus
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
    Me.btnGet = New System.Windows.Forms.Button()
    Me.txtResult = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnGet
    '
    Me.btnGet.Location = New System.Drawing.Point(56, 10)
    Me.btnGet.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnGet.Name = "btnGet"
    Me.btnGet.Size = New System.Drawing.Size(244, 36)
    Me.btnGet.TabIndex = 0
    Me.btnGet.Text = "Get Data and Determine Status"
    '
    'txtResult
    '
    Me.txtResult.Location = New System.Drawing.Point(9, 54)
    Me.txtResult.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtResult.Name = "txtResult"
    Me.txtResult.ReadOnly = True
    Me.txtResult.Size = New System.Drawing.Size(339, 22)
    Me.txtResult.TabIndex = 1
    Me.txtResult.Text = " "
    '
    'frmStatus
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(356, 90)
    Me.Controls.Add(Me.txtResult)
    Me.Controls.Add(Me.btnGet)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmStatus"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Graduation Status"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGet As System.Windows.Forms.Button
  Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
