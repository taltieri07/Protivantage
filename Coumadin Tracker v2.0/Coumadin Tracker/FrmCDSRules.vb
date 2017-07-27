Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmCDSRules

    Private Sub FrmCDSRules_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ConnRuleInfo As SqlConnection
        Dim dsRuleDetails As New DataSet             'RuleDetails dataset
        Dim ConnString As String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnRuleInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnRuleInfo.Open()

        Dim qryDetails As String = "SELECT Priority, ReasonForTherapy, INRLowerLimit, INRUpperLimit, IncDec, PercentageChange, " & _
            "VarianceAllowed, Comment, Inactive FROM tblDosingAlgorithm WHERE (Inactive Is Null or Inactive = 0) ORDER BY Priority ASC"             'Sql Query for Therapy Details data grid"
        Dim RuleDetailsAdapter As New SqlDataAdapter         'Data Adapter for Therapy Details data grid view

        RuleDetailsAdapter.SelectCommand = New SqlCommand(qryDetails, ConnRuleInfo)
        RuleDetailsAdapter.Fill(dsRuleDetails, "tblDosingAlgorithm")

        Dim RuleDetails As DataTable = dsRuleDetails.Tables("tblDosingAlgorithm")
        Dim myView As DataView = New DataView(RuleDetails)

        Me.RuleDatagrid.DataSource = myView


        Me.RuleDatagrid.Columns(0).HeaderText = "Priority"
        Me.RuleDatagrid.Columns(1).HeaderText = "Reason For Therapy"
        Me.RuleDatagrid.Columns(2).HeaderText = "INR Range"
        Me.RuleDatagrid.Columns(3).HeaderText = "INR Range"
        Me.RuleDatagrid.Columns(4).HeaderText = "Suggested Change"
        Me.RuleDatagrid.Columns(5).HeaderText = "% Change"
        Me.RuleDatagrid.Columns(6).HeaderText = "Variance Allowed"
        Me.RuleDatagrid.Columns(7).HeaderText = "Comments"
        Me.RuleDatagrid.Columns(8).HeaderText = "Inactive"

        Me.RuleDatagrid.Columns(0).Resizable = True
        Me.RuleDatagrid.Columns(1).Resizable = True
        Me.RuleDatagrid.Columns(2).Resizable = True
        Me.RuleDatagrid.Columns(3).Resizable = True
        Me.RuleDatagrid.Columns(4).Resizable = True
        Me.RuleDatagrid.Columns(5).Resizable = True
        Me.RuleDatagrid.Columns(6).Resizable = True
        Me.RuleDatagrid.Columns(7).Resizable = True
        Me.RuleDatagrid.Columns(8).Resizable = True

        Me.RuleDatagrid.ColumnHeadersHeight = 60

        Me.RuleDatagrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(0).Width = 50
        Me.RuleDatagrid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(2).Width = 50
        Me.RuleDatagrid.Columns(3).Width = 50
        Me.RuleDatagrid.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(5).Width = 50
        Me.RuleDatagrid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(6).Width = 50
        Me.RuleDatagrid.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.RuleDatagrid.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.RuleDatagrid.Columns(0).ReadOnly = True
        Me.RuleDatagrid.Columns(1).ReadOnly = True
        Me.RuleDatagrid.Columns(2).ReadOnly = True
        Me.RuleDatagrid.Columns(3).ReadOnly = True
        Me.RuleDatagrid.Columns(4).ReadOnly = True
        Me.RuleDatagrid.Columns(5).ReadOnly = True
        Me.RuleDatagrid.Columns(6).ReadOnly = True
        Me.RuleDatagrid.Columns(7).ReadOnly = True
        Me.RuleDatagrid.Columns(8).ReadOnly = True

        ConnRuleInfo.Close()
    End Sub

    Public Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

        FrmCDS.Show()
        Me.Close()

    End Sub
End Class