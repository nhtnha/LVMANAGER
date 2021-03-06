Imports ControlsAlias = DevExpress.XtraEditors.Controls
Imports System.Threading

Public Class urc_Table
#Region "Khai Báo Biến"
    Dim mvCls_TableUpdate As New cls_Table_Update
    Dim mvCls_AreaUpdate As New cls_Area_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
    Dim mvByte_TableClickCount As Byte = 0
    Dim mvCls_SalesUpdate As New cls_Sales_Update
    Dim mvCls_SalesDetailUpdate As New cls_SalesDetail_Update
    Public gvStr_CurrentArea As String
    Dim mvStr_ID As String
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()

        'Dim trd As New Thread(AddressOf SubM_LoadMenu)
        SubM_LoadMenu()
        'frm_TableMMM.cmdSplit.Enabled = True
        'frm_TableMMM.cmdTransfer.Enabled = True
        'frm_TableMMM.cmdEnter.Enabled = True
        'If gvByte_In_Tam_Tinh_Op = 1 Then
        '    frm_TableMMM.cmdPrintCash.Enabled = True
        'End If

        'frm_TableMMM.cmdDelete.Enabled = String.Equals(gvStr_Permit(5), "1"c)
        'frm_TableMMM.cmdPrintCash.Enabled = True
        'frm_TableMMM.cmdOpen.Enabled = False
        SubM_CountTable(gvStr_CurrentArea)
        Me.PanelControl1.Left = (Parent.ClientRectangle.Width / 2) - (Me.PanelControl1.Width / 2)
        Me.PanelControl2.Left = (Parent.ClientRectangle.Width / 2) - (Me.PanelControl2.Width / 2)
    End Sub
#End Region
#Region "Load Menu Khu vực"
    Public Sub SubM_LoadMenu()
        Dim mvObj_AreaData As New DataTable
        Dim mvObj_TableData As New DataTable
        Try
            'Load menu khu vực

            mvObj_AreaData = mvCls_AreaUpdate.FuncG_GetAllData
            For i As Integer = 0 To 9
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl2, "cmdKhuVuc" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_AreaData.Rows.Count > i Then
                    If mvObj_AreaData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Visible = True
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        If gvStr_CurrentArea = "" And i = 0 Then
                            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                        Else
                            If gvStr_CurrentArea = mvObj_AreaData.Rows(i)("ID") Then
                                mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                                mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                            Else
                                mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                                mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                            End If
                        End If
                    Else
                        mvCmd_SimpleButton.Visible = False
                        mvCmd_SimpleButton.Text = ""
                    End If
                Else
                    mvCmd_SimpleButton.Visible = False
                    mvCmd_SimpleButton.Text = ""
                End If
            Next

            If gvStr_CurrentArea = "" Then
                'Load bàn tại khu vực đầu tiên
                mvObj_TableData = mvCls_TableUpdate.FuncG_GetData(mvObj_AreaData.Rows(0)("ID"))
                Me.SubM_LoadTable(mvObj_TableData, mvObj_AreaData.Rows(0)("ID"))
                'gvByte_CurrentPriceLevel = mvCls_AreaUpdate.FuncG_GetPriceLevelByID(mvObj_AreaData.Rows(0)("ID"))
            Else
                mvObj_TableData = mvCls_TableUpdate.FuncG_GetData(gvStr_CurrentArea)
                Me.SubM_LoadTable(mvObj_TableData, gvStr_CurrentArea)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Shared Function FunM_GetControlByName(ByVal pobjParent As Control, ByVal pstrCtlName As String) As Control
        Dim objCtl As Control
        For Each objCtl In pobjParent.Controls
            If objCtl.Name = pstrCtlName Then
                Return (objCtl)
            End If
        Next
        ' if control is not found
        Return Nothing
    End Function
#End Region
#Region "Count table"
    Private Sub SubM_CountTable(ByVal iStr_AreaID As String)
        
        Try
            Dim mvInt_FreeTable As Integer
            Dim mvInt_ServedTable As Integer
            Dim mvInt_TotalFree As Integer
            Dim mvInt_TotalServed As Integer
            mvInt_FreeTable = mvCls_TableUpdate.FuncG_CountTable(iStr_AreaID, 1)
            mvInt_ServedTable = mvCls_TableUpdate.FuncG_CountTable(iStr_AreaID, 2) + mvCls_TableUpdate.FuncG_CountTable(iStr_AreaID, 3)
            mvInt_TotalFree = mvCls_TableUpdate.FuncG_CountTable(1)
            mvInt_TotalServed = mvCls_TableUpdate.FuncG_CountTable(2) + mvCls_TableUpdate.FuncG_CountTable(3)
            If gvByte_Language = 1 Then
                Me.lblFreeTable.Text = String.Format("Bàn trống : {0} bàn", mvInt_FreeTable)
                Me.lblServedTable.Text = String.Format("Bàn đang phục vụ : {0} bàn", mvInt_ServedTable)
                Me.lblTotalFree.Text = String.Format("Tổng bàn trống : {0} bàn", mvInt_TotalFree)
                Me.lblTotalServed.Text = String.Format("Tổng bàn đang phục vụ : {0} bàn", mvInt_TotalServed)
            Else
                Me.lblFreeTable.Text = String.Format("Empty table : {0} table", mvInt_FreeTable)
                Me.lblServedTable.Text = String.Format("Table serving : {0} table", mvInt_ServedTable)
                Me.lblTotalFree.Text = String.Format("Total empty table : {0} table", mvInt_TotalFree)
                Me.lblTotalServed.Text = String.Format("Total table serving : {0} table", mvInt_TotalServed)
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load"
    Private Sub urc_Table_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Hàm load bàn theo khu vực"
    Private Sub SubM_LoadTable(ByVal iObj_DataTable As DataTable, ByVal iStr_ID As String)
        Try
            Dim TBSALES As New DataTable
            Dim DtSumtotal As DataTable
            Dim tongtien As Double
            TBSALES = mvCls_TableUpdate.FuncG_GetDataTBSales(Convert.ToInt16(iStr_ID) * 50 - 49, Convert.ToInt16(iStr_ID) * 50)
            'Tính số lượng bàn
            If iObj_DataTable.Rows.Count <> 0 Then
                Me.SubM_CountTable(iObj_DataTable.Rows(0)("AREA_ID"))
            End If
            For i As Integer = 0 To 49
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl1, "cmdBan" & CStr(i)), DevExpress.XtraEditors.SimpleButton)

                Dim A As String = iObj_DataTable.Rows(i)("ID")
                TBSALES.Select("TABLE_ID= " + A)
                Dim B As String = ""
                Dim C As Double = 0
                Dim result() As DataRow = TBSALES.Select("TABLE_ID= " + A)
                For Each ROW As DataRow In result
                    B = Convert.ToString(ROW(0))
                    C = Convert.ToDouble(ROW(1))
                Next

                If iObj_DataTable.Rows.Count > i Then
                    If A <> B Then
                        If iObj_DataTable.Rows(i)("STATUS") = 0 Then
                            mvCmd_SimpleButton.Visible = True
                            mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                            mvCmd_SimpleButton.Appearance.BackColor = Color.WhiteSmoke
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.WhiteSmoke
                        ElseIf iObj_DataTable.Rows(i)("STATUS") = 1 Then
                            mvCmd_SimpleButton.Visible = True
                            mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                            'Bàn trống màu xanh
                            mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(135, 237, 84)
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(142, 210, 77)
                        ElseIf iObj_DataTable.Rows(i)("STATUS") = 2 Then
                            mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                            mvCmd_SimpleButton.Visible = True

                            If C > 0 Then
                                mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (C / 1000).ToString() + " K"
                            Else
                                mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                            End If
                            'mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")


                            'Bàn đang phục vụ màu vàng
                            mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(&HE4, &HE4, &H95)
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(&HE1, &HC3, &H38)
                        ElseIf iObj_DataTable.Rows(i)("STATUS") = 3 Then
                            mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                            mvCmd_SimpleButton.Visible = True

                            If C > 0 Then
                                mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (C / 1000).ToString() + " K"
                            Else
                                mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                            End If
                            'Bàn tạm tính xong, màu đỏ (TH có bàn đỏ)
                            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.Red
                        End If

                    ElseIf A = B And iObj_DataTable.Rows(i)("STATUS") = 2 Then
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Visible = True

                        If C > 0 Then
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (C / 1000).ToString() + " K"
                        Else
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        End If
                        'mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")


                        'Bàn đang phục vụ màu vàng
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(&HE4, &HE4, &H95)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(&HE1, &HC3, &H38)
                    ElseIf A = B And iObj_DataTable.Rows(i)("STATUS") = 3 Then
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Visible = True

                        If C > 0 Then
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (C / 1000).ToString() + " K"
                        Else
                            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        End If
                        'Bàn tạm tính xong, màu đỏ (TH có bàn đỏ)
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Red
                    ElseIf A <> B And iObj_DataTable.Rows(i)("STATUS") = 4 Then
                        mvCmd_SimpleButton.Visible = True
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        'Bàn trống màu xanh
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(&HA2, &H5D, &HF8)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(&HA2, &H5D, &HF8)
                    ElseIf A = B And iObj_DataTable.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Visible = True
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        'Bàn trống màu xanh
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(135, 237, 84)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(142, 210, 77)
                    End If
                    mvCmd_SimpleButton.ToolTip = iObj_DataTable.Rows(i)("NAME")
                End If
                ''=========================================================''
                ''Created By Mr.Thi
                ''=========================================================''
                'If iObj_DataTable.Rows.Count > i Then
                '    If iObj_DataTable.Rows(i)("STATUS") = 1 Then
                '        mvCmd_SimpleButton.Visible = True
                '        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                '        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                '        'Bàn trống màu xanh
                '        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(135, 237, 84)
                '        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(142, 210, 77)
                '    ElseIf iObj_DataTable.Rows(i)("STATUS") = 2 Then
                '        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                '        If gvBol_Xemgiaban Then
                '            tongtien = mvCls_TableUpdate.FuncG_GetTongtien(mvCmd_SimpleButton.Tag)
                '        End If
                '        mvCmd_SimpleButton.Visible = True

                '        If tongtien > 0 Then
                '            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (tongtien / 1000).ToString() + " K"
                '        Else
                '            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                '        End If
                '        'mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")


                '        'Bàn đang phục vụ màu vàng
                '        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(&HE4, &HE4, &H95)
                '        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(&HE1, &HC3, &H38)
                '    ElseIf iObj_DataTable.Rows(i)("STATUS") = 3 Then
                '        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                '        If gvBol_Xemgiaban Then
                '            tongtien = mvCls_TableUpdate.FuncG_GetTongtien(mvCmd_SimpleButton.Tag)
                '        End If
                '        mvCmd_SimpleButton.Visible = True

                '        'mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                '        If tongtien > 0 Then
                '            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME") + vbCrLf + (tongtien / 1000).ToString() + " K"
                '        Else
                '            mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                '        End If
                '        'Bàn tạm tính xong, màu đỏ (TH có bàn đỏ)
                '        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                '        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Red
                '    ElseIf iObj_DataTable.Rows(i)("STATUS") = 4 Then
                '        mvCmd_SimpleButton.Visible = True
                '        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                '        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                '        'Bàn trống màu xanh
                '        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(&HA2, &H5D, &HF8)
                '        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(&HA2, &H5D, &HF8)
                '    Else
                '        mvCmd_SimpleButton.Visible = False
                '        mvCmd_SimpleButton.Tag = ""
                '        mvCmd_SimpleButton.Text = ""
                '    End If
                'Else
                '    mvCmd_SimpleButton.Visible = False
                '    mvCmd_SimpleButton.Tag = ""
                '    mvCmd_SimpleButton.Text = ""
                'End If
                ''=========================================================''
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn khu vực"
    Private Sub cmdKhuVuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKhuVuc0.Click, _
    cmdKhuVuc1.Click, cmdKhuVuc2.Click, cmdKhuVuc3.Click, cmdKhuVuc4.Click, cmdKhuVuc5.Click, cmdKhuVuc6.Click, _
    cmdKhuVuc7.Click, cmdKhuVuc8.Click, cmdKhuVuc9.Click
        Dim mvObj_DataTable As New DataTable
        Try
            'frm_TableMM.Timer1.Stop()
            For i As Integer = 0 To 9
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl2, "cmdKhuVuc" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
            Next
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
            'Lấy ID từ thuộc tính Tag
            mvObj_DataTable = mvCls_TableUpdate.FuncG_GetData(mvCmd_SimpleButton.Tag)
            'mvObj_DataTable = mvCls_TableUpdate.FuncG_GetData(mvCmd_SimpleButton.Tag)
            gvStr_CurrentArea = mvCmd_SimpleButton.Tag
            'gvByte_CurrentPriceLevel = mvCls_AreaUpdate.FuncG_GetPriceLevelByID(mvCmd_SimpleButton.Tag.ToString())
            Me.SubM_LoadTable(mvObj_DataTable, mvCmd_SimpleButton.Tag)
            ' frm_TableMM.Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn bàn"
    Private Sub cmdBan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBan0.Click, _
    cmdBan1.Click, cmdBan2.Click, cmdBan3.Click, cmdBan4.Click, cmdBan5.Click, cmdBan6.Click, cmdBan7.Click, _
    cmdBan8.Click, cmdBan9.Click, cmdBan10.Click, cmdBan11.Click, cmdBan12.Click, cmdBan13.Click, cmdBan14.Click, _
    cmdBan15.Click, cmdBan16.Click, cmdBan17.Click, cmdBan18.Click, cmdBan19.Click, cmdBan20.Click, cmdBan21.Click, _
    cmdBan22.Click, cmdBan23.Click, cmdBan24.Click, cmdBan25.Click, cmdBan26.Click, cmdBan27.Click, cmdBan28.Click, _
    cmdBan29.Click, cmdBan30.Click, cmdBan31.Click, cmdBan32.Click, cmdBan33.Click, cmdBan34.Click, cmdBan35.Click, _
    cmdBan36.Click, cmdBan37.Click, cmdBan38.Click, cmdBan39.Click, cmdBan40.Click, cmdBan41.Click, cmdBan42.Click, _
    cmdBan43.Click, cmdBan44.Click, cmdBan45.Click, cmdBan46.Click, cmdBan47.Click, cmdBan48.Click, cmdBan49.Click
        If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
            mvStr_ID = DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Tag
            frm_TableM.PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
#End Region
#Region "Disable-Enable"
    Private Sub SubM_EnableFunction(ByVal iDate_CreateDate As Date, ByVal iStr_ID As String)
        'frm_TableM.cmdDelete.Enabled = String.Equals(gvStr_Permit(5), "1"c)
        'If gvByte_In_Tam_Tinh_Op = 1 Then
        '    frm_TableM.cmdPrintCash.Enabled = True
        'End If

        'frm_TableM.txtCreatDate.Text = String.Format("{0:dd/MM/yyyy HH:mm:ss}", iDate_CreateDate)
        'frm_TableM.txtInvoiceID.Text = iStr_ID

        'frm_TableM.cmdSplit.Enabled = True
        'frm_TableM.cmdTransfer.Enabled = True
        'frm_TableM.cmdEnter.Enabled = True
    End Sub

    Private Sub SubM_DisableFunction()
        'frm_TableM.cmdDelete.Enabled = False
        'frm_TableM.cmdPrintCash.Enabled = False
        'frm_TableM.txtCreatDate.Text = ""
        'frm_TableM.txtInvoiceID.Text = ""

        'frm_TableM.cmdSplit.Enabled = False
        'frm_TableM.cmdTransfer.Enabled = False
        'frm_TableM.cmdEnter.Enabled = False
    End Sub
#End Region

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'frm_TableMMM.Timer1.Start()
        'If CheckBox1.Checked Then
        '    gvBol_Xemgiaban = True
        'Else
        '    gvBol_Xemgiaban = False
        'End If
    End Sub

    Private Sub cmdBan0_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdBan0.MouseDown, _
    cmdBan1.MouseDown, cmdBan2.MouseDown, cmdBan3.MouseDown, cmdBan4.MouseDown, cmdBan5.MouseDown, cmdBan6.MouseDown, cmdBan7.MouseDown, _
    cmdBan8.MouseDown, cmdBan9.MouseDown, cmdBan10.MouseDown, cmdBan11.MouseDown, cmdBan12.MouseDown, cmdBan13.MouseDown, cmdBan14.MouseDown, _
    cmdBan15.MouseDown, cmdBan16.MouseDown, cmdBan17.MouseDown, cmdBan18.MouseDown, cmdBan19.MouseDown, cmdBan20.MouseDown, cmdBan21.MouseDown, _
    cmdBan22.MouseDown, cmdBan23.MouseDown, cmdBan24.MouseDown, cmdBan25.MouseDown, cmdBan26.MouseDown, cmdBan27.MouseDown, cmdBan28.MouseDown, _
    cmdBan29.MouseDown, cmdBan30.MouseDown, cmdBan31.MouseDown, cmdBan32.MouseDown, cmdBan33.MouseDown, cmdBan34.MouseDown, cmdBan35.MouseDown, _
    cmdBan36.MouseDown, cmdBan37.MouseDown, cmdBan38.MouseDown, cmdBan39.MouseDown, cmdBan40.MouseDown, cmdBan41.MouseDown, cmdBan42.MouseDown, _
    cmdBan43.MouseDown, cmdBan44.MouseDown, cmdBan45.MouseDown, cmdBan46.MouseDown, cmdBan47.MouseDown, cmdBan48.MouseDown, cmdBan49.MouseDown
        If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
            mvStr_ID = DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Tag
            Dim DT As New DataTable
            DT = mvCls_SalesUpdate.FuncG_GetDataByTableID(mvStr_ID)
            If DT.Rows.Count > 0 Then

                frm_TableM.btnseedetail.Enabled = True
                frm_TableM.bbiEdit.Enabled = False
                frm_TableM.PopupMenu1.ShowPopup(Control.MousePosition)
                frm_TableM.mvStr_ID = mvStr_ID
            Else
                frm_TableM.mvStr_ID = mvStr_ID
                frm_TableM.btnseedetail.Enabled = True
                frm_TableM.bbiEdit.Enabled = True
                frm_TableM.PopupMenu1.ShowPopup(Control.MousePosition)
            End If

        End If
    End Sub
End Class
