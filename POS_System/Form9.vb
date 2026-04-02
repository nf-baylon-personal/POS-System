Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9

    Dim label As String = "ID" & vbTab & "Employee Name" & vbTab & vbTab & "Job Title" & vbTab & "Email"
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(label)
        ListBox1.Items.AddRange(read_users().ToArray())

        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index = ListBox1.SelectedIndex
        If index > 0 Then
            TextBox5.Text = ListBox1.SelectedItem.Split(vbTab)(0)
            TextBox1.Text = ListBox1.SelectedItem.Split(vbTab)(1)
            TextBox2.Text = ListBox1.SelectedItem.Split(vbTab)(2)
            TextBox3.Text = ListBox1.SelectedItem.Split(vbTab)(3)
        Else MsgBox("Select item first.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim em_id As Integer = Trim(Val(TextBox5.Text))
        Dim em_name As String = Trim(TextBox1.Text)
        Dim em_job As String = Trim(TextBox2.Text)
        Dim em_email As String = Trim(TextBox3.Text)
        Using dialogForm As New Form8()
            Dim result As DialogResult = dialogForm.ShowDialog()

            If result = DialogResult.OK Then
                If em_id > 0 And em_name <> "" And em_job <> "" And em_email <> "" Then
                    modify_users(em_id, em_name, em_job, em_email)
                    MsgBox("User " & em_id & " successfully updated!")
                Else MsgBox("Invalid Details.")
                End If

                If em_id = get_e_id() Then
                    set_global_id(em_id, em_name, em_job, em_email)
                End If
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password.")
            End If

        End Using

        Dim reForm9 As New Form9()
        reForm9.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim em_id As Integer = Trim(Val(TextBox5.Text))
        Dim em_name As String = Trim(TextBox1.Text)
        Dim em_job As String = Trim(TextBox2.Text)
        Dim em_email As String = Trim(TextBox3.Text)

        Using dialogForm As New Form8()
            Dim result As DialogResult = dialogForm.ShowDialog()

            If result = DialogResult.OK Then
                If em_id = 0 And em_name <> "" And em_job <> "" And em_email <> "" Then
                    add_users(em_name, em_job, em_email)
                    MsgBox("Item " & get_new_id(em_name) & " added successfully!")
                Else MsgBox("User already exists, please clear selection before adding new item.")
                End If
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password.")
            End If
        End Using


        Dim reForm9 As New Form9()
        reForm9.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using dialogForm As New Form8()
            Dim result As DialogResult = dialogForm.ShowDialog()

            If result = DialogResult.OK Then
                Dim index As Integer = ListBox1.SelectedItem.Split(vbTab)(0)
                MessageBox.Show("User " & index & " deleted.")
                If index > 0 Then
                    delete_user(index)
                Else MsgBox("Select user first.")
                End If
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password.")
            End If
        End Using

        Dim reForm9 As New Form9()
        reForm9.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox5.Text = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToString("F")

    End Sub
End Class