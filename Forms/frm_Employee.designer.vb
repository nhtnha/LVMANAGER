<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Employee))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl
        Me.lblPhone = New DevExpress.XtraEditors.LabelControl
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.cmdUp = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDown = New DevExpress.XtraEditors.SimpleButton
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.gpcHeader)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 1)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(927, 604)
        Me.PanelControl2.TabIndex = 224
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 298)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(917, 302)
        Me.PanelControl1.TabIndex = 222
        '
        'gpcHeader
        '
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.cmdDelete)
        Me.gpcHeader.Controls.Add(Me.cmdAdd)
        Me.gpcHeader.Controls.Add(Me.lblError)
        Me.gpcHeader.Controls.Add(Me.cmdSearch)
        Me.gpcHeader.Controls.Add(Me.lblAddress)
        Me.gpcHeader.Controls.Add(Me.lblPhone)
        Me.gpcHeader.Controls.Add(Me.lblName)
        Me.gpcHeader.Controls.Add(Me.cmdUp)
        Me.gpcHeader.Controls.Add(Me.cmdDown)
        Me.gpcHeader.Controls.Add(Me.lblID)
        Me.gpcHeader.Controls.Add(Me.txtTel)
        Me.gpcHeader.Controls.Add(Me.txtAddress)
        Me.gpcHeader.Controls.Add(Me.txtName)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Controls.Add(Me.GridControl1)
        Me.gpcHeader.Controls.Add(Me.cmdExit)
        Me.gpcHeader.Controls.Add(Me.cmdUpdate)
        Me.gpcHeader.Controls.Add(Me.cmdRemove)
        Me.gpcHeader.Location = New System.Drawing.Point(5, 5)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(917, 287)
        Me.gpcHeader.TabIndex = 1
        Me.gpcHeader.Text = "Cài đặt nhân viên"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(411, 222)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 59)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Xóa"
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblError.Location = New System.Drawing.Point(553, 194)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(354, 19)
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
        Me.cmdSearch.Location = New System.Drawing.Point(654, 222)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(121, 59)
        Me.cmdSearch.TabIndex = 10
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblAddress.Location = New System.Drawing.Point(553, 121)
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
        Me.lblPhone.Location = New System.Drawing.Point(553, 151)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(107, 19)
        Me.lblPhone.TabIndex = 231
        Me.lblPhone.Text = "Số điện thoại"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblName.Location = New System.Drawing.Point(553, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(107, 19)
        Me.lblName.TabIndex = 228
        Me.lblName.Text = "Tên nhân viên"
        '
        'cmdUp
        '
        Me.cmdUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUp.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp.Appearance.Options.UseFont = True
        Me.cmdUp.Image = CType(resources.GetObject("cmdUp.Image"), System.Drawing.Image)
        Me.cmdUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdUp.Location = New System.Drawing.Point(18, 222)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(59, 59)
        Me.cmdUp.TabIndex = 8
        '
        'cmdDown
        '
        Me.cmdDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDown.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.Appearance.Options.UseFont = True
        Me.cmdDown.Image = CType(resources.GetObject("cmdDown.Image"), System.Drawing.Image)
        Me.cmdDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdDown.Location = New System.Drawing.Point(92, 222)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(59, 59)
        Me.cmdDown.TabIndex = 7
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(553, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(107, 19)
        Me.lblID.TabIndex = 227
        Me.lblID.Text = "Mã nhân viên"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(666, 146)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Properties.Appearance.Options.UseBackColor = True
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Size = New System.Drawing.Size(246, 28)
        Me.txtTel.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(666, 116)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseBackColor = True
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(246, 28)
        Me.txtAddress.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(666, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtName.Size = New System.Drawing.Size(246, 28)
        Me.txtName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(666, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtID.Size = New System.Drawing.Size(246, 28)
        Me.txtID.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(5, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(530, 180)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(783, 222)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(121, 59)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "Thoát"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(523, 222)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(123, 59)
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
        Me.cmdRemove.Location = New System.Drawing.Point(654, 222)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(121, 59)
        Me.cmdRemove.TabIndex = 11
        Me.cmdRemove.Text = "Bỏ tìm"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(279, 222)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(124, 59)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "Tạo mới"
        Me.cmdAdd.Visible = False
        '
        'frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 607)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
End Class
