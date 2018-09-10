Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmCDS

    Private Sub FrmCDS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.chkAllowSplit.Checked = True
        Me.txtPillRuleUsed.Text = -1
        Me.txtRuleUsed.Text = -1

        Dim ConnThpInfo As SqlConnection
        Dim MyCommand As SqlCommand               'reads the records from database	
        Dim drThpInfo As SqlDataReader         'stores the retrieved records
        Dim SelectString As String                  'Sql Query
        Dim SelectStringSettings As String
        Dim ConnString As String                    'Connection String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        'NEED TO CHECK TO MAKE SURE RECORD FOR PATIENT EXISTS - HERE OR ON FRMTRACKERMAIN****************************

        SelectString = "Select * FROM tblTherapy WHERE PatientID = " & PatID
        MyCommand = New SqlCommand(SelectString, ConnThpInfo)
        drThpInfo = MyCommand.ExecuteReader

        While drThpInfo.Read()

            If Not IsDBNull(drThpInfo("ReasonForTherapy")) Then
                Me.txtReason.Text = drThpInfo("ReasonForTherapy")
            End If

            If Not IsDBNull(drThpInfo("AdditionalReasonForTherapy")) Then
                Me.txtAdditionalReason.Text = drThpInfo("AdditionalReasonForTherapy")
            End If

            If Not IsDBNull(drThpInfo("PillSizeAtHome")) Then
                Me.txtPillSize.Text = drThpInfo("PillSizeAtHome")
            End If

            If Not IsDBNull(drThpInfo("INRRange")) Then
                Me.txtRange.Text = drThpInfo("INRRange")
            End If

            If Not IsDBNull(drThpInfo("CurrentDosageInstructions")) Then
                Me.txtCurInstructions.Text = drThpInfo("CurrentDosageInstructions")
            End If

        End While

        ConnThpInfo.Close()


        Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
        Dim drSettingsInfo As SqlDataReader       'stores the retrieved records
        Dim OrgINRCode As String
        Dim CoumadinFlowsheet As String

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()

            If Not IsDBNull(drSettingsInfo("INRCode")) Then
                OrgINRCode = drSettingsInfo("INRCode".TrimEnd)
            End If

            If Not IsDBNull(drSettingsInfo("FlowsheetName")) Then
                CoumadinFlowsheet = drSettingsInfo("FlowsheetName")
            End If

        End While

        ConnSettingsInfo.Close()

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

        Dim MyFlowsheetDS As DataSet = unitySvc.Magic("GetFlowsheetDatapoints", twusername, appName, PatID, MyToken, CoumadinFlowsheet, "", "", "", "", "", Nothing)
        Dim tblResults2 As DataTable = MyFlowsheetDS.Tables(0)
        Dim MostRecentINR


        Dim INRresult() As DataRow = tblResults2.Select("resultname = '" & OrgINRCode & "'", "resultdate DESC")
        MostRecentINR = INRresult(0).Item("resultvalue")

        Me.txtRecentINR.Text = MostRecentINR

        '*** Check for CDS Rules vvvv


        Dim SelectStringCDS As String
        Dim CDSDataTable As New DataTable

        SelectStringCDS = "Select * FROM tblDosingAlgorithm WHERE (ReasonForTherapy = '[any]' or ReasonForTherapy = '' or " & _
           "ReasonForTherapy is NULL or ReasonForTherapy = '" & Me.txtReason.Text & "' or ReasonForTherapy = '" & Me.txtAdditionalReason.Text & _
           "') and (TargetInrRange = '[any]' or TargetInrRange = '' or TargetInrRange is NULL or RTRIM(LTRIM(TargetInrRange)) = '" & Trim(Me.txtRange.Text) & "') ORDER BY Priority ASC;"

        Using ConnCDSInfo As New SqlConnection(ConnString)

            ConnCDSInfo.Open()


            Using dadCDS As New SqlDataAdapter(SelectStringCDS, ConnCDSInfo)
                dadCDS.Fill(CDSDataTable)
            End Using

            ConnCDSInfo.Close()

        End Using

        Dim SatisfiedCount As Integer = 0

        For counter As Integer = 0 To (CDSDataTable.Rows.Count - 1) Step 1

            Dim LowerLimit = CDSDataTable.Rows(counter).Item("INRLowerLimit")
            Dim UpperLimit = CDSDataTable.Rows(counter).Item("INRUpperLimit")
            Dim LowerSatisfied As Boolean
            Dim UpperSatisfied As Boolean

            'Is first criterion satisfied?
            If Not LowerLimit Is Nothing And LowerLimit <> "" Then
                If LowerLimit.Split(" ")(0) = ">" Then

                    If MostRecentINR > Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = ">=" Then

                    If MostRecentINR >= Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = "=" Then

                    If MostRecentINR = Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                End If
            Else
                LowerSatisfied = True
            End If


            'Is second criterion satisfied?
            If Not UpperLimit Is Nothing And UpperLimit <> "" Then

                If UpperLimit.Split(" ")(0) = "<" Then

                    If MostRecentINR < Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                ElseIf UpperLimit.Split(" ")(0) = "<=" Then

                    If MostRecentINR <= Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                End If


            Else
                UpperSatisfied = True
            End If

            If (LowerSatisfied And UpperSatisfied) Then
                SatisfiedCount += 1

                If Me.txtRuleIndex.Text Is Nothing Or Me.txtRuleIndex.Text = "" Then
                    Me.txtRuleIndex.Text = counter
                End If

            End If

        Next counter



        If SatisfiedCount = 0 Then

            Me.LblNoSatisfaction.Visible = True
            Me.BtnIncrement.Visible = False
            Me.btnDecrement.Visible = False
            Me.txtCurrentCount.Visible = False
            Me.txtMaxCount.Visible = False
            Me.lblRuleCount.Visible = False

            Exit Sub

        ElseIf SatisfiedCount = 1 Then

            Me.LblNoSatisfaction.Visible = False
            Me.BtnIncrement.Visible = False
            Me.btnDecrement.Visible = False
            Me.txtCurrentCount.Visible = False
            Me.txtMaxCount.Visible = False
            Me.lblRuleCount.Visible = False

        ElseIf SatisfiedCount > 1 Then

            Me.LblNoSatisfaction.Visible = False
            Me.BtnIncrement.Visible = True
            Me.BtnIncrement.Enabled = True
            Me.btnDecrement.Visible = True
            Me.btnDecrement.Enabled = False
            Me.txtCurrentCount.Visible = True
            Me.txtMaxCount.Visible = True
            Me.lblRuleCount.Visible = True
            Me.txtCurrentCount.Text = 1
            Me.txtMaxCount.Text = SatisfiedCount

        End If

        Dim RFT As String

        If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") = "" Then
            RFT = "[any]"
        Else
            RFT = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy")
        End If

        Dim Target As String

        If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") = "" Then
            Target = "[any]"
        Else
            Target = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange")
        End If

        If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("NotificationOnly") = True Then
            Me.btnApply.Enabled = False
        Else
            Me.btnApply.Enabled = True
        End If

        Me.txtCriteria.Text = "Target = " & Target & " and Reason for Therapy = " & RFT & " and INR " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRLowerLimit") & " and " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRUpperLimit")
        Me.txtSuggestedChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("IncDec")
        Me.txtPercentageChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("PercentageChange")
        Me.txtVariance.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("VarianceAllowed")
        Me.txtComment.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("Comment")

        If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip") Is Nothing Then
            Me.txtSkip.Text = 0
        Else
            Me.txtSkip.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip")
        End If

        '*** Check for CDS Rules ^^^^

        unitySvc.RetireSecurityToken(serviceUser, servicePwd)

    End Sub

    Private Sub LightEmUp(TextBoxColor As Color)

        Me.txtSunNew.BackColor = TextBoxColor
        Me.txtMonNew.BackColor = TextBoxColor
        Me.txtTuesNew.BackColor = TextBoxColor
        Me.txtWedNew.BackColor = TextBoxColor
        Me.txtThursNew.BackColor = TextBoxColor
        Me.txtFriNew.BackColor = TextBoxColor
        Me.txtSatNew.BackColor = TextBoxColor
        Me.txtNewDoseCalculation.BackColor = TextBoxColor
        Me.txtNewWeeklyDose.BackColor = TextBoxColor

        If TextBoxColor = Color.Lime Then

            Me.txtNewDoseCalculation.Text = Convert.ToDouble(Me.txtSunNew.Text) + Convert.ToDouble(Me.txtMonNew.Text) + Convert.ToDouble(Me.txtTuesNew.Text) + Convert.ToDouble(Me.txtWedNew.Text) + Convert.ToDouble(Me.txtThursNew.Text) + Convert.ToDouble(Me.txtFriNew.Text) + Convert.ToDouble(Me.txtSatNew.Text)
            Me.txtDifference.Visible = True

            If Me.txtDifference.Text > 0 Then
                Me.txtDifference.Text = "Variance from Recommended Dose: + " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
            Else
                Me.txtDifference.Text = "Variance from Recommended Dose: " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
            End If


        End If

    End Sub

    Private Sub AddEmUp()

        If Me.txtSun.Text Is Nothing Or Me.txtSun.Text = "" Then
            Me.txtSun.Text = 0
        End If

        If Me.txtMon.Text Is Nothing Or Me.txtMon.Text = "" Then
            Me.txtMon.Text = 0
        End If

        If Me.txtTues.Text Is Nothing Or Me.txtTues.Text = "" Then
            Me.txtTues.Text = 0
        End If

        If Me.txtWed.Text Is Nothing Or Me.txtWed.Text = "" Then
            Me.txtWed.Text = 0
        End If

        If Me.txtThurs.Text Is Nothing Or Me.txtThurs.Text = "" Then
            Me.txtThurs.Text = 0
        End If

        If Me.txtFri.Text Is Nothing Or Me.txtFri.Text = "" Then
            Me.txtFri.Text = 0
        End If

        If Me.txtSat.Text Is Nothing Or Me.txtSat.Text = "" Then
            Me.txtSat.Text = 0
        End If

        Me.txtTotalWeekly.Text = CDbl(Me.txtSun.Text) + CDbl(Me.txtMon.Text) + CDbl(Me.txtTues.Text) + CDbl(Me.txtWed.Text) + CDbl(Me.txtThurs.Text) + CDbl(Me.txtFri.Text) + CDbl(Me.txtSat.Text)
        Me.txtDailyDose.Text = ""
        Me.txtNewInstructions.Text = ""

    End Sub

    Private Sub AddEmUpNew()

        If Me.txtSunNew.Text Is Nothing Or Me.txtSunNew.Text = "" Then
            Me.txtSunNew.Text = 0
        End If

        If Me.txtMonNew.Text Is Nothing Or Me.txtMonNew.Text = "" Then
            Me.txtMonNew.Text = 0
        End If

        If Me.txtTuesNew.Text Is Nothing Or Me.txtTuesNew.Text = "" Then
            Me.txtTuesNew.Text = 0
        End If

        If Me.txtWedNew.Text Is Nothing Or Me.txtWedNew.Text = "" Then
            Me.txtWedNew.Text = 0
        End If

        If Me.txtThursNew.Text Is Nothing Or Me.txtThursNew.Text = "" Then
            Me.txtThursNew.Text = 0
        End If

        If Me.txtFriNew.Text Is Nothing Or Me.txtFriNew.Text = "" Then
            Me.txtFriNew.Text = 0
        End If

        If Me.txtSatNew.Text Is Nothing Or Me.txtSatNew.Text = "" Then
            Me.txtSatNew.Text = 0
        End If

        Me.txtNewDoseCalculation.Text = CDbl(Me.txtSunNew.Text) + CDbl(Me.txtMonNew.Text) + CDbl(Me.txtTuesNew.Text) + CDbl(Me.txtWedNew.Text) + CDbl(Me.txtThursNew.Text) + CDbl(Me.txtFriNew.Text) + CDbl(Me.txtSatNew.Text)
        Me.txtDailyDoseNew.Text = ""

        Me.txtDifference.Visible = True
        Me.txtDifference.Text = Me.txtNewDoseCalculation.Text - Me.txtNewWeeklyDose.Text

        If Me.txtDifference.Text > 0 Then
            Me.txtDifference.Text = "Variance from Recommended Dose: + " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
        Else
            Me.txtDifference.Text = "Variance from Recommended Dose: " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
        End If

        If Math.Abs(CDbl(Me.txtNewDoseCalculation.Text) - CDbl(Me.txtNewWeeklyDose.Text)) >= CDbl(Me.txtVariance.Text) Then
            Me.txtNewDoseCalculation.BackColor = Color.Red
        Else
            Me.txtNewDoseCalculation.BackColor = Color.Lime
        End If

        Me.txtNewInstructions.Text = ""

    End Sub

    Private Function ParseWeeklySchedule(ByVal WholePillSize As Double, ByVal NewWeekly As Double, ByVal Variance As Double, sender As System.Object, e As System.EventArgs) As Boolean

        Dim HalfPillSize As Double = WholePillSize / 2


        Dim ConnDose As SqlConnection
        Dim MyCommand As SqlCommand               'reads the records from database	
        Dim drDoseInfo As SqlDataReader         'stores the retrieved records
        Dim SelectString As String                  'Sql Query
        Dim ConnString As String                    'Connection String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        Me.txtDailyDoseNew.Text = ""

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnDose = New SqlConnection(ConnString)     ' Creates connection
        ConnDose.Open()

        If Me.chkAllowSplit.Checked Then
            SelectString = "Select * FROM tblDoseScheduler WHERE Inactive = 'False' ORDER BY Priority ASC;"
        Else
            SelectString = "Select * FROM tblDoseScheduler WHERE RequiresSplit = 'False' and Inactive = 'False' ORDER BY Priority ASC;"
        End If

        MyCommand = New SqlCommand(SelectString, ConnDose)
        drDoseInfo = MyCommand.ExecuteReader

        Dim ScheduleFound As Boolean = False

        If drDoseInfo.HasRows Then
            While drDoseInfo.Read()
                If Math.Abs(WholePillSize * drDoseInfo("PillSizeMultiplier") - NewWeekly) <= Variance Then
                    If Me.txtRuleUsed.Text < drDoseInfo("Priority") Then
                        Me.txtSunNew.Text = drDoseInfo("SundayMultiplier") * WholePillSize
                        Me.txtMonNew.Text = drDoseInfo("MondayMultiplier") * WholePillSize
                        Me.txtTuesNew.Text = drDoseInfo("TuesdayMultiplier") * WholePillSize
                        Me.txtWedNew.Text = drDoseInfo("WednesdayMultiplier") * WholePillSize
                        Me.txtThursNew.Text = drDoseInfo("ThursdayMultiplier") * WholePillSize
                        Me.txtFriNew.Text = drDoseInfo("FridayMultiplier") * WholePillSize
                        Me.txtSatNew.Text = drDoseInfo("SaturdayMultiplier") * WholePillSize
                        Me.txtDifference.Text = WholePillSize * drDoseInfo("PillSizeMultiplier") - NewWeekly
                        Me.txtSkipDoses.Text = Me.txtSkip.Text

                        Me.txtRuleUsed.Text = drDoseInfo("Priority")

                        Me.btnTranslate_Click(sender, e)

                        LightEmUp(Color.Lime)

                        ScheduleFound = True
                        Exit While
                    End If
                End If

            End While

        End If

        drDoseInfo.Close()

        Return ScheduleFound
        '^^^^^^^^^^^^^^^^^^^^^^^ Use data, get this working and remove the ifs below



        'If Math.Abs(WholePillSize * 7 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 0 Then
        '        Me.txtSunNew.Text = WholePillSize
        '        Me.txtMonNew.Text = WholePillSize
        '        Me.txtTuesNew.Text = WholePillSize
        '        Me.txtWedNew.Text = WholePillSize
        '        Me.txtThursNew.Text = WholePillSize
        '        Me.txtFriNew.Text = WholePillSize
        '        Me.txtSatNew.Text = WholePillSize
        '        Me.txtDifference.Text = WholePillSize * 7 - NewWeekly

        '        Me.txtRuleUsed.Text = 0

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 14 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 1 Then
        '        Me.txtSunNew.Text = WholePillSize * 2
        '        Me.txtMonNew.Text = WholePillSize * 2
        '        Me.txtTuesNew.Text = WholePillSize * 2
        '        Me.txtWedNew.Text = WholePillSize * 2
        '        Me.txtThursNew.Text = WholePillSize * 2
        '        Me.txtFriNew.Text = WholePillSize * 2
        '        Me.txtSatNew.Text = WholePillSize * 2
        '        Me.txtDifference.Text = WholePillSize * 14 - NewWeekly

        '        Me.txtRuleUsed.Text = 1

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 21 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 2 Then
        '        Me.txtSunNew.Text = WholePillSize * 3
        '        Me.txtMonNew.Text = WholePillSize * 3
        '        Me.txtTuesNew.Text = WholePillSize * 3
        '        Me.txtWedNew.Text = WholePillSize * 3
        '        Me.txtThursNew.Text = WholePillSize * 3
        '        Me.txtFriNew.Text = WholePillSize * 3
        '        Me.txtSatNew.Text = WholePillSize * 3
        '        Me.txtDifference.Text = WholePillSize * 21 - NewWeekly

        '        Me.txtRuleUsed.Text = 2

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 28 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 3 Then
        '        Me.txtSunNew.Text = WholePillSize * 4
        '        Me.txtMonNew.Text = WholePillSize * 4
        '        Me.txtTuesNew.Text = WholePillSize * 4
        '        Me.txtWedNew.Text = WholePillSize * 4
        '        Me.txtThursNew.Text = WholePillSize * 4
        '        Me.txtFriNew.Text = WholePillSize * 4
        '        Me.txtSatNew.Text = WholePillSize * 4
        '        Me.txtDifference.Text = WholePillSize * 28 - NewWeekly

        '        Me.txtRuleUsed.Text = 3

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 3.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 4 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = HalfPillSize
        '            Me.txtMonNew.Text = HalfPillSize
        '            Me.txtTuesNew.Text = HalfPillSize
        '            Me.txtWedNew.Text = HalfPillSize
        '            Me.txtThursNew.Text = HalfPillSize
        '            Me.txtFriNew.Text = HalfPillSize
        '            Me.txtSatNew.Text = HalfPillSize
        '            Me.txtDifference.Text = WholePillSize * 3.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 4

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 10.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 5 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 1.5
        '            Me.txtMonNew.Text = WholePillSize * 1.5
        '            Me.txtTuesNew.Text = WholePillSize * 1.5
        '            Me.txtWedNew.Text = WholePillSize * 1.5
        '            Me.txtThursNew.Text = WholePillSize * 1.5
        '            Me.txtFriNew.Text = WholePillSize * 1.5
        '            Me.txtSatNew.Text = WholePillSize * 1.5
        '            Me.txtDifference.Text = WholePillSize * 10.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 5

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 17.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 6 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 2.5
        '            Me.txtMonNew.Text = WholePillSize * 2.5
        '            Me.txtTuesNew.Text = WholePillSize * 2.5
        '            Me.txtWedNew.Text = WholePillSize * 2.5
        '            Me.txtThursNew.Text = WholePillSize * 2.5
        '            Me.txtFriNew.Text = WholePillSize * 2.5
        '            Me.txtSatNew.Text = WholePillSize * 2.5
        '            Me.txtDifference.Text = WholePillSize * 17.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 6

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 24.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 7 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 3.5
        '            Me.txtMonNew.Text = WholePillSize * 3.5
        '            Me.txtTuesNew.Text = WholePillSize * 3.5
        '            Me.txtWedNew.Text = WholePillSize * 3.5
        '            Me.txtThursNew.Text = WholePillSize * 3.5
        '            Me.txtFriNew.Text = WholePillSize * 3.5
        '            Me.txtSatNew.Text = WholePillSize * 3.5
        '            Me.txtDifference.Text = WholePillSize * 24.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 7

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 5.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 8 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize
        '            Me.txtMonNew.Text = HalfPillSize
        '            Me.txtTuesNew.Text = WholePillSize
        '            Me.txtWedNew.Text = HalfPillSize
        '            Me.txtThursNew.Text = WholePillSize
        '            Me.txtFriNew.Text = HalfPillSize
        '            Me.txtSatNew.Text = WholePillSize
        '            Me.txtDifference.Text = WholePillSize * 5.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 8

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 8.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 9 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize
        '            Me.txtMonNew.Text = WholePillSize * 1.5
        '            Me.txtTuesNew.Text = WholePillSize
        '            Me.txtWedNew.Text = WholePillSize * 1.5
        '            Me.txtThursNew.Text = WholePillSize
        '            Me.txtFriNew.Text = WholePillSize * 1.5
        '            Me.txtSatNew.Text = WholePillSize
        '            Me.txtDifference.Text = WholePillSize * 8.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 9

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 12.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 10 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 2
        '            Me.txtMonNew.Text = WholePillSize * 1.5
        '            Me.txtTuesNew.Text = WholePillSize * 2
        '            Me.txtWedNew.Text = WholePillSize * 1.5
        '            Me.txtThursNew.Text = WholePillSize * 2
        '            Me.txtFriNew.Text = WholePillSize * 1.5
        '            Me.txtSatNew.Text = WholePillSize * 2
        '            Me.txtDifference.Text = WholePillSize * 12.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 10

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 15.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 11 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 2
        '            Me.txtMonNew.Text = WholePillSize * 2.5
        '            Me.txtTuesNew.Text = WholePillSize * 2
        '            Me.txtWedNew.Text = WholePillSize * 2.5
        '            Me.txtThursNew.Text = WholePillSize * 2
        '            Me.txtFriNew.Text = WholePillSize * 2.5
        '            Me.txtSatNew.Text = WholePillSize * 2
        '            Me.txtDifference.Text = WholePillSize * 15.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 11

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 19.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 12 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 3
        '            Me.txtMonNew.Text = WholePillSize * 2.5
        '            Me.txtTuesNew.Text = WholePillSize * 3
        '            Me.txtWedNew.Text = WholePillSize * 2.5
        '            Me.txtThursNew.Text = WholePillSize * 3
        '            Me.txtFriNew.Text = WholePillSize * 2.5
        '            Me.txtSatNew.Text = WholePillSize * 3
        '            Me.txtDifference.Text = WholePillSize * 19.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 12

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 22.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 13 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 3
        '            Me.txtMonNew.Text = WholePillSize * 3.5
        '            Me.txtTuesNew.Text = WholePillSize * 3
        '            Me.txtWedNew.Text = WholePillSize * 3.5
        '            Me.txtThursNew.Text = WholePillSize * 3
        '            Me.txtFriNew.Text = WholePillSize * 3.5
        '            Me.txtSatNew.Text = WholePillSize * 3
        '            Me.txtDifference.Text = WholePillSize * 22.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 13

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 26.5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 14 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 4
        '            Me.txtMonNew.Text = WholePillSize * 3.5
        '            Me.txtTuesNew.Text = WholePillSize * 4
        '            Me.txtWedNew.Text = WholePillSize * 3.5
        '            Me.txtThursNew.Text = WholePillSize * 4
        '            Me.txtFriNew.Text = WholePillSize * 3.5
        '            Me.txtSatNew.Text = WholePillSize * 4
        '            Me.txtDifference.Text = WholePillSize * 26.5 - NewWeekly

        '            Me.txtRuleUsed.Text = 14

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 5 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 15 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = HalfPillSize
        '            Me.txtMonNew.Text = WholePillSize
        '            Me.txtTuesNew.Text = HalfPillSize
        '            Me.txtWedNew.Text = WholePillSize
        '            Me.txtThursNew.Text = HalfPillSize
        '            Me.txtFriNew.Text = WholePillSize
        '            Me.txtSatNew.Text = HalfPillSize
        '            Me.txtDifference.Text = WholePillSize * 5 - NewWeekly

        '            Me.txtRuleUsed.Text = 15

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 9 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 16 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 1.5
        '            Me.txtMonNew.Text = WholePillSize
        '            Me.txtTuesNew.Text = WholePillSize * 1.5
        '            Me.txtWedNew.Text = WholePillSize
        '            Me.txtThursNew.Text = WholePillSize * 1.5
        '            Me.txtFriNew.Text = WholePillSize
        '            Me.txtSatNew.Text = WholePillSize * 1.5
        '            Me.txtDifference.Text = WholePillSize * 9 - NewWeekly

        '            Me.txtRuleUsed.Text = 16

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 12 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 17 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 1.5
        '            Me.txtMonNew.Text = WholePillSize * 2
        '            Me.txtTuesNew.Text = WholePillSize * 1.5
        '            Me.txtWedNew.Text = WholePillSize * 2
        '            Me.txtThursNew.Text = WholePillSize * 1.5
        '            Me.txtFriNew.Text = WholePillSize * 2
        '            Me.txtSatNew.Text = WholePillSize * 1.5
        '            Me.txtDifference.Text = WholePillSize * 12 - NewWeekly

        '            Me.txtRuleUsed.Text = 17

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 16 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 18 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 2.5
        '            Me.txtMonNew.Text = WholePillSize * 2
        '            Me.txtTuesNew.Text = WholePillSize * 2.5
        '            Me.txtWedNew.Text = WholePillSize * 2
        '            Me.txtThursNew.Text = WholePillSize * 2.5
        '            Me.txtFriNew.Text = WholePillSize * 2
        '            Me.txtSatNew.Text = WholePillSize * 2.5
        '            Me.txtDifference.Text = WholePillSize * 16 - NewWeekly

        '            Me.txtRuleUsed.Text = 18

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 19 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 19 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 2.5
        '            Me.txtMonNew.Text = WholePillSize * 3
        '            Me.txtTuesNew.Text = WholePillSize * 2.5
        '            Me.txtWedNew.Text = WholePillSize * 3
        '            Me.txtThursNew.Text = WholePillSize * 2.5
        '            Me.txtFriNew.Text = WholePillSize * 3
        '            Me.txtSatNew.Text = WholePillSize * 2.5
        '            Me.txtDifference.Text = WholePillSize * 19 - NewWeekly

        '            Me.txtRuleUsed.Text = 19

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 23 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 20 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 3.5
        '            Me.txtMonNew.Text = WholePillSize * 3
        '            Me.txtTuesNew.Text = WholePillSize * 3.5
        '            Me.txtWedNew.Text = WholePillSize * 3
        '            Me.txtThursNew.Text = WholePillSize * 3.5
        '            Me.txtFriNew.Text = WholePillSize * 3
        '            Me.txtSatNew.Text = WholePillSize * 3.5
        '            Me.txtDifference.Text = WholePillSize * 23 - NewWeekly

        '            Me.txtRuleUsed.Text = 20

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 26 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 21 Then
        '        If Me.chkAllowSplit.Checked Then
        '            Me.txtSunNew.Text = WholePillSize * 3.5
        '            Me.txtMonNew.Text = WholePillSize * 4
        '            Me.txtTuesNew.Text = WholePillSize * 3.5
        '            Me.txtWedNew.Text = WholePillSize * 4
        '            Me.txtThursNew.Text = WholePillSize * 3.5
        '            Me.txtFriNew.Text = WholePillSize * 4
        '            Me.txtSatNew.Text = WholePillSize * 3.5
        '            Me.txtDifference.Text = WholePillSize * 26 - NewWeekly

        '            Me.txtRuleUsed.Text = 21

        '            LightEmUp(Color.Lime)

        '            Return True
        '        End If
        '    End If
        'ElseIf Math.Abs(WholePillSize * 11 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 22 Then
        '        Me.txtSunNew.Text = WholePillSize * 2
        '        Me.txtMonNew.Text = WholePillSize
        '        Me.txtTuesNew.Text = WholePillSize * 2
        '        Me.txtWedNew.Text = WholePillSize
        '        Me.txtThursNew.Text = WholePillSize * 2
        '        Me.txtFriNew.Text = WholePillSize
        '        Me.txtSatNew.Text = WholePillSize * 2
        '        Me.txtDifference.Text = WholePillSize * 11 - NewWeekly

        '        Me.txtRuleUsed.Text = 22

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 18 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 23 Then
        '        Me.txtSunNew.Text = WholePillSize * 3
        '        Me.txtMonNew.Text = WholePillSize * 2
        '        Me.txtTuesNew.Text = WholePillSize * 3
        '        Me.txtWedNew.Text = WholePillSize * 2
        '        Me.txtThursNew.Text = WholePillSize * 3
        '        Me.txtFriNew.Text = WholePillSize * 2
        '        Me.txtSatNew.Text = WholePillSize * 3
        '        Me.txtDifference.Text = WholePillSize * 18 - NewWeekly

        '        Me.txtRuleUsed.Text = 23

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 25 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 24 Then
        '        Me.txtSunNew.Text = WholePillSize * 4
        '        Me.txtMonNew.Text = WholePillSize * 3
        '        Me.txtTuesNew.Text = WholePillSize * 4
        '        Me.txtWedNew.Text = WholePillSize * 3
        '        Me.txtThursNew.Text = WholePillSize * 4
        '        Me.txtFriNew.Text = WholePillSize * 3
        '        Me.txtSatNew.Text = WholePillSize * 4
        '        Me.txtDifference.Text = WholePillSize * 25 - NewWeekly

        '        Me.txtRuleUsed.Text = 24

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 10 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 25 Then
        '        Me.txtSunNew.Text = WholePillSize
        '        Me.txtMonNew.Text = WholePillSize * 2
        '        Me.txtTuesNew.Text = WholePillSize
        '        Me.txtWedNew.Text = WholePillSize * 2
        '        Me.txtThursNew.Text = WholePillSize
        '        Me.txtFriNew.Text = WholePillSize * 2
        '        Me.txtSatNew.Text = WholePillSize
        '        Me.txtDifference.Text = WholePillSize * 10 - NewWeekly

        '        Me.txtRuleUsed.Text = 25

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 17 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 26 Then
        '        Me.txtSunNew.Text = WholePillSize * 2
        '        Me.txtMonNew.Text = WholePillSize * 3
        '        Me.txtTuesNew.Text = WholePillSize * 2
        '        Me.txtWedNew.Text = WholePillSize * 3
        '        Me.txtThursNew.Text = WholePillSize * 2
        '        Me.txtFriNew.Text = WholePillSize * 3
        '        Me.txtSatNew.Text = WholePillSize * 2
        '        Me.txtDifference.Text = WholePillSize * 17 - NewWeekly

        '        Me.txtRuleUsed.Text = 26

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'ElseIf Math.Abs(WholePillSize * 24 - NewWeekly) <= Variance Then
        '    If Me.txtRuleUsed.Text < 27 Then
        '        Me.txtSunNew.Text = WholePillSize * 3
        '        Me.txtMonNew.Text = WholePillSize * 4
        '        Me.txtTuesNew.Text = WholePillSize * 3
        '        Me.txtWedNew.Text = WholePillSize * 4
        '        Me.txtThursNew.Text = WholePillSize * 3
        '        Me.txtFriNew.Text = WholePillSize * 4
        '        Me.txtSatNew.Text = WholePillSize * 3
        '        Me.txtDifference.Text = WholePillSize * 24 - NewWeekly

        '        Me.txtRuleUsed.Text = 27

        '        LightEmUp(Color.Lime)

        '        Return True
        '    End If
        'Else

        '    Return False

        'End If

    End Function


    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click

        If Me.txtTotalWeekly.Text Is Nothing Or Me.txtTotalWeekly.Text = "" Or Not IsNumeric(Me.txtTotalWeekly.Text) Then

            MsgBox("Please enter a numeric value for the Existing Total Weekly Dose before applying selected rule.", vbOKOnly, "Existing Total Weekly Dose not entered.")
            Me.txtTotalWeekly.Focus()
            Exit Sub

        End If

        If Me.txtSuggestedChange.Text = "Keep Total Weekly Dose the same" Then

            Me.txtNewWeeklyDose.Text = Me.txtTotalWeekly.Text
            LightEmUp(Color.White)
            Me.txtNewWeeklyDose.BackColor = Color.Lime

            Dim DoseResponse As MsgBoxResult = MsgBox("Based on selected rule, patient is recommended to continue same dosing schedule.  Do you wish to continue same dose?", vbOKCancel, "Continue same dose?")

            If DoseResponse = MsgBoxResult.Cancel Then
                Exit Sub
            ElseIf DoseResponse = MsgBoxResult.Ok Then

                FrmTrackerMain.Show()
                FrmTrackerMain.BtnSameDose_Click(sender, e)
                Me.Hide()

            End If

        ElseIf Me.txtSuggestedChange.Text = "Increase Total Weekly Dose" Then

            Me.txtNewWeeklyDose.Text = Me.txtTotalWeekly.Text * (1 + (Me.txtPercentageChange.Text / 100))

        ElseIf Me.txtSuggestedChange.Text = "Decrease Total Weekly Dose" Then

            Me.txtNewWeeklyDose.Text = Me.txtTotalWeekly.Text * (1 - (Me.txtPercentageChange.Text / 100))

        End If

        Me.btnBuildSchedule.Enabled = True
        Me.txtDailyDoseNew.Text = ""
        Me.txtSunNew.Text = ""
        Me.txtMonNew.Text = ""
        Me.txtTuesNew.Text = ""
        Me.txtWedNew.Text = ""
        Me.txtThursNew.Text = ""
        Me.txtFriNew.Text = ""
        Me.txtSatNew.Text = ""
        Me.txtNewInstructions.Text = ""
        Me.txtNewDoseCalculation.Text = ""
        Me.txtPillSizeUsed.Text = ""
        LightEmUp(Color.White)

        Me.txtNewWeeklyDose.BackColor = Color.Lime
        Me.txtDifference.Visible = False


    End Sub

    Private Sub txtSun_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSun.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtMon_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtMon.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtTues_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtTues.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtWed_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtWed.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtThurs_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtThurs.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtFri_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtFri.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtSat_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSat.LostFocus
        AddEmUp()
    End Sub

    Private Sub txtSunNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSunNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtMonNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtMonNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtTuesNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtTuesNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtWedNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtWedNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtThursNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtThursNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtFriNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtFriNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub txtSatNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSatNew.LostFocus
        AddEmUpNew()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        'check for unsaved data
        FrmTrackerMain.Show()
        Me.Close()

    End Sub

    Private Sub BtnIncrement_Click(sender As System.Object, e As System.EventArgs) Handles BtnIncrement.Click

        Dim ConnString As String                    'Connection String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        Dim SelectStringCDS As String
        Dim CDSDataTable As New DataTable

        SelectStringCDS = "Select * FROM tblDosingAlgorithm WHERE (ReasonForTherapy = '[any]' or ReasonForTherapy = '' or " & _
           "ReasonForTherapy is NULL or ReasonForTherapy = '" & Me.txtReason.Text & "' or ReasonForTherapy = '" & Me.txtAdditionalReason.Text & _
           "') and (TargetInrRange = '[any]' or TargetInrRange = '' or TargetInrRange is NULL or RTRIM(LTRIM(TargetInrRange)) = '" & Trim(Me.txtRange.Text) & "') ORDER BY Priority ASC;"

        Using ConnCDSInfo As New SqlConnection(ConnString)

            ConnCDSInfo.Open()


            Using dadCDS As New SqlDataAdapter(SelectStringCDS, ConnCDSInfo)
                dadCDS.Fill(CDSDataTable)
            End Using

            ConnCDSInfo.Close()

        End Using

        Dim MostRecentINR As Double = Convert.ToDouble(Me.txtRecentINR.Text)


        For counter As Integer = (Me.txtRuleIndex.Text + 1) To (CDSDataTable.Rows.Count - 1) Step 1

            Dim LowerLimit = CDSDataTable.Rows(counter).Item("INRLowerLimit")
            Dim UpperLimit = CDSDataTable.Rows(counter).Item("INRUpperLimit")
            Dim LowerSatisfied As Boolean
            Dim UpperSatisfied As Boolean

            'Is first criterion satisfied?
            If Not LowerLimit Is Nothing And LowerLimit <> "" Then
                If LowerLimit.Split(" ")(0) = ">" Then

                    If MostRecentINR > Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = ">=" Then

                    If MostRecentINR >= Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = "=" Then

                    If MostRecentINR = Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                End If
            Else
                LowerSatisfied = True
            End If


            'Is second criterion satisfied?
            If Not UpperLimit Is Nothing And UpperLimit <> "" Then

                If UpperLimit.Split(" ")(0) = "<" Then

                    If MostRecentINR < Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                ElseIf UpperLimit.Split(" ")(0) = "<=" Then

                    If MostRecentINR <= Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                End If


            Else
                UpperSatisfied = True
            End If


            If (LowerSatisfied And UpperSatisfied) Then

                Me.txtRuleIndex.Text = counter

                Dim RFT As String

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") = "" Then
                    RFT = "[any]"
                Else
                    RFT = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy")
                End If

                Dim Target As String

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") = "" Then
                    Target = "[any]"
                Else
                    Target = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange")
                End If

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("NotificationOnly") = True Then
                    Me.btnApply.Enabled = False
                Else
                    Me.btnApply.Enabled = True
                End If

                Me.txtCriteria.Text = "Target = " & Target & " and Reason for Therapy = " & RFT & " and INR " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRLowerLimit") & " and " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRUpperLimit")
                Me.txtSuggestedChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("IncDec")
                Me.txtPercentageChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("PercentageChange")
                Me.txtVariance.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("VarianceAllowed")
                Me.txtComment.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("Comment")

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip") Is Nothing Then
                    Me.txtSkip.Text = 0
                Else
                    Me.txtSkip.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip")
                End If

                Me.txtCurrentCount.Text += 1
                Me.btnDecrement.Enabled = True

                If Me.txtCurrentCount.Text = Me.txtMaxCount.Text Then
                    Me.BtnIncrement.Enabled = False
                Else
                    Me.BtnIncrement.Enabled = True
                End If

                Exit Sub

            End If

        Next counter

        txtTotalWeekly_TextChanged(sender, e)

    End Sub

    Private Sub btnDecrement_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrement.Click

        Dim ConnString As String                    'Connection String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        Dim SelectStringCDS As String
        Dim CDSDataTable As New DataTable

        SelectStringCDS = "Select * FROM tblDosingAlgorithm WHERE (ReasonForTherapy = '[any]' or ReasonForTherapy = '' or " & _
           "ReasonForTherapy is NULL or ReasonForTherapy = '" & Me.txtReason.Text & "' or ReasonForTherapy = '" & Me.txtAdditionalReason.Text & _
           "') and (TargetInrRange = '[any]' or TargetInrRange = '' or TargetInrRange is NULL or RTRIM(LTRIM(TargetInrRange)) = '" & Trim(Me.txtRange.Text) & "') ORDER BY Priority ASC;"


        Using ConnCDSInfo As New SqlConnection(ConnString)

            ConnCDSInfo.Open()


            Using dadCDS As New SqlDataAdapter(SelectStringCDS, ConnCDSInfo)
                dadCDS.Fill(CDSDataTable)
            End Using

            ConnCDSInfo.Close()

        End Using

        Dim MostRecentINR As Double = Convert.ToDouble(Me.txtRecentINR.Text)


        For counter As Integer = (Me.txtRuleIndex.Text - 1) To 0 Step -1

            Dim LowerLimit = CDSDataTable.Rows(counter).Item("INRLowerLimit")
            Dim UpperLimit = CDSDataTable.Rows(counter).Item("INRUpperLimit")
            Dim LowerSatisfied As Boolean
            Dim UpperSatisfied As Boolean

            'Is first criterion satisfied?
            If Not LowerLimit Is Nothing And LowerLimit <> "" Then
                If LowerLimit.Split(" ")(0) = ">" Then

                    If MostRecentINR > Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = ">=" Then

                    If MostRecentINR >= Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                ElseIf LowerLimit.Split(" ")(0) = "=" Then

                    If MostRecentINR = Convert.ToDouble(LowerLimit.split(" ")(1)) Then
                        LowerSatisfied = True
                    Else
                        LowerSatisfied = False
                    End If

                End If
            Else
                LowerSatisfied = True
            End If


            'Is second criterion satisfied?
            If Not UpperLimit Is Nothing And UpperLimit <> "" Then

                If UpperLimit.Split(" ")(0) = "<" Then

                    If MostRecentINR < Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                ElseIf UpperLimit.Split(" ")(0) = "<=" Then

                    If MostRecentINR <= Convert.ToDouble(UpperLimit.split(" ")(1)) Then
                        UpperSatisfied = True
                    Else
                        UpperSatisfied = False
                    End If

                End If


            Else
                UpperSatisfied = True
            End If


            If (LowerSatisfied And UpperSatisfied) Then

                Me.txtRuleIndex.Text = counter

                Dim RFT As String

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy") = "" Then
                    RFT = "[any]"
                Else
                    RFT = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("ReasonForTherapy")
                End If

                Dim Target As String

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") Is Nothing Or CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange") = "" Then
                    Target = "[any]"
                Else
                    Target = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("TargetInrRange")
                End If

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("NotificationOnly") = True Then
                    Me.btnApply.Enabled = False
                Else
                    Me.btnApply.Enabled = True
                End If

                Me.txtCriteria.Text = "Target = " & Target & " and Reason for Therapy = " & RFT & " and INR " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRLowerLimit") & " and " & CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("INRUpperLimit")
                Me.txtSuggestedChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("IncDec")
                Me.txtPercentageChange.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("PercentageChange")
                Me.txtVariance.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("VarianceAllowed")
                Me.txtComment.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("Comment")

                If CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip") Is Nothing Then
                    Me.txtSkip.Text = 0
                Else
                    Me.txtSkip.Text = CDSDataTable.Rows(Me.txtRuleIndex.Text).Item("DoseSkip")
                End If

                Me.txtCurrentCount.Text -= 1
                Me.BtnIncrement.Enabled = True

                If Me.txtCurrentCount.Text = 1 Then
                    Me.btnDecrement.Enabled = False
                Else
                    Me.btnDecrement.Enabled = True
                End If

                Exit Sub

            End If

        Next counter

        txtTotalWeekly_TextChanged(sender, e)

    End Sub

    Private Sub btnViewRules_Click(sender As System.Object, e As System.EventArgs) Handles btnViewRules.Click

        Dim oForm As FrmCDSRules

        oForm = New FrmCDSRules
        oForm.Show()
        oForm = Nothing

        Me.Hide()

    End Sub

    Private Sub btnBuildSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnBuildSchedule.Click

        If Me.txtPillSize.Text Is Nothing Or Me.txtPillSize.Text = "" Then

            MsgBox("Patient's pill size at home is not entered.  Please enter pill size on main screen.", vbOKOnly, "Pill Size cannot be null.")
            Exit Sub
        End If

        Dim WholePillSize As Double = Me.txtPillSize.Text.Split(" ")(0)

        If Not ParseWeeklySchedule(WholePillSize, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then


            LightEmUp(Color.White)

            Me.txtDailyDoseNew.Text = ""
            Me.txtSunNew.Text = ""
            Me.txtMonNew.Text = ""
            Me.txtTuesNew.Text = ""
            Me.txtWedNew.Text = ""
            Me.txtThursNew.Text = ""
            Me.txtFriNew.Text = ""
            Me.txtSatNew.Text = ""
            Me.txtDifference.Text = ""
            Me.txtNewDoseCalculation.Text = ""
            Me.txtPillSizeUsed.Text = ""


            If MsgBox("Dosing Algorithm was not able to build a schedule based on the patient's current pill size.  Would you like the algorithm to try using a different pill size?  Click YES to try other pill sizes.  Click NO if you would like to create a schedule yourself.", vbYesNo, "Schedule not found.") = vbYes Then

                If Me.txtPillRuleUsed.Text <= 1 Then
                    If WholePillSize <> 10 Then
                        If ParseWeeklySchedule(10, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 1
                            Me.txtPillSizeUsed.Text = "10 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 2 Then
                    If WholePillSize <> 7.5 Then
                        If ParseWeeklySchedule(7.5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 2
                            Me.txtPillSizeUsed.Text = "7.5 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 3 Then
                    If WholePillSize <> 5 Then
                        If ParseWeeklySchedule(5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 3
                            Me.txtPillSizeUsed.Text = "5 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 4 Then
                    If WholePillSize <> 4 Then
                        If ParseWeeklySchedule(4, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 4
                            Me.txtPillSizeUsed.Text = "4 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 5 Then
                    If WholePillSize <> 3 Then
                        If ParseWeeklySchedule(3, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 5
                            Me.txtPillSizeUsed.Text = "3 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 6 Then
                    If WholePillSize <> 2.5 Then
                        If ParseWeeklySchedule(2.5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 6
                            Me.txtPillSizeUsed.Text = "2.5 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 7 Then
                    If WholePillSize <> 2 Then
                        If ParseWeeklySchedule(2, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 7
                            Me.txtPillSizeUsed.Text = "2 mg"
                            Exit Sub
                        End If
                    End If
                End If

                If Me.txtPillRuleUsed.Text <= 8 Then
                    If WholePillSize <> 1 Then
                        If ParseWeeklySchedule(1, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                            Me.txtPillRuleUsed.Text = 8
                            Me.txtPillSizeUsed.Text = "1 mg"
                            Exit Sub
                        End If
                    End If
                End If

                MsgBox("No appropriate dosing schedule found.  Please create dosing schedule manually.", vbOKOnly, "Schedule note found.")
                Me.txtSunNew.Focus()

            Else
                Me.txtSunNew.Focus()
            End If

        Else
            Me.txtPillSizeUsed.Text = Me.txtPillSize.Text
            Me.txtPillRuleUsed.Text = 0
            'This indicates that the patient's current pill size was used to create schedule
        End If

    End Sub


    Private Sub txtDailyDose_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtDailyDose.LostFocus

        If Me.txtDailyDose.Text Is Nothing Or Me.txtDailyDose.Text = "" Or Not IsNumeric(Me.txtDailyDose.Text) Then
            Exit Sub
        End If

        Me.txtSun.Text = Me.txtDailyDose.Text
        Me.txtMon.Text = Me.txtDailyDose.Text
        Me.txtTues.Text = Me.txtDailyDose.Text
        Me.txtWed.Text = Me.txtDailyDose.Text
        Me.txtThurs.Text = Me.txtDailyDose.Text
        Me.txtFri.Text = Me.txtDailyDose.Text
        Me.txtSat.Text = Me.txtDailyDose.Text
        Me.txtTotalWeekly.Text = Me.txtDailyDose.Text * 7

    End Sub


    Private Sub txtDailyDoseNew_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtDailyDoseNew.LostFocus

        If Me.txtDailyDoseNew.Text Is Nothing Or Me.txtDailyDoseNew.Text = "" Or Not IsNumeric(Me.txtDailyDoseNew.Text) Then
            Exit Sub
        End If

        Me.txtSunNew.Text = Me.txtDailyDoseNew.Text
        Me.txtMonNew.Text = Me.txtDailyDoseNew.Text
        Me.txtTuesNew.Text = Me.txtDailyDoseNew.Text
        Me.txtWedNew.Text = Me.txtDailyDoseNew.Text
        Me.txtThursNew.Text = Me.txtDailyDoseNew.Text
        Me.txtFriNew.Text = Me.txtDailyDoseNew.Text
        Me.txtSatNew.Text = Me.txtDailyDoseNew.Text
        Me.txtNewDoseCalculation.Text = Me.txtDailyDoseNew.Text * 7

        Me.txtDifference.Visible = True
        Me.txtDifference.Text = Me.txtNewDoseCalculation.Text - Me.txtNewWeeklyDose.Text

        If Me.txtDifference.Text > 0 Then
            Me.txtDifference.Text = "Variance from Recommended Dose: + " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
        Else
            Me.txtDifference.Text = "Variance from Recommended Dose: " & Format(Convert.ToDouble(Me.txtDifference.Text), "F3")
        End If

        Me.txtNewInstructions.Text = ""

    End Sub

    Private Sub txtTotalWeekly_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalWeekly.TextChanged

        Me.btnBuildSchedule.Enabled = False

        Me.txtDailyDoseNew.Text = ""
        Me.txtSunNew.Text = ""
        Me.txtMonNew.Text = ""
        Me.txtTuesNew.Text = ""
        Me.txtWedNew.Text = ""
        Me.txtThursNew.Text = ""
        Me.txtFriNew.Text = ""
        Me.txtSatNew.Text = ""
        Me.txtNewDoseCalculation.Text = ""
        Me.txtNewWeeklyDose.Text = ""

        Me.txtPillSizeUsed.Text = ""
        Me.txtDifference.Text = ""
        Me.txtDifference.Visible = False
        Me.txtNewInstructions.Text = ""
        LightEmUp(Color.White)

    End Sub


    Private Sub txtNewDoseCalculation_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNewDoseCalculation.TextChanged

        If Me.txtNewDoseCalculation.Text = "" Or Me.txtNewDoseCalculation.Text Is Nothing Then
            Me.txtNewDoseCalculation.Text = 0
            Me.txtPillRuleUsed.Text = -1
            Me.txtRuleUsed.Text = -1
            LightEmUp(Color.White)
            Exit Sub
        End If

        If Me.txtNewWeeklyDose.Text = "" Or Me.txtNewWeeklyDose.Text Is Nothing Then
            Me.txtNewWeeklyDose.Text = 0
        End If

        If Me.txtVariance.Text = "" Or Me.txtVariance.Text Is Nothing Then
            Me.txtVariance.Text = 0
        End If

        If Math.Abs(CDbl(Me.txtNewDoseCalculation.Text) - CDbl(Me.txtNewWeeklyDose.Text)) > CDbl(Me.txtVariance.Text) Then
            Me.txtNewDoseCalculation.BackColor = Color.Red
            Me.txtNewWeeklyDose.BackColor = Color.Red
        Else
            Me.txtNewDoseCalculation.BackColor = Color.Lime
            Me.txtNewWeeklyDose.BackColor = Color.Lime
        End If

    End Sub

    Private Sub btnFindAnother_Click(sender As System.Object, e As System.EventArgs) Handles btnFindAnother.Click

        If Me.txtPillSize.Text Is Nothing Or Me.txtPillSize.Text = "" Then

            MsgBox("Patient's pill size at home is not entered.  Please enter pill size on main screen.", vbOKOnly, "Pill Size cannot be null.")
            Exit Sub
        End If

        Dim WholePillSize As Double = Me.txtPillSize.Text.Split(" ")(0)
        Dim TryOthers As Boolean = True

        'indicates patient's pill size was used to create current schedule
        If Me.txtPillRuleUsed.Text <= 0 Then
            If ParseWeeklySchedule(WholePillSize, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                Me.txtPillRuleUsed.Text = 0
                Me.txtPillSizeUsed.Text = Me.txtPillSize.Text
                Exit Sub
            ElseIf MsgBox("Dosing Algorithm was not able to build another schedule based on the patient's current pill size.  Would you like the algorithm to try using a different pill size?  Click YES to try other pill sizes.  Click NO if you would like to create a schedule yourself.", vbYesNo, "Schedule not found.") = vbNo Then
                TryOthers = False
            End If
        End If


        If TryOthers = True Then

            If Me.txtPillRuleUsed.Text <= 1 Then
                If WholePillSize <> 10 Then
                    If ParseWeeklySchedule(10, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 1
                        Me.txtPillSizeUsed.Text = "10 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 2 Then
                If WholePillSize <> 7.5 Then
                    If ParseWeeklySchedule(7.5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 2
                        Me.txtPillSizeUsed.Text = "7.5 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 3 Then
                If WholePillSize <> 5 Then
                    If ParseWeeklySchedule(5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 3
                        Me.txtPillSizeUsed.Text = "5 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 4 Then
                If WholePillSize <> 4 Then
                    If ParseWeeklySchedule(4, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 4
                        Me.txtPillSizeUsed.Text = "4 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 5 Then
                If WholePillSize <> 3 Then
                    If ParseWeeklySchedule(3, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 5
                        Me.txtPillSizeUsed.Text = "3 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 6 Then
                If WholePillSize <> 2.5 Then
                    If ParseWeeklySchedule(2.5, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 6
                        Me.txtPillSizeUsed.Text = "2.5 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 7 Then
                If WholePillSize <> 2 Then
                    If ParseWeeklySchedule(2, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 7
                        Me.txtPillSizeUsed.Text = "2 mg"
                        Exit Sub
                    End If
                End If
            End If

            If Me.txtPillRuleUsed.Text <= 8 Then
                If WholePillSize <> 1 Then
                    If ParseWeeklySchedule(1, Me.txtNewWeeklyDose.Text, Me.txtVariance.Text, sender, e) Then
                        Me.txtPillRuleUsed.Text = 8
                        Me.txtPillSizeUsed.Text = "1 mg"
                        Exit Sub
                    End If
                End If
            End If

            MsgBox("No more appropriate dosing schedules found.  Please create dosing schedule manually or use one of the previously suggested schedules.", vbOKOnly, "Schedule note found.")
            Me.txtSunNew.Focus()

        Else
            Me.txtSunNew.Focus()
        End If

    End Sub

    Private Sub btnUseSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnUseSchedule.Click

        If Me.txtNewInstructions.Text Is Nothing Or Me.txtNewInstructions.Text = "" Then
            MsgBox("Please enter instructions for the patient's new dosing schedule.", vbOKOnly, "Instructions not entered.")
            Me.txtNewInstructions.Focus()
            Exit Sub
        End If

        FrmTrackerMain.Show()
        FrmTrackerMain.txtInstructions.Text = Me.txtNewInstructions.Text
        Me.Hide()

    End Sub

    Private Function isNotValid(phrase As String) As Boolean
        If phrase IsNot Nothing And IsNumeric(phrase) Then
            Return False
        End If

        Return True

    End Function

    Private Function areDaysEqual(day1 As String, day2 As String, day3 As String, day4 As String, day5 As String, day6 As String, day7 As String) As Boolean
        If day1 = day2 And day2 = day3 And day3 = day4 And day4 = day5 And day5 = day6 And day6 = day7 Then
            Return True
        End If

        Return False

    End Function

    Private Function areDaysAlternating(day1 As String, day2 As String, day3 As String, day4 As String, day5 As String, day6 As String, day7 As String) As Boolean
        If day1 <> day2 And day1 = day3 And day1 = day5 And day1 = day7 And day2 = day4 And day2 = day6 Then
            Return True
        End If

        Return False

    End Function

    Private Sub btnTranslate_Click(sender As System.Object, e As System.EventArgs) Handles btnTranslate.Click
        Dim newInstructions As String
        Dim day1 = Me.txtSunNew.Text
        Dim day2 = Me.txtMonNew.Text
        Dim day3 = Me.txtTuesNew.Text
        Dim day4 = Me.txtWedNew.Text
        Dim day5 = Me.txtThursNew.Text
        Dim day6 = Me.txtFriNew.Text
        Dim day7 = Me.txtSatNew.Text

        If isNotValid(day1) Or isNotValid(day2) Or isNotValid(day3) Or isNotValid(day4) Or isNotValid(day5) Or isNotValid(day6) Or isNotValid(day7) Then
            MsgBox("Unable to translate to English instructions.  Please make sure all seven days are filled in with numeric values.", vbOK, "Unable to translate.")
            Exit Sub
        End If

        If IsNumeric(Me.txtSkipDoses.Text) And Me.txtSkipDoses.Text <> "0" Then
            newInstructions = "Skip " & Me.txtSkipDoses.Text & " dose(s), then: "
        End If

        If areDaysEqual(day1, day2, day3, day4, day5, day6, day7) Then
            newInstructions = newInstructions + "Take " + day1 + " mg daily"
        ElseIf areDaysAlternating(day1, day2, day3, day4, day5, day6, day7) Then
            newInstructions = newInstructions + "Alternate taking " + day1 + " mg and " + day2 + " mg daily"
        Else
            newInstructions = newInstructions + "Day 1: " + day1 + " mg.  Day 2: " + day2 + " mg.  Day 3: " + day3 + " mg.  Day 4: " + day4 + " mg.  Day 5: " + day5 + " mg.  Day 6: " + day6 + " mg.  Day 7: " + day7 + " mg."
        End If

        If newInstructions IsNot Nothing Then
            Me.txtNewInstructions.Text = newInstructions
        End If



    End Sub


    Private Sub txtSkipDoses_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSkipDoses.TextChanged

        Dim day1 = Me.txtSunNew.Text
        Dim day2 = Me.txtMonNew.Text
        Dim day3 = Me.txtTuesNew.Text
        Dim day4 = Me.txtWedNew.Text
        Dim day5 = Me.txtThursNew.Text
        Dim day6 = Me.txtFriNew.Text
        Dim day7 = Me.txtSatNew.Text

        If isNotValid(day1) Or isNotValid(day2) Or isNotValid(day3) Or isNotValid(day4) Or isNotValid(day5) Or isNotValid(day6) Or isNotValid(day7) Then
            Me.txtNewInstructions.Text = ""
        Else
            Me.btnTranslate_Click(sender, e)
        End If

    End Sub

    Private Sub txtTuesNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTuesNew.TextChanged

        If isNotValid(Me.txtTuesNew.Text) Then
            Me.txtTuesNew.Text = 0
        End If

    End Sub

    Private Sub txtSunNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSunNew.TextChanged

        If isNotValid(Me.txtSunNew.Text) Then
            Me.txtSunNew.Text = 0
        End If

    End Sub

    Private Sub txtMonNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMonNew.TextChanged

        If isNotValid(Me.txtMonNew.Text) Then
            Me.txtMonNew.Text = 0
        End If

    End Sub


    Private Sub txtWedNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWedNew.TextChanged

        If isNotValid(Me.txtWedNew.Text) Then
            Me.txtWedNew.Text = 0
        End If

    End Sub


    Private Sub txtThursNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtThursNew.TextChanged

        If isNotValid(Me.txtThursNew.Text) Then
            Me.txtThursNew.Text = 0
        End If

    End Sub

    Private Sub txtFriNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFriNew.TextChanged

        If isNotValid(Me.txtFriNew.Text) Then
            Me.txtFriNew.Text = 0
        End If

    End Sub

    Private Sub txtSatNew_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSatNew.TextChanged

        If isNotValid(Me.txtSatNew.Text) Then
            Me.txtSatNew.Text = 0
        End If

    End Sub

End Class