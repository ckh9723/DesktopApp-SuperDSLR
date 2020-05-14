Public Class frm_customerDetails_A165916

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainMenu_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub frm_customerDetails_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A165916"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_customer.DataSource = mydatatable
        list_customer.DisplayMember = "FLD_CUSTOMER_ID"

        displayResults(list_customer.Text)
    End Sub

    Private Sub displayResults(ID As String)
        Dim mysql = "SELECT * FROM TBL_CUSTOMER_A165916 WHERE FLD_CUSTOMER_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_name.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_mobile.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_MOBILE")
        txt_email.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_EMAIL")

        pic_customer.BackgroundImage = Image.FromFile("CustomerPic/" & ID & ".jpg")
    End Sub

    Private Sub list_customer_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_customer.MouseClick
        displayResults(list_customer.Text)
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class