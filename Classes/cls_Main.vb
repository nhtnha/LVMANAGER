#Region "NameSpaces"
Imports ConIO.REG
Imports IO.REG
Imports Windows.REG
#End Region
Public Class cls_Main
    Inherits cls_Database_Base
    Public Sub SubG_Load()
        Dim mvCls_Logon As New cls_Login
        Dim mvInt_Count As Integer = 3
        'mvCls_Logon.SubM_Reader()
        cls_Database_Base.gvStr_ConnecttionString = "server=" + gvProp_Server + ";Initial Catalog=" + gvProp_DataBase + ";User ID=" + gvProp_User + ";Password=" + gvProp_PassWord + ";Persist Security Info=True;"
        Try
            If FuncM_OpenConnection() Then
                frm_Login.ShowDialog()
            Else
                frm_Config.ShowDialog()
            End If
        Catch ex As Exception

        Finally
            FuncM_CloseConnection()
        End Try
    End Sub
    Public Function SubG_CheckConnection() As Boolean
        If FuncM_OpenConnection() Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
