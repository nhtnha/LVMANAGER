Public Class cls_Rate_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_CURRENCY] ORDER BY UNIQUEID"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData1() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS Mã, NAME AS Tên, RATE AS [Tỷ giá] FROM [TBL_CURRENCY] ORDER BY UNIQUEID"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_CURRENCY] WHERE [ID] = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
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
#Region "Insert - Update Rate"
    Public Function FuncG_InsertUpdate(ByVal iCls_ForeignCurrency As cls_Rate) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_ID", iCls_ForeignCurrency.Code)
                SubM_AddParameter("@iFlt_RATE", iCls_ForeignCurrency.Rate)
                If FuncM_ExecuteStore("usp_Currency") Then
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
