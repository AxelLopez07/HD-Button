Imports System.Data.SqlClient
Imports HD_Button.DB_Tools

Public Class Items

    Public ID As String

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column As DataGridViewColumn In DataGridView1.Columns
            ' Set the column width to the width of the header text
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next
    End Sub
    'TXT External Number
    Private Sub TxtExtNumID_TextChanged(sender As Object, e As EventArgs) Handles TxtExtNumID.TextChanged
        Try
            If TxtExtNumID.Text.ToString <> "" Then

                Dim dt = GetTableDataFromServer($"select iris.dbo.tblinventorymaster.InvID, InvDesc, Active, tblLinkVendor.VendorID, ExternalItemID from iris.dbo.tblInventoryMaster inner join iris.dbo.tbllinkvendor on iris.dbo.tbllinkvendor.InvID=iris.dbo.tblInventoryMaster.InvID where iris.dbo.tblinventorymaster.InvID in(select InvID from iris.dbo.tblLinkVendor where ExternalItemID='" & TxtExtNumID.Text.ToString & "')")
                DataGridView1.DataSource = dt.DefaultView

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'TXT InvID number
    Private Sub InvIdText_TextChanged(sender As Object, e As EventArgs) Handles InvIdText.TextChanged
        Try
            If InvIdText.Text.ToString <> "" Then
                '                Dim dt As DataTable = GetTableDataFromServer($"select iris.dbo.tblinventorymaster.InvID, InvDesc, Active, tblLinkVendor.VendorID, ExternalItemID from iris.dbo.tblInventoryMaster 
                'inner join iris.dbo.tbllinkvendor on iris.dbo.tbllinkvendor.InvID=iris.dbo.tblInventoryMaster.InvID
                'where iris.dbo.tblinventorymaster.InvID in(select InvID from iris.dbo.tblLinkVendor where ExternalItemID='" & InvIdText.ToString & "')")

                Dim dt = GetTableDataFromServer($"select iris.dbo.tblinventorymaster.InvID, InvDesc, Active, tblLinkVendor.VendorID, ExternalItemID from iris.dbo.tblInventoryMaster inner join iris.dbo.tbllinkvendor on iris.dbo.tbllinkvendor.InvID=iris.dbo.tblInventoryMaster.InvID where iris.dbo.tblinventorymaster.InvID ='" & InvIdText.Text.ToString & "'")
                DataGridView1.DataSource = dt.DefaultView

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class