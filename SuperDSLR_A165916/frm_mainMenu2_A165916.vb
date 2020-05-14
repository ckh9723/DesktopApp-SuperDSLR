Public Class frm_mainMenu2_A165916
    Private Sub frm_mainMenu2_A165916_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        cmb_menu.Items.Add("View")
        cmb_menu.Items.Add("Update/Delete")
        cmb_menu.Items.Add("Insert")
        cmb_menu.SelectedIndex = cmb_menu.Items.IndexOf("Insert")
    End Sub

    Private Sub cmb_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_menu.SelectedIndexChanged
        If cmb_menu.SelectedItem.Equals("View") Then
            frm_mainMenu_A165916.Show()
            Me.Hide()
        End If

        If cmb_menu.SelectedItem.Equals("Update/Delete") Then
            frm_mainMenu1_A165916.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_shopInsert_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerInsert_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staffInsert_A165916.Show()
        Me.Hide()
    End Sub
End Class