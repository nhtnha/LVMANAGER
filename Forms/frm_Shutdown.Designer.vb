<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Shutdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Shutdown))
        Me.cmdTurnOff = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRestart = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTurnOff
        '
        Me.cmdTurnOff.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTurnOff.Appearance.Options.UseFont = True
        Me.cmdTurnOff.Image = CType(resources.GetObject("cmdTurnOff.Image"), System.Drawing.Image)
        Me.cmdTurnOff.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdTurnOff.Location = New System.Drawing.Point(12, 12)
        Me.cmdTurnOff.Name = "cmdTurnOff"
        Me.cmdTurnOff.Size = New System.Drawing.Size(123, 89)
        Me.cmdTurnOff.TabIndex = 3
        Me.cmdTurnOff.Text = "Tắt máy"
        '
        'cmdRestart
        '
        Me.cmdRestart.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestart.Appearance.Options.UseFont = True
        Me.cmdRestart.Image = CType(resources.GetObject("cmdRestart.Image"), System.Drawing.Image)
        Me.cmdRestart.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdRestart.Location = New System.Drawing.Point(141, 12)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(123, 89)
        Me.cmdRestart.TabIndex = 4
        Me.cmdRestart.Text = "Khởi động lại"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(270, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(123, 89)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Đóng"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdTurnOff)
        Me.PanelControl1.Controls.Add(Me.cmdClose)
        Me.PanelControl1.Controls.Add(Me.cmdRestart)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(406, 113)
        Me.PanelControl1.TabIndex = 6
        '
        'frm_Shutdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 113)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Shutdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTurnOff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRestart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
