<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registers_CorrectBDate
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
        Label4 = New Label()
        Label3 = New Label()
        ComboBoxRegisters = New ComboBox()
        ButtonCorrectBDay = New Button()
        DateTimePickerBusinessDay = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 17)
        Label4.TabIndex = 47
        Label4.Text = "Business Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 17)
        Label3.TabIndex = 46
        Label3.Text = "Register Number"
        ' 
        ' ComboBoxRegisters
        ' 
        ComboBoxRegisters.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRegisters.FormattingEnabled = True
        ComboBoxRegisters.Items.AddRange(New Object() {"Reg1", "Reg2", "Reg3", "Reg4", "Reg5"})
        ComboBoxRegisters.Location = New Point(12, 29)
        ComboBoxRegisters.Name = "ComboBoxRegisters"
        ComboBoxRegisters.Size = New Size(230, 23)
        ComboBoxRegisters.TabIndex = 45
        ' 
        ' ButtonCorrectBDay
        ' 
        ButtonCorrectBDay.Location = New Point(12, 108)
        ButtonCorrectBDay.Name = "ButtonCorrectBDay"
        ButtonCorrectBDay.Size = New Size(230, 71)
        ButtonCorrectBDay.TabIndex = 44
        ButtonCorrectBDay.Text = "Correct Business Date"
        ButtonCorrectBDay.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerBusinessDay
        ' 
        DateTimePickerBusinessDay.Location = New Point(12, 77)
        DateTimePickerBusinessDay.Name = "DateTimePickerBusinessDay"
        DateTimePickerBusinessDay.Size = New Size(230, 23)
        DateTimePickerBusinessDay.TabIndex = 43
        ' 
        ' Registers_CorrectBDate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(254, 191)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ComboBoxRegisters)
        Controls.Add(ButtonCorrectBDay)
        Controls.Add(DateTimePickerBusinessDay)
        Name = "Registers_CorrectBDate"
        Text = "Registers Business Day"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxRegisters As ComboBox
    Friend WithEvents ButtonCorrectBDay As Button
    Friend WithEvents DateTimePickerBusinessDay As DateTimePicker
End Class
