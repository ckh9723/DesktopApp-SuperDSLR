Public Class frm_staffDetails_A165916

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainMenu_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub frm_staffDetails_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A165916"
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

        pic_staff.BackgroundImage = Image.FromFile("StaffPic\" & ID & ".jpg")
    End Sub

    Private Sub list_staff_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_staff.MouseClick
        displayResults(list_staff.Text)
    End Sub
End Class