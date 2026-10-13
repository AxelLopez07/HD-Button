Imports System.IO
Imports System.Net

Module Module_FTP_Transfers

    'FTP server details
    Dim ftpHost As String = "ftp://starcorpus.net/"
    Dim ftpUser As String = "bi_admin_ftp@starcorpus.net"
    Dim ftpPass As String = "nsd654159"

    'Method: Download a single file from FTP server
    Public Sub downloadSingleFileFromFTP(FTP_Path As String, LocalPath As String)
        Try
            'declare full FTP path
            Dim FTP_Full_Path As String = ftpHost & FTP_Path
            'download parameters
            Dim request As FtpWebRequest = CType(WebRequest.Create(FTP_Full_Path), FtpWebRequest)
            request.Method = WebRequestMethods.Ftp.DownloadFile
            request.Credentials = New NetworkCredential(ftpUser, ftpPass)
            request.UseBinary = True
            request.UsePassive = True   ' VERY important
            request.KeepAlive = False
            'request.EnableSsl = True
            request.Timeout = 600000
            request.ReadWriteTimeout = 600000

            'download file
            Using response As FtpWebResponse = CType(request.GetResponse(), FtpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    Using fs As New FileStream(LocalPath, FileMode.Create)
                        responseStream.CopyTo(fs)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error in downloading File: " & FTP_Path & ex.ToString)
        End Try
    End Sub

    'Method: download a folder from FTP server
    Public Sub downloadFolderFromFTP(FTP_Path As String, LocalPath As String)
        Try
            'declare full FTP path
            Dim FTP_Full_Path As String = ftpHost & FTP_Path
            ' Make sure the local folder exists
            If Not Directory.Exists(LocalPath) Then
                Directory.CreateDirectory(LocalPath)
            End If
            ' Get directory listing
            Dim request As FtpWebRequest =
                        CType(WebRequest.Create(FTP_Full_Path), FtpWebRequest)

            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential(ftpUser, ftpPass)
            request.UseBinary = True
            request.UsePassive = True
            request.KeepAlive = False
            request.Timeout = 600000
            request.ReadWriteTimeout = 600000

            Dim files As New List(Of String)

            Using response As FtpWebResponse =
                        CType(request.GetResponse(), FtpWebResponse)

                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream)

                        While Not reader.EndOfStream
                            Dim fileName As String = reader.ReadLine()

                            If Not String.IsNullOrWhiteSpace(fileName) Then
                                files.Add(fileName)
                            End If
                        End While
                    End Using
                End Using
            End Using

            ' Download every file
            For Each fileName As String In files

                Try
                    Dim FTPFilePath As String = ftpHost &
                                                        FTP_Path.TrimEnd("/"c) &
                                                        "/" &
                                                        fileName

                    Dim LocalFilePath As String =
                                Path.Combine(LocalPath, fileName)

                    Dim downloadRequest As FtpWebRequest =
                                CType(WebRequest.Create(FTPFilePath), FtpWebRequest)

                    downloadRequest.Method =
                                WebRequestMethods.Ftp.DownloadFile

                    downloadRequest.Credentials =
                                New NetworkCredential(ftpUser, ftpPass)

                    downloadRequest.UseBinary = True
                    downloadRequest.UsePassive = True
                    downloadRequest.KeepAlive = False
                    downloadRequest.Timeout = 600000
                    downloadRequest.ReadWriteTimeout = 600000

                    Using response As FtpWebResponse =
                                CType(downloadRequest.GetResponse(), FtpWebResponse)

                        Using responseStream As Stream =
                                    response.GetResponseStream()

                            ' FileMode.Create automatically replaces the existing file
                            Using fs As New FileStream(
                                        LocalFilePath,
                                        FileMode.Create,
                                        FileAccess.Write)

                                responseStream.CopyTo(fs)

                            End Using
                        End Using
                    End Using
                    'Debug.WriteLine("Downloaded: " & fileName)

                Catch ex As Exception

                    Debug.WriteLine(
                                "Error downloading " & fileName &
                                ": " & ex.Message)
                End Try

            Next

        Catch ex As Exception
            MsgBox("Error accessing FTP folder: " & ex.ToString)
        End Try
    End Sub

    'Method: FTP Transfer (Upload or Download) for File or Folder
    Public Sub FTP_Transfer(Action As String, Type As String, FTP_Path As String, LocalPath As String)

        'Action = Upload or Download
        'Type = File or Folder
        'FTP_Path = FTP path of the file or folder to be uploaded or downloaded
        'LocalPath = Local path of the file or folder to be uploaded or downloaded

        Select Case Action.ToLower()
            Case "upload"
                    'If Type.ToLower() = "file" Then
                    '    'UploadFile(FTP_FilePath, LocalPath, ftpUser, ftpPass)
                    'ElseIf Type.ToLower() = "folder" Then
                    '    'UploadFolder(FTP_FilePath, LocalPath, ftpUser, ftpPass) ' Implement folder upload if needed
                    'End If

            Case "download"
                If Type.ToLower() = "file" Then
                    downloadSingleFileFromFTP(FTP_Path, LocalPath)
                ElseIf Type.ToLower() = "folder" Then
                    downloadFolderFromFTP(FTP_Path, LocalPath)
                End If

        End Select



    End Sub


End Module
