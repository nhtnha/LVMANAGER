Public Class urc_FullScreenKeyboard
#Region "Hàm khởi tạo"
    Public Sub SubM_InitializeForm()
        mod_LoadLanguageForm.SubG_FullScreenKeyboard(Me.cmdDel)
    End Sub
#End Region
#Region "Formload"
    Private Sub FullScreenKeyboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Bàn phím ảo"
    Private Sub OnScreenKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click, SimpleButton2.Click, SimpleButton3.Click, SimpleButton4.Click, _
        SimpleButton5.Click, SimpleButton6.Click, SimpleButton7.Click, SimpleButton8.Click, SimpleButton9.Click, SimpleButton10.Click, SimpleButton11.Click, SimpleButton12.Click, SimpleButton13.Click, _
        SimpleButton14.Click, SimpleButton15.Click, SimpleButton16.Click, SimpleButton17.Click, SimpleButton18.Click, SimpleButton19.Click, SimpleButton20.Click, SimpleButton21.Click, SimpleButton22.Click, _
        cmdDel.Click, SimpleButton24.Click, SimpleButton25.Click, SimpleButton26.Click, SimpleButton27.Click, SimpleButton28.Click, SimpleButton29.Click, SimpleButton30.Click, SimpleButton31.Click, _
        SimpleButton32.Click, SimpleButton33.Click, SimpleButton37.Click, SimpleButton38.Click, SimpleButton39.Click, SimpleButton40.Click, SimpleButton41.Click, SimpleButton42.Click, SimpleButton43.Click, SimpleButton44.Click
        Try
            Dim mvBtn_Key As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl
            SubG_OnScreenKeypress(mvBtn_Key, gvTxt_Focus)
            If IsNumeric(gvTxt_Focus.Text) Then
                If gvByte_Language = 1 Then
                    SubG_FormatNumberDigit(gvTxt_Focus, 0)
                Else
                    SubG_FormatNumberDigit(gvTxt_Focus, 2)
                End If
                gvTxt_Focus.SelectionStart = gvTxt_Focus.Text.Length
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
