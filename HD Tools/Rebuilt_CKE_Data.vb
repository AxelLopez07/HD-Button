Imports System.Drawing.Text

Public Class Rebuilt_CKE_Data
    Private Sub Rebuilt_CKE_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    '-----------------Excute Shell (cmd) process and wait for finsih before proceed
    Public Sub ExecuteCMD(CMDLine As String)
        Try
            Dim processID = Shell(CMDLine, 0)
            Dim p As Process = Process.GetProcessById(processID)
            p.WaitForExit()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Rebuilt CKE Data Method
    Private Sub RebuiltCKEData(StartDate As Date, EndDate As Date)
        While (StartDate <= EndDate)
            'Create Tlog File using date in Format yyyy-MM-dd
            'ExecuteCMD("cmd /c c:\iris\bin\sendtlog.exe /tlog=corrected /date=" & StartDate.ToString("yyyy-MM-dd"))

            'Create FIN File and zip the files
            ExecuteCMD("cmd /c c:\Program Files (x86)\XPIENT Solutions\psiExporter\Bin\psiexporter.exe /config=exporter_config_hardeesfran2.xml /date=" & StartDate.ToString("MM/dd/yyyy"))

            StartDate = StartDate.AddDays(1)
        End While
    End Sub
    'Button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.DateTimePicker1.Value.Date <= Me.DateTimePicker2.Value.Date Then
                Me.Button1.Enabled = False
                MsgBox("building files...")
                Call RebuiltCKEData(Me.DateTimePicker1.Value.ToString("MM-dd-yy"), Me.DateTimePicker2.Value.ToString("MM-dd-yy"))

            Else
                MsgBox("Start Date needs to be prior or equal to end Date")
            End If

        Catch ex As Exception
            Me.Button1.Enabled = True
            MsgBox(ex.ToString)
        End Try
        Me.Button1.Enabled = True
    End Sub

End Class