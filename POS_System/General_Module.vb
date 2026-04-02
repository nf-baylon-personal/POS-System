Module General_Module
    Private list_out As New List(Of String)
    Private gross, vat, total_pay As Single
    Private e_name, e_job, e_email As String
    Private e_id As Integer
    Private del_flag As Boolean = False

    Public Sub final_chk_out(chk_list As List(Of String))
        list_out = chk_list
    End Sub

    Public Function get_list_out()
        Return list_out
    End Function

    Public Sub final_paydeets(cgross As Single, cvat As Single, ctotal_pay As Single)
        gross = cgross
        vat = cvat
        total_pay = ctotal_pay
    End Sub

    Public Function get_transac()
        Dim final_transac As String
        final_transac = String.Join(Environment.NewLine, list_out) & Environment.NewLine & Environment.NewLine & "Gross: " & gross & Environment.NewLine & "VAT: " & vat & Environment.NewLine & Environment.NewLine & "Total: " & total_pay
        Return final_transac
    End Function

    Public Function get_total()
        Return total_pay
    End Function

    Public Function get_gross()
        Return gross
    End Function

    Public Function get_vat()
        Return vat
    End Function

    Public Sub set_del_flag(input_fl As Boolean)
        del_flag = input_fl
    End Sub

    Public Function get_del_flag()
        Return del_flag
    End Function

    Public Sub set_global_id(input_id As Integer, input_name As String, input_job As String, input_email As String)
        e_id = input_id
        e_name = input_name
        e_job = input_job
        e_email = input_email
    End Sub

    Public Function get_e_id()
        Return e_id
    End Function

    Public Function get_e_name()
        Return e_name
    End Function

    Public Function get_e_job()
        Return e_job
    End Function

    Public Function get_e_email()
        Return e_email
    End Function
End Module
