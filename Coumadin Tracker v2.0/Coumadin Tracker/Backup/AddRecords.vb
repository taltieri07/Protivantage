Public Class AddRecords

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim tblTherapy As DataTable = CoumadinTrackerDataSet.Tables("tblTherapy")

        Dim anyRow As DataRow = tblTherapy.NewRow

        anyRow("PatientID") = PatID
        anyRow("TherapyStartDate") = Me.dtTherapyStartDate.Value
        anyRow("ReasonForTherapy") = Me.cmbReasonForTherapy.Text
        anyRow("AdditionalReasonForTherapy") = Me.cmbAdditionalReasonForTherapy.Text
        anyRow("ExpectedLengthOfTherapy") = Me.cmbExpectedLengthOfTherapy.Text
        anyRow("PillSizeAtHome") = Me.cmbPillSize.Text
        anyRow("Notify") = Me.cbNotify.Checked
        anyRow("NotifyInterval") = Me.txtNotifyInterval.Value

        tblTherapy.Rows.Add(anyRow)


    End Sub

End Class