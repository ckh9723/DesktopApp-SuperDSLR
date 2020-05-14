<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_shopInsert_A165916
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_shopInsert_A165916))
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_exp = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.box_gps = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.box_wifi = New System.Windows.Forms.CheckBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(58, 157)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(801, 339)
        Me.grd_product.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 43.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(421, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 89)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADD PRODUCT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 517)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 571)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Brand:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Experience Level:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 574)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price:"
        '
        'txt_exp
        '
        Me.txt_exp.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exp.Location = New System.Drawing.Point(680, 515)
        Me.txt_exp.Name = "txt_exp"
        Me.txt_exp.Size = New System.Drawing.Size(179, 31)
        Me.txt_exp.TabIndex = 8
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(219, 570)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(180, 31)
        Me.txt_brand.TabIndex = 9
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(219, 517)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(180, 31)
        Me.txt_id.TabIndex = 10
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(680, 574)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(179, 31)
        Me.txt_price.TabIndex = 11
        '
        'box_gps
        '
        Me.box_gps.AutoSize = True
        Me.box_gps.BackColor = System.Drawing.Color.Transparent
        Me.box_gps.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_gps.Location = New System.Drawing.Point(721, 639)
        Me.box_gps.Name = "box_gps"
        Me.box_gps.Size = New System.Drawing.Size(18, 17)
        Me.box_gps.TabIndex = 12
        Me.box_gps.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(648, 632)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "GPS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(513, 632)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 30)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "WiFi:"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(903, 51)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(315, 252)
        Me.pic_product.TabIndex = 16
        Me.pic_product.TabStop = False
        '
        'txt_path
        '
        Me.txt_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_path.Location = New System.Drawing.Point(903, 330)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(315, 30)
        Me.txt_path.TabIndex = 17
        '
        'btn_picture
        '
        Me.btn_picture.AutoSize = True
        Me.btn_picture.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.Location = New System.Drawing.Point(937, 387)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(215, 43)
        Me.btn_picture.TabIndex = 18
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_model
        '
        Me.txt_model.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.Location = New System.Drawing.Point(219, 625)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(180, 31)
        Me.txt_model.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 627)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 30)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Model:"
        '
        'btn_back
        '
        Me.btn_back.AutoSize = True
        Me.btn_back.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(33, 28)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(113, 49)
        Me.btn_back.TabIndex = 29
        Me.btn_back.Text = "<Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'box_wifi
        '
        Me.box_wifi.AutoSize = True
        Me.box_wifi.BackColor = System.Drawing.Color.Transparent
        Me.box_wifi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_wifi.Location = New System.Drawing.Point(593, 639)
        Me.box_wifi.Name = "box_wifi"
        Me.box_wifi.Size = New System.Drawing.Size(18, 17)
        Me.box_wifi.TabIndex = 30
        Me.box_wifi.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_insert.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(980, 515)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(135, 50)
        Me.btn_insert.TabIndex = 31
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(200, 106)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(181, 33)
        Me.txt_search.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 37)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Search:"
        '
        'frm_shopInsert_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1243, 701)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.box_wifi)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.box_gps)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_exp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_product)
        Me.Name = "frm_shopInsert_A165916"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_product As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_exp As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents box_gps As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_path As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_model As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents box_wifi As CheckBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label9 As Label
End Class
