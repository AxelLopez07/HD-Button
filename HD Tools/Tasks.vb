Imports System.Data.SqlClient
Imports System.Data.OleDb
Module Tasks
    Public Sub CopyFileIfExist(source As String, destination As String)
        Shell($"cmd /c IF EXIST ""{source}"" XCOPY ""{source}"" ""{destination}"" /i /Y")
    End Sub

    Public Sub KillTask(taskName As String)
        Shell($"cmd /c taskkill /IM ""{taskName}"" -F")
    End Sub

    Public Sub RunTask_ShellCmd(taskName As String, shellCmd As String)
        Dim resultMsgBox As DialogResult = MessageBox.Show($"The task {taskName} will start now! Press OK to continue...", $"Starting {taskName}", MessageBoxButtons.OKCancel)
        If resultMsgBox = DialogResult.OK Then
            Try
                Shell(shellCmd)
            Catch ex As Exception
                MsgBox($"Error while executing: {taskName}" & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub RunTask_DashboardRes()
        Dim resultMsgBox As DialogResult = MessageBox.Show("Dashboard Reloading Now! Press OK to continue...", "Dashboard", MessageBoxButtons.OKCancel)
        If resultMsgBox = DialogResult.OK Then

            'MDB File Path variable
            Dim MDBFilePath As String() = {
            "C:\Program Files (x86)\xpient Solutions\Visual Dashboard\Dashboards\BackOfficeSOS\BackOfficeSOS.mdb",
            "C:\Program Files (x86)\xpient Solutions\Visual Dashboard\Dashboards\BackOfficeSOS\BackOfficeSOS\BackOfficeSOS.mdb",
            "C:\Users\IRIS_ADMIN\AppData\Local\VirtualStore\Program Files (x86)\xpient Solutions\Visual Dashboard\Dashboards\BackOfficeSOS\BackOfficeSOS.mdb"
            }

            For Each path As String In MDBFilePath
                'Conection String
                ' Dim MDBConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={MDBFilePath};"
                Dim MDBConnectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};"

                'SQL Query
                Dim MDBQuery As String = "Update tblPanel set PanelWidth=15780, PanelHeight=9000"
                'Connection
                Using MDBConnection As New OleDbConnection(MDBConnectionString)
                    Try
                        MDBConnection.Open()
                        'MDBCommand
                        Using MDBCommand As New OleDbCommand(MDBQuery, MDBConnection)
                            MDBCommand.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            Next

            KillTask("Visual Dashboard.exe")
        End If

    End Sub
End Module
