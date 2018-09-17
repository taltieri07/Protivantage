Imports System.Data.SqlClient
Imports System.Xml
Imports System.Configuration
Imports System.Text

Public Class FrmTrackerMain
    Implements IMessageFilter

    Dim ConnSettingsInfo As SqlConnection
    Dim MyCommand As SqlCommand               'reads the records from database	
    Dim MyCommand2 As SqlCommand               'reads the records from database
    Dim MyCommand3 As SqlCommand
    Dim drThpInfo As SqlDataReader         'stores the retrieved records
    Dim drSettingsInfo As SqlDataReader
    Dim drSettingsPersonal As SqlDataReader
    Dim SelectString As String                  'Sql Query
    Dim SelectStringSettings As String
    Dim InsertString As String
    Dim ConnString As String                    'Connection String

    '**********Commented out to disable encryption unless executable is run outside of TouchWorks
    ' Public m_Section As String

    'Public Sub ProtectSection()
    ' Get the current configuration file.
    'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    'Dim protectedSection As ConfigurationSection = config.GetSection("appSettings")

    ' Encrypts when possible
    '   If ((protectedSection IsNot Nothing) _
    '  AndAlso (Not protectedSection.IsReadOnly) _
    ' AndAlso (Not protectedSection.SectionInformation.IsProtected) _
    'AndAlso (Not protectedSection.SectionInformation.IsLocked)) Then
    ' Protect (encrypt)the section.
    '   protectedSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
    'this is for the Connection String
    '  config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
    ' Save the encrypted section.
    '  protectedSection.SectionInformation.ForceSave = True
    '   config.Save(ConfigurationSaveMode.Full)
    'End If

    'End Sub
    '******************************************************

    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage

        Dim mouse As Boolean = (m.Msg >= &H200 And m.Msg <= &H20D) Or (m.Msg >= &HA0 And m.Msg <= &HAD)
        Dim kbd As Boolean = (m.Msg >= &H100 And m.Msg <= &H109)

        If mouse Or kbd Then
            Inactivity = 0
        End If

        Return False

    End Function

    Private Sub InactivityTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InactivityTimer.Tick

        If InactivityLimit > 0 Then
            Inactivity = Inactivity + 1
        Else
            Exit Sub
        End If

        If Inactivity > InactivityLimit Then
            InactivityTimer.Enabled = False

            Application.Exit()

        End If

    End Sub


    Public Sub PopulateTherapyDetails(ByVal ConnString As String)

        Dim ConnThpInfo As SqlConnection


        ConnThpInfo = New SqlConnection(ConnString)
        ConnThpInfo.Open()

        Dim dsThpDetails As New DataSet             'TherapyDetails dataset
        Dim qryDetails As String = "SELECT PatientID, NextINR, Instructions, EvaluationDate, " & _
            "TaskOwner, Inactive FROM tblTherapyDetails WHERE tblTherapyDetails.PatientID = " & PatID & _
            " and (Inactive = 0 or Inactive Is Null) ORDER BY tblTherapyDetails.EvaluationDate DESC"             'Sql Query for Therapy Details data grid"
        Dim ThpDetailsAdapter As New SqlDataAdapter         'Data Adapter for Therapy Details data grid view

        ThpDetailsAdapter.SelectCommand = New SqlCommand(qryDetails, ConnThpInfo)
        ThpDetailsAdapter.Fill(dsThpDetails, "tblTherapyDetails")

        Dim ThpDetails As DataTable = dsThpDetails.Tables("tblTherapyDetails")

        Dim myView As DataView = New DataView(ThpDetails)

        Me.TblTherapyDetailsBindingSource.DataSource = myView
        Me.TblTherapyDetailsBindingSource.ResetBindings(False)
        Me.TblTherapyDetailsDataGridView.DataSource = Nothing
        Me.TblTherapyDetailsDataGridView.DataSource = Me.TblTherapyDetailsBindingSource
        Me.TblTherapyDetailsDataGridView.Refresh()

        ConnThpInfo.Close()

    End Sub

    ' Private Sub SetDefaults(SettingType As String)

    'If SettingType = "Enterprise" Then
    '   SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
    'ElseIf SettingType = "User" Then
    '   SelectStringSettings = "Select * FROM tblSettings WHERE UserID = " & UserID
    'End If

    '    MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
    '   drSettingsInfo = MyCommand.ExecuteReader

    '    While drSettingsInfo.Read()

    '       If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
    '          Me.cmbTaskPriority.SelectedValue = drSettingsInfo("DefaultTaskPriority")
    '     End If

    '        If Not IsDBNull(drSettingsInfo("MyInterval1")) Then
    '           Me.txtMyInterval1.Text = drSettingsInfo("MyInterval1")
    '      End If

    '        If Not IsDBNull(drSettingsInfo("MyInterval2")) Then
    '           Me.txtMyInterval2.Text = drSettingsInfo("MyInterval2")
    '      End If


    '        SelectString = "Select Count(*) as returncount FROM tblTherapy WHERE PatientID = " & PatID
    '       MyCommand2 = New SqlCommand(SelectString, ConnSettingsInfo)
    'Dim IntCount As Integer = MyCommand2.ExecuteScalar

    'The below is only run if the patient does not yet have a record in tblTherapy
    '       If IntCount = 0 Then
    '          If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
    '             Me.cbNotify.Checked = drSettingsInfo("DefaultNotify")
    '        End If

    '            If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
    '               Me.txtNotifyInterval.Value = drSettingsInfo("DefaultOverdueInterval")
    '          End If
    '     End If

    '    End While

    'End Sub

    Private Sub SetDefaults()

        Dim IntCount As Integer
        Dim TaskPriorityOverrideAllowed As Boolean
        Dim MyIntervalsOverrideAllowed As Boolean
        Dim DefaultNotifyOverrideAllowed As Boolean
        Dim OverdueIntervalOverrideAllowed As Boolean

        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"

        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()

            If Not IsDBNull(drSettingsInfo("InactivityTimeoutMins")) Then
                InactivityLimit = drSettingsInfo("InactivityTimeoutMins")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
                Me.cmbTaskPriority.SelectedValue = drSettingsInfo("DefaultTaskPriority")
            End If

            TaskPriorityOverrideAllowed = drSettingsInfo("TaskPriorityAllowOverride")

            If Not IsDBNull(drSettingsInfo("MyInterval1")) Then
                Me.txtMyInterval1.Text = drSettingsInfo("MyInterval1")
            End If

            If Not IsDBNull(drSettingsInfo("MyInterval2")) Then
                Me.txtMyInterval2.Text = drSettingsInfo("MyInterval2")
            End If

            MyIntervalsOverrideAllowed = drSettingsInfo("MyIntervalsAllowOverride")

            SelectString = "Select Count(*) as returncount FROM tblTherapy WHERE PatientID = " & PatID
            MyCommand2 = New SqlCommand(SelectString, ConnSettingsInfo)
            IntCount = MyCommand2.ExecuteScalar

            'The below is only run if the patient does not yet have a record in tblTherapy
            If IntCount = 0 Then
                If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
                    Me.cbNotify.Checked = drSettingsInfo("DefaultNotify")
                End If

                DefaultNotifyOverrideAllowed = drSettingsInfo("NotifyAllowOverride")

                If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
                    Me.txtNotifyInterval.Value = drSettingsInfo("DefaultOverdueInterval")
                End If

                OverdueIntervalOverrideAllowed = drSettingsInfo("OverdueIntervalAllowOverride")

            End If

        End While


        'Find out if the current user has personal settings.
        'If he/she has personal settings, apply them - IFF AllowOverride is checked for that particular setting
        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE UserID = " & UserID
        MyCommand2 = New SqlCommand(SelectString, ConnSettingsInfo)

        If MyCommand2.ExecuteScalar > 0 Then

            SelectStringSettings = "Select * FROM tblSettings WHERE UserID = " & UserID

            MyCommand3 = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
            drSettingsPersonal = MyCommand3.ExecuteReader

            While drSettingsPersonal.Read()

                If TaskPriorityOverrideAllowed Then
                    If Not IsDBNull(drSettingsPersonal("DefaultTaskPriority")) Then
                        Me.cmbTaskPriority.SelectedValue = drSettingsPersonal("DefaultTaskPriority")
                    End If
                End If


                If MyIntervalsOverrideAllowed Then
                    If Not IsDBNull(drSettingsPersonal("MyInterval1")) Then
                        Me.txtMyInterval1.Text = drSettingsPersonal("MyInterval1")
                    End If

                    If Not IsDBNull(drSettingsPersonal("MyInterval2")) Then
                        Me.txtMyInterval2.Text = drSettingsPersonal("MyInterval2")
                    End If
                End If

                'The below is only run if the patient does not yet have a record in tblTherapy
                If IntCount = 0 Then

                    If DefaultNotifyOverrideAllowed Then
                        If Not IsDBNull(drSettingsPersonal("DefaultNotify")) Then
                            Me.cbNotify.Checked = drSettingsPersonal("DefaultNotify")
                        End If
                    End If

                    If OverdueIntervalOverrideAllowed Then
                        If Not IsDBNull(drSettingsPersonal("DefaultOverdueInterval")) Then
                            Me.txtNotifyInterval.Value = drSettingsPersonal("DefaultOverdueInterval")
                        End If
                    End If

                End If

            End While

        End If

    End Sub

    Private Sub Btn1Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 7, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 7, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub Btn2Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 14, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 14, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub Btn3Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 21, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 21, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub Btn4Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 28, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 28, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub Btn8Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 56, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 56, Me.dtNextINR.Value)
        End If

    End Sub

    Public Sub BtnSameDose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSameDose.Click

        If Me.txtCurDosageInstructions.Text Is Nothing Or Me.txtCurDosageInstructions.Text = "" Then
            MsgBox("No instructions entered on this patient.  Please manually enter instructions.", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Me.txtInstructions.Text = Me.txtCurDosageInstructions.Text
        End If

    End Sub


    Private Sub FrmTrackerMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtEvalDate.Value = DateTime.Today
        Me.dtNextINR.Value = DateTime.Today
        Inactivity = 0

        Dim CoumadinFlowsheet As String
        Dim OrgINRCode As String
        Dim ConnThpInfo As SqlConnection

        '****Commented out to disable encryption unless executable is run outside of TouchWorks
        'm_Section = "appSettings"
        'ProtectSection()

        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
        Dim MyToken As String

        ' Obtain security token
        Try
            ' Unity Service generates a session token that has access as assigned by Allscripts
            MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)

        Catch ex As Exception
            MsgBox(ex.InnerException)
            MsgBox(ex.Message)

            MsgBox("Session Not Established", vbOK)
            Exit Sub

            ' Do something with exception.  Could not obtain token.
        End Try

        Dim MyDS As DataSet = unitySvc.Magic("GetPatient", twusername, appName, PatID, MyToken, "", "", "", "", "", "", Nothing)

        Dim Lastname As String = MyDS.Tables(0).Rows(0)("LastName")
        Dim Firstname As String = MyDS.Tables(0).Rows(0)("FirstName")
        Dim Middlename As String = MyDS.Tables(0).Rows(0)("MiddleName")

        If Len(Middlename) < 1 Then
            Me.txtPatientName.Text = Firstname + " " + Lastname
        Else
            Me.txtPatientName.Text = Firstname + " " + Middlename + " " + Lastname
        End If

        Me.TxtPatientDOB.Text = MyDS.Tables(0).Rows(0)("dateofbirth")
        Me.TxtPatientMRN.Text = MyDS.Tables(0).Rows(0)("mrn")
        Me.txtMaskedSSN.Text = MyDS.Tables(0).Rows(0)("SSN")
        Me.txtPatientHomePhone.Text = MyDS.Tables(0).Rows(0)("HomePhone")
        Me.txtPatientCellPhone.Text = MyDS.Tables(0).Rows(0)("cellphone")



        'Populates Task Priority
        MyDS = unitySvc.Magic("GetDictionary", twusername, appName, "", MyToken, "Task_Priority_DE", "", "", "", "", "", Nothing)
        Dim TaskPriorityTable = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable

        With Me.cmbTaskPriority
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .DataSource = TaskPriorityTable
            .SelectedIndex = 0
            .Enabled = False
        End With

        MyDS = unitySvc.Magic("GetProviders", twusername, appName, "", MyToken, "", "", "Y", "I", "", "", Nothing)
        Dim UserProviderTable = MyDS.Tables(0).Select("ProviderInactive = 'N'").CopyToDataTable
        Dim NameColumn As DataColumn = New DataColumn("FullName")
        NameColumn.DataType = System.Type.GetType("System.String")
        NameColumn.Expression = "LastName + ', ' + FirstName"
        UserProviderTable.Columns.Add(NameColumn)

        With Me.cmbManagedBy
            .DisplayMember = "FullName"
            .ValueMember = "UserName"
            .DataSource = UserProviderTable
            .SelectedIndex = -1
        End With

        With Me.cmbTaskOwner
            .DisplayMember = "FullName"
            .ValueMember = "UserName"
            .DataSource = UserProviderTable
            .SelectedIndex = -1
            .BindingContext = New BindingContext
        End With

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectString = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()
            If Not IsDBNull(drSettingsInfo("FlowsheetName")) Then
                CoumadinFlowsheet = drSettingsInfo("FlowsheetName")
            End If

            If Not IsDBNull(drSettingsInfo("INRCode")) Then
                OrgINRCode = drSettingsInfo("INRCode".TrimEnd)
            End If
        End While

        Dim MyFlowsheetDS As DataSet = unitySvc.Magic("GetFlowsheetDatapoints", twusername, appName, PatID, MyToken, CoumadinFlowsheet, "", "", "", "", "", Nothing)

        'populate patient results from MyDS
        Dim tblResults As DataTable = MyFlowsheetDS.Tables(0)
        Dim myResultView As DataView = New DataView(tblResults)


        Dim INRresult() As DataRow = tblResults.Select("resultname = '" & OrgINRCode & "'", "resultdate DESC")
        Me.txtMostRecentINR = INRresult(0).Item("resultvalue")

        myResultView.Sort = "resultdate DESC, resultname DESC"

        Me.ResultsDataGridView.DataSource = myResultView

        Me.ResultsDataGridView.Columns(0).HeaderText = "Type"
        Me.ResultsDataGridView.Columns(1).HeaderText = "Result"
        Me.ResultsDataGridView.Columns(7).HeaderText = "Date"

        'Me.ResultsDataGridView.Sort(ResultsDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        'Me.ResultsDataGridView.Sort(ResultsDataGridView.Columns(7), System.ComponentModel.ListSortDirection.Descending)

        Me.ResultsDataGridView.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.ResultsDataGridView.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.ResultsDataGridView.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable

        Me.ResultsDataGridView.Columns(0).Resizable = True
        Me.ResultsDataGridView.Columns(1).Resizable = True
        Me.ResultsDataGridView.Columns(7).Resizable = True

        Me.ResultsDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ResultsDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.ResultsDataGridView.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.ResultsDataGridView.Columns(2).Visible = False
        Me.ResultsDataGridView.Columns(3).Visible = False
        Me.ResultsDataGridView.Columns(4).Visible = False
        Me.ResultsDataGridView.Columns(5).Visible = False
        Me.ResultsDataGridView.Columns(6).Visible = False
        Me.ResultsDataGridView.Columns(8).Visible = False

        unitySvc.RetireSecurityToken(serviceUser, servicePwd)


        SetDefaults()                'Sets Enterprise and then User Defaults, if applicable

        ConnSettingsInfo.Close()

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select * FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand3 = New SqlCommand(SelectString, ConnThpInfo)
        drThpInfo = MyCommand3.ExecuteReader

        While drThpInfo.Read()
            If Not IsDBNull(drThpInfo("TherapyStartDate")) Then
                Me.dtTherapyStartDate.Value = drThpInfo("TherapyStartDate")
            End If

            If Not IsDBNull(drThpInfo("ReasonForTherapy")) Then
                Me.cmbReasonForTherapy.Text = drThpInfo("ReasonForTherapy")
            End If

            If Not IsDBNull(drThpInfo("AdditionalReasonForTherapy")) Then
                Me.cmbAdditionalReasonForTherapy.Text = drThpInfo("AdditionalReasonForTherapy")
            End If

            If Not IsDBNull(drThpInfo("ExpectedLengthOfTherapy")) Then
                Me.cmbExpectedLengthOfTherapy.Text = drThpInfo("ExpectedLengthOfTherapy")
            End If

            If Not IsDBNull(drThpInfo("ManagedBy")) Then
                Me.cmbManagedBy.SelectedValue = drThpInfo("ManagedBy")
                Me.cmbTaskOwner.SelectedValue = drThpInfo("ManagedBy")
            End If


            If Not IsDBNull(drThpInfo("PillSizeAtHome")) Then
                Me.cmbPillSize.Text = drThpInfo("PillSizeAtHome")
            End If

            If Not IsDBNull(drThpInfo("AdditionalPillSizeAtHome")) Then
                Me.cmbPillSize2.Text = drThpInfo("AdditionalPillSizeAtHome")
            End If

            If Not IsDBNull(drThpInfo("INRRange")) Then
                Me.cmbINRRange.Text = drThpInfo("INRRange")
            End If

            If Not IsDBNull(drThpInfo("Notify")) Then
                Me.cbNotify.Checked = drThpInfo("Notify")
            End If

            If Not IsDBNull(drThpInfo("NotifyInterval")) Then
                Me.txtNotifyInterval.Value = drThpInfo("NotifyInterval")
            End If

            If Not IsDBNull(drThpInfo("CurrentDosageInstructions")) Then
                Me.txtCurDosageInstructions.Text = drThpInfo("CurrentDosageInstructions")
            End If

            If Not IsDBNull(drThpInfo("Comments")) Then
                Me.txtComments.Text = drThpInfo("Comments")
            End If


        End While

        ConnThpInfo.Close()
        unitySvc.RetireSecurityToken(serviceUser, servicePwd)

        PopulateTherapyDetails(ConnString)


        Me.ChkEdited.Checked = False
        Me.ChkEditedDetails.Checked = False

    End Sub

    Private Sub TblTherapyDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.Validate()
        'Me.TblTherapyDetailsBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.CoumadinTrackerDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Try
        'Me.TblTherapyDetailsTableAdapter.FillBy(Me.CoumadinTrackerDataSet.tblTherapyDetails, CType(PatIDToolStripTextBox.Text, Long))
        'Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

        Dim UserResponse As MsgBoxResult

        If Me.ChkEdited.Checked = True Or Me.ChkEditedDetails.Checked Then
            UserResponse = MsgBox("Changes have not been saved.  Do you wish to save your changes?", MsgBoxStyle.YesNoCancel, "Save changes?")

            If UserResponse = MsgBoxResult.Yes Then
                BtnVerifySend_Click(sender, e)
            ElseIf UserResponse = MsgBoxResult.No Then
                Me.Close()
            ElseIf UserResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If

        End If

        Application.Exit()

    End Sub

    Private Sub dtTherapyStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTherapyStartDate.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbReasonForTherapy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReasonForTherapy.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbAdditionalReasonForTherapy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdditionalReasonForTherapy.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbExpectedLengthOfTherapy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExpectedLengthOfTherapy.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbPillSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPillSize.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbINRRange_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbINRRange.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cbNotify_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNotify.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtNotifyInterval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotifyInterval.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurDosageInstructions.TextChanged

        Me.ChkEdited.Checked = True

    End Sub



    Private Sub txtInstructions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstructions.TextChanged

        Me.ChkEditedDetails.Checked = True

        If Me.txtInstructions.Text <> "" And Me.txtInstructions.Text IsNot Nothing Then
            Me.ChkSendTask.Checked = True
            Me.ChkVerifyResults.Checked = True
            Me.ChkResultsNote.Checked = True
            Me.ChkSendTask.Enabled = True
            Me.ChkVerifyResults.Enabled = True
            Me.ChkResultsNote.Enabled = True
        Else
            Me.ChkSendTask.Checked = False
            Me.ChkVerifyResults.Checked = False
            Me.ChkResultsNote.Checked = False
            Me.ChkSendTask.Enabled = False
            Me.ChkVerifyResults.Enabled = False
            Me.ChkResultsNote.Enabled = False
        End If

    End Sub

    Private Sub BtnVerifySend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerifySend.Click

        Dim IntCount As Integer
        Dim NoteID As String
        Dim PtInstructions As String
        Dim ConnThpInfo As SqlConnection
        'Dim TaskPriorityID As Integer
        'Dim TaskStatusID As Integer

        If Me.cmbManagedBy.SelectedValue Is Nothing Or Me.cmbManagedBy.SelectedValue = "" Then
            MsgBox("Please enter a value for the Managed By field.  Managed By cannot be null.", vbOKOnly, "Required Field not entered.")
            Me.cmbManagedBy.Focus()
            Exit Sub
        End If

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand = New SqlCommand(SelectString, ConnThpInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            'SelectString = "INSERT INTO tblTherapy([TherapyStartDate], [ReasonForTherapy], [AdditionalReasonForTherapy], [ExpectedLengthOfTherapy], [ManagedBy], " & _
            '   "[PillSizeAtHome], [INRRange], [Notify], [NotifyInterval], [PatientID], [CurrentDosageInstructions], [Comments]) VALUES ('" & Me.dtTherapyStartDate.Value & "', '" & _
            '   Me.cmbReasonForTherapy.Text & "', '" & Me.cmbAdditionalReasonForTherapy.Text & "', '" & Me.cmbExpectedLengthOfTherapy.Text & "', '" & Me.cmbManagedBy.SelectedValue & "', '" & _
            '  Me.cmbPillSize.Text & "', '" & Me.cmbINRRange.Text & "', " & Me.cbNotify.CheckState & ", " & Me.txtNotifyInterval.Value & ", " & PatID & ", '" & Me.txtInstructions.Text & "', '" & Me.txtComments.Text & "');"

            'MyCommand = New SqlCommand(SelectString, ConnThpInfo)
            'MyCommand.ExecuteNonQuery()

            MyCommand.Connection = ConnThpInfo

            MyCommand.CommandText = "INSERT INTO tblTherapy([TherapyStartDate], [ReasonForTherapy], [AdditionalReasonForTherapy], [ExpectedLengthOfTherapy], [ManagedBy], " & _
               "[PillSizeAtHome], [INRRange], [Notify], [NotifyInterval], [PatientID], [CurrentDosageInstructions], [Comments]) VALUES (@pTherapyStartDate, @pReasonForTherapy, " & _
               "@pAdditionalReasonForTherapy, @pExpectedLengthOfTherapy, @pManagedBy, @pPillSizeAtHome, @pINRRange, @pNotify, @pNotifyInterval, " & PatID & ", @pCurrentDosageInstructions, @pComments);"

            MyCommand.Parameters.AddWithValue("@pTherapyStartDate", Me.dtTherapyStartDate.Value)
            MyCommand.Parameters.AddWithValue("@pReasonForTherapy", Me.cmbReasonForTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pAdditionalReasonForTherapy", Me.cmbAdditionalReasonForTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pExpectedLengthOfTherapy", Me.cmbExpectedLengthOfTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pManagedBy", Me.cmbManagedBy.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pPillSizeAtHome", Me.cmbPillSize.Text)
            MyCommand.Parameters.AddWithValue("@pINRRange", Me.cmbINRRange.Text)
            MyCommand.Parameters.AddWithValue("@pNotify", Me.cbNotify.CheckState)
            MyCommand.Parameters.AddWithValue("@pNotifyInterval", Me.txtNotifyInterval.Value)
            MyCommand.Parameters.AddWithValue("@pCurrentDosageInstructions", Me.txtInstructions.Text)
            MyCommand.Parameters.AddWithValue("@pComments", Me.txtComments.Text)

            MyCommand.ExecuteNonQuery()

        ElseIf IntCount = 1 Then

            ' SelectString = "UPDATE tblTherapy SET [TherapyStartDate] = '" & Me.dtTherapyStartDate.Value & "', [ReasonForTherapy] = '" & Me.cmbReasonForTherapy.Text & _
            '    "', [AdditionalReasonForTherapy] = '" & Me.cmbAdditionalReasonForTherapy.Text & "', [ExpectedLengthOfTherapy] = '" & Me.cmbExpectedLengthOfTherapy.Text & "', [ManagedBy] = '" & Me.cmbManagedBy.SelectedValue & _
            '   "', [PillSizeAtHome] = '" & Me.cmbPillSize.Text & "', [INRRange] = '" & Me.cmbINRRange.Text & "', [Notify] = " & Me.cbNotify.CheckState & ", [NotifyInterval] = " & _
            '  Me.txtNotifyInterval.Value & ", [CurrentDosageInstructions] = '" & PtInstructions & "', [Comments] = '" & Me.txtComments.Text & "' WHERE [PatientID] = " & PatID & ";"

            'MyCommand = New SqlCommand(SelectString, ConnThpInfo)
            'MyCommand.ExecuteNonQuery()


            MyCommand.Connection = ConnThpInfo

            MyCommand.CommandText = "UPDATE tblTherapy SET [TherapyStartDate] = @pTherapyStartDate, [ReasonForTherapy] = @pReasonForTherapy, " & _
                "[AdditionalReasonForTherapy] = @pAdditionalReasonForTherapy, [ExpectedLengthOfTherapy] = @pExpectedLengthOfTherapy, [ManagedBy] = @pManagedBy, " & _
                "[PillSizeAtHome] = @pPillSizeAtHome, [INRRange] = @pINRRange, [Notify] = @pNotify, [NotifyInterval] = @pNotifyInterval, " & _
                "[CurrentDosageInstructions] = @pCurrentDosageInstructions, [Comments] = @pComments WHERE [PatientID] = " & PatID & ";"


            MyCommand.Parameters.AddWithValue("@pTherapyStartDate", Me.dtTherapyStartDate.Value)
            MyCommand.Parameters.AddWithValue("@pReasonForTherapy", Me.cmbReasonForTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pAdditionalReasonForTherapy", Me.cmbAdditionalReasonForTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pExpectedLengthOfTherapy", Me.cmbExpectedLengthOfTherapy.Text)
            MyCommand.Parameters.AddWithValue("@pManagedBy", Me.cmbManagedBy.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pPillSizeAtHome", Me.cmbPillSize.Text)
            MyCommand.Parameters.AddWithValue("@pINRRange", Me.cmbINRRange.Text)
            MyCommand.Parameters.AddWithValue("@pNotify", Me.cbNotify.CheckState)
            MyCommand.Parameters.AddWithValue("@pNotifyInterval", Me.txtNotifyInterval.Value)

            If Me.txtInstructions.Text Is Nothing Or Me.txtInstructions.Text = "" Then
                PtInstructions = Me.txtCurDosageInstructions.Text
            Else
                PtInstructions = Me.txtInstructions.Text
            End If

            MyCommand.Parameters.AddWithValue("@pCurrentDosageInstructions", PtInstructions)
            MyCommand.Parameters.AddWithValue("@pComments", Me.txtComments.Text)

            MyCommand.ExecuteNonQuery()

            ' Try
            '        Me.Validate()

            'MsgBox("Update successful")

            'Catch ex As Exception
            'MsgBox("Update failed")
            'End Try

        End If

        If Me.ChkEditedDetails.Checked = False Then
            ConnThpInfo.Close()
            Me.Close()
            Exit Sub
        End If

        If Me.txtInstructions.Text = "" Or Me.txtInstructions.Text Is Nothing Then
            MsgBox("Instructions field is blank.  Other patient data has been saved but no instructions have been entered for this patient.  No Task or Note has been created.", vbOKOnly)
            ConnThpInfo.Close()
            Me.Close()
            Exit Sub
        End If


        If Me.cmbTaskOwner.SelectedValue Is Nothing Or Me.cmbTaskOwner.SelectedValue = "" Then
            Me.cmbTaskOwner.SelectedValue = Me.cmbManagedBy.SelectedValue
        End If

        'SelectString = "INSERT INTO tblTherapyDetails([PatientID], [NextINR], [Instructions], [EvaluationDate], [EnteredBy], [TaskOwner], [EnteredDTTM]) VALUES (" & _
        'PatID & ", '" & Me.dtNextINR.Value & "', '" & Me.txtInstructions.Text & "', '" & ThpEvalDate & "', " & UserID & ", '" & Me.cmbTaskOwner.SelectedValue & "', GetDate());"

        'MyCommand = New SqlCommand(SelectString, ConnThpInfo)
        'MyCommand.ExecuteNonQuery()

        MyCommand.Connection = ConnThpInfo

        MyCommand.CommandText = "INSERT INTO tblTherapyDetails([PatientID], [NextINR], [Instructions], [EvaluationDate], [EnteredBy], [TaskOwner], [EnteredDTTM], [MostRecentInr], [InRange], [TargetRange]) VALUES (" & _
        PatID & ", @pNextINR, @pInstructions, @pEvaluationDate, " & UserID & ", @pTaskOwner, GetDate(), @pMostRecentInr, @pInRange, @pTargetRange);"

        MyCommand.Parameters.AddWithValue("@pNextINR", Me.dtNextINR.Value)
        MyCommand.Parameters.AddWithValue("@pInstructions", Me.txtInstructions.Text)

        Dim ThpEvalDate As DateTime = Date.Parse(Me.dtEvalDate.Value.ToShortDateString & " " & DateTime.Now.ToShortTimeString)

        MyCommand.Parameters.AddWithValue("@pEvaluationDate", ThpEvalDate)
        MyCommand.Parameters.AddWithValue("@pTaskOwner", Me.cmbTaskOwner.SelectedValue)

        Dim IsInRange As Boolean = Me.IsInRange(Me.txtMostRecentINR.Text, Me.cmbINRRange.SelectedValue)

        MyCommand.Parameters.AddWithValue("@pMostRecentInr", Me.txtMostRecentINR.Text)
        MyCommand.Parameters.AddWithValue("@pInRange", IsInRange)
        MyCommand.Parameters.AddWithValue("@pTargetRange", Me.cmbINRRange.SelectedValue)

        MyCommand.ExecuteNonQuery()

        ConnThpInfo.Close()

        If Me.ChkResultsNote.Checked = True Then


            Dim SelectStringSettings As String          'Sql Query
            Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
            Dim MyCommand As SqlCommand               'reads the records from database	
            Dim drSettingsInfo As SqlDataReader       'stores the retrieved records
            Dim NoteType As String

            ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
            ConnSettingsInfo.Open()

            SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
            MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
            drSettingsInfo = MyCommand.ExecuteReader

            While drSettingsInfo.Read()

                If Not IsDBNull(drSettingsInfo("DefaultNoteType")) Then
                    NoteType = drSettingsInfo("DefaultNoteType".TrimEnd)
                End If
            End While

            Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
            Dim MyToken As String

            Try
                ' Unity Service generates a session token that has access as assigned by Allscripts
                MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)
            Catch ex As Exception
                MsgBox(ex.InnerException)
                MsgBox(ex.Message)

                MsgBox("Session Not Established", vbOK)
                Exit Sub
            End Try

            'Dim NoteContent As String = "Instructions for Current Dose: " & Me.txtInstructions.Text & vbCrLf & _
            '"Patient should get their next PT/INR on " & Me.dtNextINR.Value & vbCrLf & vbCrLf & _
            '"Comments: " & Me.txtComments.Text & vbCrLf & _
            '"Previous Patient Instructions: " & Me.txtCurDosageInstructions.Text & vbCrLf & _
            '"Task Owner: " & Me.cmbTaskOwner.SelectedValue & vbCrLf & _
            '"Anticoagulation Managed By: " & Me.cmbManagedBy.SelectedValue & vbCrLf & vbCrLf & vbCrLf & _
            '"Patient Notified: "
            '********************use string.format for the above

            Dim NoteBuilder As New StringBuilder

            NoteBuilder.Append("{\rtf1\ansi\deff0 {\fonttbl {\f0 Times New Roman;}}")
            NoteBuilder.Append("\pard \ql \fs34 \b \ul Instructions for Current Dose:\ul0  ").Append(Me.txtInstructions.Text).Append(" \line")
            NoteBuilder.Append("\fs30 Patient should get their next PT/INR on ").Append(Me.dtNextINR.Value.ToString("MM'/'dd'/'yyyy")).Append(" \line \line ")
            NoteBuilder.Append("\fs26 \ul Comments:\ul0 \b0  ").Append(Me.txtComments.Text).Append(" \line \line \par ")
            NoteBuilder.Append("\pard \qc \fs56 \b *   *   *   *   *   *   *   *   *   *   * \line \b0 \par ")
            NoteBuilder.Append("\pard \ql \fs26 \i Previous \i0 Patient Instructions: ").Append(Me.txtCurDosageInstructions.Text).Append(" \line ")
            NoteBuilder.Append("Task Owner: ").Append(Me.cmbTaskOwner.SelectedValue).Append(" \line ")
            NoteBuilder.Append("Anticoagulation Managed By: ").Append(Me.cmbManagedBy.SelectedValue).Append(" \line \line \line Patient Notified: \line \par ")

            Dim NoteContent As String = NoteBuilder.ToString


            Dim MyNoteDS As DataSet = unitySvc.Magic("SaveNote", twusername, appName, PatID, MyToken, NoteContent, NoteType, "Final", "Y", "", "", Nothing)
            NoteID = MyNoteDS.Tables(0).Rows(0)("DocumentID")

            ConnSettingsInfo.Close()
            unitySvc.RetireSecurityToken(serviceUser, servicePwd)

        End If



        If Me.ChkSendTask.Checked = True Then

            'ConnStringAHS = "Data Source=C:\Coumadin Tracker\Coumadin Tracker\Works.sdf;" & _
            '"Password = Ciccm6m6!;" & _
            '"Persist Security Info = False"

            'ConnAllscripts = New SqlCeConnection(ConnStringAHS)     ' Creates connection
            'ConnAllscripts.Open()

            'Dim cmdTaskStatus As New SqlCeCommand("SELECT ID from IDX_Task_Staus_DE where EntryName = 'Active' and IsInactiveFlag = 0", ConnAllscripts)
            'Dim TaskStatusID As Integer = cmdTaskStatus.ExecuteScalar
            'Dim TaskOwnerTypeID As Integer ' this needs retrieved
            'Dim OverdueDtTime As DateTime = Now.AddDays(3)
            ' Dim TaskActionID As Integer
            'Dim TaskComment As String = "Results:  Next PT/INR:" & Me.dtEvalDate.Value & _
            '    " Current instructions for the patient: " & Me.txtInstructions.Text

            'InsertString = "INSERT INTO IDX_Task([TaskOwnerType], [CurrentStatusChangeDT], [TaskCreatedDT], [ActivationDT], " & _
            '   "[OverdueDT], [TaskOwner], [IDXTaskStatusDE], [TaskPriorityDE], [TaskActionDE], [PatientID], [Comment], [DelegateFlag]) VALUES (" & _
            'TaskOwnerTypeID & ", '" & Now & "', '" & Now & "', '" & Now & "', '" & OverdueDtTime & "', " & UserID & ", " & TaskStatusID & _
            '", " & Me.cmbTaskPriority.SelectedValue & ",0 , " & PatID & ", '" & TaskComment & "', 1);"

            'MyCommandAhs = New SqlCeCommand(InsertString, ConnAllscripts)
            'MyCommandAhs.ExecuteNonQuery()

            'ConnAllscripts.Close()

            Dim SelectStringSettings As String          'Sql Query
            Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
            Dim MyCommand As SqlCommand               'reads the records from database	
            Dim drSettingsInfo As SqlDataReader       'stores the retrieved records
            Dim TaskType As String

            ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
            ConnSettingsInfo.Open()

            SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
            MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
            drSettingsInfo = MyCommand.ExecuteReader

            While drSettingsInfo.Read()

                If Not IsDBNull(drSettingsInfo("DefaultTaskType")) Then
                    TaskType = drSettingsInfo("DefaultTaskType")
                End If
            End While

            Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
            Dim MyToken As String

            Try
                ' Unity Service generates a session token that has access as assigned by Allscripts
                MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)
            Catch ex As Exception
                MsgBox(ex.InnerException)
                MsgBox(ex.Message)

                MsgBox("Session Not Established", vbOK)
                Exit Sub
            End Try

            Dim TaskContent As String = "Instructions for Current Dose: " & Me.txtInstructions.Text & vbCrLf & _
                "Patient should get their next PT/INR on " & Me.dtNextINR.Value & vbCrLf & vbCrLf & _
                "Comments: " & Me.txtComments.Text & vbCrLf & _
                "Previous Patient Instructions: " & Me.txtCurDosageInstructions.Text & vbCrLf & _
                "Task Owner: " & Me.cmbTaskOwner.SelectedValue & vbCrLf & _
                "Anticoagulation Managed By: " & Me.cmbManagedBy.SelectedValue

            Dim TaskPriorityXML As String = "<taskdata><taskpriority>" & Me.cmbTaskPriority.Text & "</taskpriority></taskdata>"


            Dim MyDS As DataSet = unitySvc.Magic("SaveTask", twusername, appName, PatID, MyToken, TaskType, Me.cmbTaskOwner.SelectedValue, NoteID, TaskContent, TaskPriorityXML, "", Nothing)
            'Need to add task priority to this - Use XML in Parameter 5, after TaskContent.  Issue with this reported to Allscripts.

            ConnSettingsInfo.Close()
            unitySvc.RetireSecurityToken(serviceUser, servicePwd)

        End If


        Me.ChkEdited.Checked = False

        Me.Close()

    End Sub

    Public Function IsInRange(ByVal inr As Double, ByVal target As String) As Boolean
        target = target.Replace(" ", "")
        Dim Bounds = target.Split("-")
        Dim LowerBounds = CDbl(Bounds(0))
        Dim UpperBounds = CDbl(Bounds(1))

        If inr <= UpperBounds And inr >= LowerBounds Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub dtNextINR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtNextINR.ValueChanged

        If Not Me.dtNextINR.Value = DateTime.Today Then
            Me.ChkEditedDetails.Checked = True
        End If

        Dim DaysAway As Integer = DateDiff(DateInterval.Day, DateTime.Today, Me.dtNextINR.Value)

        Me.lblDaysAway.Text = Str(DaysAway) + " days away"

    End Sub

    Private Sub dtEvalDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtEvalDate.ValueChanged

        If Not Me.dtEvalDate.Value = DateTime.Today Then
            Me.ChkEditedDetails.Checked = True
        End If

    End Sub

    Private Sub ChkSendTask_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSendTask.CheckedChanged

        If Me.ChkSendTask.Checked = True Then
            Me.cmbTaskPriority.Enabled = True
            Me.cmbTaskOwner.Enabled = True
            Me.ChkResultsNote.Checked = True
        Else
            Me.cmbTaskPriority.Enabled = False
            Me.cmbTaskOwner.Enabled = False
        End If

    End Sub

    Private Sub txtComments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComments.TextChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub txtComments_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComments.LostFocus

        'Sql Injection Prevention
        Me.txtComments.Text = Replace(Me.txtComments.Text, "'", "''")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "Delete", "De1ete")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "Union", "Uni0n")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "Select", "Se1ect")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "Append", "Appennd")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "Alter", "A1ter")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "delete", "de1ete")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "union", "uni0n")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "select", "se1ect")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "append", "appennd")
        Me.txtComments.Text = Replace(Me.txtComments.Text, "alter", "a1ter")

    End Sub


    Private Sub lnkPersonalize_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPersonalize.LinkClicked

        Dim oForm As FrmUserSettings

        oForm = New FrmUserSettings
        oForm.Show()
        oForm = Nothing

    End Sub


    Private Sub ChkResultsNote_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkResultsNote.CheckedChanged

        If Me.ChkResultsNote.Checked = False Then
            Me.ChkSendTask.Checked = False
        End If

    End Sub

    Private Sub btnMyInterval1_Click(sender As System.Object, e As System.EventArgs) Handles btnMyInterval1.Click

        If IsNothing(Me.txtMyInterval1.Text) Or Me.txtMyInterval1.Text = 0 Then
            MsgBox("My Interval settings are not set for this button." & vbCrLf & "Please setup My Interval at a User or Enterprise level.", vbOKOnly, "No Settings Defined!")
            Exit Sub
        End If

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, CInt(Me.txtMyInterval1.Text), Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, CInt(Me.txtMyInterval1.Text), Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub btnMyInterval2_Click(sender As System.Object, e As System.EventArgs) Handles btnMyInterval2.Click

        If IsNothing(Me.txtMyInterval2.Text) Or Me.txtMyInterval2.Text = 0 Then
            MsgBox("My Interval settings are not set for this button." & vbCrLf & "Please setup My Interval at a User or Enterprise level.", vbOKOnly, "No Settings Defined!")
            Exit Sub
        End If

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, CInt(Me.txtMyInterval2.Text), Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, CInt(Me.txtMyInterval2.Text), Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub cmbManagedBy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbManagedBy.SelectedIndexChanged

        Me.ChkEdited.Checked = True

        Me.cmbTaskOwner.SelectedValue = Me.cmbManagedBy.SelectedValue


    End Sub

    Private Sub lnkEditDetails_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEditDetails.LinkClicked


        Me.Hide()

        Dim oForm As FrmTherapyDetailEdit

        oForm = New FrmTherapyDetailEdit
        oForm.Show()
        oForm = Nothing

    End Sub

    Private Sub btnCDS_Click(sender As System.Object, e As System.EventArgs) Handles btnCDS.Click
        Dim IntCount As Integer
        Dim ConnThpInfo As SqlConnection

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand = New SqlCommand(SelectString, ConnThpInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            MsgBox("Record must be saved before accessing Clinical Decision Support Module.")
            Exit Sub
        End If

        Dim oForm As FrmCDS

        oForm = New FrmCDS
        oForm.Show()
        oForm = Nothing

        Me.Hide()

    End Sub


    Private Sub Btn12Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn12Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 84, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 84, Me.dtNextINR.Value)
        End If

    End Sub

End Class



