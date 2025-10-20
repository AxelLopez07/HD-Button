<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMIMs
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TxtMIMNumber = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(26, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 0
        Label1.Text = "Search by Menu"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 47)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(186, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 350)
        DataGridView1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(230, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 25)
        Label2.TabIndex = 3
        Label2.Text = "Search by Item Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(258, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(143, 23)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(467, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 25)
        Label3.TabIndex = 5
        Label3.Text = "Search by MIM number"
        ' 
        ' TxtMIMNumber
        ' 
        TxtMIMNumber.Location = New Point(500, 47)
        TxtMIMNumber.Name = "TxtMIMNumber"
        TxtMIMNumber.Size = New Size(143, 23)
        TxtMIMNumber.TabIndex = 6
        ' 
        ' MenuMIMs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtMIMNumber)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "MenuMIMs"
        Text = "MenuMIMs"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMIMNumber As TextBox
End Class
