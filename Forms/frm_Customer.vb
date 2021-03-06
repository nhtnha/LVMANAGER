Public Class frm_Customer
#Region "Khai Báo Biến"
    Dim mvCls_Customer As New cls_Customer
    Dim mvCls_CustomerUpdate As New cls_Customer_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtAddress.Text = ""
        Me.txtTel.Text = ""
        Me.txtEmail.Text = ""
        Me.lblError.Visible = False
        Me.cmdSearch.Visible = True
        Me.cmdRemove.Visible = False
        mod_LoadLanguageForm.SubG_CustomerForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 13)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        'Form.ActiveForm.ActiveControl = Me.txtID
        Me.txtID.BackColor = Color.LightSkyBlue
        Me.txtName.BackColor = Color.White
        Me.txtAddress.BackColor = Color.White
        Me.txtTel.BackColor = Color.White
        Me.txtEmail.BackColor = Color.White
        gvTxt_Focus = Me.txtID
        If gvByte_Language = 1 Then
            LabelControl3.Text = "Ghi chú"
            LabelControl4.Text = "S.L Giảm"
            LabelControl1.Text = "Mã giảm giá"
            LabelControl2.Text = "%Giảm giá"
            LabelControl5.Text = "Loại thẻ"
            cmdDelete.Text = "Xóa"
        Else
            LabelControl3.Text = "Description"
            LabelControl4.Text = "Qty Discount"
            LabelControl1.Text = "Discount Code"
            LabelControl2.Text = "%Discount"
            LabelControl5.Text = "Kind card"
            cmdDelete.Text = "Delete"
        End If
    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_CustomerUpdate.FuncG_GetAllData(1)
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
            Me.txtID.Text = Me.GridView1.GetFocusedDataRow("ID")
            Me.txtName.Text = Me.GridView1.GetFocusedDataRow("NAME")
            Me.txtAddress.Text = Me.GridView1.GetFocusedDataRow("ADDRESS")
            Me.txtTel.Text = Me.GridView1.GetFocusedDataRow("TEL")
            Me.txtEmail.Text = Me.GridView1.GetFocusedDataRow("EMAIL")
            Me.txtPhanTramGiam.Text = Me.GridView1.GetFocusedDataRow("PhanTram")
            Me.txtMathegiam.Text = Me.GridView1.GetFocusedDataRow("Mathegiamgia")
            Me.txtNote.Text = Me.GridView1.GetFocusedDataRow("Note")

            Me.txtTongSoLuongGiam.Text = Me.GridView1.GetFocusedDataRow("Soluonggiam")
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
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Enter, txtName.Enter, txtAddress.Enter, txtTel.Enter, txtEmail.Enter, txtNote.Enter, txtTongSoLuongGiam.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtID" Then
                Me.txtID.BackColor = Color.LightSkyBlue
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
                Me.txtMathegiam.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtID
            ElseIf mvCtr_ActiveControl.Name = "txtName" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.LightSkyBlue
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                Me.txtMathegiam.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtName
            ElseIf mvCtr_ActiveControl.Name = "txtAddress" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.LightSkyBlue
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                Me.txtMathegiam.BackColor = Color.White
                gvTxt_Focus = Me.txtAddress
                Me.txtTongSoLuongGiam.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
            ElseIf mvCtr_ActiveControl.Name = "txtTel" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.LightSkyBlue
                Me.txtPhanTramGiam.BackColor = Color.White
                Me.txtMathegiam.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtTel
            ElseIf mvCtr_ActiveControl.Name = "txtMathegiam" Then
                Me.txtMathegiam.BackColor = Color.LightSkyBlue
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtMathegiam
                Me.txtTongSoLuongGiam.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
            ElseIf mvCtr_ActiveControl.Name = "txtPhanTramGiam" Then
                Me.txtPhanTramGiam.BackColor = Color.LightSkyBlue
                Me.txtMathegiam.BackColor = Color.White
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtNote.BackColor = Color.White
                gvTxt_Focus = Me.txtPhanTramGiam
            ElseIf mvCtr_ActiveControl.Name = "txtNote" Then
                Me.txtNote.BackColor = Color.LightSkyBlue
                Me.txtMathegiam.BackColor = Color.White
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtNote
            ElseIf mvCtr_ActiveControl.Name = "txtTongSoLuongGiam" Then
                Me.txtNote.BackColor = Color.White
                Me.txtMathegiam.BackColor = Color.White
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTongSoLuongGiam.BackColor = Color.LightSkyBlue
                Me.txtTel.BackColor = Color.White
                Me.txtPhanTramGiam.BackColor = Color.White
                gvTxt_Focus = Me.txtNote
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
                mvCls_Customer.ID = Me.txtID.Text.Trim
                mvCls_Customer.Name = Me.txtName.Text.Trim
                mvCls_Customer.Address = Me.txtAddress.Text.Trim
                mvCls_Customer.Tel = Me.txtTel.Text.Trim
                mvCls_Customer.Type = 1
                mvCls_Customer.Email = ""
                If Me.txtPhanTramGiam.Text.Trim = "" Then
                    mvCls_Customer.Phantram = 0
                Else
                    mvCls_Customer.Phantram = Me.txtPhanTramGiam.Text.Trim
                End If

                mvCls_Customer.Mathegiamgia = Me.txtMathegiam.Text.Trim
                mvCls_Customer.Note = Me.txtNote.Text
                mvCls_Customer.Loaithe = rgpPrint.SelectedIndex
                mvCls_Customer.Soluonggiam = Me.txtTongSoLuongGiam.Text

                mvCls_CustomerUpdate.FuncG_InsertUpdate(mvCls_Customer)
                SubM_InitializeForm()
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
            mvCls_Customer.ID = Me.txtID.Text.Trim
            mvCls_Customer.Name = Me.txtName.Text.Trim
            mvCls_Customer.Address = Me.txtAddress.Text.Trim
            mvCls_Customer.Tel = Me.txtTel.Text.Trim
            mvCls_Customer.Email = Me.txtEmail.Text.Trim
            mvCls_Customer.Type = 1
            mvObj_DataTable = mvCls_CustomerUpdate.FuncG_GetAllData(mvCls_Customer)
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            Me.GridView1.Columns("ADDRESS").Visible = False
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
            Dim mvcls_Customer As New cls_Customer
            mvcls_Customer.ID = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("ID")
            If mvCls_CustomerUpdate.FuncG_GetCustomerSalesByID(mvcls_Customer.ID) = True Then
                Try
                    mvCls_CustomerUpdate.FuncG_Delete_Customer(mvcls_Customer)
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
End Class