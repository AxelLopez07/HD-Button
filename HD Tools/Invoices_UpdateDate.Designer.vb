<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices_UpdateDate
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
        Label6 = New Label()
        Label5 = New Label()
        DateTimePickerInvDate_New = New DateTimePicker()
        DateTimePickerInvDate_Old = New DateTimePicker()
        UpdInvoiceB = New Button()
        InvId = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 15)
        Label6.TabIndex = 27
        Label6.Text = "New Inventory Transaction Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 15)
        Label5.TabIndex = 26
        Label5.Text = "Actual Inventory Transaction Date"
        ' 
        ' DateTimePickerInvDate_New
        ' 
        DateTimePickerInvDate_New.Location = New Point(12, 79)
        DateTimePickerInvDate_New.Name = "DateTimePickerInvDate_New"
        DateTimePickerInvDate_New.Size = New Size(223, 23)
        DateTimePickerInvDate_New.TabIndex = 25
        ' 
        ' DateTimePickerInvDate_Old
        ' 
        DateTimePickerInvDate_Old.Location = New Point(12, 27)
        DateTimePickerInvDate_Old.Name = "DateTimePickerInvDate_Old"
        DateTimePickerInvDate_Old.Size = New Size(223, 23)
        DateTimePickerInvDate_Old.TabIndex = 24
        ' 
        ' UpdInvoiceB
        ' 
        UpdInvoiceB.Location = New Point(12, 162)
        UpdInvoiceB.Name = "UpdInvoiceB"
        UpdInvoiceB.Size = New Size(223, 25)
        UpdInvoiceB.TabIndex = 28
        UpdInvoiceB.Text = "Update Invoice Date"
        UpdInvoiceB.UseVisualStyleBackColor = True
        ' 
        ' InvId
        ' 
        InvId.Location = New Point(12, 131)
        InvId.Name = "InvId"
        InvId.Size = New Size(223, 23)
        InvId.TabIndex = 29
        InvId.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 30
        Label2.Text = "Invoice ID"
        ' 
        ' Invoices_UpdateDate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(247, 199)
        Controls.Add(Label2)
        Controls.Add(InvId)
        Controls.Add(UpdInvoiceB)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DateTimePickerInvDate_New)
        Controls.Add(DateTimePickerInvDate_Old)
        Name = "Invoices_UpdateDate"
        Text = "Update invoice date"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerInvDate_New As DateTimePicker
    Friend WithEvents DateTimePickerInvDate_Old As DateTimePicker
    Friend WithEvents UpdInvoiceB As Button
    Friend WithEvents InvId As TextBox
    Friend WithEvents Label2 As Label
End Class
