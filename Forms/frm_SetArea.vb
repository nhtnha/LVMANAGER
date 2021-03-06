Imports ControlsAlias = DevExpress.XtraEditors.Controls
Public Class frm_SetArea
#Region "Khai Báo Biến"
    Dim mvCls_Table As New cls_Table
    Dim mvCls_TableUpdate As New cls_Table_Update
    Dim mvCls_AreaUpdate As New cls_Area_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadMenu()
        Me.txtTable.Tag = ""
        Me.txtTable.Text = ""
        Me.cmdOn.Enabled = False
        Me.cmdOff.Enabled = False
        Me.PanelControl4.Visible = False
        mod_LoadLanguageForm.SubG_AreaForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 15)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        If gvByte_Language = 1 Then
            Me.cmdKeyboard.Text = "Hiện"
        Else
            Me.cmdKeyboard.Text = "Show"
        End If
        gvTxt_Focus = Me.txtTable
    End Sub
#End Region
#Region "Load Menu Khu vực"
    Private Sub SubM_LoadMenu()
        Dim mvObj_AreaData As New DataTable
        Dim mvObj_TableData As New DataTable
        Try
            'Load menu khu vực
            mvObj_AreaData = mvCls_AreaUpdate.FuncG_GetAllData
            For i As Integer = 0 To 9
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl3, "cmdKhuVuc" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_AreaData.Rows.Count > i Then
                    If mvObj_AreaData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                    If i = 0 And Me.txtArea.Text = "" Then
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                    Else
                        If Me.txtArea.Tag = mvCmd_SimpleButton.Tag Then
                            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                        End If
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If

            Next
            'Load bàn tại khu vực
            If Me.txtArea.Text = "" Then
                mvObj_TableData = mvCls_TableUpdate.FuncG_GetData(mvObj_AreaData.Rows(0)("ID"))
                Me.txtArea.Text = mvObj_AreaData.Rows(0)("NAME")
                Me.txtArea.Tag = mvObj_AreaData.Rows(0)("ID")
            Else
                mvObj_TableData = mvCls_TableUpdate.FuncG_GetData(Me.txtArea.Tag)
            End If
            Me.SubM_LoadTable(mvObj_TableData)
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
#Region "Hàm load bàn theo khu vực"
    Private Sub SubM_LoadTable(ByVal iObj_DataTable As DataTable)
        Try
            For i As Integer = 0 To 49
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl1, "cmdBan" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If iObj_DataTable.Rows.Count > i Then
                    If iObj_DataTable.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 192)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Lime
                        mvCmd_SimpleButton.Enabled = True
                    ElseIf iObj_DataTable.Rows(i)("STATUS") = 0 Then
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                        mvCmd_SimpleButton.Enabled = True
                    Else
                        'TH bàn đang sử dụng ( không cho edit trạng thái )
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Red
                        mvCmd_SimpleButton.Enabled = False
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                    mvCmd_SimpleButton.Enabled = True
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn khu vực"
    Private Sub cmdKhuVuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKhuVuc0.Click, _
    cmdKhuVuc1.Click, cmdKhuVuc2.Click, cmdKhuVuc3.Click, cmdKhuVuc4.Click, cmdKhuVuc5.Click, cmdKhuVuc6.Click, _
    cmdKhuVuc7.Click, cmdKhuVuc8.Click, cmdKhuVuc9.Click
        Dim mvObj_AreaData As New DataTable
        Dim mvObj_DataTable As New DataTable
        Try
            'Load menu khu vực
            mvObj_AreaData = mvCls_AreaUpdate.FuncG_GetAllData
            For i As Integer = 0 To 9
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl3, "cmdKhuVuc" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_AreaData.Rows.Count > i Then
                    If mvObj_AreaData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
            Me.txtArea.Text = mvCmd_SimpleButton.Text
            Me.txtArea.Tag = mvCmd_SimpleButton.Tag
            Me.txtTable.Tag = ""
            Me.txtTable.Text = ""
            Me.cmdOn.Enabled = False
            Me.cmdOff.Enabled = False
            'Lấy ID từ thuộc tính Tag
            mvObj_DataTable = mvCls_TableUpdate.FuncG_GetData(mvCmd_SimpleButton.Tag)
            Me.SubM_LoadTable(mvObj_DataTable)
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
        Dim mvObj_DataTable As New DataTable
        Try
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvObj_DataTable = mvCls_TableUpdate.FuncG_GetDataInfo(mvCmd_SimpleButton.Tag)
            If mvObj_DataTable.Rows.Count <> 0 Then
                Me.txtTable.Tag = mvObj_DataTable.Rows(0)("ID")
                Me.txtTable.Text = mvObj_DataTable.Rows(0)("NAME")
                If mvObj_DataTable.Rows(0)("STATUS") = 1 Then
                    Me.cmdOn.Enabled = False
                    Me.cmdOff.Enabled = True
                Else
                    Me.cmdOn.Enabled = True
                    Me.cmdOff.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút On"
    Private Sub cmdOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOn.Click
        Me.cmdOn.Enabled = False
        Me.cmdOff.Enabled = True
    End Sub
#End Region
#Region "Nút Off"
    Private Sub cmdOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOff.Click
        Me.cmdOn.Enabled = True
        Me.cmdOff.Enabled = False
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeyboard.Click
        Try
            If Me.cmdKeyboard.Text = "Hiện" Or Me.cmdKeyboard.Text = "Show" Then
                Me.PanelControl4.Visible = True
                If gvByte_Language = 1 Then 'Tiếng Việt
                    Me.cmdKeyboard.Text = "Ẩn"
                Else
                    Me.cmdKeyboard.Text = "Hide"
                End If
            Else
                Me.PanelControl4.Visible = False
                If gvByte_Language = 1 Then
                    Me.cmdKeyboard.Text = "Hiện"
                Else
                    Me.cmdKeyboard.Text = "Show"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        Try
            If Me.txtTable.Tag Is Nothing Then
                FunG_Alert("Thông báo lỗi", "Chưa chọn bàn cần cập nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Table.ID = Me.txtTable.Tag
                mvCls_Table.Name = Me.txtTable.Text
                If Me.cmdOn.Enabled Then
                    mvCls_Table.Status = 0
                Else
                    mvCls_Table.Status = 1
                End If
                mvCls_TableUpdate.FuncG_InsertUpdateDelete(mvCls_Table)
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
End Class