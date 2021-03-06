Public Class frm_Setup
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        Try
            With Me.PanelControl1
                .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
                .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
            End With
            Me.lblProductName.Left = (Me.ClientRectangle.Width / 2) - (Me.lblProductName.Width / 2)
            mod_LoadLanguageForm.SubG_SetupForm()
            Dim mvUrc_Footer As New urc_Footer
            mod_Format.Sub_ShowControl(mvUrc_Footer, 9)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_Setup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = Keys.F4) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frm_MainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
        'Lấy thông tin công ty
        SubM_GetCompanyInfo()
    End Sub
#End Region
#Region "Nút hàng hóa"
    Private Sub cmdItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItem.Click
        frm_SetMenu.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút nhóm hàng"
    Private Sub cmdGroupItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupItem.Click
        frm_GroupItem.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút giảm giá"
    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click

    End Sub
#End Region
#Region "Nút nhân viên"
    Private Sub cmdEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmployee.Click
        frm_Employee.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút máy in"
    Private Sub cmdPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrinter.Click
        frm_Printer.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút khu vực"
    Private Sub cmdArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArea.Click
        frm_Area.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút bàn"
    Private Sub cmdTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTable.Click
        frm_SetArea.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút khách hàng"
    Private Sub cmdCustumer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        frm_Customer.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút tỷ giá"
    Private Sub cmdRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRate.Click
        frm_Rate.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút người dùng"
    Private Sub cmdUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUser.Click
        frm_Account.Show()
        Me.Close()
    End Sub
#End Region
#Region "Nút thẻ"
    Private Sub cmdCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCard.Click

    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click, cmdClose.Click
        frm_MainMenu.Show()
        Me.Close()
    End Sub
#End Region
End Class