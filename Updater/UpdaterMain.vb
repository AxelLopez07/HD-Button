Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Module UpdaterMain
    Sub Main(args As String())
        If args.Length < 3 Then
            Console.WriteLine("Invalid arguments. Expected: <zipPath> <installPath> <exePath>")
            Return
        End If

        Dim zipPath = args(0)
        Dim installPath = args(1)
        Dim exePath = args(2)

        Try
            ' Wait a moment for the main app to fully close
            Thread.Sleep(2000)

            ' Extract the update zip to a temporary folder
            Dim extractPath = Path.Combine(Path.GetTempPath(), "HDButton_Update")
            If Directory.Exists(extractPath) Then Directory.Delete(extractPath, True)
            ZipFile.ExtractToDirectory(zipPath, extractPath)

            ' Copy new files over the existing ones
            For Each file In Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories)
                Dim relativePath = file.Substring(extractPath.Length + 1)
                Dim destPath = Path.Combine(installPath, relativePath)

                Directory.CreateDirectory(Path.GetDirectoryName(destPath))
                'File.Copy(file, destPath, True)
                file.TryCopyTo(destPath)
            Next

            ' Restart the updated main app
            Process.Start(exePath)

        Catch ex As Exception
            MessageBox.Show("Error applying update: " & ex.Message)
        End Try
    End Sub
End Module