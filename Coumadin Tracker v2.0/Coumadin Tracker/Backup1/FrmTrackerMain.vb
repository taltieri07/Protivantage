Imports System.Data.SqlClient
Imports System.Data.SqlServerCe

Public Class FrmTrackerMain

    Dim ConnThpInfo As SqlCeConnection          'represents unique connection to database
    Dim ConnAllscripts As SqlCeConnection       'connection to Works database
    Dim MyCommand As SqlCeCommand               'reads the records from database	
    Dim MyCommandAhs As SqlCeCommand
    Dim drThpInfo As SqlCeDataReader            'stores the retrieved records
    Dim drAHS As SqlCeDataReader
    Dim SelectString As String                  'Sql Query
    Dim InsertString As String
    Dim ConnString As String                    'Connection String
    Dim ConnStringAHS As String                 'Connection String to Works
    

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

    Private Sub Btn6Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 42, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 42, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub Btn8Wk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8Wk.Click

        If Me.dtNextINR Is Nothing Then
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 56, Today)
        Else
            Me.dtNextINR.Value = DateAdd(DateInterval.Day, 56, Me.dtNextINR.Value)
        End If

    End Sub

    Private Sub BtnSameDose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSameDose.Click

        If Me.txtCurDosageInstructions.Text Is Nothing Or Me.txtCurDosageInstructions.Text = "" Then
            MsgBox("No instructions entered on this patient.  Please manually enter instructions.", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Me.txtInstructions.Text = Me.txtCurDosageInstructions.Text
        End If

    End Sub

    Private Sub FrmTrackerMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WorksDataSet.tblResultView' table. You can move, or remove it, as needed.
        'Me.TblResultViewTableAdapter.Fill(Me.WorksDataSet.tblResultView)

        Me.dtEvalDate.Value = DateTime.Today
        Me.dtNextINR.Value = DateTime.Today

        ConnString = "Data Source = CoumadinTracker.sdf;" & _
        "Password = Frnk5378!;" & _
        "Persist Security Info = False"

        ConnThpInfo = New SqlCeConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select * FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
        drThpInfo = MyCommand.ExecuteReader

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

            If Not IsDBNull(drThpInfo("PillSizeAtHome")) Then
                Me.cmbPillSize.Text = drThpInfo("PillSizeAtHome")
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

        'assigns datasource to Therapy Details subform

        Dim dsThpDetails As New DataSet             'TherapyDetails dataset
        Dim qryDetails As String = "SELECT * FROM tblTherapyDetails WHERE tblTherapyDetails.PatientID = " & PatID & "ORDER BY tblTherapyDetails.EvaluationDate DESC"             'Sql Query for Therapy Details data grid"
        Dim ThpDetailsAdapter As New SqlCeDataAdapter         'Data Adapter for Therapy Details data grid view

        ThpDetailsAdapter.SelectCommand = New SqlCeCommand(qryDetails, ConnThpInfo)
        ThpDetailsAdapter.Fill(dsThpDetails, "tblTherapyDetails")

        Dim ThpDetails As DataTable = dsThpDetails.Tables("tblTherapyDetails")

        Dim myView As DataView = New DataView(ThpDetails)

        Me.TblTherapyDetailsDataGridView.DataSource = myView

        ConnStringAHS = "Data Source = Works.sdf;" & _
        "Password = Ciccm6m6!;" & _
        "Persist Security Info = False"

        ConnAllscripts = New SqlCeConnection(ConnStringAHS)     ' Creates connection
        ConnAllscripts.Open()

        SelectString = "Select * FROM Patient WHERE PAT_ID = " & PatID
        MyCommandAhs = New SqlCeCommand(SelectString, ConnAllscripts)
        drAHS = MyCommandAhs.ExecuteReader

        While drAHS.Read()
            If IsDBNull(drAHS("MID_NM")) Then
                Me.txtPatientName.Text = drAHS("FIRST_NM") + " " + drAHS("LAST_NM")
            Else
                Me.txtPatientName.Text = drAHS("FIRST_NM") + " " + drAHS("MID_NM") + " " + drAHS("LAST_NM")
            End If
            Me.TxtPatientDOB.Text = drAHS("DOB")
            Me.txtPatientSSN.Text = drAHS("SSN")
        End While

        SelectString = "SELECT * FROM Task_Priority_DE WHERE IsInactiveFlag = 0"
        Dim da As New SqlCeDataAdapter(SelectString, ConnAllscripts)
        Dim ds As New DataSet
        da.Fill(ds, "Task_Priority_DE")

        With Me.cmbTaskPriority
            .DataSource = ds.Tables("Task_Priority_DE")
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .SelectedIndex = 0
            .Enabled = False
        End With

        'assigns datasource to Results subform

        Dim dsResults As New DataSet             'Results dataset
        Dim drSettings As SqlCeDataReader
        Dim ProtimeCode As String
        Dim INRCode As String
        Dim ProtimeDisplay As String
        Dim INRDisplay As String

        SelectString = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
        drSettings = MyCommand.ExecuteReader

        While drSettings.Read()
            If Not IsDBNull(drSettings("PTCode")) Then
                ProtimeCode = drSettings("PTCode")
            End If

            If Not IsDBNull(drSettings("INRCode")) Then
                INRCode = drSettings("INRCode")
            End If

            If Not IsDBNull(drSettings("PTDisplayAs")) Then
                ProtimeDisplay = drSettings("PTDisplayAs")
            End If

            If Not IsDBNull(drSettings("INRDisplayAs")) Then
                INRDisplay = drSettings("INRDisplayAs")
            End If
        End While

        '999 needs changed to EID code
        Dim qryResults As String = "SELECT Result.*, Item_Result.* FROM Item_Result INNER JOIN Result ON Item_Result.ID = Result.ItemID WHERE (Item_Result.EntryName = '" & ProtimeCode & "' or Item_Result.EntryName = '" & INRCode & "') and Result.ResultStatusDE <> 999 and Item_Result.PatientID = " & PatID & " ORDER BY Result.ClinicalDTTM DESC"
        Dim ResultsDataAdapter As New SqlCeDataAdapter         'Data Adapter for Results data grid view

        ResultsDataAdapter.SelectCommand = New SqlCeCommand(qryResults, ConnAllscripts)
        ResultsDataAdapter.Fill(dsResults, "tblResultView")

        Dim tblResults As DataTable = dsResults.Tables("tblResultView")
        Dim myResultView As DataView = New DataView(tblResults)

        Me.ResultsDataGridView.DataSource = myResultView


        For i = 0 To ResultsDataGridView.Rows.Count - 1
            If ResultsDataGridView.Rows(i).Cells("IsUnverifiedFLAG").Value = True Then
                ResultsDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.DarkSalmon
            End If

            If ResultsDataGridView.Rows(i).Cells("EntryName").Value = ProtimeCode Then
                ResultsDataGridView.Rows(i).Cells("EntryName").Value = ProtimeDisplay
            ElseIf ResultsDataGridView.Rows(i).Cells("EntryName").Value = INRCode Then
                ResultsDataGridView.Rows(i).Cells("EntryName").Value = INRDisplay
            End If

        Next


        Me.ChkEdited.Checked = False
        Me.ChkEditedDetails.Checked = False

        ConnThpInfo.Close()
        ConnAllscripts.Close()

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

        Me.Close()

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
        'Dim TaskPriorityID As Integer
        'Dim TaskStatusID As Integer

        ConnString = "Data Source = CoumadinTracker.sdf;" & _
        "Password = Frnk5378!;" & _
        "Persist Security Info = False"

        ConnThpInfo = New SqlCeConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            SelectString = "INSERT INTO tblTherapy([TherapyStartDate], [ReasonForTherapy], [AdditionalReasonForTherapy], [ExpectedLengthOfTherapy], " & _
                "[PillSizeAtHome], [INRRange], [Notify], [NotifyInterval], [PatientID], [CurrentDosageInstructions], [Comments]) VALUES ('" & Me.dtTherapyStartDate.Value & "', '" & _
                Me.cmbReasonForTherapy.Text & "', '" & Me.cmbAdditionalReasonForTherapy.Text & "', '" & Me.cmbExpectedLengthOfTherapy.Text & "', '" & _
                Me.cmbPillSize.Text & "', '" & Me.cmbINRRange.Text & "', " & Me.cbNotify.CheckState & ", " & Me.txtNotifyInterval.Value & ", " & PatID & ", '" & Me.txtInstructions.Text & "', '" & Me.txtComments.Text & "');"

            MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
            MyCommand.ExecuteNonQuery()
        ElseIf IntCount = 1 Then
            SelectString = "UPDATE tblTherapy SET [TherapyStartDate] = '" & Me.dtTherapyStartDate.Value & "', [ReasonForTherapy] = '" & Me.cmbReasonForTherapy.Text & _
                "', [AdditionalReasonForTherapy] = '" & Me.cmbAdditionalReasonForTherapy.Text & "', [ExpectedLengthOfTherapy] = '" & Me.cmbExpectedLengthOfTherapy.Text & _
                "', [PillSizeAtHome] = '" & Me.cmbPillSize.Text & "', [INRRange] = '" & Me.cmbINRRange.Text & "', [Notify] = " & Me.cbNotify.CheckState & ", [NotifyInterval] = " & _
                Me.txtNotifyInterval.Value & ", [CurrentDosageInstructions] = '" & Me.txtInstructions.Text & "', [Comments] = '" & Me.txtComments.Text & "' WHERE [PatientID] = " & PatID & ";"

            MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
            MyCommand.ExecuteNonQuery()


            ' Try
            '        Me.Validate()

            'MsgBox("Update successful")

            'Catch ex As Exception
            'MsgBox("Update failed")
            'End Try

        End If

        If Me.ChkEditedDetails.Checked = False Then
            Me.Close()
            Exit Sub
        End If

        If Me.txtInstructions.Text = "" Or Me.txtInstructions.Text Is Nothing Then
            MsgBox("Instructions field is blank.  Other patient data has been saved but no instructions have been entered for this patient.", vbOKOnly)
            Me.Close()
            Exit Sub
        End If

        SelectString = "INSERT INTO tblTherapyDetails([PatientID], [NextINR], [Instructions], [EvaluationDate]) VALUES (" & _
            PatID & ", '" & Me.dtNextINR.Value & "', '" & Me.txtInstructions.Text & "', '" & Me.dtEvalDate.Value & "');"

        MyCommand = New SqlCeCommand(SelectString, ConnThpInfo)
        MyCommand.ExecuteNonQuery()

        ConnThpInfo.Close()


        If Me.ChkSendTask.Checked = True Then

            ConnStringAHS = "Data Source=C:\Coumadin Tracker\Coumadin Tracker\Works.sdf;" & _
            "Password = Ciccm6m6!;" & _
            "Persist Security Info = False"

            ConnAllscripts = New SqlCeConnection(ConnStringAHS)     ' Creates connection
            ConnAllscripts.Open()

            Dim cmdTaskStatus As New SqlCeCommand("SELECT ID from IDX_Task_Staus_DE where EntryName = 'Active' and IsInactiveFlag = 0", ConnAllscripts)
            Dim TaskStatusID As Integer = cmdTaskStatus.ExecuteScalar
            Dim TaskOwnerTypeID As Integer ' this needs retrieved
            Dim OverdueDtTime As DateTime = Now.AddDays(3)
            ' Dim TaskActionID As Integer
            Dim TaskComment As String = "Results:  Next PT/INR:" & Me.dtEvalDate.Value & _
                " Current instructions for the patient: " & Me.txtInstructions.Text

            InsertString = "INSERT INTO IDX_Task([TaskOwnerType], [CurrentStatusChangeDT], [TaskCreatedDT], [ActivationDT], " & _
                "[OverdueDT], [TaskOwner], [IDXTaskStatusDE], [TaskPriorityDE], [TaskActionDE], [PatientID], [Comment], [DelegateFlag]) VALUES (" & _
            TaskOwnerTypeID & ", '" & Now & "', '" & Now & "', '" & Now & "', '" & OverdueDtTime & "', " & UserID & ", " & TaskStatusID & _
            ", " & Me.cmbTaskPriority.SelectedValue & ",0 , " & PatID & ", '" & TaskComment & "', 1);"

            MyCommandAhs = New SqlCeCommand(InsertString, ConnAllscripts)
            MyCommandAhs.ExecuteNonQuery()

            ConnAllscripts.Close()

        End If

        Me.ChkEdited.Checked = False

        Me.Close()

    End Sub

    Private Sub dtNextINR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtNextINR.ValueChanged

        If Not Me.dtNextINR.Value = DateTime.Today Then
            Me.ChkEditedDetails.Checked = True
        End If

    End Sub

    Private Sub dtEvalDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtEvalDate.ValueChanged

        If Not Me.dtEvalDate.Value = DateTime.Today Then
            Me.ChkEditedDetails.Checked = True
        End If

    End Sub

    Private Sub ChkSendTask_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSendTask.CheckedChanged

        If Me.ChkSendTask.Checked = True Then
            Me.cmbTaskPriority.Enabled = True
        Else
            Me.cmbTaskPriority.Enabled = False
        End If

    End Sub

    Private Sub txtComments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComments.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub lnkPersonalize_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPersonalize.LinkClicked

        Dim oForm As FrmUserSettings

        oForm = New FrmUserSettings
        oForm.Show()
        oForm = Nothing

    End Sub

End Class
