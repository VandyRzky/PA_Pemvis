Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Form1
    Private Sub lblRegistrasi_Click(sender As Object, e As EventArgs) Handles lblRegistrasi.Click
        Registrasi.Show()

        Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        txtUsernameLogin.MaxLength = 15
        txtPasswordLogin.MaxLength = 8
    End Sub

    Private Function loginAdmin()
        If txtUsernameLogin.Text = "admin" And txtPasswordLogin.Text = "123admin" Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsernameLogin.Text = Nothing Or txtPasswordLogin.Text = Nothing Then
            MsgBox("Data belum lengkap")
            txtUsernameLogin.Focus()
        ElseIf loginAdmin Then
            Dim dashboardAdmin As New MenuAdmin
            txtUsernameLogin.Clear()
            txtPasswordLogin.Clear()
            dashboardAdmin.Show()
            Hide()
        Else
            CMD = New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", CONN)
            CMD.Parameters.AddWithValue("@username", txtUsernameLogin.Text)
            CMD.Parameters.AddWithValue("@password", txtPasswordLogin.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                Dim namaUser = txtUsernameLogin.Text
                Dim dashboard As New Home(namaUser)
                txtPasswordLogin.Clear()
                txtUsernameLogin.Clear()
                dashboard.Show()
                Hide()
            Else
                RD.Close()
                MsgBox("Akun tidak ada")
            End If
        End If
    End Sub
End Class
