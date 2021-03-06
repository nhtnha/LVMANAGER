Imports DevExpress.XtraEditors.DXErrorProvider
Public Class frm_ReceiptPayment
#Region "Khai Báo Biến"
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
    Dim mvCls_Income As New cls_Income
    Dim mvCls_IncomeUpdate As New cls_Income_Update
    Dim mvBol_Close As Boolean = False
    Public mvStr_Type As String
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        DateEdit1.EditValue = Now
        Me.txtUser.Text = ""
        Me.txtMoney.Text = ""
        Me.mmeDescription.Text = ""
        Me.cmdReceipt.Enabled = False
        Me.cmdPayment.Enabled = True
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        mod_LoadLanguageForm.SubG_ReceiptPaymentForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 16)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        'Form.ActiveForm.ActiveControl = Me.txtUser
        Me.txtUser.BackColor = Color.LightSkyBlue
        Me.txtMoney.BackColor = Color.White
        Me.mmeDescription.BackColor = Color.White
        gvTxt_Focus = Me.txtUser
        mvBol_Close = False
        If mvStr_Type = "PT" Then
            Me.cmdReceipt.Enabled = False
            Me.cmdPayment.Enabled = True
            If gvByte_Language = 1 Then
                Me.gpcHeader.Text = "Tạo phiếu thu"
                Me.lblUser.Text = "Người nộp tiền"
                LabelControl1.Text = "Ngày lập"
                gpcHeader.Text = "THU - CHI"
                Me.Text = "THU - CHI"
            Else
                Me.Text = "Receipt - Payment".ToUpper
                gpcHeader.Text = "Receipt - Payment".ToUpper
                LabelControl1.Text = "Create date"
                Me.gpcHeader.Text = "Create receipt voucher"
                Me.lblUser.Text = "Payer"
            End If
        Else
            Me.cmdReceipt.Enabled = True
            Me.cmdPayment.Enabled = False
            If gvByte_Language = 1 Then
                Me.gpcHeader.Text = "Tạo phiếu chi"
                Me.lblUser.Text = "Người nhận tiền"
            Else
                Me.gpcHeader.Text = "Create payment voucher"
                Me.lblUser.Text = "Receiver"
            End If
        End If
        DateEdit1.DateTime = DateTime.Now
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_DiscountServiceVat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not mvBol_Close Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Change textbox focus"
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.Enter, txtMoney.Enter, mmeDescription.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtUser" Then
                Me.txtUser.BackColor = Color.LightSkyBlue
                Me.txtMoney.BackColor = Color.White
                Me.mmeDescription.BackColor = Color.White
                gvTxt_Focus = Me.txtUser
            ElseIf mvCtr_ActiveControl.Name = "txtMoney" Then
                Me.txtUser.BackColor = Color.White
                Me.txtMoney.BackColor = Color.LightSkyBlue
                Me.mmeDescription.BackColor = Color.White
                gvTxt_Focus = Me.txtMoney
            ElseIf mvCtr_ActiveControl.Name = "mmeDescription" Then
                Me.txtUser.BackColor = Color.White
                Me.txtMoney.BackColor = Color.White
                Me.mmeDescription.BackColor = Color.LightSkyBlue
                gvTxt_Focus = Me.mmeDescription
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Valid"
    Private Sub txtTextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged
        Me.DxValidationProvider1.Validate()
    End Sub
#End Region
#Region "Format money"
    Private Sub txtMoney_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave, txtMoney.Leave, mmeDescription.Leave
        If IsNumeric(Me.txtMoney.Text) Then
            SubG_FormatNumberDigit(Me.txtMoney, gvByte_Digit)
        End If
    End Sub
#End Region
#Region "Nút Receipt"
    Private Sub cmdReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReceipt.Click
        Me.cmdReceipt.Enabled = False
        Me.cmdPayment.Enabled = True
        If gvByte_Language = 1 Then
            Me.gpcHeader.Text = "Tạo phiếu thu"
            Me.lblUser.Text = "Người nộp tiền"
        Else
            Me.gpcHeader.Text = "Create receipt voucher"
            Me.lblUser.Text = "Payer"
        End If
    End Sub
#End Region
#Region "Nút Payment"
    Private Sub cmdPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayment.Click
        Me.cmdReceipt.Enabled = True
        Me.cmdPayment.Enabled = False
        If gvByte_Language = 1 Then
            Me.gpcHeader.Text = "Tạo phiếu chi"
            Me.lblUser.Text = "Người nhận tiền"
        Else
            Me.gpcHeader.Text = "Create payment voucher"
            Me.lblUser.Text = "Receiver"
        End If
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If DateTime.Parse(DateEdit1.EditValue) > Now Then
                If gvByte_Language = 1 Then
                    FunG_Alert("Thông Báo", "Ngày lập phải <= ngày hiện tại", frm_Alert.WTYPE.ERROR)
                Else
                    FunG_Alert("Message", "Created less than or equal to the current day", frm_Alert.WTYPE.ERROR)
                End If

                Return
            End If
            If Me.DxValidationProvider1.Validate() Then
                If String.IsNullOrEmpty(Me.txtUser.Text) Then
                    If Me.cmdReceipt.Enabled Then
                        SubG_Alert(106) '   FunG_Alert("Lỗi", "Vui lòng nhập tên người nhận tiền!", frm_Alert.WTYPE.ERROR)
                    Else
                        SubG_Alert(107) ' FunG_Alert("Lỗi", "Vui lòng nhập tên người nộp tiền!", frm_Alert.WTYPE.ERROR)
                    End If
                ElseIf String.IsNullOrEmpty(Me.txtMoney.Text) Then
                    If gvByte_Language = 1 Then
                        FunG_Alert("Lỗi", "Vui lòng nhập số tiền!", frm_Alert.WTYPE.ERROR)
                    Else
                        FunG_Alert("Error", "Please enter the amount!", frm_Alert.WTYPE.ERROR)
                    End If
                ElseIf Not IsNumeric(Me.txtMoney.Text) Then
                    SubG_Alert(108) ' FunG_Alert("Lỗi", "Số tiền phải số!", frm_Alert.WTYPE.ERROR)
                ElseIf Convert.ToDouble(Me.txtMoney.Text) = 0 Then
                    SubG_Alert(109) '  FunG_Alert("Lỗi", "Số tiền phải lớn hơn 0!", frm_Alert.WTYPE.ERROR)
                Else
                    'Kiểm tra HĐ
                    Dim CRDATE As DateTime = New DateTime(Convert.ToDateTime(DateEdit1.EditValue).Year, Convert.ToDateTime(DateEdit1.EditValue).Month, Convert.ToDateTime(DateEdit1.EditValue).Day)
                    If Me.cmdReceipt.Enabled Then
                        'TH là phiếu chi ( phiếu nào thì nút phiếu đó enable = false )
                        mvCls_Income.ID = mvCls_IncomeUpdate.FuncG_CreateInvoiceNo("PC", CRDATE)
                        mvCls_Income.Quantity = -Math.Round(Convert.ToDouble(Me.txtMoney.Text), 0)
                    Else
                        'TH là phiếu thu
                        mvCls_Income.ID = mvCls_IncomeUpdate.FuncG_CreateInvoiceNo("PT", CRDATE)
                        mvCls_Income.Quantity = Math.Round(Convert.ToDouble(Me.txtMoney.Text), 0)
                    End If
                    mvCls_Income.People = txtUser.Text
                    mvCls_Income.CurrencyID = "VND"
                    mvCls_Income.Rate = 1
                    mvCls_Income.Description = Me.mmeDescription.Text
                    mvCls_Income.CreateDate = DateEdit1.EditValue
                    mvCls_IncomeUpdate.FuncG_InsertReceiptPayment(mvCls_Income)
                    SubM_InitializeForm()
                    End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        mvBol_Close = True
        Me.Close()
    End Sub
#End Region
End Class