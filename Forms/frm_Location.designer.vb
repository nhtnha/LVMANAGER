<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Location
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Location))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton
        Me.lblDiaDiem = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
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
        Me.gpcHeader.Controls.Add(Me.cmdEdit)
        Me.gpcHeader.Controls.Add(Me.cmdAddNew)
        Me.gpcHeader.Controls.Add(Me.lblDiaDiem)
        Me.gpcHeader.Controls.Add(Me.GridControl1)
        Me.gpcHeader.Controls.Add(Me.cmdClose)
        Me.gpcHeader.Controls.Add(Me.cmdConfirm)
        Me.gpcHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpcHeader.Location = New System.Drawing.Point(0, 0)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(746, 325)
        Me.gpcHeader.TabIndex = 1
        Me.gpcHeader.Text = "Chọn địa điểm"
        '
        'cmdEdit
        '
        Me.cmdEdit.AccessibleDescription = ""
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(322, 263)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(135, 57)
        Me.cmdEdit.TabIndex = 248
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.AccessibleDescription = ""
        Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddNew.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Appearance.Options.UseFont = True
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.Location = New System.Drawing.Point(181, 263)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(135, 57)
        Me.cmdAddNew.TabIndex = 247
        Me.cmdAddNew.Text = "Tạo mới"
        '
        'lblDiaDiem
        '
        Me.lblDiaDiem.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaDiem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDiaDiem.Location = New System.Drawing.Point(12, 280)
        Me.lblDiaDiem.Name = "lblDiaDiem"
        Me.lblDiaDiem.Size = New System.Drawing.Size(163, 21)
        Me.lblDiaDiem.TabIndex = 246
        Me.lblDiaDiem.Text = "Chọn địa điểm {0}"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(5, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(736, 224)
        Me.GridControl1.TabIndex = 245
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
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(606, 263)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(135, 57)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Thoát"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Image = CType(resources.GetObject("cmdConfirm.Image"), System.Drawing.Image)
        Me.cmdConfirm.Location = New System.Drawing.Point(463, 263)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(135, 57)
        Me.cmdConfirm.TabIndex = 6
        Me.cmdConfirm.Text = "Kết nối"
        '
        'frm_Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 325)
        Me.Controls.Add(Me.gpcHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Location"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn địa điểm"
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblDiaDiem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
End Class
