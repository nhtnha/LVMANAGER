Public Class frm_Table
#Region "Khai báo biến"
    Public gvBol_Spilit As Boolean = False
    Public gvBol_Combined As Boolean = False
    Public gvBol_Transfer As Boolean = False
    Dim mvCls_TableUpdate As New cls_Table_Update
    Dim mvCls_SaleUpdate As New cls_Sales_Update
    Dim mvCls_PrintTempUpdate As New cls_PrintTempUpdate
#End Region
#Region "Hàm Khởi Tạo"
    Public Sub SubM_InitializeForm()
        Try
            Me.txtUser.Text = gvStr_AccUser
            Me.lblCompany.Text = gvCls_Company.Name
            Me.lblAddress.Text = String.Format("{0} - ĐT : {1} - Fax : {2}", gvCls_Company.Address, gvCls_Company.Phone, gvCls_Company.Fax)
            Me.lblCompany.Left = (Me.ClientRectangle.Width / 2) - (Me.lblCompany.Width / 2)
            mod_LoadLanguageForm.SubG_TableForm()
            Dim mvUrc_Table As New urc_Table
            mod_Format.Sub_ShowControl(mvUrc_Table, 3)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_Table_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = Keys.F4) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frm_MainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Refresh time"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtTime.Text = Format(Now(), "dd/MM/yyyy HH:mm:ss")
    End Sub
#End Region
#Region "Nút Open"
    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        Try
            If Me.txtBan.Tag Is Nothing Then
                FunG_Alert("Thông báo lỗi", "Chưa chọn bàn cần sử dụng!", frm_Alert.WTYPE.STOP)
            Else
                frm_Sale.txtTable.Tag = Me.txtBan.Tag
                frm_Sale.txtTable.Text = Me.txtBan.Text
                frm_Sale.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút ChangePass"
    Private Sub cmdChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangePass.Click
        frm_ChangePassword.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút Receipt-Payment"
    Private Sub cmdReceiptPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReceiptPayment.Click
        frm_ReceiptPayment.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút Split"
    Private Sub cmdSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSplit.Click
        If Me.txtBan.Tag IsNot Nothing Then
            If FuncG_CheckStatus(Me.txtBan.Tag) = 2 Then
                gvBol_Spilit = True
                gvBol_Combined = False
                gvBol_Transfer = False
            Else
                FunG_Alert("Thông báo lỗi", "Không thể sử dụng chức năng này!", frm_Alert.WTYPE.STOP)
            End If
        End If
    End Sub
#End Region
#Region "Nút Enter"
    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        If Me.txtBan.Tag IsNot Nothing Then
            If FuncG_CheckStatus(Me.txtBan.Tag) = 2 Then
                gvBol_Spilit = False
                gvBol_Combined = True
                gvBol_Transfer = False
            Else
                FunG_Alert("Thông báo lỗi", "Không thể sử dụng chức năng này!", frm_Alert.WTYPE.STOP)
            End If
        End If
    End Sub
#End Region
#Region "Nút Transfer"
    Private Sub cmdTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransfer.Click
        If Me.txtBan.Tag IsNot Nothing Then
            If FuncG_CheckStatus(Me.txtBan.Tag) = 2 Then
                gvBol_Spilit = False
                gvBol_Combined = False
                gvBol_Transfer = True
            Else
                FunG_Alert("Thông báo lỗi", "Không thể sử dụng chức năng này!", frm_Alert.WTYPE.STOP)
            End If
        End If
    End Sub
#End Region
#Region "Nút RePrint"
    Private Sub cmdRePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRePrint.Click
        frm_RePrintBill.ShowDialog()
    End Sub
#End Region
#Region "Nút Delete"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim mvObj_DataTable As New DataTable
        Dim mvCls_Table As New cls_Table
        Dim mvStr_BillNo As String
        Try
            If Me.txtBan.Tag IsNot Nothing Then
                If FuncG_CheckStatus(Me.txtBan.Tag) = 1 Then
                    FunG_Alert("Thông báo lỗi", "Bàn này chưa sử dụng nên không thể hủy!", frm_Alert.WTYPE.STOP)
                Else
                    If FunG_Alert("Xác nhận", String.Format("Bạn có muốn hủy {0} không?", Me.txtBan.Text), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                        'Cập nhật trạng thái bàn
                        mvCls_Table.ID = Me.txtBan.Tag
                        mvCls_Table.Name = Me.txtBan.Text
                        mvCls_Table.Status = 1
                        mvCls_TableUpdate.FuncG_InsertUpdateDelete(mvCls_Table)
                        'Cập nhật lại trạng thái hóa đơn
                        'Bàn đang sử dụng, lấy về số HĐ
                        mvObj_DataTable = mvCls_SaleUpdate.FuncG_GetDataByTableID(Me.txtBan.Tag)
                        If mvObj_DataTable.Rows.Count <> 0 Then
                            mvStr_BillNo = mvObj_DataTable.Rows(0)("ID")
                            ' Trạng thái HĐ 1:completed , 2:used, 3:tranfered, 4:deleted
                            mvCls_SaleUpdate.FuncG_DeleteBill(mvStr_BillNo, gvProp_AccUser, 4)
                            ' Xóa bảng in tạm TBL_PRINT_TEMP
                            mvCls_PrintTempUpdate.FuncG_Delete(mvStr_BillNo)
                            SubM_InitializeForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click, cmdExit.Click
        frm_MainMenu.Show()
        Me.Close()
    End Sub
#End Region
End Class