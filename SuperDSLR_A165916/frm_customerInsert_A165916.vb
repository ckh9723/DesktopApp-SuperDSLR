Public Class frm_customerInsert_A165916
    Private Sub frm_customerInsert_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Function generate_id() As String
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A165916").Rows(0).Item("LASTID")
        Dim newID As String = "C" & Mid(lastID, 2) + 1

        Return newID
    End Function

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A165916"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

        txt_path.Text = defaultPath2
        pic_customer.BackgroundImage = Image.FromFile(defaultPath2)

        txt_id.Text = generate_id()

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Name"
        grd_customer.Columns(2).HeaderText = "Mobile No"
        grd_customer.Columns(3).HeaderText = "Email Address"
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_mobile.Text = ""
        txt_email.Text = ""
        txt_path.Text = defaultPath2
        pic_customer.BackgroundImage = Image.FromFile(defaultPath2)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            My.Computer.FileSystem.CopyFile(txt_path.Text, "CustomerPic\" & txt_id.Text & ".jpg")
        Catch ex As Exception
            My.Computer.FileSystem.DeleteFile("CustomerPic\" & txt_id.Text & ".jpg")
            My.Computer.FileSystem.CopyFile(txt_path.Text, "CustomerPic\" & txt_id.Text & ".jpg")
        End Try

        Try
            run_sql_command("INSERT INTO TBL_CUSTOMER_A165916 VALUES('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_mobile.Text & "','" & txt_email.Text & "')")
            MsgBox("Customer '" & txt_id.Text & "' is successfully added.")
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data that you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            MsgBox("Add customer '" & txt_id.Text & "' unsuccessful.")
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

            pic_customer.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_path.Text = OpenFileDialog1.FileName
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainMenu2_A165916.Show()
        Me.Hide()
    End Sub

End Class