<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ChkEdited = New System.Windows.Forms.CheckBox()
        Me.NumDefaultOverdueInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblDefaultOverdueInterval = New System.Windows.Forms.Label()
        Me.ChkDefaultNotify = New System.Windows.Forms.CheckBox()
        Me.lblDefaultNotify = New System.Windows.Forms.Label()
        Me.lblTaskPriority = New System.Windows.Forms.Label()
        Me.cmbTaskPriority = New System.Windows.Forms.ComboBox()
        Me.TaskPriorityDEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorksDataSet = New Coumadin_Tracker.WorksDataSet()
        Me.WorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Task_Priority_DETableAdapter = New Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter()
        Me.TaskPriorityDEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(280, 144)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 24)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(396, 144)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 24)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ChkEdited
        '
        Me.ChkEdited.AutoSize = True
        Me.ChkEdited.Location = New System.Drawing.Point(456, 12)
        Me.ChkEdited.Name = "ChkEdited"
        Me.ChkEdited.Size = New System.Drawing.Size(56, 17)
        Me.ChkEdited.TabIndex = 2
        Me.ChkEdited.Text = "Edited"
        Me.ChkEdited.UseVisualStyleBackColor = True
        Me.ChkEdited.Visible = False
        '
        'NumDefaultOverdueInterval
        '
        Me.NumDefaultOverdueInterval.Location = New System.Drawing.Point(223, 27)
        Me.NumDefaultOverdueInterval.Name = "NumDefaultOverdueInterval"
        Me.NumDefaultOverdueInterval.Size = New System.Drawing.Size(60, 20)
        Me.NumDefaultOverdueInterval.TabIndex = 7
        '
        'lblDefaultOverdueInterval
        '
        Me.lblDefaultOverdueInterval.AutoSize = True
        Me.lblDefaultOverdueInterval.Location = New System.Drawing.Point(8, 31)
        Me.lblDefaultOverdueInterval.Name = "lblDefaultOverdueInterval"
        Me.lblDefaultOverdueInterval.Size = New System.Drawing.Size(168, 13)
        Me.lblDefaultOverdueInterval.TabIndex = 8
        Me.lblDefaultOverdueInterval.Text = "Default Value for Overdue Interval"
        '
        'ChkDefaultNotify
        '
        Me.ChkDefaultNotify.AutoSize = True
        Me.ChkDefaultNotify.Location = New System.Drawing.Point(223, 54)
        Me.ChkDefaultNotify.Name = "ChkDefaultNotify"
        Me.ChkDefaultNotify.Size = New System.Drawing.Size(15, 14)
        Me.ChkDefaultNotify.TabIndex = 9
        Me.ChkDefaultNotify.UseVisualStyleBackColor = True
        '
        'lblDefaultNotify
        '
        Me.lblDefaultNotify.AutoSize = True
        Me.lblDefaultNotify.Location = New System.Drawing.Point(8, 55)
        Me.lblDefaultNotify.Name = "lblDefaultNotify"
        Me.lblDefaultNotify.Size = New System.Drawing.Size(201, 13)
        Me.lblDefaultNotify.TabIndex = 10
        Me.lblDefaultNotify.Text = "Overdue Notification Checked by Default"
        '
        'lblTaskPriority
        '
        Me.lblTaskPriority.AutoSize = True
        Me.lblTaskPriority.Location = New System.Drawing.Point(8, 79)
        Me.lblTaskPriority.Name = "lblTaskPriority"
        Me.lblTaskPriority.Size = New System.Drawing.Size(102, 13)
        Me.lblTaskPriority.TabIndex = 15
        Me.lblTaskPriority.Text = "Default Task Priority"
        '
        'cmbTaskPriority
        '
        Me.cmbTaskPriority.DataSource = Me.TaskPriorityDEBindingSource
        Me.cmbTaskPriority.DisplayMember = "EntryName"
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(223, 75)
        Me.cmbTaskPriority.Name = "cmbTaskPriority"
        Me.cmbTaskPriority.Size = New System.Drawing.Size(97, 21)
        Me.cmbTaskPriority.TabIndex = 45
        '
        'TaskPriorityDEBindingSource
        '
        Me.TaskPriorityDEBindingSource.DataMember = "Task_Priority_DE"
        Me.TaskPriorityDEBindingSource.DataSource = Me.WorksDataSet
        '
        'WorksDataSet
        '
        Me.WorksDataSet.DataSetName = "WorksDataSet"
        Me.WorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorksDataSetBindingSource
        '
        Me.WorksDataSetBindingSource.DataSource = Me.WorksDataSet
        Me.WorksDataSetBindingSource.Position = 0
        '
        'Task_Priority_DETableAdapter
        '
        Me.Task_Priority_DETableAdapter.ClearBeforeFill = True
        '
        'TaskPriorityDEBindingSource1
        '
        Me.TaskPriorityDEBindingSource1.DataMember = "Task_Priority_DE"
        Me.TaskPriorityDEBindingSource1.DataSource = Me.WorksDataSetBindingSource
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 104)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 48
        Me.lblEmail.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(223, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 47
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 181)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cmbTaskPriority)
        Me.Controls.Add(Me.lblTaskPriority)
        Me.Controls.Add(Me.lblDefaultNotify)
        Me.Controls.Add(Me.ChkDefaultNotify)
        Me.Controls.Add(Me.lblDefaultOverdueInterval)
        Me.Controls.Add(Me.NumDefaultOverdueInterval)
        Me.Controls.Add(Me.ChkEdited)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmSettings"
        Me.Text = "Settings"
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ChkEdited As System.Windows.Forms.CheckBox
    Friend WithEvents NumDefaultOverdueInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDefaultOverdueInterval As System.Windows.Forms.Label
    Friend WithEvents ChkDefaultNotify As System.Windows.Forms.CheckBox
    Friend WithEvents lblDefaultNotify As System.Windows.Forms.Label
    Friend WithEvents lblTaskPriority As System.Windows.Forms.Label
    Friend WithEvents cmbTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents WorksDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorksDataSet As Coumadin_Tracker.WorksDataSet
    Friend WithEvents TaskPriorityDEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Task_Priority_DETableAdapter As Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter
    Friend WithEvents TaskPriorityDEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
