<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        txtKode = New TextBox()
        txtMerk = New TextBox()
        txtSeri = New TextBox()
        txtPinjam = New TextBox()
        txtKembali = New TextBox()
        txtHarga = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 38)
        Label1.TabIndex = 0
        Label1.Text = "Konfirmasi Transaksi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 1
        Label2.Text = "Kode Kamera"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "Merk Kamera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 3
        Label4.Text = "Seri Kamera"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 4
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 20)
        Label6.TabIndex = 5
        Label6.Text = "Tanggal Kembali"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 6
        Label7.Text = "Total Harga"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(126, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 45)
        Button1.TabIndex = 7
        Button1.Text = "Proses Transaksi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(158, 66)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(212, 27)
        txtKode.TabIndex = 8
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(158, 107)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(212, 27)
        txtMerk.TabIndex = 9
        ' 
        ' txtSeri
        ' 
        txtSeri.Location = New Point(158, 145)
        txtSeri.Name = "txtSeri"
        txtSeri.Size = New Size(212, 27)
        txtSeri.TabIndex = 10
        ' 
        ' txtPinjam
        ' 
        txtPinjam.Location = New Point(158, 188)
        txtPinjam.Name = "txtPinjam"
        txtPinjam.Size = New Size(212, 27)
        txtPinjam.TabIndex = 11
        ' 
        ' txtKembali
        ' 
        txtKembali.Location = New Point(158, 231)
        txtKembali.Name = "txtKembali"
        txtKembali.Size = New Size(212, 27)
        txtKembali.TabIndex = 12
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(158, 279)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(212, 27)
        txtHarga.TabIndex = 13
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 412)
        Controls.Add(txtHarga)
        Controls.Add(txtKembali)
        Controls.Add(txtPinjam)
        Controls.Add(txtSeri)
        Controls.Add(txtMerk)
        Controls.Add(txtKode)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "InvoiceForm"
        Text = "Konfirmasi Transaksi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtPinjam As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtHarga As TextBox
End Class
