Public Class frm_staffEdit_A165916
    Dim currentID As String

    Private Sub frm_staffEdit_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_currentID()
    End Sub


    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A165916"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_staff.DataSource = mydatatable
        list_staff.DisplayMember = "FLD_STAFF_ID"

        displayResults(list_staff.Text)
    End Sub


    Private Sub displayResults(ID As String)
        Dim mysql = "SELECT * FROM TBL_STAFF_A165916 WHERE FLD_STAFF_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        txt_mobile.Text = mydatatable.Rows(0).Item("FLD_STAFF_MOBILE")
        txt_email.Text = mydatatable.Rows(0).Item("FLD_STAFF_EMAIL")

        pic_staff.BackgroundImage = Image.FromFile("StaffPic/" & ID & ".jpg")
    End Sub


    Private Sub get_currentID()
        currentID = list_staff.Text
        displayResults(currentID)
    End Sub


    Private Sub list_customer_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_staff.MouseClick
        get_currentID()
    End Sub


    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            run_sql_command("UPDATE TBL_STAFF_A165916 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_STAFF_A165916 SET FLD_STAFF_MOBILE='" & txt_mobile.Text & "' WHERE FLD_STAFF_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_STAFF_A165916 SET FLD_STAFF_EMAIL='" & txt_email.Text & "' WHERE FLD_STAFF_ID='" & currentID & "'")

            MsgBox("You have successfully updated staff '" & currentID & "'.")
        Catch Ex As Exception
            Beep()
            MsgBox("There is a mistake in the data that you entered, as shown below" & vbCrLf & vbCrLf & Ex.Message)
            MsgBox("Update product '" & currentID & "' unsuccessful.")
            close_connection()
        End Try

        refresh_grid()
        get_currentID()
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete staff '" & currentID & "'?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A165916 WHERE FLD_STAFF_ID='" & currentID & "'")
            Beep()
            MsgBox("The staff '" & currentID & "' has been successfully deleted.")

            refresh_grid()
            get_currentID()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainMenu1_A165916.Show()
        Me.Hide()
    End Sub

End Class