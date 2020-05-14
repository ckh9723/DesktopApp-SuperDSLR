Public Class frm_shopEdit_A165916
    Dim currentID As String

    Private Sub frm_shopEdit_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_currentID()
    End Sub


    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A165916 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_product.DataSource = mydatatable
        list_product.DisplayMember = "FLD_PRODUCT_ID"

        displayResults(list_product.Text)
    End Sub


    Private Sub displayResults(ID As String)
        Dim mysql = "SELECT * FROM TBL_PRODUCT_A165916 WHERE FLD_PRODUCT_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_model.Text = mydatatable.Rows(0).Item("FLD_MODEL")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_exp.Text = mydatatable.Rows(0).Item("FLD_EXPERIENCE_LEVEL")
        box_wifi.Checked = mydatatable.Rows(0).Item("FLD_WIFI")
        box_gps.Checked = mydatatable.Rows(0).Item("FLD_GPS")

        pic_product.BackgroundImage = Image.FromFile("ProductPic/" & ID & ".jpg")
    End Sub


    Private Sub get_currentID()
        currentID = list_product.Text
        displayResults(currentID)
    End Sub

    Private Sub list_product_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_product.MouseClick
        get_currentID()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            run_sql_command("UPDATE TBL_PRODUCT_A165916 SET FLD_MODEL='" & txt_model.Text & "' WHERE FLD_PRODUCT_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A165916 SET FLD_EXPERIENCE_LEVEL='" & txt_exp.Text & "' WHERE FLD_PRODUCT_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A165916 SET FLD_PRICE='" & txt_price.Text & "' WHERE FLD_PRODUCT_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A165916 SET FLD_WIFI='" & box_wifi.CheckState & "' WHERE FLD_PRODUCT_ID='" & currentID & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A165916 SET FLD_WIFI='" & box_wifi.CheckState & "' WHERE FLD_PRODUCT_ID='" & currentID & "'")

            MsgBox("You have successfully updated the product '" & currentID & "'.")
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data that you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            MsgBox("Update product '" & currentID & "' unsuccessful.")
            close_connection()
        End Try

        refresh_grid()
        get_currentID()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product '" & currentID & "'?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCT_A165916 WHERE FLD_PRODUCT_ID='" & currentID & "'")

            Beep()
            MsgBox("The product '" & currentID & "' has been successfully deleted.")

            refresh_grid()
            get_currentID()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainMenu1_A165916.Show()
        Me.Hide()
    End Sub

End Class