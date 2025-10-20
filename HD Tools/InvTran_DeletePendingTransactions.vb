Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports HD_Button.DB_Tools
Public Class InvTran_DeletePendingTransactions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Button1.Enabled = False
            ExecuteCmdToServer(VarString:="delete from iris.dbo.tblInventoryStatusPending where InvStatusID in (select InvStatusID from iris.dbo.tblInventoryStatusMaster where FinalizeDate is NULL)")
            ExecuteCmdToServer(VarString:="delete from iris.dbo.tblInventoryStatusMaster where InvStatusID in (select InvStatusID from iris.dbo.tblInventoryStatusMaster where FinalizeDate is NULL)")
            ExecuteCmdToServer(VarString:="delete from iris.dbo.tblInventoryStatus where UpdDate in (select UpdDate from iris.dbo.tblInventoryStatusMaster where FinalizeDate is NULL)")
            ExecuteCmdToServer(VarString:="delete from iris.dbo.tblInventoryStatusArchive where UpdDate in (select UpdDate from iris.dbo.tblInventoryStatusMaster where FinalizeDate is NULL)")
            MessageBox.Show("All pending transactions have bee deleted", "Inventory Transactions")

        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Button1.Enabled = True
        End Try
        Me.Button1.Enabled = True
    End Sub
End Class