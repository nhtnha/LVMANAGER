Public Class cls_History_Update
    Inherits cls_Database_Base
#Region "Get balane"
    Public Function FuncG_CheckBalane() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM TBL_CASHBOOK"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_Balane(ByVal iStr_Code As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM TBL_CASHBOOK WHERE CODE = @iNVchr_CODE"
                SubM_AddParameter("@iNVchr_CODE", iStr_Code)
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
#Region "Insert"
    Public Function FuncG_Insert(ByVal iCls_History As cls_History) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVchr_CODE", iCls_History.Code)
                SubM_AddParameter("@iDate_INVOICEDAY", iCls_History.InvoiceDay)
                SubM_AddParameter("@iNVchr_MONEYTYPE", iCls_History.MoneyType)
                SubM_AddParameter("@iFlt_BALANCE", iCls_History.Balance)
                SubM_AddParameter("@iFlt_AMOUNT", iCls_History.Amount)
                SubM_AddParameter("@iTInt_STATUS", iCls_History.Status)
                If FuncM_ExecuteStore("usp_History") Then
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
