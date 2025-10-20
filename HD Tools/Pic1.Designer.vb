<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pic1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Pic1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ButtonNext = New Button()
        linkLabelclipboard = New LinkLabel()
        ToolTipAlert = New ToolTip(components)
        labelLinkInfo = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, -24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(681, 518)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(402, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 20)
        Label1.TabIndex = 1
        Label1.Text = "^ This is copied in your clipboard"
        ' 
        ' ButtonNext
        ' 
        ButtonNext.Location = New Point(571, 500)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(100, 33)
        ButtonNext.TabIndex = 2
        ButtonNext.Text = "Next Step"
        ButtonNext.UseVisualStyleBackColor = True
        ' 
        ' linkLabelclipboard
        ' 
        linkLabelclipboard.AutoSize = True
        linkLabelclipboard.Location = New Point(166, 521)
        linkLabelclipboard.Name = "linkLabelclipboard"
        linkLabelclipboard.Size = New Size(214, 15)
        linkLabelclipboard.TabIndex = 3
        linkLabelclipboard.TabStop = True
        linkLabelclipboard.Text = "https://starcorp-edm.xenial.com/edm/"
        ' 
        ' labelLinkInfo
        ' 
        labelLinkInfo.AutoSize = True
        labelLinkInfo.Location = New Point(12, 521)
        labelLinkInfo.Name = "labelLinkInfo"
        labelLinkInfo.Size = New Size(148, 15)
        labelLinkInfo.TabIndex = 4
        labelLinkInfo.Text = "Click on the link to copy it:"
        ' 
        ' Pic1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 545)
        Controls.Add(labelLinkInfo)
        Controls.Add(linkLabelclipboard)
        Controls.Add(ButtonNext)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Pic1"
        Text = "Pic1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents linkLabelclipboard As LinkLabel
    Friend WithEvents ToolTipAlert As ToolTip
    Friend WithEvents labelLinkInfo As Label
End Class
