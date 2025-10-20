Imports HD_Button.DB_Tools
Imports SharpCompress.Archives
Imports System.IO
Imports System.Threading

Public Class FastTrackMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Button2.Enabled = False
            ' Specify the path you want to search
            Dim path As String = "C:\ProgramData\Fast Track Software Suite"
            ' Get the list of directories in the specified path
            Dim directories As String() = Directory.GetDirectories(path)
            ' Check if there are any directories in the specified path
            If directories.Length > 0 Then
                ' Create a DirectoryInfo object from the first directory path
                Dim firstDirectoryInfo As New DirectoryInfo(directories(0))
                ' Get the name of the first directory
                Dim firstDirectoryName As String = firstDirectoryInfo.Name

                'MsgBox("The first directory name is: " & firstDirectoryName)

                ' Specify the file path where you want to create the file
                Dim filePath As String = "C:\ProgramData\Fast Track Software Suite\TimeSync.ACL"
                ' Specify the text you want to write to the file
                Dim textToWrite As String = "SET_TIME '" & firstDirectoryName & "'"
                ' Use StreamWriter to create the file and write text to it
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine(textToWrite)
                End Using
                'Execute via cmd the file created
                ExecuteCMD("C:\ProgramData\Fast Track Software Suite\FastTrack TimeSync.ACL")

            Else
                ' If no directories are found, output a message
                MsgBox("No directories found in the specified path.")
            End If
        Catch ex As Exception
            Me.Button2.Enabled = True
            MsgBox(ex.ToString)
        End Try
        Me.Button2.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Button1.Enabled = False

            'extract xml taSK FILE
            ExtractFromRAR("File", "Files\Common\temp\FastTrackFiles\FTTLog.xml", "C:\temp")

            'Delete task from Schedule if exists already
            ExecuteCMD("cmd /c schtasks /delete /tn " & "FTTLog" & " /f")
            'Update task registry
            ExecuteCMD("cmd /c schtasks /create /tn " & "FTTLog" & " /xml " & "C:\Temp\FTTLog.xml" & " /ru iris_admin /rp STCOXp13nt@dmin")


        Catch ex As Exception
            Me.Button1.Enabled = True
            MsgBox(ex.ToString)
        End Try
        Me.Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Button3.Enabled = False

            'UnrarResourceFile(My.Resources.Fast_Track_PC_Software_Setup_2_27, "C:\temp") and execute/install
            ExtractFromRAR("File", "Files\Common\temp\Fast_Track_PC_Software_Setup_2.27.exe", "C:\temp")
            ExecuteCMD("cmd /c C:\temp\Fast_Track_PC_Software_Setup_2.27.exe")

            'Extract Fast track Files
            ExtractFromRAR("Directory", "Files\Common\temp\FastTrackFiles\", "C:\programdata\Fast Track Software Suite")

            MsgBox("Note: the site and parameters set up needs to be done manually!")

        Catch ex As Exception
            Me.Button3.Enabled = True
            MsgBox("Error!", ex.ToString)
        End Try
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Button4.Enabled = False
            ' UnrarResourceFile(My.Resources.DTIS_Setup_V2_4, "C:\temp")
            ExtractFromRAR("File", "Files\Common\temp\DTIS_Setup_V2.4.exe", "C:\temp")

            ExecuteCMD("cmd /c C:\temp\DTIS_Setup_V2.4.exe")
            MsgBox("Note the DTIS IP set up needs to be done manually")
        Catch ex As Exception
            Me.Button4.Enabled = True
            MsgBox("Error!", ex.ToString)
        End Try
        Me.Button4.Enabled = True
    End Sub
End Class