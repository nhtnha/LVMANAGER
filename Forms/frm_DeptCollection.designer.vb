<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DeptCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DeptCollection))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtIsPaid = New DevExpress.XtraEditors.TextEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.plcCaculator = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtRemain = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPay = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lkpCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.txtFinalTotal = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.txtIsPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plcCaculator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcHeader
        '
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.LabelControl6)
        Me.gpcHeader.Controls.Add(Me.txtIsPaid)
        Me.gpcHeader.Controls.Add(Me.DateEdit1)
        Me.gpcHeader.Controls.Add(Me.LabelControl5)
        Me.gpcHeader.Controls.Add(Me.LabelControl4)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Controls.Add(Me.plcCaculator)
        Me.gpcHeader.Controls.Add(Me.LabelControl3)
        Me.gpcHeader.Controls.Add(Me.txtRemain)
        Me.gpcHeader.Controls.Add(Me.LabelControl1)
        Me.gpcHeader.Controls.Add(Me.txtPay)
        Me.gpcHeader.Controls.Add(Me.LabelControl2)
        Me.gpcHeader.Controls.Add(Me.lkpCustomer)
        Me.gpcHeader.Controls.Add(Me.cmdExit)
        Me.gpcHeader.Controls.Add(Me.cmdConfirm)
        Me.gpcHeader.Controls.Add(Me.lblID)
        Me.gpcHeader.Controls.Add(Me.txtFinalTotal)
        Me.gpcHeader.Location = New System.Drawing.Point(3, 354)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(626, 330)
        Me.gpcHeader.TabIndex = 1
        Me.gpcHeader.Text = "Trả nợ"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(5, 167)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl6.TabIndex = 240
        Me.LabelControl6.Text = "Đã trả :"
        '
        'txtIsPaid
        '
        Me.txtIsPaid.EditValue = ""
        Me.txtIsPaid.Enabled = False
        Me.txtIsPaid.Location = New System.Drawing.Point(115, 161)
        Me.txtIsPaid.Name = "txtIsPaid"
        Me.txtIsPaid.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIsPaid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsPaid.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtIsPaid.Properties.Appearance.Options.UseBackColor = True
        Me.txtIsPaid.Properties.Appearance.Options.UseFont = True
        Me.txtIsPaid.Properties.Appearance.Options.UseForeColor = True
        Me.txtIsPaid.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIsPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtIsPaid.Properties.ReadOnly = True
        Me.txtIsPaid.Size = New System.Drawing.Size(222, 31)
        Me.txtIsPaid.TabIndex = 239
        Me.txtIsPaid.TabStop = False
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(115, 65)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(222, 31)
        Me.DateEdit1.TabIndex = 238
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(34, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl5.TabIndex = 237
        Me.LabelControl5.Text = "Ngày :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(5, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl4.TabIndex = 236
        Me.LabelControl4.Text = "Số HĐ :"
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(115, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseForeColor = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(222, 31)
        Me.txtID.TabIndex = 235
        Me.txtID.TabStop = False
        '
        'plcCaculator
        '
        Me.plcCaculator.Location = New System.Drawing.Point(343, 33)
        Me.plcCaculator.Name = "plcCaculator"
        Me.plcCaculator.Size = New System.Drawing.Size(277, 291)
        Me.plcCaculator.TabIndex = 234
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(5, 231)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl3.TabIndex = 233
        Me.LabelControl3.Text = "Còn lại :"
        '
        'txtRemain
        '
        Me.txtRemain.EditValue = ""
        Me.txtRemain.Enabled = False
        Me.txtRemain.Location = New System.Drawing.Point(115, 225)
        Me.txtRemain.Name = "txtRemain"
        Me.txtRemain.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemain.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemain.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtRemain.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemain.Properties.Appearance.Options.UseFont = True
        Me.txtRemain.Properties.Appearance.Options.UseForeColor = True
        Me.txtRemain.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRemain.Properties.ReadOnly = True
        Me.txtRemain.Size = New System.Drawing.Size(222, 31)
        Me.txtRemain.TabIndex = 232
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(5, 199)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl1.TabIndex = 231
        Me.LabelControl1.Text = "Số tiền trả :"
        '
        'txtPay
        '
        Me.txtPay.EditValue = ""
        Me.txtPay.Location = New System.Drawing.Point(115, 193)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPay.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtPay.Properties.Appearance.Options.UseBackColor = True
        Me.txtPay.Properties.Appearance.Options.UseFont = True
        Me.txtPay.Properties.Appearance.Options.UseForeColor = True
        Me.txtPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPay.Size = New System.Drawing.Size(222, 31)
        Me.txtPay.TabIndex = 230
        Me.txtPay.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(5, 102)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl2.TabIndex = 229
        Me.LabelControl2.Text = "Khách hàng :"
        '
        'lkpCustomer
        '
        Me.lkpCustomer.Enabled = False
        Me.lkpCustomer.Location = New System.Drawing.Point(115, 97)
        Me.lkpCustomer.Name = "lkpCustomer"
        Me.lkpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomer.Properties.Appearance.Options.UseFont = True
        Me.lkpCustomer.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomer.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpCustomer.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomer.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCustomer.Properties.NullText = ""
        Me.lkpCustomer.Properties.PopupWidth = 400
        Me.lkpCustomer.Size = New System.Drawing.Size(222, 31)
        Me.lkpCustomer.TabIndex = 228
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(205, 262)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(132, 62)
        Me.cmdExit.TabIndex = 217
        Me.cmdExit.Text = "Thoát"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Image = CType(resources.GetObject("cmdConfirm.Image"), System.Drawing.Image)
        Me.cmdConfirm.Location = New System.Drawing.Point(62, 262)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 62)
        Me.cmdConfirm.TabIndex = 216
        Me.cmdConfirm.Text = "Xác nhận"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(5, 135)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(105, 19)
        Me.lblID.TabIndex = 213
        Me.lblID.Text = "Tiền nợ :"
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.EditValue = ""
        Me.txtFinalTotal.Enabled = False
        Me.txtFinalTotal.Location = New System.Drawing.Point(115, 129)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFinalTotal.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtFinalTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtFinalTotal.Properties.Appearance.Options.UseFont = True
        Me.txtFinalTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtFinalTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFinalTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtFinalTotal.Properties.ReadOnly = True
        Me.txtFinalTotal.Size = New System.Drawing.Size(222, 31)
        Me.txtFinalTotal.TabIndex = 212
        Me.txtFinalTotal.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(626, 345)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Danh sách phiếu"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(622, 313)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frm_DeptCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 685)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gpcHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_DeptCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.txtIsPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plcCaculator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFinalTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents plcCaculator As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIsPaid As DevExpress.XtraEditors.TextEdit
End Class
