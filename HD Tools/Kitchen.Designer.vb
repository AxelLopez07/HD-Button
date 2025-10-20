<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kitchen))
        Me.OrderIdText = New System.Windows.Forms.TextBox()
        Me.OrderNumber = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OrderIdText
        '
        Me.OrderIdText.Location = New System.Drawing.Point(59, 52)
        Me.OrderIdText.Name = "OrderIdText"
        Me.OrderIdText.Size = New System.Drawing.Size(150, 23)
        Me.OrderIdText.TabIndex = 6
        Me.OrderIdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OrderNumber
        '
        Me.OrderNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderNumber.Location = New System.Drawing.Point(59, 81)
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.Size = New System.Drawing.Size(150, 50)
        Me.OrderNumber.TabIndex = 5
        Me.OrderNumber.Text = "Fix Order"
        Me.OrderNumber.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Order Number"
        '
        'Kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderIdText)
        Me.Controls.Add(Me.OrderNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kitchen"
        Me.Text = "Kitchen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderIdText As TextBox
    Friend WithEvents OrderNumber As Button
    Friend WithEvents Label1 As Label
End Class
