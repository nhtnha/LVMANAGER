Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Namespace My
    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim mvCls_Main As New cls_Main
            Try
                DevExpress.UserSkins.BonusSkins.Register()
                DevExpress.Skins.SkinManager.EnableFormSkins()
                DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
            Catch ex As Exception

            End Try
        End Sub
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo", "The program is running. Please wait a moment!", frm_Alert.WTYPE.STOP)
            Else
                FunG_Alert("Message", "The program is chay.Xin please wait a moment !", frm_Alert.WTYPE.STOP)
            End If

        End Sub
        '======================================================================
        ' Key for TripleDES encryption
        Public Shared key As Byte() = {21, 10, 64, 10, 100, 40, _
         200, 4, 21, 54, 65, 246, _
         5, 62, 1, 54, 54, 6, _
         8, 9, 65, 4, 65, 9}

        Private Shared iv As Byte() = {0, 0, 0, 0, 0, 0, _
         0, 0}
        Public Shared Function ABC_ReadFile(ByVal FilePath As String) As String
            Dim fi As New FileInfo(FilePath)
            If fi.Exists = False Then
                Return String.Empty
            End If

            Dim fin As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim tdes As TripleDES = New TripleDESCryptoServiceProvider()
            Dim cs As New CryptoStream(fin, tdes.CreateDecryptor(key, iv), CryptoStreamMode.Read)

            Dim SB As New StringBuilder()
            Dim ch As Integer
            For i As Integer = 0 To fin.Length - 1
                ch = cs.ReadByte()
                If ch = 0 Then
                    Exit For
                End If
                SB.Append(Convert.ToChar(ch))
            Next

            cs.Close()
            fin.Close()
            Return SB.ToString()
        End Function
        Public Shared Sub FunG_WriteFile(ByVal FilePath As String, ByVal Data As String)
            Dim fout As New FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write)
            Dim tdes As TripleDES = New TripleDESCryptoServiceProvider()
            Dim cs As New CryptoStream(fout, tdes.CreateEncryptor(key, iv), CryptoStreamMode.Write)

            Dim d As Byte() = Encoding.ASCII.GetBytes(Data)
            cs.Write(d, 0, d.Length)
            cs.WriteByte(0)

            cs.Close()
            fout.Close()
        End Sub
    End Class
End Namespace

