Imports System.Data.SqlServerCe

Public Class FrmUserSettings

    Dim ConnAllscripts As SqlCeConnection       'connection to Works database
    Dim ConnString As String                    'Connection String to CoumadinTracker
    Dim ConnStringAHS As String                 'Connection String to Works
    Dim SelectString As String                  'Sql Query
    Dim SelectStringSettings As String          'Sql Query
    Dim ConnSettingsInfo As SqlCeConnection     'represents unique connection to database
    Dim MyCommand As SqlCeCommand               'reads the records from database	
    Dim drSettingsInfo As SqlCeDataReader       'stores the retrieved records


    Private Sub FrmUserSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        SelectStringSettings = "Select * FROM tblSettings WHERE UserID = " & UserID
        MyCommand = New SqlCeCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()

            If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
                Me.NumDefaultOverdueInterval.Value = drSettingsInfo("DefaultOverdueInterval")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
                Me.ChkDefaultNotify.Checked = drSettingsInfo("DefaultNotify")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
                Me.cmbTaskPriority.Text = drSettingsInfo("DefaultTaskPriority")
            End If

            If Not IsDBNull(drSettingsInfo("Email")) Then
                Me.txtEmail.Text = drSettingsInfo("Email")
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

        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE UserID = " & UserID
        MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            SelectString = "INSERT INTO tblSettings([EnterpriseSetting], [DefaultOverdueInterval], " & _
                "[DefaultNotify], [DefaultTaskPriority], [Email], [UserID) " & _
                "VALUES (0, " & Me.NumDefaultOverdueInterval.Value & ", " & _
                Me.ChkDefaultNotify.CheckState & ", '" & Me.cmbTaskPriority.Text & "', '" & Me.txtEmail.Text & "', " & UserID & ");"

            MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()
        ElseIf IntCount = 1 Then
            SelectString = "UPDATE tblSettings SET [EnterpriseSetting] = 0, " & _
                "', [DefaultOverdueInterval] = " & Me.NumDefaultOverdueInterval.Value & ", " & _
                ", [DefaultNotify] = " & Me.ChkDefaultNotify.CheckState & ", [DefaultTaskPriority] = '" & _
                Me.cmbTaskPriority.Text & "', [Email] = '" & Me.txtEmail.Text & "' WHERE [UserID] = " & UserID & ";"

            MyCommand = New SqlCeCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()

        End If

        MsgBox("Settings have been saved.", MsgBoxStyle.OkOnly, "Enterprise Settings Saved.")
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

End Class