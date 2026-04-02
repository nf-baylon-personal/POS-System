Imports MySql.Data.MySqlClient
Module SQL_Module

    Dim myConnectionString As String = "server=localhost;uid=root;pwd=;database=pos_sys"

    Public Function CheckMySQLConnection() As Boolean
        Using conn As New MySqlConnection(myConnectionString)
            Try
                conn.Open()
                Return True
            Catch ex As MySqlException
                Return False
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Function
    Public Function log_in(iusername As String, ipassword As String) As Boolean
        Dim checkpass As String
        Dim check_id As Integer
        Dim check_job, check_email As String
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim login_script As String = "SELECT employee_id, job_title, email, password FROM employees WHERE employee_name = " & ControlChars.Quote & iusername & ControlChars.Quote

            Using login_cmd As New MySqlCommand(login_script, conn)
                Using reader As MySqlDataReader = login_cmd.ExecuteReader()
                    While reader.Read()
                        checkpass = reader("password")
                        check_id = reader("employee_id")
                        check_job = reader("job_title")
                        check_email = reader("email")
                    End While

                    If (ipassword = checkpass) Then
                        set_global_id(check_id, iusername, check_job, check_email)
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Sub modify_pass(input_password As String)
        Dim input_id As Integer = get_e_id()
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim set_pass As String = "UPDATE employees SET password = '" & input_password & "' WHERE employee_id = " & input_id
            Using set_pass_cmd As New MySqlCommand(set_pass, conn)
                set_pass_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Function read_users()
        Dim users As New List(Of String)
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim see_users As String = "SELECT employee_id, employee_name, job_title, email FROM employees"
            Using see_users_cmd As New MySqlCommand(see_users, conn)
                Using reader As MySqlDataReader = see_users_cmd.ExecuteReader()
                    While reader.Read()
                        users.Add(reader("employee_id") & vbTab & reader("employee_name") & vbTab & reader("job_title") & vbTab & reader("email"))
                    End While
                    Return users
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function get_new_id(name As String)
        Dim sku As Integer

        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim find_id As String = "SELECT employee_id FROM employees WHERE employee_name = '" & name & "'"
            Using find_id_cmd As New MySqlCommand(find_id, conn)
                Using reader As MySqlDataReader = find_id_cmd.ExecuteReader()
                    While reader.Read()
                        sku = reader("employee_id")
                    End While
                    Return sku
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Sub modify_users(emp_id As Integer, name_modify As String, job_modify As String, email_modify As String)
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim set_user As String = "UPDATE employees SET employee_name = " & "'" & name_modify & "'" & ", job_title = '" & job_modify & "', email = '" & email_modify & "' WHERE employee_id = " & emp_id
            Using set_user_cmd As New MySqlCommand(set_user, conn)
                set_user_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Sub add_users(name_add As String, job_add As String, email_add As String)
        Dim add_details As String = "('" & name_add & "'" & ", '" & job_add & "', '" & email_add & "')"
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim add_user As String = "INSERT INTO inventory (description, reg_price, quantity) VALUES " & add_details
            Using add_user_cmd As New MySqlCommand(add_user, conn)
                add_user_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Sub delete_user(emp_id As Integer)
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim del_user As String = "DELETE FROM employees WHERE employee_id = " & emp_id
            Using del_user_cmd As New MySqlCommand(del_user, conn)
                del_user_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Function inventory_num()
        Dim item_num As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim chk_item_num As String = "SELECT COUNT(*) as total_num FROM inventory"
            Using chk_item_cmd As New MySqlCommand(chk_item_num, conn)
                Using reader As MySqlDataReader = chk_item_cmd.ExecuteReader()
                    While reader.Read()
                        item_num = reader("total_num")
                    End While
                    Return item_num
                End Using
            End Using
            conn.Close()
        End Using
    End Function


    Public Function read_inventory()
        Dim item_num As Integer
        Dim i As Integer = 0
        item_num = inventory_num()
        Dim inventory(item_num) As String
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim see_items As String = "SELECT item_sku, description, reg_price, quantity, date_modified FROM inventory"
            Using see_items_cmd As New MySqlCommand(see_items, conn)
                Using reader As MySqlDataReader = see_items_cmd.ExecuteReader()
                    While reader.Read()
                        inventory(i) = reader("item_sku") & vbTab & reader("description") & vbTab & reader("reg_price") & vbTab & reader("quantity") & vbTab & reader("date_modified")
                        i = i + 1
                    End While
                    Return inventory
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function search_item(keystring As String)
        Dim item(100) As String
        Dim i As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim find_item As String = "SELECT item_sku, description, reg_price, quantity, date_modified FROM inventory WHERE " & keystring
            Using find_item_cmd As New MySqlCommand(find_item, conn)
                Using reader As MySqlDataReader = find_item_cmd.ExecuteReader()
                    While reader.Read()
                        item(i) = reader("item_sku") & vbTab & reader("description") & vbTab & reader("reg_price") & vbTab & reader("quantity") & vbTab & reader("date_modified")
                        i = i + 1
                    End While
                    Return item
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function get_sku(desc As String)
        Dim sku As Integer

        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim find_sku As String = "SELECT item_sku FROM inventory WHERE description = '" & desc & "'"
            Using find_sku_cmd As New MySqlCommand(find_sku, conn)
                Using reader As MySqlDataReader = find_sku_cmd.ExecuteReader()
                    While reader.Read()
                        sku = reader("item_sku")
                    End While
                    Return sku
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function get_price(sku As String)
        Dim price As Integer

        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim find_price As String = "SELECT reg_price FROM inventory WHERE item_sku = " & sku
            Using find_price_cmd As New MySqlCommand(find_price, conn)
                Using reader As MySqlDataReader = find_price_cmd.ExecuteReader()
                    While reader.Read()
                        price = reader("reg_price")
                    End While
                    Return price
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function add_item(sku As String)
        Dim item(10) As String
        Dim i As Integer
        Dim qty As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim chk_qty As String = "SELECT quantity FROM inventory WHERE item_sku = " & sku
            Using chk_qty_cmd As New MySqlCommand(chk_qty, conn)
                Using reader As MySqlDataReader = chk_qty_cmd.ExecuteReader()
                    While reader.Read()
                        qty = reader("quantity")
                    End While
                End Using
            End Using

            Dim set_qty As String = "UPDATE inventory SET quantity = " & (qty - 1) & " WHERE item_sku = " & sku
            Using set_qty_cmd As New MySqlCommand(set_qty, conn)
                set_qty_cmd.ExecuteNonQuery()
            End Using

            Dim find_item As String = "SELECT item_sku, description, reg_price FROM inventory WHERE item_sku = " & sku
            Using find_item_cmd As New MySqlCommand(find_item, conn)
                Using reader As MySqlDataReader = find_item_cmd.ExecuteReader()
                    While reader.Read()
                        item(i) = reader("item_sku") & vbTab & reader("description") & vbTab & reader("reg_price")
                        i = i + 1
                    End While
                    Return item
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Sub undo_qty(sku As String)
        Dim qty As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim chk_qty As String = "SELECT quantity FROM inventory WHERE item_sku = " & sku
            Using chk_qty_cmd As New MySqlCommand(chk_qty, conn)
                Using reader As MySqlDataReader = chk_qty_cmd.ExecuteReader()
                    While reader.Read()
                        qty = reader("quantity")
                    End While
                End Using
            End Using

            Dim set_qty As String = "UPDATE inventory SET quantity = " & (qty + 1) & " WHERE item_sku = " & sku
            Using set_qty_cmd As New MySqlCommand(set_qty, conn)
                set_qty_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub


    Public Function return_sku(keystring As String)
        Dim sku As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim find_sku As String = "SELECT item_sku, description, reg_price, quantity, date_modified FROM inventory WHERE " & keystring
            Using find_sku_cmd As New MySqlCommand(find_sku, conn)
                Using reader As MySqlDataReader = find_sku_cmd.ExecuteReader()
                    While reader.Read()
                        sku = reader("item_sku")
                    End While
                    Return sku
                End Using
            End Using
            conn.Close()
        End Using
    End Function


    Public Sub update_qty(sku As Integer, qty_update As Integer)
        Dim qty As New Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim chk_qty As String = "SELECT quantity FROM inventory WHERE item_sku = " & sku
            Using chk_qty_cmd As New MySqlCommand(chk_qty, conn)
                Using reader As MySqlDataReader = chk_qty_cmd.ExecuteReader()
                    While reader.Read()
                        qty = reader("quantity")
                    End While
                End Using
            End Using

            Dim set_qty As String = "UPDATE inventory SET quantity = " & (qty + qty_update) & " WHERE item_sku = " & sku
            Using set_qty_cmd As New MySqlCommand(set_qty, conn)
                set_qty_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using

    End Sub

    Public Sub modify_item(sku As Integer, desc_modify As String, price_modify As Integer, qty_modify As Integer)
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim set_item As String = "UPDATE inventory SET description = " & "'" & desc_modify & "'" & ", reg_price = " & price_modify & ", quantity = " & qty_modify & " WHERE item_sku = " & sku
            Using set_item_cmd As New MySqlCommand(set_item, conn)
                set_item_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Sub add_item(desc_add As String, price_add As Integer, qty_add As Integer)
        Dim add_values As String = "('" & desc_add & "'" & ", " & price_add & ", " & qty_add & ")"
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim add_item As String = "INSERT INTO inventory (description, reg_price, quantity) VALUES " & add_values
            Using add_item_cmd As New MySqlCommand(add_item, conn)
                add_item_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub


    Public Sub save_payment(pay_total As Decimal, gross As Decimal, vat As Decimal, customer As String, emp_id As Integer)
        Dim transac_values As String = "(" & pay_total & ", " & gross & ", " & vat & ", " & "'" & customer & "'" & ", " & emp_id & ")"
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim save_transac As String = "INSERT INTO payment_records (payment_total, gross_total, vat_total, customer, employee_id) VALUES " & transac_values
            Using save_transac_cmd As New MySqlCommand(save_transac, conn)
                save_transac_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Public Function payment_num()
        Dim payment_id As Integer
        Dim i As Integer = 0
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim last_transac As String = "SELECT COUNT(*) AS pay_index FROM payment_records"
            Using last_transac_cmd As New MySqlCommand(last_transac, conn)
                Using reader As MySqlDataReader = last_transac_cmd.ExecuteReader()
                    While reader.Read()
                        payment_id = reader("pay_index")
                    End While
                    Return payment_id
                End Using
            End Using
        End Using
    End Function

    Public Sub purchase_list(sku_list As List(Of Integer), qty_list As List(Of Integer))
        Dim payment_id As Integer = payment_num()
        Dim i As Integer = 0
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            While i < sku_list.Count()
                Dim save_purchase As String = "INSERT INTO item_purchases (payment_id, item_sku, purchase_qty) VALUES (" & payment_id & ", " & sku_list(i) & ", " & qty_list(i) & ")"
                Using save_purchase_cmd As New MySqlCommand(save_purchase, conn)
                    save_purchase_cmd.ExecuteNonQuery()
                End Using
                i = i + 1
            End While

            conn.Close()
        End Using
    End Sub
    Public Function read_transaction()
        Dim transac_num As Integer = payment_num()
        Dim transac_history(transac_num) As String
        Dim i As Integer = 0
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim see_transac As String = "SELECT p.payment_id, p.payment_total, p.customer, em.employee_name, p.date_transaction FROM payment_records p JOIN employees em ON p.employee_id = em.employee_id"
            Using see_transac_cmd As New MySqlCommand(see_transac, conn)
                Using reader As MySqlDataReader = see_transac_cmd.ExecuteReader()
                    While reader.Read()
                        transac_history(i) = reader("payment_id") & vbTab & reader("payment_total") & vbTab & reader("customer") & vbTab & vbTab & reader("employee_name") & vbTab & vbTab & reader("date_transaction")
                        i = i + 1
                    End While
                    Return transac_history
                End Using
            End Using
            conn.Close()
        End Using
    End Function

    Public Function get_transac_details(payment_id As Integer)
        Dim details As New List(Of String)
        Dim i As Integer
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim get_details As String = "SELECT i.item_sku, i.description, ip.purchase_qty FROM inventory i JOIN item_purchases ip ON i.item_sku = ip.item_sku WHERE payment_id = " & payment_id
            Using get_details_cmd As New MySqlCommand(get_details, conn)
                Using reader As MySqlDataReader = get_details_cmd.ExecuteReader()
                    While reader.Read()
                        details.Add(reader("item_sku") & vbTab & reader("description") & vbTab & reader("purchase_qty"))
                    End While
                End Using
            End Using

            Dim see_transac As String = "SELECT gross_total, vat_total FROM payment_records WHERE payment_id = " & payment_id
            Using see_transac_cmd As New MySqlCommand(see_transac, conn)
                Using reader As MySqlDataReader = see_transac_cmd.ExecuteReader()
                    While reader.Read()
                        details.Add("Gross Total: " & reader("gross_total"))
                        details.Add("VAT: " & reader("vat_total"))
                    End While
                End Using
            End Using
            Return details
            conn.Close()
        End Using
    End Function

    Public Sub delete_item(sku As Integer)
        Using conn As New MySqlConnection(myConnectionString)
            conn.Open()
            Dim del_item As String = "DELETE FROM inventory WHERE item_sku = " & sku
            Using del_item_cmd As New MySqlCommand(del_item, conn)
                del_item_cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

End Module
