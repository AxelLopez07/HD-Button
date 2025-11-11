
Imports System.IO
Imports System.IO.Compression
Imports System.Threading
Imports System.Windows.Forms.Design
Public Class Form1

    Sub Main(args As String())
        If args.Length < 3 Then
            'Console.WriteLine("Invalid arguments. Expected: <zipPath> <installPath> <exePath>")
            MsgBox("Invalid arguments. Expected: <zipPath> <installPath> <exePath>")
            Return
        End If

        Dim zipPath = args(0)
        Dim installPath = args(1)
        Dim exePath = args(2)

        'MsgBox("Updater started with arguments:" & vbCrLf &
        '       "Zip Path: " & zipPath & vbCrLf &
        '       "Install Path: " & installPath & vbCrLf &
        '       "Exe Path: " & exePath)

        Try
            ' Wait a moment for the main app to fully close
            Thread.Sleep(2000)

            ' Extract the update zip to a temporary folder
            Dim extractPath = Path.Combine(Path.GetTempPath(), "HD-Button")
            If Directory.Exists(extractPath) Then Directory.Delete(extractPath, True)
            ZipFile.ExtractToDirectory(zipPath, extractPath)

            'MsgBox("Extracted update from " & zipPath & " to: " & extractPath)

            ' Copy new files over the existing ones
            For Each file In Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories)
                'For Each file In Directory.GetFiles("C:\Users\IRIS_ADMIN\AppData\Local\Temp\HD-Button\net9.0-windows7.0", "*", SearchOption.AllDirectories)
                'Dim relativePath = file.Substring(extractPath.Length + 1)
                Dim relativePath = file.Substring(extractPath.Length + 19)
                Dim destPath = Path.Combine(installPath, relativePath)

                'MsgBox("File to copy: " & file.ToString)
                'MsgBox("Relativepath=" & relativePath.ToString)
                'MsgBox("FileName:" & file.ToString)
                'MsgBox("destPath:" & destPath.ToString)


                'Directory.CreateDirectory(Path.GetDirectoryName(destPath))
                'file.Copy(file, destPath, True)
                System.IO.File.Copy(file, destPath, True)


                'MsgBox("Copied file to: " & destPath)

            Next

            MsgBox("Update applied successfully!")

            ' Restart the updated main app
            Process.Start(exePath)
            Application.Exit()

        Catch ex As Exception
            MessageBox.Show("Error applying update: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main(Environment.GetCommandLineArgs().Skip(1).ToArray())
    End Sub
End Class
