<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drawers_Close
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
        Label2 = New Label()
        Label1 = New Label()
        ButtonCloseDrawer = New Button()
        TextBoxDrawerNumber = New TextBox()
        DateTimePickerClose = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 19)
        Label2.TabIndex = 9
        Label2.Text = "Closing Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 17)
        Label1.TabIndex = 8
        Label1.Text = "Drawer Number"
        ' 
        ' ButtonCloseDrawer
        ' 
        ButtonCloseDrawer.Location = New Point(12, 108)
        ButtonCloseDrawer.Name = "ButtonCloseDrawer"
        ButtonCloseDrawer.Size = New Size(215, 57)
        ButtonCloseDrawer.TabIndex = 7
        ButtonCloseDrawer.Text = "Close Drawer"
        ButtonCloseDrawer.UseVisualStyleBackColor = True
        ' 
        ' TextBoxDrawerNumber
        ' 
        TextBoxDrawerNumber.Location = New Point(12, 29)
        TextBoxDrawerNumber.Name = "TextBoxDrawerNumber"
        TextBoxDrawerNumber.Size = New Size(215, 23)
        TextBoxDrawerNumber.TabIndex = 6
        TextBoxDrawerNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' DateTimePickerClose
        ' 
        DateTimePickerClose.Location = New Point(12, 79)
        DateTimePickerClose.Name = "DateTimePickerClose"
        DateTimePickerClose.Size = New Size(215, 23)
        DateTimePickerClose.TabIndex = 5
        ' 
        ' Drawer_Close
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(239, 177)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonCloseDrawer)
        Controls.Add(TextBoxDrawerNumber)
        Controls.Add(DateTimePickerClose)
        Name = "Drawer_Close"
        Text = "Closing Drawers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseDrawer As Button
    Friend WithEvents TextBoxDrawerNumber As TextBox
    Friend WithEvents DateTimePickerClose As DateTimePicker
End Class
