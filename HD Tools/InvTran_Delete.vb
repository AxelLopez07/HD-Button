Imports HD_Button.DB_Tools
Public Class InvTran_Delete
    Private Sub InvTran_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerInvTranDate.Format = DateTimePickerFormat.Custom
        DateTimePickerInvTranDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
    End Sub
    Private Sub DelPCB_Click(sender As Object, e As EventArgs) Handles DelPCB.Click
        Dim TT As String = ComboBoxInvTranType.Text
        Dim UD As String = DateTimePickerInvTranDate.Value.ToString("yyyy-MM-dd hh:mm:ss.000 tt")

        Select Case TT
            Case "Physical Count"
                DialogResult = MessageBox.Show($"Are you sure you want to delete Physical Count from {UD}? ", "Delete Physical Count", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
declare @InvSID datetime; 
set @InvSID = (select InvStatusID from iris.dbo.tblInventoryStatusMaster where upddate='{UD}' And TranID=1); 
delete from iris.dbo.tblInventoryStatusPending where InvStatusID=@invSID; 
delete from iris.dbo.tblInventoryStatusMaster where TranID=1 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatus where TranID=1 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatusArchive where TranID=1 and UpdDate='{UD}'")
                    MessageBox.Show("Physical Count has been deleted!", "Physical Count")
                Else
                    MessageBox.Show("Be Careful!", "Physical Count")
                End If

            Case "Raw Waste"
                DialogResult = MessageBox.Show($"Are you sure you want to delete Raw Waste from {UD}? ", "Raw Waste", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
declare @InvSID datetime; 
set @InvSID = (select InvStatusID from iris.dbo.tblInventoryStatusMaster where upddate='{UD}' And TranID=12); 
delete from iris.dbo.tblInventoryStatusPending where InvStatusID=@invSID; 
delete from iris.dbo.tblInventoryStatusMaster where TranID=12 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatus where TranID=12 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatusArchive where TranID=12 and UpdDate='{UD}'")
                    MessageBox.Show("Raw Waste has been deleted!", "Raw Waste")
                Else
                    MessageBox.Show("Be Careful!", "Raw Waste")
                End If

            Case "Transfer In"
                DialogResult = MessageBox.Show($"Are you sure you want to delete Transfer In from {UD}? ", "Transfer In", MessageBoxButtons.YesNo)
                    If (DialogResult = DialogResult.Yes) Then
                        ExecuteCmdToServer(VarString:=$"
declare @InvSID datetime; 
set @InvSID = (select InvStatusID from iris.dbo.tblInventoryStatusMaster where upddate='{UD}' And TranID=4); 
delete from iris.dbo.tblInventoryStatusPending where InvStatusID=@invSID; 
delete from iris.dbo.tblInventoryStatusMaster where TranID=4 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatus where TranID=4 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatusArchive where TranID=4 and UpdDate='{UD}'")
                        MessageBox.Show("Transfer In has been deleted!", "Transfer In")
                    Else
                        MessageBox.Show("Be Careful!", "Transfer In")
                    End If

                    Case "Transfer Out"
                DialogResult = MessageBox.Show($"Are you sure you want to delete Transfer Out from {UD}? ", "Transfer Out", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
declare @InvSID datetime; 
set @InvSID = (select InvStatusID from iris.dbo.tblInventoryStatusMaster where upddate='{UD}' And TranID=5); 
delete from iris.dbo.tblInventoryStatusPending where InvStatusID=@invSID; 
delete from iris.dbo.tblInventoryStatusMaster where TranID=5 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatus where TranID=5 and UpdDate='{UD}'; 
delete from iris.dbo.tblInventoryStatusArchive where TranID=5 and UpdDate='{UD}'")
                    MessageBox.Show("Transfer Out has been deleted!", "Transfer Out")
                Else
                    MessageBox.Show("Be Careful!", "Transfer Out")
                End If
        End Select
    End Sub
End Class