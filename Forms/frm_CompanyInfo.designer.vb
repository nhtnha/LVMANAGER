<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CompanyInfo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CompanyInfo))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtContact = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCapNhat = New DevExpress.XtraEditors.SimpleButton
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTax = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSoDienThoai = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTenCty = New DevExpress.XtraEditors.TextEdit
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenCty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Controls.Add(Me.txtFax)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Controls.Add(Me.txtContact)
        Me.GroupControl3.Controls.Add(Me.Label10)
        Me.GroupControl3.Controls.Add(Me.cmdThoat)
        Me.GroupControl3.Controls.Add(Me.cmdCapNhat)
        Me.GroupControl3.Controls.Add(Me.txtEmail)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.txtTax)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.txtSoDienThoai)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Controls.Add(Me.txtTenCty)
        Me.GroupControl3.Controls.Add(Me.txtDiaChi)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(519, 159)
        Me.GroupControl3.TabIndex = 214
        Me.GroupControl3.Text = "Danh sách món ăn"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(112, 5)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Properties.Appearance.Options.UseFont = True
        Me.txtContact.Size = New System.Drawing.Size(401, 24)
        Me.txtContact.TabIndex = 235
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 234
        Me.Label10.Text = "Người liên hệ"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.Location = New System.Drawing.Point(424, 116)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(89, 38)
        Me.cmdThoat.TabIndex = 233
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdCapNhat
        '
        Me.cmdCapNhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCapNhat.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapNhat.Appearance.Options.UseFont = True
        Me.cmdCapNhat.Image = CType(resources.GetObject("cmdCapNhat.Image"), System.Drawing.Image)
        Me.cmdCapNhat.Location = New System.Drawing.Point(317, 116)
        Me.cmdCapNhat.Name = "cmdCapNhat"
        Me.cmdCapNhat.Size = New System.Drawing.Size(101, 38)
        Me.cmdCapNhat.TabIndex = 232
        Me.cmdCapNhat.Text = "Cập nhật"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(350, 88)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(163, 24)
        Me.txtEmail.TabIndex = 222
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(300, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 22)
        Me.Label5.TabIndex = 221
        Me.Label5.Text = "Email"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(112, 89)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Properties.Appearance.Options.UseFont = True
        Me.txtTax.Size = New System.Drawing.Size(182, 24)
        Me.txtTax.TabIndex = 220
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 22)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "Mã số thuế"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(112, 61)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDienThoai.Properties.Appearance.Options.UseFont = True
        Me.txtSoDienThoai.Size = New System.Drawing.Size(182, 24)
        Me.txtSoDienThoai.TabIndex = 218
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Số điện thoại"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTenCty
        '
        Me.txtTenCty.Location = New System.Drawing.Point(112, 117)
        Me.txtTenCty.Name = "txtTenCty"
        Me.txtTenCty.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenCty.Properties.Appearance.Options.UseFont = True
        Me.txtTenCty.Properties.ReadOnly = True
        Me.txtTenCty.Size = New System.Drawing.Size(182, 38)
        Me.txtTenCty.TabIndex = 215
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(112, 33)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Properties.Appearance.Options.UseFont = True
        Me.txtDiaChi.Size = New System.Drawing.Size(401, 24)
        Me.txtDiaChi.TabIndex = 216
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Tên công ty"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Địa chỉ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(350, 61)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Size = New System.Drawing.Size(163, 24)
        Me.txtFax.TabIndex = 237
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(303, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 22)
        Me.Label6.TabIndex = 236
        Me.Label6.Text = "Fax"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_CompanyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 164)
        Me.Controls.Add(Me.GroupControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CompanyInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cấu hình hệ thống"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenCty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTenCty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
