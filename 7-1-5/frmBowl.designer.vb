Partial Public Class frmBowl
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
    Me.lblName = New System.Windows.Forms.Label()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lstGamesWon = New System.Windows.Forms.ListBox()
    Me.btnAddWinner = New System.Windows.Forms.Button()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(71, 12)
    Me.lblName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(150, 17)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Name of football team:"
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(67, 39)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(239, 36)
    Me.btnDisplay.TabIndex = 2
    Me.btnDisplay.Text = "Display Games Team Won"
    '
    'lstGamesWon
    '
    Me.lstGamesWon.FormattingEnabled = True
    Me.lstGamesWon.ItemHeight = 16
    Me.lstGamesWon.Location = New System.Drawing.Point(144, 82)
    Me.lstGamesWon.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lstGamesWon.Name = "lstGamesWon"
    Me.lstGamesWon.Size = New System.Drawing.Size(84, 100)
    Me.lstGamesWon.TabIndex = 3
    '
    'btnAddWinner
    '
    Me.btnAddWinner.Location = New System.Drawing.Point(67, 189)
    Me.btnAddWinner.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnAddWinner.Name = "btnAddWinner"
    Me.btnAddWinner.Size = New System.Drawing.Size(239, 36)
    Me.btnAddWinner.TabIndex = 4
    Me.btnAddWinner.Text = "btnAddWinner"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(224, 9)
    Me.txtName.Margin = New System.Windows.Forms.Padding(4)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(84, 22)
    Me.txtName.TabIndex = 1
    '
    'frmBowl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(372, 232)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.btnAddWinner)
    Me.Controls.Add(Me.lstGamesWon)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lblName)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmBowl"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lstGamesWon As System.Windows.Forms.ListBox
  Friend WithEvents btnAddWinner As System.Windows.Forms.Button
  Friend WithEvents txtName As System.Windows.Forms.TextBox

End Class
