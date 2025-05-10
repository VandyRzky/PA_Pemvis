Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataTransaksi
    Private userLogin As String
    Public Sub New(nama As String)
        InitializeComponent()
        userLogin = nama
    End Sub
    Sub tampilJenis()
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        Dim query As String = "SELECT * FROM transaksitb WHERE username = @username"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@username", userLogin)


        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tanggalPinjam")

        DataGridView1.DataSource = DS.Tables("tanggalPinjam")
        DataGridView1.Refresh()
    End Sub
    Sub aturGrid()
        DataGridView1.Columns(0).Width = 95
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(0).HeaderText = "Kode"
        DataGridView1.Columns(1).HeaderText = "Tanggal Pinjam"
        DataGridView1.Columns(2).HeaderText = "Tanggal Kembali"
        DataGridView1.Columns(3).HeaderText = "Total Harga"
        DataGridView1.Columns(4).HeaderText = "Status Sewa"
        DataGridView1.Columns(5).HeaderText = "Kode Kamera"
        DataGridView1.Columns(6).HeaderText = "Username"

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim kode As String = row.Cells(0).Value.ToString()
            Dim detailForm = New DetailTransaksi(kode)
            detailForm.Show()
        End If
    End Sub

    Private Sub DataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        tampilJenis()
        aturGrid()
    End Sub
End Class