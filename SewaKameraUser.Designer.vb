<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SewaKameraUser
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
        txtKode = New TextBox()
        txtMerk = New TextBox()
        txtSeri = New TextBox()
        txtHarga = New TextBox()
        dtpPinjam = New DateTimePicker()
        dtpKembali = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtCari = New TextBox()
        btnSewa = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 77)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(719, 213)
        DataGridView1.TabIndex = 0
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(152, 320)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(190, 27)
        txtKode.TabIndex = 1
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(152, 365)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(190, 27)
        txtMerk.TabIndex = 2
        ' 
        ' txtSeri
        ' 
        txtSeri.Location = New Point(151, 413)
        txtSeri.Name = "txtSeri"
        txtSeri.Size = New Size(190, 27)
        txtSeri.TabIndex = 3
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(508, 320)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(250, 27)
        txtHarga.TabIndex = 4
        ' 
        ' dtpPinjam
        ' 
        dtpPinjam.Location = New Point(508, 365)
        dtpPinjam.Name = "dtpPinjam"
        dtpPinjam.Size = New Size(250, 27)
        dtpPinjam.TabIndex = 5
        ' 
        ' dtpKembali
        ' 
        dtpKembali.Location = New Point(508, 413)
        dtpKembali.Name = "dtpKembali"
        dtpKembali.Size = New Size(250, 27)
        dtpKembali.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 324)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 20)
        Label1.TabIndex = 7
        Label1.Text = "Kode Kamera"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 8
        Label2.Text = "Merk Kamera"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 417)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 9
        Label3.Text = "Seri Kamera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(415, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 10
        Label4.Text = "Harga/hari"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(383, 370)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 11
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(373, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 20)
        Label6.TabIndex = 12
        Label6.Text = "Tanggal Kembali"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(39, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 14
        Label7.Text = "Cari Kamera"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(152, 29)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(606, 27)
        txtCari.TabIndex = 13
        ' 
        ' btnSewa
        ' 
        btnSewa.Location = New Point(39, 466)
        btnSewa.Name = "btnSewa"
        btnSewa.Size = New Size(134, 29)
        btnSewa.TabIndex = 15
        btnSewa.Text = "Sewa Kamera"
        btnSewa.UseVisualStyleBackColor = True
        ' 
        ' SewaKameraUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 507)
        Controls.Add(btnSewa)
        Controls.Add(Label7)
        Controls.Add(txtCari)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpKembali)
        Controls.Add(dtpPinjam)
        Controls.Add(txtHarga)
        Controls.Add(txtSeri)
        Controls.Add(txtMerk)
        Controls.Add(txtKode)
        Controls.Add(DataGridView1)
        Name = "SewaKameraUser"
        Text = "SewaKameraUser"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dtpPinjam As DateTimePicker
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSewa As Button
End Class
