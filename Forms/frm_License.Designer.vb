<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_License
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_License))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDangKy = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl
        Me.txtRegistryCode = New DevExpress.XtraEditors.TextEdit
        Me.txtSerial = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtRegistryCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdThoat)
        Me.GroupControl1.Controls.Add(Me.cmdDangKy)
        Me.GroupControl1.Location = New System.Drawing.Point(51, 139)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(305, 71)
        Me.GroupControl1.TabIndex = 215
        Me.GroupControl1.Text = "Danh sách món ăn"
        '
        'cmdThoat
        '
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.Location = New System.Drawing.Point(161, 6)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(137, 59)
        Me.cmdThoat.TabIndex = 81
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdDangKy
        '
        Me.cmdDangKy.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDangKy.Appearance.Options.UseFont = True
        Me.cmdDangKy.Enabled = False
        Me.cmdDangKy.Image = CType(resources.GetObject("cmdDangKy.Image"), System.Drawing.Image)
        Me.cmdDangKy.Location = New System.Drawing.Point(7, 6)
        Me.cmdDangKy.Name = "cmdDangKy"
        Me.cmdDangKy.Size = New System.Drawing.Size(148, 59)
        Me.cmdDangKy.TabIndex = 80
        Me.cmdDangKy.Text = "Đăng ký"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lblPassword)
        Me.GroupControl3.Controls.Add(Me.lblUserName)
        Me.GroupControl3.Controls.Add(Me.txtRegistryCode)
        Me.GroupControl3.Controls.Add(Me.txtSerial)
        Me.GroupControl3.Location = New System.Drawing.Point(13, 66)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(387, 67)
        Me.GroupControl3.TabIndex = 214
        Me.GroupControl3.Text = "Danh sách món ăn"
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassword.Appearance.ImageIndex = 1
        Me.lblPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPassword.Location = New System.Drawing.Point(7, 39)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(90, 19)
        Me.lblPassword.TabIndex = 232
        Me.lblPassword.Text = "Số đăng ký"
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUserName.Appearance.ImageIndex = 0
        Me.lblUserName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblUserName.Location = New System.Drawing.Point(7, 10)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(90, 19)
        Me.lblUserName.TabIndex = 231
        Me.lblUserName.Text = "Mã sản phẩm"
        '
        'txtRegistryCode
        '
        Me.txtRegistryCode.Location = New System.Drawing.Point(103, 34)
        Me.txtRegistryCode.Name = "txtRegistryCode"
        Me.txtRegistryCode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtRegistryCode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistryCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtRegistryCode.Properties.Appearance.Options.UseFont = True
        Me.txtRegistryCode.Size = New System.Drawing.Size(279, 28)
        Me.txtRegistryCode.TabIndex = 216
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(103, 5)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtSerial.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Properties.Appearance.Options.UseBackColor = True
        Me.txtSerial.Properties.Appearance.Options.UseFont = True
        Me.txtSerial.Properties.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(279, 28)
        Me.txtSerial.TabIndex = 215
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(238, 55)
        Me.LabelControl1.TabIndex = 232
        Me.LabelControl1.Text = "Đăng ký bản quyền"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(410, 219)
        Me.PanelControl1.TabIndex = 233
        '
        'frm_License
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 219)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_License"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtRegistryCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSerial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDangKy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRegistryCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
