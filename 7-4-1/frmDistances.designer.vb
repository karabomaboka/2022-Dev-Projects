Partial Public Class frmDistances
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.mtbOrig = New System.Windows.Forms.MaskedTextBox()
    Me.mtbDest = New System.Windows.Forms.MaskedTextBox()
    Me.btnShow = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtMiles = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(23, 16)
    Me.Label1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(75, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "1. Chicago"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(23, 41)
    Me.Label2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 1)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(102, 17)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "2. Los Angeles"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(23, 65)
    Me.Label3.Margin = New System.Windows.Forms.Padding(5, 1, 5, 1)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(84, 17)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "3. New York"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(23, 90)
    Me.Label4.Margin = New System.Windows.Forms.Padding(5, 1, 5, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(101, 17)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "4. Philadelphia"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(203, 42)
    Me.Label5.Margin = New System.Windows.Forms.Padding(5, 1, 5, 4)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(50, 17)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Origin:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(169, 78)
    Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(83, 17)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "Destination:"
    '
    'mtbOrig
    '
    Me.mtbOrig.Location = New System.Drawing.Point(258, 39)
    Me.mtbOrig.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.mtbOrig.Mask = "0"
    Me.mtbOrig.Name = "mtbOrig"
    Me.mtbOrig.Size = New System.Drawing.Size(29, 22)
    Me.mtbOrig.TabIndex = 6
    '
    'mtbDest
    '
    Me.mtbDest.Location = New System.Drawing.Point(258, 73)
    Me.mtbDest.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.mtbDest.Mask = "0"
    Me.mtbDest.Name = "mtbDest"
    Me.mtbDest.Size = New System.Drawing.Size(28, 22)
    Me.mtbDest.TabIndex = 7
    '
    'btnShow
    '
    Me.btnShow.Location = New System.Drawing.Point(54, 116)
    Me.btnShow.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnShow.Name = "btnShow"
    Me.btnShow.Size = New System.Drawing.Size(204, 49)
    Me.btnShow.TabIndex = 8
    Me.btnShow.Text = "Show Mileage between Origin and Destination"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(95, 181)
    Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(61, 17)
    Me.Label7.TabIndex = 9
    Me.Label7.Text = "Mileage:"
    '
    'txtMiles
    '
    Me.txtMiles.Location = New System.Drawing.Point(165, 178)
    Me.txtMiles.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtMiles.Name = "txtMiles"
    Me.txtMiles.ReadOnly = True
    Me.txtMiles.Size = New System.Drawing.Size(49, 22)
    Me.txtMiles.TabIndex = 10
    '
    'frmDistances
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(312, 213)
    Me.Controls.Add(Me.txtMiles)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.btnShow)
    Me.Controls.Add(Me.mtbDest)
    Me.Controls.Add(Me.mtbOrig)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmDistances"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Distances"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents mtbOrig As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbDest As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnShow As System.Windows.Forms.Button
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtMiles As System.Windows.Forms.TextBox

End Class
