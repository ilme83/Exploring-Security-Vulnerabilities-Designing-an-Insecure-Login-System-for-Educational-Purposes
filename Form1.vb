Public Class Form1
    ' Kullanıcı Veritabanı
    Private users As New List(Of Dictionary(Of String, String)) From {
        New Dictionary(Of String, String) From {{"username", "admin"}, {"password", "12345"}},
        New Dictionary(Of String, String) From {{"username", "user1"}, {"password", "password123"}},
        New Dictionary(Of String, String) From {{"username", "user2"}, {"password", "qwerty"}}
    }


    Private loginAttempts As New Dictionary(Of String, Integer)
    Private Const MAX_ATTEMPTS As Integer = 3
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        If Not loginAttempts.ContainsKey(username) Then
            loginAttempts(username) = 0
        End If

        If loginAttempts(username) >= MAX_ATTEMPTS Then
            MessageBox.Show("Çok fazla deneme yaptınız. Lütfen tekrar deneyin.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kullanıcı adı ve şifre kontrolü
        Dim usernameExists As Boolean = users.Any(Function(user) user("username") = username)
        Dim passwordExists As Boolean = users.Any(Function(user) user("password") = password)

        If usernameExists And passwordExists Then
            MessageBox.Show($"Hoş geldiniz, {username}!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loginAttempts(username) = 0 ' Giriş başarılı, denemeler sıfırlanır
        Else
            loginAttempts(username) += 1 ' Başarısız giriş, deneme sayısı artar
            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim Form2 As New Form2(users)
        Form2.Show()
    End Sub
End Class
