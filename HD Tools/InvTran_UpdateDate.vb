Imports HD_Button.DB_Tools
Public Class InvTran_UpdateDate
    Private Sub InvTran_UpdateDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerInvDate_Old.Format = DateTimePickerFormat.Custom
        DateTimePickerInvDate_Old.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        DateTimePickerInvDate_New.Format = DateTimePickerFormat.Custom
        DateTimePickerInvDate_New.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
    End Sub

    Private Sub ChangeDB_Click(sender As Object, e As EventArgs) Handles ChangeDB.Click
        Dim TT As String = ComboBoxInvTranType.Text
        Dim UD As String = DateTimePickerInvDate_Old.Value.ToString("yyyy-MM-dd hh:mm:ss.000 tt")
        Dim NDate As Date = DateTimePickerInvDate_New.Value.ToString("yyyy-MM-dd hh:mm:ss.000 tt")
        Dim BDate As Date = DateTimePickerInvDate_New.Value.ToString("yyyy-MM-dd 00:00:00.000")

        Select Case TT
            Case "Physical Count"
                DialogResult = MessageBox.Show($"Are you sure you want to update Physical Count's date from {UD}? ", "Update Physical Count", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
update iris.dbo.tblInventoryStatusMaster set CreateDate='{NDate}', BusinessDate='{BDate}', UpdDate='{NDate}', FinalizeDate='{NDate}', LastModifyDate='{NDate}' where TranID=1 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatus set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=1 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatusArchive set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=1 and UpdDate='{UD}'")
                    MessageBox.Show("Physical Count has been updated!", "Update Physical Count")
                Else
                    MessageBox.Show("Be Careful!", "Update Physical Count")
                End If

            Case "Raw Waste"
                DialogResult = MessageBox.Show($"Are you sure you want to update Raw Waste's date from {UD}? ", "Update Raw Waste", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
update iris.dbo.tblInventoryStatusMaster set CreateDate='{NDate}', BusinessDate='{BDate}', UpdDate='{NDate}', FinalizeDate='{NDate}', LastModifyDate='{NDate}' where TranID=12 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatus set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=12 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatusArchive set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=12 and UpdDate='{UD}'")
                    MessageBox.Show("Physical Count has been updated!", "Update Raw Waste")
                Else
                    MessageBox.Show("Be Careful!", "Update Raw Waste")
                End If

            Case "Transfer In"
                DialogResult = MessageBox.Show($"Are you sure you want to update Transfer In's date from {UD}? ", "Update Transfer In", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
update iris.dbo.tblInventoryStatusMaster set CreateDate='{NDate}', BusinessDate='{BDate}', UpdDate='{NDate}', FinalizeDate='{NDate}', LastModifyDate='{NDate}' where TranID=4 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatus set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=4 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatusArchive set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=4 and UpdDate='{UD}'")
                    MessageBox.Show("Physical Count has been updated!", "Update Transfer In")
                Else
                    MessageBox.Show("Be Careful!", "Update Transfer In")
                End If

            Case "Transfer Out"
                DialogResult = MessageBox.Show($"Are you sure you want to update Transfer In's date from {UD}? ", "Update Transfer Out", MessageBoxButtons.YesNo)
                If (DialogResult = DialogResult.Yes) Then
                    ExecuteCmdToServer(VarString:=$"
update iris.dbo.tblInventoryStatusMaster set CreateDate='{NDate}', BusinessDate='{BDate}', UpdDate='{NDate}', FinalizeDate='{NDate}', LastModifyDate='{NDate}' where TranID=5 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatus set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=5 and UpdDate='{UD}';
update iris.dbo.tblInventoryStatusArchive set BusinessDate='{BDate}', UpdDate='{NDate}' where TranID=5 and UpdDate='{UD}'")
                    MessageBox.Show("Physical Count has been updated!", "Update Transfer Out")
                Else
                    MessageBox.Show("Be Careful!", "Update Transfer Out")
                End If
        End Select
    End Sub
End Class