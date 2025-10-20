Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports HD_Button.DB_Tools

Public Class EmpHours
    'Load form
    Private Sub EmpHours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear ComboBox
        Me.ComboBox1.Items.Clear()

        'Clear Data Grids
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView2.DataSource = Nothing

        'reset in/out combos 
        Me.Cmb_ClockInBreakIn.SelectedItem = -1
        Me.Cmb_ClockOutBreakOut.SelectedItem = -1

        'Fill employees name ComboBox
        Fill_ComboBox(Me.ComboBox1, "select FullName from iris.dbo.tblemployees order by fullname asc")

        'Set Format for Date time picker boxes
        Dtp_ClockInBreakIn.Format = DateTimePickerFormat.Custom
        Dtp_ClockInBreakIn.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        Dtp_ClockOutBreakOut.Format = DateTimePickerFormat.Custom
        Dtp_ClockOutBreakOut.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"

    End Sub

    'Select employee name and fill DataGrids
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim dt As DataTable = GetTableDataFromServer($"select JobCode, PrimaryJob, PayRate, EffectiveDate, ModDate from iris.dbo.tblEmployeesJobs where EmployeeID=(select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "' )")
            Me.DataGridView1.DataSource = dt.DefaultView

            Dim dt2 As DataTable = GetTableDataFromServer($"select RecordID, EmployeeID, ClockIn, ClockInType, ClockOut, ClockOutType, JobCode, Rate, DelFlag from iris.dbo.tblEmployeesHours where employeeID=(select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "') order by ClockIn Desc")
            Me.DataGridView2.DataSource = dt2.DefaultView

            'Set no used columns to be non-editable
            DataGridView2.Columns(0).ReadOnly = True
            DataGridView2.Columns(1).ReadOnly = True
            DataGridView2.Columns(8).ReadOnly = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Delete Record
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Try
            If Me.DataGridView2.SelectedRows.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(0).Value)
                ExecuteCmdToServer(VarString:="delete from iris.dbo.tblEmployeesHours where recordID=" & id & "")

                'resfresh datagrid data
                Dim dt2 As DataTable = GetTableDataFromServer($"select RecordID, EmployeeID, ClockIn, ClockInType, ClockOut, ClockOutType, JobCode, Rate, DelFlag from iris.dbo.tblEmployeesHours where employeeID=(select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "') order by ClockIn Desc")
                Me.DataGridView2.DataSource = dt2.DefaultView

                ' Set the not used columns to be non-editable
                DataGridView2.Columns(0).ReadOnly = True
                DataGridView2.Columns(1).ReadOnly = True
                DataGridView2.Columns(8).ReadOnly = True

            Else
                MsgBox("Select one row to delete")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Edit Record Button Event
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Try
            If Me.DataGridView2.SelectedRows.Count > 0 Then

                'Get recordID#
                Dim id As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(0).Value)

                'Get Clock In/Break In
                Dim ClockIn As Date = DataGridView2.SelectedRows(0).Cells(2).Value.ToString

                'Get Clock in/break in type
                Dim ClockInType As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(3).Value)

                'Get Clock Out/Break Out type
                Dim ClockOutType As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(5).Value)

                'Get Jobcode
                Dim JobCode As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(6).Value)

                'Get Rate
                Dim Rate As Double = DataGridView2.SelectedRows(0).Cells(7).Value

                'Execute Update command
                If DataGridView2.SelectedRows(0).Cells(4).Value.ToString = "" Then
                    ExecuteCmdToServer(VarString:="update iris.dbo.tblEmployeesHours set ClockIn='" & ClockIn & "', ClockInType=" & ClockInType & ", ClockOut=NULL, ClockOutType=" & ClockOutType & ", JobCode=" & JobCode & ", Rate=" & Rate & " where RecordID=" & id & "")
                Else
                    'Get clock out/Break out time
                    Dim ClockOut As Date = DataGridView2.SelectedRows(0).Cells(4).Value.ToString
                    ExecuteCmdToServer(VarString:="update iris.dbo.tblEmployeesHours set ClockIn='" & ClockIn & "', ClockInType=" & ClockInType & ", ClockOut='" & ClockOut & "', ClockOutType=" & ClockOutType & ", JobCode=" & JobCode & ", Rate=" & Rate & " where RecordID=" & id & "")
                End If


                'Refresh datagrid data
                Dim dt2 As DataTable = GetTableDataFromServer($"select RecordID, EmployeeID, ClockIn, ClockInType, ClockOut, ClockOutType, JobCode, Rate, DelFlag from iris.dbo.tblEmployeesHours where employeeID=(select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "') order by ClockIn Desc")
                Me.DataGridView2.DataSource = dt2.DefaultView

                ' Set not usable columns to be non-editable
                DataGridView2.Columns(0).ReadOnly = True
                DataGridView2.Columns(1).ReadOnly = True
                DataGridView2.Columns(8).ReadOnly = True

            Else
                MsgBox("Select one row to edit")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Make sure entered data is correct format")
        End Try
    End Sub

    'Add record Buton
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Try
            If Me.ComboBox1.SelectedItem.ToString <> "" And Cmb_ClockInBreakIn.SelectedItem.ToString <> "" And Cmb_ClockOutBreakOut.SelectedItem.ToString <> "" And Txt_JobCode.Text <> "" And Txt_Rate.Text <> "" Then

                'Get RecordID to insert
                Dim RID As DataTable = GetTableDataFromServer("select max(RecordID)+1 from iris.dbo.tblEmployeesHours")
                Dim RecordID As Integer
                If RID Is Nothing Then
                    RecordID = 1
                Else
                    RecordID = Convert.ToInt32(RID.Rows(0)(0))
                End If

                'Get EmployeeID#
                Dim UID As DataTable = GetTableDataFromServer("select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "'")
                Dim EmployeeID As Integer = Convert.ToInt32(UID.Rows(0)(0))

                'Get Clock in/Break in
                Dim ClockIn As Date = Me.Dtp_ClockInBreakIn.Value.ToString

                'Get clock In Type
                Dim ClockInType As Integer
                Select Case Me.Cmb_ClockInBreakIn.SelectedItem
                    Case "Clock In"
                        ClockInType = 1
                    Case "Break In"
                        ClockInType = 3
                End Select

                'Get clock Out/Break Out
                Dim ClockOut As Date
                Dim ClockOutType As Integer
                Select Case Me.Cmb_ClockOutBreakOut.SelectedItem
                    Case "Clock Out"
                        ClockOut = Dtp_ClockOutBreakOut.Value.ToString
                        ClockOutType = 2
                    Case "Break Out"
                        ClockOut = Dtp_ClockOutBreakOut.Value.ToString
                        ClockOutType = 4
                    Case "NO"
                        ClockOutType = 0
                End Select

                'Get Jobcode
                Dim JobCode As Integer = Me.Txt_JobCode.Text

                'Get Rate
                Dim Rate As Double = Me.Txt_Rate.Text

                'Insert Command
                If Me.Cmb_ClockOutBreakOut.SelectedItem = "NO" Then
                    ExecuteCmdToServer(VarString:="insert into iris.dbo.tblEmployeesHours (RecordID, employeeID, ClockIn, ClockInType, ClockOutType, JobCode, Rate, DelFlag) values(" & RecordID & "," & EmployeeID & ",'" & ClockIn & "', " & ClockInType & ", " & ClockOutType & ", " & JobCode & ", " & Rate & ", 0)")
                Else
                    ExecuteCmdToServer(VarString:="insert into iris.dbo.tblEmployeesHours (RecordID, employeeID, ClockIn, ClockInType, ClockOut, ClockOutType, JobCode, Rate, DelFlag) values(" & RecordID & "," & EmployeeID & ",'" & ClockIn & "', " & ClockInType & ", '" & ClockOut & "', " & ClockOutType & ", " & JobCode & ", " & Rate & ", 0)")
                End If


                'Refresh datagrid data
                Dim dt2 As DataTable = GetTableDataFromServer($"select RecordID, EmployeeID, ClockIn, ClockInType, ClockOut, ClockOutType, JobCode, Rate, DelFlag from iris.dbo.tblEmployeesHours where employeeID=(select EmployeeID from iris.dbo.tblemployees where FullName='" & Me.ComboBox1.Text.ToString & "') order by ClockIn Desc")
                Me.DataGridView2.DataSource = dt2.DefaultView

                'Set not used columns to be non-editable
                DataGridView2.Columns(0).ReadOnly = True
                DataGridView2.Columns(1).ReadOnly = True
                DataGridView2.Columns(8).ReadOnly = True

            Else
                MsgBox("Fill all the fields!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class