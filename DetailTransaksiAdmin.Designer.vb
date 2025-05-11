<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksiAdmin
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
        txtHarga = New TextBox()
        txtKembali = New TextBox()
        txtPinjam = New TextBox()
        txtSeri = New TextBox()
        txtMerk = New TextBox()
        txtKode = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(167, 315)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(212, 27)
        txtHarga.TabIndex = 40
        ' 
        ' txtKembali
        ' 
        txtKembali.Location = New Point(167, 267)
        txtKembali.Name = "txtKembali"
        txtKembali.Size = New Size(212, 27)
        txtKembali.TabIndex = 39
        ' 
        ' txtPinjam
        ' 
        txtPinjam.Location = New Point(167, 224)
        txtPinjam.Name = "txtPinjam"
        txtPinjam.Size = New Size(212, 27)
        txtPinjam.TabIndex = 38
        ' 
        ' txtSeri
        ' 
        txtSeri.Location = New Point(167, 181)
        txtSeri.Name = "txtSeri"
        txtSeri.Size = New Size(212, 27)
        txtSeri.TabIndex = 37
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(167, 143)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(212, 27)
        txtMerk.TabIndex = 36
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(167, 102)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(212, 27)
        txtKode.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 318)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 34
        Label7.Text = "Total Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 20)
        Label6.TabIndex = 33
        Label6.Text = "Tanggal Kembali"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 32
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 31
        Label4.Text = "Seri Kamera"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 30
        Label3.Text = "Merk Kamera"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 29
        Label2.Text = "Kode Kamera"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(92, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 38)
        Label1.TabIndex = 28
        Label1.Text = "Detail Transaksi"
        ' 
        ' DetailTransaksiAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 450)
        Controls.Add(txtHarga)
        Controls.Add(txtKembali)
        Controls.Add(txtPinjam)
        Controls.Add(txtSeri)
        Controls.Add(txtMerk)
        Controls.Add(txtKode)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DetailTransaksiAdmin"
        Text = "DetailTransaksiAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtPinjam As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
