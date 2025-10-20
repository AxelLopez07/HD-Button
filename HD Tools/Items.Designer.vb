<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        InvIdText = New TextBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        TxtExtNumID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InvIdText
        ' 
        InvIdText.Location = New Point(295, 27)
        InvIdText.Name = "InvIdText"
        InvIdText.Size = New Size(103, 23)
        InvIdText.TabIndex = 33
        InvIdText.TextAlign = HorizontalAlignment.Center
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(757, 364)
        DataGridView1.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(279, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 15)
        Label2.TabIndex = 39
        Label2.Text = "Search by Inventory ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 15)
        Label1.TabIndex = 41
        Label1.Text = "Search by ExternalNum (Vendor ID)"
        ' 
        ' TxtExtNumID
        ' 
        TxtExtNumID.Location = New Point(52, 27)
        TxtExtNumID.Name = "TxtExtNumID"
        TxtExtNumID.Size = New Size(103, 23)
        TxtExtNumID.TabIndex = 40
        TxtExtNumID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Items
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 434)
        Controls.Add(Label1)
        Controls.Add(TxtExtNumID)
        Controls.Add(Label2)
        Controls.Add(InvIdText)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Items"
        Text = "Items"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents InvIdText As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtExtNumID As TextBox
End Class
