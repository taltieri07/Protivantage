Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmTherapyDetailEdit

    Private Sub FrmTherapyDetailEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim ConnThpInfo As SqlConnection
        Dim dsThpDetails As New DataSet             'TherapyDetails dataset
        Dim ConnString As String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()

        Dim qryDetails As String = "SELECT EvaluationDate, Instructions, NextINR, EnteredBy, " & _
           "EnteredDTTM, Inactive, TherapyDetailID FROM tblTherapyDetails WHERE tblTherapyDetails.PatientID = " & PatID & _
           " and (Inactive = 0 or Inactive Is Null) ORDER BY tblTherapyDetails.EvaluationDate DESC"             'Sql Query for Therapy Details data grid"
        Dim ThpDetailsAdapter As New SqlDataAdapter         'Data Adapter for Therapy Details data grid view

        ThpDetailsAdapter.SelectCommand = New SqlCommand(qryDetails, ConnThpInfo)
        ThpDetailsAdapter.Fill(dsThpDetails, "tblTherapyDetails")

        Dim ThpDetails As DataTable = dsThpDetails.Tables("tblTherapyDetails")
        Dim myView As DataView = New DataView(ThpDetails)

        Me.TblTherapyDetailsDataGridView.DataSource = myView

        Me.TblTherapyDetailsDataGridView.Columns(6).Visible = False

        Me.TblTherapyDetailsDataGridView.Columns(0).HeaderText = "Eval Date"
        Me.TblTherapyDetailsDataGridView.Columns(1).HeaderText = "Instructions"
        Me.TblTherapyDetailsDataGridView.Columns(2).HeaderText = "NextINR"
        Me.TblTherapyDetailsDataGridView.Columns(3).HeaderText = "Entered By"
        Me.TblTherapyDetailsDataGridView.Columns(4).HeaderText = "Date Entered"
        Me.TblTherapyDetailsDataGridView.Columns(5).HeaderText = "Enter in Error"

        Me.TblTherapyDetailsDataGridView.Columns(0).Resizable = True
        Me.TblTherapyDetailsDataGridView.Columns(1).Resizable = True
        Me.TblTherapyDetailsDataGridView.Columns(2).Resizable = True
        Me.TblTherapyDetailsDataGridView.Columns(3).Resizable = True
        Me.TblTherapyDetailsDataGridView.Columns(4).Resizable = True
        Me.TblTherapyDetailsDataGridView.Columns(5).Resizable = True

        Me.TblTherapyDetailsDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.TblTherapyDetailsDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TblTherapyDetailsDataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.TblTherapyDetailsDataGridView.Columns(0).ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Columns(1).ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Columns(2).ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Columns(3).ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Columns(4).ReadOnly = True
        Me.TblTherapyDetailsDataGridView.Columns(5).ReadOnly = False



        Dim qryDetailsEIE As String = "SELECT EvaluationDate, Instructions, NextINR, " & _
           "TherapyDetailID, EnteredBy, EIEBy, EnteredDTTM, EIEDTTM FROM tblTherapyDetails WHERE tblTherapyDetails.PatientID = " & PatID & _
           " and Inactive = 1 ORDER BY tblTherapyDetails.EvaluationDate DESC"             'Sql Query for Therapy Details data grid"
        Dim ThpDetailsAdapterEIE As New SqlDataAdapter         'Data Adapter for Therapy Details data grid view
        Dim dsThpDetailsEIE As New DataSet

        ThpDetailsAdapterEIE.SelectCommand = New SqlCommand(qryDetailsEIE, ConnThpInfo)
        ThpDetailsAdapterEIE.Fill(dsThpDetailsEIE, "tblTherapyDetails")

        Dim ThpDetailsEIE As DataTable = dsThpDetailsEIE.Tables("tblTherapyDetails")
        Dim myViewEIE As DataView = New DataView(ThpDetailsEIE)

        Me.TblInactiveDetailsDataGridView.DataSource = myViewEIE

        Me.TblInactiveDetailsDataGridView.Columns(3).Visible = False

        Me.TblInactiveDetailsDataGridView.Columns(0).HeaderText = "Eval Date"
        Me.TblInactiveDetailsDataGridView.Columns(1).HeaderText = "Instructions"
        Me.TblInactiveDetailsDataGridView.Columns(2).HeaderText = "NextINR"
        Me.TblInactiveDetailsDataGridView.Columns(4).HeaderText = "Entered By"
        Me.TblInactiveDetailsDataGridView.Columns(5).HeaderText = "EIE By"
        Me.TblInactiveDetailsDataGridView.Columns(6).HeaderText = "Date Entered"
        Me.TblInactiveDetailsDataGridView.Columns(7).HeaderText = "Date EIE"


        Me.TblInactiveDetailsDataGridView.Columns(0).Resizable = True
        Me.TblInactiveDetailsDataGridView.Columns(1).Resizable = True
        Me.TblInactiveDetailsDataGridView.Columns(2).Resizable = True

        Me.TblInactiveDetailsDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TblInactiveDetailsDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.TblInactiveDetailsDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        
        Me.TblInactiveDetailsDataGridView.ReadOnly = True
        Me.TblInactiveDetailsDataGridView.GridColor = Color.Black
        Me.TblInactiveDetailsDataGridView.DefaultCellStyle.BackColor = Color.Coral

        ConnThpInfo.Close()

    End Sub

    Private Sub BtnInactivate_Click(sender As System.Object, e As System.EventArgs) Handles BtnInactivate.Click

        Dim ThpID As Integer
        Dim UpdateString As String

        Dim ConnThpInfo As SqlConnection
        Dim dsThpDetails As New DataSet             'TherapyDetails dataset
        Dim ConnString As String
        Dim MyCommand As SqlCommand

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnThpInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnThpInfo.Open()


        For Each row As DataGridViewRow In Me.TblTherapyDetailsDataGridView.Rows
            If Not IsDBNull(row.Cells.Item("Inactive").Value) Then
                If row.Cells.Item("Inactive").Value = True Then
                    ThpID = row.Cells.Item("TherapyDetailID").Value

                    UpdateString = "UPDATE tblTherapyDetails SET [Inactive] = 1, EIEBy = " & UserID & ", EIEDTTM = GetDate() " & _
                        "WHERE [TherapyDetailID] = " & ThpID & ";"

                    MyCommand = New SqlCommand(UpdateString, ConnThpInfo)
                    MyCommand.ExecuteNonQuery()

                End If
            End If
        Next

        ConnThpInfo.Close()
        FrmTherapyDetailEdit_Load(sender, e)

    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click

        Dim ConnString As String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If


        For Each row As DataGridViewRow In Me.TblTherapyDetailsDataGridView.Rows
            If Not IsDBNull(row.Cells.Item("Inactive").Value) Then
                If row.Cells.Item("Inactive").Value = True Then

                    Dim InactivateYN = MsgBox("There are items checked for inactivation that have not yet been inactivated.  Are you sure you want to close?", vbYesNo)

                    If InactivateYN = vbYes Then
                        FrmTrackerMain.Show()
                        FrmTrackerMain.PopulateTherapyDetails(ConnString)
                        Me.Close()
                    Else
                        Exit Sub
                    End If

                End If
            End If
        Next

        FrmTrackerMain.Show()
        FrmTrackerMain.PopulateTherapyDetails(ConnString)
        Me.Close()


    End Sub
End Class