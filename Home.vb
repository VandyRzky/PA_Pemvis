Public Class Home
    Private userLogin As String

    Public Sub New(nama As String)
        InitializeComponent()
        userLogin = nama
        TampilkanFormKePanel(New SewaKameraUser(nama))
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

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub SewaKameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewaKameraToolStripMenuItem.Click
        TampilkanFormKePanel(New SewaKameraUser(userLogin))
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        TampilkanFormKePanel(New DataTransaksi(userLogin))

    End Sub
End Class