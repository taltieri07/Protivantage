Imports System
Imports System.Configuration
Imports System.ServiceModel.Configuration


Module StartingPoint

    Public Sub Main(ByVal Params() As String)

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.AddMessageFilter(FrmTrackerMain)


        'Parameterized String being called from Allscripts: C:\Program Files\Altimate Clinical Advantage\Protivantage\Protivantage.exe 
        '/AppGroup:{AppGroup} /sso:{SSOToken} /pid:{PatientID} /uid:{UserID} /uname:{UserName} /encid:{EncounterID} 
        '/orgMRN:{PatientOrganizationMRN} /entMRN:{PatientEnterpriseMRN}

        'EDIT 3-07-15 TJA
        'String = C:\Program Files\Altimate Clinical Advantage\Protivantage\Protivantage.exe /AppGroup:{AppGroup} /sso:{SSOToken} /encid:{EncounterID} /uid:{UserID}

        If Params.Count = 0 Or Params Is Nothing Then

            Application.Run(New FrmNoSSO)
            Application.Exit()

        End If

        Dim ColonLocation As Integer

        ColonLocation = InStr(Params(1), ":", CompareMethod.Text)
        Dim LauncherSSO As String = Right(Params(1), Len(Params(1)) - ColonLocation)

        'ColonLocation = InStr(Params(2), ":", CompareMethod.Text)
        'PatID = CInt(Right(Params(2), Len(Params(2)) - ColonLocation))

        ColonLocation = InStr(Params(3), ":", CompareMethod.Text)
        UserID = Right(Params(3), Len(Params(3)) - ColonLocation)

        'ColonLocation = InStr(Params(4), ":", CompareMethod.Text)
        'UserName = Right(Params(4), Len(Params(4)) - ColonLocation)


        serviceUser = System.Configuration.ConfigurationManager.AppSettings("ServiceUser")
        servicePwd = System.Configuration.ConfigurationManager.AppSettings("ServicePwd")
        appName = System.Configuration.ConfigurationManager.AppSettings("appName")

        'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        'Dim appConfigSection As ConfigurationSection = config.GetSection("system.servicemodel/client")

        Dim appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig)
        Dim bindings = serviceModel.Bindings
        Dim endpoints = serviceModel.Client.Endpoints

        Dim endpointElement = endpoints(0)
        Dim EndpointAddress As String = endpointElement.Address.OriginalString

        If EndpointAddress.ToUpper.StartsWith("HTTPS") Then
            BindingType = "securehttp"
        Else
            BindingType = "basichttp"
        End If

        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
        Dim MyToken As String

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


        'Dim MyDS1 As DataSet = unitySvc.Magic("GetUserAuthentication", twusername, appName, "", MyToken, twpassword, "", "", "", "", "", Nothing)

        'If MyDS1.Tables(0).Rows(0)("ValidUser") <> "YES" Then
        'MsgBox("There is a problem with the EHR user identified in app.config.  Please notify your administrator.", vbOKOnly)
        'Exit Sub
        'End If

        Dim MyDS1 As DataSet = unitySvc.Magic("GetTokenValidation", "", appName, "", MyToken, LauncherSSO, "", "", "", "", "", Nothing)
        twusername = MyDS1.Tables(0).Rows(0)("SSOUserName")
        PatID = MyDS1.Tables(0).Rows(0)("PatientID")


        Dim MyDS2 As DataSet = unitySvc.Magic("GetServerInfo", twusername, appName, "", MyToken, "", "", "", "", "", "", Nothing)


        unitySvc.RetireSecurityToken(serviceUser, servicePwd)

        Application.Run(New FrmTrackerMain)


    End Sub

End Module
