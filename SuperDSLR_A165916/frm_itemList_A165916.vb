Public Class frm_itemList_A165916
    Private Sub frm_orderproduct_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A165916"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_order.DataSource = mydatatable
        list_order.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub list_order_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles list_order.MouseClick
        Dim mysql = "SELECT * FROM TBL_ITEM_LIST_A165916 WHERE FLD_ORDER_ID='" & list_order.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orderproduct.DataSource = mydatatable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class