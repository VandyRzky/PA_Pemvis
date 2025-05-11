Public Class MenuAdmin


    Public Sub New()
        InitializeComponent()
        TampilkanFormKePanel(New HomeAdmin)
    End Sub
    Private Sub TampilkanFormKePanel(form As Form)
        PanelKonten.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.None
        PanelKonten.Controls.Add(form)
        PanelKonten.AutoScroll = True
        form.Show()
    End Sub

    Private Sub ManajemenKameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenKameraToolStripMenuItem.Click
        TampilkanFormKePanel(New HomeAdmin())
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        TampilkanFormKePanel(New DataTransaksiAdmin())
    End Sub
End Class