Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False

        Button3.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = get_e_name()
        TextBox2.Text = get_e_job()
        TextBox3.Text = get_e_email()
        TextBox5.Text = get_e_id()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True

        Button3.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using dialogForm As New Form8()
            Dim result As DialogResult = dialogForm.ShowDialog()

            If result = DialogResult.OK Then
                modify_users(get_e_id(), Trim(TextBox1.Text), Trim(TextBox2.Text), Trim(TextBox3.Text))
                If Trim(TextBox4.Text) <> "" Then
                    modify_pass(Trim(TextBox4.Text))
                End If
                set_global_id(Val(Trim(TextBox5.Text)), Trim(TextBox1.Text), Trim(TextBox2.Text), Trim(TextBox3.Text))
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password.")
            End If
        End Using

        Dim reForm7 As New Form7()
        reForm7.Show()
        Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class