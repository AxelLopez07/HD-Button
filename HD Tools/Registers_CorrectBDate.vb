Imports HD_Button.DB_Tools
Public Class Registers_CorrectBDate
    Private Sub BDateB_Click(sender As Object, e As EventArgs) Handles ButtonCorrectBDay.Click
        Try
            Me.ButtonCorrectBDay.Enabled = False
            '---register# to apply variable
            Dim BReg = ComboBoxRegisters.Text

            ExtractFromRAR("File", "Files\Common\sqlite_app\sqlite3.exe", "\\" & BReg.ToString & "\IRIS\Data")

            '---Execute CMD on teh network register to use sqlite tool and aply the businessDate correction
            Shell("cmd /c pushd\\" & BReg.ToString & "\IRIS\Data & sqlite3 POSlive.sqlite ""update tblbusinessdate Set BusinessDate='" & Me.DateTimePickerBusinessDay.Value.ToString("yyyy/MM/ddT00:00:00") & "'"" ")


            'Perform log-off on the register
            Shell("cmd /c shutdown /l /m \\"" & BReg.ToString & ")

            MessageBox.Show("Business Date has been Changed!, " & BReg.ToString & " should be login off out now!, if not, please perfom a manual log off", "Business Date")

        Catch ex As Exception
            Me.ButtonCorrectBDay.Enabled = True
            MsgBox(ex.ToString)
        End Try
        Me.ButtonCorrectBDay.Enabled = True


    End Sub
End Class