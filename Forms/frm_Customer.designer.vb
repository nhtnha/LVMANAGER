<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Customer))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.rgpPrint = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtNote = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtTongSoLuongGiam = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtPhanTramGiam = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMathegiam = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl
        Me.lblPhone = New DevExpress.XtraEditors.LabelControl
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.rgpPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSoLuongGiam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhanTramGiam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMathegiam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcHeader
        '
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.cmdDelete)
        Me.gpcHeader.Controls.Add(Me.rgpPrint)
        Me.gpcHeader.Controls.Add(Me.LabelControl5)
        Me.gpcHeader.Controls.Add(Me.txtNote)
        Me.gpcHeader.Controls.Add(Me.LabelControl3)
        Me.gpcHeader.Controls.Add(Me.txtTongSoLuongGiam)
        Me.gpcHeader.Controls.Add(Me.LabelControl4)
        Me.gpcHeader.Controls.Add(Me.txtPhanTramGiam)
        Me.gpcHeader.Controls.Add(Me.LabelControl2)
        Me.gpcHeader.Controls.Add(Me.txtMathegiam)
        Me.gpcHeader.Controls.Add(Me.LabelControl1)
        Me.gpcHeader.Controls.Add(Me.GridControl1)
        Me.gpcHeader.Controls.Add(Me.lblError)
        Me.gpcHeader.Controls.Add(Me.cmdSearch)
        Me.gpcHeader.Controls.Add(Me.lblEmail)
        Me.gpcHeader.Controls.Add(Me.txtEmail)
        Me.gpcHeader.Controls.Add(Me.lblAddress)
        Me.gpcHeader.Controls.Add(Me.lblPhone)
        Me.gpcHeader.Controls.Add(Me.lblName)
        Me.gpcHeader.Controls.Add(Me.lblID)
        Me.gpcHeader.Controls.Add(Me.txtTel)
        Me.gpcHeader.Controls.Add(Me.txtAddress)
        Me.gpcHeader.Controls.Add(Me.txtName)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Controls.Add(Me.cmdExit)
        Me.gpcHeader.Controls.Add(Me.cmdUpdate)
        Me.gpcHeader.Controls.Add(Me.cmdRemove)
        Me.gpcHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpcHeader.Location = New System.Drawing.Point(0, 0)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(770, 607)
        Me.gpcHeader.TabIndex = 2
        Me.gpcHeader.Text = "Danh sách khách hàng"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(375, 542)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 59)
        Me.cmdDelete.TabIndex = 253
        Me.cmdDelete.Text = "Xóa"
        '
        'rgpPrint
        '
        Me.rgpPrint.Location = New System.Drawing.Point(507, 169)
        Me.rgpPrint.Name = "rgpPrint"
        Me.rgpPrint.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpPrint.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgpPrint.Properties.Appearance.Options.UseBackColor = True
        Me.rgpPrint.Properties.Appearance.Options.UseFont = True
        Me.rgpPrint.Properties.Columns = 3
        Me.rgpPrint.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "KM"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "SALES"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "VIP")})
        Me.rgpPrint.Size = New System.Drawing.Size(257, 31)
        Me.rgpPrint.TabIndex = 252
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(394, 176)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(107, 19)
        Me.LabelControl5.TabIndex = 251
        Me.LabelControl5.Text = "Loại thẻ"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(131, 127)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseBackColor = True
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNote.Size = New System.Drawing.Size(246, 31)
        Me.txtNote.TabIndex = 250
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(18, 133)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 19)
        Me.LabelControl3.TabIndex = 249
        Me.LabelControl3.Text = "Ghi chú"
        '
        'txtTongSoLuongGiam
        '
        Me.txtTongSoLuongGiam.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTongSoLuongGiam.Location = New System.Drawing.Point(131, 167)
        Me.txtTongSoLuongGiam.Name = "txtTongSoLuongGiam"
        Me.txtTongSoLuongGiam.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTongSoLuongGiam.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongSoLuongGiam.Properties.Appearance.Options.UseBackColor = True
        Me.txtTongSoLuongGiam.Properties.Appearance.Options.UseFont = True
        Me.txtTongSoLuongGiam.Size = New System.Drawing.Size(246, 28)
        Me.txtTongSoLuongGiam.TabIndex = 247
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(31, 171)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl4.TabIndex = 248
        Me.LabelControl4.Text = "SL GIẢM"
        '
        'txtPhanTramGiam
        '
        Me.txtPhanTramGiam.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPhanTramGiam.Location = New System.Drawing.Point(507, 135)
        Me.txtPhanTramGiam.Name = "txtPhanTramGiam"
        Me.txtPhanTramGiam.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPhanTramGiam.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhanTramGiam.Properties.Appearance.Options.UseBackColor = True
        Me.txtPhanTramGiam.Properties.Appearance.Options.UseFont = True
        Me.txtPhanTramGiam.Size = New System.Drawing.Size(258, 28)
        Me.txtPhanTramGiam.TabIndex = 247
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(394, 140)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 19)
        Me.LabelControl2.TabIndex = 248
        Me.LabelControl2.Text = "% Giảm Giá"
        '
        'txtMathegiam
        '
        Me.txtMathegiam.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtMathegiam.Location = New System.Drawing.Point(507, 97)
        Me.txtMathegiam.Name = "txtMathegiam"
        Me.txtMathegiam.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMathegiam.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMathegiam.Properties.Appearance.Options.UseBackColor = True
        Me.txtMathegiam.Properties.Appearance.Options.UseFont = True
        Me.txtMathegiam.Size = New System.Drawing.Size(257, 28)
        Me.txtMathegiam.TabIndex = 245
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(394, 102)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 19)
        Me.LabelControl1.TabIndex = 246
        Me.LabelControl1.Text = "Mã thẻ giảm giá"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(5, 238)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(759, 298)
        Me.GridControl1.TabIndex = 244
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 40
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblError.Location = New System.Drawing.Point(424, 213)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(334, 19)
        Me.lblError.TabIndex = 236
        Me.lblError.Text = "Không tìm thấy dữ liệu"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageIndex = 0
        Me.cmdSearch.Location = New System.Drawing.Point(485, 542)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(137, 59)
        Me.cmdSearch.TabIndex = 235
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'lblEmail
        '
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblEmail.Location = New System.Drawing.Point(18, 98)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(107, 19)
        Me.lblEmail.TabIndex = 234
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(131, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(246, 28)
        Me.txtEmail.TabIndex = 233
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblAddress.Location = New System.Drawing.Point(18, 68)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(107, 19)
        Me.lblAddress.TabIndex = 232
        Me.lblAddress.Text = "Địa chỉ"
        '
        'lblPhone
        '
        Me.lblPhone.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPhone.Location = New System.Drawing.Point(383, 68)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(118, 19)
        Me.lblPhone.TabIndex = 231
        Me.lblPhone.Text = "Số điện thoại"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblName.Location = New System.Drawing.Point(383, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(118, 19)
        Me.lblName.TabIndex = 228
        Me.lblName.Text = "Tên khách hàng"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(5, 38)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(120, 19)
        Me.lblID.TabIndex = 227
        Me.lblID.Text = "Mã khách hàng"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(507, 63)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Properties.Appearance.Options.UseBackColor = True
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Size = New System.Drawing.Size(257, 28)
        Me.txtTel.TabIndex = 230
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(131, 63)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseBackColor = True
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(246, 28)
        Me.txtAddress.TabIndex = 229
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(507, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtName.Size = New System.Drawing.Size(257, 28)
        Me.txtName.TabIndex = 224
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(131, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtID.Size = New System.Drawing.Size(246, 28)
        Me.txtID.TabIndex = 223
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(628, 542)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(137, 59)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Thoát"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(232, 542)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(137, 59)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Cập nhật"
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.Image = CType(resources.GetObject("cmdRemove.Image"), System.Drawing.Image)
        Me.cmdRemove.ImageIndex = 0
        Me.cmdRemove.Location = New System.Drawing.Point(482, 542)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(137, 59)
        Me.cmdRemove.TabIndex = 237
        Me.cmdRemove.Text = "Bỏ tìm"
        '
        'frm_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 607)
        Me.Controls.Add(Me.gpcHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.rgpPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSoLuongGiam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhanTramGiam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMathegiam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhanTramGiam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMathegiam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongSoLuongGiam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgpPrint As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
