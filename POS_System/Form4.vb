Public Class Form4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String

        Username = Trim(txtUsername.Text)
        Password = Trim(txtPassword.Text)

        If Username <> "" AndAlso Password <> "" AndAlso log_in(Username, Password) = True Then
            Form1.Show()
            Close()
        Else
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckMySQLConnection() = False Then
            MessageBox.Show("Database error, please ensure database is online or credentials are correct.")
            Me.Close()
        End If
    End Sub
End Class