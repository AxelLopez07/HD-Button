Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports HD_Button.DB_Tools
Public Class MenuMIMs
    Private Sub MenuMIMs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("25 Breakfast biscuits").ToString()
        Me.ComboBox1.Items.Add("37 Main Burgers Lunch").ToString()
        Me.ComboBox1.Items.Add("33 Main Chicken tenders").ToString()
        Me.ComboBox1.Items.Add("1  Main specialty Sandwhich").ToString()
        Me.ComboBox1.Items.Add("60 Sm Drinks").ToString()
        Me.ComboBox1.Items.Add("15 Main sides & desserts").ToString()
        Me.ComboBox1.Items.Add("36 Kids").ToString()
        Me.ComboBox1.Items.Add("79 Main alternative").ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case Me.ComboBox1.SelectedItem.ToString
            Case "25 Breakfast biscuits"
                Call FillMIMsDataGrid(25, Me.DataGridView1)
            Case "37 Main Burgers Lunch"
                Call FillMIMsDataGrid(37, Me.DataGridView1)
            Case "33 Main Chicken tenders"
                Call FillMIMsDataGrid(33, Me.DataGridView1)
            Case "1  Main specialty Sandwhich"
                Call FillMIMsDataGrid(1, Me.DataGridView1)
            Case "60 Sm Drinks"
                Call FillMIMsDataGrid(60, Me.DataGridView1)
            Case "15 Main sides & desserts"
                Call FillMIMsDataGrid(15, Me.DataGridView1)
            Case "36 Kids"
                Call FillMIMsDataGrid(36, Me.DataGridView1)
            Case "79 Main alternative"
                Call FillMIMsDataGrid(79, Me.DataGridView1)
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If Me.TextBox1.Text.ToString <> "" Then
                Dim dt As DataTable = GetTableDataFromServer($"select ItemNum,ItemDescription,ExternalItemNum2,ClientRouting from iris.dbo.tblItemMapping where ItemNum=" & Me.TextBox1.Text & "")
                Me.DataGridView1.DataSource = dt.DefaultView
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtMIMNumber_TextChanged(sender As Object, e As EventArgs) Handles TxtMIMNumber.TextChanged
        Try
            If Me.TxtMIMNumber.Text.ToString <> "" Then
                Dim dt As DataTable = GetTableDataFromServer($"select ItemNum,ItemDescription,ExternalItemNum2,ClientRouting from iris.dbo.tblItemMapping where ExternalItemNum2='" & Me.TxtMIMNumber.Text & "'")
                Me.DataGridView1.DataSource = dt.DefaultView
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class