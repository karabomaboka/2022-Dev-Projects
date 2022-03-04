<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodLabel
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
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.dgvOutput = New System.Windows.Forms.DataGridView()
    CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(54, 10)
    Me.btnDetermine.Margin = New System.Windows.Forms.Padding(4)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(275, 36)
    Me.btnDetermine.TabIndex = 0
    Me.btnDetermine.Text = "Determine Nutritional Contents of a Meal"
    Me.btnDetermine.UseVisualStyleBackColor = True
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.Location = New System.Drawing.Point(51, 62)
    Me.dgvOutput.Margin = New System.Windows.Forms.Padding(4)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = False
    Me.dgvOutput.Size = New System.Drawing.Size(282, 146)
    Me.dgvOutput.TabIndex = 2
    '
    'frmFoodLabel
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(382, 224)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.btnDetermine)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmFoodLabel"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nutritional Analysis"
    CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDetermine As System.Windows.Forms.Button
  Friend WithEvents dgvOutput As System.Windows.Forms.DataGridView

End Class
