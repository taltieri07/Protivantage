<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCDSRules
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
        Me.RuleDatagrid = New System.Windows.Forms.DataGridView()
        Me.lblExisting = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.RuleDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RuleDatagrid
        '
        Me.RuleDatagrid.AllowUserToAddRows = False
        Me.RuleDatagrid.AllowUserToDeleteRows = False
        Me.RuleDatagrid.AllowUserToResizeRows = False
        Me.RuleDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RuleDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.RuleDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.RuleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RuleDatagrid.Location = New System.Drawing.Point(21, 35)
        Me.RuleDatagrid.Name = "RuleDatagrid"
        Me.RuleDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RuleDatagrid.ShowEditingIcon = False
        Me.RuleDatagrid.Size = New System.Drawing.Size(951, 225)
        Me.RuleDatagrid.TabIndex = 124
        '
        'lblExisting
        '
        Me.lblExisting.AutoSize = True
        Me.lblExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExisting.ForeColor = System.Drawing.Color.Indigo
        Me.lblExisting.Location = New System.Drawing.Point(14, 11)
        Me.lblExisting.Name = "lblExisting"
        Me.lblExisting.Size = New System.Drawing.Size(120, 18)
        Me.lblExisting.TabIndex = 123
        Me.lblExisting.Text = "Existing Rules:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(855, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 23)
        Me.btnClose.TabIndex = 125
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FrmCDSRules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.RuleDatagrid)
        Me.Controls.Add(Me.lblExisting)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCDSRules"
        Me.Text = "Clinical Decision Support Rules"
        CType(Me.RuleDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RuleDatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents lblExisting As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
