<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Form1BindingSource = New BindingSource(components)
        LabelVer = New Label()
        LabelPhoneNumber = New Label()
        LabelMenu_Search = New Label()
        ListBoxMainMenu = New ListBox()
        TextBoxSearch = New TextBox()
        CType(Form1BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelVer
        ' 
        LabelVer.AutoSize = True
        LabelVer.Location = New Point(443, 508)
        LabelVer.Name = "LabelVer"
        LabelVer.Size = New Size(40, 15)
        LabelVer.TabIndex = 41
        LabelVer.Text = "1.0.1.1"
        LabelVer.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelPhoneNumber
        ' 
        LabelPhoneNumber.AutoSize = True
        LabelPhoneNumber.Location = New Point(12, 508)
        LabelPhoneNumber.Name = "LabelPhoneNumber"
        LabelPhoneNumber.Size = New Size(190, 15)
        LabelPhoneNumber.TabIndex = 43
        LabelPhoneNumber.Text = "IT Helpdesk (877) 312-4287 ext: 319"
        ' 
        ' LabelMenu_Search
        ' 
        LabelMenu_Search.AutoSize = True
        LabelMenu_Search.Location = New Point(15, 15)
        LabelMenu_Search.Name = "LabelMenu_Search"
        LabelMenu_Search.Size = New Size(45, 15)
        LabelMenu_Search.TabIndex = 46
        LabelMenu_Search.Text = "Search:"
        LabelMenu_Search.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ListBoxMainMenu
        ' 
        ListBoxMainMenu.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxMainMenu.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        ListBoxMainMenu.FormattingEnabled = True
        ListBoxMainMenu.ItemHeight = 15
        ListBoxMainMenu.Items.AddRange(New Object() {"Option1", "Option2", "Option3"})
        ListBoxMainMenu.Location = New Point(12, 41)
        ListBoxMainMenu.Name = "ListBoxMainMenu"
        ListBoxMainMenu.Size = New Size(462, 454)
        ListBoxMainMenu.Sorted = True
        ListBoxMainMenu.TabIndex = 2
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Location = New Point(66, 12)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(408, 23)
        TextBoxSearch.TabIndex = 1
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 532)
        Controls.Add(TextBoxSearch)
        Controls.Add(ListBoxMainMenu)
        Controls.Add(LabelMenu_Search)
        Controls.Add(LabelPhoneNumber)
        Controls.Add(LabelVer)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainMenu"
        Text = "HD Tools - Main Menu"
        CType(Form1BindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents LabelVer As Label
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents LabelMenu_Search As Label
    Friend WithEvents ListBoxMainMenu As ListBox
    Friend WithEvents TextBoxSearch As TextBox
End Class
