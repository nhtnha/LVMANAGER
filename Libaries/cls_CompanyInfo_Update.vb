Public Class cls_CompanyInfo_Update
    Inherits cls_Database_Base
#Region "Lấy Thông tin công ty"
    Public Function FuncG_LayThongTin() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM TBL_COMPANY"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
#End Region
#Region "Cập nhật thông tin công ty"
    Public Function FuncG_Update(ByVal iCls_CompanyInfo As cls_CompanyInfo) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVchr_NAME", iCls_CompanyInfo.Name)
                SubM_AddParameter("@iNVchr_ADDRESS", iCls_CompanyInfo.Address)
                SubM_AddParameter("@iNVchr_PHONE", iCls_CompanyInfo.Phone)
                SubM_AddParameter("@iNVchr_FAX", iCls_CompanyInfo.Fax)
                SubM_AddParameter("@iNVchr_TAX", iCls_CompanyInfo.Tax)
                SubM_AddParameter("@iNVchr_EMAIL", iCls_CompanyInfo.Email)
                SubM_AddParameter("@iNVchr_CONTACT", iCls_CompanyInfo.ContactPerson)
                If FuncM_ExecuteStore("usp_CompanyInfo") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
#End Region
End Class
