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
    Me.lblState = New System.Windows.Forms.Label()
    Me.mtbState = New System.Windows.Forms.MaskedTextBox()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.dgvColleges = New System.Windows.Forms.DataGridView()
    CType(Me.dgvColleges, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblState
    '
    Me.lblState.AutoSize = True
    Me.lblState.Location = New System.Drawing.Point(132, 10)
    Me.lblState.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblState.Name = "lblState"
    Me.lblState.Size = New System.Drawing.Size(45, 17)
    Me.lblState.TabIndex = 0
    Me.lblState.Text = "State:"
    '
    'mtbState
    '
    Me.mtbState.Location = New System.Drawing.Point(181, 6)
    Me.mtbState.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.mtbState.Mask = "LL"
    Me.mtbState.Name = "mtbState"
    Me.mtbState.Size = New System.Drawing.Size(35, 22)
    Me.mtbState.TabIndex = 1
    Me.mtbState.Text = "PA"
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(56, 38)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(232, 36)
    Me.btnDisplay.TabIndex = 2
    Me.btnDisplay.Text = "Display Colleges"
    '
    'dgvColleges
    '
    Me.dgvColleges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvColleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvColleges.Location = New System.Drawing.Point(37, 95)
    Me.dgvColleges.Margin = New System.Windows.Forms.Padding(4)
    Me.dgvColleges.Name = "dgvColleges"
    Me.dgvColleges.RowHeadersVisible = False
    Me.dgvColleges.Size = New System.Drawing.Size(271, 147)
    Me.dgvColleges.TabIndex = 3
    '
    'frmColleges
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(347, 265)
    Me.Controls.Add(Me.dgvColleges)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.mtbState)
    Me.Controls.Add(Me.lblState)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmColleges"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Earliest Colleges"
    CType(Me.dgvColleges, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblState As System.Windows.Forms.Label
  Friend WithEvents mtbState As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents dgvColleges As System.Windows.Forms.DataGridView


End Class
