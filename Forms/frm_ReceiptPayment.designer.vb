<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReceiptPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReceiptPayment))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.mmeDescription = New DevExpress.XtraEditors.MemoEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblMoney = New DevExpress.XtraEditors.LabelControl
        Me.lblUser = New DevExpress.XtraEditors.LabelControl
        Me.cmdPayment = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReceipt = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.txtMoney = New DevExpress.XtraEditors.TextEdit
        Me.txtUser = New DevExpress.XtraEditors.TextEdit
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoney.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.gpcHeader)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 1)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(927, 520)
        Me.PanelControl2.TabIndex = 224
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 213)
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
        Me.gpcHeader.Controls.Add(Me.DateEdit1)
        Me.gpcHeader.Controls.Add(Me.LabelControl1)
        Me.gpcHeader.Controls.Add(Me.mmeDescription)
        Me.gpcHeader.Controls.Add(Me.lblDescription)
        Me.gpcHeader.Controls.Add(Me.lblMoney)
        Me.gpcHeader.Controls.Add(Me.lblUser)
        Me.gpcHeader.Controls.Add(Me.cmdPayment)
        Me.gpcHeader.Controls.Add(Me.cmdReceipt)
        Me.gpcHeader.Controls.Add(Me.cmdExit)
        Me.gpcHeader.Controls.Add(Me.cmdUpdate)
        Me.gpcHeader.Controls.Add(Me.txtMoney)
        Me.gpcHeader.Controls.Add(Me.txtUser)
        Me.gpcHeader.Location = New System.Drawing.Point(5, 5)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(917, 203)
        Me.gpcHeader.TabIndex = 1
        Me.gpcHeader.Text = "Lập phiếu thu - chi"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(716, 35)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(196, 28)
        Me.DateEdit1.TabIndex = 38
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(632, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "NGÀY LẬP"
        '
        'mmeDescription
        '
        Me.mmeDescription.Location = New System.Drawing.Point(148, 101)
        Me.mmeDescription.Name = "mmeDescription"
        Me.mmeDescription.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmeDescription.Properties.Appearance.Options.UseFont = True
        Me.mmeDescription.Size = New System.Drawing.Size(478, 96)
        Me.mmeDescription.TabIndex = 34
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDescription.Location = New System.Drawing.Point(5, 139)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(137, 19)
        Me.lblDescription.TabIndex = 33
        Me.lblDescription.Text = "DIỄN GIẢI"
        '
        'lblMoney
        '
        Me.lblMoney.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMoney.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMoney.Location = New System.Drawing.Point(5, 72)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(137, 19)
        Me.lblMoney.TabIndex = 31
        Me.lblMoney.Text = "SỐ TIỀN"
        '
        'lblUser
        '
        Me.lblUser.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblUser.Location = New System.Drawing.Point(5, 39)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(137, 19)
        Me.lblUser.TabIndex = 30
        Me.lblUser.Text = "NGƯỜI NỘP"
        '
        'cmdPayment
        '
        Me.cmdPayment.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayment.Appearance.Options.UseFont = True
        Me.cmdPayment.Image = CType(resources.GetObject("cmdPayment.Image"), System.Drawing.Image)
        Me.cmdPayment.Location = New System.Drawing.Point(775, 72)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(137, 59)
        Me.cmdPayment.TabIndex = 9
        Me.cmdPayment.Text = "Chi"
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReceipt.Appearance.Options.UseFont = True
        Me.cmdReceipt.Image = CType(resources.GetObject("cmdReceipt.Image"), System.Drawing.Image)
        Me.cmdReceipt.Location = New System.Drawing.Point(632, 72)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(137, 59)
        Me.cmdReceipt.TabIndex = 8
        Me.cmdReceipt.Text = "Thu"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(775, 138)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(137, 59)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Thoát"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(632, 138)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(137, 59)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Cập nhật"
        '
        'txtMoney
        '
        Me.txtMoney.EditValue = ""
        Me.DxValidationProvider1.SetIconAlignment(Me.txtMoney, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txtMoney.Location = New System.Drawing.Point(148, 67)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMoney.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoney.Properties.Appearance.Options.UseBackColor = True
        Me.txtMoney.Properties.Appearance.Options.UseFont = True
        Me.txtMoney.Properties.MaxLength = 12
        Me.txtMoney.Size = New System.Drawing.Size(478, 31)
        Me.txtMoney.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.EditValue = ""
        Me.DxValidationProvider1.SetIconAlignment(Me.txtUser, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txtUser.Location = New System.Drawing.Point(148, 33)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Size = New System.Drawing.Size(478, 31)
        Me.txtUser.TabIndex = 1
        '
        'frm_ReceiptPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 525)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ReceiptPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thu - Chi"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        Me.gpcHeader.PerformLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoney.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMoney As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReceipt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMoney As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mmeDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
