Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim label As String = "SKU" & vbTab & "Description" & vbTab & "Price"
    Dim chk_items As New List(Of Integer)()
    Private Sub InventoryManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryManagementToolStripMenuItem.Click
        Form2.Show()
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(label & vbTab & "Qty")
        Dim inventory() As String = read_inventory()
        Dim i As Integer = 0
        ListBox2.Items.Add(label)
        While i < inventory_num()
            ListBox2.Items.Add(inventory(i).Split(vbTab)(0) & vbTab & inventory(i).Split(vbTab)(1) & vbTab & inventory(i).Split(vbTab)(2))
            i = i + 1
        End While
        Timer1.Start()
        chk_items.Add(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item As String
        Dim sku As String
        Dim temp As String
        Dim flag_exists As Boolean
        Dim i As Integer = Trim(Val(TextBox6.Text))
        Dim j As Integer = 0
        Dim index As Integer
        If ListBox2.SelectedIndex > 0 And i > 0 Then
            item = ListBox2.SelectedItem.Split(vbTab)(0) & vbTab & ListBox2.SelectedItem.Split(vbTab)(1) & vbTab & ListBox2.SelectedItem.Split(vbTab)(2)
            sku = item.Split(vbTab)(0)

            While j < chk_items.Count()
                If sku = chk_items(j) Then
                    flag_exists = True
                    index = j
                    j = chk_items.Count()
                Else
                    flag_exists = False
                End If
                j = j + 1
            End While

            If flag_exists = True Then
                temp = item & vbTab & (CInt(ListBox1.Items(index).Split(vbTab)(3)) + i)
                ListBox1.Items(index) = temp
            Else
                ListBox1.Items.Add(item & vbTab & i)
                chk_items.Add(sku)
                j = chk_items.Count()
            End If

            TextBox2.Text = Math.Round(Val(TextBox2.Text) + (Val(get_price(sku) * i)), 2)
            TextBox3.Text = Math.Round(Val(TextBox2.Text) * 0.12, 2)
            TextBox4.Text = Math.Round(Val(TextBox2.Text) + Val(TextBox3.Text), 2)

        Else MsgBox("Please select appropriate item and qty first.")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sku As Integer
        Dim index = ListBox1.SelectedIndex
        Dim qty As Integer


        If index > 0 Then
            qty = ListBox1.SelectedItem.Split(vbTab)(3)
            sku = chk_items(index)

            chk_items.RemoveAt(index)

            ListBox1.Items.Remove(ListBox1.SelectedItem)
            undo_qty(sku)
            TextBox2.Text = Math.Round(Val(TextBox2.Text) - Val(get_price(sku) * qty), 2)
            TextBox3.Text = Math.Round(Val(TextBox2.Text) * 0.12, 2)
            TextBox4.Text = Math.Round(Val(TextBox2.Text) + Val(TextBox3.Text), 2)
        Else
            MsgBox("Please select item first.")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim keystring As String
        Dim i As Integer = 0
        If ComboBox1.Text = "Item SKU" Then
            keystring = "item_sku = " & Trim(TextBox1.Text)
        Else keystring = "description LIKE " & "'%" & Trim(TextBox1.Text) & "%'"
        End If

        ListBox2.Items.Clear()
        ListBox2.Items.Add(label)
        If Trim(TextBox1.Text) <> "" Then
            Dim item() As String = search_item(keystring)
            While i < 100
                If item(i) IsNot Nothing Then
                    ListBox2.Items.Add(item(i).Split(vbTab)(0) & vbTab & item(i).Split(vbTab)(1) & vbTab & item(i).Split(vbTab)(2))
                End If
                i = i + 1
            End While
        Else
            Dim inventory() As String = read_inventory()
            While i < inventory_num()
                ListBox2.Items.Add(inventory(i).Split(vbTab)(0) & vbTab & inventory(i).Split(vbTab)(1) & vbTab & inventory(i).Split(vbTab)(2))
                i = i + 1
            End While
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        chk_items.Clear()
        chk_items.Add(0)
        ListBox1.Items.Add(label & vbTab & "Qty")
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim current_list As New List(Of String)
        For Each item As Object In ListBox1.Items
            current_list.Add(ListBox1.GetItemText(item))
        Next

        final_chk_out(current_list)
        final_paydeets(Val(TextBox2.Text), Val(TextBox3.Text), Val(TextBox4.Text))

        Form3.Show()
        Close()
    End Sub

    Private Sub TransactionRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionRecordsToolStripMenuItem.Click
        Form5.Show()
        Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form4.Show()
        Close()
    End Sub

    Private Sub QuitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitProgramToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AccountDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountDetailsToolStripMenuItem.Click
        Form7.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If get_e_id() = 0 Then
            Form9.Show()
            Close()
        End If
    End Sub
End Class
