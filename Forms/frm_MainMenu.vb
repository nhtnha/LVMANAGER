Imports DevExpress.XtraBars.Helpers
Imports System.Data.SqlClient

Public Class frm_MainMenu
#Region "Khai Báo Biến"
    Dim mvCls_Main As New cls_Main
    Public mvBol_IsChoseInventory As Boolean = False
#End Region
#Region "Refresh time"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblTimer.Caption = Format(Now(), "dd/MM/yyyy HH:mm:ss")
        Me.lblName.Caption = "Hello " + gvStr_EmployeeName + " !"
        Me.lblLocation.Caption = "Server :" + gvStr_Server

    End Sub
#End Region
#Region "Show - hide form"
    Private Sub frm_MainMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.NotifyIcon1.Dispose()
    End Sub
    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If WindowState = FormWindowState.Minimized Then
            Me.NotifyIcon1.Visible = True
            Me.Visible = False
        End If
        If Me.WindowState <> FormWindowState.Minimized Then
            With PanelControl1
                .Left = (Me.ClientPanel.ClientRectangle.Width / 2) - (.Width / 2)
                .Top = (Me.ClientPanel.ClientRectangle.Height / 2) - (.Height / 2)
            End With
        End If
    End Sub
    Private Sub Form1_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub NotifyIcon1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDown
        If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
            Me.PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
#End Region
#Region "Formload"
    Private Sub frm_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mvObj_DataTable As New DataTable
        Try
            If AppIsAlreadyRunning() Then
                SubG_Alert(101) ' FunG_Alert("Thông báo", "Chương trình đang chạy.Xin vui lòng đợi trong giây lát!", frm_Alert.WTYPE.STOP)
                End
            Else
                SkinHelper.InitSkinPopupMenu(Me.bbiGiaoDien)
                Me.NotifyIcon1.Visible = False
                spl_FlashForm.ShowDialog()
                frm_Location.mvBol_IsExits = True
                frm_Location.ShowDialog()
                mvCls_Main.SubG_Load()
                SubM_GetCompanyInfo()
                Me.Text = "LV Manager - " + gvStr_Location
                Loadlanguage()
                'SubM_LoadSetting()
                'Nếu đặt chế độ AUTO_SYN: tự động đồng bộ dữ liệu bán hàng (TBL_ITEM, TBL_INCOME, TBL_SALES, TBL_SALES_DETAILS...) hien thong tin tu dong bo
                'If gvBol_AutoSync = True Then

                'frm_AutoSync.ShowDialog()
                '    Dim mvCls_SyncData As New cls_Synchronous_Data()
                '    Dim mvObj_ClientConn As New SqlConnectionStringBuilder() With {.DataSource = "SOFTWARE\SOFTWARE2", .InitialCatalog = "PHUONGTRANGTG", .UserID = "sa", .Password = "0985050067", .PersistSecurityInfo = False}
                '    Dim mvObj_ServerConn As New SqlConnectionStringBuilder() With {.DataSource = "SOFTWARE", .InitialCatalog = "PHUONGTRANGTG", .UserID = "sa", .Password = "0985050067", .PersistSecurityInfo = False}
                '    mvCls_SyncData.ClientConn = mvObj_ClientConn.ConnectionString
                '    mvCls_SyncData.ServerConn = mvObj_ServerConn.ConnectionString

                '    mvCls_SyncData.FuncM_SyncByTableName("TBL_SALES")
                'End If


                ' Fag = True Or txtUserName.Text.ToUpper() = "ADMIN" Then
                'If gvStr_Permit = "11111111" Then

                'Else

                'End If
                If gvStr_LocID <> "00" Then
                    bbiSync.Enabled = False
                    bbiChoseInventory.Enabled = False
                End If

                If gvStr_AccUser.ToUpper = "PHANMEM" Then
                    bbiDeleteDB.Enabled = True
                End If
                SubM_PhanQuyen()
                lblRegistry.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "LoadLanguage"
    Public Sub Loadlanguage()
        If gvByte_Language = 1 Then
            '=======================================
            RibbonPage4.Text = "Báo cáo"
            bbiBaocaodinhluong.Caption = "Định lượng"
            bbiBaoCaoHangHoa.Caption = "Hàng hóa"
            bbiBaoCaoKH.Caption = "Báo cáo KH"
            bbiBaoCaoNCC.Caption = "Báo cáo NCC"
            bbiTaiChinh.Caption = "Tài chính"
            bbiBCHoaDon.Caption = "Hóa đơn"
            bbiBCLoiNhuan.Caption = "Lợi nhuận"
            btnReturn.Caption = "Trả hàng"
            bbiThuChi.Caption = "Thu chi"
            bbiChoseInventory.Caption = "Chọn kho"
            bbiNhapKho.Caption = "Nhập kho"
            bbiXuatKho.Caption = "Xuất kho"
            bbiStock.Caption = "Tồn kho"
            bbBaoCaoCongNoKH.Caption = "Công nợ KH"
            bbiBaoCaoCongNoNCC.Caption = "Công nợ NCC"
            BarButtonItem3.Caption = "NX TỒN"
            btnNguuyenLieu.Caption = "Nguyên liệu"
            RpBCdanhmuc.Text = "Danh mục"
            RpBCBanhang.Text = "Bán hàng"
            RpBCthuchi.Text = "Thu chi"
            RpBCQUanLyKho.Text = "Quản lý kho"
            RpBCCongno.Text = "Công nơ"
            RpCNCongno.Text = "Công nợ"
            btnDoanhThu.Caption = "Doanh Thu KH"
            BarButtonItem2.Caption = "BC Hủy Bàn"
            '=======================================
            RibbonPage1.Text = "Nghiệp vụ"
            bbiHoaDon.Caption = "Hàng đã bán"
            bbiLogOut.Caption = "Đăng xuất"
            bbiChangePass.Caption = "Đổi M.Khẩu"
            bbiPhieuThu.Caption = "Phiếu thu"
            bbiPhieuChi.Caption = "Phiếu chi"
            bbiTonDau.Caption = "Tồn đầu"
            bbiPhieuNhap.Caption = "Phiếu nhập"
            bbiPhieuXuat.Caption = "Phiếu xuất"
            btnCandoikho.Caption = "Cân đối kho"
            bbiHuongDan.Caption = "Hướng dẫn"
            bbiLienHe.Caption = "Liên hệ"
            ' bbiChoseInventory.Caption = "Selection entrepôt"
            'bbiNhapKho.Caption = "Remplir Entrepôt"
            'bbiXuatKho.Caption = "l'entreposage"
            'bbiStock.Caption = "Stocks"
            RibbonPageGroup4.Text = "Hệ thống"
            RpNVthuchi.Text = "Nghiệp vụ"
            RpNVQuanlykho.Text = "Quản lý kho"
            RibbonPageGroup6.Text = "Hỗ trợ"
            '=======================================
            RibbonPage5.Text = "Cập nhật"
            bbiNhomHang.Caption = "Nhóm hàng"

            bbiHangHoa.Caption = "Hàng hóa"
            bbiKhachHang.Caption = "Khách hàng"
            bbiNhaCC.Caption = "Nhà cung cấp"
            RpCNdanhmuc.Text = "Danh mục"
            bbiCongNoKH.Caption = "Khách hàng"
            bbiCongNoNCC.Caption = "Nhà cung cấp"
            RpCNHethong.Text = "Hệ thống"
            bbiThongTin.Caption = "Thông tin công ty"
            bbiTaiKhoan.Caption = "TK bán hàng"
            BarButtonItem7.Caption = "TK Quản lý"
            btnAddEmployee.Caption = "Quản lý nhân viên"
            bbiDeleteDB.Caption = "Xóa dữ liệu"
            bbiSync.Caption = "Đồng bộ"
            '============================================
            RpCNkvban.Text = "Khu vực - Bàn"
            btnArea.Caption = "Khu vực"
            btntable.Caption = "Danh sách bàn"
            '===========
            bbiBaoCaoNhapKho.Caption = "Báo cáo nhập kho"
            bbiNhapKhoNCC.Caption = "Nhập kho NCC"

            bbiBaoCaoXuatHang.Caption = "Báo cáo xuất kho"
            bbiXuatKhoKH.Caption = "Xuất kho NCC"
            bbTonKhoTongHop.Caption = "Tồng kho tổng hợp"
            bbiTonKhoCT.Caption = "Tồn kho chi tiết"
            '========================================
            rgpLanguage.Properties.Items.Item(0).Description = "Tiếng Việt"
            rgpLanguage.Properties.Items.Item(1).Description = "Tiếng Anh"

        ElseIf gvByte_Language = 2 Then

            RibbonPage4.Text = "Report"
            bbiBaocaodinhluong.Caption = "Quantification"
            bbiBaoCaoHangHoa.Caption = "Item"
            bbiBaoCaoKH.Caption = "Customer"
            bbiBaoCaoNCC.Caption = "Providers"
            bbiTaiChinh.Caption = "Finances"
            bbiBCHoaDon.Caption = "Invoice Report"
            bbiBCLoiNhuan.Caption = "Profit"
            btnReturn.Caption = "Return"
            bbiThuChi.Caption = "Receive-Payment"
            bbiChoseInventory.Caption = "Select Inventory"
            bbiNhapKho.Caption = "Import"
            bbiXuatKho.Caption = "Export"
            bbiStock.Caption = "Stocks"
            bbBaoCaoCongNoKH.Caption = "Liabilities"
            bbiBaoCaoCongNoNCC.Caption = "Debt Providers"
            BarButtonItem3.Caption = "Export-Import-inventory"
            btnNguuyenLieu.Caption = "Material"
            btnDoanhThu.Caption = "Revenue Customer"
            BarButtonItem2.Caption = "Cancel Table"
            RpBCdanhmuc.Text = "Category"
            RpBCBanhang.Text = "Sale"
            RpBCthuchi.Text = "Receive-Payment"
            RpBCQUanLyKho.Text = "Inventory Manager"
            RpBCCongno.Text = "Debts"
            RpCNCongno.Text = "Contabilité"
            '=======================================
            RibbonPage1.Text = "Major"
            bbiHoaDon.Caption = "Goods sold"
            bbiLogOut.Caption = "Log Out"
            bbiChangePass.Caption = "Change Password"
            bbiPhieuThu.Caption = "Receive"
            bbiPhieuChi.Caption = "Payment"
            bbiTonDau.Caption = "Beginning Inventory"
            bbiPhieuNhap.Caption = "Import Inventory"
            bbiPhieuXuat.Caption = "Export Inventory"
            btnCandoikho.Caption = "Balance Inventory"
            bbiHuongDan.Caption = "Guid"
            bbiLienHe.Caption = "Contact"

            'bbiChoseInventory.Caption = "Selection entrepôt"
            'bbiNhapKho.Caption = "Remplir Entrepôt"
            'bbiXuatKho.Caption = "l'entreposage"
            'bbiStock.Caption = "Stocks"
            RibbonPageGroup4.Text = "Systems"
            RpNVthuchi.Text = "Major"
            RpNVQuanlykho.Text = "Inventory Manager"
            RibbonPageGroup6.Text = "Support"
            '=======================================
            RibbonPage5.Text = "Update"
            bbiNhomHang.Caption = "Group Item"

            bbiHangHoa.Caption = "Item"
            bbiKhachHang.Caption = "Customer"
            bbiNhaCC.Caption = "Provider"
            RpCNdanhmuc.Text = "Category"
            bbiCongNoKH.Caption = "Debt Customer"
            bbiCongNoNCC.Caption = "Debt Provider"
            RpCNHethong.Text = "System"
            bbiThongTin.Caption = "Company Information"
            bbiTaiKhoan.Caption = "Account Manager"
            btnAddEmployee.Caption = "Employee"
            bbiDeleteDB.Caption = "Delete Data"
            bbiSync.Caption = "Sync System"
            '============================================
            RpCNkvban.Text = "Area - Table"
            btnArea.Caption = "Area"
            btntable.Caption = "List Table"
            '============================================
            rgpLanguage.Properties.Items.Item(0).Description = "Vietnamese"
            rgpLanguage.Properties.Items.Item(1).Description = "English"
        End If
        rgpLanguage.SelectedIndex = gvByte_Language - 1
    End Sub
#End Region
#Region "LoadSetting"
    Private Sub SubM_LoadSetting()
        Dim mvObj_DataTable As New DataTable
        Dim mvCls_SetupUpdate As New cls_Setup_Update
        Try
            mvObj_DataTable = mvCls_SetupUpdate.FuncG_GetData
            If mvObj_DataTable.Rows.Count = 0 Then
                Exit Sub
            Else
                gvBol_AutoSync = mvObj_DataTable.Rows(0)("AUTO_SYNC")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Hide Customization Menu"
    Private Sub RibbonControl_ShowCustomizationMenu(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventArgs) Handles RibbonControl.ShowCustomizationMenu
        Try
            e.ShowCustomizationMenu = False
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút phóng to"
    Private Sub bbiPhongTo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhongTo.ItemClick
        Me.NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub bbiThoat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiThoat.ItemClick
        Try
            End
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút đăng xuất"
    Private Sub bbiLogOut_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLogOut.ItemClick
        Try
            'Ghi lại logfile
            'mvCls_Logfile.UserName = gvStr_AccUser
            'mvCls_Logfile.Detail = "Thoát khỏi chương trình"
            'mvCls_UpdateLogfile.FuncG_Insert(mvCls_Logfile)
            'Me.ClientPanel.Controls.Clear()
            frm_Login.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Đổi mật khẩu"
    Private Sub bbiChangePass_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiChangePass.ItemClick
        frm_ChangePassword.ShowDialog()
    End Sub
#End Region
#Region "Nút hàng hóa"
    Private Sub bbiNgoaiTe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHangHoa.ItemClick
        frm_SetMenu.ShowDialog()
    End Sub
#End Region
#Region "Nút liên hệ"
    Private Sub bbiLienHe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLienHe.ItemClick
        frm_Contact.ShowDialog()
    End Sub
#End Region
#Region "Nút đăng ký"
    Private Sub bbiDangKy_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDangKy.ItemClick
        frm_License.ShowDialog()
    End Sub
#End Region
#Region "Nút thông tin công ty"
    Private Sub bbiThongTin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiThongTin.ItemClick
        frm_CompanyInfo.ShowDialog()
    End Sub
#End Region
#Region "Nút tài khoản"
    Private Sub bbiTaiKhoan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTaiKhoan.ItemClick
        frm_Account.ShowDialog()
    End Sub
#End Region
#Region "Nút nhóm hàng"
    Private Sub bbiNhomHang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNhomHang.ItemClick
        frm_GroupItem.ShowDialog()
    End Sub
#End Region
#Region "Nút xóa DB"
    Private Sub bbiDeleteDB_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDeleteDB.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "XoaDL"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút tồn đầu"
    Private Sub bbiTonDau_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTonDau.ItemClick
        frm_StockInHand.ShowDialog()
    End Sub
#End Region
#Region "Nút thu"
    Private Sub bbiPhieuThu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhieuThu.ItemClick
        frm_ReceiptPayment.mvStr_Type = "PT"
        frm_ReceiptPayment.ShowDialog()
    End Sub
#End Region
#Region "Nút chi"
    Private Sub bbiPhieuChi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhieuChi.ItemClick
        frm_ReceiptPayment.mvStr_Type = "PC"
        frm_ReceiptPayment.ShowDialog()
    End Sub
#End Region
#Region "Nút khách hàng"
    Private Sub bbiKhachHang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiKhachHang.ItemClick
        frm_Customer.ShowDialog()
    End Sub
#End Region
#Region "Nút nhà cung cấp"
    Private Sub bbiNhaCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNhaCC.ItemClick
        frm_Supplier.ShowDialog()
    End Sub
#End Region
#Region "Nút nhập hàng"
    Private Sub bbiPhieuNhap_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhieuNhap.ItemClick
        frm_ImportExport.gvStr_Status = "PN"
        frm_ImportExport.ShowDialog()
    End Sub
#End Region
#Region "Nút xuất kho"
    Private Sub bbiPhieuXuat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhieuXuat.ItemClick
        frm_ImportExport.gvStr_Status = "PX"
        frm_ImportExport.ShowDialog()
    End Sub
#End Region
#Region "Nút công nợ KH"
    Private Sub bbiCongNoKH_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCongNoKH.ItemClick
        frm_DeptCollection.gvStr_Status = "KH"
        frm_DeptCollection.ShowDialog()
    End Sub
#End Region
#Region "Nút công nợ NCC"
    Private Sub bbiCongNoNCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCongNoNCC.ItemClick
        frm_DeptCollection.gvStr_Status = "NCC"
        frm_DeptCollection.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo công nợ KH"
    Private Sub bbBaoCaoCongNoKH_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbBaoCaoCongNoKH.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "CongNoKH"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo công nợ NCC"
    Private Sub bbiBaoCaoCongNoNCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBaoCaoCongNoNCC.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "CongNoNCC"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo thu chi"
    Private Sub bbiThuChi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiThuChi.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "ThuChi"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo nhập kho"
    Private Sub bbiNhapKho_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNhapKho.ItemClick, bbiBaoCaoNhapKho.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "NhapKho"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo nhập kho theo NCC"
    Private Sub bbiNhapKhoNCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNhapKhoNCC.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "NhapKhoNCC"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo xuất kho"
    Private Sub bbiNhapKho1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiXuatKho.ItemClick, bbiBaoCaoXuatHang.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "XuatKho"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo tồn kho"
    Private Sub bbiStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiStock.ItemClick
        Try
            'Dim mvRpt_Report As New rpt_ReportStockInHands
            'Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
            'mvFrm_LoadReport.ShowDialog()
            frm_StockReports.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút báo cáo sổ tổng hợp"
    Private Sub bbTonKhoTongHop_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbTonKhoTongHop.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "TonKhoTongHop"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo sổ chi tiết"
    Private Sub bbiTonKhoCT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTonKhoCT.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "TonKhoCT"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo tài chính"
    Private Sub bbiTaiChinh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTaiChinh.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "TaiChinh"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo hóa đơn chi tiết"
    Private Sub bbiHoaDon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHoaDon.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "CTHoaDon"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo hóa đơn"
    Private Sub bbiBCHoaDon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBCHoaDon.ItemClick
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "HoaDon"
        frm_ReportsFromTo.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo hàng hóa"
    Private Sub bbiBaoCaoHangHoa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBaoCaoHangHoa.ItemClick
        Try
            Dim mvRpt_Report As New rpt_ReportItem
            Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
            mvFrm_LoadReport.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút báo cáo KH"
    Private Sub bbiBaoCaoKH_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBaoCaoKH.ItemClick
        Dim mvRpt_Report As New rpt_ReportEmployee
        Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
        mvRpt_Report.SetParameterValue("Type", 1)
        mvFrm_LoadReport.ShowDialog()
    End Sub
#End Region
#Region "Nút báo cáo NCC"
    Private Sub bbiBaoCaoNCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBaoCaoNCC.ItemClick
        Dim mvRpt_Report As New rpt_ReportEmployee
        Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
        mvRpt_Report.SetParameterValue("Type", 3)
        mvFrm_LoadReport.ShowDialog()
    End Sub
#End Region
#Region "Nút đồng bộ dữ liệu"
    Private Sub bbiSync_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSync.ItemClick
        frm_AutoSync.ShowDialog()
    End Sub
#End Region

    Private Sub bbiChoseInventory_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiChoseInventory.ItemClick
        frm_Location.mvBol_IsExits = False
        frm_Location.ShowDialog()
        If mvBol_IsChoseInventory = False Then
            mvCls_Main.SubG_Load()
            SubM_GetCompanyInfo()
            Me.Text = "LV Manager - " + gvStr_Location
            SubM_LoadSetting()
        End If
        mvBol_IsChoseInventory = False
    End Sub


    Private Sub btnAddEmployee_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddEmployee.ItemClick
        frm_Employee.Show()
        'Me.Close()
    End Sub



    Private Sub bbiBCLoiNhuan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBCLoiNhuan.ItemClick
        frm_ReportsFromTo.gvStr_ReportType = "LaiLo"
        frm_ReportsFromTo.ShowDialog()
    End Sub

    Private Sub bbiBaocaodinhluong_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBaocaodinhluong.ItemClick
        frm_ReportsFromTo.gvStr_ReportType = "DinhLuong"
        frm_ReportsFromTo.ShowDialog()
    End Sub




    Private Sub btnReturn_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReturn.ItemClick

        frm_ReportsFromTo.gvStr_ReportType = "TraHang"
        frm_ReportsFromTo.ShowDialog()
    End Sub

    Private Sub btnCandoikho_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCandoikho.ItemClick
        frm_InventoryBalance.ShowDialog()
    End Sub
#Region "Nút đồng bộ dữ liệu"
    Private Sub btnNguuyenLieu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNguuyenLieu.ItemClick
        frm_ReportsFromToNL.gvStr_ReportType = "NguyenLieu"

        frm_ReportsFromToNL.ShowDialog()
    End Sub
#End Region

    Private Sub btnDoanhThu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDoanhThu.ItemClick
        'Dim mvRpt_Report As New rpt_ReportDoanhthuKH
        'Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
        'mvRpt_Report.SetParameterValue("Type", 1)
        'mvFrm_LoadReport.ShowDialog()
        frm_ReportsFromTo.Text = DirectCast(sender, DevExpress.XtraBars.Ribbon.RibbonBarManager).PressedLink.Caption
        frm_ReportsFromTo.gvStr_ReportType = "DOANHTHUKH"
        frm_ReportsFromTo.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        frm_ReportsFromTo.gvStr_ReportType = "BCHUYBAN"
        frm_ReportsFromTo.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frm_StockReportsNXT.ShowDialog()
    End Sub

    Private Sub btnArea_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArea.ItemClick
        frm_Area.ShowDialog()
    End Sub

    Private Sub rgpLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgpLanguage.SelectedIndexChanged
        Try
            If Me.rgpLanguage.SelectedIndex = 0 Then
                gvByte_Language = 1
            Else
                gvByte_Language = 2
            End If
            mod_LoadLanguageForm.SubG_LoginForm()
            Loadlanguage()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btntable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btntable.ItemClick
        frm_TableM.ShowDialog()
    End Sub

    Private Sub beiRadius_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles beiRadius.ItemClick
        '  Debug.WriteLine("BarEditItem1 EditValue: " & (CType(Ribbon.Manager.ActiveEditor, DevExpress.XtraEditors.RadioGroup)).EditValue)
    End Sub

    Private Sub rgblanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgblanguage.SelectedIndexChanged
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frm_Unit.ShowDialog()
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frm_DateFromTo.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        frm_ReportsFromTo.gvStr_ReportType = "BCXUATMONMO"
        frm_ReportsFromTo.ShowDialog()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        frm_AccountQL.ShowDialog()
    End Sub

    Public Shared Sub SubM_PhanQuyen()
        Try
            frm_MainMenu.Enabled = True
            frm_MainMenu.RpBCdanhmuc.Visible = String.Equals(gvStr_Permit(0), "1"c)
            frm_MainMenu.RpBCBanhang.Visible = String.Equals(gvStr_Permit(1), "1"c)
            frm_MainMenu.RpBCthuchi.Visible = String.Equals(gvStr_Permit(2), "1"c)
            frm_MainMenu.RpBCQUanLyKho.Visible = String.Equals(gvStr_Permit(3), "1"c)
            frm_MainMenu.RpBCCongno.Visible = String.Equals(gvStr_Permit(4), "1"c)

            frm_MainMenu.RpNVthuchi.Visible = String.Equals(gvStr_Permit(5), "1"c)
            frm_MainMenu.RpNVQuanlykho.Visible = String.Equals(gvStr_Permit(6), "1"c)

            frm_MainMenu.RpCNdanhmuc.Visible = String.Equals(gvStr_Permit(7), "1"c)
            frm_MainMenu.RpCNkvban.Visible = String.Equals(gvStr_Permit(8), "1"c)
            frm_MainMenu.RpCNCongno.Visible = String.Equals(gvStr_Permit(9), "1"c)
            frm_MainMenu.RpCNHethong.Visible = String.Equals(gvStr_Permit(10), "1"c)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        frm_ReportsFromTo.gvStr_ReportType = "HISTORYBALANCE"
        frm_ReportsFromTo.ShowDialog()
    End Sub
End Class