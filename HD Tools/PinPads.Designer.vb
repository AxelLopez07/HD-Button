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
        LPSCAD1 = New Label()
        Label2 = New Label()
        LPP2_IP = New Label()
        LPP4_IP = New Label()
        Label4 = New Label()
        LPSCAD2 = New Label()
        LPSCAD4 = New Label()
        LPSCAD5 = New Label()
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
        LReg1Ping = New Label()
        LReg2Ping = New Label()
        LReg3Ping = New Label()
        LReg4Ping = New Label()
        LReg5Ping = New Label()
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 0
        Label1.Text = "SCADevice1"
        ' 
        ' LPP1_IP
        ' 
        LPP1_IP.AutoSize = True
        LPP1_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPP1_IP.Location = New Point(14, 27)
        LPP1_IP.Name = "LPP1_IP"
        LPP1_IP.Size = New Size(73, 17)
        LPP1_IP.TabIndex = 1
        LPP1_IP.Text = "IP Address"
        ' 
        ' LPSCAD1
        ' 
        LPSCAD1.AutoSize = True
        LPSCAD1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPSCAD1.Location = New Point(14, 44)
        LPSCAD1.Name = "LPSCAD1"
        LPSCAD1.Size = New Size(86, 17)
        LPSCAD1.TabIndex = 2
        LPSCAD1.Text = "Lose packets"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(14, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 3
        Label2.Text = "SCADevice2"
        ' 
        ' LPP2_IP
        ' 
        LPP2_IP.AutoSize = True
        LPP2_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPP2_IP.Location = New Point(14, 143)
        LPP2_IP.Name = "LPP2_IP"
        LPP2_IP.Size = New Size(73, 17)
        LPP2_IP.TabIndex = 4
        LPP2_IP.Text = "IP Address"
        ' 
        ' LPP4_IP
        ' 
        LPP4_IP.AutoSize = True
        LPP4_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPP4_IP.Location = New Point(14, 250)
        LPP4_IP.Name = "LPP4_IP"
        LPP4_IP.Size = New Size(73, 17)
        LPP4_IP.TabIndex = 6
        LPP4_IP.Text = "IP Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(14, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 17)
        Label4.TabIndex = 5
        Label4.Text = "SCADevice4"
        ' 
        ' LPSCAD2
        ' 
        LPSCAD2.AutoSize = True
        LPSCAD2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPSCAD2.Location = New Point(14, 160)
        LPSCAD2.Name = "LPSCAD2"
        LPSCAD2.Size = New Size(86, 17)
        LPSCAD2.TabIndex = 7
        LPSCAD2.Text = "Lose packets"
        ' 
        ' LPSCAD4
        ' 
        LPSCAD4.AutoSize = True
        LPSCAD4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPSCAD4.Location = New Point(14, 267)
        LPSCAD4.Name = "LPSCAD4"
        LPSCAD4.Size = New Size(86, 17)
        LPSCAD4.TabIndex = 8
        LPSCAD4.Text = "Lose packets"
        ' 
        ' LPSCAD5
        ' 
        LPSCAD5.AutoSize = True
        LPSCAD5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPSCAD5.Location = New Point(14, 376)
        LPSCAD5.Name = "LPSCAD5"
        LPSCAD5.Size = New Size(86, 17)
        LPSCAD5.TabIndex = 11
        LPSCAD5.Text = "Lose packets"
        ' 
        ' LPP5_IP
        ' 
        LPP5_IP.AutoSize = True
        LPP5_IP.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LPP5_IP.Location = New Point(14, 359)
        LPP5_IP.Name = "LPP5_IP"
        LPP5_IP.Size = New Size(73, 17)
        LPP5_IP.TabIndex = 10
        LPP5_IP.Text = "IP Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(106, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 17)
        Label3.TabIndex = 12
        Label3.Text = "Terminal ID#"
        ' 
        ' LTID1
        ' 
        LTID1.AutoSize = True
        LTID1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LTID1.Location = New Point(199, 10)
        LTID1.Name = "LTID1"
        LTID1.Size = New Size(80, 17)
        LTID1.TabIndex = 13
        LTID1.Text = "SCADevice1"
        ' 
        ' LTID2
        ' 
        LTID2.AutoSize = True
        LTID2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LTID2.Location = New Point(199, 126)
        LTID2.Name = "LTID2"
        LTID2.Size = New Size(80, 17)
        LTID2.TabIndex = 15
        LTID2.Text = "SCADevice2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(106, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 17)
        Label8.TabIndex = 14
        Label8.Text = "Terminal ID#"
        ' 
        ' LTID4
        ' 
        LTID4.AutoSize = True
        LTID4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LTID4.Location = New Point(199, 233)
        LTID4.Name = "LTID4"
        LTID4.Size = New Size(80, 17)
        LTID4.TabIndex = 17
        LTID4.Text = "SCADevice4"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(106, 233)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 17)
        Label10.TabIndex = 16
        Label10.Text = "Terminal ID#"
        ' 
        ' LTID5
        ' 
        LTID5.AutoSize = True
        LTID5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LTID5.Location = New Point(199, 342)
        LTID5.Name = "LTID5"
        LTID5.Size = New Size(80, 17)
        LTID5.TabIndex = 19
        LTID5.Text = "SCADevice5"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(106, 342)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 17)
        Label12.TabIndex = 18
        Label12.Text = "Terminal ID#"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(300, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 17)
        Label5.TabIndex = 20
        Label5.Text = "Register1 (192.168.1.101)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(300, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 17)
        Label7.TabIndex = 21
        Label7.Text = "Register2 (192.168.1.102)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(300, 160)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 17)
        Label9.TabIndex = 22
        Label9.Text = "Register3 (192.168.1.103)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(300, 233)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 17)
        Label11.TabIndex = 23
        Label11.Text = "Register4 (192.168.1.104)"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(300, 302)
        Label13.Name = "Label13"
        Label13.Size = New Size(161, 17)
        Label13.TabIndex = 24
        Label13.Text = "Register5 (192.168.1.105)"
        ' 
        ' LReg1Ping
        ' 
        LReg1Ping.AutoSize = True
        LReg1Ping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LReg1Ping.Location = New Point(300, 27)
        LReg1Ping.Name = "LReg1Ping"
        LReg1Ping.Size = New Size(86, 17)
        LReg1Ping.TabIndex = 25
        LReg1Ping.Text = "Lose packets"
        ' 
        ' LReg2Ping
        ' 
        LReg2Ping.AutoSize = True
        LReg2Ping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LReg2Ping.Location = New Point(300, 102)
        LReg2Ping.Name = "LReg2Ping"
        LReg2Ping.Size = New Size(86, 17)
        LReg2Ping.TabIndex = 26
        LReg2Ping.Text = "Lose packets"
        ' 
        ' LReg3Ping
        ' 
        LReg3Ping.AutoSize = True
        LReg3Ping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LReg3Ping.Location = New Point(300, 177)
        LReg3Ping.Name = "LReg3Ping"
        LReg3Ping.Size = New Size(86, 17)
        LReg3Ping.TabIndex = 27
        LReg3Ping.Text = "Lose packets"
        ' 
        ' LReg4Ping
        ' 
        LReg4Ping.AutoSize = True
        LReg4Ping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LReg4Ping.Location = New Point(300, 250)
        LReg4Ping.Name = "LReg4Ping"
        LReg4Ping.Size = New Size(86, 17)
        LReg4Ping.TabIndex = 28
        LReg4Ping.Text = "Lose packets"
        ' 
        ' LReg5Ping
        ' 
        LReg5Ping.AutoSize = True
        LReg5Ping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LReg5Ping.Location = New Point(300, 319)
        LReg5Ping.Name = "LReg5Ping"
        LReg5Ping.Size = New Size(86, 17)
        LReg5Ping.TabIndex = 29
        LReg5Ping.Text = "Lose packets"
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
        Button1.Location = New Point(433, 432)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 58)
        Button1.TabIndex = 30
        Button1.Text = "Reset ping"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(300, 432)
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
        Btn_UpdatePinPadIP.Location = New Point(14, 511)
        Btn_UpdatePinPadIP.Name = "Btn_UpdatePinPadIP"
        Btn_UpdatePinPadIP.Size = New Size(106, 58)
        Btn_UpdatePinPadIP.TabIndex = 33
        Btn_UpdatePinPadIP.Text = "Update Pin Pad IP"
        Btn_UpdatePinPadIP.UseVisualStyleBackColor = True
        ' 
        ' Btn_RestartRegister
        ' 
        Btn_RestartRegister.Location = New Point(126, 511)
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
        ' PinPads
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 586)
        Controls.Add(Txt_PinPadIP)
        Controls.Add(Btn_RestartRegister)
        Controls.Add(Btn_UpdatePinPadIP)
        Controls.Add(Cmb_Registers)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(LReg5Ping)
        Controls.Add(LReg4Ping)
        Controls.Add(LReg3Ping)
        Controls.Add(LReg2Ping)
        Controls.Add(LReg1Ping)
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
        Controls.Add(LPSCAD5)
        Controls.Add(LPP5_IP)
        Controls.Add(Label6)
        Controls.Add(LPSCAD4)
        Controls.Add(LPSCAD2)
        Controls.Add(LPP4_IP)
        Controls.Add(Label4)
        Controls.Add(LPP2_IP)
        Controls.Add(Label2)
        Controls.Add(LPSCAD1)
        Controls.Add(LPP1_IP)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "PinPads"
        Text = "PinPads"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LPP1_IP As Label
    Friend WithEvents LPSCAD1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LPP2_IP As Label
    Friend WithEvents LPP4_IP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LPSCAD2 As Label
    Friend WithEvents LPSCAD4 As Label
    Friend WithEvents LPSCAD5 As Label
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
    Friend WithEvents LReg1Ping As Label
    Friend WithEvents LReg2Ping As Label
    Friend WithEvents LReg3Ping As Label
    Friend WithEvents LReg4Ping As Label
    Friend WithEvents LReg5Ping As Label
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
End Class
