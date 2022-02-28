Partial Public Class frmColleges
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
    Me.lblCollege = New System.Windows.Forms.Label()
    Me.lblState = New System.Windows.Forms.Label()
    Me.lblYear = New System.Windows.Forms.Label()
    Me.txtState = New System.Windows.Forms.TextBox()
    Me.txtYear = New System.Windows.Forms.TextBox()
    Me.lstColleges = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'lblCollege
    '
    Me.lblCollege.AutoSize = True
    Me.lblCollege.Location = New System.Drawing.Point(5, 15)
    Me.lblCollege.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblCollege.Name = "lblCollege"
    Me.lblCollege.Size = New System.Drawing.Size(201, 17)
    Me.lblCollege.TabIndex = 0
    Me.lblCollege.Text = "Click on the name of a college."
    '
    'lblState
    '
    Me.lblState.AutoSize = True
    Me.lblState.Location = New System.Drawing.Point(213, 53)
    Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblState.Name = "lblState"
    Me.lblState.Size = New System.Drawing.Size(45, 17)
    Me.lblState.TabIndex = 5
    Me.lblState.Text = "State:"
    '
    'lblYear
    '
    Me.lblYear.AutoSize = True
    Me.lblYear.Location = New System.Drawing.Point(213, 82)
    Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblYear.Name = "lblYear"
    Me.lblYear.Size = New System.Drawing.Size(98, 17)
    Me.lblYear.TabIndex = 6
    Me.lblYear.Text = "Year founded:"
    '
    'txtState
    '
    Me.txtState.Location = New System.Drawing.Point(263, 49)
    Me.txtState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtState.Name = "txtState"
    Me.txtState.ReadOnly = True
    Me.txtState.Size = New System.Drawing.Size(28, 22)
    Me.txtState.TabIndex = 7
    '
    'txtYear
    '
    Me.txtYear.Location = New System.Drawing.Point(315, 79)
    Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtYear.Name = "txtYear"
    Me.txtYear.ReadOnly = True
    Me.txtYear.Size = New System.Drawing.Size(53, 22)
    Me.txtYear.TabIndex = 8
    '
    'lstColleges
    '
    Me.lstColleges.FormattingEnabled = True
    Me.lstColleges.ItemHeight = 16
    Me.lstColleges.Location = New System.Drawing.Point(16, 38)
    Me.lstColleges.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.lstColleges.Name = "lstColleges"
    Me.lstColleges.Size = New System.Drawing.Size(169, 196)
    Me.lstColleges.TabIndex = 9
    '
    'frmColleges
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(385, 246)
    Me.Controls.Add(Me.lstColleges)
    Me.Controls.Add(Me.txtYear)
    Me.Controls.Add(Me.txtState)
    Me.Controls.Add(Me.lblYear)
    Me.Controls.Add(Me.lblState)
    Me.Controls.Add(Me.lblCollege)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmColleges"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Earliest Colleges"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCollege As System.Windows.Forms.Label
  Friend WithEvents lblState As System.Windows.Forms.Label
  Friend WithEvents lblYear As System.Windows.Forms.Label
  Friend WithEvents txtState As System.Windows.Forms.TextBox
  Friend WithEvents txtYear As System.Windows.Forms.TextBox
  Friend WithEvents lstColleges As System.Windows.Forms.ListBox

End Class
