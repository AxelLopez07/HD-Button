<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoices_Delete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoices_Delete))
        Label1 = New Label()
        EInvId = New Button()
        ExtId = New Button()
        VendId = New Button()
        DelInvoiceB = New Button()
        InvIdT = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        ' 
        ' EInvId
        ' 
        EInvId.Location = New Point(0, 0)
        EInvId.Name = "EInvId"
        EInvId.Size = New Size(75, 23)
        EInvId.TabIndex = 0
        ' 
        ' ExtId
        ' 
        ExtId.Location = New Point(0, 0)
        ExtId.Name = "ExtId"
        ExtId.Size = New Size(75, 23)
        ExtId.TabIndex = 0
        ' 
        ' VendId
        ' 
        VendId.Location = New Point(0, 0)
        VendId.Name = "VendId"
        VendId.Size = New Size(75, 23)
        VendId.TabIndex = 0
        ' 
        ' DelInvoiceB
        ' 
        DelInvoiceB.Location = New Point(12, 59)
        DelInvoiceB.Name = "DelInvoiceB"
        DelInvoiceB.Size = New Size(158, 50)
        DelInvoiceB.TabIndex = 0
        DelInvoiceB.Text = "Delete Invoice"
        DelInvoiceB.UseVisualStyleBackColor = True
        ' 
        ' InvIdT
        ' 
        InvIdT.Location = New Point(12, 27)
        InvIdT.Name = "InvIdT"
        InvIdT.Size = New Size(158, 23)
        InvIdT.TabIndex = 5
        InvIdT.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 6
        Label2.Text = "Invoice ID"
        ' 
        ' Invoices_Delete
        ' 
        ClientSize = New Size(182, 121)
        Controls.Add(Label2)
        Controls.Add(InvIdT)
        Controls.Add(DelInvoiceB)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Invoices_Delete"
        Text = "Invoices and Transactions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EInvId As Button
    Friend WithEvents ExtId As Button
    Friend WithEvents VendId As Button
    Friend WithEvents DelInvoiceB As Button
    Friend WithEvents InvIdT As TextBox
    Friend WithEvents Label2 As Label
End Class
