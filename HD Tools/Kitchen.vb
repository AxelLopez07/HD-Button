Imports HD_Button.DB_Tools

Public Class Kitchen

    Public OrderId As Integer

    Private Sub OrderNumber_Click(sender As Object, e As EventArgs) Handles OrderNumber.Click
        OrderId = OrderIdText.Text

        ExtractFromRAR("File", "Files\Common\sqlite_app\sqlite3.exe", "C:\IRIS\Bin\HD Button\HD Button Package")
        Shell("cmd /c cd C:\IRIS\Bin\HD Button\HD Button Package & sqlite3 C:\iris\data\kitchen.sqlite ""update tblorder Set Paid=1 where ordernum=" & OrderId & " "" /WAIT")
        Shell("cmd /c taskkill /IM ""Kitchen.exe"" -F")

        MessageBox.Show("Order Number #" & OrderId & " can be bumped now!", "Kitchen Order")

    End Sub

    Private Sub Kitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class