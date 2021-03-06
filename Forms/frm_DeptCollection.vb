Public Class frm_DeptCollection
#Region "Khai Báo Biến"
    Dim mvCls_EmployeeUpdate As New cls_Customer_Update
    Dim mvCls_Dept As New cls_Depts
    Dim mvCls_DeptUpdate As New cls_Dept_Update
    Dim mvCls_Income As New cls_Income
    Dim mvCls_IncomeUpdate As New cls_Income_Update
    Public gvStr_Status As String
    Dim mvUrc_Caculator As New urc_Calculator()
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        AddHandler mvUrc_Caculator.txtInput.TextChanged, AddressOf txtInput_TextChanged
        SubM_LoadEmployee()
        SubM_LoadBill()
        mod_Format.Sub_ShowControl(mvUrc_Caculator, 30)
        Me.txtID.Text = ""
        Me.DateEdit1.EditValue = Nothing
        Me.txtIsPaid.Text = "0"
        Me.txtFinalTotal.Text = "0"
        Me.txtPay.Text = "0"
        mod_LoadLanguageForm.SubG_GroupItemForm()
        mvUrc_Caculator.txtInput.Text = ""
        If gvByte_Language = 1 Then
            Me.GroupControl1.Text = "Danh sách phiếu"
            Me.gpcHeader.Text = "Trả nợ"
            Me.LabelControl4.Text = "Số HĐ:"
            Me.LabelControl5.Text = "Ngày:"
            Me.LabelControl2.Text = "Khách hàng:"
            Me.lblID.Text = "Tiền nợ:"

            Me.LabelControl6.Text = "Đã trả:"
            Me.LabelControl1.Text = "Số tiền trả:" 'Unité calculer
            Me.LabelControl3.Text = "Còn lại:"

            cmdConfirm.Text = "Xác nhận"
            cmdExit.Text = "Thoát"
        Else
            cmdConfirm.Text = "Confirm"
            cmdExit.Text = "Exit"
            Me.GroupControl1.Text = "LIST DEBT"
            Me.gpcHeader.Text = "Pay Debt"
            Me.LabelControl4.Text = "Invoice No: "
            Me.LabelControl5.Text = "Date:"
            Me.LabelControl2.Text = "Customer:"
            Me.lblID.Text = "Debt amount:"

            Me.LabelControl6.Text = "Paid:"
            Me.LabelControl1.Text = "Pay amount:" 'Unité calculer
            Me.LabelControl3.Text = "Remain:"

        End If
    End Sub
#End Region
#Region "Load employee"
    Private Sub SubM_LoadEmployee()
        Dim mvObj_DataTable As New DataTable
        Try
            If gvStr_Status = "KH" Then
                mvObj_DataTable = mvCls_EmployeeUpdate.FuncG_GetAll(1)
            Else
                mvObj_DataTable = mvCls_EmployeeUpdate.FuncG_GetAll(3)
            End If
            Me.lkpCustomer.Properties.DataSource = mvObj_DataTable
            Me.lkpCustomer.Properties.DisplayMember = "Tên"
            Me.lkpCustomer.Properties.ValueMember = "Mã"
            Me.lkpCustomer.EditValue = Nothing
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load bill"
    Private Sub SubM_LoadBill()
        Dim mvObj_DataTable As New DataTable
        Try
            If gvStr_Status = "KH" Then
                mvObj_DataTable = mvCls_DeptUpdate.FuncG_GetAllData(0)
            Else
                mvObj_DataTable = mvCls_DeptUpdate.FuncG_GetAllData(1)
            End If
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns()
            If gvByte_Language = 1 Then
                Me.GridView1.Columns(0).Caption = "Số HĐ"
                Me.GridView1.Columns(1).Caption = "Ngày"
                If gvStr_Status = "KH" Then
                    Me.GridView1.Columns(3).Caption = "Tên KH"
                Else
                    Me.GridView1.Columns(3).Caption = "Tên NCC"
                End If
                Me.GridView1.Columns(4).Caption = "Tiền nợ"
                Me.GridView1.Columns(5).Caption = "Đã trả"
            Else
                Me.GridView1.Columns(0).Caption = "Bill No"
                Me.GridView1.Columns(1).Caption = "Create date"
                If gvStr_Status = "KH" Then
                    Me.GridView1.Columns(3).Caption = "Customer"
                Else
                    Me.GridView1.Columns(3).Caption = "Supplier"
                End If
                Me.GridView1.Columns(4).Caption = "Dept"
                Me.GridView1.Columns(5).Caption = "IsPaid"
            End If
            Me.GridView1.Columns(0).Width = 150
            Me.GridView1.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridView1.Columns(1).DisplayFormat.FormatString = "dd/MM/yyyy"
            Me.GridView1.Columns(1).Width = 100
            Me.GridView1.Columns(2).Visible = False
            Me.GridView1.Columns(6).Visible = False
            Me.GridView1.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Đánh số thứ tự cho girdview"
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        Try
            Dim mvInt_RowIndex As Integer = e.RowHandle
            If mvInt_RowIndex >= 0 Then
                mvInt_RowIndex += 1
                e.Info.DisplayText = mvInt_RowIndex.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Click girdview"
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                Me.txtID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(0)
                Me.DateEdit1.DateTime = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(1)
                Me.lkpCustomer.EditValue = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(2)
                Me.txtFinalTotal.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(4)
                Me.txtIsPaid.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(5)
                SubG_FormatNumberDigit(Me.txtFinalTotal, 0)
                SubG_FormatNumberDigit(Me.txtIsPaid, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "FormLoad"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Textchange"
    Private Sub txtInput_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtPay.Text = mvUrc_Caculator.txtInput.Text
        SubG_FormatNumberDigit(Me.txtPay, 0)
    End Sub
    Private Sub txtPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPay.KeyPress
        SubG_OnlyInputDigit(Me.txtPay, e, False)
    End Sub
    Private Sub txtTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinalTotal.TextChanged, txtPay.TextChanged, txtIsPaid.TextChanged
        Dim mvDbl_Pay As Double = 0
        Try
            If String.IsNullOrEmpty(Me.txtPay.Text) Then
                mvDbl_Pay = 0
            Else
                mvDbl_Pay = Convert.ToDouble(Me.txtPay.Text)
            End If
            Me.txtRemain.Text = Convert.ToDouble(Me.txtFinalTotal.Text) - Convert.ToDouble(Me.txtIsPaid.Text) - mvDbl_Pay
            SubG_FormatNumberDigit(Me.txtRemain, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPay_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPay.Leave
        SubG_FormatNumberDigit(Me.txtPay, 0)
    End Sub
#End Region
#Region "Nút Confirm"
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(76)
                'FunG_Alert("Lỗi", "Chưa chọn hóa đơn cần thanh toán!", frm_Alert.WTYPE.ERROR)
            ElseIf mvUrc_Caculator.txtInput.Text = "" Then
                SubG_Alert(77)
                'FunG_Alert("Lỗi", "Chưa nhập số tiền cần thanh toán!", frm_Alert.WTYPE.ERROR)
            ElseIf Convert.ToDouble(mvUrc_Caculator.txtInput.Text) = 0 Then
                SubG_Alert(78)
                'FunG_Alert("Lỗi", "Số tiền cần thanh toán phải lớn hơn 0!", frm_Alert.WTYPE.ERROR)
            Else
                If Convert.ToDouble(Me.txtRemain.Text) < 0 Then
                    SubG_Alert(79)
                    'FunG_Alert("Lỗi", "Số tiền trả không được lớn hơn số tiền nợ!", frm_Alert.WTYPE.ERROR)
                Else
                    'Cập nhật bảng công nợ và lưu vào history
                    mvCls_Dept.InvoiceID = Me.txtID.Text
                    mvCls_Dept.Dept = Me.txtPay.Text
                    If mvCls_DeptUpdate.FuncG_Update(mvCls_Dept) Then
                        If gvStr_Status = "KH" Then
                            mvCls_Income.ID = mvCls_IncomeUpdate.FuncG_CreateInvoiceNo("PT")
                            mvCls_Income.Quantity = Math.Round(Convert.ToDouble(Me.txtPay.Text), 0)
                            mvCls_Income.CurrencyID = "VND"
                            mvCls_Income.Rate = 1
                            mvCls_Income.People = lkpCustomer.Text
                            mvCls_Income.CreateDate = Date.Now
                            mvCls_Income.Description = "Thu nợ " + Me.txtID.Text
                        Else
                            mvCls_Income.ID = mvCls_IncomeUpdate.FuncG_CreateInvoiceNo("PC")
                            mvCls_Income.Quantity = -Math.Round(Convert.ToDouble(Me.txtPay.Text), 0)
                            mvCls_Income.CurrencyID = "VND"
                            mvCls_Income.Rate = 1
                            mvCls_Income.People = lkpCustomer.Text
                            mvCls_Income.CreateDate = Date.Now
                            mvCls_Income.Description = "Trả nợ cho nhà cung cấp(N-C-C)"
                        End If
                        mvCls_IncomeUpdate.FuncG_InsertReceiptPayment(mvCls_Income)
                    End If
                    SubG_Alert(80) 'FunG_Alert("Thông báo", "Cập nhật thành công!", frm_Alert.WTYPE.CHECK)
                    SubM_InitializeForm()
                End If
            End If
           
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region
End Class