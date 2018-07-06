Imports System.Data.OleDb
Public Class mdi
    Dim x As DialogResult

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles b_qtt.Click
        Me.Close()
    End Sub

    Private Sub B_pr_Click(sender As Object, e As EventArgs) Handles B_pr.Click
        'b_acl.Checked = False
        'B_emp.Checked = False
        'B_cl.Checked = False
        'B_spo.Checked = False
        'B_pr.Checked = True
        'b_qtt.Checked = False
    End Sub




    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles b_logout.Click
        x = MessageBox.Show("Voulez Vous Vraiment Decc Cet Compte", "Auto IMEBA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            b_logout.Visible = False
            b_login.Visible = True
            B_cl.Enabled = False
            B_emp.Enabled = False
            B_spo.Enabled = False
            B_pr.Enabled = False
            b_acl.Enabled = False
            b_qtt.Enabled = True
            login.Close()
        End If
    End Sub

  

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles b_login.Click
        login.Show()
    End Sub

    Private Sub B_emp_Click(sender As Object, e As EventArgs) Handles B_emp.Click
        'b_acl.Checked = False
        'B_emp.Checked = True
        'B_cl.Checked = False
        'B_spo.Checked = False
        'B_pr.Checked = False
        'b_qtt.Checked = False


    End Sub

    Private Sub B_cl_Click(sender As Object, e As EventArgs) Handles B_cl.Click
        sport.Close()
        client.Show()
        b_acl.Checked = False
        B_emp.Checked = False
        B_cl.Checked = True
        B_spo.Checked = False
        B_pr.Checked = False
        b_qtt.Checked = False
    End Sub

    Private Sub B_spo_Click(sender As Object, e As EventArgs) Handles B_spo.Click
        'sport.Show()
        'client.Close()
        b_acl.Checked = False
        B_emp.Checked = False
        B_cl.Checked = False
        B_spo.Checked = True
        B_pr.Checked = False
        b_qtt.Checked = False
    End Sub

    Private Sub b_acl_Click(sender As Object, e As EventArgs) Handles b_acl.Click
        'sport.Close()
        'client.Close()
        b_acl.Checked = True
        B_emp.Checked = False
        B_cl.Checked = False
        B_spo.Checked = False
        B_pr.Checked = False
        b_qtt.Checked = False
    End Sub




    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        help.Show();
    End Sub
End Class