Public Class frm_Unit
#Region "Khai Báo Biến"
    Dim mvCls_Unit As New cls_Unit
    Dim mvCls_UnitUpdate As New cls_Unit_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
    Dim _isAdd As Int16
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtID.Enabled = False
        Me._isAdd = 0
        Me.lblError.Visible = False
        Me.cmdSearch.Visible = True
        Me.cmdRemove.Visible = False
        mod_LoadLanguageForm.SubG_CustomerForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 13)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        'Form.ActiveForm.ActiveControl = Me.txtID
        Me.txtID.BackColor = Color.LightSkyBlue
        Me.txtName.BackColor = Color.White
        
    End Sub
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_UnitUpdate.FuncG_GetAllData()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            'Me.GridView1.Columns("ADDRESS").Visible = False
            'Me.GridView1.Columns("EMAIL").Visible = False
            'Me.GridView1.Columns("TYPE").Visible = False
            'Me.GridView1.Columns("Mathegiamgia").Visible = False
            'Me.GridView1.Columns("Phantram").Visible = False
            'Me.GridView1.Columns("Note").Visible = False
            'Me.GridView1.Columns("LoaiThe").Visible = False
            'Me.GridView1.Columns("Soluonggiam").Visible = False
            'Me.GridView1.Columns("ngaythangnam").Visible = False
            Me.GridView1.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Form Events"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn dòng trên gird"
    Private Sub SubM_ClickOnGird()
        Try
            Me.txtID.Text = Me.GridView1.GetFocusedDataRow("UnitID")
            Me.txtName.Text = Me.GridView1.GetFocusedDataRow("UnitName")
            _isAdd = 1
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
#Region "Change textbox focus"
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Enter, txtName.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtID" Then
                Me.txtID.BackColor = Color.LightSkyBlue
                Me.txtName.BackColor = Color.White
            
                gvTxt_Focus = Me.txtID
            ElseIf mvCtr_ActiveControl.Name = "txtName" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.LightSkyBlue
            
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(75) 'FunG_Alert("Thông báo lỗi", "Chưa chọn khách hàng cần cập nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Unit.UnitID = Me.txtID.Text.Trim
                mvCls_Unit.UnitName = Me.txtName.Text.Trim

                If Me._isAdd = 0 Then
                    If mvCls_UnitUpdate.FuncG_GetCustomerSalesByID(mvCls_Unit.UnitID) = True Then
                        ' Nếu mã nguyen lieu ton tai
                        FunG_Alert("Thông Báo", "Mã nguyên liệu này đã tồn tại vui lòng chọn mã khác", frm_Alert.WTYPE.ERROR)
                    Else
                        mvCls_UnitUpdate.FuncG_Insert(mvCls_Unit.UnitID, mvCls_Unit.UnitName)
                        SubM_InitializeForm()
                    End If
                   
                Else
                    mvCls_UnitUpdate.FuncG_Update(mvCls_Unit.UnitID, mvCls_Unit.UnitName)
                    SubM_InitializeForm()
                End If

                
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Search"
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim mvObj_DataTable As New DataTable
        Try
            Me.cmdSearch.Visible = False
            Me.cmdRemove.Visible = True
           
            mvObj_DataTable = mvCls_UnitUpdate.FuncG_GetAllData(txtID.Text, txtName.Text)
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            If mvObj_DataTable.Rows.Count = 0 Then
                Me.lblError.Visible = True
            Else
                Me.lblError.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Remove"
    Private Sub cmdRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Me.cmdSearch.Visible = True
            Me.cmdRemove.Visible = False
            Me.SubM_InitializeForm()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.GridView1.FocusedRowHandle > -1 Then
            Dim mvcls_Unit As New cls_Unit
            mvcls_Unit.UnitID = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("UnitID")
            If mvCls_UnitUpdate.FuncG_GetCustomerSalesByID(mvcls_Unit.UnitID) = True Then
                Try
                    mvCls_UnitUpdate.FuncG_Delete(mvcls_Unit.UnitID)
                Catch ex As Exception

                End Try
            Else
                If gvByte_Language = 1 Then
                    FunG_Alert("Thông báo", "Thao tác thất bại.", frm_Alert.WTYPE.CHECK)
                Else
                    FunG_Alert("Message", "The action failed.", frm_Alert.WTYPE.CHECK)
                End If

            End If
            SubM_InitializeForm()
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Me._isAdd = 0
            Me.txtID.Enabled = True
            Me.txtID.Text = ""
            Me.txtName.Text = ""
            Me.txtName.Text = ""
         
            gvTxt_Focus = Me.txtID
            'If Me.txtID.Text = "" Then
            '    SubG_Alert(75) 'FunG_Alert("Thông báo lỗi", "Chưa chọn khách hàng cần cập nhật!", frm_Alert.WTYPE.ERROR)
            'Else
            '    mvCls_Unit.UnitID = Me.txtID.Text.Trim
            '    mvCls_Unit.UnitName = Me.txtName.Text.Trim

            '    mvCls_UnitUpdate.FuncG_Insert(mvCls_Unit.UnitID, mvCls_Unit.UnitName)
            '    SubM_InitializeForm()
            'End If
        Catch ex As Exception

        End Try
    End Sub
End Class