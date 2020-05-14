<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerEdit_A165916
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerEdit_A165916))
        Me.list_customer = New System.Windows.Forms.ListBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pic_customer = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_customer
        '
        Me.list_customer.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_customer.FormattingEnabled = True
        Me.list_customer.ItemHeight = 35
        Me.list_customer.Location = New System.Drawing.Point(70, 246)
        Me.list_customer.Name = "list_customer"
        Me.list_customer.Size = New System.Drawing.Size(240, 389)
        Me.list_customer.TabIndex = 41
        '
        'btn_back
        '
        Me.btn_back.AutoSize = True
        Me.btn_back.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(56, 41)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(123, 53)
        Me.btn_back.TabIndex = 40
        Me.btn_back.Text = "<Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(933, 455)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 35)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(933, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 35)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Mobile No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(933, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 35)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Customer Name:"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(936, 262)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(268, 31)
        Me.txt_name.TabIndex = 36
        '
        'txt_mobile
        '
        Me.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_mobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mobile.Location = New System.Drawing.Point(936, 378)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(271, 31)
        Me.txt_mobile.TabIndex = 35
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(936, 493)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(274, 31)
        Me.txt_email.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 35)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Customer List"
        '
        'pic_customer
        '
        Me.pic_customer.BackColor = System.Drawing.Color.White
        Me.pic_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_customer.Location = New System.Drawing.Point(389, 246)
        Me.pic_customer.Name = "pic_customer"
        Me.pic_customer.Size = New System.Drawing.Size(479, 389)
        Me.pic_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_customer.TabIndex = 32
        Me.pic_customer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(571, 97)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CUSTOMER DETAILS"
        '
        'btn_update
        '
        Me.btn_update.AutoSize = True
        Me.btn_update.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(936, 571)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(124, 48)
        Me.btn_update.TabIndex = 51
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.AutoSize = True
        Me.btn_delete.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1089, 571)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(121, 48)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_customerEdit_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1292, 753)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.list_customer)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_mobile)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pic_customer)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frm_customerEdit_A165916"
        Me.Text = "frm_customerEdit_A165916"
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list_customer As ListBox
    Friend WithEvents btn_back As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_mobile As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_customer As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
