#Region "NameSpaces"
Imports ConIO.REG
#End Region
Public Class frm_License
#Region "Khai báo biến"
    Private Declare Function getHardDriveComputerID Lib "HardDiskID.dll" () As String
    Dim mvCls_Logon As New cls_Login
    Dim mvCls_LoadLanguage As New cls_LoadLanguage
    Public mvBol_Flag As Boolean = False
    Dim mvStr_Path As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
    Dim mvStr_NameKey As String = "ProductName"
#End Region
#Region "Form events"
    Private Sub frm_License_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_MainMenu.PanelControl1.Visible = True
    End Sub
    Private Sub frm_Registry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mvStr_ProductName As String
        Dim mvBol_Win7 As Boolean
        Try
            mvStr_ProductName = My.Computer.Registry.LocalMachine.OpenSubKey(mvStr_Path).GetValue(mvStr_NameKey)
            If mvStr_ProductName.IndexOf("Windows 7") <> -1 Then
                mvBol_Win7 = True
            Else
                mvBol_Win7 = False
            End If
            If mvBol_Win7 Then
                Me.txtSerial.Text = cls_PhysicalDrive.GetSerialNumberUsingSmart(0)
            Else
                Me.txtSerial.Text = getHardDriveComputerID.Trim.ToString
            End If
        Catch ex As Exception
            If gvByte_Language = 1 Then
                FunG_Alert("Cảnh báo", "Máy này bị lỗi trong quá trình cài đặt!" & Chr(13) & "Vui lòng liên hệ gặp Mr.Nguyên (0935 328 921)!", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Warning", "This machine fails during installation!" & Chr(13) & "Please contact meet Mr.Nguyễn (0935 328 921)!", frm_Alert.WTYPE.ERROR)
            End If

            End
        End Try
    End Sub
#End Region
#Region "TextChanged"
    Private Sub txtCheck_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerial.TextChanged, txtRegistryCode.TextChanged
        mvCls_Logon.SubG_FormatButton(Me.txtSerial, Me.txtRegistryCode, Me.cmdDangKy)
    End Sub
#End Region
#Region "Nút đăng ký"
    Private Sub cmdDangKy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDangKy.Click
        Dim mvStr_Serial As String
        Dim mvStr_RegistryCode As String
        Dim mvStr_Decrypt As String
        Try
            mvStr_Serial = Me.txtSerial.Text
            mvStr_RegistryCode = Me.txtRegistryCode.Text
            If String.IsNullOrEmpty(Me.txtRegistryCode.Text) Then
                SubG_Alert(95) ' FunG_Alert("Cảnh báo", "Mã đăng ký không hợp lệ!", frm_Alert.WTYPE.ERROR)
            Else
                mvStr_Decrypt = Decrypt(mvStr_RegistryCode)
                If mvStr_Serial = mvStr_Decrypt Then
                    If CreateLicense(mvStr_RegistryCode) Then
                        If FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(13, "frm_License", 2), mvCls_LoadLanguage.FuncG_GetData(11, "frm_License", 2), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                            Application.Restart()
                        End If
                    Else
                        If gvByte_Language = 1 Then
                            FunG_Alert("Cảnh báo", "Máy này bị lỗi trong quá trình cài đặt!" & Chr(13) & "Vui lòng liên hệ gặp Mr.Nguyên (0935 328 921)!", frm_Alert.WTYPE.ERROR)
                        Else
                            FunG_Alert("Warning", "This machine fails during installation!" & Chr(13) & "Please contact meet Mr.Nguyễn (0935 328 921)!", frm_Alert.WTYPE.ERROR)
                        End If

                    End If
                Else
                    SubG_Alert(96) ' FunG_Alert("Cảnh báo", "Mã đăng ký không hợp lệ!", frm_Alert.WTYPE.ERROR)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Try
            If mvBol_Flag Then
                End
            Else
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class