Partial Public Class frmFirstName
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

  Friend WithEvents btnDetermine As System.Windows.Forms.Button
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblFirstName As System.Windows.Forms.Label
  Friend WithEvents txtFirstname As System.Windows.Forms.TextBox

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.lblFirstName = New System.Windows.Forms.Label()
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.lblName = New System.Windows.Forms.Label()
    Me.txtFirstname = New System.Windows.Forms.TextBox()
    Me.txtFullName = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblFirstName
    '
    Me.lblFirstName.AutoSize = True
    Me.lblFirstName.Location = New System.Drawing.Point(13, 86)
    Me.lblFirstName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblFirstName.Name = "lblFirstName"
    Me.lblFirstName.Size = New System.Drawing.Size(78, 17)
    Me.lblFirstName.TabIndex = 3
    Me.lblFirstName.Text = "First name:"
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(36, 37)
    Me.btnDetermine.Margin = New System.Windows.Forms.Padding(5, 1, 5, 4)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(227, 36)
    Me.btnDetermine.TabIndex = 2
    Me.btnDetermine.Text = "Determine First Name"
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(13, 10)
    Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(73, 17)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Full name:"
    '
    'txtFirstname
    '
    Me.txtFirstname.Location = New System.Drawing.Point(99, 82)
    Me.txtFirstname.Margin = New System.Windows.Forms.Padding(5, 2, 5, 4)
    Me.txtFirstname.Name = "txtFirstname"
    Me.txtFirstname.ReadOnly = True
    Me.txtFirstname.Size = New System.Drawing.Size(177, 22)
    Me.txtFirstname.TabIndex = 4
    '
    'txtFullName
    '
    Me.txtFullName.Location = New System.Drawing.Point(91, 6)
    Me.txtFullName.Margin = New System.Windows.Forms.Padding(4)
    Me.txtFullName.Name = "txtFullName"
    Me.txtFullName.Size = New System.Drawing.Size(189, 22)
    Me.txtFullName.TabIndex = 1
    '
    'frmFirstName
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.ClientSize = New System.Drawing.Size(300, 113)
    Me.Controls.Add(Me.txtFullName)
    Me.Controls.Add(Me.txtFirstname)
    Me.Controls.Add(Me.lblFirstName)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.btnDetermine)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmFirstName"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "First Name"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFullName As System.Windows.Forms.TextBox
  Private components As System.ComponentModel.IContainer

End Class
