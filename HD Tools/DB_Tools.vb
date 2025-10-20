Imports System.Data.SqlClient
Imports SharpCompress.Common
Imports SharpCompress.Archives
Imports System.IO
Imports Amazon.Auth.AccessControlPolicy
Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Net
Imports System.Net.Http
Imports System.Net.Mail
Imports Microsoft.Win32
Imports SharpCompress.Compressors.Rar.UnpackV1
Imports System.Security.Cryptography
Imports System.Diagnostics.Eventing
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json.Linq

Public Class DB_Tools

    Public Const updateUrl As String = "https://github.com/AxelLopez07/HD-Button/blob/master/HD%20Tools/Resources/version.txt"
    Public Const downloadUrl As String = "https://github.com/username/MyApp/releases/latest/download/MyAppInstaller.exe"

    'Check for updates method
    Public Shared Sub CheckForUpdates()
        Try
            'Dim client As New WebClient()
            Dim client As New HttpClient
            'Dim latestVersion As String = client.DownloadString(updateUrl).Trim()
            Dim latestVersionByte As Byte() = client.GetByteArrayAsync(updateUrl).Result
            ' Convert bytes to string (UTF-8 is the most common)
            Dim latestVersion As String = Encoding.UTF8.GetString(latestVersionByte)
            'Dim currentVersion As String = Application.ProductVersion ' Or use My.Application.Info.Version.ToString()
            Dim currentVersion As String = MainMenu.LabelVer.Text.ToString.Trim() ' Or use My.Application.Info.Version.ToString()

            MsgBox("" & latestVersion & " - " & currentVersion & "")

            If IsNewerVersion(latestVersion, currentVersion) Then
                Dim result = MessageBox.Show(
                    $"A new version ({latestVersion}) is available. You have {currentVersion}. Update now?",
                    "Update Available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    'DownloadAndUpdate()
                    MsgBox("Updating...")
                End If
            Else
                MsgBox("You have the latest version.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            ' Optional: Log or ignore update errors silently
        End Try
    End Sub
    Public Shared Function IsNewerVersion(latest As String, current As String) As Boolean
        Return New Version(latest) > New Version(current)
    End Function
    Public Sub DownloadAndUpdate()
        Dim tempPath As String = IO.Path.Combine(IO.Path.GetTempPath(), "MyAppInstaller.exe")
        Dim client As New WebClient()
        client.DownloadFile(downloadUrl, tempPath)
        Process.Start(tempPath)
        Application.Exit()
    End Sub

    Public Shared Function GetConnectionString() As String
        Return $"Data Source=IRIS-SERVER\XSIRIS;Initial Catalog=iris;Integrated Security=True"
        'Return $"Data Source=localhost\SQLEXPRESS01;Initial Catalog=iris;Integrated Security=True"
    End Function
    ' CMD to server
    Public Shared Function ExecuteCmdToServer(VarString As String) As Boolean
        Dim ServerConnection As New SqlConnection(GetConnectionString())
        Try
            Dim mycmd As New SqlCommand(VarString, ServerConnection)
            ServerConnection.Open()
            mycmd.ExecuteNonQuery()
            ServerConnection.Close()
        Catch ex As Exception
            ServerConnection.Close()
            MsgBox("Error!")
            MsgBox(ex.ToString)
            Return False
        End Try
        Return True
    End Function
    'Get Databale data
    Public Shared Function GetTableDataFromServer(cmdText As String) As DataTable
        Dim table As New DataTable
        Try
            Using con As New SqlConnection(GetConnectionString()),
            CMD As New SqlCommand(cmdText, con)
                con.Open()
                Using reader = CMD.ExecuteReader
                    table.Load(reader)
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    'fill combobox
    Public Shared Sub Fill_ComboBox(Used_ComboBox As ComboBox, SQLQuery As String)
        Using connection As New SqlConnection(GetConnectionString)
            Dim command As New SqlCommand(SQLQuery, connection)
            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader
                While reader.Read
                    Used_ComboBox.Items.Add(reader("FullName").ToString)
                End While
                reader.Close()

            Catch ex As Exception
                connection.Close()
                MsgBox(ex.ToString)
            End Try

            connection.Close()

        End Using
    End Sub
    '-----------------Execute Shell (cmd) process and wait for finsih before proceed
    Public Shared Sub ExecuteCMD(CMDLine As String)
        Dim processID = Shell(CMDLine, 0)
        Dim p As Process = Process.GetProcessById(processID)
        p.WaitForExit()
    End Sub
    'fill SCADevice info
    Public Shared Sub FillSCADInfo()
        Try
            'filepaths list
            Dim filePath As New List(Of String)()
            filePath.Add("C:\IRIS\RegInfo\Reg1\Ini\IrisAuthSrvr.ini")
            filePath.Add("C:\IRIS\RegInfo\Reg2\Ini\IrisAuthSrvr.ini")
            filePath.Add("C:\IRIS\RegInfo\Reg4\Ini\IrisAuthSrvr.ini")
            filePath.Add("C:\IRIS\RegInfo\Reg5\Ini\IrisAuthSrvr.ini")


            'search text list
            Dim searchText As New List(Of String)()
            searchText.Add("[scadevice1]")
            searchText.Add("[scadevice2]")
            searchText.Add("[scadevice4]")
            searchText.Add("[scadevice5]")

            'pin pad label
            Dim PPL As Control = Nothing

            For I As Integer = 0 To 3
                Dim lineNumber As Integer = 0
                Dim line As String = Nothing
                Dim nextLine As String = Nothing

                Select Case I
                    Case 0
                        PPL = PinPads.LPP1_IP
                    Case 1
                        PPL = PinPads.LPP2_IP
                    Case 2
                        PPL = PinPads.LPP4_IP
                    Case 3
                        PPL = PinPads.LPP5_IP

                End Select

                If File.Exists(filePath(I).ToString) Then
                    Using reader As New StreamReader(filePath(I))

                        While Not reader.EndOfStream
                            lineNumber += 1
                            line = reader.ReadLine()

                            If line.Contains(searchText(I)) Then
                                ' If the search text is found, retrieve the line below it
                                nextLine = reader.ReadLine()
                                If nextLine IsNot Nothing Then
                                    'MsgBox("Found at line " & lineNumber & ": " & line)
                                    'MsgBox("Line below: " & nextLine)

                                    PPL.Text = nextLine.ToString
                                    'hostNameOrAddress = nextLine.Substring(5, 13).ToString
                                Else
                                    'MsgBox("Found at line " & lineNumber & ": " & line)
                                    'MsgBox("No line below.")
                                    PPL.Text = "Not Found"

                                    If reader.EndOfStream AndAlso Not line.Contains(searchText(I)) Then
                                        PPL.Text = "Not Found"
                                    End If

                                End If
                                Exit While ' Exit the loop if the text is found
                            End If
                        End While
                    End Using
                Else
                    PPL.Text = "Not Found"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Fill TID
    Public Shared Sub FillSCADInfoTID()
        Try
            'filepaths list
            Dim filePath As New List(Of String)()
            filePath.Add("\\192.168.1.101\iris\Log\IrisAuthSrvr.log")
            filePath.Add("\\192.168.1.102\iris\Log\IrisAuthSrvr.log")
            filePath.Add("\\192.168.1.104\iris\Log\IrisAuthSrvr.log")
            filePath.Add("\\192.168.1.105\iris\Log\IrisAuthSrvr.log")

            'search text list
            Dim searchText As New List(Of String)()
            searchText.Add("<DeviceId>")
            searchText.Add("<DeviceId>")
            searchText.Add("<DeviceId>")
            searchText.Add("<DeviceId>")


            'pin pad label
            Dim PPL As Control = Nothing

            For I As Integer = 0 To 3
                'Dim lineNumber As Integer = 0
                'Dim line As String = Nothing
                Dim nextLine As String = Nothing

                Select Case I
                    Case 0
                        PPL = PinPads.LTID1
                    Case 1
                        PPL = PinPads.LTID2
                    Case 2
                        PPL = PinPads.LTID4
                    Case 3
                        PPL = PinPads.LTID5
                End Select

                If File.Exists(filePath(I).ToString) Then

                    ' Read all lines into an array
                    Dim allLines() As String = File.ReadAllLines(filePath(I))
                    ' Iterate over the lines in reverse order

                    ' Iterate over the lines in reverse order
                    For O As Integer = allLines.Length - 1 To 0 Step -1
                        Dim line As String = allLines(O)

                        ' Search for the text in the current line
                        Dim index As Integer = line.LastIndexOf(searchText(I)) ' Use LastIndexOf to search from the end

                        If index <> -1 Then
                            ' Found the search text, get the next 8 characters after the search text
                            Dim startIndex As Integer = index + searchText(I).Length
                            Dim remainingChars As Integer = line.Length - startIndex
                            Dim nextChars As String

                            If remainingChars >= 8 Then
                                nextChars = line.Substring(startIndex, 8) ' Get 8 characters
                                PPL.Text = nextChars
                            Else
                                nextChars = line.Substring(startIndex, remainingChars) ' Get remaining characters if less than 8
                                PPL.Text = "Not Found"
                            End If


                            Exit For ' Exit after the first match is found
                        End If
                    Next

                    ''''''''''''''''''''''''''''''''''''
                    'Using reader As New StreamReader(filePath(I))

                    '    While Not reader.EndOfStream
                    '        'lineNumber += 1
                    '        line = reader.ReadLine()

                    '        Dim index As Integer = line.IndexOf(searchText(I))
                    '        If index <> -1 Then
                    '            ' Found the search text, get the next 8 characters after the search text
                    '            Dim startIndex As Integer = index + searchText(I).Length
                    '            Dim remainingChars As Integer = line.Length - startIndex
                    '            Dim nextChars As String

                    '            If remainingChars >= 8 Then
                    '                nextChars = line.Substring(startIndex, 8) ' Get 8 characters
                    '                PPL.Text = nextChars
                    '            Else
                    '                nextChars = line.Substring(startIndex, remainingChars) ' Get remaining characters if less than 8
                    '                PPL.Text = "Not Found"
                    '            End If


                    '            Exit While ' Exit the loop after finding the text
                    '        End If

                    '    End While
                    'End Using

                Else
                    PPL.Text = "Not Found"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    '--------------Ping SCADevice method1
    Public Shared Sub Ping_Device1()
        Try
            Dim hostNameOrAddress As String = "Nothing"
            Dim pingSender As New Ping()
            Dim options As New PingOptions()
            Dim reply As PingReply
            Dim SCADID As String = Nothing
            Dim LabelStatus As Control = Nothing

            'Dim successCount As Integer = 0
            Dim successCount As New List(Of Integer)
            successCount.Add(0)
            successCount.Add(0)
            successCount.Add(0)
            successCount.Add(0)

            'Dim failCount As Integer = 0
            Dim failCount As List(Of Integer) = Nothing
            failCount.Add(0)
            failCount.Add(0)
            failCount.Add(0)
            failCount.Add(0)

            Dim totalPings As List(Of Integer) = Nothing
            totalPings.Add(0)
            totalPings.Add(0)
            totalPings.Add(0)
            totalPings.Add(0)

            Dim lossPercentage As List(Of Double) = Nothing
            lossPercentage.Add(0)
            lossPercentage.Add(0)
            lossPercentage.Add(0)
            lossPercentage.Add(0)

            For I As Integer = 0 To 3
                Select Case I
                    Case 0
                        SCADID = PinPads.LPP1_IP.Text.ToString
                        LabelStatus = PinPads.LPSCAD1
                    Case 1
                        SCADID = PinPads.LPP2_IP.Text.ToString
                        LabelStatus = PinPads.LPSCAD2
                    Case 2
                        SCADID = PinPads.LPP4_IP.Text.ToString
                        LabelStatus = PinPads.LPSCAD4
                    Case 3
                        SCADID = PinPads.LPP5_IP.Text.ToString
                        LabelStatus = PinPads.LPSCAD5
                End Select

                'ping trace
                If SCADID.Length >= 18 Then
                    hostNameOrAddress = SCADID.Substring(5, 13).ToString
                    options.DontFragment = True
                    reply = pingSender.Send(hostNameOrAddress, 1000, New Byte() {1, 2, 3, 4}, options)

                    If reply.Status = IPStatus.Success Then
                        'Console.WriteLine($"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}")
                        successCount(I) += 1
                    Else
                        'Console.WriteLine($"Request timed out.")
                        failCount(I) += 1
                    End If

                    totalPings(I) = successCount(I) + failCount(I)
                    lossPercentage(I) = (failCount(I) / totalPings(I)) * 100
                    LabelStatus.Text = $"loss rate:" & lossPercentage(I).ToString & "% received packets:" & successCount(I).ToString & ""

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    '-----------fill Menu Mims data grid view
    Public Shared Sub FillMIMsDataGrid(MenuID As Integer, DG As DataGridView)
        Try
            Dim dt As DataTable = GetTableDataFromServer($"select MenuID,Text,BtnValue,ItemNum,ItemDescription,ExternalItemNum2,ClientRouting from iris.dbo.tbl_MenuBtns left join iris.dbo.tblItemMapping on iris.dbo.tblItemMapping.ItemNum=iris.dbo.tbl_MenuBtns.BtnValue where MenuID='" & MenuID & "' and BtnType=0 and BtnValue<>0 order by ItemNum asc")
            DG.DataSource = dt.DefaultView
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    '--- Synchronous Extract Specific file from RAR resource file
    Public Shared Sub ExtractFromRAR(ExtractOut As String, DirectoryOrFileName As String, Output As String)
        ' Load the RAR file from resources
        Dim rarFileBytes() As Byte = My.Resources.Files
        Dim rarFilePath As String = Path.Combine(Path.GetTempPath(), "temp.rar")

        ' Write the RAR file to a temporary location
        File.WriteAllBytes(rarFilePath, rarFileBytes)

        Select Case ExtractOut
            Case "File"
                '----------Extract just one speficif file

                ' Specify the exact path of the file you want to extract within the RAR archive
                Dim filePathToExtract As String = DirectoryOrFileName.ToString
                Dim outputFilePath As String = Path.Combine(Output.ToString, Path.GetFileName(filePathToExtract))

                ' Extract the specific file
                Using archive As IArchive = ArchiveFactory.Open(rarFilePath)
                    For Each entry In archive.Entries
                        If Not entry.IsDirectory AndAlso entry.Key.Equals(filePathToExtract, StringComparison.OrdinalIgnoreCase) Then
                            entry.WriteToFile(outputFilePath)
                            'Console.WriteLine("File extracted successfully to " & outputFilePath)
                            Exit For
                        End If
                    Next
                End Using

                ' Clean up the temporary RAR file
                File.Delete(rarFilePath)

            Case "Directory"
                '----------Extract whole specific folder directory

                ' Specify the directory you want to extract from within the RAR archive
                Dim directoryToExtract As String = DirectoryOrFileName.ToString
                Dim outputDirectory As String = Output.ToString

                ' Extract the specific directory
                Using archive As IArchive = ArchiveFactory.Open(rarFilePath)
                    For Each entry In archive.Entries
                        If Not entry.IsDirectory AndAlso entry.Key.StartsWith(directoryToExtract, StringComparison.OrdinalIgnoreCase) Then
                            ' Create the full output path
                            Dim relativePath As String = entry.Key.Substring(directoryToExtract.Length)
                            Dim fullOutputPath As String = Path.Combine(outputDirectory, relativePath)

                            ' Ensure the directory exists
                            Directory.CreateDirectory(Path.GetDirectoryName(fullOutputPath))

                            ' Extract the file
                            entry.WriteToFile(fullOutputPath)
                            'Console.WriteLine("Extracted: " & fullOutputPath)
                            'Else
                            ' MsgBox("file not found")
                        End If
                    Next
                End Using

                ' Clean up the temporary RAR file
                File.Delete(rarFilePath)

            Case Else
                MsgBox("No File or Directory specified, please check the extract command line")

        End Select





    End Sub
    'Scan CC log files for a possible offline transaction
    Public Shared Sub Scan_CC_log()
        Try
            Dim filePath As String = Nothing
            Dim searchText As String = "Added transaction to SAF File"
            Dim Register As New List(Of String)()
            Dim RegisterLogFound As New List(Of String)()
            Dim StoreNumber As DataTable = GetTableDataFromServer("select storenum from iris.dbo.tblStoreInfo")

            'add registers to list
            Register.Add("1")
            Register.Add("2")
            Register.Add("4")
            Register.Add("5")

            For I As Integer = 0 To 3
                'MsgBox("Scanning \\192.168.1.10" & Register(I) & "\iris\log\IrisAuthSrvr.log")
                filePath = "\\192.168.1.10" & Register(I) & "\iris\log\IrisAuthSrvr.log"

                Dim lineNumber As Integer = 0
                Dim line As String = Nothing
                'Dim nextLine As String = Nothing

                If File.Exists(filePath) Then
                    Using reader As New StreamReader(filePath)

                        While Not reader.EndOfStream
                            lineNumber += 1
                            line = reader.ReadLine()

                            If line.Contains(searchText) Then
                                RegisterLogFound.Add(Register(I).ToString)

                                Exit While ' Exit the loop if the text is found
                            End If
                        End While
                    End Using
                End If
            Next

            Dim RegistersFound As String = String.Join(", ", RegisterLogFound)

            If RegisterLogFound.Count <> 0 Then
                ' If the search text is found
                ' Create a new MailMessage object
                Dim mail As New MailMessage()

                ' Set the sender's address
                mail.From = New MailAddress("testemail@starcorprestaurants.com")

                ' Set the recipient's address
                mail.To.Add("alopez@starcorpus.com")

                ' Set the subject
                mail.Subject = "Offline transactions detected " & StoreNumber.Rows(0)(0).ToString()

                ' Set the body
                mail.Body = "* Location:" & StoreNumber.Rows(0)(0).ToString() & " * Register(s):" & RegistersFound.ToString

                ' Create a new SmtpClient object
                Dim smtp As New SmtpClient("mail.noip.com")

                ' Set the SMTP server credentials
                smtp.Credentials = New NetworkCredential("testemail@starcorprestaurants.com", "12345")

                ' Enable SSL (depending on your SMTP server requirements)
                smtp.EnableSsl = False

                ' Set the timeout (e.g., 30 seconds)
                smtp.Timeout = 100000 ' Timeout in milliseconds (30000 ms = 30 seconds)

                ' Send the email
                smtp.Send(mail)

                MsgBox("Found")
            Else
                MsgBox("not found")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub





    ' Store tokens in memory (or securely in a file/database)
    Public AccessToken As String = ""
    Public RefreshToken As String = ""

    ' Your Azure App Details
    Private ReadOnly ClientId As String = "cd526d4f-d677-4247-a98c-d610b937569b"
    Private ReadOnly ClientSecret As String = "sjF8Q~uIra8FVDHce5PikWWUl15xkaiUutIyRcMa"
    Private ReadOnly TenantId As String = "91b1024c-8218-47d0-a189-ccc39d83732a"
    Private ReadOnly RedirectUri As String = "http://localhost"

    ' 🔹 Step 1: Get Access Token using Authorization Code
    Public Function GetAccessToken(authCode As String) As Boolean
        Dim url As String = "https://login.microsoftonline.com/" & TenantId & "/oauth2/v2.0/token"
        Dim postData As String = "grant_type=authorization_code&client_id=" & ClientId &
                                 "&client_secret=" & ClientSecret &
                                 "&code=" & authCode &
                                 "&redirect_uri=" & RedirectUri &
                                 "&scope=https%3A%2F%2Fgraph.microsoft.com%2F.default"

        Dim jsonResponse As String = SendPostRequest(url, postData)
        If jsonResponse.Contains("access_token") Then
            Dim json As JObject = JObject.Parse(jsonResponse)
            AccessToken = json("access_token").ToString()
            RefreshToken = json("refresh_token").ToString()
            Return True
        Else
            MsgBox("Error getting Access Token: " & jsonResponse)
            Return False
        End If
    End Function

    ' 🔹 Step 2: Refresh Access Token when expired
    Public Function RefreshAccessToken() As Boolean
        Dim url As String = "https://login.microsoftonline.com/" & TenantId & "/oauth2/v2.0/token"
        Dim postData As String = "grant_type=refresh_token&client_id=" & ClientId &
                                 "&client_secret=" & ClientSecret &
                                 "&refresh_token=" & RefreshToken &
                                 "&scope=https%3A%2F%2Fgraph.microsoft.com%2F.default"

        Dim jsonResponse As String = SendPostRequest(url, postData)
        If jsonResponse.Contains("access_token") Then
            Dim json As JObject = JObject.Parse(jsonResponse)
            AccessToken = json("access_token").ToString()
            RefreshToken = json("refresh_token").ToString()
            Return True
        Else
            MsgBox("Error refreshing Access Token: " & jsonResponse)
            Return False
        End If
    End Function

    ' 🔹 Helper function to send POST requests
    Private Function SendPostRequest(url As String, postData As String) As String
        Try
            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length

            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using

            Dim response As WebResponse = request.GetResponse()
            Dim responseStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(responseStream)
            Dim responseText As String = reader.ReadToEnd()

            reader.Close()
            responseStream.Close()
            response.Close()

            Return responseText
        Catch ex As WebException
            Dim errorResponse As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            Return "Error: " & errorResponse
        End Try
    End Function


End Class
