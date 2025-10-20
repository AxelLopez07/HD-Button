<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvTran_UpdateDate
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
        ChangeDB = New Button()
        Label4 = New Label()
        ComboBoxInvTranType = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        DateTimePickerInvDate_New = New DateTimePicker()
        DateTimePickerInvDate_Old = New DateTimePicker()
        SuspendLayout()
        ' 
        ' ChangeDB
        ' 
        ChangeDB.Location = New Point(12, 161)
        ChangeDB.Name = "ChangeDB"
        ChangeDB.Size = New Size(218, 25)
        ChangeDB.TabIndex = 24
        ChangeDB.Text = "Update Transaction Date"
        ChangeDB.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 15)
        Label4.TabIndex = 30
        Label4.Text = "Inventory Transaction Type"
        ' 
        ' ComboBoxInvTranType
        ' 
        ComboBoxInvTranType.AccessibleName = ""
        ComboBoxInvTranType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxInvTranType.FormattingEnabled = True
        ComboBoxInvTranType.Items.AddRange(New Object() {"Physical Count", "Raw Waste", "Transfer In", "Transfer Out"})
        ComboBoxInvTranType.Location = New Point(12, 132)
        ComboBoxInvTranType.Name = "ComboBoxInvTranType"
        ComboBoxInvTranType.Size = New Size(218, 23)
        ComboBoxInvTranType.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 15)
        Label6.TabIndex = 36
        Label6.Text = "New Inventory Transaction Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 15)
        Label5.TabIndex = 35
        Label5.Text = "Actual Inventory Transaction Date"
        ' 
        ' DateTimePickerInvDate_New
        ' 
        DateTimePickerInvDate_New.Location = New Point(12, 79)
        DateTimePickerInvDate_New.Name = "DateTimePickerInvDate_New"
        DateTimePickerInvDate_New.Size = New Size(215, 23)
        DateTimePickerInvDate_New.TabIndex = 34
        ' 
        ' DateTimePickerInvDate_Old
        ' 
        DateTimePickerInvDate_Old.Location = New Point(12, 27)
        DateTimePickerInvDate_Old.Name = "DateTimePickerInvDate_Old"
        DateTimePickerInvDate_Old.Size = New Size(215, 23)
        DateTimePickerInvDate_Old.TabIndex = 33
        ' 
        ' InvTran_UpdateDate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(242, 198)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DateTimePickerInvDate_New)
        Controls.Add(DateTimePickerInvDate_Old)
        Controls.Add(Label4)
        Controls.Add(ComboBoxInvTranType)
        Controls.Add(ChangeDB)
        Name = "InvTran_UpdateDate"
        Text = "InvTran_UpdateDate"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ChangeDB As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxInvTranType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerInvDate_New As DateTimePicker
    Friend WithEvents DateTimePickerInvDate_Old As DateTimePicker
End Class
