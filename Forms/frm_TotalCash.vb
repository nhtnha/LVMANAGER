Public Class frm_TotalCash
#Region "Khai báo biến"
    Public gvStr_Currency As String
    Dim mvCls_RateUpdate As New cls_Rate_Update
    Dim mvCls_Table As New cls_Table
    Dim mvCls_TableUpdate As New cls_Table_Update
    Dim mvCls_Income As New cls_Income
    Dim mvCls_IncomeUpdate As New cls_Income_Update
    Dim mvCls_SaleUpdate As New cls_Sales_Update
    Dim mvCls_PrintTempUpdate As New cls_PrintTempUpdate
#End Region
#Region "Hàm khởi tạo"
    Public Sub SubM_InitializeForm()
        Try
            SubM_LoadRate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load rate"
    Private Sub SubM_LoadRate()
        Dim mvObj_DataTable As New DataTable
        Try
            If gvStr_Currency <> "" Then
                mvObj_DataTable = mvCls_RateUpdate.FuncG_GetData(gvStr_Currency)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.txtCashType.Text = gvStr_Currency
                    Me.lblRate.Text = mvObj_DataTable.Rows(0)("RATE")
                    SubG_FormatNumberDigit(Me.lblRate, 0)
                Else
                    Me.txtCashType.Text = "VND"
                    Me.lblRate.Text = "1"
                End If
                Me.txtTotal.Text = Convert.ToDouble(Me.txtPay.Text) * Convert.ToDouble(Me.lblRate.Text)
                SubG_FormatNumberDigit(Me.txtPay, 0)
                SubG_FormatNumberDigit(Me.txtTotal, 0)
                Me.txtRemain.Text = Convert.ToDouble(Me.txtTotal.Text) - Convert.ToDouble(Me.txtOrderCost.Text)
                SubG_FormatNumberDigit(Me.txtRemain, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_TotalCash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút total"
    Private Sub cmdTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTotal.Click
        Try
            'Đưa tiền vào két
            If Me.txtCashType.Text = "USD" Or Me.txtCashType.Text = "EURO" Then
                'Nếu là tiền USD hoặc EURO
                mvCls_Income.ID = frm_Cash.txtSoHD.Text
                mvCls_Income.CurrencyID = Me.txtCashType.Text
                mvCls_Income.Quantity = Me.txtPay.Text
                mvCls_Income.Rate = Me.lblRate.Text
                mvCls_Income.Description = ""
                mvCls_IncomeUpdate.FuncG_Insert(mvCls_Income)
                'Trừ tiền Việt trong kho ra
                mvCls_Income.CurrencyID = "VND"
                mvCls_Income.Quantity = -Math.Round(Convert.ToDouble(Me.txtRemain.Text), 0)
                mvCls_Income.Rate = 1
                mvCls_Income.Description = "Trả ngoại tệ"
                mvCls_IncomeUpdate.FuncG_Insert(mvCls_Income)
            Else
                mvCls_Income.ID = frm_Cash.txtSoHD.Text
                mvCls_Income.CurrencyID = Me.txtCashType.Text
                mvCls_Income.Quantity = Me.txtPay.Text
                mvCls_Income.Rate = Me.lblRate.Text
                mvCls_Income.Description = ""
                mvCls_IncomeUpdate.FuncG_Insert(mvCls_Income)
            End If
            'Xóa bảng in tạm
            mvCls_PrintTempUpdate.FuncG_Delete(frm_Cash.txtSoHD.Text)
            'Cập nhật lại trạng thái bàn
            mvCls_Table.ID = frm_Cash.txtTable.Tag
            mvCls_Table.Name = frm_Cash.txtTable.Text
            mvCls_Table.Status = 1  'Trạng thái ban đầu
            mvCls_TableUpdate.FuncG_InsertUpdateDelete(mvCls_Table)
            'Cập nhật trạng thái hóa đơn
            ' Status = 1 : complete, 2 : used, 3 : tranfer
            mvCls_SaleUpdate.FuncG_UpdateStatus(frm_Cash.txtSoHD.Text, 1)
            'In hóa đơn tính tiền
            If frm_Cash.cmdPrintBill.Text = "In HĐ" Or frm_Cash.cmdPrintBill.Text = "Print bill" Then
                'Kiểm tra số liên
                Dim mvRpt_Bill As New rpt_Bill
                LoadReport(mvRpt_Bill)
                SubM_LoadInfoInReport(mvRpt_Bill)
                mvRpt_Bill.SetParameterValue("ID", frm_Cash.txtSoHD.Text)
                For i As Integer = 0 To gvByte_NumberPrint - 1
                    mvRpt_Bill.SetParameterValue("Count", i + 1)
                    mvRpt_Bill.PrintToPrinter(1, True, 0, 0)
                Next
            End If
            frm_Cash.Close()
            frm_Table.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút close"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
End Class