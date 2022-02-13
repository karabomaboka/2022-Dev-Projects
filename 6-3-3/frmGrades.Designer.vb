<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
    Me.lstGrades = New System.Windows.Forms.ListBox()
    Me.lblGrade = New System.Windows.Forms.Label()
    Me.txtGrade = New System.Windows.Forms.TextBox()
    Me.btnRecord = New System.Windows.Forms.Button()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.lblAverage = New System.Windows.Forms.Label()
    Me.lblHighest = New System.Windows.Forms.Label()
    Me.txtAverage = New System.Windows.Forms.TextBox()
    Me.txtHighest = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lstGrades
    '
    Me.lstGrades.FormattingEnabled = True
    Me.lstGrades.ItemHeight = 16
    Me.lstGrades.Location = New System.Drawing.Point(225, 7)
    Me.lstGrades.Margin = New System.Windows.Forms.Padding(4)
    Me.lstGrades.Name = "lstGrades"
    Me.lstGrades.Size = New System.Drawing.Size(64, 180)
    Me.lstGrades.TabIndex = 0
    '
    'lblGrade
    '
    Me.lblGrade.AutoSize = True
    Me.lblGrade.Location = New System.Drawing.Point(36, 11)
    Me.lblGrade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblGrade.Name = "lblGrade"
    Me.lblGrade.Size = New System.Drawing.Size(52, 17)
    Me.lblGrade.TabIndex = 1
    Me.lblGrade.Text = "Grade:"
    '
    'txtGrade
    '
    Me.txtGrade.Location = New System.Drawing.Point(91, 7)
    Me.txtGrade.Margin = New System.Windows.Forms.Padding(4)
    Me.txtGrade.Name = "txtGrade"
    Me.txtGrade.Size = New System.Drawing.Size(59, 22)
    Me.txtGrade.TabIndex = 0
    '
    'btnRecord
    '
    Me.btnRecord.Location = New System.Drawing.Point(39, 37)
    Me.btnRecord.Margin = New System.Windows.Forms.Padding(4)
    Me.btnRecord.Name = "btnRecord"
    Me.btnRecord.Size = New System.Drawing.Size(143, 43)
    Me.btnRecord.TabIndex = 3
    Me.btnRecord.Text = "Record Grade"
    Me.btnRecord.UseVisualStyleBackColor = True
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(39, 85)
    Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(143, 43)
    Me.btnCalculate.TabIndex = 4
    Me.btnCalculate.Text = "Calculate Average and Highest Grade"
    Me.btnCalculate.UseVisualStyleBackColor = True
    '
    'lblAverage
    '
    Me.lblAverage.AutoSize = True
    Me.lblAverage.Location = New System.Drawing.Point(41, 139)
    Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblAverage.Name = "lblAverage"
    Me.lblAverage.Size = New System.Drawing.Size(106, 17)
    Me.lblAverage.TabIndex = 5
    Me.lblAverage.Text = "Average grade:"
    '
    'lblHighest
    '
    Me.lblHighest.AutoSize = True
    Me.lblHighest.Location = New System.Drawing.Point(46, 174)
    Me.lblHighest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblHighest.Name = "lblHighest"
    Me.lblHighest.Size = New System.Drawing.Size(101, 17)
    Me.lblHighest.TabIndex = 6
    Me.lblHighest.Text = "Highest grade:"
    '
    'txtAverage
    '
    Me.txtAverage.Location = New System.Drawing.Point(151, 135)
    Me.txtAverage.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAverage.Name = "txtAverage"
    Me.txtAverage.ReadOnly = True
    Me.txtAverage.Size = New System.Drawing.Size(53, 22)
    Me.txtAverage.TabIndex = 7
    '
    'txtHighest
    '
    Me.txtHighest.Location = New System.Drawing.Point(151, 170)
    Me.txtHighest.Margin = New System.Windows.Forms.Padding(4)
    Me.txtHighest.Name = "txtHighest"
    Me.txtHighest.ReadOnly = True
    Me.txtHighest.Size = New System.Drawing.Size(53, 22)
    Me.txtHighest.TabIndex = 8
    '
    'frmGrades
    '
    Me.AcceptButton = Me.btnRecord
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(332, 203)
    Me.Controls.Add(Me.txtHighest)
    Me.Controls.Add(Me.txtAverage)
    Me.Controls.Add(Me.lblHighest)
    Me.Controls.Add(Me.lblAverage)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.btnRecord)
    Me.Controls.Add(Me.txtGrade)
    Me.Controls.Add(Me.lblGrade)
    Me.Controls.Add(Me.lstGrades)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmGrades"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Analyze Grades"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstGrades As System.Windows.Forms.ListBox
  Friend WithEvents lblGrade As System.Windows.Forms.Label
  Friend WithEvents txtGrade As System.Windows.Forms.TextBox
  Friend WithEvents btnRecord As System.Windows.Forms.Button
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents lblAverage As System.Windows.Forms.Label
  Friend WithEvents lblHighest As System.Windows.Forms.Label
  Friend WithEvents txtAverage As System.Windows.Forms.TextBox
  Friend WithEvents txtHighest As System.Windows.Forms.TextBox

End Class
