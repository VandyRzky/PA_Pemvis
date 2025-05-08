Public Class InvoiceForm

    Public Property ReturnValue As Boolean
    Public Sub New(kode As String, seri As String, merk As String, pinjam As Date, kembali As Date, harga As Integer)
        InitializeComponent()
        txtKode.Text = kode
        txtSeri.Text = seri
        txtMerk.Text = merk
        txtPinjam.Text = pinjam
        txtKembali.Text = kembali
        txtHarga.Text = harga
    End Sub
    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKode.ReadOnly = True
        txtSeri.ReadOnly = True
        txtMerk.ReadOnly = True
        txtKembali.ReadOnly = True
        txtPinjam.ReadOnly = True
        txtHarga.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReturnValue = True
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class