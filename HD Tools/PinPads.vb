Imports HD_Button.DB_Tools
Imports Microsoft.Win32
Imports SharpCompress.Common
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Threading
Imports ZstdSharp.Unsafe
Public Class PinPads
    'ping variables

    'pin pad#1
    Dim successCount1 As Integer = 0
    Dim failCount1 As Integer = 0
    'pin pad#2
    Dim successCount2 As Integer = 0
    Dim failCount2 As Integer = 0
    'pin pad#4
    Dim successCount3 As Integer = 0
    Dim failCount3 As Integer = 0
    'pin pad#5
    Dim successCount4 As Integer = 0
    Dim failCount4 As Integer = 0
    'Register1
    Dim successCount5 As Integer = 0
    Dim failCount5 As Integer = 0
    'Register2
    Dim successCount6 As Integer = 0
    Dim failCount6 As Integer = 0
    'Register3
    Dim successCount7 As Integer = 0
    Dim failCount7 As Integer = 0
    'Register4
    Dim successCount8 As Integer = 0
    Dim failCount8 As Integer = 0
    'Register5
    Dim successCount9 As Integer = 0
    Dim failCount9 As Integer = 0


    Dim pingSender As New Ping()
    Dim options As New PingOptions()

    Private Sub PinPads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSCADInfo()
        options.DontFragment = True
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
        Timer8.Start()
        Timer9.Start()

    End Sub
    ' Reset ping methid
    Private Sub reset_ping()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        LPP1_IP.ResetText()
        LPP2_IP.ResetText()
        LPP4_IP.ResetText()
        LPP5_IP.ResetText()
        LPSCAD1.ResetText()
        LPSCAD2.ResetText()
        LPSCAD4.ResetText()
        LPSCAD5.ResetText()
        LReg1Ping.ResetText()
        LReg2Ping.ResetText()
        LReg3Ping.ResetText()
        LReg4Ping.ResetText()
        LReg5Ping.ResetText()
        successCount1 = 0
        failCount1 = 0
        successCount2 = 0
        failCount2 = 0
        successCount3 = 0
        failCount3 = 0
        successCount4 = 0
        failCount4 = 0
        successCount5 = 0
        failCount5 = 0
        successCount6 = 0
        failCount6 = 0
        successCount7 = 0
        failCount7 = 0
        successCount8 = 0
        failCount8 = 0
        successCount9 = 0
        failCount9 = 0
        FillSCADInfo()
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
        Timer8.Start()
        Timer9.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Me.LPP1_IP.Text.Length = 18 Then
                Dim hostNameOrAddress1 As String = Me.LPP1_IP.Text.ToString.Substring(5, 13).ToString
                Dim LabelStatus1 As Label = Me.LPSCAD1
                Dim reply1 As PingReply = pingSender.Send(hostNameOrAddress1, 1000, New Byte() {1, 2, 3, 4}, options)

                If reply1.Status = IPStatus.Success Then
                    successCount1 += 1
                Else
                    failCount1 += 1
                End If

                Dim totalPings1 As Integer = successCount1 + failCount1
                Dim lossPercentage1 As Double = If(totalPings1 > 0, Format((failCount1 / totalPings1) * 100, "#.00"), 0)
                LabelStatus1.Text = $"loss rate:" & lossPercentage1.ToString & "%   received packets:" & successCount1.ToString & ""

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If Me.LPP2_IP.Text.Length = 18 Then

                Dim hostNameOrAddress2 As String = Me.LPP2_IP.Text.ToString.Substring(5, 13).ToString
                Dim LabelStatus2 As Label = Me.LPSCAD2
                Dim reply2 As PingReply = pingSender.Send(hostNameOrAddress2, 1000, New Byte() {1, 2, 3, 4}, options)

                If reply2.Status = IPStatus.Success Then
                    successCount2 += 1
                Else
                    failCount2 += 1
                End If

                Dim totalPings2 As Integer = successCount2 + failCount2
                Dim lossPercentage2 As Double = If(totalPings2 > 0, Format((failCount2 / totalPings2) * 100, "#.00"), 0)
                LabelStatus2.Text = $"loss rate:" & lossPercentage2.ToString & "%   received packets:" & successCount2.ToString & ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            If Me.LPP4_IP.Text.Length = 18 Then

                Dim hostNameOrAddress3 As String = Me.LPP4_IP.Text.ToString.Substring(5, 13).ToString
                Dim LabelStatus3 As Label = Me.LPSCAD4
                Dim reply3 As PingReply = pingSender.Send(hostNameOrAddress3, 1000, New Byte() {1, 2, 3, 4}, options)

                If reply3.Status = IPStatus.Success Then
                    successCount3 += 1
                Else
                    failCount3 += 1
                End If

                Dim totalPings3 As Integer = successCount3 + failCount3
                Dim lossPercentage3 As Double = If(totalPings3 > 0, Format((failCount3 / totalPings3) * 100, "#.00"), 0)
                LabelStatus3.Text = $"loss rate:" & lossPercentage3.ToString & "%   received packets:" & successCount3.ToString & ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            If Me.LPP5_IP.Text.Length = 18 Then
                Dim hostNameOrAddress4 As String = Me.LPP5_IP.Text.ToString.Substring(5, 13).ToString
                Dim LabelStatus4 As Label = Me.LPSCAD5
                Dim reply4 As PingReply = pingSender.Send(hostNameOrAddress4, 1000, New Byte() {1, 2, 3, 4}, options)

                If reply4.Status = IPStatus.Success Then
                    successCount4 += 1
                Else
                    failCount4 += 1
                End If

                Dim totalPings4 As Integer = successCount4 + failCount4
                Dim lossPercentage4 As Double = If(totalPings4 > 0, Format((failCount4 / totalPings4) * 100, "#.00"), 0)
                LabelStatus4.Text = $"loss rate:" & lossPercentage4.ToString & "%   received packets:" & successCount4.ToString & ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Try
            Dim hostNameOrAddress5 As String = "192.168.1.101"
            Dim LabelStatus5 As Label = Me.LReg1Ping
            Dim reply5 As PingReply = pingSender.Send(hostNameOrAddress5, 1000, New Byte() {1, 2, 3, 4}, options)

            If reply5.Status = IPStatus.Success Then
                successCount5 += 1
            Else
                failCount5 += 1
            End If

            Dim totalPings5 As Integer = successCount5 + failCount5
            Dim lossPercentage5 As Double = If(totalPings5 > 0, Format((failCount5 / totalPings5) * 100, "#.00"), 0)
            LabelStatus5.Text = $"loss rate:" & lossPercentage5.ToString & "%   received packets:" & successCount5.ToString & ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Try
            Dim hostNameOrAddress6 As String = "192.168.1.102"
            Dim LabelStatus6 As Label = Me.LReg2Ping
            Dim reply6 As PingReply = pingSender.Send(hostNameOrAddress6, 1000, New Byte() {1, 2, 3, 4}, options)

            If reply6.Status = IPStatus.Success Then
                successCount6 += 1
            Else
                failCount6 += 1
            End If

            Dim totalPings6 As Integer = successCount6 + failCount6
            Dim lossPercentage6 As Double = If(totalPings6 > 0, Format((failCount6 / totalPings6) * 100, "#.00"), 0)
            LabelStatus6.Text = $"loss rate:" & lossPercentage6.ToString & "%   received packets:" & successCount6.ToString & ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Try
            Dim hostNameOrAddress7 As String = "192.168.1.103"
            Dim LabelStatus7 As Label = Me.LReg3Ping
            Dim reply7 As PingReply = pingSender.Send(hostNameOrAddress7, 1000, New Byte() {1, 2, 3, 4}, options)

            If reply7.Status = IPStatus.Success Then
                successCount7 += 1
            Else
                failCount7 += 1
            End If

            Dim totalPings7 As Integer = successCount7 + failCount7
            Dim lossPercentage7 As Double = If(totalPings7 > 0, Format((failCount7 / totalPings7) * 100, "#.00"), 0)
            LabelStatus7.Text = $"loss rate:" & lossPercentage7.ToString & "%   received packets:" & successCount7.ToString & ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Try
            Dim hostNameOrAddress8 As String = "192.168.1.104"
            Dim LabelStatus8 As Label = Me.LReg4Ping
            Dim reply8 As PingReply = pingSender.Send(hostNameOrAddress8, 1000, New Byte() {1, 2, 3, 4}, options)

            If reply8.Status = IPStatus.Success Then
                successCount8 += 1
            Else
                failCount8 += 1
            End If

            Dim totalPings8 As Integer = successCount8 + failCount8
            Dim lossPercentage8 As Double = If(totalPings8 > 0, Format((failCount8 / totalPings8) * 100, "#.00"), 0)
            LabelStatus8.Text = $"loss rate:" & lossPercentage8.ToString & "%   received packets:" & successCount8.ToString & ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Try
            Dim hostNameOrAddress9 As String = "192.168.1.105"
            Dim LabelStatus9 As Label = Me.LReg5Ping
            Dim reply9 As PingReply = pingSender.Send(hostNameOrAddress9, 1000, New Byte() {1, 2, 3, 4}, options)

            If reply9.Status = IPStatus.Success Then
                successCount9 += 1
            Else
                failCount9 += 1
            End If

            Dim totalPings9 As Integer = successCount9 + failCount9
            Dim lossPercentage9 As Double = If(totalPings9 > 0, Format((failCount9 / totalPings9) * 100, "#.00"), 0)
            LabelStatus9.Text = $"loss rate:" & lossPercentage9.ToString & "%   received packets:" & successCount9.ToString & ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Button Reset Ping
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call reset_ping()
    End Sub
    'Button Get Terminal ID#
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            FillSCADInfoTID()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Button Update pin pad IP
    Private Sub Btn_UpdatePinPadIP_Click(sender As Object, e As EventArgs) Handles Btn_UpdatePinPadIP.Click
        Try
            If Me.Cmb_Registers.Text <> "" And Me.Txt_PinPadIP.Text <> "" Then

                Dim filePath As String = Nothing
                Dim searchText As String = Nothing
                Dim replacementText As String = "addr=" & Me.Txt_PinPadIP.Text.ToString


                Select Case Me.Cmb_Registers.Text
                    Case "Register #1"
                        filePath = "C:\IRIS\RegInfo\Reg1\Ini\IrisAuthSrvr.ini"
                        searchText = "[scadevice1]"
                    Case "Register #2"
                        filePath = "C:\IRIS\RegInfo\Reg2\Ini\IrisAuthSrvr.ini"
                        searchText = "[scadevice2]"
                    Case "Register #4"
                        filePath = "C:\IRIS\RegInfo\Reg4\Ini\IrisAuthSrvr.ini"
                        searchText = "[scadevice4]"
                End Select

                ' Read all lines from the file
                Dim lines As String() = File.ReadAllLines(filePath)
                Dim targetLineIndex As Integer = -1

                ' Find the index of the search text
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains(searchText) Then
                        targetLineIndex = i
                        Exit For
                    End If
                Next

                ' Check if the search text was found
                If targetLineIndex <> -1 AndAlso targetLineIndex + 1 < lines.Length Then
                    ' Replace the entire line after the search text
                    lines(targetLineIndex + 1) = replacementText

                    ' Write the modified lines back to the file
                    File.WriteAllLines(filePath, lines)

                    'update IP labels
                    FillSCADInfo()

                    MsgBox("IP Address changed!")
                Else
                    MsgBox("Error to replace IP!")
                End If
            Else
                MsgBox("Select a valid Register and IP address")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Button restart POS register
    Private Sub Btn_RestartRegister_Click(sender As Object, e As EventArgs) Handles Btn_RestartRegister.Click
        Try
            If Me.Cmb_Registers.Text <> "" Then
                Dim Register As String = Nothing

                Select Case Me.Cmb_Registers.Text
                    Case "Register #1"
                        Register = "reg1"
                    Case "Register #2"
                        Register = "reg2"
                    Case "Register #4"
                        Register = "reg4"
                End Select

                ExecuteCMD("C:\IRIS\bin\postevent.exe /LogOffReg /'" & Register & "' /Q")
            Else
                MsgBox("Please select a valid register")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    'Reset Status after closing this form
    Private Sub PinPads_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        Me.LPP1_IP.ResetText()
        Me.LPP2_IP.ResetText()
        Me.LPP4_IP.ResetText()
        Me.LPP5_IP.ResetText()
        Me.LPSCAD1.ResetText()
        Me.LPSCAD2.ResetText()
        Me.LPSCAD4.ResetText()
        Me.LPSCAD5.ResetText()
        Me.LReg1Ping.ResetText()
        Me.LReg2Ping.ResetText()
        Me.LReg3Ping.ResetText()
        Me.LReg4Ping.ResetText()
        Me.LReg5Ping.ResetText()
        successCount1 = 0
        failCount1 = 0
        successCount2 = 0
        failCount2 = 0
        successCount3 = 0
        failCount3 = 0
        successCount4 = 0
        failCount4 = 0
        successCount5 = 0
        failCount5 = 0
        successCount6 = 0
        failCount6 = 0
        successCount7 = 0
        failCount7 = 0
        successCount8 = 0
        failCount8 = 0
        successCount9 = 0
        failCount9 = 0
    End Sub

End Class