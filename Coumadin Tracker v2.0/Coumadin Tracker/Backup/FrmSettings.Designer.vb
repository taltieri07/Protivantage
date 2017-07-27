<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.txtPTCode = New System.Windows.Forms.TextBox()
        Me.txtINRCode = New System.Windows.Forms.TextBox()
        Me.lblProtime = New System.Windows.Forms.Label()
        Me.lblINR = New System.Windows.Forms.Label()
        Me.NumDefaultOverdueInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblDefaultOverdueInterval = New System.Windows.Forms.Label()
        Me.ChkDefaultNotify = New System.Windows.Forms.CheckBox()
        Me.lblDefaultNotify = New System.Windows.Forms.Label()
        Me.lblUserOverrideOverdue = New System.Windows.Forms.Label()
        Me.ChkAllow1 = New System.Windows.Forms.CheckBox()
        Me.ChkAllow2 = New System.Windows.Forms.CheckBox()
        Me.lblTaskPriority = New System.Windows.Forms.Label()
        Me.lblUserOverrideNotify = New System.Windows.Forms.Label()
        Me.lblTaskAllowOverride = New System.Windows.Forms.Label()
        Me.cmbTaskPriority = New System.Windows.Forms.ComboBox()
        Me.TaskPriorityDEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorksDataSet = New Coumadin_Tracker.WorksDataSet()
        Me.WorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Task_Priority_DETableAdapter = New Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter()
        Me.TaskPriorityDEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkAllow3 = New System.Windows.Forms.CheckBox()
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
        Me.BtnSave.Location = New System.Drawing.Point(280, 209)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 24)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(396, 209)
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
        'txtPTCode
        '
        Me.txtPTCode.Location = New System.Drawing.Point(223, 44)
        Me.txtPTCode.Name = "txtPTCode"
        Me.txtPTCode.Size = New System.Drawing.Size(77, 20)
        Me.txtPTCode.TabIndex = 3
        '
        'txtINRCode
        '
        Me.txtINRCode.Location = New System.Drawing.Point(223, 68)
        Me.txtINRCode.Name = "txtINRCode"
        Me.txtINRCode.Size = New System.Drawing.Size(77, 20)
        Me.txtINRCode.TabIndex = 4
        '
        'lblProtime
        '
        Me.lblProtime.AutoSize = True
        Me.lblProtime.Location = New System.Drawing.Point(8, 48)
        Me.lblProtime.Name = "lblProtime"
        Me.lblProtime.Size = New System.Drawing.Size(118, 13)
        Me.lblProtime.TabIndex = 5
        Me.lblProtime.Text = "Result Code for Protime"
        '
        'lblINR
        '
        Me.lblINR.AutoSize = True
        Me.lblINR.Location = New System.Drawing.Point(8, 72)
        Me.lblINR.Name = "lblINR"
        Me.lblINR.Size = New System.Drawing.Size(102, 13)
        Me.lblINR.TabIndex = 6
        Me.lblINR.Text = "Result Code for INR"
        '
        'NumDefaultOverdueInterval
        '
        Me.NumDefaultOverdueInterval.Location = New System.Drawing.Point(223, 92)
        Me.NumDefaultOverdueInterval.Name = "NumDefaultOverdueInterval"
        Me.NumDefaultOverdueInterval.Size = New System.Drawing.Size(60, 20)
        Me.NumDefaultOverdueInterval.TabIndex = 7
        '
        'lblDefaultOverdueInterval
        '
        Me.lblDefaultOverdueInterval.AutoSize = True
        Me.lblDefaultOverdueInterval.Location = New System.Drawing.Point(8, 96)
        Me.lblDefaultOverdueInterval.Name = "lblDefaultOverdueInterval"
        Me.lblDefaultOverdueInterval.Size = New System.Drawing.Size(168, 13)
        Me.lblDefaultOverdueInterval.TabIndex = 8
        Me.lblDefaultOverdueInterval.Text = "Default Value for Overdue Interval"
        '
        'ChkDefaultNotify
        '
        Me.ChkDefaultNotify.AutoSize = True
        Me.ChkDefaultNotify.Location = New System.Drawing.Point(223, 119)
        Me.ChkDefaultNotify.Name = "ChkDefaultNotify"
        Me.ChkDefaultNotify.Size = New System.Drawing.Size(15, 14)
        Me.ChkDefaultNotify.TabIndex = 9
        Me.ChkDefaultNotify.UseVisualStyleBackColor = True
        '
        'lblDefaultNotify
        '
        Me.lblDefaultNotify.AutoSize = True
        Me.lblDefaultNotify.Location = New System.Drawing.Point(8, 120)
        Me.lblDefaultNotify.Name = "lblDefaultNotify"
        Me.lblDefaultNotify.Size = New System.Drawing.Size(201, 13)
        Me.lblDefaultNotify.TabIndex = 10
        Me.lblDefaultNotify.Text = "Overdue Notification Checked by Default"
        '
        'lblUserOverrideOverdue
        '
        Me.lblUserOverrideOverdue.AutoSize = True
        Me.lblUserOverrideOverdue.Location = New System.Drawing.Point(337, 96)
        Me.lblUserOverrideOverdue.Name = "lblUserOverrideOverdue"
        Me.lblUserOverrideOverdue.Size = New System.Drawing.Size(106, 13)
        Me.lblUserOverrideOverdue.TabIndex = 11
        Me.lblUserOverrideOverdue.Text = "Allow User Override?"
        '
        'ChkAllow1
        '
        Me.ChkAllow1.AutoSize = True
        Me.ChkAllow1.Location = New System.Drawing.Point(454, 95)
        Me.ChkAllow1.Name = "ChkAllow1"
        Me.ChkAllow1.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow1.TabIndex = 13
        Me.ChkAllow1.UseVisualStyleBackColor = True
        '
        'ChkAllow2
        '
        Me.ChkAllow2.AutoSize = True
        Me.ChkAllow2.Location = New System.Drawing.Point(454, 119)
        Me.ChkAllow2.Name = "ChkAllow2"
        Me.ChkAllow2.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow2.TabIndex = 14
        Me.ChkAllow2.UseVisualStyleBackColor = True
        '
        'lblTaskPriority
        '
        Me.lblTaskPriority.AutoSize = True
        Me.lblTaskPriority.Location = New System.Drawing.Point(8, 144)
        Me.lblTaskPriority.Name = "lblTaskPriority"
        Me.lblTaskPriority.Size = New System.Drawing.Size(102, 13)
        Me.lblTaskPriority.TabIndex = 15
        Me.lblTaskPriority.Text = "Default Task Priority"
        '
        'lblUserOverrideNotify
        '
        Me.lblUserOverrideNotify.AutoSize = True
        Me.lblUserOverrideNotify.Location = New System.Drawing.Point(337, 120)
        Me.lblUserOverrideNotify.Name = "lblUserOverrideNotify"
        Me.lblUserOverrideNotify.Size = New System.Drawing.Size(106, 13)
        Me.lblUserOverrideNotify.TabIndex = 12
        Me.lblUserOverrideNotify.Text = "Allow User Override?"
        '
        'lblTaskAllowOverride
        '
        Me.lblTaskAllowOverride.AutoSize = True
        Me.lblTaskAllowOverride.Location = New System.Drawing.Point(337, 144)
        Me.lblTaskAllowOverride.Name = "lblTaskAllowOverride"
        Me.lblTaskAllowOverride.Size = New System.Drawing.Size(106, 13)
        Me.lblTaskAllowOverride.TabIndex = 16
        Me.lblTaskAllowOverride.Text = "Allow User Override?"
        '
        'cmbTaskPriority
        '
        Me.cmbTaskPriority.DataSource = Me.TaskPriorityDEBindingSource
        Me.cmbTaskPriority.DisplayMember = "EntryName"
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(223, 140)
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
        'ChkAllow3
        '
        Me.ChkAllow3.AutoSize = True
        Me.ChkAllow3.Location = New System.Drawing.Point(454, 143)
        Me.ChkAllow3.Name = "ChkAllow3"
        Me.ChkAllow3.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow3.TabIndex = 46
        Me.ChkAllow3.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 169)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(116, 13)
        Me.lblEmail.TabIndex = 48
        Me.lblEmail.Text = "Email Address (Sender)"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(223, 165)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 47
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 250)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.ChkAllow3)
        Me.Controls.Add(Me.cmbTaskPriority)
        Me.Controls.Add(Me.lblTaskAllowOverride)
        Me.Controls.Add(Me.lblTaskPriority)
        Me.Controls.Add(Me.ChkAllow2)
        Me.Controls.Add(Me.ChkAllow1)
        Me.Controls.Add(Me.lblUserOverrideNotify)
        Me.Controls.Add(Me.lblUserOverrideOverdue)
        Me.Controls.Add(Me.lblDefaultNotify)
        Me.Controls.Add(Me.ChkDefaultNotify)
        Me.Controls.Add(Me.lblDefaultOverdueInterval)
        Me.Controls.Add(Me.NumDefaultOverdueInterval)
        Me.Controls.Add(Me.lblINR)
        Me.Controls.Add(Me.lblProtime)
        Me.Controls.Add(Me.txtINRCode)
        Me.Controls.Add(Me.txtPTCode)
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
    Friend WithEvents txtPTCode As System.Windows.Forms.TextBox
    Friend WithEvents txtINRCode As System.Windows.Forms.TextBox
    Friend WithEvents lblProtime As System.Windows.Forms.Label
    Friend WithEvents lblINR As System.Windows.Forms.Label
    Friend WithEvents NumDefaultOverdueInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDefaultOverdueInterval As System.Windows.Forms.Label
    Friend WithEvents ChkDefaultNotify As System.Windows.Forms.CheckBox
    Friend WithEvents lblDefaultNotify As System.Windows.Forms.Label
    Friend WithEvents lblUserOverrideOverdue As System.Windows.Forms.Label
    Friend WithEvents ChkAllow1 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAllow2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblTaskPriority As System.Windows.Forms.Label
    Friend WithEvents lblUserOverrideNotify As System.Windows.Forms.Label
    Friend WithEvents lblTaskAllowOverride As System.Windows.Forms.Label
    Friend WithEvents cmbTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents WorksDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorksDataSet As Coumadin_Tracker.WorksDataSet
    Friend WithEvents TaskPriorityDEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Task_Priority_DETableAdapter As Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter
    Friend WithEvents TaskPriorityDEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ChkAllow3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
