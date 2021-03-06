Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Public Class frm_SplitTable
#Region "Khai Báo Biến"
    Dim mvCls_Sales As New cls_Sales
    Dim mvCls_SalesUpdate As New cls_Sales_Update
    Dim mvCls_SalesDetail As New cls_SalesDetail
    Dim mvCls_SalesDetailUpdate As New cls_SalesDetail_Update
    Dim mvCls_TableUpdate As New cls_Table_Update
    Dim mvStr_InvoiceNo1 As String
    Dim mvStr_InvoiceNo2 As String
    Dim mvBol_OpenNew As Boolean = False
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        SubM_LoadOrder(Me.txtTable1, 1)
        SubM_LoadOrder(Me.txtTable2, 2)
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_CombinedTable_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.GridView1.RowCount = 0 Then
            FunG_Alert("Thông báo lỗi", "Hóa đơn phải có ít nhất 1 mặt hàng", frm_Alert.WTYPE.ERROR)
            e.Cancel = True
        Else
            'Nếu HĐ mới tạo không có mặt hàng nào thì xóa lun
            If Me.GridView2.RowCount = 0 Then
                mvCls_SalesUpdate.FuncG_Delete(mvStr_InvoiceNo2, Me.txtTable2.Tag)
            End If
            frm_Table.SubM_InitializeForm()
            frm_Table.Show()
        End If
    End Sub
    Private Sub frm_SplitTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Load Order"
    Private Sub SubM_LoadOrder(ByVal iTextEdit As DevExpress.XtraEditors.TextEdit, ByVal iFlag As Byte)
        Dim mvObj_DataTable As New DataTable
        Try
            If iTextEdit.Tag Is Nothing Then
                Me.Close()
            Else
                'Lấy trạng thái của bàn
                mvObj_DataTable = mvCls_TableUpdate.FuncG_GetDataInfo(iTextEdit.Tag)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    If mvObj_DataTable.Rows(0)("STATUS") = 2 Or mvObj_DataTable.Rows(0)("STATUS") = 3 Then
                        'Bàn đang sử dụng, lấy về số HĐ
                        mvObj_DataTable = mvCls_SalesUpdate.FuncG_GetDataByTableID(iTextEdit.Tag)
                        If mvObj_DataTable.Rows.Count <> 0 Then
                            If iFlag = 1 Then
                                Me.mvStr_InvoiceNo1 = mvObj_DataTable.Rows(0)("ID")
                                'Load chi tiết HĐ vào lưới
                                mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(Me.mvStr_InvoiceNo1)
                                SubM_LoadDataIntoGrid(mvObj_DataTable, Me.GridControl1, Me.GridView1)
                            Else
                                Me.mvStr_InvoiceNo2 = mvObj_DataTable.Rows(0)("ID")
                                'Load chi tiết HĐ vào lưới
                                mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(Me.mvStr_InvoiceNo2)
                                SubM_LoadDataIntoGrid(mvObj_DataTable, Me.GridControl2, Me.GridView2)
                            End If
                        End If
                    Else
                        'Bàn vừa mở
                        If iFlag = 1 Then
                            Me.mvStr_InvoiceNo1 = ""
                            Me.GridControl1.DataSource = Nothing
                        Else
                            Me.mvStr_InvoiceNo2 = ""
                            Me.GridControl2.DataSource = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load mặt hàng đã bán vào gird"
    Public Sub SubM_LoadDataIntoGrid(ByVal iObj_DataTable As DataTable, ByVal iGirdControl As GridControl, ByVal iGridView As GridView)
        Try
            iGirdControl.DataSource = iObj_DataTable
            iGridView.PopulateColumns(iObj_DataTable)
            iGridView.Columns("Tên hàng").Width = 133
            iGridView.Columns("S.L").Width = 40
            iGridView.Columns("S.L").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iGridView.Columns("S.L").DisplayFormat.FormatString = "#,##"
            iGridView.Columns("Giá").Width = 60
            iGridView.Columns("Giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iGridView.Columns("Giá").DisplayFormat.FormatString = "#,##"
            iGridView.Columns("ITEM_ID").Visible = False
            iGridView.Columns("DISCOUNT").Visible = False
            iGridView.Columns("VAT").Visible = False
            iGridView.Columns("SERVICE").Visible = False
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Up1"
    Private Sub cmdUp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp1.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Down1"
    Private Sub cmdDown1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown1.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Up2"
    Private Sub cmdUp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp2.Click
        Try
            If Me.GridView2.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView2.FocusedRowHandle = Me.GridView2.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Down2"
    Private Sub cmdDown2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown2.Click
        Try
            If Me.GridView2.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView2.FocusedRowHandle = Me.GridView2.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Right"
    Private Sub cmdRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRight.Click
        Try
            If Me.GridView1.FocusedRowHandle <> -1 Then
                'Lấy thông tin từ grid
                frm_SpilitQty.txtName.Tag = Me.GridView1.GetFocusedDataRow("ITEM_ID")
                frm_SpilitQty.txtName.Text = Me.GridView1.GetFocusedDataRow("Tên hàng")
                frm_SpilitQty.txtCurrentQty.Text = Me.GridView1.GetFocusedDataRow("S.L")
                If gvByte_Language = 1 Then
                    frm_SpilitQty.Text = "Vui lòng nhập số lượng"
                Else
                    frm_SpilitQty.Text = "Please input quantity"
                End If
                frm_SpilitQty.ShowDialog()
                If frm_SpilitQty.gvInt_Quantity > 0 Then
                    'Kiểm tra HĐ thứ 2, nếu chưa có thì tạo mới
                    If mvStr_InvoiceNo2 = "" Then
                        'Tạo hóa đơn mới
                        mvBol_OpenNew = True
                        mvCls_Sales.ID = mvCls_SalesUpdate.FuncG_CreateInvoiceNo
                        mvCls_Sales.CashierID = gvStr_AccUser
                        mvCls_Sales.CustomerID = "00"
                        mvCls_Sales.WaiterID = "00"
                        mvCls_Sales.TableID = Me.txtTable2.Tag
                        mvCls_Sales.CheckIn = Now
                        mvCls_Sales.VAT = 0
                        mvCls_Sales.Status = 2
                        mvCls_SalesUpdate.FuncG_Insert(mvCls_Sales)
                        mvStr_InvoiceNo2 = mvCls_Sales.ID
                    End If
                    'Cập nhật lại chi tiết của 2 HĐ
                    SubM_InsertItem(1, Me.GridView1.GetFocusedDataRow("ITEM_ID"), frm_SpilitQty.gvInt_Quantity, Me.GridView1.GetFocusedDataRow("Giá"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút AllRight"
    Private Sub cmdAllRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllRight.Click
        Try
            If Me.GridView1.FocusedRowHandle <> -1 Then
                'Kiểm tra HĐ thứ 2, nếu chưa có thì tạo mới
                If mvStr_InvoiceNo2 = "" Then
                    'Tạo hóa đơn mới
                    mvCls_Sales.ID = mvCls_SalesUpdate.FuncG_CreateInvoiceNo
                    mvCls_Sales.CashierID = gvStr_AccUser
                    mvCls_Sales.CustomerID = "00"
                    mvCls_Sales.WaiterID = "00"
                    mvCls_Sales.TableID = Me.txtTable2.Tag
                    mvCls_Sales.CheckIn = Now
                    mvCls_Sales.VAT = 0
                    mvCls_Sales.Status = 2
                    mvCls_SalesUpdate.FuncG_Insert(mvCls_Sales)
                    mvStr_InvoiceNo2 = mvCls_Sales.ID
                End If
                'Cập nhật lại chi tiết của 2 HĐ
                SubM_InsertItem(1, Me.GridView1.GetFocusedDataRow("ITEM_ID"), Me.GridView1.GetFocusedDataRow("S.L"), Me.GridView1.GetFocusedDataRow("Giá"))
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Left"
    Private Sub cmdLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeft.Click
        Try
            If Me.GridView2.FocusedRowHandle <> -1 Then       
                'Lấy thông tin từ grid
                frm_SpilitQty.txtName.Tag = Me.GridView2.GetFocusedDataRow("ITEM_ID")
                frm_SpilitQty.txtName.Text = Me.GridView2.GetFocusedDataRow("Tên hàng")
                frm_SpilitQty.txtCurrentQty.Text = Me.GridView2.GetFocusedDataRow("S.L")
                If gvByte_Language = 1 Then
                    frm_SpilitQty.Text = "Vui lòng nhập số lượng"
                Else
                    frm_SpilitQty.Text = "Please input quantity"
                End If
                frm_SpilitQty.ShowDialog()
                If frm_SpilitQty.gvInt_Quantity > 0 Then
                    'Kiểm tra HĐ thứ 2, nếu chưa có thì tạo mới
                    If mvStr_InvoiceNo2 = "" Then
                        'Tạo hóa đơn mới
                        mvCls_Sales.ID = mvCls_SalesUpdate.FuncG_CreateInvoiceNo
                        mvCls_Sales.CashierID = gvStr_AccUser
                        mvCls_Sales.CustomerID = "00"
                        mvCls_Sales.WaiterID = "00"
                        mvCls_Sales.TableID = Me.txtTable2.Tag
                        mvCls_Sales.CheckIn = Now
                        mvCls_Sales.VAT = 0
                        mvCls_Sales.Status = 2
                        mvCls_SalesUpdate.FuncG_Insert(mvCls_Sales)
                        mvStr_InvoiceNo2 = mvCls_Sales.ID
                    End If
                    'Cập nhật lại chi tiết của 2 HĐ
                    SubM_InsertItem(2, Me.GridView2.GetFocusedDataRow("ITEM_ID"), frm_SpilitQty.gvInt_Quantity, Me.GridView2.GetFocusedDataRow("Giá"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút AllLeft"
    Private Sub cmdAllLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllLeft.Click
        Try
            If Me.GridView2.FocusedRowHandle <> -1 Then
                'Kiểm tra HĐ thứ 2, nếu chưa có thì tạo mới
                If mvStr_InvoiceNo2 = "" Then
                    'Tạo hóa đơn mới
                    mvCls_Sales.ID = mvCls_SalesUpdate.FuncG_CreateInvoiceNo
                    mvCls_Sales.CashierID = gvStr_AccUser
                    mvCls_Sales.CustomerID = "00"
                    mvCls_Sales.WaiterID = "00"
                    mvCls_Sales.TableID = Me.txtTable2.Tag
                    mvCls_Sales.CheckIn = Now
                    mvCls_Sales.VAT = 0
                    mvCls_Sales.Status = 2
                    mvCls_SalesUpdate.FuncG_Insert(mvCls_Sales)
                    mvStr_InvoiceNo2 = mvCls_Sales.ID
                End If
                'Cập nhật lại chi tiết của 2 HĐ
                SubM_InsertItem(2, Me.GridView2.GetFocusedDataRow("ITEM_ID"), Me.GridView2.GetFocusedDataRow("S.L"), Me.GridView2.GetFocusedDataRow("Giá"))
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Thêm mặt hàng vào hóa đơn"
    Private Sub SubM_InsertItem(ByVal iFlag As Byte, ByVal iStr_ItemID As String, ByVal iDbl_Qty As Double, ByVal iDbl_Price As Double)
        Dim mvObj_DataTable As New DataTable
        Try
            mvCls_SalesDetail.ItemID = iStr_ItemID
            mvCls_SalesDetail.Price = iDbl_Price
            If iFlag = 1 Then
                'Xóa mặt hàng ở hóa đơn 1
                mvCls_SalesDetail.ID = mvStr_InvoiceNo1
                mvCls_SalesDetail.Quantity = -iDbl_Qty
                mvCls_SalesDetailUpdate.FuncG_InsertUpdate(mvCls_SalesDetail)
                'Thêm mặt hàng ở hóa đơn 2
                mvCls_SalesDetail.ID = mvStr_InvoiceNo2
                mvCls_SalesDetail.Quantity = iDbl_Qty
                mvCls_SalesDetailUpdate.FuncG_InsertUpdate(mvCls_SalesDetail)
            Else
                'Thêm mặt hàng ở hóa đơn 1
                mvCls_SalesDetail.ID = mvStr_InvoiceNo1
                mvCls_SalesDetail.Quantity = iDbl_Qty
                mvCls_SalesDetailUpdate.FuncG_InsertUpdate(mvCls_SalesDetail)
                'Xóa mặt hàng ở hóa đơn 2
                mvCls_SalesDetail.ID = mvStr_InvoiceNo2
                mvCls_SalesDetail.Quantity = -iDbl_Qty
                mvCls_SalesDetailUpdate.FuncG_InsertUpdate(mvCls_SalesDetail)
            End If
            'Load dữ liệu vào gird
            mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(mvStr_InvoiceNo1)
            SubM_LoadDataIntoGrid(mvObj_DataTable, Me.GridControl1, Me.GridView1)
            mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(mvStr_InvoiceNo2)
            SubM_LoadDataIntoGrid(mvObj_DataTable, Me.GridControl2, Me.GridView2)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region
End Class