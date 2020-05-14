Public Class frm_mainMenu_A165916

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to the 'Super DSLR' web interface.")
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        cmb_menu.Items.Add("View")
        cmb_menu.Items.Add("Update/Delete")
        cmb_menu.Items.Add("Insert")
        cmb_menu.SelectedIndex = cmb_menu.Items.IndexOf("View")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_shop.Click
        frm_shop_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerDetails_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staffDetails_A165916.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_menu.SelectedIndexChanged
        If cmb_menu.SelectedItem.Equals("Update/Delete") Then
            frm_mainMenu1_A165916.Show()
            Me.Hide()
        End If

        If cmb_menu.SelectedItem.Equals("Insert") Then
            frm_mainMenu2_A165916.Show()
            Me.Hide()
        End If
    End Sub
End Class