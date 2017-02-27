Public Class frm_Shutdown
#Region "Form events"
    Private Sub frm_Shutdown_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mod_LoadLanguageForm.SubG_ShutdownForm()
        frm_Login.PanelControl1.Visible = False
    End Sub
    Private Sub frm_Shutdown_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Login.PanelControl1.Visible = True
    End Sub
#End Region
#Region "Nút đóng"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Nút shutdown"
    Private Sub cmdTurnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTurnOff.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub
#End Region
#Region "Nút restart"
    Private Sub cmdRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestart.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub
#End Region
End Class