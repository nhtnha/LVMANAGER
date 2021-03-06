Public Class frm_CompanyInfo
#Region "Khai báo biến"
    Dim gvCls_CompanyUpdate As New cls_CompanyInfo_Update
#End Region
#Region "Formload"
    Private Sub frm_CompanyInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.txtContact.Text = gvCls_Company.ContactPerson
            Me.txtTenCty.Text = gvCls_Company.Name
            Me.txtDiaChi.Text = gvCls_Company.Address
            Me.txtSoDienThoai.Text = gvCls_Company.Phone
            Me.txtFax.Text = gvCls_Company.Fax
            Me.txtTax.Text = gvCls_Company.Tax
            Me.txtEmail.Text = gvCls_Company.Email
            mod_LoadLanguageForm.SubG_AreaForm()
            If gvByte_Language = 1 Then
                Me.Text = "Thông tin công ty"
                Me.Label10.Text = "Liên hệ"
                Me.Label3.Text = "Địa chỉ"
                Me.Label1.Text = "Số ĐT"
                Me.Label4.Text = "Mã thuế"
                Me.Label2.Text = "Tên công ty"
                cmdCapNhat.Text = "Cập nhật"
                cmdThoat.Text = "Thoát"
            Else
                cmdCapNhat.Text = "Update"
                cmdThoat.Text = "Exit"
                Me.Text = "Company Information"
                Me.Label10.Text = "Contact"
                Me.Label3.Text = "Address"
                Me.Label1.Text = "Phone number"
                Me.Label4.Text = "Tax code"
                Me.Label2.Text = "Company name"
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút cập nhật"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        Try
            'Cập nhạt thông tin cty
            gvCls_Company.ContactPerson = Me.txtContact.Text.Trim
            gvCls_Company.Name = Me.txtTenCty.Text.Trim
            gvCls_Company.Address = Me.txtDiaChi.Text.Trim
            gvCls_Company.Phone = Me.txtSoDienThoai.Text.Trim
            gvCls_Company.Fax = Me.txtFax.Text
            gvCls_Company.Tax = Me.txtTax.Text
            gvCls_Company.Email = Me.txtEmail.Text
            gvCls_CompanyUpdate.FuncG_Update(gvCls_Company)

            SubG_Alert(74) 'FunG_Alert("Thông báo", "Cập nhật thông tin thành công!", frm_Alert.WTYPE.CHECK)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region
End Class