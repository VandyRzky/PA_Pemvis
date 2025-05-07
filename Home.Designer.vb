<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        MenuStrip1 = New MenuStrip()
        SewaKameraToolStripMenuItem = New ToolStripMenuItem()
        DataTransaksiToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        PanelKonten = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SewaKameraToolStripMenuItem, DataTransaksiToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(811, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SewaKameraToolStripMenuItem
        ' 
        SewaKameraToolStripMenuItem.Name = "SewaKameraToolStripMenuItem"
        SewaKameraToolStripMenuItem.Size = New Size(113, 24)
        SewaKameraToolStripMenuItem.Text = "Sewa Kamera"
        ' 
        ' DataTransaksiToolStripMenuItem
        ' 
        DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        DataTransaksiToolStripMenuItem.Size = New Size(118, 24)
        DataTransaksiToolStripMenuItem.Text = "Data Transaksi"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(76, 24)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' PanelKonten
        ' 
        PanelKonten.Location = New Point(0, 31)
        PanelKonten.Name = "PanelKonten"
        PanelKonten.Size = New Size(811, 438)
        PanelKonten.TabIndex = 1
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(811, 466)
        Controls.Add(PanelKonten)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Home"
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SewaKameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelKonten As Panel
End Class
