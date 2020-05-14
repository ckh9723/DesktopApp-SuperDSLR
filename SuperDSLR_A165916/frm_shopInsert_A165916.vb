Public Class frm_shopInsert_A165916

    Private Sub frm_shopInsert_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A165916 WHERE FLD_PRODUCT_ID LIKE '%" & txt_search.Text & "%' ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable

        txt_path.Text = defaultPath1
        pic_product.BackgroundImage = Image.FromFile(defaultPath1)

        grd_product.Columns(0).HeaderText = "Product Code"
        grd_product.Columns(1).HeaderText = "Brand"
        grd_product.Columns(2).HeaderText = "Model"
        grd_product.Columns(3).HeaderText = "Experience Level"
        grd_product.Columns(4).HeaderText = "Price"
        grd_product.Columns(5).HeaderText = "WiFi"
        grd_product.Columns(6).HeaderText = "GPS"
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_brand.Text = ""
        txt_model.Text = ""
        txt_exp.Text = ""
        txt_price.Text = ""
        txt_path.Text = defaultPath1
        pic_product.BackgroundImage = Image.FromFile(defaultPath1)
        box_wifi.Checked = CheckState.Unchecked
        box_gps.Checked = CheckState.Unchecked
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            My.Computer.FileSystem.CopyFile(txt_path.Text, "ProductPic\" & txt_id.Text & ".jpg")
        Catch ex As Exception
            My.Computer.FileSystem.DeleteFile("ProductPic\" & txt_id.Text & ".jpg")
            My.Computer.FileSystem.CopyFile(txt_path.Text, "ProductPic\" & txt_id.Text & ".jpg")
        End Try

        Try
            run_sql_command("INSERT INTO TBL_PRODUCT_A165916 VALUES('" & txt_id.Text & "','" & txt_brand.Text & "','" & txt_model.Text & "','" & txt_exp.Text & "','" & txt_price.Text & "','" & box_wifi.CheckState & "','" & box_gps.CheckState & "')")
            MsgBox("The product '" & txt_id.Text & "' is successfully added.")
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data that you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            MsgBox("Add product '" & txt_id.Text & "' unsuccessful.")
            close_connection()
        End Try

        clear_fields()
        refresh_grid()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Try
            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg"
            OpenFileDialog1.ShowDialog()

            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_path.Text = OpenFileDialog1.FileName
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_grid()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainMenu2_A165916.Show()
        Me.Hide()
    End Sub
End Class