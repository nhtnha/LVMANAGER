<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Printer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Printer))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.cmdDown = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUp = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOff = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOn = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCapNhat = New DevExpress.XtraEditors.SimpleButton
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpcHeader.Controls.Add(Me.PictureBox2)
        Me.gpcHeader.Controls.Add(Me.lblName)
        Me.gpcHeader.Controls.Add(Me.lblID)
        Me.gpcHeader.Controls.Add(Me.cmdDown)
        Me.gpcHeader.Controls.Add(Me.cmdUp)
        Me.gpcHeader.Controls.Add(Me.cmdOff)
        Me.gpcHeader.Controls.Add(Me.cmdOn)
        Me.gpcHeader.Controls.Add(Me.GridControl1)
        Me.gpcHeader.Controls.Add(Me.cmdThoat)
        Me.gpcHeader.Controls.Add(Me.cmdCapNhat)
        Me.gpcHeader.Controls.Add(Me.txtName)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Location = New System.Drawing.Point(5, 5)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(917, 287)
        Me.gpcHeader.TabIndex = 1
        Me.gpcHeader.Text = "Cài đặt máy in"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(582, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(330, 248)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblName.Location = New System.Drawing.Point(148, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(137, 19)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "TÊN"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(5, 33)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(137, 19)
        Me.lblID.TabIndex = 30
        Me.lblID.Text = "MÃ"
        '
        'cmdDown
        '
        Me.cmdDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDown.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.Appearance.Options.UseFont = True
        Me.cmdDown.Image = CType(resources.GetObject("cmdDown.Image"), System.Drawing.Image)
        Me.cmdDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdDown.Location = New System.Drawing.Point(148, 157)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(137, 59)
        Me.cmdDown.TabIndex = 11
        Me.cmdDown.Text = "Xuống"
        '
        'cmdUp
        '
        Me.cmdUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUp.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp.Appearance.Options.UseFont = True
        Me.cmdUp.Image = CType(resources.GetObject("cmdUp.Image"), System.Drawing.Image)
        Me.cmdUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdUp.Location = New System.Drawing.Point(148, 92)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(137, 59)
        Me.cmdUp.TabIndex = 10
        Me.cmdUp.Text = "Lên"
        '
        'cmdOff
        '
        Me.cmdOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOff.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOff.Appearance.Options.UseFont = True
        Me.cmdOff.Image = CType(resources.GetObject("cmdOff.Image"), System.Drawing.Image)
        Me.cmdOff.Location = New System.Drawing.Point(5, 157)
        Me.cmdOff.Name = "cmdOff"
        Me.cmdOff.Size = New System.Drawing.Size(137, 59)
        Me.cmdOff.TabIndex = 9
        Me.cmdOff.Text = "Tắt"
        '
        'cmdOn
        '
        Me.cmdOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOn.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOn.Appearance.Options.UseFont = True
        Me.cmdOn.Image = CType(resources.GetObject("cmdOn.Image"), System.Drawing.Image)
        Me.cmdOn.Location = New System.Drawing.Point(5, 92)
        Me.cmdOn.Name = "cmdOn"
        Me.cmdOn.Size = New System.Drawing.Size(137, 59)
        Me.cmdOn.TabIndex = 8
        Me.cmdOn.Text = "Mở"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(291, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(285, 248)
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
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdThoat.Location = New System.Drawing.Point(148, 222)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(137, 59)
        Me.cmdThoat.TabIndex = 5
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdCapNhat
        '
        Me.cmdCapNhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCapNhat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapNhat.Appearance.Options.UseFont = True
        Me.cmdCapNhat.Image = CType(resources.GetObject("cmdCapNhat.Image"), System.Drawing.Image)
        Me.cmdCapNhat.Location = New System.Drawing.Point(5, 222)
        Me.cmdCapNhat.Name = "cmdCapNhat"
        Me.cmdCapNhat.Size = New System.Drawing.Size(137, 59)
        Me.cmdCapNhat.TabIndex = 4
        Me.cmdCapNhat.Text = "Cập nhật"
        '
        'txtName
        '
        Me.txtName.EditValue = "00"
        Me.txtName.Location = New System.Drawing.Point(148, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtName.Size = New System.Drawing.Size(137, 31)
        Me.txtName.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.EditValue = "00"
        Me.txtID.Location = New System.Drawing.Point(5, 55)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(137, 31)
        Me.txtID.TabIndex = 1
        '
        'frm_Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 607)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Printer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Area"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
