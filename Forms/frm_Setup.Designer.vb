<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Setup))
        Me.lblProductName = New DevExpress.XtraEditors.LabelControl
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cmdUser = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCustomer = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCard = New DevExpress.XtraEditors.SimpleButton
        Me.cmdTable = New DevExpress.XtraEditors.SimpleButton
        Me.cmdArea = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrinter = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEmployee = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRate = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGroupItem = New DevExpress.XtraEditors.SimpleButton
        Me.cmdItem = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProductName.Location = New System.Drawing.Point(146, 12)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(458, 27)
        Me.lblProductName.TabIndex = 24
        Me.lblProductName.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdThoat.Location = New System.Drawing.Point(860, 5)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(32, 32)
        Me.cmdThoat.TabIndex = 25
        Me.cmdThoat.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdUser)
        Me.PanelControl1.Controls.Add(Me.cmdClose)
        Me.PanelControl1.Controls.Add(Me.cmdCustomer)
        Me.PanelControl1.Controls.Add(Me.cmdCard)
        Me.PanelControl1.Controls.Add(Me.cmdTable)
        Me.PanelControl1.Controls.Add(Me.cmdArea)
        Me.PanelControl1.Controls.Add(Me.cmdPrinter)
        Me.PanelControl1.Controls.Add(Me.cmdEmployee)
        Me.PanelControl1.Controls.Add(Me.cmdRate)
        Me.PanelControl1.Controls.Add(Me.cmdDiscount)
        Me.PanelControl1.Controls.Add(Me.cmdGroupItem)
        Me.PanelControl1.Controls.Add(Me.cmdItem)
        Me.PanelControl1.Location = New System.Drawing.Point(97, 71)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(581, 319)
        Me.PanelControl1.TabIndex = 26
        '
        'cmdUser
        '
        Me.cmdUser.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUser.Appearance.Options.UseFont = True
        Me.cmdUser.Image = CType(resources.GetObject("cmdUser.Image"), System.Drawing.Image)
        Me.cmdUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdUser.Location = New System.Drawing.Point(149, 215)
        Me.cmdUser.Name = "cmdUser"
        Me.cmdUser.Size = New System.Drawing.Size(138, 99)
        Me.cmdUser.TabIndex = 12
        Me.cmdUser.Text = "NGƯỜI DÙNG"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(437, 215)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(138, 99)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "TRỞ VỀ"
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.Appearance.Options.UseFont = True
        Me.cmdCustomer.Image = CType(resources.GetObject("cmdCustomer.Image"), System.Drawing.Image)
        Me.cmdCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdCustomer.Location = New System.Drawing.Point(437, 110)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(138, 99)
        Me.cmdCustomer.TabIndex = 8
        Me.cmdCustomer.Text = "KH.HÀNG"
        '
        'cmdCard
        '
        Me.cmdCard.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCard.Appearance.Options.UseFont = True
        Me.cmdCard.Image = CType(resources.GetObject("cmdCard.Image"), System.Drawing.Image)
        Me.cmdCard.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdCard.Location = New System.Drawing.Point(293, 215)
        Me.cmdCard.Name = "cmdCard"
        Me.cmdCard.Size = New System.Drawing.Size(138, 99)
        Me.cmdCard.TabIndex = 10
        Me.cmdCard.Text = "THẺ"
        '
        'cmdTable
        '
        Me.cmdTable.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTable.Appearance.Options.UseFont = True
        Me.cmdTable.Image = CType(resources.GetObject("cmdTable.Image"), System.Drawing.Image)
        Me.cmdTable.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdTable.Location = New System.Drawing.Point(293, 110)
        Me.cmdTable.Name = "cmdTable"
        Me.cmdTable.Size = New System.Drawing.Size(138, 99)
        Me.cmdTable.TabIndex = 7
        Me.cmdTable.Text = "BÀN"
        '
        'cmdArea
        '
        Me.cmdArea.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArea.Appearance.Options.UseFont = True
        Me.cmdArea.Image = CType(resources.GetObject("cmdArea.Image"), System.Drawing.Image)
        Me.cmdArea.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdArea.Location = New System.Drawing.Point(149, 110)
        Me.cmdArea.Name = "cmdArea"
        Me.cmdArea.Size = New System.Drawing.Size(138, 99)
        Me.cmdArea.TabIndex = 6
        Me.cmdArea.Text = "KHU VỰC"
        '
        'cmdPrinter
        '
        Me.cmdPrinter.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrinter.Appearance.Options.UseFont = True
        Me.cmdPrinter.Image = CType(resources.GetObject("cmdPrinter.Image"), System.Drawing.Image)
        Me.cmdPrinter.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdPrinter.Location = New System.Drawing.Point(5, 110)
        Me.cmdPrinter.Name = "cmdPrinter"
        Me.cmdPrinter.Size = New System.Drawing.Size(138, 99)
        Me.cmdPrinter.TabIndex = 5
        Me.cmdPrinter.Text = "MÁY IN"
        '
        'cmdEmployee
        '
        Me.cmdEmployee.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmployee.Appearance.Options.UseFont = True
        Me.cmdEmployee.Image = CType(resources.GetObject("cmdEmployee.Image"), System.Drawing.Image)
        Me.cmdEmployee.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdEmployee.Location = New System.Drawing.Point(437, 5)
        Me.cmdEmployee.Name = "cmdEmployee"
        Me.cmdEmployee.Size = New System.Drawing.Size(138, 99)
        Me.cmdEmployee.TabIndex = 4
        Me.cmdEmployee.Text = "NHÂN VIÊN"
        '
        'cmdRate
        '
        Me.cmdRate.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRate.Appearance.Options.UseFont = True
        Me.cmdRate.Image = CType(resources.GetObject("cmdRate.Image"), System.Drawing.Image)
        Me.cmdRate.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdRate.Location = New System.Drawing.Point(5, 215)
        Me.cmdRate.Name = "cmdRate"
        Me.cmdRate.Size = New System.Drawing.Size(138, 99)
        Me.cmdRate.TabIndex = 9
        Me.cmdRate.Text = "TỶ GIÁ"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.Appearance.Options.UseFont = True
        Me.cmdDiscount.Image = CType(resources.GetObject("cmdDiscount.Image"), System.Drawing.Image)
        Me.cmdDiscount.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdDiscount.Location = New System.Drawing.Point(293, 5)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(138, 99)
        Me.cmdDiscount.TabIndex = 3
        Me.cmdDiscount.Text = "GIẢM GIÁ"
        '
        'cmdGroupItem
        '
        Me.cmdGroupItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGroupItem.Appearance.Options.UseFont = True
        Me.cmdGroupItem.Image = CType(resources.GetObject("cmdGroupItem.Image"), System.Drawing.Image)
        Me.cmdGroupItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdGroupItem.Location = New System.Drawing.Point(149, 5)
        Me.cmdGroupItem.Name = "cmdGroupItem"
        Me.cmdGroupItem.Size = New System.Drawing.Size(138, 99)
        Me.cmdGroupItem.TabIndex = 2
        Me.cmdGroupItem.Text = "NHÓM HÀNG"
        '
        'cmdItem
        '
        Me.cmdItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItem.Appearance.Options.UseFont = True
        Me.cmdItem.Image = CType(resources.GetObject("cmdItem.Image"), System.Drawing.Image)
        Me.cmdItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdItem.Location = New System.Drawing.Point(5, 5)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(138, 99)
        Me.cmdItem.TabIndex = 1
        Me.cmdItem.Text = "MÃ HÀNG"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Location = New System.Drawing.Point(12, 435)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(876, 70)
        Me.PanelControl2.TabIndex = 27
        '
        'frm_Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 517)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.lblProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Setup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdEmployee As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGroupItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdArea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrinter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdUser As DevExpress.XtraEditors.SimpleButton
End Class
