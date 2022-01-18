Partial Public Class frmMovie
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
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.txtQuotation = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(38, 5)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(196, 36)
    Me.btnDisplay.TabIndex = 0
    Me.btnDisplay.Text = "Display a Movie Quotation"
    '
    'txtQuotation
    '
    Me.txtQuotation.Location = New System.Drawing.Point(38, 47)
    Me.txtQuotation.Margin = New System.Windows.Forms.Padding(4)
    Me.txtQuotation.Name = "txtQuotation"
    Me.txtQuotation.Size = New System.Drawing.Size(196, 22)
    Me.txtQuotation.TabIndex = 1
    '
    'frmMovie
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(272, 75)
    Me.Controls.Add(Me.txtQuotation)
    Me.Controls.Add(Me.btnDisplay)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmMovie"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Movies"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents txtQuotation As System.Windows.Forms.TextBox

End Class
