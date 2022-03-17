<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.lstResult = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(23, 7)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(237, 36)
    Me.btnCalculate.TabIndex = 0
    Me.btnCalculate.Text = "Calculate a Balance After 1 Year"
    Me.btnCalculate.UseVisualStyleBackColor = True
    '
    'lstResult
    '
    Me.lstResult.FormattingEnabled = True
    Me.lstResult.ItemHeight = 16
    Me.lstResult.Location = New System.Drawing.Point(98, 48)
    Me.lstResult.Name = "lstResult"
    Me.lstResult.Size = New System.Drawing.Size(86, 20)
    Me.lstResult.TabIndex = 1
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 73)
    Me.Controls.Add(Me.lstResult)
    Me.Controls.Add(Me.btnCalculate)
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "3-1-6"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents lstResult As System.Windows.Forms.ListBox

End Class
