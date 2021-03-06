Public Class frm_Employee
#Region "Khai Báo Biến"
    Dim mvCls_Customer As New cls_Customer
    Dim mvCls_CustomerUpdate As New cls_Customer_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
    Public rsl_MSG As frm_Alert.WRESULT
    Dim _isAdd As Int16 = 0
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()

        Me.lblError.Visible = False
        Me.cmdSearch.Visible = True
        Me.cmdRemove.Visible = False
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        ' mod_LoadLanguageForm.SubG_EmployeeForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 14)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        'Form.ActiveForm.ActiveControl = Me.txtID
        Me.txtID.BackColor = Color.LightSkyBlue
        Me.txtName.BackColor = Color.White
        Me.txtAddress.BackColor = Color.White
        Me.txtTel.BackColor = Color.White
        'Me.txtEmail.BackColor = Color.White
        gvTxt_Focus = Me.txtID
        mod_LoadLanguageForm.SubG_EmployeeForm()
    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable

        Me.txtID.Enabled = True
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtAddress.Text = ""
        Me.txtTel.Text = ""

        Try
            mvObj_DataTable = mvCls_CustomerUpdate.FuncG_GetAllData(2)
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            Me.GridView1.Columns("ADDRESS").Visible = False
            Me.GridView1.Columns("EMAIL").Visible = False
            Me.GridView1.Columns("TYPE").Visible = False
            Me.GridView1.Columns("Mathegiamgia").Visible = False
            Me.GridView1.Columns("Phantram").Visible = False
            Me.GridView1.Columns("Note").Visible = False
            Me.GridView1.Columns("LoaiThe").Visible = False
            Me.GridView1.Columns("Soluonggiam").Visible = False
            Me.GridView1.Columns("ngaythangnam").Visible = False
            Me._isAdd = 0

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_Employee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_MainMenu.Show()
        ' Me.Close()
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
            Me.txtAddress.Text = Me.GridView1.GetFocusedDataRow("ADDRESS")
            Me.txtTel.Text = Me.GridView1.GetFocusedDataRow("TEL")
            'Me.txtEmail.Text = Me.GridView1.GetFocusedDataRow("EMAIL")
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
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Enter, txtName.Enter, txtAddress.Enter, txtTel.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtID" Then
                Me.txtID.BackColor = Color.LightSkyBlue
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                'Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtID
            ElseIf mvCtr_ActiveControl.Name = "txtName" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.LightSkyBlue
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.White
                'Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtName
            ElseIf mvCtr_ActiveControl.Name = "txtAddress" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.LightSkyBlue
                Me.txtTel.BackColor = Color.White
                'Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtAddress
            ElseIf mvCtr_ActiveControl.Name = "txtTel" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtAddress.BackColor = Color.White
                Me.txtTel.BackColor = Color.LightSkyBlue
                'Me.txtEmail.BackColor = Color.White
                gvTxt_Focus = Me.txtTel
                'ElseIf mvCtr_ActiveControl.Name = "txtEmail" Then
                '    Me.txtID.BackColor = Color.White
                '    Me.txtName.BackColor = Color.White
                '    Me.txtAddress.BackColor = Color.White
                '    Me.txtTel.BackColor = Color.White
                '    Me.txtEmail.BackColor = Color.LightSkyBlue
                '    gvTxt_Focus = Me.txtEmail
            End If
        Catch ex As Exception

        End Try
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
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If Me.txtID.Text = "" Then
                'SubG_Alert(5)
            Else
                mvCls_Customer.ID = Me.txtID.Text.Trim
                mvCls_Customer.Name = Me.txtName.Text.Trim
                mvCls_Customer.Address = Me.txtAddress.Text.Trim
                mvCls_Customer.Tel = Me.txtTel.Text.Trim
                mvCls_Customer.Type = 2
                mvCls_Customer.Phantram = 0
                mvCls_Customer.Email = ""
                mvCls_Customer.Mathegiamgia = "MNVLV" + Me.txtID.Text.Trim
                mvCls_Customer.Note = ""
                mvCls_Customer.Loaithe = 1
                mvCls_Customer.Soluonggiam = 0
                mvCls_CustomerUpdate.FuncG_InsertUpdate_Customer_Employee(mvCls_Customer, Me._isAdd)

                SubM_LoadArea()
                Me.GridView1.FocusedRowHandle = 0
                SubM_ClickOnGird()

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
            'mvCls_Customer.Email = Me.txtEmail.Text.Trim
            mvCls_Customer.Type = 2
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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Me._isAdd = 0
        Me.txtID.Enabled = True
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtAddress.Text = ""
        Me.txtTel.Text = ""

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Me._isAdd Then
                SubM_ClickOnGird()
            Else
                Dim msg As String
                Dim frm As New frm_Alert()
                If gvByte_Language = 1 Then
                    msg = "Bạn có muốn xóa nhân viên " + Me.txtName.Text + " không?"
                    frm.setParam("Xác nhận", msg, frm_Alert.WTYPE.YESNO)
                    frm.Text = "Xác nhận"
                Else
                    msg = "Do you want to remove employee" + Me.txtName.Text + " not?"
                    frm.setParam("Confirm", msg, frm_Alert.WTYPE.YESNO)
                    frm.Text = "Confirm"
                End If


                

                frm.StartPosition = FormStartPosition.CenterParent

                frm.ShowDialog()


                If rsl_MSG = frm_Alert.WRESULT.YES Then
                    mvCls_Customer.ID = Me.txtID.Text.Trim
                    Dim mvCls_CustomerUpdate As New cls_Customer_Update
                    If mvCls_CustomerUpdate.FuncG_GetCustomerSalesByID(mvCls_Customer.ID) = True Then
                        mvCls_CustomerUpdate.FuncG_Delete_Employee(mvCls_Customer)
                    Else
                        If gvByte_Language = 1 Then
                            FunG_Alert("Thông báo", "Thao tác thất bại.", frm_Alert.WTYPE.CHECK)
                        Else
                            FunG_Alert("Message", "Action Failed", frm_Alert.WTYPE.CHECK)
                        End If


                    End If


                    SubM_LoadArea()
                    Me.GridView1.FocusedRowHandle = 0
                    SubM_ClickOnGird()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class