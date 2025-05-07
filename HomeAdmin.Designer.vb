<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
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
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtKode = New TextBox()
        txtMerk = New TextBox()
        txtSeri = New TextBox()
        txtPenyewa = New TextBox()
        txtCari = New TextBox()
        Label6 = New Label()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        DateTimePicker1 = New DateTimePicker()
        txtHarga = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(31, 353)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(686, 188)
        DataGridView1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 2
        Label2.Text = "Kode Kamera"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 3
        Label3.Text = "Merk Kamera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 4
        Label4.Text = "Seri Kamera"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 5
        Label5.Text = "Penyewa"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(146, 58)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(386, 27)
        txtKode.TabIndex = 6
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(146, 100)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(386, 27)
        txtMerk.TabIndex = 7
        ' 
        ' txtSeri
        ' 
        txtSeri.Location = New Point(146, 144)
        txtSeri.Name = "txtSeri"
        txtSeri.Size = New Size(386, 27)
        txtSeri.TabIndex = 8
        ' 
        ' txtPenyewa
        ' 
        txtPenyewa.Location = New Point(146, 185)
        txtPenyewa.Name = "txtPenyewa"
        txtPenyewa.Size = New Size(386, 27)
        txtPenyewa.TabIndex = 9
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(146, 295)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(386, 27)
        txtCari.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 11
        Label6.Text = "Cari"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(582, 170)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(135, 29)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(582, 115)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(135, 29)
        btnUbah.TabIndex = 13
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(582, 61)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(135, 29)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(824, 533)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(86, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(146, 230)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(386, 27)
        txtHarga.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 236)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 20)
        Label7.TabIndex = 16
        Label7.Text = "Harga"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(299, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 28)
        Label1.TabIndex = 18
        Label1.Text = "Manajemen Kamera"
        ' 
        ' HomeAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(771, 550)
        Controls.Add(Label1)
        Controls.Add(txtHarga)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(Label6)
        Controls.Add(txtCari)
        Controls.Add(txtPenyewa)
        Controls.Add(txtSeri)
        Controls.Add(txtMerk)
        Controls.Add(txtKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Name = "HomeAdmin"
        Text = "HomeAdmin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtPenyewa As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
