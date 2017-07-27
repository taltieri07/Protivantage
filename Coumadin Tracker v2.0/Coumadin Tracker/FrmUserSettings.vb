Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmUserSettings

    Dim ConnString As String                    'Connection String to CoumadinTracker
    Dim SelectString As String                  'Sql Query
    Dim SelectStringSettings As String          'Sql Query
    Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
    Dim MyCommand As SqlCommand               'reads the records from database	
    Dim drSettingsInfo As SqlDataReader       'stores the retrieved records
    Dim drSettingsInfo2 As SqlDataReader       'stores the retrieved records
    Dim IntCount As Integer


    Private Sub FrmUserSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim MyToken As String
        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
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

        Dim MyDS As DataSet = unitySvc.Magic("GetDictionary", twusername, appName, "", MyToken, "Task_Priority_DE", "", "", "", "", "", Nothing)
        Dim TaskPriorityTable = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable
        Dim TaskPriorityTable2 = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable

        With Me.cmbTaskPriority
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .DataSource = TaskPriorityTable
            .SelectedIndex = 0
        End With

        With Me.cmbOverdueTaskPriority
            .DisplayMember = "EntryName"
            .ValueMember = "EntryName"
            .DataSource = TaskPriorityTable2
            .SelectedIndex = 0
        End With

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE UserID = " & UserID
        MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        Else
            SelectStringSettings = "Select * FROM tblSettings WHERE UserID = " & UserID
        End If

        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()

            If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
                Me.NumDefaultOverdueInterval.Value = drSettingsInfo("DefaultOverdueInterval")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
                Me.ChkDefaultNotify.Checked = drSettingsInfo("DefaultNotify")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
                Me.cmbTaskPriority.SelectedValue = drSettingsInfo("DefaultTaskPriority")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueTaskPriority")) Then
                Me.cmbOverdueTaskPriority.SelectedValue = drSettingsInfo("DefaultOverdueTaskPriority")
            End If

            If IntCount > 0 Then
                If Not IsDBNull(drSettingsInfo("Email")) Then
                    Me.txtEmail.Text = drSettingsInfo("Email")
                End If
            End If

            If Not IsDBNull(drSettingsInfo("MyInterval1")) Then
                Me.NumMyInterval1.Value = drSettingsInfo("MyInterval1")
            End If

            If Not IsDBNull(drSettingsInfo("MyInterval2")) Then
                Me.NumMyInterval2.Value = drSettingsInfo("MyInterval2")
            End If

        End While


        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"

        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo2 = MyCommand.ExecuteReader

        While drSettingsInfo2.Read()

            If Not IsDBNull(drSettingsInfo2("OverdueIntervalAllowOverride")) Then
                If drSettingsInfo2("OverdueIntervalAllowOverride") = True Then
                    Me.NumDefaultOverdueInterval.Enabled = True
                End If
            End If

            If Not IsDBNull(drSettingsInfo2("NotifyAllowOverride")) Then
                If drSettingsInfo2("NotifyAllowOverride") = True Then
                    Me.ChkDefaultNotify.Enabled = True
                End If
            End If

            If Not IsDBNull(drSettingsInfo2("TaskPriorityAllowOverride")) Then
                If drSettingsInfo2("TaskPriorityAllowOverride") = True Then
                    Me.cmbTaskPriority.Enabled = True
                End If
            End If

            If Not IsDBNull(drSettingsInfo2("OverdueTaskPriorityAllowOverride")) Then
                If drSettingsInfo2("OverdueTaskPriorityAllowOverride") = True Then
                    Me.cmbOverdueTaskPriority.Enabled = True
                End If
            End If

            If Not IsDBNull(drSettingsInfo2("MyIntervalsAllowOverride")) Then
                If drSettingsInfo2("MyIntervalsAllowOverride") = True Then
                    Me.NumMyInterval1.Enabled = True
                    Me.NumMyInterval2.Enabled = True
                End If
            End If

        End While

        Me.ChkEdited.Checked = False
        unitySvc.RetireSecurityToken(serviceUser, servicePwd)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

        Dim UserResponse As MsgBoxResult

        If Me.ChkEdited.Checked = True Then
            UserResponse = MsgBox("Changes have not been saved.  Do you wish to save your changes?", MsgBoxStyle.YesNoCancel, "Save changes?")

            If UserResponse = MsgBoxResult.Yes Then
                BtnSave_Click(sender, e)
            ElseIf UserResponse = MsgBoxResult.No Then
                Me.Close()
            ElseIf UserResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If

        End If

        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'Dim TaskPriorityID As Integer
        'Dim TaskStatusID As Integer


        If Me.cmbTaskPriority.SelectedValue Is Nothing Then
            MsgBox("Default Task Priority cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbTaskPriority.Focus()
            Exit Sub
        End If

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE UserID = " & UserID
        MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            'SelectString = "INSERT INTO tblSettings([EnterpriseSetting], [DefaultOverdueInterval], " & _
            '   "[DefaultNotify], [DefaultTaskPriority], [DefaultOverdueTaskType], [Email], [UserID], [MyInterval1], [MyInterval2]) " & _
            '   "VALUES (0, " & Me.NumDefaultOverdueInterval.Value & ", " & Me.ChkDefaultNotify.CheckState & ", '" & _
            '   Me.cmbTaskPriority.SelectedValue & "', '" & Me.cmbOverdueTaskPriority.SelectedValue & "', '" & Me.txtEmail.Text & "', " & UserID & ", " & Me.NumMyInterval1.Value & ", " & Me.NumMyInterval2.Value & ");"

            'MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
            'MyCommand.ExecuteNonQuery()

            MyCommand.Connection = ConnSettingsInfo

            MyCommand.CommandText = "INSERT INTO tblSettings([EnterpriseSetting], [DefaultOverdueInterval], " & _
               "[DefaultNotify], [DefaultTaskPriority], [DefaultOverdueTaskPriority], [Email], [UserID], [MyInterval1], [MyInterval2]) " & _
               "VALUES (0, @pDefaultOverdueInterval, @pDefaultNotify, @pDefaultTaskPriority, @pDefaultOverdueTaskPriority, " & _
               "@pEmail, " & UserID & ", @pMyInterval1, @pMyInterval2);"

            MyCommand.Parameters.AddWithValue("@pDefaultOverdueInterval", Me.NumDefaultOverdueInterval.Value)
            MyCommand.Parameters.AddWithValue("@pDefaultNotify", Me.ChkDefaultNotify.CheckState)
            MyCommand.Parameters.AddWithValue("@pDefaultTaskPriority", Me.cmbTaskPriority.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pDefaultOverdueTaskPriority", Me.cmbOverdueTaskPriority.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pEmail", Me.txtEmail.Text)
            MyCommand.Parameters.AddWithValue("@pMyInterval1", Me.NumMyInterval1.Value)
            MyCommand.Parameters.AddWithValue("@pMyInterval2", Me.NumMyInterval2.Value)

            MyCommand.ExecuteNonQuery()

        ElseIf IntCount = 1 Then
            'SelectString = "UPDATE tblSettings SET [EnterpriseSetting] = 0, " & _
            '   "[DefaultOverdueInterval] = " & Me.NumDefaultOverdueInterval.Value & ", " & _
            '  "[DefaultNotify] = " & Me.ChkDefaultNotify.CheckState & ", [DefaultTaskPriority] = '" & _
            ' Me.cmbTaskPriority.SelectedValue & "', [DefaultOverdueTaskPriority] = '" & Me.cmbOverdueTaskPriority.SelectedValue & "', [Email] = '" & Me.txtEmail.Text & "', [MyInterval1] = " & _
            ' Me.NumMyInterval1.Value & ", [MyInterval2] = " & Me.NumMyInterval2.Value & " WHERE [UserID] = " & UserID & ";"

            'MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
            'MyCommand.ExecuteNonQuery()

            MyCommand.Connection = ConnSettingsInfo
            MyCommand.CommandText = "Update tblSettings SET [EnterpriseSetting] = 0, " & _
                "[DefaultOverdueInterval] = @pDefaultOverdueInterval, " & _
                "[DefaultNotify] = @pDefaultNotify, [DefaultTaskPriority] = " & _
                "@pDefaultTaskPriority, [DefaultOverdueTaskPriority] = @pDefaultOverdueTaskPriority, [Email] = @pEmail, [MyInterval1] = " & _
                "@pMyInterval1, [MyInterval2] = @pMyInterval2 WHERE [UserID] = " & UserID & ";"

            MyCommand.Parameters.AddWithValue("@pDefaultOverdueInterval", Me.NumDefaultOverdueInterval.Value)
            MyCommand.Parameters.AddWithValue("@pDefaultNotify", Me.ChkDefaultNotify.CheckState)
            MyCommand.Parameters.AddWithValue("@pDefaultTaskPriority", Me.cmbTaskPriority.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pDefaultOverdueTaskPriority", Me.cmbOverdueTaskPriority.SelectedValue)
            MyCommand.Parameters.AddWithValue("@pEmail", Me.txtEmail.Text)
            MyCommand.Parameters.AddWithValue("@pMyInterval1", Me.NumMyInterval1.Value)
            MyCommand.Parameters.AddWithValue("@pMyInterval2", Me.NumMyInterval2.Value)

            MyCommand.ExecuteNonQuery()

        End If

        MsgBox("Settings have been saved.", MsgBoxStyle.OkOnly, "User Settings Saved.")
        Me.Close()

    End Sub

    Private Sub txtPTCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtINRCOde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumDefaultOverdueInterval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumDefaultOverdueInterval.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkDefaultNotify_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDefaultNotify.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbTaskPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaskPriority.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval1.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval2.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbOverdueTaskPriority_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbOverdueTaskPriority.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub
End Class