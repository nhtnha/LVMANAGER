Public Class frm_Rate
#Region "Khai báo biến"
    Dim mvCls_Rate As New cls_Rate
    Dim mvCls_RateUpdate As New cls_Rate_Update
    Dim mvUrc_Caculator As New urc_Calculator()
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Me.txtMa.Text = ""
        With Me.PanelControl1
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        mod_Format.Sub_ShowControl(mvUrc_Caculator, 7)
        mod_LoadLanguageForm.SubG_MainMenuForm()
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_Rate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút Delete"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        mvUrc_Caculator.txtInput.Text = ""
    End Sub
#End Region
#Region "Nút USD, EURO, VISA, MASTER"
    Private Sub cmdUSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUSD.Click, cmdEURO.Click, cmdMaster.Click, cmdVisa.Click
        Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
        Dim mvObj_DataTable As New DataTable
        Try
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            Me.txtMa.Text = mvCmd_SimpleButton.Text
            mvObj_DataTable = mvCls_RateUpdate.FuncG_GetData(Me.txtMa.Text)
            If mvObj_DataTable.Rows.Count <> 0 Then
                mvUrc_Caculator.txtInput.Text = mvObj_DataTable.Rows(0)("RATE")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If Me.txtMa.Text = "" Then
                SubG_Alert(105) ' FunG_Alert("Thông báo lỗi", "Chưa chọn loại tiền cần câp nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Rate.Code = Me.txtMa.Text.Trim
                mvCls_Rate.Rate = mvUrc_Caculator.txtInput.Text.Trim
                mvCls_RateUpdate.FuncG_InsertUpdate(mvCls_Rate)
                Me.txtMa.Text = ""
                mvUrc_Caculator.txtInput.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
End Class