<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_itemList_A165916
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_itemList_A165916))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grd_orderproduct = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.list_order = New System.Windows.Forms.ListBox()
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(50, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 49)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "<Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grd_orderproduct
        '
        Me.grd_orderproduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grd_orderproduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd_orderproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderproduct.Location = New System.Drawing.Point(358, 188)
        Me.grd_orderproduct.Name = "grd_orderproduct"
        Me.grd_orderproduct.RowTemplate.Height = 24
        Me.grd_orderproduct.Size = New System.Drawing.Size(708, 452)
        Me.grd_orderproduct.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 52.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 108)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ORDER DETAILS"
        '
        'list_order
        '
        Me.list_order.BackColor = System.Drawing.Color.Gainsboro
        Me.list_order.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_order.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_order.FormattingEnabled = True
        Me.list_order.ItemHeight = 31
        Me.list_order.Location = New System.Drawing.Point(50, 188)
        Me.list_order.Name = "list_order"
        Me.list_order.Size = New System.Drawing.Size(215, 403)
        Me.list_order.TabIndex = 35
        '
        'frm_itemList_A165916
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1150, 712)
        Me.Controls.Add(Me.list_order)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd_orderproduct)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_itemList_A165916"
        Me.Text = "orderproduct"
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents grd_orderproduct As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents list_order As ListBox
End Class
