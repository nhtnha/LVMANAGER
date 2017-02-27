Public Class urc_Calculator
#Region "Khai báo biến"
    Public gvBol_Flag As Boolean = False    ' True : cho phép nhập thêm dấu '-'
#End Region
#Region "Bàn phím ảo"
    Private Sub OnScreenKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click, SimpleButton2.Click, SimpleButton3.Click, SimpleButton4.Click, _
        SimpleButton5.Click, SimpleButton6.Click, SimpleButton7.Click, SimpleButton8.Click, SimpleButton9.Click, SimpleButton10.Click, SimpleButton11.Click, cmdDot.Click, SimpleButton13.Click, _
        SimpleButton14.Click
        Try
            Dim mvBtn_Key As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
            gvTxt_Focus = Me.txtInput
            If mvBtn_Key.Text = "." Then
                If Me.txtInput.Text.IndexOf(".") = -1 Then
                    SubG_OnScreenKeypress(mvBtn_Key, gvTxt_Focus)
                End If
            Else
                If Me.txtInput.Text.Length < 16 Then
                    SubG_OnScreenKeypress(mvBtn_Key, gvTxt_Focus)
                Else
                    If mvBtn_Key.Text = "CE" Then
                        SubG_OnScreenKeypress(mvBtn_Key, gvTxt_Focus)
                    End If
                End If
            End If        
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load event"
    Private Sub urc_Calculator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtInput.Text = ""
    End Sub
#End Region
#Region "Chỉ cho nhập số"
    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        SubG_OnlyInputDigit(txtInput, e, gvBol_Flag)
    End Sub
#End Region
#Region "Chỉ cho nhập số"
    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged
        If Not gvBol_Flag Then
            'Nếu không phải là số hóa đơn
            'If IsNumeric(Me.txtInput.Text) Then
            '    If gvByte_Language = 1 Then
            '        SubG_FormatNumberDigit(Me.txtInput, 0)
            '    Else
            '        SubG_FormatNumberDigit(Me.txtInput, 2)
            '    End If
            'End If
        End If
    End Sub
#End Region
End Class
