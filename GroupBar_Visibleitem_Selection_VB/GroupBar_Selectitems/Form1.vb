Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Partial Public Class Form1
    Inherits MetroForm
    Private groupBar1 As New GroupBar()
    Public Sub New()
        InitializeComponent()
        groupBar1.Size = New Size(220, 300)
        groupBar1.VisualStyle = VisualStyle.Metro
        groupBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))))

        AddHandler groupBar1.GroupBarItemSelected, AddressOf GroupBar1_GroupBarItemSelected

        Dim groupBarItem1 As New GroupBarItem()
        groupBarItem1.Text = "Mail"

        Dim groupBarItem2 As New GroupBarItem()
        groupBarItem2.Text = "Contacts"

        Dim groupBarItem3 As New GroupBarItem()
        groupBarItem3.Text = "Tasks"
        groupBarItem3.Visible = False

        Dim groupBarItem4 As New GroupBarItem()
        groupBarItem4.Text = "Notes"

        groupBar1.GroupBarItems.AddRange(New GroupBarItem() {groupBarItem1, groupBarItem2, groupBarItem3, groupBarItem4})

        Me.Controls.Add(groupBar1)
    End Sub

    Private Sub GroupBar1_GroupBarItemSelected(ByVal sender As Object, ByVal e As EventArgs)
        Dim mygroup As String = Me.groupBar1.VisibleGroupBarItems(Me.groupBar1.SelectedItem).Text
        MessageBox.Show(mygroup)
    End Sub
End Class