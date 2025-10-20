Imports Microsoft.VisualBasic.FileIO
Imports MongoDB
Imports System.Buffers
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Reflection.Metadata
Imports System.Runtime
Imports System.Runtime.InteropServices
Imports System.Security.Authentication.ExtendedProtection
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports HD_Button.DB_Tools

Public Class EmpRehire

    Private Sub RehireButton_Click(sender As Object, e As EventArgs) Handles RehireButton.Click
        Dim EmpId = EmpIdText.Text
        ExecuteCmdToServer(VarString:="update iris.dbo.tblEmployeesStatusHistory set Rehire=1 where EmployeeID=" & EmpId & " and StatusID=3")
        MessageBox.Show("Employee Is Enabled for Rehire Now", "Employee Rehire")

    End Sub

    Private Sub EmpRehire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class