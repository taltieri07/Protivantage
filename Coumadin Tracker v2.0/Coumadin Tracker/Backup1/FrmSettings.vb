Imports System.Data.SqlServerCe

Public Class FrmSettings

    Dim ConnAllscripts As SqlCeConnection       'connection to Works database
    Dim ConnString As String                    'Connection String to CoumadinTracker
    Dim ConnStringAHS As String                 'Connection String to Works
    Dim SelectString As String                  'Sql Query
    Dim SelectStringSettings As String          'Sql Query
    Dim ConnSettingsInfo As SqlCeConnection     'represents unique connection to database
    Dim MyCommand As SqlCeCommand               'reads the records from database	
    Dim drSettingsInfo As SqlCeDataReader       'stores the retrieved records


    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConnStringAHS = "Data Source = Works.sdf;" & _
        "Password = Ciccm6m6!;" & _
        "Persist Security Info = False"

        ConnAllscripts = New SqlCeConnection(ConnStringAHS)     ' Creates connection
        ConnAllscripts.Open()

        SelectString = "SELECT * FROM Task_Priority_DE WHERE IsInactiveFlag = 0"
        Dim da As New SqlCeDataAdapter(SelectString, ConnAllscripts)
        Dim ds As New DataSet
        da.Fill(ds, "Task_Priority_DE")

        With Me.cmbTaskPriority
            .DataSource = ds.Tables("Task_Priority_DE")
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .SelectedIndex = 0
            .Enabled = True
        End With

        ConnString = "Data Source = CoumadinTracker.sdf;" & _
        "Password = Frnk5378!;" & _
        "Persist Security Info = False"

        ConnSettingsInfo = New SqlCeConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCeCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()
            If Not IsDBNull(drSettingsInfo("PTCode")) Then
                Me.txtPTCode.Text = drSettingsInfo("PTCode")
            End If

            If Not IsDBNull(drSettingsInfo("INRCode")) Then
                Me.txtINRCode.Text = drSettingsInfo("INRCode")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
                Me.NumDefaultOverdueInterval.Value = drSettingsInfo("DefaultOverdueInterval")
            End If

            If Not IsDBNull(drSettingsInfo("OverdueIntervalAllowOverride")) Then
                Me.ChkAllow1.Checked = drSettingsInfo("OverdueIntervalAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
                Me.ChkDefaultNotify.Checked = drSettingsInfo("DefaultNotify")
            End If

            If Not IsDBNull(drSettingsInfo("NotifyAllowOverride")) Then
                Me.ChkAllow2.Checked = drSettingsInfo("NotifyAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
                Me.cmbTaskPriority.Text = drSettingsInfo("DefaultTaskPriority")
            End If

            If Not IsDBNull(drSettingsInfo("TaskPriorityAllowOverride")) Then
                Me.ChkAllow3.Checked = drSettingsInfo("TaskPriorityAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("Email")) Then
                Me.txtEmail.Text = drSettingsInfo("Email")
            End If

            If Not IsDBNull(drSettingsInfo("PTDisplayAs")) Then
                Me.txtPTDisplayAs.Text = drSettingsInfo("PTDisplayAs")
            End If

            If Not IsDBNull(drSettingsInfo("INRDisplayAs")) Then
                Me.txtINRDisplayAs.Text = drSettingsInfo("INRDisplayAs")
            End If

        End While

        Me.ChkEdited.Checked = False

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

        Dim IntCount As Integer

        'Dim TaskPriorityID As Integer
        'Dim TaskStatusID As Integer

        ConnString = "Data Source = CoumadinTracker.sdf;" & _
        "Password = Frnk5378!;" & _
        "Persist Security Info = False"

        ConnSettingsInfo = New SqlCeConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            SelectString = "INSERT INTO tblSettings([EnterpriseSetting], [PTCode], [INRCode], [DefaultOverdueInterval], " & _
                "[OverdueIntervalAllowOverride], [DefaultNotify], [NotifyAllowOverride], [DefaultTaskPriority], [TaskPriorityAllowOverride], [Email], [PTDisplayAs], [INRDisplayAs], " & _
                "[MyInterval1], [MyInterval2]) VALUES (1, '" & Me.txtPTCode.Text & "', '" & Me.txtINRCode.Text & "', " & Me.NumDefaultOverdueInterval.Value & ", " & _
                Me.ChkAllow1.CheckState & ", " & Me.ChkDefaultNotify.CheckState & ", " & Me.ChkAllow2.CheckState & ", '" & Me.cmbTaskPriority.Text & "', " & Me.ChkAllow3.CheckState & ", '" & _
                Me.txtEmail.Text & "', '" & Me.txtPTDisplayAs.Text & "', '" & Me.txtINRDisplayAs.Text & "', " & Me.NumMyInterval1.Value & ", " & Me.NumMyInterval2.Value & ");"

            MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()
        ElseIf IntCount = 1 Then
            SelectString = "UPDATE tblSettings SET [EnterpriseSetting] = 1, [PTCode] = '" & Me.txtPTCode.Text & "', [INRCode] = '" & Me.txtINRCode.Text & _
                "', [DefaultOverdueInterval] = " & Me.NumDefaultOverdueInterval.Value & ", [OverdueIntervalAllowOverride] = " & Me.ChkAllow1.CheckState & _
                ", [DefaultNotify] = " & Me.ChkDefaultNotify.CheckState & ", [NotifyAllowOverride] = " & Me.ChkAllow2.CheckState & ", [DefaultTaskPriority] = '" & _
                Me.cmbTaskPriority.Text & "', [TaskPriorityAllowOverride] = " & Me.ChkAllow3.CheckState & ", [Email] = '" & Me.txtEmail.Text & "', [PTDisplayAs] = '" & _
                Me.txtPTDisplayAs.Text & "', [INRDisplayAs] = '" & Me.txtINRDisplayAs.Text & "', [MyInterval1] = " & Me.NumMyInterval1.Value & ", [MyInterval2] = " & Me.NumMyInterval2.Value & " WHERE [EnterpriseSetting] = 1;"
         
            MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()

        End If

        MsgBox("Settings have been saved.", MsgBoxStyle.OkOnly, "Enterprise Settings Saved.")
        Me.Close()

    End Sub

    Private Sub txtPTCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTCode.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtINRCOde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtINRCode.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumDefaultOverdueInterval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumDefaultOverdueInterval.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow1.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkDefaultNotify_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDefaultNotify.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow2.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbTaskPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaskPriority.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow3.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtPTDisplayAs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTDisplayAs.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtINRDisplayAs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtINRDisplayAs.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval1.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval2.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

End Class