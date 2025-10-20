<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpHours
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        DataGridView2 = New DataGridView()
        Label3 = New Label()
        Btn_Delete = New Button()
        Btn_Edit = New Button()
        Btn_Add = New Button()
        Dtp_ClockInBreakIn = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Cmb_ClockInBreakIn = New ComboBox()
        Label6 = New Label()
        Cmb_ClockOutBreakOut = New ComboBox()
        Label7 = New Label()
        Txt_JobCode = New TextBox()
        Txt_Rate = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Dtp_ClockOutBreakOut = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 71)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(559, 86)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 3
        Label1.Text = "Employees:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(271, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 5
        Label2.Text = "Employee job(s)"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToOrderColumns = True
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView2.Location = New Point(12, 178)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(900, 219)
        DataGridView2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 7
        Label3.Text = "Employee Hours"
        ' 
        ' Btn_Delete
        ' 
        Btn_Delete.Location = New Point(12, 403)
        Btn_Delete.Name = "Btn_Delete"
        Btn_Delete.Size = New Size(75, 23)
        Btn_Delete.TabIndex = 8
        Btn_Delete.Text = "Delete"
        Btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.Location = New Point(111, 403)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(75, 23)
        Btn_Edit.TabIndex = 9
        Btn_Edit.Text = "Edit"
        Btn_Edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_Add
        ' 
        Btn_Add.Location = New Point(821, 502)
        Btn_Add.Name = "Btn_Add"
        Btn_Add.Size = New Size(91, 23)
        Btn_Add.TabIndex = 10
        Btn_Add.Text = "Add"
        Btn_Add.UseVisualStyleBackColor = True
        ' 
        ' Dtp_ClockInBreakIn
        ' 
        Dtp_ClockInBreakIn.Location = New Point(12, 503)
        Dtp_ClockInBreakIn.Name = "Dtp_ClockInBreakIn"
        Dtp_ClockInBreakIn.Size = New Size(188, 23)
        Dtp_ClockInBreakIn.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 485)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 12
        Label4.Text = "Clock In/Break In:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(200, 484)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 15)
        Label5.TabIndex = 13
        Label5.Text = "Clock In/Break In Type:"
        ' 
        ' Cmb_ClockInBreakIn
        ' 
        Cmb_ClockInBreakIn.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_ClockInBreakIn.FormattingEnabled = True
        Cmb_ClockInBreakIn.Items.AddRange(New Object() {"Clock In", "Break In"})
        Cmb_ClockInBreakIn.Location = New Point(206, 503)
        Cmb_ClockInBreakIn.Name = "Cmb_ClockInBreakIn"
        Cmb_ClockInBreakIn.Size = New Size(112, 23)
        Cmb_ClockInBreakIn.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(514, 482)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 15)
        Label6.TabIndex = 15
        Label6.Text = "Clock Out/Break Out:"
        ' 
        ' Cmb_ClockOutBreakOut
        ' 
        Cmb_ClockOutBreakOut.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_ClockOutBreakOut.FormattingEnabled = True
        Cmb_ClockOutBreakOut.Items.AddRange(New Object() {"Clock Out", "Break Out", "NO"})
        Cmb_ClockOutBreakOut.Location = New Point(518, 503)
        Cmb_ClockOutBreakOut.Name = "Cmb_ClockOutBreakOut"
        Cmb_ClockOutBreakOut.Size = New Size(112, 23)
        Cmb_ClockOutBreakOut.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(647, 482)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 17
        Label7.Text = "Job Code:"
        ' 
        ' Txt_JobCode
        ' 
        Txt_JobCode.Location = New Point(636, 503)
        Txt_JobCode.Name = "Txt_JobCode"
        Txt_JobCode.Size = New Size(84, 23)
        Txt_JobCode.TabIndex = 18
        ' 
        ' Txt_Rate
        ' 
        Txt_Rate.Location = New Point(726, 503)
        Txt_Rate.Name = "Txt_Rate"
        Txt_Rate.Size = New Size(89, 23)
        Txt_Rate.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(742, 482)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 19
        Label8.Text = "Rate:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(362, 487)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 15)
        Label9.TabIndex = 22
        Label9.Text = "Clock Out/Break Out:"
        ' 
        ' Dtp_ClockOutBreakOut
        ' 
        Dtp_ClockOutBreakOut.Location = New Point(324, 505)
        Dtp_ClockOutBreakOut.Name = "Dtp_ClockOutBreakOut"
        Dtp_ClockOutBreakOut.Size = New Size(188, 23)
        Dtp_ClockOutBreakOut.TabIndex = 21
        ' 
        ' EmpHours
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(944, 630)
        Controls.Add(Label9)
        Controls.Add(Dtp_ClockOutBreakOut)
        Controls.Add(Txt_Rate)
        Controls.Add(Label8)
        Controls.Add(Txt_JobCode)
        Controls.Add(Label7)
        Controls.Add(Cmb_ClockOutBreakOut)
        Controls.Add(Label6)
        Controls.Add(Cmb_ClockInBreakIn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Dtp_ClockInBreakIn)
        Controls.Add(Btn_Add)
        Controls.Add(Btn_Edit)
        Controls.Add(Btn_Delete)
        Controls.Add(Label3)
        Controls.Add(DataGridView2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        MaximizeBox = False
        Name = "EmpHours"
        Text = "Employee Hours"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Dtp_ClockInBreakIn As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cmb_ClockInBreakIn As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmb_ClockOutBreakOut As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_JobCode As TextBox
    Friend WithEvents Txt_Rate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Dtp_ClockOutBreakOut As DateTimePicker
End Class
