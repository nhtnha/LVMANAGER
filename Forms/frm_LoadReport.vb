Imports System.ComponentModel
Imports CrystalDecisions.Shared

Public Class frm_LoadReport
#Region "Khai báo biến"
    Public gvRpt_Object As New Object   'Chứa loại report cần xem
    Dim mvBol_Close As Boolean = False

    Public gTuNgay As DateTime
    Public gDenNgay As DateTime
    Public gCashierID As String
#End Region
#Region "Hàm khởi tạo"
    Public Sub New(ByVal iObj_Report As Object)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        gvRpt_Object = iObj_Report
        If gvByte_Language = 1 Then
            cmdPrint.Text = "In"
        Else
            cmdPrint.Text = "Print"
        End If
    End Sub
#End Region
#Region "This event handler is where the time-consuming work is done."
    Private Sub backgroundWorker1_DoWork(ByVal sender As System.Object, _
    ByVal e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim i As Integer
        Dim RandomClass As New Random()
        For i = 1 To 10
            ' Perform a time consuming operation and report progress.
            System.Threading.Thread.Sleep(RandomClass.Next(10, 200))
            worker.ReportProgress(i * 10)
        Next
    End Sub
#End Region
#Region "This event handler updates the progress."
    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As System.Object, _
    ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ProgressBarControl1.Position = e.ProgressPercentage.ToString
    End Sub
#End Region
#Region "This event handler deals with the results of the background operation."
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, _
        ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            If gvByte_Language = 1 Then
                lblProgress.Text = "Lỗi: " & e.Error.Message
            Else
                lblProgress.Text = "Error: " & e.Error.Message
            End If
        Else
            If gvByte_Language = 1 Then
                lblProgress.Text = "Hoàn tất!"
            Else
                lblProgress.Text = "Done!"
            End If
            CrystalReportViewer1.ReportSource = gvRpt_Object
        End If
        Me.Cursor = Cursors.Default
    End Sub
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Me.mvBol_Close = False
        Me.ProgressBarControl1.Properties.Minimum = 0
        Me.ProgressBarControl1.Properties.Maximum = 100
        If gvByte_Language = 1 Then
            Me.gpcHeader.Text = "Báo cáo"
            Me.lblProgress.Text = "Đang xử lý ..."
            Me.cmdExport.Text = "Xuất file"
            Me.cmdExit.Text = "Thoát"
            cmdPrint.Text = "IN"
        Else
            Me.gpcHeader.Text = "Report"
            Me.lblProgress.Text = "Progressing ..."
            Me.cmdExport.Text = "Export file"
            Me.cmdExit.Text = "Exit"
            cmdPrint.Text = "PRINT"
        End If
        If BackgroundWorker1.IsBusy <> True Then
            LoadReport(Me.gvRpt_Object)
            SubM_LoadInfoInReport(gvRpt_Object)
            ' Start the asynchronous operation.
            BackgroundWorker1.RunWorkerAsync()
            Me.Cursor = Cursors.WaitCursor
        End If
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_LoadReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not mvBol_Close Then
            e.Cancel = True
        End If
    End Sub
    Private Sub frm_LoadReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút Next"
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If Me.CrystalReportViewer1.ReportSource Is Nothing Then
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo!", "Vui lòng chờ trong giây lát", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Message", "Please wait a moment!", frm_Alert.WTYPE.ERROR)
            End If

        Else
            Me.CrystalReportViewer1.ShowNextPage()
        End If
    End Sub
#End Region
#Region "Nút Previous"
    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        If Me.CrystalReportViewer1.ReportSource Is Nothing Then
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo!", "Vui lòng chờ trong giây lát", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Message", "Please wait a moment!", frm_Alert.WTYPE.ERROR)
            End If
        Else
            Me.CrystalReportViewer1.ShowPreviousPage()
        End If
    End Sub
#End Region
#Region "Nút Print"
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Me.CrystalReportViewer1.ReportSource Is Nothing Then
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo!", "Vui lòng chờ trong giây lát", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Message", "Please wait a moment!", frm_Alert.WTYPE.ERROR)
            End If
        Else
            gvRpt_Object.PrintToPrinter(1, True, 0, 0)
        End If
    End Sub
#End Region
#Region "Nút Export"
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            If Me.CrystalReportViewer1.ReportSource Is Nothing Then
                If gvByte_Language = 1 Then
                    FunG_Alert("Thông báo!", "Vui lòng chờ trong giây lát", frm_Alert.WTYPE.ERROR)
                Else
                    FunG_Alert("Message", "Please wait a moment!", frm_Alert.WTYPE.ERROR)
                End If
            Else
                If frm_ReportsFromTo.gvStr_ReportType = "CTHoaDon" Then

                    Dim drs As frm_Alert.WRESULT
                    If gvByte_Language = 1 Then
                        drs = FunG_Alert("Thông Báo", "Bạn có muốn xuất ra file excel tùy chọn không?", frm_Alert.WTYPE.YESNO)
                    Else
                        drs = FunG_Alert("Message", "Do you want to export to excel file option does not?", frm_Alert.WTYPE.YESNO)
                    End If


                    If (drs = frm_Alert.WRESULT.YES) Then
                        Dim drsSave As New DialogResult
                        Dim saveFile As New SaveFileDialog
                        saveFile.Filter = "File Excel (.xls)|*.xls"

                        drsSave = saveFile.ShowDialog()
                        If drsSave = System.Windows.Forms.DialogResult.OK Then
                            Dim cls_ReportUpdate As New cls_Report_Update
                            Dim dtGroup As New DataTable
                            Dim dt As New DataTable
                            dtGroup = cls_ReportUpdate.FuncG_GetDataReport_CTHoaDon_2(gTuNgay, gDenNgay, gCashierID)
                            dt = cls_ReportUpdate.FuncG_GetDataReport_CTHoaDon(gTuNgay, gDenNgay, gCashierID)

                            ghifileexcel(saveFile.FileName, dtGroup, dt, gTuNgay, gDenNgay)
                            If gvByte_Language = 1 Then
                                FunG_Alert("Thông Báo", "Xuất file thành công", frm_Alert.WTYPE.CHECK)
                            Else
                                FunG_Alert("Message", "Successful Export files", frm_Alert.WTYPE.CHECK)
                            End If

                        End If
                    Else
                        Me.CrystalReportViewer1.ExportReport()
                    End If
                Else
                    Me.CrystalReportViewer1.ExportReport()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        gvRpt_Object.Dispose()
        mvBol_Close = True
        Me.Close()
    End Sub
#End Region
#Region "xử lý excel"
    ' ghi file excel
    Private Function ghifileexcel(ByVal pathExcel As String, ByVal dtGroup As DataTable, ByVal dt As DataTable, ByVal tuNgay As String, ByVal denNgay As String) As Boolean
        ' false: tạo excel thất bại
        ' true: tạo excel thành công
        Dim flag As Boolean = True

        ' cấu hình excel
        Dim myExcelApp As Microsoft.Office.Interop.Excel.Application
        Dim myExcelWorkbooks As Microsoft.Office.Interop.Excel.Workbooks
        Dim myExcelWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value

        myExcelApp = New Microsoft.Office.Interop.Excel.ApplicationClass()
        myExcelApp.Visible = False
        myExcelApp.DisplayAlerts = False
        myExcelWorkbooks = myExcelApp.Workbooks

        Dim startRow As Integer = 4

        Try
            ' load file mẫu excel
            myExcelWorkbook = myExcelApp.Workbooks.Open(Environment.CurrentDirectory + "/CTHoaDon.xls")

            Dim myExcelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(myExcelWorkbook.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            ' ghi tieu de
            diendulieuvaoexxcel_tieude(myExcelWorksheet, tuNgay, denNgay)

            ' ghi noi dung
            diendulieuvaoexcel_noidung(myExcelWorksheet, dtGroup, dt, startRow)

            ' lưu
            myExcelWorkbook.SaveAs(pathExcel)
        Catch ex As Exception
            ' lỗi
            flag = False
            MessageBox.Show("Lỗi: " + ex.Message)
        Finally
            ' dọn vùng nhớ
            myExcelWorkbook.Close()
            myExcelApp.Quit()
        End Try

        Return flag
    End Function

    ' điền dữ liệu vào from excel tiêu đề
    Private Sub diendulieuvaoexxcel_tieude(ByVal myExcelWorksheet As Microsoft.Office.Interop.Excel.Worksheet, ByVal tuNgay As String, ByVal denNgay As String)
        Try
            Dim misValue As Object = System.Reflection.Missing.Value

            myExcelWorksheet.Range("D2").Formula = tuNgay
            myExcelWorksheet.Range("F2", "H2").Formula = denNgay
        Catch
        End Try
    End Sub

    ' điền dữ liệu vào form excel nội dung
    Private Sub diendulieuvaoexcel_noidung(ByVal myExcelWorksheet As Microsoft.Office.Interop.Excel.Worksheet, ByVal dataGroup As DataTable, ByVal data As DataTable, ByVal index As Integer)
        Try
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim border As Microsoft.Office.Interop.Excel.Borders
            Dim stt As Integer = 1
            Dim groupName As String = ""

            Dim dv As New DataView(data)

            ' group
            For Each rowGroup As DataRow In dataGroup.Rows
                ' mat hang
                myExcelWorksheet.Range("B" + index.ToString()).Formula = rowGroup("GROUPNAME").ToString()
                myExcelWorksheet.Range("B" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("B" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("B" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' sl
                myExcelWorksheet.Range("C" + index.ToString()).Formula = rowGroup("QUANTITY").ToString()
                myExcelWorksheet.Range("C" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("C" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("C" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' don gia
                myExcelWorksheet.Range("D" + index.ToString()).Formula = rowGroup("PRICE").ToString()
                myExcelWorksheet.Range("D" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("D" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("D" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' giam gia
                myExcelWorksheet.Range("E" + index.ToString()).Formula = rowGroup("TOTALDISCOUNT").ToString()
                myExcelWorksheet.Range("E" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("E" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("E" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' phi ph. vu
                myExcelWorksheet.Range("F" + index.ToString()).Formula = rowGroup("TOTALSERVICE").ToString()
                myExcelWorksheet.Range("F" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("F" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("F" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' vat
                myExcelWorksheet.Range("G" + index.ToString()).Formula = rowGroup("TOTALVAT").ToString()
                myExcelWorksheet.Range("G" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("G" + index.ToString()).Font.Size = 14
                border = myExcelWorksheet.Range("G" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                ' tong tien
                myExcelWorksheet.Range("H" + index.ToString()).Formula = rowGroup("FINALTOTAL").ToString()
                myExcelWorksheet.Range("H" + index.ToString()).Font.Bold = True
                myExcelWorksheet.Range("H" + index.ToString()).Font.Size = 14

                border = myExcelWorksheet.Range("H" + index.ToString()).Borders
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                index += 1

                ' noi dung
                dv.RowFilter = String.Format("GROUPNAME = '{0}'", rowGroup("GROUPNAME").ToString())
                For Each row As DataRow In dv.ToTable().Rows
                    ' stt               
                    myExcelWorksheet.Range("A" + index.ToString()).Formula = stt.ToString()
                    border = myExcelWorksheet.Range("A" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' mat hang
                    myExcelWorksheet.Range("B" + index.ToString()).Formula = row("ITEMNAME").ToString()
                    border = myExcelWorksheet.Range("B" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' sl
                    myExcelWorksheet.Range("C" + index.ToString()).Formula = row("QUANTITY").ToString()
                    border = myExcelWorksheet.Range("C" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' don gia
                    myExcelWorksheet.Range("D" + index.ToString()).Formula = row("PRICE").ToString()
                    border = myExcelWorksheet.Range("D" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' giam gia
                    myExcelWorksheet.Range("E" + index.ToString()).Formula = row("TOTALDISCOUNT").ToString()
                    border = myExcelWorksheet.Range("E" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' phi ph. vu
                    myExcelWorksheet.Range("F" + index.ToString()).Formula = row("TOTALSERVICE").ToString()
                    border = myExcelWorksheet.Range("F" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' vat
                    myExcelWorksheet.Range("G" + index.ToString()).Formula = row("TOTALVAT").ToString()
                    border = myExcelWorksheet.Range("G" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    ' tong tien
                    myExcelWorksheet.Range("H" + index.ToString()).Formula = row("FINALTOTAL").ToString()
                    border = myExcelWorksheet.Range("H" + index.ToString()).Borders
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    index += 1
                    stt += 1
                Next
            Next

            ''================================
            Dim mvCls_IncomeUpdate As New cls_Income_Update
            Dim dtTaichinh As DataTable
            dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(gTuNgay, gDenNgay)
            Dim doanhthu As Double
            Try
                doanhthu = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DOANHTHU'")
            Catch ex As Exception
                doanhthu = 0
            End Try
            ''===============================
            ' footer
            ' doanh thu
            myExcelWorksheet.Range("B" + index.ToString()).Formula = "DOANH THU"
            myExcelWorksheet.Range("B" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("B" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("B" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).Merge()
            myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            'myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).Formula = dataGroup.Compute("SUM(FINALTOTAL) + SUM(TOTALDISCOUNT)", "").ToString()
            myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).Formula = doanhthu.ToString()
            myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("C" + index.ToString(), "D" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("B" + index.ToString(), "D" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            myExcelWorksheet.Range("E" + index.ToString()).Formula = ""
            myExcelWorksheet.Range("E" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("E" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("E" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            myExcelWorksheet.Range("F" + index.ToString()).Formula = ""
            myExcelWorksheet.Range("F" + index.ToString()).Font.Bold = True
            border = myExcelWorksheet.Range("F" + index.ToString()).Borders
            myExcelWorksheet.Range("F" + index.ToString()).Font.Size = 14
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            myExcelWorksheet.Range("G" + index.ToString()).Formula = ""
            myExcelWorksheet.Range("G" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("G" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("G" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            myExcelWorksheet.Range("H" + index.ToString()).Formula = ""
            myExcelWorksheet.Range("H" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("H" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("H" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            index += 1

            myExcelWorksheet.Range("B" + index.ToString()).Formula = "TỔNG CỘNG"
            myExcelWorksheet.Range("B" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("B" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("B" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' sl
            myExcelWorksheet.Range("C" + index.ToString()).Formula = dataGroup.Compute("SUM(QUANTITY)", "").ToString()
            myExcelWorksheet.Range("C" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("C" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("C" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' gia
            myExcelWorksheet.Range("D" + index.ToString()).Formula = dataGroup.Compute("SUM(PRICE)", "").ToString()
            myExcelWorksheet.Range("D" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("D" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("D" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' giam gia
            myExcelWorksheet.Range("E" + index.ToString()).Formula = dataGroup.Compute("SUM(TOTALDISCOUNT)", "").ToString()
            myExcelWorksheet.Range("E" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("E" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("E" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' phi ph. vu
            myExcelWorksheet.Range("F" + index.ToString()).Formula = dataGroup.Compute("SUM(TOTALSERVICE)", "").ToString()
            myExcelWorksheet.Range("F" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("F" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("F" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' vat
            myExcelWorksheet.Range("G" + index.ToString()).Formula = dataGroup.Compute("SUM(TOTALVAT)", "").ToString()
            myExcelWorksheet.Range("G" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("G" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("G" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            ' tong tien
            myExcelWorksheet.Range("H" + index.ToString()).Formula = dataGroup.Compute("SUM(FINALTOTAL)", "").ToString()
            myExcelWorksheet.Range("H" + index.ToString()).Font.Bold = True
            myExcelWorksheet.Range("H" + index.ToString()).Font.Size = 14
            border = myExcelWorksheet.Range("H" + index.ToString()).Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Catch
        End Try
    End Sub
#End Region
End Class