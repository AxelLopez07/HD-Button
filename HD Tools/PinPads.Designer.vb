<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PinPads
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        LPP1_IP = New Label()
        Label2 = New Label()
        LPP2_IP = New Label()
        LPP4_IP = New Label()
        Label4 = New Label()
        LPP5_IP = New Label()
        Label6 = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        Label3 = New Label()
        LTID1 = New Label()
        LTID2 = New Label()
        Label8 = New Label()
        LTID4 = New Label()
        Label10 = New Label()
        LTID5 = New Label()
        Label12 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Timer5 = New Timer(components)
        Timer6 = New Timer(components)
        Timer7 = New Timer(components)
        Timer8 = New Timer(components)
        Timer9 = New Timer(components)
        Button1 = New Button()
        Button2 = New Button()
        Cmb_Registers = New ComboBox()
        Btn_UpdatePinPadIP = New Button()
        Btn_RestartRegister = New Button()
        Txt_PinPadIP = New TextBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        StatusStrip2 = New StatusStrip()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        StatusStrip3 = New StatusStrip()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        StatusStrip4 = New StatusStrip()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        StatusStrip5 = New StatusStrip()
        ToolStripStatusLabel5 = New ToolStripStatusLabel()
        StatusStrip6 = New StatusStrip()
        ToolStripStatusLabel6 = New ToolStripStatusLabel()
        StatusStrip7 = New StatusStrip()
        ToolStripStatusLabel7 = New ToolStripStatusLabel()
        StatusStrip8 = New StatusStrip()
        ToolStripStatusLabel8 = New ToolStripStatusLabel()
        StatusStrip9 = New StatusStrip()
        ToolStripStatusLabel9 = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        StatusStrip2.SuspendLayout()
        StatusStrip3.SuspendLayout()
        StatusStrip4.SuspendLayout()
        StatusStrip5.SuspendLayout()
        StatusStrip6.SuspendLayout()
        StatusStrip7.SuspendLayout()
        StatusStrip8.SuspendLayout()
        StatusStrip9.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(14, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 0
        Label1.Text = "SCADevice1"
        ' 
        ' LPP1_IP
        ' 
        LPP1_IP.AutoSize = True
        LPP1_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LPP1_IP.Location = New Point(14, 27)
        LPP1_IP.Name = "LPP1_IP"
        LPP1_IP.Size = New Size(73, 17)
        LPP1_IP.TabIndex = 1
        LPP1_IP.Text = "IP Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(14, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 3
        Label2.Text = "SCADevice2"
        ' 
        ' LPP2_IP
        ' 
        LPP2_IP.AutoSize = True
        LPP2_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LPP2_IP.Location = New Point(14, 143)
        LPP2_IP.Name = "LPP2_IP"
        LPP2_IP.Size = New Size(73, 17)
        LPP2_IP.TabIndex = 4
        LPP2_IP.Text = "IP Address"
        ' 
        ' LPP4_IP
        ' 
        LPP4_IP.AutoSize = True
        LPP4_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LPP4_IP.Location = New Point(14, 250)
        LPP4_IP.Name = "LPP4_IP"
        LPP4_IP.Size = New Size(73, 17)
        LPP4_IP.TabIndex = 6
        LPP4_IP.Text = "IP Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(14, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 17)
        Label4.TabIndex = 5
        Label4.Text = "SCADevice4"
        ' 
        ' LPP5_IP
        ' 
        LPP5_IP.AutoSize = True
        LPP5_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LPP5_IP.Location = New Point(14, 359)
        LPP5_IP.Name = "LPP5_IP"
        LPP5_IP.Size = New Size(73, 17)
        LPP5_IP.TabIndex = 10
        LPP5_IP.Text = "IP Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(14, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 17)
        Label6.TabIndex = 9
        Label6.Text = "SCADevice5"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 1000
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(106, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 17)
        Label3.TabIndex = 12
        Label3.Text = "Terminal ID#"
        ' 
        ' LTID1
        ' 
        LTID1.AutoSize = True
        LTID1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LTID1.Location = New Point(199, 10)
        LTID1.Name = "LTID1"
        LTID1.Size = New Size(80, 17)
        LTID1.TabIndex = 13
        LTID1.Text = "SCADevice1"
        ' 
        ' LTID2
        ' 
        LTID2.AutoSize = True
        LTID2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LTID2.Location = New Point(199, 126)
        LTID2.Name = "LTID2"
        LTID2.Size = New Size(80, 17)
        LTID2.TabIndex = 15
        LTID2.Text = "SCADevice2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(106, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 17)
        Label8.TabIndex = 14
        Label8.Text = "Terminal ID#"
        ' 
        ' LTID4
        ' 
        LTID4.AutoSize = True
        LTID4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LTID4.Location = New Point(199, 233)
        LTID4.Name = "LTID4"
        LTID4.Size = New Size(80, 17)
        LTID4.TabIndex = 17
        LTID4.Text = "SCADevice4"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(106, 233)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 17)
        Label10.TabIndex = 16
        Label10.Text = "Terminal ID#"
        ' 
        ' LTID5
        ' 
        LTID5.AutoSize = True
        LTID5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        LTID5.Location = New Point(199, 342)
        LTID5.Name = "LTID5"
        LTID5.Size = New Size(80, 17)
        LTID5.TabIndex = 19
        LTID5.Text = "SCADevice5"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(106, 342)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 17)
        Label12.TabIndex = 18
        Label12.Text = "Terminal ID#"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(300, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 17)
        Label5.TabIndex = 20
        Label5.Text = "Register1 (192.168.1.101)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(300, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 17)
        Label7.TabIndex = 21
        Label7.Text = "Register2 (192.168.1.102)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(300, 160)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 17)
        Label9.TabIndex = 22
        Label9.Text = "Register3 (192.168.1.103)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(300, 233)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 17)
        Label11.TabIndex = 23
        Label11.Text = "Register4 (192.168.1.104)"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(300, 302)
        Label13.Name = "Label13"
        Label13.Size = New Size(161, 17)
        Label13.TabIndex = 24
        Label13.Text = "Register5 (192.168.1.105)"
        ' 
        ' Timer5
        ' 
        Timer5.Interval = 1000
        ' 
        ' Timer6
        ' 
        Timer6.Interval = 1000
        ' 
        ' Timer7
        ' 
        Timer7.Interval = 1000
        ' 
        ' Timer8
        ' 
        Timer8.Interval = 1000
        ' 
        ' Timer9
        ' 
        Timer9.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(412, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 58)
        Button1.TabIndex = 30
        Button1.Text = "Reset ping"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(300, 376)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 58)
        Button2.TabIndex = 31
        Button2.Text = "Get TIDs"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Cmb_Registers
        ' 
        Cmb_Registers.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_Registers.FormattingEnabled = True
        Cmb_Registers.Items.AddRange(New Object() {"Register #1", "Register #2", "Register #4"})
        Cmb_Registers.Location = New Point(12, 432)
        Cmb_Registers.Name = "Cmb_Registers"
        Cmb_Registers.Size = New Size(148, 25)
        Cmb_Registers.TabIndex = 32
        ' 
        ' Btn_UpdatePinPadIP
        ' 
        Btn_UpdatePinPadIP.Location = New Point(14, 496)
        Btn_UpdatePinPadIP.Name = "Btn_UpdatePinPadIP"
        Btn_UpdatePinPadIP.Size = New Size(106, 58)
        Btn_UpdatePinPadIP.TabIndex = 33
        Btn_UpdatePinPadIP.Text = "Update Pin Pad IP"
        Btn_UpdatePinPadIP.UseVisualStyleBackColor = True
        ' 
        ' Btn_RestartRegister
        ' 
        Btn_RestartRegister.Location = New Point(126, 496)
        Btn_RestartRegister.Name = "Btn_RestartRegister"
        Btn_RestartRegister.Size = New Size(106, 58)
        Btn_RestartRegister.TabIndex = 34
        Btn_RestartRegister.Text = "Restart Register"
        Btn_RestartRegister.UseVisualStyleBackColor = True
        ' 
        ' Txt_PinPadIP
        ' 
        Txt_PinPadIP.Location = New Point(14, 465)
        Txt_PinPadIP.Name = "Txt_PinPadIP"
        Txt_PinPadIP.Size = New Size(148, 25)
        Txt_PinPadIP.TabIndex = 35
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(14, 44)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(159, 22)
        StatusStrip1.TabIndex = 36
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(142, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' StatusStrip2
        ' 
        StatusStrip2.Dock = DockStyle.None
        StatusStrip2.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel2})
        StatusStrip2.Location = New Point(14, 160)
        StatusStrip2.Name = "StatusStrip2"
        StatusStrip2.Size = New Size(159, 22)
        StatusStrip2.TabIndex = 37
        StatusStrip2.Text = "StatusStrip2"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(142, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' StatusStrip3
        ' 
        StatusStrip3.Dock = DockStyle.None
        StatusStrip3.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel3})
        StatusStrip3.Location = New Point(14, 267)
        StatusStrip3.Name = "StatusStrip3"
        StatusStrip3.Size = New Size(159, 22)
        StatusStrip3.TabIndex = 38
        StatusStrip3.Text = "StatusStrip3"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(142, 17)
        ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        ' 
        ' StatusStrip4
        ' 
        StatusStrip4.Dock = DockStyle.None
        StatusStrip4.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel4})
        StatusStrip4.Location = New Point(14, 376)
        StatusStrip4.Name = "StatusStrip4"
        StatusStrip4.Size = New Size(159, 22)
        StatusStrip4.TabIndex = 39
        StatusStrip4.Text = "StatusStrip4"
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(142, 17)
        ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        ' 
        ' StatusStrip5
        ' 
        StatusStrip5.Dock = DockStyle.None
        StatusStrip5.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel5})
        StatusStrip5.Location = New Point(300, 27)
        StatusStrip5.Name = "StatusStrip5"
        StatusStrip5.Size = New Size(159, 22)
        StatusStrip5.TabIndex = 40
        StatusStrip5.Text = "StatusStrip5"
        ' 
        ' ToolStripStatusLabel5
        ' 
        ToolStripStatusLabel5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        ToolStripStatusLabel5.Size = New Size(142, 17)
        ToolStripStatusLabel5.Text = "ToolStripStatusLabel5"
        ' 
        ' StatusStrip6
        ' 
        StatusStrip6.Dock = DockStyle.None
        StatusStrip6.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel6})
        StatusStrip6.Location = New Point(300, 102)
        StatusStrip6.Name = "StatusStrip6"
        StatusStrip6.Size = New Size(159, 22)
        StatusStrip6.TabIndex = 41
        StatusStrip6.Text = "StatusStrip6"
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(142, 17)
        ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        ' 
        ' StatusStrip7
        ' 
        StatusStrip7.Dock = DockStyle.None
        StatusStrip7.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel7})
        StatusStrip7.Location = New Point(300, 177)
        StatusStrip7.Name = "StatusStrip7"
        StatusStrip7.Size = New Size(159, 22)
        StatusStrip7.TabIndex = 42
        StatusStrip7.Text = "StatusStrip7"
        ' 
        ' ToolStripStatusLabel7
        ' 
        ToolStripStatusLabel7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        ToolStripStatusLabel7.Size = New Size(142, 17)
        ToolStripStatusLabel7.Text = "ToolStripStatusLabel7"
        ' 
        ' StatusStrip8
        ' 
        StatusStrip8.Dock = DockStyle.None
        StatusStrip8.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel8})
        StatusStrip8.Location = New Point(300, 250)
        StatusStrip8.Name = "StatusStrip8"
        StatusStrip8.Size = New Size(159, 22)
        StatusStrip8.TabIndex = 43
        StatusStrip8.Text = "StatusStrip8"
        ' 
        ' ToolStripStatusLabel8
        ' 
        ToolStripStatusLabel8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        ToolStripStatusLabel8.Size = New Size(142, 17)
        ToolStripStatusLabel8.Text = "ToolStripStatusLabel8"
        ' 
        ' StatusStrip9
        ' 
        StatusStrip9.Dock = DockStyle.None
        StatusStrip9.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel9})
        StatusStrip9.Location = New Point(300, 319)
        StatusStrip9.Name = "StatusStrip9"
        StatusStrip9.Size = New Size(159, 22)
        StatusStrip9.TabIndex = 44
        StatusStrip9.Text = "StatusStrip9"
        ' 
        ' ToolStripStatusLabel9
        ' 
        ToolStripStatusLabel9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        ToolStripStatusLabel9.Size = New Size(142, 17)
        ToolStripStatusLabel9.Text = "ToolStripStatusLabel9"
        ' 
        ' PinPads
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 586)
        Controls.Add(StatusStrip9)
        Controls.Add(StatusStrip8)
        Controls.Add(StatusStrip7)
        Controls.Add(StatusStrip6)
        Controls.Add(StatusStrip5)
        Controls.Add(StatusStrip4)
        Controls.Add(StatusStrip3)
        Controls.Add(StatusStrip2)
        Controls.Add(StatusStrip1)
        Controls.Add(Txt_PinPadIP)
        Controls.Add(Btn_RestartRegister)
        Controls.Add(Btn_UpdatePinPadIP)
        Controls.Add(Cmb_Registers)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(LTID5)
        Controls.Add(Label12)
        Controls.Add(LTID4)
        Controls.Add(Label10)
        Controls.Add(LTID2)
        Controls.Add(Label8)
        Controls.Add(LTID1)
        Controls.Add(Label3)
        Controls.Add(LPP5_IP)
        Controls.Add(Label6)
        Controls.Add(LPP4_IP)
        Controls.Add(Label4)
        Controls.Add(LPP2_IP)
        Controls.Add(Label2)
        Controls.Add(LPP1_IP)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Name = "PinPads"
        Text = "PinPads"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        StatusStrip2.ResumeLayout(False)
        StatusStrip2.PerformLayout()
        StatusStrip3.ResumeLayout(False)
        StatusStrip3.PerformLayout()
        StatusStrip4.ResumeLayout(False)
        StatusStrip4.PerformLayout()
        StatusStrip5.ResumeLayout(False)
        StatusStrip5.PerformLayout()
        StatusStrip6.ResumeLayout(False)
        StatusStrip6.PerformLayout()
        StatusStrip7.ResumeLayout(False)
        StatusStrip7.PerformLayout()
        StatusStrip8.ResumeLayout(False)
        StatusStrip8.PerformLayout()
        StatusStrip9.ResumeLayout(False)
        StatusStrip9.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LPP1_IP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LPP2_IP As Label
    Friend WithEvents LPP4_IP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LPP5_IP As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents LTID1 As Label
    Friend WithEvents LTID2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LTID4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LTID5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Cmb_Registers As ComboBox
    Friend WithEvents Btn_UpdatePinPadIP As Button
    Friend WithEvents Btn_RestartRegister As Button
    Friend WithEvents Txt_PinPadIP As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StatusStrip4 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents StatusStrip5 As StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents StatusStrip6 As StatusStrip
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents StatusStrip7 As StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents StatusStrip8 As StatusStrip
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents StatusStrip9 As StatusStrip
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
End Class
