Imports System.IO
Imports HD_Button.DB_Tools
Imports Microsoft.SqlServer
Imports Microsoft.VisualBasic.FileIO
Imports MongoDB.Driver.Search
Imports System.Threading
Imports SharpCompress.Archives
Imports SharpCompress.Readers
Imports System.Runtime.CompilerServices
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
    'change Store Number
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Button1.Enabled = False

            'CARL'S jr's
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

            'HARDEES
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

            'OLO
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
                        'extract OLO installer 
                        ExtractFromRAR("File", "Files\Common\xpient\OLOw7.exe", "C:\xpient")

                        'Install OLO command
                        ExecuteCMD("cmd /c C:\xpient\OLOw7.exe –IIS –POI –olocode " & OLOUserName.ToString & " –olopw " & OLOPassword.ToString & "")
                        MsgBox("OLO Installation Complete!")
                    End If

                End If
            End If

            'Loyalty (XLC)
            If Me.CB_Loyalty.Checked = True Then

                If Directory.Exists("C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller") Then
                    MsgBox("Loyalty folder found!, need to uninstall XLC and delete XLC folder and files (C:\Program Files (x86)\xpient Solutions\XPIENT Loyalty Controller) before install XLC again")
                Else
                    'extract XLC installation files and execute
                    ExtractFromRAR("Directory", "Files\Common\temp\XLC\", "C:\temp\XLC")
                    ExecuteCMD("cmd /c C:\Temp\XLCInstall.bat")
                    MsgBox("XLC installation complete!")
                End If

            End If

            'Xenial Sync Service
            If Me.CB_XenialSync.Checked = True Then
                'extract and Execute Xenial Sync Files
                ExtractFromRAR("File", "Files\Common\xpient\XenialSync\InstallXenialSync.exe", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpient\InstallXenialSync.exe")
                MsgBox("XenyalSync service installation completed!")
            End If

            'WinSCP
            If Me.CB_WinSCP.Checked = True Then
                'Extract and Execute WinSCP
                ExtractFromRAR("File", "Files\Common\xpient\WinSCP-5.21.8-Setup.exe", "C:\xpient")
                ExecuteCMD("cmd /c C:\xpien\WinSCP-5.21.8-Setup.exe")
                MsgBox("WinSCP installation completed!")
            End If

            'Google Chrome Installation
            If Me.CB_GC.Checked = True Then
                ExecuteCMD("cmd /c powershell -Command " & "Start-Process -FilePath " & "$env:TEMP\chrome_installer.exe" & " -ArgumentList '/silent', '/install' -Wait")
                MsgBox("Google Chrome installation completed!")
            End If

            'Depletions
            If Me.CB_Depletions.Checked = True Then
                ExtractFromRAR("Directory", "Files\Common\temp\Depletions\", "C:\IRIS\Bin\HD Button\Depletions")
                MsgBox("Depletions installation completed!")
            End If

            'Fast Track
            If Me.CB_FastTrack.Checked = True Then
                'UnrarResourceFile(My.Resources.Fast_Track_PC_Software_Setup_2_27, "C:\temp") and execute/install
                ExtractFromRAR("File", "Files\Common\temp\Fast_Track_PC_Software_Setup_2.27.exe", "C:\temp")
                ExecuteCMD("cmd /c C:\temp\Fast_Track_PC_Software_Setup_2.27.exe")

                'Extract Fast track Files
                ExtractFromRAR("Directory", "Files\Common\temp\FastTrackFiles\", "C:\programdata\Fast Track Software Suite")

                MsgBox("Fast Track Installation Completed!, Note: the site and parameters set up needs to be done manually!")
            End If

            'DTIS
            If Me.CB_DTIS.Checked = True Then
                ' UnrarResourceFile(My.Resources.DTIS_Setup_V2_4, "C:\temp")
                ExtractFromRAR("File", "Files\Common\temp\DTIS_Setup_V2.4.exe", "C:\temp")

                ExecuteCMD("cmd /c C:\temp\DTIS_Setup_V2.4.exe")
                MsgBox("DTIS installation completed!, Note the DTIS IP address and layout set up needs to be done manually")
            End If

            'FTTLog Windows Task
            If Me.CB_FTTLogTask.Checked = True Then
                'extract xml taSK FILE
                ExtractFromRAR("File", "Files\Common\temp\FastTrackFiles\FTTLog.xml", "C:\temp")

                'Delete task from Schedule if exists already
                ExecuteCMD("cmd /c schtasks /delete /tn " & "FTTLog" & " /f")
                'Update task registry
                ExecuteCMD("cmd /c schtasks /create /tn " & "FTTLog" & " /xml " & "C:\Temp\FTTLog.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")

                MsgBox("FTTLog Windows task has been registered Successfully!")

                ExecuteCMD("cmd /c powershell -Command() & ""Remove-Item " & " 'C:\temp\FTTLog.xml' -Recurse -Force" & "")

            End If

            'Start MSSQL$XSIRIS Service
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