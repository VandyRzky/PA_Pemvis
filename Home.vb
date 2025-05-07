Public Class Home
    Private userLogin As String

    Public Sub New(nama As String)
        InitializeComponent()
        userLogin = nama
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub


End Class