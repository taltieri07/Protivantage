Imports System.Data.SqlClient

Public Class FrmTrackerMain

    Dim ConnThpInfo As SqlConnection        'represents unique connection to database
    Dim MyCommand As SqlCommand             'reads the records from database	
    Dim drThpInfo As SqlDataReader          'stores the retrieved records
    Dim SelectString As String              'Sql Query
    Dim ConnString As String                'Connection String

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

        Me.txtInstructions.AppendText("Continue same dose.")

    End Sub

    Private Sub FrmTrackerMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ConnString = _
        '"Data Source=localhost;" & _
        '"Integrated Security=true;" & _
        '"Initial Catalog=CoumadinTracker/sqlexpress"

        ConnString = "Server=.\SQLExpress;" & _
        "Database=test;" & _
        "User ID = sa;" & _
        "Password = Frnk5378!"

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        SelectString = "Select * FROM tblTherapy WHERE PatientID = 8787"
        MyCommand = New SqlCommand(SelectString, ConnThpInfo)
        drThpInfo = MyCommand.ExecuteReader

        While drThpInfo.Read()
            MsgBox("Employee Name: " + drThpInfo(2) + vbCrLf + _
             "Employee ID: " + drThpInfo(0) + vbCrLf + _
             "Department ID: " + drThpInfo(1))
        End While



        Me.txtCurPatID.Text = PatID



    End Sub

    Private Sub TblTherapyDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTherapyDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTherapyDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CoumadinTrackerDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.TblTherapyDetailsTableAdapter.FillBy(Me.CoumadinTrackerDataSet.tblTherapyDetails, CType(PatIDToolStripTextBox.Text, Long))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
