Public Class Form5
    Dim label As String = "ID" & vbTab & "Payment" & vbTab & "Customer" & vbTab & "Employee" & vbTab & vbTab & vbTab & "Transaction Date"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(Label)
        Dim transaction() As String = read_transaction()
        Dim i As Integer = 0
        While i < payment_num()
            ListBox1.Items.Add(transaction(i))
            i = i + 1
        End While
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Clear()
        ListBox2.Items.Add("Payment ID: " & ListBox1.SelectedItem.Split(vbTab)(0))
        ListBox2.Items.Add("Date of Transaction: " & ListBox1.SelectedItem.Split(vbTab)(6))
        ListBox2.Items.Add("SKU" & vbTab & "Description" & vbTab & "Qty")
        ListBox2.Items.AddRange(get_transac_details(ListBox1.SelectedItem.Split(vbTab)(0)).ToArray())
        ListBox2.Items.Add("Payment Total: " & ListBox1.SelectedItem.Split(vbTab)(1))
        ListBox2.Items.Add("Customer: " & ListBox1.SelectedItem.Split(vbTab)(2))
        ListBox2.Items.Add("Employee: " & ListBox1.SelectedItem.Split(vbTab)(4))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Close()
    End Sub
End Class