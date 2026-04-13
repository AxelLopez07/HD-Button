Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Threading
Imports HD_Button.DB_Tools
Imports Microsoft.SqlServer
Imports Microsoft.VisualBasic.FileIO
Imports MongoDB.Driver.Search
Imports SharpCompress.Archives
Imports SharpCompress.Readers
Imports System.ServiceProcess

Public Class Installs
    'XDMB service
    Private Sub DMB_Click(sender As Object, e As EventArgs) Handles DMB.Click
        Try
            'check if XDMB service exists on the database
            Dim xdbmName2 As DataTable = GetTableDataFromServer("select Title from iris.dbo.tbl_Application where Title='XenialDMBSvc'")
            Dim xdbmName As String = xdbmName2.Rows(0)(0).ToString

            'If not exists then proceed to add it to the database
            If xdbmName <> "XenialDMBSvc" Then

                'Dim SeqNum As Integer = 1013
                Dim SeqNum2 As DataTable = GetTableDataFromServer("select max(seqnum)+1 from iris.dbo.tbl_Application")
                Dim value As Object = SeqNum2.Rows(0)(0)
                Dim SeqNum As Integer = Convert.ToInt32(value)
                Dim XenialSvcName As String = "XenialDMBSvc"
                Dim XenialSvcPath As String = "C:\iris\bin\XenialDMBSvc.exe CONSOLE"
                Dim XenialSvcDir As String = "C:\iris\bin\"
                Dim AdminName As String = "iris_admin"
                Dim AdminKey As String = "0x004C78454442200300200000001752AC6D3EC5DFDC8929FABCEE3943D10F46A6E2E336B2B792B0898D04DB850CD822AAFE546C6FB607F22AA0C746D63FA97C152615BB10326D0E89C6B291CD18E8"

                ExecuteCmdToServer(VarString:=$"Begin IF NOT EXISTS(Select * from iris.dbo.tbl_Application where SeqNum={SeqNum}) Begin insert into iris.dbo.tbl_Application values({SeqNum},'{XenialSvcName}','{XenialSvcPath}','{XenialSvcDir}',NULL,0,1,1,0,0,0,1,1,1,0,0,0,0,0,22,1,'{AdminName}',{AdminKey},0) end end")


            Else 'if xdmb name exists, then just overwrite the XenialDMBSvc.ini file

                Dim XenialSvcINI As String = "C:\IRIS\ini\XenialDMBSvc.ini"
                File.Create(XenialSvcINI).Dispose()

                Dim IP As String = TextBox1.Text
                Dim Debug As String = 1
                Dim ExternalItemNum As String = 2
                Dim Categories As String = Nothing
                Dim ClientRouting As String = 1
                Dim aryText() As String = {"[Options]", $"Address={IP}", $"Debug={Debug}", $"ExternalItemNum={ExternalItemNum}", $"Categories={Categories}", $"ClientRouting={ClientRouting}"}

                Using objWriter As New StreamWriter(XenialSvcINI, True)
                    For Each txt In aryText
                        objWriter.WriteLine(txt)
                    Next
                End Using
            End If

            MessageBox.Show("Installation completed! Remember to do a ""Sign Out"" to start the new service.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Change Store Number
    Private Sub StoreNumB_Click(sender As Object, e As EventArgs) Handles StoreNumB.Click
        Dim SN As Integer = TextBox2.Text
        DialogResult = MessageBox.Show($"Are you sure you want to change this location's store number to {SN}?", "Change Store Number", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.Yes) Then
            ExecuteCmdToServer(VarString:=$"update iris.dbo.tblStoreInfo set StoreNum={SN}")
            Shell("cmd /c cd C:\EDMWeb & del ""authenticationSchema.xml"" & del ""schema_iris.xml"" \wait")

            ExecuteCmdToServer(VarString:="ALTER DATABASE EdmWeb SET OFFLINE; ALTER DATABASE EdmWeb SET ONLINE; DROP DATABASE EdmWeb; ALTER DATABASE Auth SET OFFLINE; ALTER DATABASE Auth SET ONLINE; DROP DATABASE Auth")
            Shell("cmd /c cd C:\EDMWeb & go.bat")

            MessageBox.Show(
$"Wait for EDM to finish loading and follow the instructions below.

1.- On the EDM window click ""logout"" and then login as administrator.

Username: admin 
Password: admin 

2.- Go to ""Sites"" tab, then click on ""Edit Locations and Groups"" submenu, here we should have 2 location IDs, ""0"" and ""{SN}"" available.

3.- Open ID: ""0"" and make sure values are correct (Look at the next picture)", "Change Store Number")

            Clipboard.SetText("https://starcorp-edm.xenial.com/edm/")
            Me.Hide()
            Pic1.ShowDialog()
            Me.Show()

            MessageBox.Show(
$"4-. Next, make sure the location is correct ID: ""{SN}"", and make sure the name match with the brand and store number, for example ""CJ/HD #{SN}"" 
Save the changes and close the EDM window. 

After this, location should be ready to receive ""sent table refresh"" Data/Deployment", "Change Store Number")
        Else
            MessageBox.Show("Be Careful!!", "Change Store Number")
        End If
    End Sub
    'INSTALLS Button
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Button1.Enabled = False

            '-------------------------------------------------------------------------------------------------------------------------------
            'CARL'S jr's--------------------------------------------------------------------------------------------------------------------
            If Me.RBUpdatesCarls.Checked = True Then

                '----------------Extract STCO.exe File
                ExtractFromRAR("File", "Files\Common\temp\STCO.exe", "C:\temp")

                '-----------------Stage STCO file updates (1st Updates)
                ExecuteCMD("cmd /c C:\Temp\STCO.exe")

                '----------------Extract Updated Files (2nd updates)
                ExtractFromRAR("Directory", "Files\Carls\", "C:\")

                '-----------Run "DatabaseUpdate.sql" file (check file for details)
                ExecuteCMD("cmd /c sqlcmd -S localhost\XSIRIS -s, -W -i C:\Temp\DatabaseUpdates.sql")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\DatabaseUpdates.sql' -Recurse -Force")

                '-----------extract and Run sp_datakey values_custom update
                ExtractFromRAR("File", "Files\Common\temp\sp_datakeyvalues_custom.sql", "C:\temp")
                ExecuteCMD("cmd /c sqlcmd -S localhost\XSIRIS -s, -W -i C:\Temp\sp_datakeyvalues_custom.sql")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\sp_datakeyvalues_custom.sql' -Recurse -Force")

                '-----------Import sites to CoreFPT.exe (Carl's Jr's) as iris_admin windows user
                ExecuteCMD("cmd /c " & "c:\program files\coreftp\coreftp.exe" & " -import " & "c:\Temp\CoreFTP_sites")

                'Update STORENUM in the TPE_SVS.ini file
                ExecuteCMD("cmd /c C:\Temp\UpdateTPE_SVS_Carls.bat")
                'ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\StoreNum.txt' -Recurse -Force")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\UpdateTPE_SVS_Carls.bat' -Recurse -Force")

                '----------------Register WIndows Tasks
                'Register "House_account" task to the windows task scheduler
                ExecuteCMD("cmd /c schtasks /delete /tn " & "House_Account_update" & " /f")
                ExecuteCMD("cmd /c schtasks /create /tn " & "House_Account_update" & " /xml " & "C:\Temp\House_Account_update.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\House_Account_update.xml' -Recurse -Force")

                'Register CKE data tasks
                ExecuteCMD("cmd /c schtasks /delete /tn " & "PSI_Exporter_2" & " /f")
                ExecuteCMD("cmd /c schtasks /create /tn " & "PSI_Exporter_2" & " /xml " & "C:\Temp\PSI_Exporter_2.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\PSI_Exporter_2.xml' -Recurse -Force")

                'Register Services running
                ExecuteCMD("cmd /c C:\Temp\services_running_registration.bat")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\services_running_registration.bat' -Recurse -Force")

                'Extract and Execute NewFinFileXpient.vbs via cmd to update new Fin File store procedures
                ExtractFromRAR("Directory", "Files\Common\xpient\FinFileLayoutUpdate\", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\InstallNewFinFile.vbs")

                'Extract and Execute UpdateAppini_GiftCard_Scanning.vbs via cmd to update new Gift cards with the Scanners
                ExtractFromRAR("File", "Files\Common\temp\UpdateAppini_GiftCard_Scanning.vbs", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\UpdateAppini_GiftCard_Scanning.vbs")

                'Turn OFF windows firewall
                ExecuteCMD("cmd /c netsh advfirewall set allprofiles state off")

                'grant full permissions to iris_user & iris_admin to the folders and subfolders from "C:\iris" & "C:\Program Files (x86)\xpient Solutions"
                ExecuteCMD("cmd /c icacls " & "C:\Iris" & " /grant iris_user:F /T")
                ExecuteCMD("cmd /c icacls " & "C:\Iris" & " /grant iris_admin:F /T")

                ExecuteCMD("cmd /c icacls " & "C:\Program Files (x86)\xpient Solutions" & " /grant iris_user:F /T")
                ExecuteCMD("cmd /c icacls " & "C:\Program Files (x86)\xpient Solutions" & " /grant iris_admin:F /T")

            End If

            '-------------------------------------------------------------------------------------------------------------------------------
            'HARDEES------------------------------------------------------------------------------------------------------------------------
            If Me.RBUpdatesHardees.Checked = True Then

                '----------------Extract STCO.exe File
                'UnrarResourceFile(My.Resources.STCO_exe, "C:\")
                ExtractFromRAR("File", "Common\temp\STCO.exe", "C:\temp")

                '-----------------Stage STCO file updates (1st Updates)
                ExecuteCMD("cmd /c C:\Temp\STCO.exe")

                '----------------Extract Updated Files (2nd updates)
                'UnrarResourceFile(My.Resources.Hardees, "C:\")
                ExtractFromRAR("Directory", "Hardees\", "C:\")

                '-----------Run "DatabaseUpdate.sql" file check file for details
                ExecuteCMD("cmd /c sqlcmd -S localhost\XSIRIS -s, -W -i C:\Temp\DatabaseUpdates.sql")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\DatabaseUpdates.sql' -Recurse -Force")

                '-----------extract and Run sp_datakey values_custom update
                ExtractFromRAR("File", "Files\Common\temp\sp_datakeyvalues_custom.sql", "C:\temp")
                ExecuteCMD("cmd /c sqlcmd -S localhost\XSIRIS -s, -W -i C:\Temp\sp_datakeyvalues_custom.sql")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\sp_datakeyvalues_custom.sql' -Recurse -Force")

                '-----------Import sites to CoreFPT.exe (Hardee's)
                ExecuteCMD("cmd /c " & "c:\program files\coreftp\coreftp.exe" & " -import " & "c:\Temp\new_MBM_site")

                'Update STORENUM in the TPE_SVS.ini file
                ExecuteCMD("cmd /c C:\Temp\UpdateTPE_SVS.bat")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\StoreNum.txt' -Recurse -Force")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\UpdateTPE_SVS.bat' -Recurse -Force")

                '----------------Register WIndows Tasks
                'Register "House_account" tash to the windows task scheduler
                ExecuteCMD("cmd /c schtasks /delete /tn " & "House_Account_update" & " /f")
                ExecuteCMD("cmd /c schtasks /create /tn " & "House_Account_update" & " /xml " & "C:\Temp\House_Account_update.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\House_Account_update.xml' -Recurse -Force")

                'Register CKE data tasks
                ExecuteCMD("cmd /c schtasks /delete /tn " & "PSI_Exporter_2" & " /f")
                ExecuteCMD("cmd /c schtasks /create /tn " & "PSI_Exporter_2" & " /xml " & "C:\Temp\PSI_Exporter_2.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")
                ExecuteCMD("cmd /c powershell -Command " & "Remove-Item 'C:\Temp\PSI_Exporter_2.xml' -Recurse -Force")

                'Register Services running
                ExecuteCMD("cmd /c C:\Temp\services_running_registration.bat")

                'Extract and execute NewFinFileXpient.vbs via cmd to update new Fin File store procedures
                ExtractFromRAR("Directory", "Common\xpient\FinFileLayoutUpdate\", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\InstallNewFinFile.vbs")

                'Extract and Execute UpdateAppini_GiftCard_Scanning.vbs via cmd to update new Gift cards with the Scanners
                ExtractFromRAR("File", "Files\Common\temp\UpdateAppini_GiftCard_Scanning.vbs", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\UpdateAppini_GiftCard_Scanning.vbs")

                'Turn OFF windows firewall
                ExecuteCMD("cmd /c netsh advfirewall set allprofiles state off")

                'grant full permissions to iris_user & iris_admin to the folders and subfolders from "C:\iris" & "C:\Program Files (x86)\xpient Solutions"
                ExecuteCMD("cmd /c icacls " & "C:\Iris" & " /grant iris_user:F /T")
                ExecuteCMD("cmd /c icacls " & "C:\Iris" & " /grant iris_admin:F /T")

                ExecuteCMD("cmd /c icacls " & "C:\Program Files (x86)\xpient Solutions" & " /grant iris_user:F /T")
                ExecuteCMD("cmd /c icacls " & "C:\Program Files (x86)\xpient Solutions" & " /grant iris_admin:F /T")

            End If

            '-------------------------------------------------------------------------------------------------------------------------------
            'OLO----------------------------------------------------------------------------------------------------------------------------
            If Me.CB_OLO.Checked = True Then

                If Directory.Exists("C:\Program Files (x86)\Olo") Then
                    MsgBox("OLO folder found!, need to uninstall OLO and delete OLO folder and files (C:\Program Files (x86)\Olo) before install OLO again")
                Else

                    Dim OLOUserName As String = "user"
                    Dim OLOPassword As String = "password"

                    Dim SN As DataTable = GetTableDataFromServer("select storenum from iris.dbo.tblStoreInfo")
                    Dim Found As Integer = 0

                    ' Convert the byte resource to a string
                    Dim csvBytes As Byte() = My.Resources.OLOCredentials
                    Dim csvContent As String = System.Text.Encoding.UTF8.GetString(csvBytes)

                    ' Split the CSV content into rows
                    Dim rows As String() = csvContent.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                    ' Define the word to search for
                    Dim searchWord As String = SN.Rows(0)(0).ToString

                    ' Initialize variables to store the results
                    'Dim secondColumnValue As String = String.Empty
                    'Dim thirdColumnValue As String = String.Empty

                    ' Loop through each row to find the search word in the first column
                    For Each row As String In rows
                        ' Split the row into columns (assuming a comma delimiter)
                        Dim columns As String() = row.Split(","c)

                        ' Check if the first column contains the search word
                        If columns.Length >= 3 AndAlso columns(0).Trim() = searchWord Then
                            Found = 1
                            ' Retrieve the second and third column values
                            OLOUserName = columns(1).Trim()
                            OLOPassword = columns(2).Trim()

                            ' Exit the loop since we only need the matching row
                            Exit For

                        End If
                    Next

                    If Found = 0 Then
                        MsgBox("Store Number '" & searchWord.ToString & "'  Not Found!")
                    Else

                        'create patch if not exist C:\Xpient
                        If Not Directory.Exists("C:\Xpient") Then
                            Directory.CreateDirectory("C:\Xpient")
                        End If

                        'Download OLO installer
                        DownloadFromFTP("Stores_Apps/OLO/OLOw7.exe", "C:\Xpient\OLOw7.exe")

                        'Install OLO command
                        'ExecuteCMD("cmd /c C:\xpient\OLOw7.exe –IIS –POI –olocode " & OLOUserName.ToString & " –olopw " & OLOPassword.ToString & "")

                        'execute OLO installer with arguments and wait for installation to be done
                        Dim psi As New ProcessStartInfo()

                        psi.FileName = "cmd.exe"
                        psi.Arguments = "/c ""C:\xpient\OLOw7.exe –IIS –POI –olocode " & OLOUserName.ToString & " –olopw " & OLOPassword.ToString & """"
                        psi.UseShellExecute = True
                        psi.Verb = "runas"   ' Run as Administrator
                        psi.WindowStyle = ProcessWindowStyle.Normal   ' optional

                        Try
                            Dim proc As Process = Process.Start(psi)

                            If proc IsNot Nothing Then
                                proc.WaitForExit()
                                MsgBox("OLO Installation Complete!")
                            End If

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                    End If

                End If
            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            'Xpient Loyalty Controller (XLC)-------------------------------------------------------------------------------------------------------------------------------------------------------------
            If Me.CB_Loyalty.Checked = True Then

                If Directory.Exists("C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller") Then
                    MsgBox("Loyalty folder found!, need to uninstall XLC and delete XLC folder and files (C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller) before install XLC again")
                Else

                    'Create required LoyaltyCustomValues.ini files for BOC and registers path
                    Dim fileName As String = "LoyaltyCustomValues"
                    Dim extension As String = ".ini"   ' any extension you want
                    Dim folderPath As String = "c:\iris\data"
                    Dim folderPath2 As String = "c:\iris\reginfo\common\data"

                    Dim fullPath As String = Path.Combine(folderPath, fileName & extension)
                    Dim fullPath2 As String = Path.Combine(folderPath2, fileName & extension)
                    Dim fileContent As String = "[Loyalty]
LoyaltyCustomValue4=7573
LoyaltyCustomValue7=1
LoyaltyCustomValue8=60
LoyaltyCustomValue9=11/3/2021 10:14:46 AM
LoyaltyCustomValue5=
LoyaltyCustomValue6="

                    File.WriteAllText(fullPath, fileContent)
                    File.WriteAllText(fullPath2, fileContent)

                    'If the [Loyalty] section doesn't exist in the App.ini file, add it to the end of the file
                    'File Paths where the [Loyalty] values will be written
                    Dim fileAppIniPath As New List(Of String)()
                    fileAppIniPath.Add("C:\iris\ini\appini.ini")
                    fileAppIniPath.Add("C:\iris\reginfo\reg1\ini\appini.ini")
                    fileAppIniPath.Add("C:\iris\reginfo\reg2\ini\appini.ini")
                    fileAppIniPath.Add("C:\iris\reginfo\reg3\ini\appini.ini")
                    fileAppIniPath.Add("C:\iris\reginfo\reg4\ini\appini.ini")
                    fileAppIniPath.Add("C:\iris\reginfo\reg5\ini\appini.ini")

                    Dim wordToFind As String = "[Loyalty]"

                    ' Lines to add if word [Loyalty] does not exist
                    Dim linesToAdd As String() = {
        "[Loyalty]",
        "Log=127",
        "AddinServerName=Punchh",
        "Adapter_0=Punchh",
        "SubmitTimeOut=10",
        "GenerateTimeOut=10",
        "IDExpireSeconds=60",
        "UseFiletransfer=0",
        "WebServerURL=192.168.1.100:8044",
        "requestdir=c:\loyaltyrequests",
        "responsedir=c:\loyaltyresponses",
        "Blankbitmap=loywhite.bmp",
        "AutoBitmp=loyauto.bmp",
        "applyBitmap=loyapply.bmp",
        "Skipbitmap=loyskip.bmp",
        "enablePhoneNumActivate=1",
        "EnableMobileCode=1",
        "EnableEmailLookup=1",
        "AutoDetectNumber=1",
        "CardLengthMin=-1",
        "cardLengthMax=-1",
        "PhoneLength=10",
        "MobileCodeLength=7",
        "QRPrefix=|",
        "QRcodeEnclosure=PUNCHH",
        "ScanCodePrefix=C",
        "EnableLoyaltyBarCode=1",
        "SenditemTypeExDetail=1",
        "IgnoreIDExpire=1",
        "ApplyRewardsOnAccept=1",
        "DisableNumericLoyaltyCodeScanOnOrderScreen=0"
    }

                    'Cycle to verify values exists or if need to be written in Reg1 to Reg5
                    For I As Integer = 0 To 5
                        ' Make sure file exists
                        If Not File.Exists(fileAppIniPath(I).ToString) Then
                            'MessageBox.Show("app.ini file not found.")
                        Else
                            ' Read entire appini.ini file
                            Dim fileContentIni As String = File.ReadAllText(fileAppIniPath(I).ToString)
                            ' Check if word exists (case insensitive)
                            If Not fileContentIni.IndexOf(wordToFind, StringComparison.OrdinalIgnoreCase) >= 0 Then

                                ' Append lines at the end
                                File.AppendAllLines(fileAppIniPath(I).ToString, linesToAdd)

                                'MessageBox.Show("Lines added successfully.")
                            Else
                                'MessageBox.Show("Word already exists. No changes made.")
                            End If
                        End If
                    Next

                    'diferent [Loyalty] values for the xsposserver.ini file on the BOC only
                    Dim linesToAdd2 As String() = {
        "[Loyalty]",
        "SubmitAllOrdersOrderPoints=Olo"}

                    ' Make sure file exists
                    If Not File.Exists("C:\iris\ini\xsposserver.ini") Then
                        MessageBox.Show("C:\iris\ini\xsposserver.ini file not found.")
                    Else
                        ' Read entire C:\iris\ini\xsposserver.ini file
                        Dim fileContentIni As String = File.ReadAllText("C:\iris\ini\xsposserver.ini")
                        ' Check if word not exists (case insensitive)
                        If Not fileContentIni.IndexOf(wordToFind, StringComparison.OrdinalIgnoreCase) >= 0 Then

                            ' Append lines at the end
                            File.AppendAllLines("C:\iris\ini\xsposserver.ini", linesToAdd2)

                            'MessageBox.Show("Lines added successfully.")
                        Else
                            'MessageBox.Show("Word already exists. No changes made.")
                        End If
                    End If

                    'Download XLC installer from FTP site
                    DownloadFromFTP("Stores_Apps/XLC/XLC_2.5.0.325.exe", "C:\temp\XLC_2.5.0.325.exe")

                    'Execute XLC installer with arguments and wait for installation to be done
                    Dim psi As New ProcessStartInfo()
                    psi.FileName = "C:\temp\XLC_2.5.0.325.exe"
                    psi.Arguments = "/COMPONENTS=Punchh /VERYSILENT /SUPPRESSMSGBOXES /NORESTART /RESTARTEXITCODE=30103"   'Arguments go here
                    psi.Verb = "runas"
                    psi.UseShellExecute = True

                    Try
                        Dim p As Process = Process.Start(psi)

                        If p IsNot Nothing Then
                            p.WaitForExit()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    'Get Store Number from database
                    Dim SN As DataTable = GetTableDataFromServer("select storenum from iris.dbo.tblStoreInfo")
                    Dim Found As Integer = 0

                    'Location Key variable
                    Dim LocationKey As String = ""

                    'Search Store Location Key from resrouce file and store in its variable
                    ' Convert the byte resource to a string
                    Dim csvBytes As Byte() = My.Resources.XLCLocationKey
                    Dim csvContent As String = System.Text.Encoding.UTF8.GetString(csvBytes)

                    ' Split the XLC CSV content into rows
                    Dim rows As String() = csvContent.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                    ' Define the word to search for, in this case the XLC variable stored before
                    Dim searchWord As String = SN.Rows(0)(0).ToString

                    ' Loop through each row to find the search word in the first column
                    For Each row As String In rows
                        ' Split the row into columns (assuming a comma delimiter)
                        Dim columns As String() = row.Split(","c)

                        ' Check if the first column contains the search word
                        If columns.Length >= 2 AndAlso columns(0).Trim() = searchWord Then
                            Found = 1
                            ' Retrieve the second column value (Location Key)
                            LocationKey = columns(1).Trim()

                            ' Exit the loop since we only need the matching row
                            Exit For

                        End If
                    Next

                    'IF store Locatio Key is Not found, cancel, otherwise, write store location key in the XLC config file
                    If Found = 0 Then
                        MsgBox("Location Key number for Store '" & searchWord.ToString & "' Not Found in the XLCLocationKey.csv file!")
                    Else

                        'Download ddisc.LIC (Lincese) file for the XLC installation to the iris linceses folder path
                        DownloadFromFTP("Stores_Apps/XLC/ddisc.lic", "c:\iris\Licenses\ddisc.lic")

                        'Download XLC.LICX (Lincese) file for the XLC installation to the XLC lincense folder path
                        DownloadFromFTP("Stores_Apps/XLC/XLC.licx", "c:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller\Licenses\XLC.licx")

                        'download Punchh.dll.config file to the XL installation folder path
                        DownloadFromFTP("Stores_Apps/XLC/Punchh.dll.config", "C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller\PipeLine\AddIns\Loyalty\Punchh.dll.config")

                        'Edit the Punchh.dll.config file to add the store location key found in the XLCLocationKey.csv file
                        Dim filePath As String = "C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller\PipeLine\AddIns\Loyalty\Punchh.dll.config"

                        ' Read all text
                        Dim content As String = IO.File.ReadAllText(filePath)

                        ' Replace text
                        content = content.Replace("f2896d38fa3a6e248795d16bd5eafeba", LocationKey.ToString)

                        ' Write back to file
                        IO.File.WriteAllText(filePath, content)

                        'Reset windos XLC service to apply changes
                        Dim serviceName As String = "YourServiceName"
                        Dim sc As New ServiceController(serviceName)

                        Try
                            ' Stop service if running
                            If sc.Status <> ServiceControllerStatus.Stopped AndAlso sc.Status <> ServiceControllerStatus.StopPending Then
                                sc.Stop()
                                sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30))
                            End If

                            ' Start service
                            sc.Start()
                            sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30))

                            'MessageBox.Show("Service restarted successfully!")

                        Catch ex As Exception
                            MessageBox.Show("Error restarting XLC service: " & ex.Message)
                        End Try

                    End If


                    MsgBox("XLC installation complete!")
                End If

            End If

            '------------------------------------------------------------------------------------------------------------------------------
            'Xenial Sync Service-----------------------------------------------------------------------------------------------------------
            If Me.CB_XenialSync.Checked = True Then
                'extract and Execute Xenial Sync Files
                ExtractFromRAR("File", "Files\Common\xpient\XenialSync\InstallXenialSync.exe", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\InstallXenialSync.exe")
                MsgBox("XenyalSync service installation completed!")
            End If

            '-------------------------------------------------------------------------------------------------------------------------------
            'WinSCP-------------------------------------------------------------------------------------------------------------------------
            If Me.CB_WinSCP.Checked = True Then
                'Extract and Execute WinSCP
                ExtractFromRAR("File", "Files\Common\xpient\WinSCP-5.21.8-Setup.exe", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpien\WinSCP-5.21.8-Setup.exe")
                MsgBox("WinSCP installation completed!")
            End If

            '-------------------------------------------------------------------------------------------------------------------------------
            'Google Chrome Installation-----------------------------------------------------------------------------------------------------
            If Me.CB_GC.Checked = True Then
                'ExecuteCMD("cmd /c powershell -Command " & "Start-Process -FilePath " & "$env:TEMP\chrome_installer.exe" & " -ArgumentList '/silent', '/install' -Wait")
                'MsgBox("Google Chrome installation completed!")

                Try
                    Dim installerPath As String = "C:\Temp\GoogleChromeStandaloneEnterprise64.msi"
                    Dim downloadUrl As String = "https://dl.google.com/chrome/install/GoogleChromeStandaloneEnterprise64.msi"

                    ' Download the MSI installer
                    If Not IO.File.Exists(installerPath) Then
                        Using wc As New WebClient()
                            wc.DownloadFile(downloadUrl, installerPath)
                        End Using
                    End If

                    ' Install using msiexec
                    'Dim p As New Process()
                    'p.StartInfo.FileName = "cmd.exe"
                    'p.StartInfo.Arguments = "/c msiexec /i ""C:\temp\GoogleChromeStandaloneEnterprise64.msi"" /qn /norestart"
                    'p.StartInfo.CreateNoWindow = True
                    'p.StartInfo.UseShellExecute = False

                    'p.Start()
                    'p.WaitForExit()

                    'If p.ExitCode = 0 Then
                    '    MessageBox.Show("Chrome was installed successfully.")
                    'Else
                    '    MessageBox.Show("Chrome installation failed. Exit code: " & p.ExitCode)
                    'End If

                    ExecuteCMD("cmd /c C:\Temp\GoogleChromeStandaloneEnterprise64.msi")


                Catch ex As WebException
                    MessageBox.Show("Download error:  " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("General error: " & ex.Message)
                End Try

            End If


            '-------------------------------------------------------------------------------------------------------------------------------
            'Depletions---------------------------------------------------------------------------------------------------------------------
            If Me.CB_Depletions.Checked = True Then
                ExtractFromRAR("Directory", "Files\Common\temp\Depletions\", "C:\IRIS\Bin\HD Button\Depletions")
                MsgBox("Depletions installation completed!")

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'Fast Track---------------------------------------------------------------------------------------------------------------------
            If Me.CB_FastTrack.Checked = True Then
                'Download Fastrack file.exe from FTP site and execute it (had to use cmd coreFTP command due appears download methond not working for large files)
                ExecuteCMD("""c:\Program Files\CoreFTP\coreftp.exe"" -s -o -d ftp://bi_admin_ftp@starcorpus.net:nsd654159@starcorpus.net/Stores_Apps/FastTrackFiles/Fast_Track_PC_Software_Setup_2.27.exe -p C:\temp\")

                'execute Fastrack installer and wait for installation to be done
                Dim psi As New ProcessStartInfo()
                psi.FileName = "C:\temp\Fast_Track_PC_Software_Setup_2.27.exe"
                psi.UseShellExecute = True
                psi.Verb = "runas"

                Try
                    Dim proc As Process = Process.Start(psi)

                    If proc IsNot Nothing Then
                        proc.WaitForExit()   ' ⬅ This pauses your code until installer closes

                        'Download extra Fast track Files after installation
                        DownloadFromFTP("Stores_Apps/FastTrackFiles/CKERTD.bat", "C:\programdata\Fast Track Software Suite\CKERTD.bat")
                        DownloadFromFTP("Stores_Apps/FastTrackFiles/fttparam060420carls.spd", "C:\programdata\Fast Track Software Suite\fttparam060420carls.spd")
                        DownloadFromFTP("Stores_Apps/FastTrackFiles/fttparam070720hardees.spd", "C:\programdata\Fast Track Software Suite\fttparam070720hardees.spd")

                        MsgBox("Fast Track Installation Completed!, Note: the site and parameters set up needs to be done manually!")

                    End If

                Catch ex As Exception
                    MessageBox.Show("User cancelled UAC prompt.")
                End Try

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'DTIS---------------------------------------------------------------------------------------------------------------------------
            If Me.CB_DTIS.Checked = True Then
                'Download DTIS files from FTP site
                DownloadFromFTP("Stores_Apps/FastTrackFiles/DTIS_Setup_V2.4.exe", "C:\temp\DTIS_Setup_V2.4.exe")

                'execute Fastrack installer and wait for installation to be done
                Dim psi As New ProcessStartInfo()
                psi.FileName = "C:\temp\DTIS_Setup_V2.4.exe"
                psi.UseShellExecute = True
                psi.Verb = "runas"

                Try
                    Dim proc As Process = Process.Start(psi)

                    If proc IsNot Nothing Then
                        proc.WaitForExit()   ' ⬅ This pauses your code until installer closes

                        'download DTIS template file
                        DownloadFromFTP("Stores_Apps/FastTrackFiles/templates/DTIS2.xml", "C:\programdata\Fast Track Software Suite\templates\DTIS2.xml")

                        MsgBox("DTIS installation completed!, Note: the DTIS IP address and layout set up needs to be done manually")

                    End If

                Catch ex As Exception
                    MessageBox.Show("User cancelled UAC prompt.")
                End Try

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'FTTLog Windows Task------------------------------------------------------------------------------------------------------------
            If Me.CB_FTTLogTask.Checked = True Then
                'download xml taSK FILE
                DownloadFromFTP("Stores_Apps/FastTrackFiles/FTTLog.xml", "C:\temp\FTTLog.xml")

                'Delete task from Schedule if exists already
                ExecuteCMD("cmd /c schtasks /delete /tn " & "FTTLog" & " /f")
                'Update task registry
                ExecuteCMD("cmd /c schtasks /create /tn " & "FTTLog" & " /xml " & "C:\Temp\FTTLog.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")

                MsgBox("FTTLog Windows task has been registered Successfully!")

                ExecuteCMD("cmd /c powershell -Command() & ""Remove-Item " & " 'C:\temp\FTTLog.xml' -Recurse -Force" & "")

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'Start MSSQL$XSIRIS Service-----------------------------------------------------------------------------------------------------
            If Me.CB_Start_MSSQLXSIRIS_Service.Checked = True Then
                'extract xml taSK FILE
                ExtractFromRAR("File", "Files\Common\temp\Start_MSSQL$XSIRIS_Service.xml", "C:\temp")

                'Delete task from Schedule if exists already
                ExecuteCMD("cmd /c schtasks /delete /tn " & "Start MSSQL$XSIRIS Service" & " /f")
                'Update task registry
                ExecuteCMD("cmd /c schtasks /create /tn " & "Start MSSQL$XSIRIS Service" & " /xml " & "C:\Temp\Start_MSSQL$XSIRIS_Service.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")

                MsgBox("Start MSSQL$XSIRIS Service Windows task has been registered Successfully!")

                ExecuteCMD("cmd /c powershell -Command() & ""Remove-Item " & " 'C:\temp\Start_MSSQL$XSIRIS_Service.xml' -Recurse -Force" & "")

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'R365 Starcorp/Carl's Jr Version Install----------------------------------------------------------------------------------------
            If Me.CB_R365_SC.Checked = True Then
                'Download R365 SC exe
                DownloadFromFTP("/Stores_Apps/R365/SC/ComidaGP.PRO.26.6.0.102.zip", "C:\temp\ComidaGP.PRO.26.6.0.102.zip")

                ''Install R365 SS version acording store number in the R365SS csv resource file
                Dim R365SCKey As String = "password"

                Dim SN As DataTable = GetTableDataFromServer("select storenum from iris.dbo.tblStoreInfo")
                Dim Found As Integer = 0

                ' Convert the byte resource to a string
                Dim csvBytes As Byte() = My.Resources.R365SC
                Dim csvContent As String = System.Text.Encoding.UTF8.GetString(csvBytes)

                ' Split the CSV content into rows
                Dim rows As String() = csvContent.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                ' Define the word to search for
                Dim searchWord As String = SN.Rows(0)(0).ToString

                ' Initialize variables to store the results
                'Dim secondColumnValue As String = String.Empty
                'Dim thirdColumnValue As String = String.Empty

                ' Loop through each row to find the search word
                For Each row As String In rows
                    ' Split the row into columns (assuming a comma delimiter)
                    Dim columns As String() = row.Split(","c)

                    ' Check if the Third column contains the search word if there is 3 columns or more
                    If columns.Length >= 3 AndAlso columns(2).Trim() = searchWord Then
                        Found = 1
                        ' Retrieve the second column values
                        R365SCKey = columns(1).Trim()

                        ' Exit the loop since we only need the matching row
                        Exit For

                    End If
                Next

                If Found = 0 Then '0=not found, 1= found
                    MsgBox("Store Number '" & searchWord.ToString & "'  Not Found!")
                Else
                    'create patch if not exist C:\R365
                    If Not Directory.Exists("C:\R365") Then
                        Directory.CreateDirectory("C:\R365")
                    End If

                    'Extract R365 SC rar file into C:\R365 folder
                    ZipFile.ExtractToDirectory("C:\temp\ComidaGP.PRO.26.6.0.102.zip", "C:\R365")

                    'Set 'SetupConfig.br' file with the correct store number and key
                    Dim fileName As String = "R365"
                    Dim extension As String = ".bat"   ' any extension you want
                    Dim folderPath As String = "C:\R365"

                    Dim fullPath As String = Path.Combine(folderPath, fileName & extension)
                    Dim fileContent As String = "C:\R365\ComidaGP.exe -r -s ""starcorpvalley,Xpient," & R365SCKey & "," & SN.Rows(0)(0).ToString & ",,,,3/31/2022 7:00:00 AM,True,IRIS-SERVER\XSIRIS,IRIS,False,False,False,False,False,,,,False,,False,False,False,False,False,False,False,False,False,False,False"

                    File.WriteAllText(fullPath, fileContent)

                    'Delete task from Schedule if exists already
                    ExecuteCMD("cmd /c schtasks /delete /tn " & "R365 Import" & " /f")
                    'register R365 windows task               
                    ExecuteCMD("cmd /c schtasks /create /tn ""R365 Import"" /st 00:05 /du 0023:50 /k /tr ""C:\R365\R365.bat"" /sc daily /ri 15 /ru iris_admin /rp STCOXp13nt@dmin /RL HIGHEST")

                    MsgBox("R365 Hardees Version Installed Successfully!")
                End If

            End If
            '-------------------------------------------------------------------------------------------------------------------------------
            'R365 superiorstar/Hardees version Install--------------------------------------------------------------------------------------
            If Me.CB_R365_SS.Checked = True Then
                'Download R365 SS exe
                DownloadFromFTP("/Stores_Apps/R365/SS/ComidaInstaller24.50.0.exe", "C:\temp\ComidaInstaller24.50.0.exe")
                'DownloadFromFTP("/Stores_Apps/R365/SS/R365Import.xml", "C:\temp\R365Import.xml")

                ''Install R365 SS version acording store number in the R365SS csv resource file
                Dim R365SSKey As String = "password"

                Dim SN As DataTable = GetTableDataFromServer("select storenum from iris.dbo.tblStoreInfo")
                Dim Found As Integer = 0

                ' Convert the byte resource to a string
                Dim csvBytes As Byte() = My.Resources.R365SS
                Dim csvContent As String = System.Text.Encoding.UTF8.GetString(csvBytes)

                ' Split the CSV content into rows
                Dim rows As String() = csvContent.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                ' Define the word to search for
                Dim searchWord As String = SN.Rows(0)(0).ToString

                ' Initialize variables to store the results
                'Dim secondColumnValue As String = String.Empty
                'Dim thirdColumnValue As String = String.Empty

                ' Loop through each row to find the search word
                For Each row As String In rows
                    ' Split the row into columns (assuming a comma delimiter)
                    Dim columns As String() = row.Split(","c)

                    ' Check if the Third column contains the search word if there is 3 columns or more
                    If columns.Length >= 3 AndAlso columns(2).Trim() = searchWord Then
                        Found = 1
                        ' Retrieve the second column values
                        R365SSKey = columns(1).Trim()

                        ' Exit the loop since we only need the matching row
                        Exit For

                    End If
                Next

                If Found = 0 Then '0=not found, 1= found
                    MsgBox("Store Number '" & searchWord.ToString & "'  Not Found!")
                Else
                    'create patch if not exist C:\R365
                    If Not Directory.Exists("C:\R365") Then
                        Directory.CreateDirectory("C:\R365")
                    End If

                    'Execute R365 installer
                    Dim psi As New ProcessStartInfo()
                    psi.FileName = "C:\temp\ComidaInstaller24.50.0.exe"
                    psi.UseShellExecute = True
                    psi.Verb = "runas"

                    Try
                        Dim proc As Process = Process.Start(psi)

                        If proc IsNot Nothing Then
                            proc.WaitForExit()   ' ⬅ This pauses your code until installer closes
                        End If

                    Catch ex As Exception
                        MessageBox.Show("User cancelled UAC prompt.")
                    End Try

                    'Set 'SetupConfig.br' file with the correct store number and key
                    Dim fileName As String = "SetupConfig"
                    Dim extension As String = ".br"   ' any extension you want
                    Dim folderPath As String = "C:\R365"

                    Dim fullPath As String = Path.Combine(folderPath, fileName & extension)
                    Dim fileContent As String = "superiorstar,Xpient," & R365SSKey & "," & SN.Rows(0)(0).ToString & ",,,,8/18/2023 12:00:00 AM,True,.\XSIRIS,IRIS,False,False,False,False,False,,,,False,,False,False,False,False,False,False,False,False,False,False,False#$%#{""IsSplitTaxExemptCategories"":""True""}"
                    File.WriteAllText(fullPath, fileContent)

                    'Delete task from Schedule if exists already
                    ExecuteCMD("cmd /c schtasks /delete /tn " & "R365 Import" & " /f")
                    'register R365 windows task               
                    ExecuteCMD("cmd /c Schtasks /create /tn ""R365 Import"" /tr ""C:\R365\ComidaGP.exe run"" /sc daily /st 05:05 /ri 15 /du 24:00 /ru iris_admin /rp STCOXp13nt@dmin /RL HIGHEST")

                    MsgBox("R365 Hardees Version Installed Successfully!")
                End If

            End If

        Catch ex As Exception
            Me.Button1.Enabled = True
            MsgBox(ex.ToString)
        End Try
        Me.Button1.Enabled = True

    End Sub


    Private Sub Installs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RadioButton1.Checked = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.RadioButton1.BackColor = Color.LightBlue
        Me.RBUpdatesCarls.BackColor = DefaultBackColor
        Me.RBUpdatesHardees.BackColor = DefaultBackColor
    End Sub

    Private Sub RBUpdatesHardees_CheckedChanged(sender As Object, e As EventArgs) Handles RBUpdatesHardees.CheckedChanged
        Me.RBUpdatesHardees.BackColor = Color.LightBlue
        Me.RadioButton1.BackColor = DefaultBackColor
        Me.RBUpdatesCarls.BackColor = DefaultBackColor
    End Sub

    Private Sub RBUpdatesCarls_CheckedChanged(sender As Object, e As EventArgs) Handles RBUpdatesCarls.CheckedChanged
        Me.RBUpdatesCarls.BackColor = Color.LightBlue
        Me.RBUpdatesHardees.BackColor = DefaultBackColor
        Me.RadioButton1.BackColor = DefaultBackColor
    End Sub

End Class