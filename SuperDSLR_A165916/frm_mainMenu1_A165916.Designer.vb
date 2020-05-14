<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainMenu1_A165916
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainMenu1_A165916))
        Me.cmb_menu = New System.Windows.Forms.ComboBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_menu
        '
        Me.cmb_menu.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_menu.FormattingEnabled = True
        Me.cmb_menu.Location = New System.Drawing.Point(387, 239)
        Me.cmb_menu.Name = "cmb_menu"
        Me.cmb_menu.Size = New System.Drawing.Size(188, 30)
        Me.cmb_menu.TabIndex = 15
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(734, 514)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(78, 27)
        Me.lbl_date.TabIndex = 14
        Me.lbl_date.Text = "Label4"
        '
        'btn_staff
        '
        Me.btn_staff.AutoSize = True
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(223, 504)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(181, 37)
        Me.btn_staff.TabIndex = 13
        Me.btn_staff.Text = "Edit/Delete Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.AutoSize = True
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(353, 447)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(240, 37)
        Me.btn_customer.TabIndex = 12
        Me.btn_customer.Text = "Edit/Delete Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.AutoSize = True
        Me.btn_product.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(52, 447)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(221, 37)
        Me.btn_product.TabIndex = 11
        Me.btn_product.Text = "Edit/Delete Product"
        Me.btn_product.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 72)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Super DSLR e-System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(89, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 72)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Welcome To"
        '
        'frm_mainMenu1_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1059, 570)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_menu)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Name = "frm_mainMenu1_A165916"
        Me.Text = "frm_mainMenu1_A165916"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_menu As ComboBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
