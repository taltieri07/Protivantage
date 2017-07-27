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
        Me.lblInterval1 = New System.Windows.Forms.Label()
        Me.lblInterval2 = New System.Windows.Forms.Label()
        Me.lblDays1 = New System.Windows.Forms.Label()
        Me.lblDays2 = New System.Windows.Forms.Label()
        Me.NumMyInterval1 = New System.Windows.Forms.NumericUpDown()
        Me.NumMyInterval2 = New System.Windows.Forms.NumericUpDown()
        Me.cmbOverdueTaskPriority = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(280, 213)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 24)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(396, 213)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 24)
        Me.BtnCancel.TabIndex = 8
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
        Me.NumDefaultOverdueInterval.Enabled = False
        Me.NumDefaultOverdueInterval.Location = New System.Drawing.Point(223, 27)
        Me.NumDefaultOverdueInterval.Name = "NumDefaultOverdueInterval"
        Me.NumDefaultOverdueInterval.Size = New System.Drawing.Size(60, 20)
        Me.NumDefaultOverdueInterval.TabIndex = 1
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
        Me.ChkDefaultNotify.Enabled = False
        Me.ChkDefaultNotify.Location = New System.Drawing.Point(223, 54)
        Me.ChkDefaultNotify.Name = "ChkDefaultNotify"
        Me.ChkDefaultNotify.Size = New System.Drawing.Size(15, 14)
        Me.ChkDefaultNotify.TabIndex = 2
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
        Me.cmbTaskPriority.Enabled = False
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(223, 75)
        Me.cmbTaskPriority.Name = "cmbTaskPriority"
        Me.cmbTaskPriority.Size = New System.Drawing.Size(97, 21)
        Me.cmbTaskPriority.TabIndex = 3
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
        Me.lblEmail.Location = New System.Drawing.Point(8, 178)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 48
        Me.lblEmail.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(223, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lblInterval1
        '
        Me.lblInterval1.AutoSize = True
        Me.lblInterval1.Location = New System.Drawing.Point(8, 130)
        Me.lblInterval1.Name = "lblInterval1"
        Me.lblInterval1.Size = New System.Drawing.Size(68, 13)
        Me.lblInterval1.TabIndex = 49
        Me.lblInterval1.Text = "My Interval 1"
        '
        'lblInterval2
        '
        Me.lblInterval2.AutoSize = True
        Me.lblInterval2.Location = New System.Drawing.Point(8, 153)
        Me.lblInterval2.Name = "lblInterval2"
        Me.lblInterval2.Size = New System.Drawing.Size(68, 13)
        Me.lblInterval2.TabIndex = 50
        Me.lblInterval2.Text = "My Interval 2"
        '
        'lblDays1
        '
        Me.lblDays1.AutoSize = True
        Me.lblDays1.Location = New System.Drawing.Point(287, 130)
        Me.lblDays1.Name = "lblDays1"
        Me.lblDays1.Size = New System.Drawing.Size(29, 13)
        Me.lblDays1.TabIndex = 51
        Me.lblDays1.Text = "days"
        '
        'lblDays2
        '
        Me.lblDays2.AutoSize = True
        Me.lblDays2.Location = New System.Drawing.Point(287, 153)
        Me.lblDays2.Name = "lblDays2"
        Me.lblDays2.Size = New System.Drawing.Size(29, 13)
        Me.lblDays2.TabIndex = 52
        Me.lblDays2.Text = "days"
        '
        'NumMyInterval1
        '
        Me.NumMyInterval1.Enabled = False
        Me.NumMyInterval1.Location = New System.Drawing.Point(223, 126)
        Me.NumMyInterval1.Name = "NumMyInterval1"
        Me.NumMyInterval1.Size = New System.Drawing.Size(56, 20)
        Me.NumMyInterval1.TabIndex = 4
        '
        'NumMyInterval2
        '
        Me.NumMyInterval2.Enabled = False
        Me.NumMyInterval2.Location = New System.Drawing.Point(223, 149)
        Me.NumMyInterval2.Name = "NumMyInterval2"
        Me.NumMyInterval2.Size = New System.Drawing.Size(56, 20)
        Me.NumMyInterval2.TabIndex = 5
        '
        'cmbOverdueTaskPriority
        '
        Me.cmbOverdueTaskPriority.DataSource = Me.TaskPriorityDEBindingSource
        Me.cmbOverdueTaskPriority.DisplayMember = "EntryName"
        Me.cmbOverdueTaskPriority.Enabled = False
        Me.cmbOverdueTaskPriority.FormattingEnabled = True
        Me.cmbOverdueTaskPriority.Location = New System.Drawing.Point(223, 100)
        Me.cmbOverdueTaskPriority.Name = "cmbOverdueTaskPriority"
        Me.cmbOverdueTaskPriority.Size = New System.Drawing.Size(97, 21)
        Me.cmbOverdueTaskPriority.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Default Overdue Task Priority"
        '
        'FrmUserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbOverdueTaskPriority)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumMyInterval2)
        Me.Controls.Add(Me.NumMyInterval1)
        Me.Controls.Add(Me.lblDays2)
        Me.Controls.Add(Me.lblDays1)
        Me.Controls.Add(Me.lblInterval2)
        Me.Controls.Add(Me.lblInterval1)
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
        Me.Name = "FrmUserSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblInterval1 As System.Windows.Forms.Label
    Friend WithEvents lblInterval2 As System.Windows.Forms.Label
    Friend WithEvents lblDays1 As System.Windows.Forms.Label
    Friend WithEvents lblDays2 As System.Windows.Forms.Label
    Friend WithEvents NumMyInterval1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumMyInterval2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbOverdueTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
