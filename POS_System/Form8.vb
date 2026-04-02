Imports Windows.Win32.UI.Input

Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Password As String

        Password = Trim(TextBox1.Text)

        If Password <> "" And log_in(get_e_name(), Password) = True Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class