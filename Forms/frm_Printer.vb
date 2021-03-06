Public Class frm_Printer
#Region "Khai Báo Biến"
    Dim mvCls_Printer As New cls_Printer
    Dim mvCls_PrinterUpdate As New cls_Printer_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.cmdOn.Enabled = False
        Me.cmdOff.Enabled = False
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        mod_LoadLanguageForm.SubG_PrinterForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 19)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        gvTxt_Focus = Me.txtName
    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_PrinterUpdate.FuncG_GetAllData()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            Me.GridView1.Columns("STATUS").Visible = False
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
            If Me.GridView1.GetFocusedDataRow("STATUS") = 1 Then
                Me.cmdOn.Enabled = False
                Me.cmdOff.Enabled = True
            Else
                Me.cmdOn.Enabled = True
                Me.cmdOff.Enabled = False
            End If
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
    End Sub
#End Region
#Region "Nút Off"
    Private Sub cmdOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOff.Click
        Me.cmdOn.Enabled = True
        Me.cmdOff.Enabled = False
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
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(102) ' FunG_Alert("Thông báo lỗi", "Chưa chọn máy in cần cập nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Printer.ID = Me.txtID.Text
                mvCls_Printer.Name = Me.txtName.Text
                If Me.cmdOn.Enabled = False Then
                    mvCls_Printer.Status = 1
                Else
                    mvCls_Printer.Status = 0
                End If
                mvCls_PrinterUpdate.FuncG_Update(mvCls_Printer)
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