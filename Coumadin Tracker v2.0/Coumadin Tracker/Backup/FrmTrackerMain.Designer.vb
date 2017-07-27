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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnVerifySend = New System.Windows.Forms.Button()
        Me.dtNextINR = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn1Wk = New System.Windows.Forms.Button()
        Me.Btn2Wk = New System.Windows.Forms.Button()
        Me.Btn3Wk = New System.Windows.Forms.Button()
        Me.Btn4Wk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.Btn8Wk = New System.Windows.Forms.Button()
        Me.Btn6Wk = New System.Windows.Forms.Button()
        Me.BtnSameDose = New System.Windows.Forms.Button()
        Me.txtCurDosageInstructions = New System.Windows.Forms.TextBox()
        Me.txtPrevious = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtTherapyStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbReasonForTherapy = New System.Windows.Forms.ComboBox()
        Me.cmbAdditionalReasonForTherapy = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbExpectedLengthOfTherapy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbINRRange = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPillSize = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNotify = New System.Windows.Forms.CheckBox()
        Me.txtNotifyInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lnkPersonalize = New System.Windows.Forms.LinkLabel()
        Me.ChkEditedDetails = New System.Windows.Forms.CheckBox()
        Me.txtPatientHomePhone = New System.Windows.Forms.TextBox()
        Me.txtPatientSSN = New System.Windows.Forms.TextBox()
        Me.txtPatientCellPhone = New System.Windows.Forms.TextBox()
        Me.TxtPatientMRN = New System.Windows.Forms.TextBox()
        Me.TxtPatientDOB = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkEdited = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TblTherapyDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoumadinTrackerDataSet = New Coumadin_Tracker.CoumadinTrackerDataSet()
        Me.TblTherapyDetailsTableAdapter = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyDetailsTableAdapter()
        Me.TableAdapterManager = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager()
        Me.TblTherapyDetailstblTherapyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTherapyTableAdapter = New Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyTableAdapter()
        Me.TblTherapyDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EvaluationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtEvalDate = New System.Windows.Forms.DateTimePicker()
        Me.ChkSendTask = New System.Windows.Forms.CheckBox()
        Me.ChkVerifyResults = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbTaskPriority = New System.Windows.Forms.ComboBox()
        Me.TaskPriorityDEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorksDataSet = New Coumadin_Tracker.WorksDataSet()
        Me.ChkResultsNote = New System.Windows.Forms.CheckBox()
        Me.Task_Priority_DETableAdapter = New Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter()
        Me.ResultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblResultViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultTableAdapter = New Coumadin_Tracker.WorksDataSetTableAdapters.ResultTableAdapter()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.TblResultViewTableAdapter = New Coumadin_Tracker.WorksDataSetTableAdapters.tblResultViewTableAdapter()
        Me.EntryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnswerDETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicalDTTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsUnverifiedFLAG = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnMyInterval1 = New System.Windows.Forms.Button()
        Me.btnMyInterval2 = New System.Windows.Forms.Button()
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblTherapyDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTherapyDetailstblTherapyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResultViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVerifySend
        '
        Me.BtnVerifySend.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerifySend.Location = New System.Drawing.Point(254, 6)
        Me.BtnVerifySend.Name = "BtnVerifySend"
        Me.BtnVerifySend.Size = New System.Drawing.Size(166, 30)
        Me.BtnVerifySend.TabIndex = 0
        Me.BtnVerifySend.Text = "&Commit All"
        Me.BtnVerifySend.UseVisualStyleBackColor = True
        '
        'dtNextINR
        '
        Me.dtNextINR.CustomFormat = ""
        Me.dtNextINR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNextINR.Location = New System.Drawing.Point(146, 303)
        Me.dtNextINR.Name = "dtNextINR"
        Me.dtNextINR.Size = New System.Drawing.Size(103, 20)
        Me.dtNextINR.TabIndex = 4
        Me.dtNextINR.Value = New Date(2014, 1, 16, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Next PT/INR"
        '
        'Btn1Wk
        '
        Me.Btn1Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn1Wk.Location = New System.Drawing.Point(18, 330)
        Me.Btn1Wk.Name = "Btn1Wk"
        Me.Btn1Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn1Wk.TabIndex = 6
        Me.Btn1Wk.Text = "+&1W"
        Me.Btn1Wk.UseVisualStyleBackColor = True
        '
        'Btn2Wk
        '
        Me.Btn2Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn2Wk.Location = New System.Drawing.Point(57, 330)
        Me.Btn2Wk.Name = "Btn2Wk"
        Me.Btn2Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn2Wk.TabIndex = 7
        Me.Btn2Wk.Text = "+&2W"
        Me.Btn2Wk.UseVisualStyleBackColor = True
        '
        'Btn3Wk
        '
        Me.Btn3Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn3Wk.Location = New System.Drawing.Point(96, 330)
        Me.Btn3Wk.Name = "Btn3Wk"
        Me.Btn3Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn3Wk.TabIndex = 8
        Me.Btn3Wk.Text = "+&3W"
        Me.Btn3Wk.UseVisualStyleBackColor = True
        '
        'Btn4Wk
        '
        Me.Btn4Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn4Wk.Location = New System.Drawing.Point(134, 330)
        Me.Btn4Wk.Name = "Btn4Wk"
        Me.Btn4Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn4Wk.TabIndex = 9
        Me.Btn4Wk.Text = "+&4W"
        Me.Btn4Wk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Instructions"
        '
        'txtInstructions
        '
        Me.txtInstructions.Location = New System.Drawing.Point(19, 403)
        Me.txtInstructions.MaxLength = 200
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInstructions.Size = New System.Drawing.Size(230, 54)
        Me.txtInstructions.TabIndex = 11
        '
        'Btn8Wk
        '
        Me.Btn8Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn8Wk.Location = New System.Drawing.Point(213, 330)
        Me.Btn8Wk.Name = "Btn8Wk"
        Me.Btn8Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn8Wk.TabIndex = 13
        Me.Btn8Wk.Text = "+&8W"
        Me.Btn8Wk.UseVisualStyleBackColor = True
        '
        'Btn6Wk
        '
        Me.Btn6Wk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Btn6Wk.Location = New System.Drawing.Point(174, 330)
        Me.Btn6Wk.Name = "Btn6Wk"
        Me.Btn6Wk.Size = New System.Drawing.Size(36, 21)
        Me.Btn6Wk.TabIndex = 12
        Me.Btn6Wk.Text = "+&6W"
        Me.Btn6Wk.UseVisualStyleBackColor = True
        '
        'BtnSameDose
        '
        Me.BtnSameDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.BtnSameDose.Location = New System.Drawing.Point(57, 463)
        Me.BtnSameDose.Name = "BtnSameDose"
        Me.BtnSameDose.Size = New System.Drawing.Size(150, 22)
        Me.BtnSameDose.TabIndex = 14
        Me.BtnSameDose.Text = "Continue &Same Dose"
        Me.BtnSameDose.UseVisualStyleBackColor = True
        '
        'txtCurDosageInstructions
        '
        Me.txtCurDosageInstructions.BackColor = System.Drawing.SystemColors.Control
        Me.txtCurDosageInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurDosageInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurDosageInstructions.ForeColor = System.Drawing.Color.Red
        Me.txtCurDosageInstructions.Location = New System.Drawing.Point(234, 254)
        Me.txtCurDosageInstructions.MaximumSize = New System.Drawing.Size(811, 38)
        Me.txtCurDosageInstructions.Multiline = True
        Me.txtCurDosageInstructions.Name = "txtCurDosageInstructions"
        Me.txtCurDosageInstructions.Size = New System.Drawing.Size(792, 38)
        Me.txtCurDosageInstructions.TabIndex = 16
        '
        'txtPrevious
        '
        Me.txtPrevious.AutoSize = True
        Me.txtPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevious.Location = New System.Drawing.Point(16, 252)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(216, 17)
        Me.txtPrevious.TabIndex = 15
        Me.txtPrevious.Text = "Current Dosage Instructions:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Therapy Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Reason For Therapy"
        '
        'dtTherapyStartDate
        '
        Me.dtTherapyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTherapyStartDate.Location = New System.Drawing.Point(191, 93)
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
        Me.cmbReasonForTherapy.Location = New System.Drawing.Point(191, 119)
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
        Me.cmbAdditionalReasonForTherapy.Location = New System.Drawing.Point(191, 146)
        Me.cmbAdditionalReasonForTherapy.Name = "cmbAdditionalReasonForTherapy"
        Me.cmbAdditionalReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbAdditionalReasonForTherapy.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 147)
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
        Me.cmbExpectedLengthOfTherapy.Location = New System.Drawing.Point(191, 173)
        Me.cmbExpectedLengthOfTherapy.Name = "cmbExpectedLengthOfTherapy"
        Me.cmbExpectedLengthOfTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbExpectedLengthOfTherapy.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 174)
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
        Me.cmbINRRange.Location = New System.Drawing.Point(449, 144)
        Me.cmbINRRange.Name = "cmbINRRange"
        Me.cmbINRRange.Size = New System.Drawing.Size(101, 21)
        Me.cmbINRRange.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(357, 148)
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
        Me.cmbPillSize.Location = New System.Drawing.Point(449, 119)
        Me.cmbPillSize.Name = "cmbPillSize"
        Me.cmbPillSize.Size = New System.Drawing.Size(101, 21)
        Me.cmbPillSize.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(357, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Pill Size at Home"
        '
        'cbNotify
        '
        Me.cbNotify.AutoSize = True
        Me.cbNotify.Location = New System.Drawing.Point(359, 174)
        Me.cbNotify.Name = "cbNotify"
        Me.cbNotify.Size = New System.Drawing.Size(85, 17)
        Me.cbNotify.TabIndex = 30
        Me.cbNotify.Text = "Notify When"
        Me.cbNotify.UseVisualStyleBackColor = True
        '
        'txtNotifyInterval
        '
        Me.txtNotifyInterval.Location = New System.Drawing.Point(449, 173)
        Me.txtNotifyInterval.Name = "txtNotifyInterval"
        Me.txtNotifyInterval.Size = New System.Drawing.Size(32, 20)
        Me.txtNotifyInterval.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "days overdue"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(905, 10)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 22)
        Me.BtnCancel.TabIndex = 33
        Me.BtnCancel.Text = "Cance&l"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lnkPersonalize)
        Me.Panel1.Controls.Add(Me.ChkEditedDetails)
        Me.Panel1.Controls.Add(Me.txtPatientHomePhone)
        Me.Panel1.Controls.Add(Me.txtPatientSSN)
        Me.Panel1.Controls.Add(Me.txtPatientCellPhone)
        Me.Panel1.Controls.Add(Me.TxtPatientMRN)
        Me.Panel1.Controls.Add(Me.TxtPatientDOB)
        Me.Panel1.Controls.Add(Me.txtPatientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.ChkEdited)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 65)
        Me.Panel1.TabIndex = 35
        '
        'lnkPersonalize
        '
        Me.lnkPersonalize.AutoSize = True
        Me.lnkPersonalize.Location = New System.Drawing.Point(948, 3)
        Me.lnkPersonalize.Name = "lnkPersonalize"
        Me.lnkPersonalize.Size = New System.Drawing.Size(61, 13)
        Me.lnkPersonalize.TabIndex = 49
        Me.lnkPersonalize.TabStop = True
        Me.lnkPersonalize.Text = "Personalize"
        '
        'ChkEditedDetails
        '
        Me.ChkEditedDetails.AutoSize = True
        Me.ChkEditedDetails.Location = New System.Drawing.Point(925, 42)
        Me.ChkEditedDetails.Name = "ChkEditedDetails"
        Me.ChkEditedDetails.Size = New System.Drawing.Size(91, 17)
        Me.ChkEditedDetails.TabIndex = 48
        Me.ChkEditedDetails.Text = "Details Edited"
        Me.ChkEditedDetails.UseVisualStyleBackColor = True
        Me.ChkEditedDetails.Visible = False
        '
        'txtPatientHomePhone
        '
        Me.txtPatientHomePhone.BackColor = System.Drawing.Color.Khaki
        Me.txtPatientHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientHomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientHomePhone.Location = New System.Drawing.Point(767, 3)
        Me.txtPatientHomePhone.Name = "txtPatientHomePhone"
        Me.txtPatientHomePhone.ReadOnly = True
        Me.txtPatientHomePhone.Size = New System.Drawing.Size(157, 19)
        Me.txtPatientHomePhone.TabIndex = 45
        '
        'txtPatientSSN
        '
        Me.txtPatientSSN.BackColor = System.Drawing.Color.Khaki
        Me.txtPatientSSN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientSSN.Location = New System.Drawing.Point(419, 34)
        Me.txtPatientSSN.Name = "txtPatientSSN"
        Me.txtPatientSSN.ReadOnly = True
        Me.txtPatientSSN.Size = New System.Drawing.Size(209, 19)
        Me.txtPatientSSN.TabIndex = 46
        '
        'txtPatientCellPhone
        '
        Me.txtPatientCellPhone.BackColor = System.Drawing.Color.Khaki
        Me.txtPatientCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientCellPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientCellPhone.Location = New System.Drawing.Point(767, 33)
        Me.txtPatientCellPhone.Name = "txtPatientCellPhone"
        Me.txtPatientCellPhone.ReadOnly = True
        Me.txtPatientCellPhone.Size = New System.Drawing.Size(157, 19)
        Me.txtPatientCellPhone.TabIndex = 47
        '
        'TxtPatientMRN
        '
        Me.TxtPatientMRN.BackColor = System.Drawing.Color.Khaki
        Me.TxtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPatientMRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientMRN.Location = New System.Drawing.Point(419, 4)
        Me.TxtPatientMRN.Name = "TxtPatientMRN"
        Me.TxtPatientMRN.ReadOnly = True
        Me.TxtPatientMRN.Size = New System.Drawing.Size(209, 19)
        Me.TxtPatientMRN.TabIndex = 44
        '
        'TxtPatientDOB
        '
        Me.TxtPatientDOB.BackColor = System.Drawing.Color.Khaki
        Me.TxtPatientDOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPatientDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientDOB.Location = New System.Drawing.Point(82, 34)
        Me.TxtPatientDOB.Name = "TxtPatientDOB"
        Me.TxtPatientDOB.ReadOnly = True
        Me.TxtPatientDOB.Size = New System.Drawing.Size(270, 19)
        Me.TxtPatientDOB.TabIndex = 43
        '
        'txtPatientName
        '
        Me.txtPatientName.BackColor = System.Drawing.Color.Khaki
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(82, 4)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.ReadOnly = True
        Me.txtPatientName.Size = New System.Drawing.Size(270, 19)
        Me.txtPatientName.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(356, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 20)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "SSN:"
        '
        'ChkEdited
        '
        Me.ChkEdited.AutoSize = True
        Me.ChkEdited.Location = New System.Drawing.Point(925, 22)
        Me.ChkEdited.Name = "ChkEdited"
        Me.ChkEdited.Size = New System.Drawing.Size(56, 17)
        Me.ChkEdited.TabIndex = 38
        Me.ChkEdited.Text = "Edited"
        Me.ChkEdited.UseVisualStyleBackColor = True
        Me.ChkEdited.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(639, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Cell Phone:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(639, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 20)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Home Phone:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(356, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "MRN:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "DOB:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Patient:"
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
        'TblTherapyDetailstblTherapyBindingSource
        '
        Me.TblTherapyDetailstblTherapyBindingSource.DataMember = "tblTherapyDetails_tblTherapy"
        Me.TblTherapyDetailstblTherapyBindingSource.DataSource = Me.TblTherapyDetailsBindingSource
        '
        'TblTherapyTableAdapter
        '
        Me.TblTherapyTableAdapter.ClearBeforeFill = True
        '
        'TblTherapyDetailsDataGridView
        '
        Me.TblTherapyDetailsDataGridView.AllowUserToAddRows = False
        Me.TblTherapyDetailsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TblTherapyDetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblTherapyDetailsDataGridView.AutoGenerateColumns = False
        Me.TblTherapyDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.TblTherapyDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TblTherapyDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTherapyDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EvaluationDate, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.TblTherapyDetailsDataGridView.DataSource = Me.TblTherapyDetailsBindingSource
        Me.TblTherapyDetailsDataGridView.Location = New System.Drawing.Point(267, 303)
        Me.TblTherapyDetailsDataGridView.Name = "TblTherapyDetailsDataGridView"
        Me.TblTherapyDetailsDataGridView.ReadOnly = True
        Me.TblTherapyDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TblTherapyDetailsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblTherapyDetailsDataGridView.ShowEditingIcon = False
        Me.TblTherapyDetailsDataGridView.Size = New System.Drawing.Size(759, 220)
        Me.TblTherapyDetailsDataGridView.TabIndex = 36
        '
        'EvaluationDate
        '
        Me.EvaluationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EvaluationDate.DataPropertyName = "EvaluationDate"
        Me.EvaluationDate.HeaderText = "Eval Date"
        Me.EvaluationDate.Name = "EvaluationDate"
        Me.EvaluationDate.ReadOnly = True
        Me.EvaluationDate.Width = 78
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Instructions"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Instructions"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NextINR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Next INR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 507)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Evaluation Date"
        '
        'dtEvalDate
        '
        Me.dtEvalDate.CustomFormat = ""
        Me.dtEvalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEvalDate.Location = New System.Drawing.Point(146, 503)
        Me.dtEvalDate.Name = "dtEvalDate"
        Me.dtEvalDate.Size = New System.Drawing.Size(103, 20)
        Me.dtEvalDate.TabIndex = 39
        Me.dtEvalDate.Value = New Date(2014, 1, 16, 0, 0, 0, 0)
        '
        'ChkSendTask
        '
        Me.ChkSendTask.AutoSize = True
        Me.ChkSendTask.Enabled = False
        Me.ChkSendTask.Location = New System.Drawing.Point(625, 13)
        Me.ChkSendTask.Name = "ChkSendTask"
        Me.ChkSendTask.Size = New System.Drawing.Size(78, 17)
        Me.ChkSendTask.TabIndex = 41
        Me.ChkSendTask.Text = "Send Task"
        Me.ChkSendTask.UseVisualStyleBackColor = True
        '
        'ChkVerifyResults
        '
        Me.ChkVerifyResults.AutoSize = True
        Me.ChkVerifyResults.Enabled = False
        Me.ChkVerifyResults.Location = New System.Drawing.Point(436, 13)
        Me.ChkVerifyResults.Name = "ChkVerifyResults"
        Me.ChkVerifyResults.Size = New System.Drawing.Size(90, 17)
        Me.ChkVerifyResults.TabIndex = 42
        Me.ChkVerifyResults.Text = "Verify Results"
        Me.ChkVerifyResults.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmbTaskPriority)
        Me.Panel2.Controls.Add(Me.ChkResultsNote)
        Me.Panel2.Controls.Add(Me.ChkVerifyResults)
        Me.Panel2.Controls.Add(Me.ChkSendTask)
        Me.Panel2.Controls.Add(Me.BtnVerifySend)
        Me.Panel2.Controls.Add(Me.BtnCancel)
        Me.Panel2.Location = New System.Drawing.Point(12, 535)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 44)
        Me.Panel2.TabIndex = 43
        '
        'cmbTaskPriority
        '
        Me.cmbTaskPriority.DataSource = Me.TaskPriorityDEBindingSource
        Me.cmbTaskPriority.DisplayMember = "EntryName"
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(708, 10)
        Me.cmbTaskPriority.Name = "cmbTaskPriority"
        Me.cmbTaskPriority.Size = New System.Drawing.Size(113, 21)
        Me.cmbTaskPriority.TabIndex = 44
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
        'ChkResultsNote
        '
        Me.ChkResultsNote.AutoSize = True
        Me.ChkResultsNote.Enabled = False
        Me.ChkResultsNote.Location = New System.Drawing.Point(532, 13)
        Me.ChkResultsNote.Name = "ChkResultsNote"
        Me.ChkResultsNote.Size = New System.Drawing.Size(87, 17)
        Me.ChkResultsNote.TabIndex = 43
        Me.ChkResultsNote.Text = "Results Note"
        Me.ChkResultsNote.UseVisualStyleBackColor = True
        '
        'Task_Priority_DETableAdapter
        '
        Me.Task_Priority_DETableAdapter.ClearBeforeFill = True
        '
        'ResultsDataGridView
        '
        Me.ResultsDataGridView.AllowUserToAddRows = False
        Me.ResultsDataGridView.AllowUserToDeleteRows = False
        Me.ResultsDataGridView.AutoGenerateColumns = False
        Me.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ResultsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntryName, Me.AnswerDETDataGridViewTextBoxColumn, Me.ClinicalDTTMDataGridViewTextBoxColumn, Me.IsUnverifiedFLAG})
        Me.ResultsDataGridView.DataSource = Me.TblResultViewBindingSource
        Me.ResultsDataGridView.Location = New System.Drawing.Point(585, 89)
        Me.ResultsDataGridView.Name = "ResultsDataGridView"
        Me.ResultsDataGridView.ReadOnly = True
        Me.ResultsDataGridView.Size = New System.Drawing.Size(441, 155)
        Me.ResultsDataGridView.TabIndex = 44
        '
        'TblResultViewBindingSource
        '
        Me.TblResultViewBindingSource.DataMember = "tblResultView"
        Me.TblResultViewBindingSource.DataSource = Me.WorksDataSetBindingSource
        '
        'WorksDataSetBindingSource
        '
        Me.WorksDataSetBindingSource.DataSource = Me.WorksDataSet
        Me.WorksDataSetBindingSource.Position = 0
        '
        'ResultBindingSource
        '
        Me.ResultBindingSource.DataMember = "Result"
        Me.ResultBindingSource.DataSource = Me.WorksDataSet
        '
        'ResultTableAdapter
        '
        Me.ResultTableAdapter.ClearBeforeFill = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 203)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Comments"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(191, 203)
        Me.txtComments.MaxLength = 200
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(359, 40)
        Me.txtComments.TabIndex = 46
        '
        'TblResultViewTableAdapter
        '
        Me.TblResultViewTableAdapter.ClearBeforeFill = True
        '
        'EntryName
        '
        Me.EntryName.DataPropertyName = "EntryName"
        Me.EntryName.HeaderText = "Type"
        Me.EntryName.Name = "EntryName"
        Me.EntryName.ReadOnly = True
        Me.EntryName.Width = 56
        '
        'AnswerDETDataGridViewTextBoxColumn
        '
        Me.AnswerDETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AnswerDETDataGridViewTextBoxColumn.DataPropertyName = "AnswerDET"
        Me.AnswerDETDataGridViewTextBoxColumn.HeaderText = "Result"
        Me.AnswerDETDataGridViewTextBoxColumn.Name = "AnswerDETDataGridViewTextBoxColumn"
        Me.AnswerDETDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClinicalDTTMDataGridViewTextBoxColumn
        '
        Me.ClinicalDTTMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClinicalDTTMDataGridViewTextBoxColumn.DataPropertyName = "ClinicalDTTM"
        Me.ClinicalDTTMDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.ClinicalDTTMDataGridViewTextBoxColumn.Name = "ClinicalDTTMDataGridViewTextBoxColumn"
        Me.ClinicalDTTMDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClinicalDTTMDataGridViewTextBoxColumn.Width = 55
        '
        'IsUnverifiedFLAG
        '
        Me.IsUnverifiedFLAG.DataPropertyName = "IsUnverifiedFLAG"
        Me.IsUnverifiedFLAG.HeaderText = "IsUnverifiedFLAG"
        Me.IsUnverifiedFLAG.Name = "IsUnverifiedFLAG"
        Me.IsUnverifiedFLAG.ReadOnly = True
        Me.IsUnverifiedFLAG.Visible = False
        Me.IsUnverifiedFLAG.Width = 96
        '
        'btnMyInterval1
        '
        Me.btnMyInterval1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.btnMyInterval1.Location = New System.Drawing.Point(18, 358)
        Me.btnMyInterval1.Name = "btnMyInterval1"
        Me.btnMyInterval1.Size = New System.Drawing.Size(82, 21)
        Me.btnMyInterval1.TabIndex = 47
        Me.btnMyInterval1.Text = "+&My Interval 1"
        Me.btnMyInterval1.UseVisualStyleBackColor = True
        '
        'btnMyInterval2
        '
        Me.btnMyInterval2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.btnMyInterval2.Location = New System.Drawing.Point(134, 358)
        Me.btnMyInterval2.Name = "btnMyInterval2"
        Me.btnMyInterval2.Size = New System.Drawing.Size(82, 21)
        Me.btnMyInterval2.TabIndex = 48
        Me.btnMyInterval2.Text = "+M&y Interval 2"
        Me.btnMyInterval2.UseVisualStyleBackColor = True
        '
        'FrmTrackerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 593)
        Me.Controls.Add(Me.btnMyInterval2)
        Me.Controls.Add(Me.btnMyInterval1)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ResultsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtEvalDate)
        Me.Controls.Add(Me.TblTherapyDetailsDataGridView)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.txtCurDosageInstructions)
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
        Me.Name = "FrmTrackerMain"
        Me.Text = "Blood Thinner Therapy Tracking"
        CType(Me.txtNotifyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblTherapyDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoumadinTrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTherapyDetailstblTherapyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTherapyDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TaskPriorityDEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResultViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVerifySend As System.Windows.Forms.Button
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
    Friend WithEvents txtCurDosageInstructions As System.Windows.Forms.TextBox
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
    Friend WithEvents ChkEdited As System.Windows.Forms.CheckBox
    Friend WithEvents TableAdapterManager As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTherapyDetailstblTherapyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTherapyTableAdapter As Coumadin_Tracker.CoumadinTrackerDataSetTableAdapters.tblTherapyTableAdapter
    Friend WithEvents TblTherapyDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtEvalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EvaluationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChkSendTask As System.Windows.Forms.CheckBox
    Friend WithEvents ChkVerifyResults As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ChkResultsNote As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents WorksDataSet As Coumadin_Tracker.WorksDataSet
    Friend WithEvents TaskPriorityDEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Task_Priority_DETableAdapter As Coumadin_Tracker.WorksDataSetTableAdapters.Task_Priority_DETableAdapter
    Friend WithEvents ResultsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WorksDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultTableAdapter As Coumadin_Tracker.WorksDataSetTableAdapters.ResultTableAdapter
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents ChkEditedDetails As System.Windows.Forms.CheckBox
    Friend WithEvents lnkPersonalize As System.Windows.Forms.LinkLabel
    Friend WithEvents TblResultViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblResultViewTableAdapter As Coumadin_Tracker.WorksDataSetTableAdapters.tblResultViewTableAdapter
    Friend WithEvents EntryName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnswerDETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClinicalDTTMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsUnverifiedFLAG As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnMyInterval1 As System.Windows.Forms.Button
    Friend WithEvents btnMyInterval2 As System.Windows.Forms.Button

End Class
