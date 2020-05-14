<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainMenu2_A165916
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainMenu2_A165916))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_menu = New System.Windows.Forms.ComboBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 40.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(564, 81)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Super DSLR e-System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_menu
        '
        Me.cmb_menu.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_menu.FormattingEnabled = True
        Me.cmb_menu.Location = New System.Drawing.Point(387, 242)
        Me.cmb_menu.Name = "cmb_menu"
        Me.cmb_menu.Size = New System.Drawing.Size(186, 30)
        Me.cmb_menu.TabIndex = 22
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(767, 514)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(78, 27)
        Me.lbl_date.TabIndex = 21
        Me.lbl_date.Text = "Label4"
        '
        'btn_staff
        '
        Me.btn_staff.AutoSize = True
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(515, 486)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(176, 37)
        Me.btn_staff.TabIndex = 20
        Me.btn_staff.Text = "Add Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.AutoSize = True
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(282, 486)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(186, 37)
        Me.btn_customer.TabIndex = 19
        Me.btn_customer.Text = "Add Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.AutoSize = True
        Me.btn_product.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(45, 486)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(190, 37)
        Me.btn_product.TabIndex = 18
        Me.btn_product.Text = "Add Product"
        Me.btn_product.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 40.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 81)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Welcome To"
        '
        'frm_mainMenu2_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1059, 570)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_menu)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_mainMenu2_A165916"
        Me.Text = "frm_mainMenu2_A165916"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_menu As ComboBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents Label1 As Label
End Class
