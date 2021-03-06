Imports System.Xml
Imports System.IO
Public Class frm_Location
#Region "Khai Báo Biến"
    Dim mvCls_Loctions As New cls_Location
    Dim mvCls_UpdateLocation As New cls_Location_Update
    Dim mvCls_Main As New cls_Main
    Public mvBol_IsExits As Boolean = True
    Public mvObj_GridData As New DataTable
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        gvByte_Language = 1
        mvObj_GridData.Clear()
        SubM_CreateData()
        SubM_LoadLocation()
        If gvByte_Language = 1 Then
            Me.gpcHeader.Text = "Chọn địa điểm"
        Else
            Me.gpcHeader.Text = "Choose location"
        End If
    End Sub
#End Region
#Region "Tạo bảng để load lên gird"
    Private Sub SubM_CreateData()
        Try
            mvObj_GridData.Columns.Add("ID", GetType(String))
            mvObj_GridData.Columns.Add("Name", GetType(String))
            mvObj_GridData.Columns.Add("Address", GetType(String))
            mvObj_GridData.Columns.Add("IP Address", GetType(String))
            mvObj_GridData.Columns.Add("Username", GetType(String))
            mvObj_GridData.Columns.Add("Password", GetType(String))
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load Location"
    Private Sub SubM_LoadLocation()
        Dim mvObj_DataTable As New DataTable
        Try
            Me.SubM_ReadXML()
            Me.GridControl1.DataSource = Nothing
            Me.GridControl1.DataSource = mvObj_GridData
            Me.GridView1.PopulateColumns()
            If gvByte_Language = 1 Then
                Me.GridView1.Columns(0).Caption = "Mã"
                Me.GridView1.Columns(1).Caption = "Văn phòng"
                Me.GridView1.Columns(2).Caption = "Địa chỉ"
                Me.GridView1.Columns(3).Caption = "Đ/c IP"
            Else
                Me.GridView1.Columns(0).Caption = "ID"
                Me.GridView1.Columns(1).Caption = "Name"
                Me.GridView1.Columns(2).Caption = "Address"
                Me.GridView1.Columns(3).Caption = "IP Address"
            End If
            Me.GridView1.Columns(0).Width = 95
            Me.GridView1.Columns(1).Width = 200
            Me.GridView1.Columns(2).Width = 200
            Me.GridView1.Columns(3).Width = 200
            Me.GridView1.Columns(4).Visible = False
            Me.GridView1.Columns(5).Visible = False
            'Me.GridView1.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub frm_Location_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.SubM_CreateXML()
    End Sub
    Private Sub frm_Location_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = Keys.F4) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Change focus row"
    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            Dim mvStr_Location As String
            If Me.GridView1.FocusedRowHandle > -1 Then
                mvStr_Location = (Me.GridView1.FocusedRowHandle + 1) & "/" & Me.GridView1.RowCount.ToString
            Else
                mvStr_Location = "0/0"
            End If
            If gvByte_Language = 1 Then
                Me.lblDiaDiem.Text = String.Format("Chọn địa điểm {0}", mvStr_Location)
            Else
                Me.lblDiaDiem.Text = String.Format("Choose location {0}", mvStr_Location)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Add"
    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Try
            frm_AddEditLocation.mvBol_Edit = False
            frm_AddEditLocation.txtID.Text = ""
            frm_AddEditLocation.txtName.Text = ""
            frm_AddEditLocation.txtAddress.Text = ""
            frm_AddEditLocation.txtIPAddress.Text = ""
            frm_AddEditLocation.txtUser.Text = ""
            frm_AddEditLocation.txtPassword.Text = ""
            frm_AddEditLocation.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Edit"
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                frm_AddEditLocation.mvBol_Edit = True
                frm_AddEditLocation.txtID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(0)
                frm_AddEditLocation.txtName.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(1)
                frm_AddEditLocation.txtAddress.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(2)
                frm_AddEditLocation.txtIPAddress.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(3)
                frm_AddEditLocation.txtUser.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(4)
                frm_AddEditLocation.txtPassword.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(5)
                frm_AddEditLocation.ShowDialog()
            Else
                SubG_Alert(97) 'FunG_Alert("Lỗi", "Vui lòng chọn địa điểm cần xem báo cáo!", frm_Alert.WTYPE.ERROR)
            End If          
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Choose"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim mvObj_DataTable As New DataTable
        Dim mvCls_Login As New cls_Login
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                mvCls_Login.SubM_Reader()
                gvStr_LocID = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(0)
                'gvProp_DataBase = "RESTAURANT DATABASE"
                gvStr_Location = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(1)
                gvProp_Server = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(3)
                gvProp_User = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(4)
                gvProp_PassWord = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(5)
                cls_Database_Base.gvStr_ConnecttionString = "server=" + gvProp_Server + ";Initial Catalog=" + gvProp_DataBase + ";User ID=" + gvProp_User + ";Password=" + gvProp_PassWord + ";Persist Security Info=True;"
                If mvCls_Main.SubG_CheckConnection Then
                    Me.Close()
                Else
                    SubG_Alert(98) ' FunG_Alert("Lỗi", "Không thể kết nối đến máy chủ!", frm_Alert.WTYPE.ERROR)
                End If
            Else
                SubG_Alert(97) 'FunG_Alert("Lỗi", "Vui lòng chọn địa điểm cần xem báo cáo!", frm_Alert.WTYPE.ERROR)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Close"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If Me.mvBol_IsExits Then
            End
        Else
            Me.Close()
            frm_MainMenu.mvBol_IsChoseInventory = True
        End If
    End Sub
#End Region
#Region "Create XML file"
    Private Sub SubM_CreateXML()
        Try
            ' Create XmlWriterSettings.
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            'Check exists file
            If File.Exists(Application.StartupPath + "\location.xml") Then
                File.Delete(Application.StartupPath + "\location.xml")
            End If
            ' Create XmlWriter.
            Using writer As XmlWriter = XmlWriter.Create(Application.StartupPath + "\location.xml", settings)
                ' Begin writing.
                writer.WriteStartDocument()
                writer.WriteStartElement("Locations") ' Root.
                For i As Integer = 0 To Me.GridView1.RowCount - 1
                    writer.WriteStartElement("Locations")
                    writer.WriteElementString("ID", Me.GridView1.GetDataRow(i)(0))
                    writer.WriteElementString("Name", Me.GridView1.GetDataRow(i)(1))
                    writer.WriteElementString("Address", Me.GridView1.GetDataRow(i)(2))
                    writer.WriteElementString("IPAddress", Me.GridView1.GetDataRow(i)(3))
                    writer.WriteElementString("Username", Me.GridView1.GetDataRow(i)(4))
                    writer.WriteElementString("Password", Me.GridView1.GetDataRow(i)(5))
                    writer.WriteEndElement()
                Next
                ' End document.
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Read XML file"
    Private Sub SubM_ReadXML()
        Try
            If File.Exists(Application.StartupPath + "\location.xml") Then
                ' Create an XML reader.
                Using reader As XmlReader = XmlReader.Create(Application.StartupPath + "\location.xml")
                    While reader.Read()
                        If reader.IsStartElement() Then
                            If reader.Name = "Locations" Then

                            ElseIf reader.Name = "ID" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.ID = reader.Value
                                End If
                            ElseIf reader.Name = "Name" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.Name = reader.Value
                                End If
                            ElseIf reader.Name = "Address" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.Address = reader.Value
                                End If
                            ElseIf reader.Name = "IPAddress" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.IPAddress = reader.Value
                                End If
                            ElseIf reader.Name = "Username" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.UserName = reader.Value
                                End If
                            ElseIf reader.Name = "Password" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Loctions.Password = reader.Value
                                    'Add data in to gird
                                    mvObj_GridData.Rows.Add(New Object() {mvCls_Loctions.ID, mvCls_Loctions.Name, mvCls_Loctions.Address, _
                                    mvCls_Loctions.IPAddress, mvCls_Loctions.UserName, mvCls_Loctions.Password})
                                    Me.GridView1.RefreshData()
                                End If
                            End If
                        End If                
                    End While
                End Using
            End If
        Catch ex As Exception
            If File.Exists(Application.StartupPath + "\location.xml") Then
                File.Delete(Application.StartupPath + "\location.xml")
            End If
        End Try
    End Sub
#End Region
End Class