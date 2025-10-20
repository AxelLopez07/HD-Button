Imports System.Data.SqlClient
Imports HD_Button.DB_Tools

Public Class Mirus

    Public BegDate As Date
    Public X As Integer
    Public Days As Date
    Public Diff As Integer
    Public Sub Mirus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MM/dd/yy"

        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "MM/dd/yy"

    End Sub

    Public Sub MirusButton_Click(sender As Object, e As EventArgs) Handles MirusButton.Click
        If DateTimePicker2.Value <= DateTimePicker3.Value Then

            Dim StartDate As Date = DateTimePicker2.Value.ToString("MM/dd/yy")
            Dim EndDate As Date = DateTimePicker3.Value.ToString("MM/dd/yy")

            Do While StartDate <= EndDate

                Me.Hide()

                'Dim process As New Process
                'process.StartInfo.FileName = "cmd.exe"
                'process.StartInfo.Arguments = $"/c cd c:\mirus\mirusconnect & mirusconnect.exe /-a -b " & "StartDate.ToString("MM/dd/yy")"&" /-e=" & StartDate.ToString("MM/dd/yy") & " & Exit"
                'process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                'process.StartInfo.CreateNoWindow = True
                'process.Start()
                'process.WaitForExit()

                ExecuteCMD("cmd /c c:\mirus\mirusconnect\mirusconnect.exe -a -b " & StartDate.ToString("MM/dd/yy") & " -e " & StartDate.ToString("MM/dd/yy") & "")

                StartDate = StartDate.AddDays(1)
            Loop

            Me.Close()
            MainMenu.Close()

        Else
            MessageBox.Show("Wrong Dates, Not Possible", "Mirus")
        End If
    End Sub

End Class
