<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerInsert_A165916
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerInsert_A165916))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.pic_customer = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.AutoSize = True
        Me.btn_back.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(57, 54)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(113, 42)
        Me.btn_back.TabIndex = 49
        Me.btn_back.Text = "<Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_mobile
        '
        Me.txt_mobile.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mobile.Location = New System.Drawing.Point(297, 604)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(188, 37)
        Me.txt_mobile.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 605)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 33)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Mobile No:"
        '
        'btn_picture
        '
        Me.btn_picture.AutoSize = True
        Me.btn_picture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_picture.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.Location = New System.Drawing.Point(965, 406)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(215, 37)
        Me.btn_picture.TabIndex = 46
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_path.Location = New System.Drawing.Point(927, 349)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(302, 30)
        Me.txt_path.TabIndex = 45
        '
        'pic_customer
        '
        Me.pic_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_customer.Location = New System.Drawing.Point(927, 70)
        Me.pic_customer.Name = "pic_customer"
        Me.pic_customer.Size = New System.Drawing.Size(302, 252)
        Me.pic_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_customer.TabIndex = 44
        Me.pic_customer.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(628, 606)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(237, 37)
        Me.txt_email.TabIndex = 39
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(297, 546)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(188, 37)
        Me.txt_id.TabIndex = 38
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(628, 546)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(237, 37)
        Me.txt_name.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 608)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 33)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 548)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 33)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 548)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 43.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(270, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 89)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ADD CUSTOMER"
        '
        'grd_customer
        '
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(82, 163)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(801, 339)
        Me.grd_customer.TabIndex = 30
        '
        'btn_insert
        '
        Me.btn_insert.AutoSize = True
        Me.btn_insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_insert.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(1027, 548)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(103, 37)
        Me.btn_insert.TabIndex = 50
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_customerInsert_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1286, 733)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_mobile)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.pic_customer)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_customer)
        Me.Name = "frm_customerInsert_A165916"
        Me.Text = "frm_customerInsert_A165916"
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents txt_mobile As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_path As TextBox
    Friend WithEvents pic_customer As PictureBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
