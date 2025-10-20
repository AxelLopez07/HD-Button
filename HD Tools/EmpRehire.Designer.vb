<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpRehire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpRehire))
        Label1 = New Label()
        RehireButton = New Button()
        EmpIdText = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Location = New Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 11
        Label1.Text = "Employee ID"
        ' 
        ' RehireButton
        ' 
        RehireButton.Location = New Point(12, 62)
        RehireButton.Name = "RehireButton"
        RehireButton.Size = New Size(192, 50)
        RehireButton.TabIndex = 10
        RehireButton.Text = "Enable Rehire"
        RehireButton.UseVisualStyleBackColor = True
        ' 
        ' EmpIdText
        ' 
        EmpIdText.Location = New Point(12, 32)
        EmpIdText.Name = "EmpIdText"
        EmpIdText.Size = New Size(192, 23)
        EmpIdText.TabIndex = 9
        EmpIdText.TextAlign = HorizontalAlignment.Center
        ' 
        ' EmpRehire
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(216, 124)
        Controls.Add(Label1)
        Controls.Add(RehireButton)
        Controls.Add(EmpIdText)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EmpRehire"
        Text = "Payroll"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RehireButton As Button
    Friend WithEvents EmpIdText As TextBox
End Class
