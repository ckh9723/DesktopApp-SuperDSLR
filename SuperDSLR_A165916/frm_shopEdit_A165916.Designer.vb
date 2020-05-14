<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_shopEdit_A165916
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_shopEdit_A165916))
        Me.txt_exp = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.box_gps = New System.Windows.Forms.CheckBox()
        Me.box_wifi = New System.Windows.Forms.CheckBox()
        Me.list_product = New System.Windows.Forms.ListBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_exp
        '
        Me.txt_exp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_exp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exp.Location = New System.Drawing.Point(892, 524)
        Me.txt_exp.Multiline = True
        Me.txt_exp.Name = "txt_exp"
        Me.txt_exp.Size = New System.Drawing.Size(265, 34)
        Me.txt_exp.TabIndex = 49
        '
        'txt_price
        '
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(888, 610)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(269, 34)
        Me.txt_price.TabIndex = 48
        '
        'box_gps
        '
        Me.box_gps.BackColor = System.Drawing.Color.Transparent
        Me.box_gps.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_gps.Location = New System.Drawing.Point(1045, 668)
        Me.box_gps.Name = "box_gps"
        Me.box_gps.Size = New System.Drawing.Size(125, 33)
        Me.box_gps.TabIndex = 47
        Me.box_gps.Text = "GPS"
        Me.box_gps.UseVisualStyleBackColor = False
        '
        'box_wifi
        '
        Me.box_wifi.BackColor = System.Drawing.Color.Transparent
        Me.box_wifi.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_wifi.Location = New System.Drawing.Point(905, 668)
        Me.box_wifi.Name = "box_wifi"
        Me.box_wifi.Size = New System.Drawing.Size(109, 33)
        Me.box_wifi.TabIndex = 46
        Me.box_wifi.Text = "WiFi"
        Me.box_wifi.UseVisualStyleBackColor = False
        '
        'list_product
        '
        Me.list_product.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_product.FormattingEnabled = True
        Me.list_product.ItemHeight = 30
        Me.list_product.Location = New System.Drawing.Point(56, 250)
        Me.list_product.Name = "list_product"
        Me.list_product.Size = New System.Drawing.Size(276, 424)
        Me.list_product.TabIndex = 44
        '
        'btn_back
        '
        Me.btn_back.AutoSize = True
        Me.btn_back.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(32, 28)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(124, 55)
        Me.btn_back.TabIndex = 43
        Me.btn_back.Text = "<Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_model
        '
        Me.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.Location = New System.Drawing.Point(890, 438)
        Me.txt_model.Multiline = True
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(267, 34)
        Me.txt_model.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(886, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 30)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Experience:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(884, 576)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 30)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Price(RM):"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_name.Location = New System.Drawing.Point(886, 403)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(100, 30)
        Me.lbl_name.TabIndex = 39
        Me.lbl_name.Text = "Model:"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.White
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(826, 28)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(355, 293)
        Me.pic_product.TabIndex = 38
        Me.pic_product.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 52.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(729, 108)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "EDIT PRODUCT DETAILS"
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(442, 551)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(149, 55)
        Me.btn_update.TabIndex = 50
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(629, 551)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(135, 55)
        Me.btn_delete.TabIndex = 51
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(905, 339)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(199, 39)
        Me.txt_brand.TabIndex = 52
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_shopEdit_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1218, 728)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_exp)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.box_gps)
        Me.Controls.Add(Me.box_wifi)
        Me.Controls.Add(Me.list_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_shopEdit_A165916"
        Me.Text = "frm_shopEdit_A165916"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_exp As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents box_gps As CheckBox
    Friend WithEvents box_wifi As CheckBox
    Friend WithEvents list_product As ListBox
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_model As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_brand As TextBox
End Class
