Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Pic1
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Me.Close()
    End Sub

    Private Sub linkLabelclipboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabelclipboard.LinkClicked
        Dim url As String = "https://starcorp-edm.xenial.com/edm/"
        Clipboard.SetText(url)
        ToolTipAlert.Show("Link has been copied to clipboard", linkLabelclipboard, 5000)
    End Sub
End Class