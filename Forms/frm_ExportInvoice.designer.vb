<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ExportInvoice
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ExportInvoice))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtVAT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalVat = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtItemID = New DevExpress.XtraEditors.TextEdit
        Me.lkpName = New DevExpress.XtraEditors.LookUpEdit
        Me.txtFinalTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.lblOrderNo = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lkpToInventory = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.lkpInventory = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.txtNote = New DevExpress.XtraEditors.TextEdit
        Me.txtInvoice = New DevExpress.XtraEditors.TextEdit
        Me.txtInvoiceID = New DevExpress.XtraEditors.TextEdit
        Me.lkpNhaCungCap = New DevExpress.XtraEditors.LookUpEdit
        Me.lkpNhanVien = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lkpToInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpNhaCungCap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Controls.Add(Me.GroupControl3)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(730, 646)
        Me.PanelControl2.TabIndex = 224
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.cmdPrint)
        Me.GroupControl2.Controls.Add(Me.cmdAdd)
        Me.GroupControl2.Controls.Add(Me.cmdDelete)
        Me.GroupControl2.Controls.Add(Me.cmdExit)
        Me.GroupControl2.Controls.Add(Me.cmdSave)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 573)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(720, 68)
        Me.GroupControl2.TabIndex = 102
        Me.GroupControl2.Text = "GroupControl2"
        '
        'cmdPrint
        '
        Me.cmdPrint.AccessibleDescription = ""
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(467, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(121, 57)
        Me.cmdPrint.TabIndex = 14
        Me.cmdPrint.Text = "In"
        Me.cmdPrint.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.AccessibleDescription = ""
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(26, 6)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(181, 57)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Thêm/Cập nhật"
        '
        'cmdDelete
        '
        Me.cmdDelete.AccessibleDescription = ""
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(213, 6)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(121, 57)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Xóa"
        Me.cmdDelete.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(594, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(121, 57)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.AccessibleDescription = ""
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(340, 6)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(121, 57)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(5, 291)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(720, 274)
        Me.GridControl1.TabIndex = 259
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
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.txtVAT)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.txtTotalVat)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.txtTotal)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtItemID)
        Me.GroupControl3.Controls.Add(Me.lkpName)
        Me.GroupControl3.Controls.Add(Me.txtFinalTotal)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.txtQty)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.txtPrice)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.lblOrderNo)
        Me.GroupControl3.Location = New System.Drawing.Point(5, 146)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(720, 127)
        Me.GroupControl3.TabIndex = 101
        Me.GroupControl3.Text = "Thông tin mặt hàng"
        '
        'txtVAT
        '
        Me.txtVAT.EditValue = ""
        Me.txtVAT.Location = New System.Drawing.Point(86, 93)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtVAT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtVAT.Properties.Appearance.Options.UseBackColor = True
        Me.txtVAT.Properties.Appearance.Options.UseFont = True
        Me.txtVAT.Properties.Appearance.Options.UseForeColor = True
        Me.txtVAT.Size = New System.Drawing.Size(140, 28)
        Me.txtVAT.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl11.Location = New System.Drawing.Point(0, 97)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl11.TabIndex = 61
        Me.LabelControl11.Text = "VAT"
        '
        'txtTotalVat
        '
        Me.txtTotalVat.EditValue = ""
        Me.txtTotalVat.Location = New System.Drawing.Point(314, 93)
        Me.txtTotalVat.Name = "txtTotalVat"
        Me.txtTotalVat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtTotalVat.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVat.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotalVat.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalVat.Properties.Appearance.Options.UseFont = True
        Me.txtTotalVat.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalVat.Properties.ReadOnly = True
        Me.txtTotalVat.Size = New System.Drawing.Size(130, 28)
        Me.txtTotalVat.TabIndex = 60
        Me.txtTotalVat.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl10.Location = New System.Drawing.Point(228, 97)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl10.TabIndex = 59
        Me.LabelControl10.Text = "Tiền VAT"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = ""
        Me.txtTotal.Location = New System.Drawing.Point(561, 63)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(154, 28)
        Me.txtTotal.TabIndex = 58
        Me.txtTotal.TabStop = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl9.Location = New System.Drawing.Point(450, 68)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl9.TabIndex = 57
        Me.LabelControl9.Text = "Thành tiền"
        '
        'txtItemID
        '
        Me.txtItemID.EditValue = ""
        Me.txtItemID.Location = New System.Drawing.Point(86, 33)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtItemID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemID.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtItemID.Properties.Appearance.Options.UseBackColor = True
        Me.txtItemID.Properties.Appearance.Options.UseFont = True
        Me.txtItemID.Properties.Appearance.Options.UseForeColor = True
        Me.txtItemID.Size = New System.Drawing.Size(140, 28)
        Me.txtItemID.TabIndex = 6
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Chưa có mã hàng"
        Me.DxValidationProvider1.SetValidationRule(Me.txtItemID, ConditionValidationRule1)
        '
        'lkpName
        '
        Me.lkpName.Location = New System.Drawing.Point(314, 33)
        Me.lkpName.Name = "lkpName"
        Me.lkpName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpName.Properties.Appearance.Options.UseFont = True
        Me.lkpName.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpName.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpName.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpName.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpName.Properties.NullText = ""
        Me.lkpName.Size = New System.Drawing.Size(401, 28)
        Me.lkpName.TabIndex = 7
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.EditValue = ""
        Me.txtFinalTotal.Location = New System.Drawing.Point(561, 93)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtFinalTotal.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtFinalTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtFinalTotal.Properties.Appearance.Options.UseFont = True
        Me.txtFinalTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtFinalTotal.Properties.ReadOnly = True
        Me.txtFinalTotal.Size = New System.Drawing.Size(154, 28)
        Me.txtFinalTotal.TabIndex = 54
        Me.txtFinalTotal.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(450, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Tổng tiền"
        '
        'txtQty
        '
        Me.txtQty.EditValue = ""
        Me.txtQty.Location = New System.Drawing.Point(314, 63)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQty.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtQty.Properties.Appearance.Options.UseBackColor = True
        Me.txtQty.Properties.Appearance.Options.UseFont = True
        Me.txtQty.Properties.Appearance.Options.UseForeColor = True
        Me.txtQty.Size = New System.Drawing.Size(130, 28)
        Me.txtQty.TabIndex = 9
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Chưa nhập số lượng"
        Me.DxValidationProvider1.SetValidationRule(Me.txtQty, ConditionValidationRule2)
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(228, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Số lượng"
        '
        'txtPrice
        '
        Me.txtPrice.EditValue = ""
        Me.txtPrice.Location = New System.Drawing.Point(86, 63)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtPrice.Size = New System.Drawing.Size(140, 28)
        Me.txtPrice.TabIndex = 8
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Chưa nhập đơn giá"
        Me.DxValidationProvider1.SetValidationRule(Me.txtPrice, ConditionValidationRule3)
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(0, 67)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Đơn giá"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl8.Location = New System.Drawing.Point(228, 37)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl8.TabIndex = 48
        Me.LabelControl8.Text = "Tên hàng"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOrderNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblOrderNo.Location = New System.Drawing.Point(0, 37)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(80, 19)
        Me.lblOrderNo.TabIndex = 47
        Me.lblOrderNo.Text = "Mã hàng"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.lkpToInventory)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.lkpInventory)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.txtNote)
        Me.GroupControl1.Controls.Add(Me.txtInvoice)
        Me.GroupControl1.Controls.Add(Me.txtInvoiceID)
        Me.GroupControl1.Controls.Add(Me.lkpNhaCungCap)
        Me.GroupControl1.Controls.Add(Me.lkpNhanVien)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(720, 128)
        Me.GroupControl1.TabIndex = 100
        Me.GroupControl1.Text = "Thông tin phiếu xuất kho"
        '
        'lkpToInventory
        '
        Me.lkpToInventory.Location = New System.Drawing.Point(86, 93)
        Me.lkpToInventory.Name = "lkpToInventory"
        Me.lkpToInventory.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpToInventory.Properties.Appearance.Options.UseFont = True
        Me.lkpToInventory.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpToInventory.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpToInventory.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpToInventory.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpToInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpToInventory.Properties.NullText = ""
        Me.lkpToInventory.Properties.PopupWidth = 400
        Me.lkpToInventory.Size = New System.Drawing.Size(140, 28)
        Me.lkpToInventory.TabIndex = 25
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl14.Location = New System.Drawing.Point(5, 93)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl14.TabIndex = 26
        Me.LabelControl14.Text = "Đến kho"
        '
        'lkpInventory
        '
        Me.lkpInventory.Location = New System.Drawing.Point(561, 63)
        Me.lkpInventory.Name = "lkpInventory"
        Me.lkpInventory.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.Appearance.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpInventory.Properties.NullText = ""
        Me.lkpInventory.Properties.PopupWidth = 400
        Me.lkpInventory.Size = New System.Drawing.Size(154, 28)
        Me.lkpInventory.TabIndex = 23
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl13.Location = New System.Drawing.Point(450, 66)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "Từ kho"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl12.Location = New System.Drawing.Point(228, 66)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl12.TabIndex = 20
        Me.LabelControl12.Text = "Ngày CT"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(314, 63)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(130, 28)
        Me.DateEdit1.TabIndex = 19
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(314, 93)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNote.Properties.Appearance.Options.UseBackColor = True
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Properties.Appearance.Options.UseForeColor = True
        Me.txtNote.Size = New System.Drawing.Size(401, 28)
        Me.txtNote.TabIndex = 5
        '
        'txtInvoice
        '
        Me.txtInvoice.EditValue = ""
        Me.txtInvoice.Location = New System.Drawing.Point(314, 33)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtInvoice.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtInvoice.Properties.Appearance.Options.UseBackColor = True
        Me.txtInvoice.Properties.Appearance.Options.UseFont = True
        Me.txtInvoice.Properties.Appearance.Options.UseForeColor = True
        Me.txtInvoice.Size = New System.Drawing.Size(130, 28)
        Me.txtInvoice.TabIndex = 2
        '
        'txtInvoiceID
        '
        Me.txtInvoiceID.EditValue = ""
        Me.txtInvoiceID.Location = New System.Drawing.Point(86, 33)
        Me.txtInvoiceID.Name = "txtInvoiceID"
        Me.txtInvoiceID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtInvoiceID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceID.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceID.Properties.Appearance.Options.UseBackColor = True
        Me.txtInvoiceID.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceID.Properties.Appearance.Options.UseForeColor = True
        Me.txtInvoiceID.Properties.AutoHeight = False
        Me.txtInvoiceID.Properties.ReadOnly = True
        Me.txtInvoiceID.Size = New System.Drawing.Size(140, 28)
        Me.txtInvoiceID.TabIndex = 1
        '
        'lkpNhaCungCap
        '
        Me.lkpNhaCungCap.Location = New System.Drawing.Point(561, 33)
        Me.lkpNhaCungCap.Name = "lkpNhaCungCap"
        Me.lkpNhaCungCap.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhaCungCap.Properties.Appearance.Options.UseFont = True
        Me.lkpNhaCungCap.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhaCungCap.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpNhaCungCap.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhaCungCap.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpNhaCungCap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpNhaCungCap.Properties.NullText = ""
        Me.lkpNhaCungCap.Properties.PopupWidth = 400
        Me.lkpNhaCungCap.Size = New System.Drawing.Size(154, 28)
        Me.lkpNhaCungCap.TabIndex = 3
        '
        'lkpNhanVien
        '
        Me.lkpNhanVien.Location = New System.Drawing.Point(86, 63)
        Me.lkpNhanVien.Name = "lkpNhanVien"
        Me.lkpNhanVien.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhanVien.Properties.Appearance.Options.UseFont = True
        Me.lkpNhanVien.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhanVien.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpNhanVien.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhanVien.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpNhanVien.Properties.NullText = ""
        Me.lkpNhanVien.Properties.PopupWidth = 400
        Me.lkpNhanVien.Size = New System.Drawing.Size(140, 28)
        Me.lkpNhanVien.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(6, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Nhân viên"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(452, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(103, 20)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Nhà cung cấp"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(228, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Số HĐ"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl21.Location = New System.Drawing.Point(228, 96)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl21.TabIndex = 12
        Me.LabelControl21.Text = "Ghi chú"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(5, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl7.TabIndex = 2
        Me.LabelControl7.Text = "Số phiếu"
        '
        'frm_ExportInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 646)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ExportInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu xuất kho"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lkpToInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpNhaCungCap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtItemID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFinalTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOrderNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpNhanVien As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtInvoice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInvoiceID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpNhaCungCap As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lkpInventory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpToInventory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
