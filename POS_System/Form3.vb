Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = get_transac()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = Math.Round(Val(TextBox2.Text) - get_total(), 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox3.Text) >= 0 And Trim(TextBox4.Text) <> "" Then
            Dim index = 1
            Dim qty_list As New List(Of Integer)
            Dim sku_list As New List(Of Integer)
            Dim sku, qty As Integer
            TextBox1.AppendText(Environment.NewLine & Environment.NewLine & "Payment: " & TextBox2.Text & Environment.NewLine & "Change: " & TextBox3.Text)
            TextBox1.AppendText(Environment.NewLine & "Customer: " & TextBox4.Text)

            Dim item_list As New List(Of String)
            item_list = get_list_out()

            save_payment(get_total, get_gross, get_vat, Trim(TextBox4.Text), get_e_id)

            While index < item_list.Count
                sku = Val(item_list(index).Split(vbTab)(0))
                qty = Val(item_list(index).Split(vbTab)(3)) * -1

                sku_list.Add(sku)
                qty_list.Add(qty * -1)

                update_qty(sku, qty)
                index = index + 1
            End While
            purchase_list(sku_list, qty_list)

            MsgBox("Transaction Succeded!")

            Form1.Show()

            Close()

        ElseIf Val(TextBox3.Text) >= 0 Then
            MsgBox("Insufficient Payment.")
        Else
            MsgBox("Invalid Customer Name.")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Close()
    End Sub
End Class