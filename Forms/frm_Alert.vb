Public Class frm_Alert
    Public result As Integer
    Public Enum WTYPE
        [ERROR]
        [STOP]
        CHECK
        YESNO
    End Enum
    Public Enum WRESULT
        YES
        NO
        OK
    End Enum
    ''' <summary>
    ''' cấu hình thông số
    ''' </summary>
    ''' <param name="title">title của hộp thoại</param>
    ''' <param name="msg">thông điệp của hộp thoại</param>
    ''' <param name="wType">kiểu hộp thoại: 0 = error, 1 = stop, 2 = check</param>
    Public Sub setParam(ByVal title As [String], ByVal msg As [String], ByVal wType As WTYPE)
        Dim iType As Integer = 0
        If wType = wType.[ERROR] Then
            iType = 0
        ElseIf wType = wType.[STOP] Then
            iType = 1
        ElseIf wType = wType.CHECK Then
            lblMsg.ForeColor = Color.DarkGreen
            iType = 2
        ElseIf wType = wType.YESNO Then
            result = WRESULT.NO
            cmdNo.Visible = True
            cmdYes.Visible = True
            cmdExit.Visible = False
            lblMsg.ForeColor = Color.MediumBlue
            iType = 3
        End If
        pictureEdit.Image = imageCollection.Images(iType)
        Me.Text = title
        lblMsg.Text = msg
    End Sub
    Private Sub frmAlert_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.Size = New Size(lblMsg.Width + 100, Me.Height)
        mod_LoadLanguageForm.SubG_AlertForm()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        result = WRESULT.OK
        Me.Close()
    End Sub
    Private Sub btnNO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNo.Click
        result = WRESULT.NO
        Me.Close()
    End Sub
    Private Sub btnYes_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        result = WRESULT.YES
        Me.Close()
    End Sub
End Class