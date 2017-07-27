<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrackerMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrackerMain))
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtNextINR = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btn1Wk = New System.Windows.Forms.Button
        Me.Btn2Wk = New System.Windows.Forms.Button
        Me.Btn3Wk = New System.Windows.Forms.Button
        Me.Btn4Wk = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInstructions = New System.Windows.Forms.TextBox
        Me.Btn8Wk = New System.Windows.Forms.Button
        Me.Btn6Wk = New System.Windows.Forms.Button
        Me.BtnSameDose = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.txtPrevious = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtTherapyStartDate = New System.Windows.Forms.DateTimePicker
        Me.cmbReasonForTherapy = New System.Windows.Forms.ComboBox
        Me.cmbAdditionalReasonForTherapy = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbExpectedLengthOfTherapy = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbINRRange = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbPillSize = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbNotify = New System.Windows.Forms.CheckBox
        Me.txtNotifyInterval = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.txtCurPatID = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtPatientHomePhone = New System.Windows.Forms.TextBox
        Me.txtPatientSSN = New System.Windows.Forms.TextBox
        Me.txtPatientCellPhone = New System.Windows.Forms.TextBox
        Me.TxtPatientMRN = New System.Windows.Forms.TextBox
        Me.TxtPatientDOB = New System.Windows.Forms.TextBox
        Me.txtPatientName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TblTherapyDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblTherapyDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoumadinTrackerDataSet = New Coumadin_Tracker.CoumadinTrackerDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TblTherapyDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblTherapyDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.PatIDToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.PatIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.TblTherapyDetailsTableAdapter = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyDetailsTableAdapter
        Me.TableAdapterManager = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblTherapyDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTherapyDetailsBindingNavigator.SuspendLayout()
        CType(Me.TblTherapyDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Verify and Send Instructions"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtNextINR
        '
        Me.dtNextINR.CustomFormat = ""
        Me.dtNextINR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNextINR.Location = New System.Drawing.Point(142, 265)
        Me.dtNextINR.Name = "dtNextINR"
        Me.dtNextINR.Size = New System.Drawing.Size(103, 20)
        Me.dtNextINR.TabIndex = 4
        Me.dtNextINR.Value = New Date(2013, 5, 24, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Next PT/INR"
        '
        'Btn1Wk
        '
        Me.Btn1Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn1Wk.Location = New System.Drawing.Point(13, 292)
        Me.Btn1Wk.Name = "Btn1Wk"
        Me.Btn1Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn1Wk.TabIndex = 6
        Me.Btn1Wk.Text = "+&1W"
        Me.Btn1Wk.UseVisualStyleBackColor = True
        '
        'Btn2Wk
        '
        Me.Btn2Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn2Wk.Location = New System.Drawing.Point(52, 292)
        Me.Btn2Wk.Name = "Btn2Wk"
        Me.Btn2Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn2Wk.TabIndex = 7
        Me.Btn2Wk.Text = "+&2W"
        Me.Btn2Wk.UseVisualStyleBackColor = True
        '
        'Btn3Wk
        '
        Me.Btn3Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn3Wk.Location = New System.Drawing.Point(91, 292)
        Me.Btn3Wk.Name = "Btn3Wk"
        Me.Btn3Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn3Wk.TabIndex = 8
        Me.Btn3Wk.Text = "+&3W"
        Me.Btn3Wk.UseVisualStyleBackColor = True
        '
        'Btn4Wk
        '
        Me.Btn4Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn4Wk.Location = New System.Drawing.Point(130, 292)
        Me.Btn4Wk.Name = "Btn4Wk"
        Me.Btn4Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn4Wk.TabIndex = 9
        Me.Btn4Wk.Text = "+&4W"
        Me.Btn4Wk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Instructions"
        '
        'txtInstructions
        '
        Me.txtInstructions.Location = New System.Drawing.Point(15, 335)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.Size = New System.Drawing.Size(230, 36)
        Me.txtInstructions.TabIndex = 11
        '
        'Btn8Wk
        '
        Me.Btn8Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn8Wk.Location = New System.Drawing.Point(209, 292)
        Me.Btn8Wk.Name = "Btn8Wk"
        Me.Btn8Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn8Wk.TabIndex = 13
        Me.Btn8Wk.Text = "+&8W"
        Me.Btn8Wk.UseVisualStyleBackColor = True
        '
        'Btn6Wk
        '
        Me.Btn6Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn6Wk.Location = New System.Drawing.Point(170, 292)
        Me.Btn6Wk.Name = "Btn6Wk"
        Me.Btn6Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn6Wk.TabIndex = 12
        Me.Btn6Wk.Text = "+&6W"
        Me.Btn6Wk.UseVisualStyleBackColor = True
        '
        'BtnSameDose
        '
        Me.BtnSameDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.BtnSameDose.Location = New System.Drawing.Point(52, 377)
        Me.BtnSameDose.Name = "BtnSameDose"
        Me.BtnSameDose.Size = New System.Drawing.Size(150, 22)
        Me.BtnSameDose.TabIndex = 14
        Me.BtnSameDose.Text = "&Continue Same Dose"
        Me.BtnSameDose.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 223)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 36)
        Me.TextBox2.TabIndex = 16
        '
        'txtPrevious
        '
        Me.txtPrevious.AutoSize = True
        Me.txtPrevious.Location = New System.Drawing.Point(12, 207)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(105, 13)
        Me.txtPrevious.TabIndex = 15
        Me.txtPrevious.Text = "Previous Instructions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Therapy Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Reason For Therapy"
        '
        'dtTherapyStartDate
        '
        Me.dtTherapyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTherapyStartDate.Location = New System.Drawing.Point(170, 70)
        Me.dtTherapyStartDate.Name = "dtTherapyStartDate"
        Me.dtTherapyStartDate.Size = New System.Drawing.Size(97, 20)
        Me.dtTherapyStartDate.TabIndex = 20
        '
        'cmbReasonForTherapy
        '
        Me.cmbReasonForTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReasonForTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReasonForTherapy.DropDownWidth = 200
        Me.cmbReasonForTherapy.FormattingEnabled = True
        Me.cmbReasonForTherapy.Items.AddRange(New Object() {"Anticardiolipin Antibody Syndrome", "Artificial Heart Valves", "Atrial Fibrillation", "Atrial Flutter", "Cardiac Thrombus", "Cardiomyopathy", "CHF", "CVA", "DVT", "DVT/PE", "EVAR", "Factor 5", "Hypercoaguable State", "Intra-Abdominal Thrombosis", "Joint Replacement", "PE", "PFO", "Recurrent DVT", "Recurrent PE", "Stenting", "TIA", "Valvular Heart Disease"})
        Me.cmbReasonForTherapy.Location = New System.Drawing.Point(170, 96)
        Me.cmbReasonForTherapy.Name = "cmbReasonForTherapy"
        Me.cmbReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbReasonForTherapy.TabIndex = 21
        '
        'cmbAdditionalReasonForTherapy
        '
        Me.cmbAdditionalReasonForTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAdditionalReasonForTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAdditionalReasonForTherapy.DropDownWidth = 200
        Me.cmbAdditionalReasonForTherapy.FormattingEnabled = True
        Me.cmbAdditionalReasonForTherapy.Items.AddRange(New Object() {"Anticardiolipin Antibody Syndrome", "Artificial Heart Valves", "Atrial Fibrillation", "Atrial Flutter", "Cardiac Thrombus", "Cardiomyopathy", "CHF", "CVA", "DVT", "DVT/PE", "EVAR", "Factor 5", "Hypercoaguable State", "Intra-Abdominal Thrombosis", "Joint Replacement", "PE", "PFO", "Recurrent DVT", "Recurrent PE", "Stenting", "TIA", "Valvular Heart Disease"})
        Me.cmbAdditionalReasonForTherapy.Location = New System.Drawing.Point(170, 123)
        Me.cmbAdditionalReasonForTherapy.Name = "cmbAdditionalReasonForTherapy"
        Me.cmbAdditionalReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbAdditionalReasonForTherapy.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Additional Reason For Therapy"
        '
        'cmbExpectedLengthOfTherapy
        '
        Me.cmbExpectedLengthOfTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbExpectedLengthOfTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbExpectedLengthOfTherapy.FormattingEnabled = True
        Me.cmbExpectedLengthOfTherapy.Items.AddRange(New Object() {"Lifelong", "1 Month", "6 Weeks", "2 Months", "3 Months", "4 Months", "5 Months", "6 Months", "7 Months", "8 Months", "9 Months", "10 Months", "11 Months", "1 Year"})
        Me.cmbExpectedLengthOfTherapy.Location = New System.Drawing.Point(170, 150)
        Me.cmbExpectedLengthOfTherapy.Name = "cmbExpectedLengthOfTherapy"
        Me.cmbExpectedLengthOfTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbExpectedLengthOfTherapy.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Expected Length Of Therapy"
        '
        'cmbINRRange
        '
        Me.cmbINRRange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbINRRange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbINRRange.FormattingEnabled = True
        Me.cmbINRRange.Items.AddRange(New Object() {"1.8 - 2.0", "1.8 - 2.3", "2.0 - 2.5", "2.0 - 3.0", "2.0 - 4.0", "2.5 - 3.0", "2.5 - 3.5", "3.0 - 4.0"})
        Me.cmbINRRange.Location = New System.Drawing.Point(428, 122)
        Me.cmbINRRange.Name = "cmbINRRange"
        Me.cmbINRRange.Size = New System.Drawing.Size(101, 21)
        Me.cmbINRRange.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(336, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "INR Range"
        '
        'cmbPillSize
        '
        Me.cmbPillSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPillSize.FormattingEnabled = True
        Me.cmbPillSize.Items.AddRange(New Object() {"1 mg", "2 mg", "2.5 mg", "3 mg", "4 mg", "5 mg", "7.5 mg", "10 mg"})
        Me.cmbPillSize.Location = New System.Drawing.Point(428, 97)
        Me.cmbPillSize.Name = "cmbPillSize"
        Me.cmbPillSize.Size = New System.Drawing.Size(101, 21)
        Me.cmbPillSize.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Pill Size at Home"
        '
        'cbNotify
        '
        Me.cbNotify.AutoSize = True
        Me.cbNotify.Location = New System.Drawing.Point(338, 152)
        Me.cbNotify.Name = "cbNotify"
        Me.cbNotify.Size = New System.Drawing.Size(85, 17)
        Me.cbNotify.TabIndex = 30
        Me.cbNotify.Text = "Notify When"
        Me.cbNotify.UseVisualStyleBackColor = True
        '
        'txtNotifyInterval
        '
        Me.txtNotifyInterval.Location = New System.Drawing.Point(428, 151)
        Me.txtNotifyInterval.Name = "txtNotifyInterval"
        Me.txtNotifyInterval.Size = New System.Drawing.Size(32, 20)
        Me.txtNotifyInterval.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(461, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "days overdue"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(786, 422)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 22)
        Me.BtnCancel.TabIndex = 33
        Me.BtnCancel.Text = "Cance&l"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'txtCurPatID
        '
        Me.txtCurPatID.Location = New System.Drawing.Point(804, 65)
        Me.txtCurPatID.Name = "txtCurPatID"
        Me.txtCurPatID.Size = New System.Drawing.Size(71, 20)
        Me.txtCurPatID.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPatientHomePhone)
        Me.Panel1.Controls.Add(Me.txtPatientSSN)
        Me.Panel1.Controls.Add(Me.txtPatientCellPhone)
        Me.Panel1.Controls.Add(Me.TxtPatientMRN)
        Me.Panel1.Controls.Add(Me.TxtPatientDOB)
        Me.Panel1.Controls.Add(Me.txtPatientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(8, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 46)
        Me.Panel1.TabIndex = 35
        '
        'txtPatientHomePhone
        '
        Me.txtPatientHomePhone.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPatientHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientHomePhone.Location = New System.Drawing.Point(712, 4)
        Me.txtPatientHomePhone.Name = "txtPatientHomePhone"
        Me.txtPatientHomePhone.Size = New System.Drawing.Size(148, 13)
        Me.txtPatientHomePhone.TabIndex = 45
        '
        'txtPatientSSN
        '
        Me.txtPatientSSN.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPatientSSN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientSSN.Location = New System.Drawing.Point(384, 22)
        Me.txtPatientSSN.Name = "txtPatientSSN"
        Me.txtPatientSSN.Size = New System.Drawing.Size(148, 13)
        Me.txtPatientSSN.TabIndex = 46
        '
        'txtPatientCellPhone
        '
        Me.txtPatientCellPhone.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPatientCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientCellPhone.Location = New System.Drawing.Point(712, 22)
        Me.txtPatientCellPhone.Name = "txtPatientCellPhone"
        Me.txtPatientCellPhone.Size = New System.Drawing.Size(148, 13)
        Me.txtPatientCellPhone.TabIndex = 47
        '
        'TxtPatientMRN
        '
        Me.TxtPatientMRN.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPatientMRN.Location = New System.Drawing.Point(384, 4)
        Me.TxtPatientMRN.Name = "TxtPatientMRN"
        Me.TxtPatientMRN.Size = New System.Drawing.Size(148, 13)
        Me.TxtPatientMRN.TabIndex = 44
        '
        'TxtPatientDOB
        '
        Me.TxtPatientDOB.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtPatientDOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPatientDOB.Location = New System.Drawing.Point(57, 22)
        Me.TxtPatientDOB.Name = "TxtPatientDOB"
        Me.TxtPatientDOB.Size = New System.Drawing.Size(261, 13)
        Me.TxtPatientDOB.TabIndex = 43
        '
        'txtPatientName
        '
        Me.txtPatientName.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientName.Location = New System.Drawing.Point(57, 4)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(261, 13)
        Me.txtPatientName.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(339, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "SSN:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(624, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Cell Phone:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(624, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Home Phone:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(339, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "MRN:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "DOB:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Patient:"
        '
        'TblTherapyDetailsBindingNavigator
        '
        Me.TblTherapyDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTherapyDetailsBindingNavigator.BindingSource = Me.TblTherapyDetailsBindingSource
        Me.TblTherapyDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTherapyDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTherapyDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTherapyDetailsBindingNavigatorSaveItem})
        Me.TblTherapyDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTherapyDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTherapyDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTherapyDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTherapyDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTherapyDetailsBindingNavigator.Name = "TblTherapyDetailsBindingNavigator"
        Me.TblTherapyDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTherapyDetailsBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.TblTherapyDetailsBindingNavigator.TabIndex = 36
        Me.TblTherapyDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'TblTherapyDetailsBindingSource
        '
        Me.TblTherapyDetailsBindingSource.DataMember = "tblTherapyDetails"
        Me.TblTherapyDetailsBindingSource.DataSource = Me.CoumadinTrackerDataSet
        '
        'CoumadinTrackerDataSet
        '
        Me.CoumadinTrackerDataSet.DataSetName = "CoumadinTrackerDataSet"
        Me.CoumadinTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblTherapyDetailsBindingNavigatorSaveItem
        '
        Me.TblTherapyDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTherapyDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTherapyDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTherapyDetailsBindingNavigatorSaveItem.Name = "TblTherapyDetailsBindingNavigatorSaveItem"
        Me.TblTherapyDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTherapyDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTherapyDetailsDataGridView
        '
        Me.TblTherapyDetailsDataGridView.AllowUserToAddRows = False
        Me.TblTherapyDetailsDataGridView.AllowUserToDeleteRows = False
        Me.TblTherapyDetailsDataGridView.AutoGenerateColumns = False
        Me.TblTherapyDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTherapyDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblTherapyDetailsDataGridView.DataSource = Me.TblTherapyDetailsBindingSource
        Me.TblTherapyDetailsDataGridView.Location = New System.Drawing.Point(317, 196)
        Me.TblTherapyDetailsDataGridView.Name = "TblTherapyDetailsDataGridView"
        Me.TblTherapyDetailsDataGridView.ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Size = New System.Drawing.Size(357, 220)
        Me.TblTherapyDetailsDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PreviousInstructions"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PreviousInstructions"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NextINR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NextINR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Instructions"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Instructions"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatIDToolStripLabel, Me.PatIDToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(896, 25)
        Me.FillByToolStrip.TabIndex = 37
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'PatIDToolStripLabel
        '
        Me.PatIDToolStripLabel.Name = "PatIDToolStripLabel"
        Me.PatIDToolStripLabel.Size = New System.Drawing.Size(38, 22)
        Me.PatIDToolStripLabel.Text = "PatID:"
        '
        'PatIDToolStripTextBox
        '
        Me.PatIDToolStripTextBox.Name = "PatIDToolStripTextBox"
        Me.PatIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'TblTherapyDetailsTableAdapter
        '
        Me.TblTherapyDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblTherapyDetailsTableAdapter = Me.TblTherapyDetailsTableAdapter
        Me.TableAdapterManager.tblTherapyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmTrackerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 508)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.TblTherapyDetailsDataGridView)
        Me.Controls.Add(Me.TblTherapyDetailsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNotifyInterval)
        Me.Controls.Add(Me.cbNotify)
        Me.Controls.Add(Me.cmbPillSize)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbINRRange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbExpectedLengthOfTherapy)
        Me.Controls.Add(Me.txtCurPatID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbAdditionalReasonForTherapy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbReasonForTherapy)
        Me.Controls.Add(Me.dtTherapyStartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtPrevious)
        Me.Controls.Add(Me.BtnSameDose)
        Me.Controls.Add(Me.Btn8Wk)
        Me.Controls.Add(Me.Btn6Wk)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn4Wk)
        Me.Controls.Add(Me.Btn3Wk)
        Me.Controls.Add(Me.Btn2Wk)
        Me.Controls.Add(Me.Btn1Wk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtNextINR)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmTrackerMain"
        Me.Text = "Form1"
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblTherapyDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTherapyDetailsBindingNavigator.ResumeLayout(False)
        Me.TblTherapyDetailsBindingNavigator.PerformLayout()
        CType(Me.TblTherapyDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtNextINR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn1Wk As System.Windows.Forms.Button
    Friend WithEvents Btn2Wk As System.Windows.Forms.Button
    Friend WithEvents Btn3Wk As System.Windows.Forms.Button
    Friend WithEvents Btn4Wk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents Btn8Wk As System.Windows.Forms.Button
    Friend WithEvents Btn6Wk As System.Windows.Forms.Button
    Friend WithEvents BtnSameDose As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrevious As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtTherapyStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbReasonForTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAdditionalReasonForTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbExpectedLengthOfTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbINRRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbPillSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbNotify As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotifyInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCurPatID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPatientHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientMRN As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents CoumadinTrackerDataSet As Coumadin_Tracker.CoumadinTrackerDataSet
    Friend WithEvents TblTherapyDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTherapyDetailsTableAdapter As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyDetailsTableAdapter
    Friend WithEvents TableAdapterManager As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTherapyDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTherapyDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTherapyDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PatIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PatIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton

End Class
