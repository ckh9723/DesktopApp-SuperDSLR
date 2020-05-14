Module mod_global_A165916
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SuperDSLR_A165916.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    Dim mywriter As OleDb.OleDbCommand
    Public defaultPath1 As String = Application.StartupPath & "\Pictures\noproductphoto.jpg"
    Public defaultPath2 As String = Application.StartupPath & "\Pictures\nophoto.jpg"
    Public mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

    Public Sub run_sql_command(thissql As String)
        mywriter = New OleDb.OleDbCommand(thissql, myconnection2)

        mywriter.Connection.Open()
        mywriter.ExecuteNonQuery()
        mywriter.Connection.Close()

    End Sub

    Public Sub close_connection()
        mywriter.Connection.Close()
    End Sub

    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error in the data that you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        Return mydatatable
    End Function

End Module
