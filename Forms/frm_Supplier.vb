Public Class frm_Supplier
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
        'mod_LoadLanguageForm.SubG_EmployeeForm()
        mod_LoadLanguageForm.SubG_Supplier()
        mvUrc_FullKeyboard.SubM_InitializeForm()
        Me.txtID.BackColor = Color.LightSkyBlue
        Me.txtName.BackColor = Color.White
        Me.txtAddress.BackColor = Color.White
        Me.txtTel.BackColor = Color.White
        Me.txtEmail.BackColor = Color.White
        gvTxt_Focus = Me.txtID
    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_CustomerUpdate.FuncG_GetAllData(3)
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
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        SubM_ClickOnGird()
    End Sub
#End Region
#Region "Change textbox focus"
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Enter, txtName.Enter, txtAddress.Enter, txtTel.Enter, txtEmail.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtID" Then
                Me.txtID.BackColor = Color.LightSkyBlue
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtID
            ElseIf mvCtr_ActiveControl.Name = "txtName" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.LightSkyBlue
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtName
            ElseIf mvCtr_ActiveControl.Name = "txtAddress" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.LightSkyBlue
                Me.txtTel.BackColor = Color.White
                Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtAddress
            ElseIf mvCtr_ActiveControl.Name = "txtTel" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.LightSkyBlue
                Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtTel
            ElseIf mvCtr_ActiveControl.Name = "txtEmail" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                Me.txtEmail.BackColor = Color.LightSkyBlue
                gvTxt_Focus = Me.txtEmail
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Up"
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Down"
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(115) 'FunG_Alert("Thông báo lỗi", "Chưa chọn nhà cung cấp cần cập nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Customer.ID = Me.txtID.Text.Trim
                mvCls_Customer.Name = Me.txtName.Text.Trim
                mvCls_Customer.Address = Me.txtAddress.Text.Trim
                mvCls_Customer.Tel = Me.txtTel.Text.Trim
                mvCls_Customer.Email = Me.txtEmail.Text.Trim
                mvCls_Customer.Type = 3
                mvCls_Customer.Phantram = 0

                mvCls_Customer.Mathegiamgia = "MNCCLV_" + Me.txtID.Text.Trim
                mvCls_Customer.Note = ""
                mvCls_Customer.Loaithe = 4
                mvCls_Customer.Soluonggiam = 0
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
            mvCls_Customer.Type = 3
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
            If mvCls_CustomerUpdate.FuncG_GetNCCSalesByID(mvcls_Customer.ID) = True Then
                Try
                    mvCls_CustomerUpdate.FuncG_Delete_Customer(mvcls_Customer)
                Catch ex As Exception

                End Try
            Else
                If gvByte_Language = 1 Then
                    FunG_Alert("Thông báo", "Thao tác thất bại.", frm_Alert.WTYPE.CHECK)
                Else
                    FunG_Alert("Message", "Action failed", frm_Alert.WTYPE.CHECK)
                End If

            End If
            SubM_InitializeForm()
        End If
    End Sub
End Class