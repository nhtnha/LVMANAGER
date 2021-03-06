Public Class frm_Area
#Region "Khai Báo Biến"
    Dim mvCls_Area As New cls_Area
    Dim mvCls_AreaUpdate As New cls_Area_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        rgpType.SelectedIndex = 0
        Me.cmdOn.Enabled = False
        Me.cmdOff.Enabled = False
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        mod_LoadLanguageForm.SubG_AreaForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 6)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        gvTxt_Focus = Me.txtName

        Me.GridView1.Columns("LOC_ID").Visible = False
        Me.GridView1.Columns("TIME_BEGIN").Visible = False
        Me.GridView1.Columns("TIME_END").Visible = False
        Me.GridView1.Columns("TYPE_SERVICE").Visible = False

        Me.GridView1.Columns("ID").Width = 50
        Me.GridView1.Columns("NAME").Width = 200
        If gvByte_Language = 1 Then
            lblID.Text = "MÃ".ToUpper
            lblName.Text = "Tên".ToUpper
            LabelControl1.Text = "Mức giá".ToUpper
            LabelControl2.Text = "Phụ thu".ToUpper
            LabelControl3.Text = "Bắt đầu".ToUpper
            LabelControl4.Text = "Kết thúc".ToUpper
            rgpType.Properties.Items.Item(0).Description = "Tính giờ".ToUpper
            rgpType.Properties.Items.Item(1).Description = "Không tính".ToUpper
            rgpPhuThu.Properties.Items.Item(0).Description = "Tính phụ thu".ToUpper
            rgpPhuThu.Properties.Items.Item(1).Description = "Không tính".ToUpper
            rdoHoaDon.Text = "% Hóa đơn".ToUpper
        Else
            lblID.Text = "ID".ToUpper
            lblName.Text = "NAME".ToUpper
            LabelControl1.Text = "Price level".ToUpper
            LabelControl2.Text = "surcharge".ToUpper
            LabelControl3.Text = "Begin".ToUpper
            LabelControl4.Text = "The end".ToUpper
            rgpType.Properties.Items.Item(0).Description = "timers".ToUpper
            rgpType.Properties.Items.Item(1).Description = "Not timers".ToUpper
            rgpPhuThu.Properties.Items.Item(0).Description = "surcharge".ToUpper
            rgpPhuThu.Properties.Items.Item(1).Description = "not surcharge".ToUpper
            rdoHoaDon.Text = "% Invoice".ToUpper
        End If

    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_AreaUpdate.FuncG_GetAllData()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            Me.GridView1.Columns("STATUS").Visible = False
            Me.GridView1.Columns("TYPE").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub SubM_InitializePriceLevel()
    '    Dim mvObj_List As New List(Of Integer)
    '    Try
    '        mvObj_List.Add(1)
    '        mvObj_List.Add(2)
    '        mvObj_List.Add(3)
    '        mvObj_List.Add(4)
    '        mvObj_List.Add(5)
    '        lkpPriceLevel.Properties.DataSource = mvObj_List
    '        lkpPriceLevel.Properties.PopulateColumns()
    '    Catch ex As Exception

    '    End Try
    'End Sub

#End Region
#Region "Form Events"
    Private Sub frm_Area_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
    End Sub
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn dòng trên gird"
    Private Sub SubM_ClickOnGird()
        Try
            Me.txtID.Text = Me.GridView1.GetFocusedDataRow("ID")
            Me.txtName.Text = Me.GridView1.GetFocusedDataRow("NAME")
            Try
                Me.txtBatDau.Text = Me.GridView1.GetFocusedDataRow("TIME_BEGIN")
                Me.txtKetThuc.Text = Me.GridView1.GetFocusedDataRow("TIME_END")
            Catch ex As Exception
                Me.txtBatDau.Text = "0"
                Me.txtKetThuc.Text = "0"
            End Try
            

            If Me.GridView1.GetFocusedDataRow("TYPE_SERVICE") = 1 Then
                rdoHoaDon.Checked = True
                rdoKaraoke.Checked = False
            Else
                rdoHoaDon.Checked = False
                rdoKaraoke.Checked = True
            End If

            Me.txtHoaDon.Text = Me.GridView1.GetFocusedDataRow("BILL_SERVICE")
            Me.txtKaraoke.Text = Me.GridView1.GetFocusedDataRow("KARAOKE_SERVICE")

            Me.rgpPhuThu.EditValue = Me.GridView1.GetFocusedDataRow("STATUS_SERVICE")

            If Me.GridView1.GetFocusedDataRow("STATUS") = 1 Then
                Me.cmdOn.Enabled = False
                Me.cmdOff.Enabled = True
            Else
                Me.cmdOn.Enabled = True
                Me.cmdOff.Enabled = False
            End If
            Me.rgpType.EditValue = Me.GridView1.GetFocusedDataRow("TYPE")
            Me.cboPriceLevel.SelectedIndex = Me.GridView1.GetFocusedDataRow("PRICE_LEVEL") - 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SubM_ClickOnGird()
    End Sub
    Private Sub GridView1_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        SubM_ClickOnGird()
    End Sub
#End Region
#Region "Nút On"
    Private Sub cmdOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOn.Click
        Me.cmdOn.Enabled = False
        Me.cmdOff.Enabled = True
        SubM_CapNhat()
    End Sub
#End Region
#Region "Nút Off"
    Private Sub cmdOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOff.Click
        Me.cmdOn.Enabled = True
        Me.cmdOff.Enabled = False
        SubM_CapNhat()
    End Sub
#End Region
#Region "Nút Up"
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Down"
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        SubM_CapNhat()
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region
#Region "Cập nhật"
    Private Sub SubM_CapNhat()
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(36)
            Else
                mvCls_Area.ID = Me.txtID.Text
                mvCls_Area.Name = Me.txtName.Text

                'Add
                mvCls_Area.Time_Begin = Me.txtBatDau.Text
                mvCls_Area.Time_End = Me.txtKetThuc.Text
                mvCls_Area.Bill_Service = Me.txtHoaDon.Text
                mvCls_Area.Karaoke_Service = Me.txtKaraoke.Text


                If rdoHoaDon .Checked  Then
                    mvCls_Area.Type_Service = 1
                Else
                    mvCls_Area.Type_Service = 2
                End If

                mvCls_Area.Status_Service = rgpPhuThu.EditValue

                If Me.cmdOn.Enabled = False Then
                    mvCls_Area.Status = 1
                Else
                    mvCls_Area.Status = 0
                End If
                If rgpType.EditValue.ToString = "" Then
                    If gvByte_Language = 1 Then
                        FunG_Alert("Thông báo", "Vui lòng chọn loại khu vực !", frm_Alert.WTYPE.CHECK)
                    Else
                        FunG_Alert("Message", "Please select the region!", frm_Alert.WTYPE.CHECK)
                    End If

                    Exit Sub
                Else
                    mvCls_Area.Type = rgpType.EditValue '1-Cafe; 2-Karaoke
                End If
                mvCls_Area.PriceLevel = cboPriceLevel.Text
                mvCls_AreaUpdate.FuncG_UpdateArea(mvCls_Area)
                SubM_InitializeForm()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class