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
    Me.txtAmount = New System.Windows.Forms.TextBox()
    Me.txtSalesTax = New System.Windows.Forms.TextBox()
    Me.lblAmount = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(59, 39)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(189, 36)
    Me.btnCalculate.TabIndex = 2
    Me.btnCalculate.Text = "Calculate Sales Tax"
    Me.btnCalculate.UseVisualStyleBackColor = True
    '
    'txtAmount
    '
    Me.txtAmount.Location = New System.Drawing.Point(170, 12)
    Me.txtAmount.Name = "txtAmount"
    Me.txtAmount.Size = New System.Drawing.Size(110, 22)
    Me.txtAmount.TabIndex = 1
    '
    'txtSalesTax
    '
    Me.txtSalesTax.Location = New System.Drawing.Point(168, 80)
    Me.txtSalesTax.Name = "txtSalesTax"
    Me.txtSalesTax.ReadOnly = True
    Me.txtSalesTax.Size = New System.Drawing.Size(110, 22)
    Me.txtSalesTax.TabIndex = 4
    '
    'lblAmount
    '
    Me.lblAmount.AutoSize = True
    Me.lblAmount.Location = New System.Drawing.Point(27, 15)
    Me.lblAmount.Name = "lblAmount"
    Me.lblAmount.Size = New System.Drawing.Size(139, 17)
    Me.lblAmount.TabIndex = 0
    Me.lblAmount.Text = "Amount of purchase:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(97, 84)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(69, 17)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Sales tax:"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(307, 115)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblAmount)
    Me.Controls.Add(Me.txtSalesTax)
    Me.Controls.Add(Me.txtAmount)
    Me.Controls.Add(Me.btnCalculate)
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sales Tax"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents txtAmount As System.Windows.Forms.TextBox
  Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
  Friend WithEvents lblAmount As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
