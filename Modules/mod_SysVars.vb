Module mod_SysVars
#Region "Biến hệ thống"
    Public gvStr_EmployeeName As String 'Tên người đăng nhập
    Public gvStr_Permit As String  'Level của người đăng nhập
    Public gvInt_Permit As Integer  'Level của người đăng nhập
    Public gvCls_Company As New cls_CompanyInfo 'Thông tin công ty
    Public gvByte_Language As Byte  'Thông tin ngôn ngữ 1: Việt Nam, 2: English
    Public gvByte_Digit As Byte     'Số lẻ thập phân (dùng để làm tròn khi tính tiền)
    Public gvStr_LocID As String    'ID phân biệt với database khác trong TH gộp chung dữ liệu vào 1 database
    Public gvTxt_Focus As DevExpress.XtraEditors.TextEdit   'Textbox đang active (dùng bàn phím ảo)
    Public gvBol_FastFood As Boolean = False   'Lưu chế độ đang làm việc có phải là FastFood hay bán bình thường
    Public gvBol_RedStatus As Boolean   'Chế độ làm việc (tính tiền liền hoặc có tạm tính)
    Public gvBol_VatStatus As Boolean   'Chế độ làm việc (có thêm VAT vào hóa đơn)
    Public gvBol_PrintOrder As Boolean   'Chế độ làm việc (In món ra bếp hoặc bar)
    Public gvByte_NumberPrint As Byte  'Số liên của hóa đơn
    Public gvBol_AutoSync As Boolean = False 'Tự động đồng bộ
    Public gvByte_ReportTime As Byte = 0 'Định giờ lấy báo cáo vd: 24/01/2013 07:00:00 đến 25/01/2013 07:00:00
    Public gvByte_AddedHour As Byte = 24 'Giờ cộng thêm vào báo cáo

    Public gvInt_StartMenu As Integer = 0 'Bắt đầu menu
    Public gvInt_EndMenu As Integer = 23 'Kết thúc menu
    Public gvInt_StartPluOfMenu As Integer = 0 'Món bắt đầu trong 1 group
    Public gvInt_EndPluOfMenu As Integer = 39 'Món kết thúc trong 1 group
    Public gvInt_StartItem As Integer = 1 'Bắt đầu món ăn trong db
    Public gvInt_EndItem As Integer = 1920 'Kết thúc món ăn trong db (món mở > 999, nguyên liệu > 1000000000
#End Region
#Region "Biến báo cáo"

#End Region
End Module
