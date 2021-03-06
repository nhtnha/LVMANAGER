Imports ControlsAlias = DevExpress.XtraEditors.Controls
Public Class frm_SetMenu
#Region "Khai Báo Biến"

    Dim mvCls_PrinterUpdate As New cls_Printer_Update
    Dim mvCls_Item As New cls_Item
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
    Dim mvBool_Search As Boolean = False
    Dim _path_Image As String = Application.StartupPath + "\\Insert_Picture.PNG"
    Dim indexselect As Integer = 0
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadData()
        mod_LoadLanguageForm.SubG_AreaForm()
        If gvByte_Language = 1 Then
            Me.GroupControl1.Text = "Danh sách mặt hàng"
            Me.gpcHeader.Text = "Thông tin mặt hàng"
            Me.LabelControl1.Text = "Mã hàng"
            Me.lblItem.Text = "Tên hàng"
            Me.cmdTableMap.Text = "Sơ đồ bàn"
            Me.lblGroupItem.Text = "Nhóm hàng"
            lblUnit.Text = "ĐVT"
            Me.lblPrice1.Text = "Giá  1"
            Me.LabelControl2.Text = "Giá 2"
            Me.LabelControl6.Text = "Giá 3"
            Me.LabelControl5.Text = "Giá 4"
            Me.LabelControl7.Text = "Giá 5"
            Me.cheStatus.Text = "Hiển thị"
            Me.chePrint.Text = "In bếp"
            Me.RadioGroup1.Properties.Items(0).Description = "Hàng hóa"
            Me.RadioGroup1.Properties.Items(1).Description = "Menu"
        Else
            Me.GroupControl1.Text = "LIST ITEM"
            Me.gpcHeader.Text = "ITEM INFORMATION"
            Me.LabelControl1.Text = "Item ID"
            Me.lblItem.Text = "Item Name"
            Me.cmdTableMap.Text = "Table Map"
            Me.lblGroupItem.Text = "Group Item"
            lblUnit.Text = "Unit"
            Me.lblPrice1.Text = "Price 1"
            Me.LabelControl2.Text = "Price 2"
            Me.LabelControl6.Text = "Price 3"
            Me.LabelControl5.Text = "Price 4"
            Me.LabelControl7.Text = "Price 5"
            Me.cheStatus.Text = "Show"
            Me.chePrint.Text = "Print "
            Me.RadioGroup1.Properties.Items(0).Description = "Item"
            Me.RadioGroup1.Properties.Items(1).Description = "Menü"
        End If
    End Sub
#End Region
#Region "Load Data"
    Public Sub SubM_LoadData()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable1 As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        Dim mvObj_DataTable3 As New DataTable
        Try
            mvObj_DataTable = mvCls_PrinterUpdate.FuncG_GetAllData1
            Me.lkpPrinter.Properties.DataSource = mvObj_DataTable
            Me.lkpPrinter.Properties.DisplayMember = "Tên máy"
            Me.lkpPrinter.Properties.ValueMember = "Mã"
            Me.lkpPrinter.EditValue = Nothing

            mvObj_DataTable1 = mvCls_GroupItemUpdate.FuncG_GetAllData1
            Me.lkpNhomHang.Properties.DataSource = mvObj_DataTable1
            Me.lkpNhomHang.Properties.DisplayMember = "Nhóm hàng"
            Me.lkpNhomHang.Properties.ValueMember = "Mã nhóm"
            Me.lkpNhomHang.EditValue = Nothing

            mvObj_DataTable2 = mvCls_ItemUpdate.FuncG_GetAllData2
            If mvObj_DataTable2.Rows.Count <> 0 Then
                Me.GridControl1.DataSource = Nothing
                Me.GridControl1.DataSource = mvObj_DataTable2
                Me.GridView1.PopulateColumns()
                Me.GridView1.BestFitColumns()
                ''================================================
                If gvByte_Language = 1 Then
                    Me.GridView1.Columns("Mã hàng").Caption = "Mã hàng"
                    Me.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
                    Me.GridView1.Columns("Đơn vị").Caption = "Đơn vị"
                    Me.GridView1.Columns("Đơn giá").Caption = "Đơn giá"

                ElseIf gvByte_Language = 2 Then
                    Me.GridView1.Columns("Mã hàng").Caption = "ID"
                    Me.GridView1.Columns("Tên hàng").Caption = "Item Name"

                    Me.GridView1.Columns("Đơn giá").Caption = "Price"
                    Me.GridView1.Columns("Đơn vị").Caption = "Unit"

                End If
            End If
            GridView1.FocusedRowHandle = indexselect
            RadioGroup1.SelectedIndex = 1
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Click on girdview"
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim mvStr_ID As String
        Dim mvObj_DataTable As New DataTable
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                mvStr_ID = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng")
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(mvStr_ID)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.txtID.Text = mvObj_DataTable.Rows(0)("ID")
                    Me.lkpNhomHang.EditValue = mvObj_DataTable.Rows(0)("GROUP_ID")
                    Me.txtName.Text = mvObj_DataTable.Rows(0)("NAME")
                    Me.txtPrice1.Text = mvObj_DataTable.Rows(0)("PRICE1")
                    Me.txtPrice2.Text = mvObj_DataTable.Rows(0)("PRICE2")
                    Me.txtPrice3.Text = mvObj_DataTable.Rows(0)("PRICE3")
                    Me.txtPrice4.Text = mvObj_DataTable.Rows(0)("PRICE4")
                    Me.txtPrice5.Text = mvObj_DataTable.Rows(0)("PRICE5")
                    Me.txtUnit.Text = mvObj_DataTable.Rows(0)("UNIT")
                    Me.lkpPrinter.EditValue = mvObj_DataTable.Rows(0)("PRINTER")
                    Me.chePrint.Checked = mvObj_DataTable.Rows(0)("PRINTORDER")
                    Me.cheStatus.Checked = mvObj_DataTable.Rows(0)("STATUS")
                    Me.RadioGroup1.SelectedIndex = 1 'mvObj_DataTable.Rows(0)("PROMAT")
                    Me.ColorEdit1.Color = Color.FromArgb(mvObj_DataTable.Rows(0)("COLOR"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn menu"
    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If Me.RadioGroup1.SelectedIndex = 0 Then
            Me.cmdSetMenu.Enabled = False
        Else
            Me.cmdSetMenu.Enabled = True
        End If
    End Sub
#End Region
#Region "Format money"
    Private Sub txtMoney_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.Leave, txtPrice1.Leave, txtUnit.Leave
        Try
            If IsNumeric(Me.txtPrice1.Text) Then
                SubG_FormatNumberDigit(Me.txtPrice1, gvByte_Digit)
            End If
            If IsNumeric(Me.txtPrice2.Text) Then
                SubG_FormatNumberDigit(Me.txtPrice2, gvByte_Digit)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Table Map"
    Private Sub cmdTableMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTableMap.Click
        frm_TableMap.ShowDialog()
    End Sub
#End Region
#Region "Nút Set menu"
    Private Sub cmdSetMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetMenu.Click
        'frm_Promat_.txtItem.Tag = Me.txtID.Text
        frm_Promat_.lueItem.EditValue = Me.txtID.Text
        frm_Promat_.txtItemID.Text = Me.txtID.Text
        frm_Promat_.ShowDialog()
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        Try
            indexselect = Me.GridView1.FocusedRowHandle
            If Me.lkpNhomHang.EditValue Is Nothing Then
                SubG_Alert(110) ' FunG_Alert("Thông báo lỗi", "Chưa chọn món ăn cần cập nhật!", frm_Alert.WTYPE.ERROR)
            ElseIf Me.txtPrice1.Text = "" Then
                SubG_Alert(111) ' FunG_Alert("Annonce lỗi", "Chưa nhập giá bán cho món ăn!", frm_Alert.WTYPE.ERROR)
            ElseIf (Not IsNumeric(Me.txtPrice1.Text)) Then
                SubG_Alert(112) ' FunG_Alert("Annonce lỗi", "Đơn giá bán phải là số!", frm_Alert.WTYPE.ERROR)
            Else
                If String.IsNullOrEmpty(txtPrice3.Text) Then
                    txtPrice3.Text = "0"
                End If
                If String.IsNullOrEmpty(txtPrice4.Text) Then
                    txtPrice4.Text = "0"
                End If
                If String.IsNullOrEmpty(txtPrice5.Text) Then
                    txtPrice5.Text = "0"
                End If
                mvCls_Item.ID = Me.txtID.Text
                mvCls_Item.Name = Me.txtName.Text
                mvCls_Item.Price1 = Me.txtPrice1.Text
                mvCls_Item.Price2 = Me.txtPrice2.Text
                mvCls_Item.Price3 = Me.txtPrice3.Text
                mvCls_Item.Price4 = Me.txtPrice4.Text
                mvCls_Item.Price5 = Me.txtPrice5.Text
                mvCls_Item.Unit = Me.txtUnit.Text
                mvCls_Item.Printer = Me.lkpPrinter.EditValue
                mvCls_Item.Color = Me.ColorEdit1.Color.ToArgb
                If Me.chePrint.Checked Then
                    mvCls_Item.Print = 1
                Else
                    mvCls_Item.Print = 0
                End If
                If Me.cheStatus.Checked Then
                    mvCls_Item.Status = 1
                Else
                    mvCls_Item.Status = 0
                End If
                mvCls_Item.Promat = Me.RadioGroup1.SelectedIndex

                'Chưa cập nhật hình ảnh và mô tả

                'mvCls_Item.Image1 = ReadFile(_path_Image)
                'mvCls_Item.Image2 = ReadFile(_path_Image)
                'mvCls_Item.Image3 = ReadFile(_path_Image)
                'mvCls_Item.Image4 = ReadFile(_path_Image)
                'mvCls_Item.Image5 = ReadFile(_path_Image)
                mvCls_Item.Description = ""

                mvCls_ItemUpdate.FuncG_UpdateItem(mvCls_Item, 2)
                SubM_InitializeForm()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim mvObj_DataTable As New DataTable
        Try
            If gvByte_Language = 1 Then


                If mvBool_Search = False Then
                    SubM_EnableDisableControl(False)

                    SimpleButton3.Text = "Bỏ tìm"
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataByName(txtName.Text.Trim())
                    If mvObj_DataTable.Rows.Count <> 0 Then
                        Me.GridControl1.DataSource = Nothing
                        Me.GridControl1.DataSource = mvObj_DataTable
                        Me.GridView1.PopulateColumns()
                        Me.GridView1.BestFitColumns()
                        '================================================
                        Me.GridView1.Columns("Mã hàng").Caption = "Mã"
                        Me.GridView1.Columns("Tên hàng").Caption = "Tên"
                        Me.GridView1.Columns("Đơn vị").Caption = "Đơn vị"
                        Me.GridView1.Columns("Đơn giá").Caption = "Giá"
                    End If
                Else
                    SubM_EnableDisableControl(True)
                    SimpleButton3.Text = "Tìm kiếm"
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllData2
                    If mvObj_DataTable.Rows.Count <> 0 Then
                        Me.GridControl1.DataSource = Nothing
                        Me.GridControl1.DataSource = mvObj_DataTable
                        Me.GridView1.PopulateColumns()
                        Me.GridView1.BestFitColumns()
                        '===============================================================
                        Me.GridView1.Columns("Mã hàng").Caption = "Mã"
                        Me.GridView1.Columns("Tên hàng").Caption = "Tên"
                        Me.GridView1.Columns("Đơn vị").Caption = "Đơn vị"
                        Me.GridView1.Columns("Đơn giá").Caption = "Giá"
                    End If
                End If
            Else
                If mvBool_Search = False Then
                    SubM_EnableDisableControl(False)

                    SimpleButton3.Text = "Cancel"
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataByName(txtName.Text.Trim())
                    If mvObj_DataTable.Rows.Count <> 0 Then
                        Me.GridControl1.DataSource = Nothing
                        Me.GridControl1.DataSource = mvObj_DataTable
                        Me.GridView1.PopulateColumns()
                        Me.GridView1.BestFitColumns()
                        '===================================================
                        Me.GridView1.Columns("Mã hàng").Caption = "ID"
                        Me.GridView1.Columns("Tên hàng").Caption = "NAME"
                        Me.GridView1.Columns("Đơn vị").Caption = "UNIT"
                        Me.GridView1.Columns("Đơn giá").Caption = "PRICE"
                    End If
                Else
                    SubM_EnableDisableControl(True)
                    SimpleButton3.Text = "Search"
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllData2
                    If mvObj_DataTable.Rows.Count <> 0 Then
                        Me.GridControl1.DataSource = Nothing
                        Me.GridControl1.DataSource = mvObj_DataTable
                        Me.GridView1.PopulateColumns()
                        Me.GridView1.BestFitColumns()
                        '======================================================================
                        Me.GridView1.Columns("Mã hàng").Caption = "ID"
                        Me.GridView1.Columns("Tên hàng").Caption = "NAME"
                        Me.GridView1.Columns("Đơn vị").Caption = "UNIT"
                        Me.GridView1.Columns("Đơn giá").Caption = "PRICE"
                    End If
                End If
            End If
            mvBool_Search = Not mvBool_Search
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        Dim mvObj_DataTable As New DataTable
        Try
            If mvBool_Search = True Then
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataByName(txtName.Text.Trim())
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.GridControl1.DataSource = Nothing
                    Me.GridControl1.DataSource = mvObj_DataTable
                    Me.GridView1.PopulateColumns()
                    Me.GridView1.BestFitColumns()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SubM_EnableDisableControl(ByVal iBool_Enable As Boolean)
        txtID.Enabled = iBool_Enable
        txtPrice1.Enabled = iBool_Enable
        txtPrice2.Enabled = iBool_Enable
        txtUnit.Enabled = iBool_Enable
        lkpNhomHang.Enabled = iBool_Enable
        lkpPrinter.Enabled = iBool_Enable
    End Sub

    ''' <summary>
    ''' ReadFile - Dùng để đọc một file ảnh trên đĩa và convert sang mảng byte
    ''' </summary>
    ''' <Author>Van Long</Author>
    ''' <Date>2013/12/19</Date>
    ''' <param name="sFileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadFile(ByVal sFileName As String) As Byte()
        Dim fs As System.IO.FileStream = New System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read)
        Dim rs() As Byte = New Byte(fs.Length) {}
        fs.Read(rs, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        Return rs
    End Function
End Class

    

