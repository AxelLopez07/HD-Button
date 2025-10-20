Imports System.Text.RegularExpressions.Regex
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports HD_Button.DB_Tools


Public Class MainMenu

    Dim listOptions As New List(Of String) From {
        "***REGISTERS***",
        "Close drawers by id",
        "Correct registers business date",
        "Delete Pending Loyalty files",
        "***PAYROLL***",
        "Employee Hours",
        "Enable employee rehire",
        "***INVENROTY/ITEMS***",
        "Search Inventory item",
        "Menu MIMs",
        "Transfer Web",
        "Delete invoice by id",
        "Update invoice date",
        "Delete inventory transaction by date",
        "Delete All pending inventory transactions",
        "Update inventory transaction date",
        "***OTHER TOOLS***",
        "Set Kitchen order to PAID",
        "Send Mirus data",
        "Dashboard Resolution",
        "Rebuild CKE Data",
        "Pin pads/Registers ping",
        "POS Installation tools"
    }

    Public Sub MainMenu_Forms(optionSelected As String)
        Me.Hide()
        Select Case optionSelected
            'Registers
            Case "Close drawers by id"
                Drawers_Close.ShowDialog()
            Case "Correct registers business date"
                Registers_CorrectBDate.ShowDialog()
            Case "Delete Pending Loyalty files"
                Registers_DeleteLoyalties.ShowDialog()
            'PAYROLL
            Case "Employee Hours"
                EmpHours.ShowDialog()
            Case "Enable employee rehire"
                EmpRehire.ShowDialog()
            'Inventory
            Case "Search Inventory item"
                Items.ShowDialog()
            Case "Menu MIMs"
                MenuMIMs.ShowDialog()
            Case "Transfer Web"
                RunTask_ShellCmd(optionSelected, "cmd /k cd c:\EDMWeb & transfer_web.bat")
            Case "Delete invoice by id"
                Invoices_Delete.ShowDialog()
            Case "Update invoice date"
                Invoices_UpdateDate.ShowDialog()
            Case "Delete inventory transaction by date"
                InvTran_Delete.ShowDialog()
            Case "Delete All pending inventory transactions"
                InvTran_DeletePendingTransactions.ShowDialog()
            Case "Update inventory transaction date"
                InvTran_UpdateDate.ShowDialog()
                'Other tools
            Case "Set Kitchen order to PAID"
                Kitchen.ShowDialog()
            Case "Send Mirus data"
                Mirus.ShowDialog()
            Case "Dashboard Resolution"
                RunTask_DashboardRes()
            Case "Rebuild CKE Data"
                Rebuilt_CKE_Data.ShowDialog()
            Case "Pin pads/Registers ping"
                PinPads.ShowDialog()
            Case "POS Installation tools"
                Installs.ShowDialog()

        End Select
        Me.Show()
        Debug.Print(optionSelected)
    End Sub

    Public Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await DB_Tools.CheckForUpdateAsync()

        Try



            'if argument is found will run task
            If My.Application.CommandLineArgs.Count > 0 Then
                Select Case My.Application.CommandLineArgs(0)
                    Case "-sccl"
                        Scan_CC_log()
                        End
                    Case Else
                        End
                        '    ListBoxMainMenu.Items.Clear()
                        '    ListBoxMainMenu.Sorted = False
                        '    ListBoxMainMenu.Items.AddRange(listOptions.ToArray())

                End Select

            Else
                ListBoxMainMenu.Items.Clear()
                ListBoxMainMenu.Sorted = False
                ListBoxMainMenu.Items.AddRange(listOptions.ToArray())
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub ListBoxMainMenu_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBoxMainMenu.DrawItem
        e.DrawBackground()

        If ListBoxMainMenu.Items(e.Index).ToString().Contains("*").ToString Then

            e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
        End If
        e.Graphics.DrawString(ListBoxMainMenu.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()
    End Sub
    Private Sub ListBoxMainMenu_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxMainMenu.DoubleClick
        MainMenu_Forms(ListBoxMainMenu.GetItemText(ListBoxMainMenu.SelectedItem))
    End Sub

    Private Sub ListBoxMainMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxMainMenu.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MainMenu_Forms(ListBoxMainMenu.GetItemText(ListBoxMainMenu.SelectedItem))
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim searchText As String = TextBoxSearch.Text.ToLower()
        searchText = Escape(searchText)
        searchText = searchText
        Dim searchPattern As New Regex(searchText, RegexOptions.IgnoreCase)
        ListBoxMainMenu.Items.Clear()
        Dim listItems As List(Of String) = listOptions
        For Each item As String In listItems
            If searchPattern.IsMatch(item) Then
                ListBoxMainMenu.Items.Add(item)
            End If
        Next
    End Sub


End Class
