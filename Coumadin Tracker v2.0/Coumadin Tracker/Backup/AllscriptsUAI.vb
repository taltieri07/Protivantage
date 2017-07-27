Public Class AllscriptsUAI

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageCoumadin.Click

        Dim oForm As FrmTrackerMain

        If Me.txtPatID.Text = "" Then
            MsgBox("Patient ID cannot be null.", MsgBoxStyle.OkOnly, "Enter a Patient ID")
            Exit Sub
        End If

        PatID = Me.txtPatID.Text
        UserID = Me.txtUserID.Text

        oForm = New FrmTrackerMain()
        oForm.Show()
        oForm = Nothing

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTest.Click
        Dim oForm As AddRecords

        oForm = New AddRecords()
        oForm.Show()
        oForm = Nothing

    End Sub

    Private Sub AllscriptsUAI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        Dim oForm As FrmSettings

        oForm = New FrmSettings
        oForm.Show()
        oForm = Nothing
    End Sub

End Class