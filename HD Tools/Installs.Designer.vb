<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Installs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Installs))
        DMB = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        StoreNumB = New Button()
        TextBox2 = New TextBox()
        Button1 = New Button()
        RBUpdatesCarls = New RadioButton()
        RBUpdatesHardees = New RadioButton()
        GroupBox1 = New GroupBox()
        CB_R365_SC = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        CB_Start_MSSQLXSIRIS_Service = New CheckBox()
        CB_FTTLogTask = New CheckBox()
        CB_DTIS = New CheckBox()
        CB_FastTrack = New CheckBox()
        CB_Depletions = New CheckBox()
        CB_GC = New CheckBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CB_WinSCP = New CheckBox()
        RadioButton1 = New RadioButton()
        CB_XenialSync = New CheckBox()
        CB_Loyalty = New CheckBox()
        CB_OLO = New CheckBox()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        VScrollBar1 = New VScrollBar()
        CB_R365_SS = New CheckBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DMB
        ' 
        DMB.Location = New Point(54, 83)
        DMB.Name = "DMB"
        DMB.Size = New Size(150, 45)
        DMB.TabIndex = 0
        DMB.Text = "DMB Install"
        DMB.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(54, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 29)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(6, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 20)
        Label1.TabIndex = 2
        Label1.Text = "Main DMB controller box IP Address"
        ' 
        ' StoreNumB
        ' 
        StoreNumB.Location = New Point(17, 83)
        StoreNumB.Name = "StoreNumB"
        StoreNumB.Size = New Size(136, 41)
        StoreNumB.TabIndex = 3
        StoreNumB.Text = "Change Store Number"
        StoreNumB.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(17, 48)
        TextBox2.MaxLength = 7
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 29)
        TextBox2.TabIndex = 4
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(129, 578)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 50)
        Button1.TabIndex = 6
        Button1.Text = "Install"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RBUpdatesCarls
        ' 
        RBUpdatesCarls.AutoSize = True
        RBUpdatesCarls.BackColor = SystemColors.ControlDark
        RBUpdatesCarls.Font = New Font("Segoe UI", 11.25F)
        RBUpdatesCarls.Location = New Point(5, 28)
        RBUpdatesCarls.Name = "RBUpdatesCarls"
        RBUpdatesCarls.Size = New Size(197, 24)
        RBUpdatesCarls.TabIndex = 10
        RBUpdatesCarls.TabStop = True
        RBUpdatesCarls.Text = "Updates and Files Carl's Jr"
        RBUpdatesCarls.UseVisualStyleBackColor = False
        ' 
        ' RBUpdatesHardees
        ' 
        RBUpdatesHardees.AutoSize = True
        RBUpdatesHardees.BackColor = SystemColors.ControlDark
        RBUpdatesHardees.Font = New Font("Segoe UI", 11.25F)
        RBUpdatesHardees.Location = New Point(6, 90)
        RBUpdatesHardees.Name = "RBUpdatesHardees"
        RBUpdatesHardees.Size = New Size(206, 24)
        RBUpdatesHardees.TabIndex = 11
        RBUpdatesHardees.TabStop = True
        RBUpdatesHardees.Text = "Updates and Files Hardee's"
        RBUpdatesHardees.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDark
        GroupBox1.Controls.Add(CB_R365_SS)
        GroupBox1.Controls.Add(CB_R365_SC)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(CB_Start_MSSQLXSIRIS_Service)
        GroupBox1.Controls.Add(CB_FTTLogTask)
        GroupBox1.Controls.Add(CB_DTIS)
        GroupBox1.Controls.Add(CB_FastTrack)
        GroupBox1.Controls.Add(CB_Depletions)
        GroupBox1.Controls.Add(CB_GC)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(CB_WinSCP)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(CB_XenialSync)
        GroupBox1.Controls.Add(CB_Loyalty)
        GroupBox1.Controls.Add(CB_OLO)
        GroupBox1.Controls.Add(RBUpdatesCarls)
        GroupBox1.Controls.Add(RBUpdatesHardees)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox1.Location = New Point(18, 163)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(486, 650)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Updates and Installs"
        ' 
        ' CB_R365_SC
        ' 
        CB_R365_SC.AutoSize = True
        CB_R365_SC.Font = New Font("Segoe UI", 11.25F)
        CB_R365_SC.Location = New Point(6, 506)
        CB_R365_SC.Name = "CB_R365_SC"
        CB_R365_SC.Size = New Size(165, 24)
        CB_R365_SC.TabIndex = 28
        CB_R365_SC.Text = "R365 Carl's Jr version"
        CB_R365_SC.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(430, 21)
        Label5.TabIndex = 27
        Label5.Text = "----------------------------------------------------------------------"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(430, 21)
        Label4.TabIndex = 26
        Label4.Text = "----------------------------------------------------------------------"
        ' 
        ' CB_Start_MSSQLXSIRIS_Service
        ' 
        CB_Start_MSSQLXSIRIS_Service.AutoSize = True
        CB_Start_MSSQLXSIRIS_Service.Font = New Font("Segoe UI", 11.25F)
        CB_Start_MSSQLXSIRIS_Service.Location = New Point(5, 476)
        CB_Start_MSSQLXSIRIS_Service.Name = "CB_Start_MSSQLXSIRIS_Service"
        CB_Start_MSSQLXSIRIS_Service.Size = New Size(211, 24)
        CB_Start_MSSQLXSIRIS_Service.TabIndex = 25
        CB_Start_MSSQLXSIRIS_Service.Text = "Start MSSQL$XSIRIS Service"
        CB_Start_MSSQLXSIRIS_Service.UseVisualStyleBackColor = True
        ' 
        ' CB_FTTLogTask
        ' 
        CB_FTTLogTask.AutoSize = True
        CB_FTTLogTask.Font = New Font("Segoe UI", 11.25F)
        CB_FTTLogTask.Location = New Point(6, 446)
        CB_FTTLogTask.Name = "CB_FTTLogTask"
        CB_FTTLogTask.Size = New Size(239, 24)
        CB_FTTLogTask.TabIndex = 24
        CB_FTTLogTask.Text = "Fast Track FTTLog Windows Task"
        CB_FTTLogTask.UseVisualStyleBackColor = True
        ' 
        ' CB_DTIS
        ' 
        CB_DTIS.AutoSize = True
        CB_DTIS.Font = New Font("Segoe UI", 11.25F)
        CB_DTIS.Location = New Point(6, 416)
        CB_DTIS.Name = "CB_DTIS"
        CB_DTIS.Size = New Size(58, 24)
        CB_DTIS.TabIndex = 23
        CB_DTIS.Text = "DTIS"
        CB_DTIS.UseVisualStyleBackColor = True
        ' 
        ' CB_FastTrack
        ' 
        CB_FastTrack.AutoSize = True
        CB_FastTrack.Font = New Font("Segoe UI", 11.25F)
        CB_FastTrack.Location = New Point(6, 386)
        CB_FastTrack.Name = "CB_FastTrack"
        CB_FastTrack.Size = New Size(91, 24)
        CB_FastTrack.TabIndex = 22
        CB_FastTrack.Text = "Fast Track"
        CB_FastTrack.UseVisualStyleBackColor = True
        ' 
        ' CB_Depletions
        ' 
        CB_Depletions.AutoSize = True
        CB_Depletions.Font = New Font("Segoe UI", 11.25F)
        CB_Depletions.Location = New Point(6, 356)
        CB_Depletions.Name = "CB_Depletions"
        CB_Depletions.Size = New Size(100, 24)
        CB_Depletions.TabIndex = 21
        CB_Depletions.Text = "Depletions"
        CB_Depletions.UseVisualStyleBackColor = True
        ' 
        ' CB_GC
        ' 
        CB_GC.AutoSize = True
        CB_GC.Font = New Font("Segoe UI", 11.25F)
        CB_GC.Location = New Point(6, 326)
        CB_GC.Name = "CB_GC"
        CB_GC.Size = New Size(133, 24)
        CB_GC.TabIndex = 20
        CB_GC.Text = "Google Chrome"
        CB_GC.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(430, 21)
        Label3.TabIndex = 19
        Label3.Text = "----------------------------------------------------------------------"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Hardees_Logo
        PictureBox2.Location = New Point(218, 90)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(169, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(218, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' CB_WinSCP
        ' 
        CB_WinSCP.AutoSize = True
        CB_WinSCP.Font = New Font("Segoe UI", 11.25F)
        CB_WinSCP.Location = New Point(6, 296)
        CB_WinSCP.Name = "CB_WinSCP"
        CB_WinSCP.Size = New Size(79, 24)
        CB_WinSCP.TabIndex = 16
        CB_WinSCP.Text = "WinSCP"
        CB_WinSCP.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = SystemColors.ControlDark
        RadioButton1.Font = New Font("Segoe UI", 11.25F)
        RadioButton1.Location = New Point(6, 155)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(166, 24)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "NO updates and files"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' CB_XenialSync
        ' 
        CB_XenialSync.AutoSize = True
        CB_XenialSync.Font = New Font("Segoe UI", 11.25F)
        CB_XenialSync.Location = New Point(6, 266)
        CB_XenialSync.Name = "CB_XenialSync"
        CB_XenialSync.Size = New Size(154, 24)
        CB_XenialSync.TabIndex = 14
        CB_XenialSync.Text = "Xenial Sync Service"
        CB_XenialSync.UseVisualStyleBackColor = True
        ' 
        ' CB_Loyalty
        ' 
        CB_Loyalty.AutoSize = True
        CB_Loyalty.Font = New Font("Segoe UI", 11.25F)
        CB_Loyalty.Location = New Point(6, 236)
        CB_Loyalty.Name = "CB_Loyalty"
        CB_Loyalty.Size = New Size(192, 24)
        CB_Loyalty.TabIndex = 13
        CB_Loyalty.Text = "Xpient Loyalty Controller"
        CB_Loyalty.UseVisualStyleBackColor = True
        ' 
        ' CB_OLO
        ' 
        CB_OLO.AutoSize = True
        CB_OLO.Font = New Font("Segoe UI", 11.25F)
        CB_OLO.Location = New Point(6, 206)
        CB_OLO.Name = "CB_OLO"
        CB_OLO.Size = New Size(250, 24)
        CB_OLO.TabIndex = 12
        CB_OLO.Text = "OLO (for the actual store number)"
        CB_OLO.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ControlDark
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(StoreNumB)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox2.Location = New Point(18, 13)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(189, 144)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "NEW STORE NUMBER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(53, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 16
        Label2.Text = "Store #"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ControlDark
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Controls.Add(DMB)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox3.Location = New Point(241, 13)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(263, 144)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        GroupBox3.Text = "DMB SERVICE"
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(0, 0)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 80)
        VScrollBar1.TabIndex = 16
        ' 
        ' CB_R365_SS
        ' 
        CB_R365_SS.AutoSize = True
        CB_R365_SS.Font = New Font("Segoe UI", 11.25F)
        CB_R365_SS.Location = New Point(7, 536)
        CB_R365_SS.Name = "CB_R365_SS"
        CB_R365_SS.Size = New Size(171, 24)
        CB_R365_SS.TabIndex = 29
        CB_R365_SS.Text = "R365 Hardees version"
        CB_R365_SS.UseVisualStyleBackColor = True
        ' 
        ' Installs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(542, 825)
        Controls.Add(VScrollBar1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Installs"
        Text = "Installs"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents DMB As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StoreNumB As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RBUpdatesCarls As RadioButton
    Friend WithEvents RBUpdatesHardees As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_Loyalty As CheckBox
    Friend WithEvents CB_OLO As CheckBox
    Friend WithEvents CB_XenialSync As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CB_WinSCP As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_GC As CheckBox
    Friend WithEvents CB_Depletions As CheckBox
    Friend WithEvents CB_FastTrack As CheckBox
    Friend WithEvents CB_DTIS As CheckBox
    Friend WithEvents CB_FTTLogTask As CheckBox
    Friend WithEvents CB_Start_MSSQLXSIRIS_Service As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents CB_R365_SC As CheckBox
    Friend WithEvents CB_R365_SS As CheckBox
End Class
