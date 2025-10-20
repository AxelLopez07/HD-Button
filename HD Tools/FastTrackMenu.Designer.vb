<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastTrackMenu
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 152)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 64)
        Button1.TabIndex = 0
        Button1.Text = "Create FTTLog windows Task"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 222)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 64)
        Button2.TabIndex = 1
        Button2.Text = "Synchronize FT time with BOC time/hour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 64)
        Button3.TabIndex = 2
        Button3.Text = "Install Fastrack"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 82)
        Button4.Name = "Button4"
        Button4.Size = New Size(114, 64)
        Button4.TabIndex = 3
        Button4.Text = "Install DTIS"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FastTrackMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 336)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "FastTrackMenu"
        Text = "FastTrackMenu"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
