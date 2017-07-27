<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecords
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRecords))
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNotifyInterval = New System.Windows.Forms.NumericUpDown
        Me.cbNotify = New System.Windows.Forms.CheckBox
        Me.cmbPillSize = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbINRRange = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbExpectedLengthOfTherapy = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbAdditionalReasonForTherapy = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbReasonForTherapy = New System.Windows.Forms.ComboBox
        Me.dtTherapyStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCurPatID = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.CoumadinTrackerDataSet = New Coumadin_Tracker.CoumadinTrackerDataSet
        Me.TblTherapyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTherapyTableAdapter = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyTableAdapter
        Me.TableAdapterManager = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager
        Me.TblTherapyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.TblTherapyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTherapyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTherapyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTherapyBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "days overdue"
        '
        'txtNotifyInterval
        '
        Me.txtNotifyInterval.Location = New System.Drawing.Point(451, 137)
        Me.txtNotifyInterval.Name = "txtNotifyInterval"
        Me.txtNotifyInterval.Size = New System.Drawing.Size(32, 20)
        Me.txtNotifyInterval.TabIndex = 46
        '
        'cbNotify
        '
        Me.cbNotify.AutoSize = True
        Me.cbNotify.Location = New System.Drawing.Point(361, 138)
        Me.cbNotify.Name = "cbNotify"
        Me.cbNotify.Size = New System.Drawing.Size(85, 17)
        Me.cbNotify.TabIndex = 45
        Me.cbNotify.Text = "Notify When"
        Me.cbNotify.UseVisualStyleBackColor = True
        '
        'cmbPillSize
        '
        Me.cmbPillSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPillSize.FormattingEnabled = True
        Me.cmbPillSize.Items.AddRange(New Object() {"1 mg", "2 mg", "2.5 mg", "3 mg", "4 mg", "5 mg", "7.5 mg", "10 mg"})
        Me.cmbPillSize.Location = New System.Drawing.Point(451, 83)
        Me.cmbPillSize.Name = "cmbPillSize"
        Me.cmbPillSize.Size = New System.Drawing.Size(101, 21)
        Me.cmbPillSize.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Pill Size at Home"
        '
        'cmbINRRange
        '
        Me.cmbINRRange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbINRRange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbINRRange.FormattingEnabled = True
        Me.cmbINRRange.Items.AddRange(New Object() {"1.8 - 2.0", "1.8 - 2.3", "2.0 - 2.5", "2.0 - 3.0", "2.0 - 4.0", "2.5 - 3.0", "2.5 - 3.5", "3.0 - 4.0"})
        Me.cmbINRRange.Location = New System.Drawing.Point(451, 108)
        Me.cmbINRRange.Name = "cmbINRRange"
        Me.cmbINRRange.Size = New System.Drawing.Size(101, 21)
        Me.cmbINRRange.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "INR Range"
        '
        'cmbExpectedLengthOfTherapy
        '
        Me.cmbExpectedLengthOfTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbExpectedLengthOfTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbExpectedLengthOfTherapy.FormattingEnabled = True
        Me.cmbExpectedLengthOfTherapy.Items.AddRange(New Object() {"Lifelong", "1 Month", "6 Weeks", "2 Months", "3 Months", "4 Months", "5 Months", "6 Months", "7 Months", "8 Months", "9 Months", "10 Months", "11 Months", "1 Year"})
        Me.cmbExpectedLengthOfTherapy.Location = New System.Drawing.Point(193, 136)
        Me.cmbExpectedLengthOfTherapy.Name = "cmbExpectedLengthOfTherapy"
        Me.cmbExpectedLengthOfTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbExpectedLengthOfTherapy.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Expected Length Of Therapy"
        '
        'cmbAdditionalReasonForTherapy
        '
        Me.cmbAdditionalReasonForTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAdditionalReasonForTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAdditionalReasonForTherapy.DropDownWidth = 200
        Me.cmbAdditionalReasonForTherapy.FormattingEnabled = True
        Me.cmbAdditionalReasonForTherapy.Items.AddRange(New Object() {"Anticardiolipin Antibody Syndrome", "Artificial Heart Valves", "Atrial Fibrillation", "Atrial Flutter", "Cardiac Thrombus", "Cardiomyopathy", "CHF", "CVA", "DVT", "DVT/PE", "EVAR", "Factor 5", "Hypercoaguable State", "Intra-Abdominal Thrombosis", "Joint Replacement", "PE", "PFO", "Recurrent DVT", "Recurrent PE", "Stenting", "TIA", "Valvular Heart Disease"})
        Me.cmbAdditionalReasonForTherapy.Location = New System.Drawing.Point(193, 109)
        Me.cmbAdditionalReasonForTherapy.Name = "cmbAdditionalReasonForTherapy"
        Me.cmbAdditionalReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbAdditionalReasonForTherapy.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Additional Reason For Therapy"
        '
        'cmbReasonForTherapy
        '
        Me.cmbReasonForTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReasonForTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReasonForTherapy.DropDownWidth = 200
        Me.cmbReasonForTherapy.FormattingEnabled = True
        Me.cmbReasonForTherapy.Items.AddRange(New Object() {"Anticardiolipin Antibody Syndrome", "Artificial Heart Valves", "Atrial Fibrillation", "Atrial Flutter", "Cardiac Thrombus", "Cardiomyopathy", "CHF", "CVA", "DVT", "DVT/PE", "EVAR", "Factor 5", "Hypercoaguable State", "Intra-Abdominal Thrombosis", "Joint Replacement", "PE", "PFO", "Recurrent DVT", "Recurrent PE", "Stenting", "TIA", "Valvular Heart Disease"})
        Me.cmbReasonForTherapy.Location = New System.Drawing.Point(193, 82)
        Me.cmbReasonForTherapy.Name = "cmbReasonForTherapy"
        Me.cmbReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbReasonForTherapy.TabIndex = 36
        '
        'dtTherapyStartDate
        '
        Me.dtTherapyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTherapyStartDate.Location = New System.Drawing.Point(193, 56)
        Me.dtTherapyStartDate.Name = "dtTherapyStartDate"
        Me.dtTherapyStartDate.Size = New System.Drawing.Size(97, 20)
        Me.dtTherapyStartDate.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Reason For Therapy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Therapy Start Date"
        '
        'txtCurPatID
        '
        Me.txtCurPatID.Location = New System.Drawing.Point(38, 26)
        Me.txtCurPatID.Name = "txtCurPatID"
        Me.txtCurPatID.Size = New System.Drawing.Size(71, 20)
        Me.txtCurPatID.TabIndex = 48
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(123, 189)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 35)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "&Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CoumadinTrackerDataSet
        '
        Me.CoumadinTrackerDataSet.DataSetName = "CoumadinTrackerDataSet"
        Me.CoumadinTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTherapyBindingSource
        '
        Me.TblTherapyBindingSource.DataMember = "tblTherapy"
        Me.TblTherapyBindingSource.DataSource = Me.CoumadinTrackerDataSet
        '
        'TblTherapyTableAdapter
        '
        Me.TblTherapyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblTherapyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblTherapyTableAdapter = Me.TblTherapyTableAdapter
        Me.TableAdapterManager.UpdateOrder = Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTherapyBindingNavigator
        '
        Me.TblTherapyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTherapyBindingNavigator.BindingSource = Me.TblTherapyBindingSource
        Me.TblTherapyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTherapyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTherapyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTherapyBindingNavigatorSaveItem})
        Me.TblTherapyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTherapyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTherapyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTherapyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTherapyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTherapyBindingNavigator.Name = "TblTherapyBindingNavigator"
        Me.TblTherapyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTherapyBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.TblTherapyBindingNavigator.TabIndex = 50
        Me.TblTherapyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblTherapyBindingNavigatorSaveItem
        '
        Me.TblTherapyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTherapyBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTherapyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTherapyBindingNavigatorSaveItem.Name = "TblTherapyBindingNavigatorSaveItem"
        Me.TblTherapyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblTherapyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 583)
        Me.Controls.Add(Me.TblTherapyBindingNavigator)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCurPatID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNotifyInterval)
        Me.Controls.Add(Me.cbNotify)
        Me.Controls.Add(Me.cmbPillSize)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbINRRange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbExpectedLengthOfTherapy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbAdditionalReasonForTherapy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbReasonForTherapy)
        Me.Controls.Add(Me.dtTherapyStartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "AddRecords"
        Me.Text = "AddRecords"
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTherapyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTherapyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTherapyBindingNavigator.ResumeLayout(False)
        Me.TblTherapyBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNotifyInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbNotify As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPillSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbINRRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbExpectedLengthOfTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbAdditionalReasonForTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbReasonForTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents dtTherapyStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCurPatID As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents CoumadinTrackerDataSet As Coumadin_Tracker.CoumadinTrackerDataSet
    Friend WithEvents TblTherapyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTherapyTableAdapter As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyTableAdapter
    Friend WithEvents TableAdapterManager As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTherapyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblTherapyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
End Class
