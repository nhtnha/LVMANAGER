<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Alert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Alert))
        Me.cmdNo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdYes = New DevExpress.XtraEditors.SimpleButton
        Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label
        CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNo
        '
        Me.cmdNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNo.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNo.Appearance.Options.UseFont = True
        Me.cmdNo.Image = CType(resources.GetObject("cmdNo.Image"), System.Drawing.Image)
        Me.cmdNo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdNo.Location = New System.Drawing.Point(292, 56)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(86, 40)
        Me.cmdNo.TabIndex = 9
        Me.cmdNo.Text = "Không"
        Me.cmdNo.Visible = False
        '
        'cmdYes
        '
        Me.cmdYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdYes.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYes.Appearance.Options.UseFont = True
        Me.cmdYes.Image = CType(resources.GetObject("cmdYes.Image"), System.Drawing.Image)
        Me.cmdYes.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdYes.Location = New System.Drawing.Point(200, 56)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(86, 40)
        Me.cmdYes.TabIndex = 8
        Me.cmdYes.Text = "Có"
        Me.cmdYes.Visible = False
        '
        'pictureEdit
        '
        Me.pictureEdit.Location = New System.Drawing.Point(8, 11)
        Me.pictureEdit.Name = "pictureEdit"
        Me.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pictureEdit.Size = New System.Drawing.Size(32, 32)
        Me.pictureEdit.TabIndex = 6
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(292, 56)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(86, 40)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Thoát"
        '
        'imageCollection
        '
        Me.imageCollection.ImageSize = New System.Drawing.Size(128, 128)
        Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection.Images.SetKeyName(0, "Delete.png")
        Me.imageCollection.Images.SetKeyName(1, "Warning.png")
        Me.imageCollection.Images.SetKeyName(2, "Duyet_001.png")
        Me.imageCollection.Images.SetKeyName(3, "help.png")
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Black
        Me.lblMsg.Location = New System.Drawing.Point(46, 8)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(332, 38)
        Me.lblMsg.TabIndex = 74
        Me.lblMsg.Text = "Thông báo"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_Alert
        '
        Me.AcceptButton = Me.cmdExit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 99)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.cmdNo)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.pictureEdit)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Alert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pictureEdit As DevExpress.XtraEditors.PictureEdit
    Private WithEvents imageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Public WithEvents cmdNo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmdYes As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
End Class
