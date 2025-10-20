<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvTran_Delete
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
        ComboBoxInvTranType = New ComboBox()
        DateTimePickerInvTranDate = New DateTimePicker()
        Label3 = New Label()
        DelPCB = New Button()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 15)
        Label4.TabIndex = 24
        Label4.Text = "Inventory Transaction Type"
        ' 
        ' ComboBoxInvTranType
        ' 
        ComboBoxInvTranType.AccessibleName = ""
        ComboBoxInvTranType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxInvTranType.FormattingEnabled = True
        ComboBoxInvTranType.Items.AddRange(New Object() {"Physical Count", "Raw Waste", "Transfer In", "Transfer Out"})
        ComboBoxInvTranType.Location = New Point(12, 83)
        ComboBoxInvTranType.Name = "ComboBoxInvTranType"
        ComboBoxInvTranType.Size = New Size(219, 23)
        ComboBoxInvTranType.TabIndex = 23
        ' 
        ' DateTimePickerInvTranDate
        ' 
        DateTimePickerInvTranDate.Location = New Point(12, 27)
        DateTimePickerInvTranDate.Name = "DateTimePickerInvTranDate"
        DateTimePickerInvTranDate.Size = New Size(219, 23)
        DateTimePickerInvTranDate.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 15)
        Label3.TabIndex = 21
        Label3.Text = "Inventory Transaction Date"
        ' 
        ' DelPCB
        ' 
        DelPCB.Location = New Point(12, 114)
        DelPCB.Name = "DelPCB"
        DelPCB.Size = New Size(219, 25)
        DelPCB.TabIndex = 20
        DelPCB.Text = "Delete Transaction"
        DelPCB.UseVisualStyleBackColor = True
        ' 
        ' InvTran_Delete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(243, 151)
        Controls.Add(Label4)
        Controls.Add(ComboBoxInvTranType)
        Controls.Add(DateTimePickerInvTranDate)
        Controls.Add(Label3)
        Controls.Add(DelPCB)
        Name = "InvTran_Delete"
        Text = "Delete inventory transaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxInvTranType As ComboBox
    Friend WithEvents DateTimePickerInvTranDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DelPCB As Button
End Class
