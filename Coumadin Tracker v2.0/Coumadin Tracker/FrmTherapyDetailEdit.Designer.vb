<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTherapyDetailEdit
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnInactivate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TblTherapyDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EvaluationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInactiveDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEIE = New System.Windows.Forms.Label()
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInactiveDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInactivate
        '
        Me.BtnInactivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInactivate.ForeColor = System.Drawing.Color.Red
        Me.BtnInactivate.Location = New System.Drawing.Point(538, 294)
        Me.BtnInactivate.Name = "BtnInactivate"
        Me.BtnInactivate.Size = New System.Drawing.Size(115, 22)
        Me.BtnInactivate.TabIndex = 1
        Me.BtnInactivate.Text = "&Enter in Error"
        Me.BtnInactivate.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnClose.Location = New System.Drawing.Point(538, 492)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(115, 22)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TblTherapyDetailsDataGridView
        '
        Me.TblTherapyDetailsDataGridView.AllowUserToAddRows = False
        Me.TblTherapyDetailsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TblTherapyDetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TblTherapyDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.TblTherapyDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TblTherapyDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTherapyDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EvaluationDate})
        Me.TblTherapyDetailsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.TblTherapyDetailsDataGridView.Location = New System.Drawing.Point(29, 22)
        Me.TblTherapyDetailsDataGridView.Name = "TblTherapyDetailsDataGridView"
        Me.TblTherapyDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TblTherapyDetailsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblTherapyDetailsDataGridView.ShowEditingIcon = False
        Me.TblTherapyDetailsDataGridView.Size = New System.Drawing.Size(688, 258)
        Me.TblTherapyDetailsDataGridView.TabIndex = 37
        '
        'EvaluationDate
        '
        Me.EvaluationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EvaluationDate.DataPropertyName = "EvaluationDate"
        Me.EvaluationDate.HeaderText = "Eval Date"
        Me.EvaluationDate.Name = "EvaluationDate"
        Me.EvaluationDate.Width = 79
        '
        'TblInactiveDetailsDataGridView
        '
        Me.TblInactiveDetailsDataGridView.AllowUserToAddRows = False
        Me.TblInactiveDetailsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TblInactiveDetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TblInactiveDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.TblInactiveDetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.TblInactiveDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TblInactiveDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInactiveDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.TblInactiveDetailsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.TblInactiveDetailsDataGridView.Location = New System.Drawing.Point(29, 350)
        Me.TblInactiveDetailsDataGridView.Name = "TblInactiveDetailsDataGridView"
        Me.TblInactiveDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TblInactiveDetailsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblInactiveDetailsDataGridView.ShowEditingIcon = False
        Me.TblInactiveDetailsDataGridView.Size = New System.Drawing.Size(688, 125)
        Me.TblInactiveDetailsDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EvaluationDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Eval Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 79
        '
        'lblEIE
        '
        Me.lblEIE.AutoSize = True
        Me.lblEIE.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEIE.ForeColor = System.Drawing.Color.Maroon
        Me.lblEIE.Location = New System.Drawing.Point(32, 321)
        Me.lblEIE.Name = "lblEIE"
        Me.lblEIE.Size = New System.Drawing.Size(159, 27)
        Me.lblEIE.TabIndex = 39
        Me.lblEIE.Text = "Entered in Error"
        '
        'FrmTherapyDetailEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEIE)
        Me.Controls.Add(Me.TblInactiveDetailsDataGridView)
        Me.Controls.Add(Me.TblTherapyDetailsDataGridView)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnInactivate)
        Me.Name = "FrmTherapyDetailEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Therapy Details"
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInactiveDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInactivate As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TblTherapyDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EvaluationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblInactiveDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEIE As System.Windows.Forms.Label
End Class
