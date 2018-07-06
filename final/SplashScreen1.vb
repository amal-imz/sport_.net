Public NotInheritable Class SplashScreen1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = Timer1.Interval + 100
        If Timer1.Interval >= 1200 Then
            Timer1.Enabled = False
            Me.Hide()
            mdi.Show()
            mdi.B_emp.Enabled = False
            mdi.p_emp.Enabled = False
            mdi.B_cl.Enabled = False
            mdi.p_cl.Enabled = False
            mdi.B_spo.Enabled = False
            mdi.p_spo.Enabled = False
            mdi.B_pr.Enabled = False
            mdi.p_pr.Enabled = False
            mdi.b_acl.Enabled = False
            mdi.b_qtt.Enabled = True
        End If
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        'BackColor = Color.WhiteSmoke
        'TransparencyKey = BackColor
    End Sub
End Class
