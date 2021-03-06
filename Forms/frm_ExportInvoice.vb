Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Public Class frm_ExportInvoice
#Region "Khai Báo Biến"
    Public gvStr_Status As String
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_CustomerUpdate As New cls_Customer_Update
    Dim mvCls_ImportExport As New cls_ImportExport
    Dim mvCls_ImportExportUpdate As New cls_ImportExport_Update
    Dim mvCls_ImExDetail As New cls_ImportExportDetail
    Dim mvCls_ImExDetailUpdate As New cls_ImportExportDetail_Update
    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Dim mvCls_MaterialUpdate As New cls_Material_Update
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadData()
        If gvStr_Status = "Add" Then
            SubM_CreateNewInvoice()
            'Me.cmdSave.Enabled = True
            SubM_AnHienButton(True)
        Else
            SubM_LoadInvoice()
            'Me.cmdSave.Enabled = True
            SubM_AnHienButton(False)
        End If
        Me.txtVAT.Text = "0"
        If gvByte_Language <> 1 Then
            Me.Text = "Export Invoice"
            GroupControl1.Text = "Export invoice Information"
            '===========================================================
            LabelControl7.Text = "Invoice ID"
            LabelControl2.Text = "Employee"
            LabelControl14.Text = "To Inventory"
            LabelControl1.Text = "Invoice No"
            LabelControl2.Text = "Date"
            LabelControl21.Text = "Description"
            LabelControl5.Text = "Providers"
            LabelControl13.Text = "From Inventory"
            '===========================================================
            GroupControl3.Text = "Item Information"
            '===========================================================
            lblOrderNo.Text = "Item ID"
            LabelControl6.Text = "Price"
            LabelControl11.Text = "VAT"
            LabelControl8.Text = "Item Name"
            LabelControl3.Text = "Quantity"
            LabelControl10.Text = "VAT Amount"
            LabelControl9.Text = "To Cash"
            LabelControl4.Text = "Total Cash"
            '===========================================================
            'CÁC NÚT
            '===========================================================
            cmdAdd.Text = "Add"
            cmdDelete.Text = "Delete"
            cmdExit.Text = "Exit"
            cmdPrint.Text = "Print"
            cmdSave.Text = "Save"
            '===========================================================
        Else

            Me.Text = "Phiếu nhập kho"
            GroupControl1.Text = "Thông tin phiếu nhập kho"
            '===========================================================
            LabelControl7.Text = "Số phiếu"
            LabelControl2.Text = "Nhân viên"
            LabelControl14.Text = "Đến kho"
            LabelControl1.Text = "Số HĐ"
            LabelControl12.Text = "Ngày CT"
            LabelControl21.Text = "Ghi chú"
            LabelControl5.Text = "Nhà cung cấp"
            LabelControl13.Text = "Từ kho"
            '===========================================================
            GroupControl3.Text = "Thông tin mặc hàng"
            '===========================================================
            lblOrderNo.Text = "Mã hàng"
            LabelControl6.Text = "Giá"
            LabelControl11.Text = "Vat"
            LabelControl8.Text = "Tên hàng hóa"
            LabelControl3.Text = "Số lượng"
            LabelControl10.Text = "Tiền Vat"
            LabelControl9.Text = "Thành tiền"
            LabelControl4.Text = "Tổng tiền"
            '===========================================================
            'CÁC NÚT
            '===========================================================
            cmdAdd.Text = "Thêm"
            cmdDelete.Text = "Xóa"
            cmdExit.Text = "Thoát"
            cmdPrint.Text = "In"
            cmdSave.Text = "Lưu"
            '===========================================================
        End If
    End Sub

    Private Sub SubM_AnHienButton(ByVal ah As Boolean)
        cmdAdd.Enabled = ah
        cmdDelete.Enabled = ah
        cmdSave.Enabled = ah
    End Sub
#End Region
#Region "Load Data"
    Private Sub SubM_LoadData()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable1 As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        Dim mvObj_DataTable3 As New DataTable
        Dim mvObj_DataTable4 As New DataTable
        Try
            mvObj_DataTable3 = mvCls_InventoryUpdate.FuncG_GetAllData()
            Me.lkpInventory.Properties.DataSource = mvObj_DataTable3
            Me.lkpInventory.Properties.DisplayMember = "InventoryName"
            Me.lkpInventory.Properties.ValueMember = "InventoryID"
            Me.lkpInventory.EditValue = "001"
            Me.lkpInventory.Properties.ShowHeader = False

            mvObj_DataTable4 = mvCls_InventoryUpdate.FuncG_GetAllData2()
            Me.lkpToInventory.Properties.DataSource = mvObj_DataTable4
            Me.lkpToInventory.Properties.DisplayMember = "InventoryName"
            Me.lkpToInventory.Properties.ValueMember = "InventoryID"
            Me.lkpToInventory.EditValue = "001"
            Me.lkpToInventory.Properties.ShowHeader = False


            mvObj_DataTable = mvCls_CustomerUpdate.FuncG_GetAll2(2)
            Me.lkpNhanVien.Properties.DataSource = mvObj_DataTable
            Me.lkpNhanVien.Properties.DisplayMember = "NAME"
            Me.lkpNhanVien.Properties.ValueMember = "ID"
            Me.lkpNhanVien.EditValue = Nothing

            mvObj_DataTable1 = mvCls_CustomerUpdate.FuncG_GetAll2(3)
            Me.lkpNhaCungCap.Properties.DataSource = mvObj_DataTable1
            Me.lkpNhaCungCap.Properties.DisplayMember = "NAME"
            Me.lkpNhaCungCap.Properties.ValueMember = "ID"
            Me.lkpNhaCungCap.EditValue = Nothing

            mvObj_DataTable2 = mvCls_MaterialUpdate.FuncG_GetAllDataByInventory()
            Me.lkpName.Properties.DataSource = mvObj_DataTable2
            Me.lkpName.Properties.DisplayMember = "MaterialName"
            Me.lkpName.Properties.ValueMember = "MaterialID"
            Me.lkpName.EditValue = Nothing

            Me.lkpName.Properties.PopulateColumns()
            Me.lkpName.Properties.Columns("LOC_ID").Visible = False
            Me.lkpName.Properties.Columns("ImportUnit").Visible = False
            Me.lkpName.Properties.Columns("ImportToInvRate").Visible = False
            Me.lkpName.Properties.Columns("ExportToInvRate").Visible = False

            'Me.lkpName.Properties.Columns("MaterialID").Caption = "Mã"
            'Me.lkpName.Properties.Columns("MaterialName").Caption = "Tên"
            'Me.lkpName.Properties.Columns("ExportUnit").Caption = "ĐV Xuất"
            'Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"
            ''Me.lkpName.Properties.Columns("ExportUnit").Caption = "ĐV Xuất"
            ''Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"
            'Me.lkpName.Properties.Columns("InventoryUnit").Caption = "ĐV Tồn"
            If gvByte_Language = 1 Then
                Me.lkpName.Properties.Columns("MaterialID").Caption = "Mã"
                Me.lkpName.Properties.Columns("MaterialName").Caption = "Tên"
                Me.lkpName.Properties.Columns("ImportUnit").Caption = "ĐV Nhập"
                Me.lkpName.Properties.Columns("ImportToInvRate").Caption = "Tỷ lệ Nhập/Tồn"
                Me.lkpName.Properties.Columns("ExportUnit").Caption = "ĐV Xuất"
                Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"
                Me.lkpName.Properties.Columns("InventoryUnit").Caption = "ĐV Tồn"

            Else
                Me.lkpName.Properties.Columns("MaterialID").Caption = "ID"
                Me.lkpName.Properties.Columns("MaterialName").Caption = "Name"
                Me.lkpName.Properties.Columns("ImportUnit").Caption = "Import Unit"
                Me.lkpName.Properties.Columns("ImportToInvRate").Caption = "Rate Import/Stocks"
                Me.lkpName.Properties.Columns("ExportUnit").Caption = "Unit Export"
                Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Rate Export/Stocks"
                Me.lkpName.Properties.Columns("InventoryUnit").Caption = "Unit Stocks"

            End If

          
        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Create New Invoice"
    Private Sub SubM_CreateNewInvoice()
        Try
            Me.DateEdit1.DateTime = Today
            Me.txtInvoice.Text = ""
            Me.txtNote.Text = ""
            Me.txtInvoiceID.Text = mvCls_ImportExportUpdate.FuncG_CreateInvoiceNo("PX", Me.DateEdit1.DateTime)
            Me.GridControl1.DataSource = Nothing
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load Invoice"
    Private Sub SubM_LoadInvoice()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable1 As New DataTable
        Try
            If Me.txtInvoiceID.Text <> "" Then
                mvObj_DataTable = mvCls_ImportExportUpdate.FuncG_GetData(Me.txtInvoiceID.Text)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.txtInvoice.Text = mvObj_DataTable.Rows(0)("INVOICE")
                    Me.lkpNhanVien.EditValue = mvObj_DataTable.Rows(0)("CREATEUSER")
                    Me.lkpNhaCungCap.EditValue = mvObj_DataTable.Rows(0)("SUPPLIERS")
                    Me.DateEdit1.DateTime = mvObj_DataTable.Rows(0)("CREATEDATE")
                    Me.txtNote.Text = mvObj_DataTable.Rows(0)("NOTE")
                    Me.lkpInventory.EditValue = mvObj_DataTable.Rows(0)("InventoryID")
                    Me.lkpToInventory.EditValue = mvObj_DataTable.Rows(0)("ToInventoryID")
                End If
                mvObj_DataTable1 = mvCls_ImExDetailUpdate.FuncG_GetData(Me.txtInvoiceID.Text)
                Me.GridControl1.DataSource = mvObj_DataTable1
                Me.GridView1.BestFitColumns()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_ExportInvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.gvStr_Status = "Add" Then
                If Me.GridView1.RowCount = 0 Then
                    mvCls_ImExDetailUpdate.FuncG_Delete(Me.txtInvoiceID.Text)
                Else
                    If gvByte_Language = 1 Then
                        If FunG_Alert("Xác nhận", "Bạn có muốn lưu phiếu đang nhập không?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                            If Not SubM_Save() Then
                                e.Cancel = True
                            End If
                        Else
                            mvCls_ImExDetailUpdate.FuncG_Delete(Me.txtInvoiceID.Text)
                        End If
                    Else
                        If FunG_Alert("Confirm", "Do you want to save this stock?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                            If Not SubM_Save() Then
                                e.Cancel = True
                            End If
                        Else
                            mvCls_ImExDetailUpdate.FuncG_Delete(Me.txtInvoiceID.Text)
                        End If

                    End If
                End If              
            End If
            frm_ImportExport.SubM_InitializeForm()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frm_SplitTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn tên hàng"
    Private Sub lkpName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpName.EditValueChanged
        Try
            If Me.lkpName.EditValue IsNot Nothing Then
                Me.txtItemID.Text = Me.lkpName.EditValue
                Dim cls As New cls_Material_Update
                txtPrice.Text = cls.FuncG_GetMaterialPrice(Me.lkpName.EditValue.ToString)
                If txtPrice.Text = "" Then
                    txtPrice.Text = cls.FuncG_GetTBL_STOCK_Price(Me.lkpName.EditValue.ToString)
                    If txtPrice.Text = "" Then
                        txtPrice.Text = "0"
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nhập mã hàng"
    'Private Sub TextEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemID.TextChanged
    '    Dim mvObj_DataTable As New DataTable
    '    Try
    '        mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(Me.txtItemID.Text.Trim)
    '        If mvObj_DataTable.Rows.Count <> 0 Then
    '            Me.lkpName.EditValue = Me.txtItemID.Text.Trim
    '            Me.txtPrice.Text = mvObj_DataTable.Rows(0)("PRICE1")
    '        Else
    '            Me.lkpName.EditValue = Nothing
    '            Me.txtPrice.Text = ""
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
#End Region
#Region "Xử lí nhập - Leave, GotFocus, TextChanged, CheckedChanged, EnableChanged"
#Region "TextChanged"
    Private Sub txtGhiChu_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged, txtPrice.TextChanged, txtVAT.TextChanged
        SubM_Math()
    End Sub
    Private Sub Textbox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.TextChanged
        SubG_TextChanged(Me.FuncM_KiemTraRongNutLuu, Me.cmdSave)
    End Sub
#End Region
#Region "Leave"
    Private Sub txtDuaTruoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.Leave, txtPrice.Leave
        SubG_FormatNumberDigit(sender, 3)
    End Sub
#End Region
#Region "KeyPress"
    Private Sub txtNang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress, txtPrice.KeyPress, txtVAT.KeyPress
        SubG_OnlyInputDigit(sender, e, False)
    End Sub
#End Region
#End Region
#Region "Kiểm Tra Rỗng Nút Lưu"
    Private Function FuncM_KiemTraRongNutLuu() As Boolean
        Dim mvBol_Flag As Boolean
        Try
            If Me.lkpNhanVien.EditValue IsNot Nothing And Me.lkpNhaCungCap.EditValue IsNot Nothing And Me.GridView1.RowCount <> 0 Then
                mvBol_Flag = True
            Else
                mvBol_Flag = False
            End If
            Return mvBol_Flag
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "Tính tiền"
    Private Sub SubM_Math()
        Dim mvDbl_Price As Double = 0
        Dim mvDbl_Qty As Double = 0
        Dim mvInt_Vat As Integer
        Try
            If String.IsNullOrEmpty(Me.txtPrice.Text) Then
                mvDbl_Price = 0
            Else
                mvDbl_Price = Convert.ToDouble(Me.txtPrice.Text)
            End If
            If String.IsNullOrEmpty(Me.txtQty.Text) Then
                mvDbl_Qty = 0
            Else
                mvDbl_Qty = Convert.ToDouble(Me.txtQty.Text)
            End If
            If String.IsNullOrEmpty(Me.txtVAT.Text) Then
                mvInt_Vat = 0
            Else
                mvInt_Vat = Convert.ToDouble(Me.txtVAT.Text)
            End If
            Me.txtTotal.Text = mvDbl_Price * mvDbl_Qty
            Me.txtTotalVat.Text = mvDbl_Price * mvDbl_Qty * mvInt_Vat / 100
            Me.txtFinalTotal.Text = Convert.ToDouble(Me.txtTotal.Text) + Convert.ToDouble(Me.txtTotalVat.Text)
            SubG_FormatNumberDigit2(Me.txtTotal, 0)
            SubG_FormatNumberDigit2(Me.txtTotalVat, 0)
            SubG_FormatNumberDigit2(Me.txtFinalTotal, 0)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Click lên grid"
    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                Me.txtItemID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng")
                Me.txtQty.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Số lượng")
                Me.txtPrice.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Đơn giá")
                Me.txtVAT.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Thuế VAT")
            End If
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
#Region "Đổi ngày"
    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        If Me.gvStr_Status = "Add" Then
            Me.txtInvoiceID.Text = mvCls_ImportExportUpdate.FuncG_CreateInvoiceNo("PX", Me.DateEdit1.DateTime)
        End If
    End Sub
#End Region
#Region "Nút Add"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim mvBol_Flag As Boolean = False
        Try
            If Me.DxValidationProvider1.Validate Then
                For i As Integer = 0 To Me.GridView1.RowCount - 1
                    If Me.txtItemID.Text = Me.GridView1.GetDataRow(i)("Mã hàng") Then
                        mvBol_Flag = True
                        Exit For
                    End If
                Next
                If mvBol_Flag Then
                    'mvCls_ImExDetail.Status = 1 'CHI TIẾT DÒNG HÀNG Ở TRẠNG THÁI UPDATE
                    'GoTo INSERT_DETAIL
                    If gvByte_Language = 1 Then
                        FunG_Alert("Lỗi", String.Format("Mã hàng <{0}> đã có rồi!", Me.txtItemID.Text), frm_Alert.WTYPE.ERROR)
                    Else
                        FunG_Alert("Error", String.Format("this Id <{0}> is already there!", Me.txtItemID.Text), frm_Alert.WTYPE.ERROR)
                    End If
                    Me.txtItemID.Focus()
                ElseIf Me.txtVAT.Text = "" OrElse Convert.ToInt32(Me.txtVAT.Text) > 100 Then
                    SubG_Alert(85) 'FunG_Alert("Lỗi", "Vui lòng kiểm tra lại thuế VAT", frm_Alert.WTYPE.ERROR)
                    Me.txtVAT.Focus()
                ElseIf lkpInventory.EditValue = "999" Then
                    If gvByte_Language = 1 Then
                        FunG_Alert("Thông báo", "Không thể xuất hàng từ Kho này được", frm_Alert.WTYPE.ERROR)
                    Else
                        FunG_Alert("Message", "Unable to export goods from this warehouse", frm_Alert.WTYPE.ERROR)
                    End If
                ElseIf Convert.ToDouble(txtQty.Text) = 0 Then
                    If gvByte_Language = 1 Then
                        FunG_Alert("Thông báo", "Số lượng phải lớn hơn 0", frm_Alert.WTYPE.ERROR)
                    Else
                        FunG_Alert("Notice", "Quantity must be greater than zero.", frm_Alert.WTYPE.ERROR)
                    End If


                Else

INSERT_DETAIL:

                    
                    mvCls_ImExDetail.ID = Me.txtInvoiceID.Text
                    mvCls_ImExDetail.ItemID = Me.txtItemID.Text
                    mvCls_ImExDetail.Price = Me.txtPrice.Text
                    mvCls_ImExDetail.Quantity = Convert.ToDouble(Me.txtQty.Text)
                    mvCls_ImExDetail.Vat = Me.txtVAT.Text
                    Dim slt As Double = 0
                    slt = mvCls_ImExDetailUpdate.FuncG_GetSLTon(mvCls_ImExDetail.ItemID, lkpInventory.EditValue)
                    If (slt - mvCls_ImExDetail.Quantity >= 0) Then
                        Try
                            mvCls_ImExDetailUpdate.FuncG_InsertUpdate(mvCls_ImExDetail)
                        Catch ex As Exception
                            mvCls_ImExDetail.Status = 0
                            mvCls_ImExDetailUpdate.FuncG_InsertUpdate(mvCls_ImExDetail)
                        End Try
                    Else
                        If gvByte_Language = 1 Then
                            FunG_Alert("Thông báo", "Số lượng " + lkpName.Text + " trong kho " + lkpInventory.Text + " chỉ còn " + slt.ToString + ". Vui lòng nhập kho", frm_Alert.WTYPE.ERROR)
                        Else
                            FunG_Alert("Message", "Quantity " + lkpName.Text + " in warehouse " + lkpInventory.Text + " only " + slt.ToString + ". Please warehousing", frm_Alert.WTYPE.ERROR)
                        End If

                        Return
                    End If

                    SubM_LoadInvoice()
                    'SubG_TextChanged(Me.FuncM_KiemTraRongNutLuu, Me.cmdSave)
                    Me.txtItemID.Text = ""
                    Me.txtPrice.Text = ""
                    Me.txtQty.Text = ""


                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Delete"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvByte_Language = 1 Then
                If Me.GridView1.FocusedRowHandle > -1 Then
                    If FunG_Alert("Xác nhận", String.Format("Bạn có muốn xóa mặt hàng <{0}> không?", Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Tên hàng")), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                        mvCls_ImExDetailUpdate.FuncG_Delete(Me.txtInvoiceID.Text, Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng"))
                        SubM_LoadInvoice()
                        'SubG_TextChanged(Me.FuncM_KiemTraRongNutLuu, Me.cmdSave)
                    End If
                Else
                    FunG_Alert("Lỗi", "Chưa chọn mã hàng cần xóa!", frm_Alert.WTYPE.ERROR)
                End If
            Else
                If Me.GridView1.FocusedRowHandle > -1 Then
                    If FunG_Alert("Message", String.Format("Do you want to delete the item <{0}> not?", Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Tên hàng")), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                        mvCls_ImExDetailUpdate.FuncG_Delete(Me.txtInvoiceID.Text, Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng"))
                        SubM_LoadInvoice()
                        'SubG_TextChanged(Me.FuncM_KiemTraRongNutLuu, Me.cmdSave)
                    End If
                Else
                    FunG_Alert("Error", "Not selected item need remove", frm_Alert.WTYPE.ERROR)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Save"
    Private Function SubM_Save()
        Try
            If Me.lkpNhanVien.EditValue Is Nothing Then
                SubG_Alert(86) ' FunG_Alert("Annonce", "Chưa chọn nhân viên!", frm_Alert.WTYPE.STOP)
                Return False
            ElseIf Me.lkpNhaCungCap.EditValue Is Nothing Then
                SubG_Alert(87) 'FunG_Alert("Annonce", "Chưa chọn đối tác!", frm_Alert.WTYPE.STOP)
                Return False
            ElseIf Me.GridView1.RowCount = 0 Then
                SubG_Alert(88) 'FunG_Alert("Annonce", "Chưa có thông tin mặt hàng!", frm_Alert.WTYPE.STOP)
                Return False
            ElseIf Me.lkpInventory.EditValue.Equals(lkpToInventory.EditValue) Then
                SubG_Alert(89) 'FunG_Alert("Annonce", "Kho Xuất/Nhập không thể trùng!", frm_Alert.WTYPE.STOP)
                Return False
            Else
                mvCls_ImportExport.ID = Me.txtInvoiceID.Text
                mvCls_ImportExport.Invoice = Me.txtInvoice.Text
                mvCls_ImportExport.CreateDay = Me.DateEdit1.DateTime.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()
                mvCls_ImportExport.Note = Me.txtNote.Text
                mvCls_ImportExport.Suppliers = Me.lkpNhaCungCap.EditValue
                mvCls_ImportExport.User = Me.lkpNhanVien.EditValue
                mvCls_ImportExport.InventoryID = lkpInventory.EditValue
                mvCls_ImportExport.ToInventoryID = lkpToInventory.EditValue
                mvCls_ImportExport.Type = 1

                If Me.gvStr_Status = "Add" Then
                    mvCls_ImportExport.Status = 0
                Else
                    mvCls_ImportExport.Status = 1
                End If

                mvCls_ImportExportUpdate.FuncG_InsertUpdate(mvCls_ImportExport)

                'Ghi vao kho
                mvCls_ImportExportUpdate.FuncG_ImportExport_StockDetail(Me.txtInvoiceID.Text, False)

                If Me.gvStr_Status = "Add" Then
                    SubM_InitializeForm()
                Else
                    Me.Close()
                End If
                Return True
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click    
        SubM_Save()
    End Sub
#End Region
#Region "Nút Print"
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'If Me.gvStr_Status = "Edit" Then
        '    mvCls_ImportExport.ID = Me.txtInvoiceID.Text
        '    mvCls_ImportExport.Invoice = Me.txtInvoice.Text
        '    mvCls_ImportExport.CreateDay = Me.DateEdit1.DateTime.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()
        '    mvCls_ImportExport.Note = Me.txtNote.Text
        '    mvCls_ImportExport.Suppliers = Me.lkpNhaCungCap.EditValue
        '    mvCls_ImportExport.User = Me.lkpNhanVien.EditValue
        '    mvCls_ImportExport.Type = 0
        '    mvCls_ImportExport.InventoryID = lkpInventory.EditValue
        '    mvCls_ImportExport.ToInventoryID = ""

        '    If Me.gvStr_Status = "Add" Then
        '        mvCls_ImportExport.Status = 0
        '    Else
        '        mvCls_ImportExport.Status = 1
        '    End If

        '    mvCls_ImportExportUpdate.FuncG_InsertUpdate(mvCls_ImportExport) 'BAO GOM XOA DU LIEU TRONG TRONG STOCK_DETAIL VA STOCK_REPORT DE TINH TOAN LAI TON KHO

        '    'Ghi vao kho
        '    mvCls_ImportExportUpdate.FuncG_ImportExport_StockDetail(Me.txtInvoiceID.Text, True)
        'End If
        Me.Close()
    End Sub
#End Region

    Private Sub lkpInventory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpInventory.EditValueChanged
        
        If lkpInventory.EditValue = "999" Then
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo", "Không thể xuất hàng từ Kho này được", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Message", "Unable to export goods from this warehouse", frm_Alert.WTYPE.ERROR)
            End If

            lkpInventory.EditValue = "001"

        Else

        End If
    End Sub
End Class