<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblRegistrasi = New Label()
        txtUsernameLogin = New TextBox()
        txtPasswordLogin = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(187, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(30, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(30, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' lblRegistrasi
        ' 
        lblRegistrasi.AutoSize = True
        lblRegistrasi.BackColor = Color.Transparent
        lblRegistrasi.Location = New Point(124, 316)
        lblRegistrasi.Name = "lblRegistrasi"
        lblRegistrasi.Size = New Size(162, 20)
        lblRegistrasi.TabIndex = 3
        lblRegistrasi.Text = "Belum ada akun?daftar"
        ' 
        ' txtUsernameLogin
        ' 
        txtUsernameLogin.Location = New Point(134, 99)
        txtUsernameLogin.Name = "txtUsernameLogin"
        txtUsernameLogin.Size = New Size(231, 27)
        txtUsernameLogin.TabIndex = 4
        ' 
        ' txtPasswordLogin
        ' 
        txtPasswordLogin.Location = New Point(134, 176)
        txtPasswordLogin.Name = "txtPasswordLogin"
        txtPasswordLogin.Size = New Size(231, 27)
        txtPasswordLogin.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(156, 284)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(405, 378)
        Controls.Add(btnLogin)
        Controls.Add(txtPasswordLogin)
        Controls.Add(txtUsernameLogin)
        Controls.Add(lblRegistrasi)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRegistrasi As Label
    Friend WithEvents txtUsernameLogin As TextBox
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents btnLogin As Button

End Class
