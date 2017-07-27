<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllscriptsUAI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPatID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnManageCoumadin = New System.Windows.Forms.Button()
        Me.btnAddTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPatID
        '
        Me.txtPatID.Location = New System.Drawing.Point(116, 54)
        Me.txtPatID.Name = "txtPatID"
        Me.txtPatID.Size = New System.Drawing.Size(141, 20)
        Me.txtPatID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient ID:"
        '
        'btnManageCoumadin
        '
        Me.btnManageCoumadin.Location = New System.Drawing.Point(278, 51)
        Me.btnManageCoumadin.Name = "btnManageCoumadin"
        Me.btnManageCoumadin.Size = New System.Drawing.Size(126, 23)
        Me.btnManageCoumadin.TabIndex = 2
        Me.btnManageCoumadin.Text = "&Manage Coumadin"
        Me.btnManageCoumadin.UseVisualStyleBackColor = True
        '
        'btnAddTest
        '
        Me.btnAddTest.Location = New System.Drawing.Point(278, 106)
        Me.btnAddTest.Name = "btnAddTest"
        Me.btnAddTest.Size = New System.Drawing.Size(126, 23)
        Me.btnAddTest.TabIndex = 3
        Me.btnAddTest.Text = "&Add Test Record"
        Me.btnAddTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User ID:"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(116, 28)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(141, 20)
        Me.txtUserID.TabIndex = 4
        Me.txtUserID.Text = "6789"
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(402, 209)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(96, 23)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Tag = ""
        Me.btnSettings.Text = "&Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'AllscriptsUAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 235)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnAddTest)
        Me.Controls.Add(Me.btnManageCoumadin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPatID)
        Me.Name = "AllscriptsUAI"
        Me.Text = "AllscriptsUAI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPatID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnManageCoumadin As System.Windows.Forms.Button
    Friend WithEvents btnAddTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnSettings As System.Windows.Forms.Button
End Class
