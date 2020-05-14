Public Class frm_shop_A165916

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainMenu_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub frm_shop_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A165916 ORDER BY FLD_PRODUCT_ID ASC"
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
        'txt_wifi.Text = txt_price = mydatatable.Rows(0).Item("FLD_WIFI")
        'txt_gps.Text = txt_price = mydatatable.Rows(0).Item("FLD_GPS")
        box_wifi.Checked = mydatatable.Rows(0).Item("FLD_WIFI")
        box_gps.Checked = mydatatable.Rows(0).Item("FLD_GPS")

        pic_product.BackgroundImage = Image.FromFile("ProductPic/" & ID & ".jpg")
    End Sub

    Private Sub lst_camera_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_product.MouseClick
        displayResults(list_product.Text)
    End Sub

End Class