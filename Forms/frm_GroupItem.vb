Public Class frm_GroupItem
#Region "Khai Báo Biến"
    Dim mvCls_GroupItem As New cls_GroupItem
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
    Dim _path_Image As String = Application.StartupPath + "\\.PNG"
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadArea()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        mod_LoadLanguageForm.SubG_GroupItemForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 11)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        gvTxt_Focus = Me.txtName
    End Sub
#End Region
#Region "Load area"
    Private Sub SubM_LoadArea()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_GroupItemUpdate.FuncG_GetAllData()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns(mvObj_DataTable)
            Me.GridView1.Columns("STATUS").Visible = False
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
            If Me.GridView1.GetFocusedDataRow("STATUS") = 1 Then
                Me.RadioGroup1.SelectedIndex = 0
            Else
                Me.RadioGroup1.SelectedIndex = 1
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        SubM_ClickOnGird()
    End Sub
#End Region
#Region "Nút Update"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        Try
            If Me.txtID.Text = "" Then
                SubG_Alert(90) ' FunG_Alert("Thông báo lỗi", "Chưa chọn nhóm hàng cần cập nhật!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_GroupItem.ID = Me.txtID.Text
                mvCls_GroupItem.Name = Me.txtName.Text
                If Me.RadioGroup1.SelectedIndex = 0 Then
                    mvCls_GroupItem.Status = 1
                Else
                    mvCls_GroupItem.Status = 0
                End If
                'Add 2013/12/19 by DUY THI - Them Hinh anh

                'mvCls_GroupItem.Image1 = ReadFile(_path_Image)
                'mvCls_GroupItem.Image2 = ReadFile(_path_Image)
                mvCls_GroupItem.Description = ""
                mvCls_GroupItem.Type = rgptypegroup.SelectedIndex + 1

                mvCls_GroupItemUpdate.FuncG_UpdateGroup(mvCls_GroupItem)
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

    ''' <summary>
    ''' ReadFile - Dùng để đọc một file ảnh trên đĩa và convert sang mảng byte
    ''' </summary>
    ''' <Author>Van Long</Author>
    ''' <Date>2013/12/19</Date>
    ''' <param name="sFileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadFile(ByVal sFileName As String) As Byte()
        Dim fs As System.IO.FileStream = New System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read)
        Dim rs() As Byte = New Byte(fs.Length) {}
        fs.Read(rs, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        Return rs
    End Function
End Class