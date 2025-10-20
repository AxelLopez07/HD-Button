Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Registers_DeleteLoyalties
    'Private directories As New List(Of String) From {
    '    "\\Reg1\iris\loyaltypend\",
    '    "\\Reg2\iris\loyaltypend\",
    '    "\\Reg3\iris\loyaltypend\",
    '    "\\Reg4\iris\loyaltypend\",
    '    "C:\loyaltyBuffer\Punchh\"
    '}
    Private Function ConnectionToRegisters(myPath As String) As Boolean
        Dim myDir As New DirectoryInfo(myPath)
        If myDir.Exists Then
            Return myDir.EnumerateFiles().Any
        End If
        Return False
    End Function
    Private Sub Registers_DeleteLoyalties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim progressBars As New List(Of Windows.Forms.ProgressBar) From {
        'ProgressBarReg1,
        'ProgressBarReg2,
        'ProgressBarReg3,
        'ProgressBarReg4,
        'ProgressBarBOC
        '}
        'For Each entry As String In directories
        '    For Each progressBar As Windows.Forms.ProgressBar In progressBars
        '        If ConnectionToRegisters(entry) Then
        '            progressBar.Value = 100
        '        Else
        '            progressBar.Value = 0
        '        End If
        '    Next
        'Next

        Dim Flag As New List(Of PictureBox)()
        Flag.Add(Me.PictureBox1)
        Flag.Add(Me.PictureBox2)
        Flag.Add(Me.PictureBox3)
        Flag.Add(Me.PictureBox4)
        Flag.Add(Me.PictureBox5)
        Flag.Add(Me.PictureBox6)

        Me.PictureBox1.BackColor = DefaultBackColor
        Me.PictureBox2.BackColor = DefaultBackColor
        Me.PictureBox3.BackColor = DefaultBackColor
        Me.PictureBox4.BackColor = DefaultBackColor
        Me.PictureBox5.BackColor = DefaultBackColor
        Me.PictureBox6.BackColor = DefaultBackColor

        Dim Loyalty_Path As New List(Of String)()
        Loyalty_Path.Add("\\Reg1\iris\loyaltypend")
        Loyalty_Path.Add("\\Reg2\iris\loyaltypend")
        Loyalty_Path.Add("\\Reg3\iris\loyaltypend")
        Loyalty_Path.Add("\\Reg4\iris\loyaltypend")
        Loyalty_Path.Add("\\Reg5\iris\loyaltypend")

        Loyalty_Path.Add("C:\iris\loyaltypend")
        Loyalty_Path.Add("C:\loyaltyBuffer\Punchh\")

        For I As Integer = 0 To 4
            ' Check if the directory exists
            If Directory.Exists(Loyalty_Path(I)) Then
                ' Get the files in the directory
                Dim files As String() = Directory.GetFiles(Loyalty_Path(I))

                ' Check if the array is empty
                If files.Length > 0 Then
                    Flag(I).BackColor = Color.Red
                Else
                    Flag(I).BackColor = Color.Green
                End If
            End If
        Next

        If Directory.Exists(Loyalty_Path(5)) And Directory.Exists(Loyalty_Path(6)) Then
            ' Get the files in the directory
            Dim files1 As String() = Directory.GetFiles(Loyalty_Path(6))
            Dim files2 As String() = Directory.GetFiles(Loyalty_Path(7))

            ' Check if the array is empty
            If files1.Length > 0 And files2.Length > 0 Then
                Flag(5).BackColor = Color.Red
            Else
                Flag(5).BackColor = Color.Green
            End If
        End If

    End Sub
    Private Sub ButtonDeleteLoyalties_Click(sender As Object, e As EventArgs) Handles ButtonDeleteLoyalties.Click
        Me.ButtonDeleteLoyalties.Enabled = False

        Dim RegNum = ComboBoxRegisters.Text
        Dim directoryPath As String

        ' Determine the directory path based on the ComboBox selection
        If RegNum = "Back Office" Then
            directoryPath = "C:\loyaltyBuffer\Punchh\"
        Else
            directoryPath = "\\" & RegNum & "\iris\loyaltypend"
        End If

        ' Check if the directory exists
        If Directory.Exists(directoryPath) Then
            ' Delete all files in the directory
            For Each filePath As String In Directory.GetFiles(directoryPath)
                Try
                    File.Delete(filePath)
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            Next
            MessageBox.Show("All files have been deleted successfully", "Clear Loyalties")
        Else
            MessageBox.Show("Loyalties not installed", "Clear Loyalties")
        End If
        Me.ButtonDeleteLoyalties.Enabled = True
    End Sub
End Class