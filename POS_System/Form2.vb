Public Class Form2
    Dim label As String = "SKU" & vbTab & "Description" & vbTab & "Price" & vbTab & "Qnty" & vbTab & "Date Modified"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inventory() As String = read_inventory()
        Dim i As Integer = 0
        ListBox1.Items.Add(Label)
        While i < inventory_num()
            ListBox1.Items.Add(inventory(i))
            i = i + 1
        End While
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keystring As String
        Dim i As Integer = 0
        If ComboBox1.Text = "Item SKU" Then
            keystring = "item_sku = " & TextBox1.Text
        Else keystring = "description LIKE " & "'%" & TextBox1.Text & "%'"
        End If

        Dim item() As String = search_item(keystring)
        ListBox1.Items.Clear()
        ListBox1.Items.Add(Label)
        While i < 10
            If item(i) IsNot Nothing Then
                ListBox1.Items.Add(item(i))
            End If
            i = i + 1
        End While

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item_sku As Integer = Val(TextBox5.Text)
        Dim item_desc As String = Trim(TextBox2.Text)
        Dim item_price As Integer = Trim(Val(TextBox3.Text))
        Dim item_qty As Integer = Trim(Val(TextBox4.Text))

        If item_sku > 0 And item_desc <> "" And item_price > 0 And item_qty > 0 Then
            modify_item(item_sku, item_desc, item_price, item_qty)
            MsgBox("Item " & item_sku & " successfully updated!")
        Else MsgBox("Invalid Details.")
        End If
        Dim reForm2 As New Form2()
        reForm2.Show()
        Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim index = ListBox1.SelectedIndex
        If index > 0 Then
            TextBox5.Text = ListBox1.SelectedItem.Split(vbTab)(0)
            TextBox2.Text = ListBox1.SelectedItem.Split(vbTab)(1)
            TextBox3.Text = ListBox1.SelectedItem.Split(vbTab)(2)
            TextBox4.Text = ListBox1.SelectedItem.Split(vbTab)(3)
        Else MsgBox("Select item first.")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Using dialogForm As New Form6()
            Dim result As DialogResult = dialogForm.ShowDialog()

            If result = DialogResult.OK Then
                Dim index As Integer = ListBox1.SelectedItem.Split(vbTab)(0)
                MessageBox.Show("Item " & index & " deleted.")
                If index > 0 Then
                    delete_item(index)
                Else MsgBox("Select item first.")
                End If
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Operation Canceled.")
            End If
        End Using

        Dim reForm2 As New Form2()
        reForm2.Show()
        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim item_sku As Integer = Val(TextBox5.Text)
        Dim item_desc As String = Trim(TextBox2.Text)
        Dim item_price As Integer = Trim(Val(TextBox3.Text))
        Dim item_qty As Integer = Trim(Val(TextBox4.Text))

        If item_sku = 0 Then
            add_item(item_desc, item_price, item_qty)
            MsgBox("Item " & get_sku(item_desc) & " added successfully!")
        Else MsgBox("Item SKU already exists, please clear selection before adding new item.")
        End If

        Dim reForm2 As New Form2()
        reForm2.Show()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToString("F")
    End Sub
End Class