Public Class Drawers_Close
    Private Sub ButtonCloseDrawer_Click(sender As Object, e As EventArgs) Handles ButtonCloseDrawer.Click
        Try
            If TextBoxDrawerNumber.Text > 0 Then
                Shell("cmd /c cd c:\iris\bin & drawer.exe /DRAWER=" & TextBoxDrawerNumber.Text & " /DATE=" & DateTimePickerClose.Value.ToString("MM/dd/yyyy") & "")
                MessageBox.Show("closing drawer '" & TextBoxDrawerNumber.Text.ToString & "' process is in progress, please wait a minute to see the changes reflected", "Close Drawer")
            Else
                MessageBox.Show("Can't close drawer number Zero or below with this method. Verify drawer number...", "Close Drawer")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class