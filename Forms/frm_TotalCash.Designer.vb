<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TotalCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TotalCash))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.lblRate = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtOrderCost = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCashType = New DevExpress.XtraEditors.TextEdit
        Me.cmdTotal = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtRemain = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPay = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtOrderCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.lblRate)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtOrderCost)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtCashType)
        Me.PanelControl1.Controls.Add(Me.cmdTotal)
        Me.PanelControl1.Controls.Add(Me.cmdClose)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtRemain)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtPay)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtTotal)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(283, 235)
        Me.PanelControl1.TabIndex = 213
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(169, 10)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(11, 21)
        Me.LabelControl6.TabIndex = 221
        Me.LabelControl6.Text = "x"
        '
        'lblRate
        '
        Me.lblRate.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblRate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblRate.Location = New System.Drawing.Point(191, 10)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(76, 21)
        Me.lblRate.TabIndex = 219
        Me.lblRate.Text = "20.145"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(6, 106)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(90, 21)
        Me.LabelControl5.TabIndex = 220
        Me.LabelControl5.Text = "Tiền HĐ :"
        '
        'txtOrderCost
        '
        Me.txtOrderCost.EditValue = ""
        Me.txtOrderCost.Location = New System.Drawing.Point(102, 101)
        Me.txtOrderCost.Name = "txtOrderCost"
        Me.txtOrderCost.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtOrderCost.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderCost.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtOrderCost.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrderCost.Properties.Appearance.Options.UseFont = True
        Me.txtOrderCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtOrderCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOrderCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOrderCost.Size = New System.Drawing.Size(165, 31)
        Me.txtOrderCost.TabIndex = 219
        Me.txtOrderCost.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(6, 10)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 21)
        Me.LabelControl4.TabIndex = 218
        Me.LabelControl4.Text = "Loại tiền :"
        '
        'txtCashType
        '
        Me.txtCashType.EditValue = ""
        Me.txtCashType.Location = New System.Drawing.Point(102, 5)
        Me.txtCashType.Name = "txtCashType"
        Me.txtCashType.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCashType.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtCashType.Properties.Appearance.Options.UseBackColor = True
        Me.txtCashType.Properties.Appearance.Options.UseFont = True
        Me.txtCashType.Properties.Appearance.Options.UseForeColor = True
        Me.txtCashType.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCashType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCashType.Size = New System.Drawing.Size(61, 31)
        Me.txtCashType.TabIndex = 217
        Me.txtCashType.TabStop = False
        '
        'cmdTotal
        '
        Me.cmdTotal.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTotal.Appearance.Options.UseFont = True
        Me.cmdTotal.Image = CType(resources.GetObject("cmdTotal.Image"), System.Drawing.Image)
        Me.cmdTotal.Location = New System.Drawing.Point(6, 169)
        Me.cmdTotal.Name = "cmdTotal"
        Me.cmdTotal.Size = New System.Drawing.Size(133, 61)
        Me.cmdTotal.TabIndex = 216
        Me.cmdTotal.Text = "Tính tiền"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(145, 169)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(133, 61)
        Me.cmdClose.TabIndex = 215
        Me.cmdClose.Text = "Trở về"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(6, 138)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 21)
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Thối lại :"
        '
        'txtRemain
        '
        Me.txtRemain.EditValue = ""
        Me.txtRemain.Location = New System.Drawing.Point(102, 133)
        Me.txtRemain.Name = "txtRemain"
        Me.txtRemain.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemain.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemain.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtRemain.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemain.Properties.Appearance.Options.UseFont = True
        Me.txtRemain.Properties.Appearance.Options.UseForeColor = True
        Me.txtRemain.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRemain.Size = New System.Drawing.Size(165, 31)
        Me.txtRemain.TabIndex = 38
        Me.txtRemain.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(6, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 21)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Khách trả :"
        '
        'txtPay
        '
        Me.txtPay.EditValue = ""
        Me.txtPay.Location = New System.Drawing.Point(102, 37)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPay.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPay.Properties.Appearance.Options.UseBackColor = True
        Me.txtPay.Properties.Appearance.Options.UseFont = True
        Me.txtPay.Properties.Appearance.Options.UseForeColor = True
        Me.txtPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPay.Size = New System.Drawing.Size(165, 31)
        Me.txtPay.TabIndex = 36
        Me.txtPay.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(6, 74)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 21)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Thành tiền :"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = ""
        Me.txtTotal.Location = New System.Drawing.Point(102, 69)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Size = New System.Drawing.Size(165, 31)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TabStop = False
        '
        'frm_TotalCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 259)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TotalCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HÓA ĐƠN TÍNH TIỀN"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtOrderCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdTotal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCashType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrderCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRate As DevExpress.XtraEditors.LabelControl
End Class
