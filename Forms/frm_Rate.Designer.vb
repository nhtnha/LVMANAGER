<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Rate))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.txtMa = New DevExpress.XtraEditors.TextEdit
        Me.plcCaculator = New DevExpress.XtraEditors.PanelControl
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUSD = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEURO = New DevExpress.XtraEditors.SimpleButton
        Me.cmdVisa = New DevExpress.XtraEditors.SimpleButton
        Me.cmdMaster = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plcCaculator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.cmdClose)
        Me.GroupControl2.Controls.Add(Me.cmdUpdate)
        Me.GroupControl2.Controls.Add(Me.txtMa)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(418, 95)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Cập nhật tỷ giá"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(142, 33)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(135, 57)
        Me.cmdClose.TabIndex = 223
        Me.cmdClose.Text = "Thoát"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(5, 33)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(135, 57)
        Me.cmdUpdate.TabIndex = 222
        Me.cmdUpdate.Text = "Cập nhật"
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(283, 45)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa.Properties.Appearance.Options.UseBackColor = True
        Me.txtMa.Properties.Appearance.Options.UseFont = True
        Me.txtMa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMa.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtMa.Properties.ReadOnly = True
        Me.txtMa.Size = New System.Drawing.Size(130, 32)
        Me.txtMa.TabIndex = 4
        '
        'plcCaculator
        '
        Me.plcCaculator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.plcCaculator.Location = New System.Drawing.Point(2, 101)
        Me.plcCaculator.Name = "plcCaculator"
        Me.plcCaculator.Size = New System.Drawing.Size(277, 291)
        Me.plcCaculator.TabIndex = 210
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(285, 101)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(135, 57)
        Me.cmdDelete.TabIndex = 212
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdUSD
        '
        Me.cmdUSD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUSD.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUSD.Appearance.Options.UseFont = True
        Me.cmdUSD.Image = CType(resources.GetObject("cmdUSD.Image"), System.Drawing.Image)
        Me.cmdUSD.Location = New System.Drawing.Point(285, 159)
        Me.cmdUSD.Name = "cmdUSD"
        Me.cmdUSD.Size = New System.Drawing.Size(135, 57)
        Me.cmdUSD.TabIndex = 211
        Me.cmdUSD.Text = "USD"
        '
        'cmdEURO
        '
        Me.cmdEURO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEURO.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEURO.Appearance.Options.UseFont = True
        Me.cmdEURO.Image = CType(resources.GetObject("cmdEURO.Image"), System.Drawing.Image)
        Me.cmdEURO.Location = New System.Drawing.Point(285, 217)
        Me.cmdEURO.Name = "cmdEURO"
        Me.cmdEURO.Size = New System.Drawing.Size(135, 57)
        Me.cmdEURO.TabIndex = 214
        Me.cmdEURO.Text = "EURO"
        '
        'cmdVisa
        '
        Me.cmdVisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVisa.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVisa.Appearance.Options.UseFont = True
        Me.cmdVisa.Image = CType(resources.GetObject("cmdVisa.Image"), System.Drawing.Image)
        Me.cmdVisa.Location = New System.Drawing.Point(285, 276)
        Me.cmdVisa.Name = "cmdVisa"
        Me.cmdVisa.Size = New System.Drawing.Size(135, 57)
        Me.cmdVisa.TabIndex = 213
        Me.cmdVisa.Text = "VISA"
        '
        'cmdMaster
        '
        Me.cmdMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdMaster.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMaster.Appearance.Options.UseFont = True
        Me.cmdMaster.Image = CType(resources.GetObject("cmdMaster.Image"), System.Drawing.Image)
        Me.cmdMaster.Location = New System.Drawing.Point(285, 335)
        Me.cmdMaster.Name = "cmdMaster"
        Me.cmdMaster.Size = New System.Drawing.Size(135, 57)
        Me.cmdMaster.TabIndex = 216
        Me.cmdMaster.Text = "MASTER"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.plcCaculator)
        Me.PanelControl1.Controls.Add(Me.cmdUSD)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.cmdVisa)
        Me.PanelControl1.Controls.Add(Me.cmdEURO)
        Me.PanelControl1.Controls.Add(Me.cmdMaster)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(423, 394)
        Me.PanelControl1.TabIndex = 0
        '
        'frm_Rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 394)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Rate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plcCaculator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents plcCaculator As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUSD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEURO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVisa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdMaster As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
