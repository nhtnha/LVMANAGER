Public Class urc_Sale
#Region "Khai Báo Biến"
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
    Dim mvCls_Sales As New cls_Sales
    Dim mvCls_SalesUpdate As New cls_Sales_Update
    Dim mvCls_SalesDetail As New cls_SalesDetail
    Dim mvCls_SalesDetailUpdate As New cls_SalesDetail_Update
    Dim mvCls_PrintTemp As New cls_PrintTemp
    Dim mvCls_TableUpdate As New cls_Table_Update
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        Dim mvObj_DataTable As New DataTable
        SubM_LoadMenu()
        'If frm_Sale.txtSoHD.Text <> "" Then
        '    mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(frm_Sale.txtSoHD.Text)
        '    SubM_LoadDataIntoGrid(mvObj_DataTable)
        '    SubM_Total()
        'End If
    End Sub
#End Region
#Region "Load Menu Nhóm món ăn"
    Private Sub SubM_LoadMenu()
        Dim mvObj_GroupItemData As New DataTable
        Dim mvObj_ItemData As New DataTable
        Try
            'Load menu
            mvObj_GroupItemData = mvCls_GroupItemUpdate.FuncG_GetAllData
            For i As Integer = 0 To 15
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.plcMenu, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_GroupItemData.Rows.Count > i Then
                    If mvObj_GroupItemData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Visible = True
                        mvCmd_SimpleButton.Tag = mvObj_GroupItemData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_GroupItemData.Rows(i)("NAME")
                    Else
                        mvCmd_SimpleButton.Visible = False
                        mvCmd_SimpleButton.Text = ""
                    End If
                Else
                    mvCmd_SimpleButton.Visible = False
                    mvCmd_SimpleButton.Text = ""
                End If
            Next
            'Load menu đầu tiên
            mvObj_ItemData = mvCls_ItemUpdate.FuncG_GetAllData(mvObj_GroupItemData.Rows(0)("ID"))
            Me.SubM_LoadItem(mvObj_ItemData)
        Catch ex As Exception

        End Try
    End Sub
    Private Shared Function FunM_GetControlByName(ByVal iObjParent As Control, ByVal iStr_CtlName As String) As Control
        Dim objCtl As Control
        For Each objCtl In iObjParent.Controls
            If objCtl.Name = iStr_CtlName Then
                Return (objCtl)
            End If
        Next
        ' if control is not found
        Return Nothing
    End Function
#End Region
#Region "Load"
    Private Sub urc_Sales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Hàm load món ăn theo nhóm"
    Private Sub SubM_LoadItem(ByVal iObj_DataTable As DataTable)
        Try
            For i As Integer = 0 To 39
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.plcItem, "cmdBan" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If iObj_DataTable.Rows.Count > i Then
                    If iObj_DataTable.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Visible = True
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                    Else
                        mvCmd_SimpleButton.Visible = False
                        mvCmd_SimpleButton.Tag = ""
                        mvCmd_SimpleButton.Text = ""
                    End If
                Else
                    mvCmd_SimpleButton.Visible = False
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn menu"
    Private Sub cmdKhuVuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMenu0.Click, _
    cmdMenu1.Click, cmdMenu2.Click, cmdMenu3.Click, cmdMenu4.Click, cmdMenu5.Click, cmdMenu6.Click, _
    cmdMenu7.Click, cmdMenu8.Click, cmdMenu9.Click, cmdMenu10.Click, cmdMenu11.Click, cmdMenu12.Click, _
    cmdMenu13.Click, cmdMenu14.Click, cmdMenu15.Click
        Dim mvObj_DataTable As New DataTable
        Try
            For i As Integer = 0 To 15
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.plcMenu, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
            Next
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
            'Lấy ID từ thuộc tính Tag
            mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllData(mvCmd_SimpleButton.Tag)
            Me.SubM_LoadItem(mvObj_DataTable)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn item"
    Private Sub cmdBan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBan0.Click, _
    cmdBan1.Click, cmdBan2.Click, cmdBan3.Click, cmdBan4.Click, cmdBan5.Click, cmdBan6.Click, cmdBan7.Click, _
    cmdBan8.Click, cmdBan9.Click, cmdBan10.Click, cmdBan11.Click, cmdBan12.Click, cmdBan13.Click, cmdBan14.Click, _
    cmdBan15.Click, cmdBan16.Click, cmdBan17.Click, cmdBan18.Click, cmdBan19.Click, cmdBan20.Click, cmdBan21.Click, _
    cmdBan22.Click, cmdBan23.Click, cmdBan24.Click, cmdBan25.Click, cmdBan26.Click, cmdBan27.Click, cmdBan28.Click, _
    cmdBan29.Click, cmdBan30.Click, cmdBan31.Click, cmdBan32.Click, cmdBan33.Click, cmdBan34.Click, cmdBan35.Click, _
    cmdBan36.Click, cmdBan37.Click, cmdBan38.Click, cmdBan39.Click
        Dim mvObj_DataTable As New DataTable
        Dim mvDbl_Quantity As Double
        Dim mvDbl_Price As Double
        Try
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            If frm_Sale.cmdNP.Enabled Then
                'Nếu bật chức năng giá mở
                frm_NewPrice.txtName.Tag = mvCmd_SimpleButton.Tag
                frm_NewPrice.txtName.Text = mvCmd_SimpleButton.Text
                frm_NewPrice.txtQuantity.Text = frm_Sale.mvUrc_Caculator.txtInput.Text
                frm_NewPrice.txtPrice.Text = 0
                frm_NewPrice.ShowDialog()
                If frm_NewPrice.gvDbl_Quantity <> 0 Then
                    'Nếu số lượng khác 0, tạo món mới
                    SubM_CreateBill(frm_NewPrice.gvDbl_Quantity, frm_NewPrice.gvDbl_Price)
                End If
            Else
                If IsNumeric(frm_Sale.mvUrc_Caculator.txtInput.Text) Then
                    mvDbl_Quantity = Convert.ToDouble(frm_Sale.mvUrc_Caculator.txtInput.Text)
                Else
                    mvDbl_Quantity = 1
                End If
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(mvCmd_SimpleButton.Tag)
                If frm_Sale.cmdPrice1.Enabled Then
                    mvDbl_Price = mvObj_DataTable.Rows(0)("PRICE2")
                Else
                    mvDbl_Price = mvObj_DataTable.Rows(0)("PRICE1")
                End If
                SubM_CreateBill(mvDbl_Quantity, mvDbl_Price)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Tạo hóa đơn mới"
    Private Sub SubM_CreateBill(ByVal iDbl_Quantity As Double, ByVal iDbl_Price As Double)
        If frm_Sale.txtSoHD.Text = "" Then
            'Nếu bàn mới mở, tạo hóa đơn mới
            mvCls_Sales.ID = mvCls_SalesUpdate.FuncG_CreateInvoiceNo
            mvCls_Sales.CashierID = gvStr_AccUser
            mvCls_Sales.CustomerID = "00"
            mvCls_Sales.WaiterID = "00"
            mvCls_Sales.TableID = frm_Sale.txtTable.Tag
            mvCls_Sales.CheckIn = Now
            mvCls_Sales.VAT = 0
            mvCls_Sales.Status = 2
            mvCls_SalesUpdate.FuncG_Insert(mvCls_Sales)
            frm_Sale.txtSoHD.Text = mvCls_Sales.ID
            SubM_InsertItem(iDbl_Quantity, iDbl_Price)
        Else
            'Bàn đã mở sẵn
            SubM_InsertItem(iDbl_Quantity, iDbl_Price)
        End If
        frm_Sale.mvUrc_Caculator.txtInput.Text = "1"
        frm_Sale.cmdNP.Enabled = False
    End Sub
#End Region
#Region "Thêm mặt hàng vào hóa đơn"
    Private Sub SubM_InsertItem(ByVal iDbl_Quantity As Double, ByVal iDbl_Price As Double)
        Dim mvObj_DataTable As New DataTable
        Try
            'Thêm món ăn vào trong hóa đơn
            mvCls_SalesDetail.ID = frm_Sale.txtSoHD.Text
            mvCls_SalesDetail.ItemID = mvCmd_SimpleButton.Tag
            mvCls_SalesDetail.Quantity = iDbl_Quantity
            mvCls_SalesDetail.Price = iDbl_Price
            mvCls_SalesDetailUpdate.FuncG_InsertUpdate(mvCls_SalesDetail)
            'Thêm vào bảng in tạm nếu có chế độ in bếp
            If gvBol_PrintOrder Then
                'Kiểm tra trạng thái bàn
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(mvCls_SalesDetail.ItemID)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    If mvObj_DataTable.Rows(0)("PRINTORDER") = 1 Then
                        'Nếu mặt hàng được in vào bếp
                        frm_Description.gvCls_PrintTemp.ID = mvCls_SalesDetail.ID
                        frm_Description.gvCls_PrintTemp.ItemID = mvCls_SalesDetail.ItemID
                        frm_Description.gvCls_PrintTemp.Employee = frm_Sale.lkpEmployee.Text
                        frm_Description.gvCls_PrintTemp.Quantity = mvCls_SalesDetail.Quantity
                        frm_Description.gvCls_PrintTemp.Status = 1
                        frm_Description.txtName.Tag = mvCmd_SimpleButton.Tag
                        frm_Description.txtName.Text = mvCmd_SimpleButton.Text
                        frm_Description.ShowDialog()
                    End If
                End If
            End If
            'Load dữ liệu vào gird
            mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetData(frm_Sale.txtSoHD.Text)
            SubM_LoadDataIntoGrid(mvObj_DataTable)
            'Tính tiền
            SubM_Total()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load mặt hàng đã bán vào gird"
    Public Sub SubM_LoadDataIntoGrid(ByVal iObj_DataTable As DataTable)
        Try
            frm_Sale.GridControl1.DataSource = iObj_DataTable
            frm_Sale.GridView1.PopulateColumns(iObj_DataTable)
            frm_Sale.GridView1.Columns("Tên hàng").Width = 133
            frm_Sale.GridView1.Columns("S.L").Width = 40
            frm_Sale.GridView1.Columns("S.L").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            frm_Sale.GridView1.Columns("S.L").DisplayFormat.FormatString = "#,##"
            frm_Sale.GridView1.Columns("Giá").Width = 60
            frm_Sale.GridView1.Columns("Giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            frm_Sale.GridView1.Columns("Giá").DisplayFormat.FormatString = "#,##"
            frm_Sale.GridView1.Columns("ITEM_ID").Visible = False
            frm_Sale.GridView1.Columns("DISCOUNT").Visible = False
            frm_Sale.GridView1.Columns("VAT").Visible = False
            frm_Sale.GridView1.Columns("SERVICE").Visible = False
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Tính thành tiền"
    Public Sub SubM_Total()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_GetTotal(frm_Sale.txtSoHD.Text)
            If mvObj_DataTable.Rows.Count <> 0 Then
                frm_Sale.lblTotal.Text = mvObj_DataTable.Rows(0)("TOTAL")
                frm_Sale.lblDiscount.Text = mvObj_DataTable.Rows(0)("DISCOUNT")
                frm_Sale.lblService.Text = mvObj_DataTable.Rows(0)("SERVICE")
                frm_Sale.lblVAT.Text = mvObj_DataTable.Rows(0)("VAT")
                frm_Sale.lblFinalCost.Text = mvObj_DataTable.Rows(0)("TOTALCOST")
                SubG_FormatNumberDigit(frm_Sale.lblTotal, 0)
                SubG_FormatNumberDigit(frm_Sale.lblDiscount, 0)
                SubG_FormatNumberDigit(frm_Sale.lblService, 0)
                SubG_FormatNumberDigit(frm_Sale.lblVAT, 0)
                SubG_FormatNumberDigit(frm_Sale.lblFinalCost, 0)
            Else
                frm_Sale.lblTotal.Text = ""
                frm_Sale.lblDiscount.Text = ""
                frm_Sale.lblService.Text = ""
                frm_Sale.lblVAT.Text = ""
                frm_Sale.lblFinalCost.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
