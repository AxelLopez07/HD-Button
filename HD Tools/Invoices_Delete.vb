Imports System.Data.SqlClient
Imports HD_Button.DB_Tools

Public Class Invoices_Delete
    Public NConnection As SqlConnection
    Public CCommand As SqlCommand
    Public ID As String
    Public UD As Date

    Private Sub Invoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DelInvoiceB_Click(sender As Object, e As EventArgs) Handles DelInvoiceB.Click
        Dim ID As String = InvIdT.Text
        DialogResult = MessageBox.Show($"Are you sure you want to delete Invoice #{ID}? ", "Delete Invoice", MessageBoxButtons.YesNo)

        If (DialogResult = DialogResult.Yes) Then
            ExecuteCmdToServer(VarString:=$"
delete from iris.dbo.tblInvoiceMaster where InvoiceID ='{ID}'; 
delete from iris.dbo.tblRejectedInvoices where InvoiceID ='{ID}'; 
delete from iris.dbo.tblCostHistory where InvoiceID ='{ID}'; 
delete from iris.dbo.tblInventoryStatus where Custom2 ='{ID}'; 
delete from iris.dbo.tblInventoryStatusArchive where Custom2 ='{ID}'")
            MessageBox.Show("Invoice has been deleted!", "Delete Invoice")
        Else
            MessageBox.Show("Be Careful!", "Delete Invoice")
        End If
    End Sub
End Class
