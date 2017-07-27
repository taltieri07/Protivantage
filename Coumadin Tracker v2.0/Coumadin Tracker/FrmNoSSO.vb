Imports System.Configuration

Public Class FrmNoSSO

    Public m_Section As String

    'Public Sub New(ByVal section As String)
    'InitializeComponent()
    'If String.IsNullOrEmpty(section) Then _
    '   Throw New ArgumentNullException("ConfigurationSection")
    '    m_Section = section
    'End Sub


    Public Sub ProtectSection()
        ' Get the current configuration file.
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim protectedSection As ConfigurationSection = config.GetSection("appSettings")

        ' Encrypts when possible
        If ((protectedSection IsNot Nothing) _
        AndAlso (Not protectedSection.IsReadOnly) _
        AndAlso (Not protectedSection.SectionInformation.IsProtected) _
        AndAlso (Not protectedSection.SectionInformation.IsLocked)) Then
            ' Protect (encrypt)the section.
            protectedSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
            'this is for the Connection String
            config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
            ' Save the encrypted section.
            protectedSection.SectionInformation.ForceSave = True
            config.Save(ConfigurationSaveMode.Full)
        End If

    End Sub

    Private Sub FrmNoSSO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        m_Section = "appSettings"
        ProtectSection()

        MsgBox("No SSO Token was established.", vbOKOnly, "Error - No SSO Token")

        Application.Exit()

        MsgBox("test")

    End Sub


End Class