<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Table
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Table))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblCompany = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUser = New DevExpress.XtraEditors.TextEdit
        Me.lblCashier = New DevExpress.XtraEditors.LabelControl
        Me.txtTime = New DevExpress.XtraEditors.TextEdit
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdTransfer = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReceiptPayment = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPay = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOpen = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEnter = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRePrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSplit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdChangePass = New DevExpress.XtraEditors.SimpleButton
        Me.txtBan = New DevExpress.XtraEditors.TextEdit
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 71)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1010, 523)
        Me.PanelControl1.TabIndex = 11
        '
        'lblCompany
        '
        Me.lblCompany.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(252, 14)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(303, 23)
        Me.lblCompany.TabIndex = 19
        Me.lblCompany.Text = "TÊN CÔNG TY MUA PHẦN MỀM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtUser
        '
        Me.txtUser.EditValue = "Tên user"
        Me.txtUser.Location = New System.Drawing.Point(99, 8)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Properties.Appearance.Options.UseForeColor = True
        Me.txtUser.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUser.Properties.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(147, 28)
        Me.txtUser.TabIndex = 20
        Me.txtUser.TabStop = False
        '
        'lblCashier
        '
        Me.lblCashier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCashier.Location = New System.Drawing.Point(12, 12)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(81, 19)
        Me.lblCashier.TabIndex = 21
        Me.lblCashier.Text = "THU NGÂN"
        '
        'txtTime
        '
        Me.txtTime.EditValue = "Thời gian"
        Me.txtTime.Location = New System.Drawing.Point(12, 37)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTime.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtTime.Properties.Appearance.Options.UseFont = True
        Me.txtTime.Properties.Appearance.Options.UseForeColor = True
        Me.txtTime.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTime.Properties.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(234, 28)
        Me.txtTime.TabIndex = 22
        Me.txtTime.TabStop = False
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(252, 43)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(172, 19)
        Me.lblAddress.TabIndex = 23
        Me.lblAddress.Text = "Địa chỉ - Số điện thoại - Fax"
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdThoat.Location = New System.Drawing.Point(995, 8)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(32, 32)
        Me.cmdThoat.TabIndex = 24
        Me.cmdThoat.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.cmdExit)
        Me.PanelControl2.Controls.Add(Me.cmdTransfer)
        Me.PanelControl2.Controls.Add(Me.cmdReceiptPayment)
        Me.PanelControl2.Controls.Add(Me.cmdPay)
        Me.PanelControl2.Controls.Add(Me.cmdReport)
        Me.PanelControl2.Controls.Add(Me.cmdOpen)
        Me.PanelControl2.Controls.Add(Me.cmdEnter)
        Me.PanelControl2.Controls.Add(Me.cmdDelete)
        Me.PanelControl2.Controls.Add(Me.cmdRePrint)
        Me.PanelControl2.Controls.Add(Me.cmdSplit)
        Me.PanelControl2.Controls.Add(Me.cmdChangePass)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 600)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1010, 131)
        Me.PanelControl2.TabIndex = 24
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(686, 69)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(161, 57)
        Me.cmdExit.TabIndex = 214
        Me.cmdExit.Text = "Thoát"
        '
        'cmdTransfer
        '
        Me.cmdTransfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdTransfer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTransfer.Appearance.Options.UseFont = True
        Me.cmdTransfer.Image = CType(resources.GetObject("cmdTransfer.Image"), System.Drawing.Image)
        Me.cmdTransfer.Location = New System.Drawing.Point(522, 6)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Size = New System.Drawing.Size(158, 57)
        Me.cmdTransfer.TabIndex = 197
        Me.cmdTransfer.Text = "Chuyển bàn"
        '
        'cmdReceiptPayment
        '
        Me.cmdReceiptPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdReceiptPayment.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReceiptPayment.Appearance.Options.UseFont = True
        Me.cmdReceiptPayment.Image = CType(resources.GetObject("cmdReceiptPayment.Image"), System.Drawing.Image)
        Me.cmdReceiptPayment.Location = New System.Drawing.Point(331, 69)
        Me.cmdReceiptPayment.Name = "cmdReceiptPayment"
        Me.cmdReceiptPayment.Size = New System.Drawing.Size(185, 57)
        Me.cmdReceiptPayment.TabIndex = 196
        Me.cmdReceiptPayment.Text = "Thu - Chi"
        '
        'cmdPay
        '
        Me.cmdPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPay.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPay.Appearance.Options.UseFont = True
        Me.cmdPay.Image = CType(resources.GetObject("cmdPay.Image"), System.Drawing.Image)
        Me.cmdPay.Location = New System.Drawing.Point(171, 69)
        Me.cmdPay.Name = "cmdPay"
        Me.cmdPay.Size = New System.Drawing.Size(154, 57)
        Me.cmdPay.TabIndex = 195
        Me.cmdPay.Text = "Thu nợ"
        '
        'cmdReport
        '
        Me.cmdReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdReport.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReport.Appearance.Options.UseFont = True
        Me.cmdReport.Image = CType(resources.GetObject("cmdReport.Image"), System.Drawing.Image)
        Me.cmdReport.Location = New System.Drawing.Point(522, 69)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(158, 57)
        Me.cmdReport.TabIndex = 194
        Me.cmdReport.Text = "Báo cáo ca"
        '
        'cmdOpen
        '
        Me.cmdOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOpen.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.Appearance.Options.UseFont = True
        Me.cmdOpen.Image = CType(resources.GetObject("cmdOpen.Image"), System.Drawing.Image)
        Me.cmdOpen.Location = New System.Drawing.Point(5, 6)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(160, 57)
        Me.cmdOpen.TabIndex = 192
        Me.cmdOpen.Text = "Mở bàn"
        '
        'cmdEnter
        '
        Me.cmdEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEnter.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnter.Appearance.Options.UseFont = True
        Me.cmdEnter.Image = CType(resources.GetObject("cmdEnter.Image"), System.Drawing.Image)
        Me.cmdEnter.Location = New System.Drawing.Point(331, 6)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(185, 57)
        Me.cmdEnter.TabIndex = 192
        Me.cmdEnter.Text = "Gộp bàn"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(686, 6)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(161, 57)
        Me.cmdDelete.TabIndex = 192
        Me.cmdDelete.Text = "Hủy bàn"
        '
        'cmdRePrint
        '
        Me.cmdRePrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRePrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRePrint.Appearance.Options.UseFont = True
        Me.cmdRePrint.Image = CType(resources.GetObject("cmdRePrint.Image"), System.Drawing.Image)
        Me.cmdRePrint.Location = New System.Drawing.Point(853, 6)
        Me.cmdRePrint.Name = "cmdRePrint"
        Me.cmdRePrint.Size = New System.Drawing.Size(142, 57)
        Me.cmdRePrint.TabIndex = 193
        Me.cmdRePrint.Text = "In lại"
        '
        'cmdSplit
        '
        Me.cmdSplit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSplit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSplit.Appearance.Options.UseFont = True
        Me.cmdSplit.Image = CType(resources.GetObject("cmdSplit.Image"), System.Drawing.Image)
        Me.cmdSplit.Location = New System.Drawing.Point(171, 6)
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.Size = New System.Drawing.Size(154, 57)
        Me.cmdSplit.TabIndex = 192
        Me.cmdSplit.Text = "Tách bàn"
        '
        'cmdChangePass
        '
        Me.cmdChangePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdChangePass.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangePass.Appearance.Options.UseFont = True
        Me.cmdChangePass.Image = CType(resources.GetObject("cmdChangePass.Image"), System.Drawing.Image)
        Me.cmdChangePass.Location = New System.Drawing.Point(5, 69)
        Me.cmdChangePass.Name = "cmdChangePass"
        Me.cmdChangePass.Size = New System.Drawing.Size(160, 57)
        Me.cmdChangePass.TabIndex = 191
        Me.cmdChangePass.Text = "Đổi mật khẩu"
        '
        'txtBan
        '
        Me.txtBan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBan.EditValue = ""
        Me.txtBan.Location = New System.Drawing.Point(875, 8)
        Me.txtBan.Name = "txtBan"
        Me.txtBan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBan.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBan.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtBan.Properties.Appearance.Options.UseBackColor = True
        Me.txtBan.Properties.Appearance.Options.UseFont = True
        Me.txtBan.Properties.Appearance.Options.UseForeColor = True
        Me.txtBan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtBan.Properties.ReadOnly = True
        Me.txtBan.Size = New System.Drawing.Size(114, 34)
        Me.txtBan.TabIndex = 25
        Me.txtBan.TabStop = False
        '
        'frm_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 743)
        Me.Controls.Add(Me.txtBan)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Table"
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txtBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblCompany As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCashier As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdChangePass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOpen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEnter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRePrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSplit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReceiptPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTransfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
End Class
