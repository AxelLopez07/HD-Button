Imports HD_Button.DB_Tools
Public Class Invoices_UpdateDate
    Private Sub Invoices_UpdateDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerInvDate_Old.Format = DateTimePickerFormat.Custom
        DateTimePickerInvDate_Old.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        DateTimePickerInvDate_New.Format = DateTimePickerFormat.Custom
        DateTimePickerInvDate_New.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
    End Sub
    Private Sub UpdInvoiceB_Click(sender As Object, e As EventArgs) Handles UpdInvoiceB.Click
        Dim ID As String = InvId.Text
        Dim BDate As String = DateTimePickerInvDate_New.Value.ToString("yyyy-MM-dd hh:mm:ss.000 tt")
        Dim BDateShort As String = DateTimePickerInvDate_New.Value.ToString("yyyy-MM-dd")

        DialogResult = MessageBox.Show($"Are you sure you want to update Invoice #{ID}? ", "Update Invoice", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.Yes) Then
            ExecuteCmdToServer(VarString:=$"
update iris.dbo.tblInvoiceMaster set BusinessDate='{BDate}', DateOfInvoice='{BDateShort}', FinalizeOnDate='{BDate}' where InvoiceID='{ID}';
update iris.dbo.tblInventoryStatus set BusinessDate='{BDate}', UpdDate='{BDate}' where Custom2='{ID}';
update iris.dbo.tblInventoryStatusArchive set BusinessDate='{BDate}', UpdDate='{BDate}' where Custom2='{ID}';
update iris.dbo.tblCostHistory set BusinessDate='{BDate}', SystemDateTime='{BDate}' where InvoiceID='{ID}'")
            MessageBox.Show("Invoice has been Updated!", "Update Invoice")
        Else
            MessageBox.Show("Be Careful!", "Update Invoice")
        End If
    End Sub
End Class