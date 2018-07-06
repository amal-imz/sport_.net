Imports System.Data.OleDb

Public Class login
    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from condidat", con)
    Private dtset As New DataSet
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= client.accdb"
        con.Open()
        'Identification Table ou requête Exemple la Table T1
        dtadapter.Fill(dtset, "condidat")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        grid.DataSource = dtset.Tables("condidat")
        'Rechargement Combo : p our la Préparer à la recherche.
        For s = 0 To Me.grid.RowCount - 2
            C1.Items.Add(Me.grid.Item(0, s).Value)
        Next
        'BackColor = Color.Blue
        'TransparencyKey = BackColor

    End Sub

    

   

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        For s = 0 To Me.grid.RowCount - 2
            If C1.Text = Me.grid.Item(0, s).Value Then
                If T1.Text = Me.grid.Item(4, s).Value Then
                    If Me.grid.Item(6, s).Value = 0 Then
                        Timer1.Enabled = True
                        If Me.grid.Item(5, s).Value = 1 Then
                            mdi.b_acl.Enabled = True
                            mdi.B_emp.Enabled = True
                            mdi.B_spo.Enabled = True
                            mdi.B_pr.Enabled = True
                            mdi.B_cl.Enabled = True

                        End If
                        If Me.grid.Item(5, s).Value = 2 Then
                            mdi.b_acl.Enabled = True
                            mdi.B_emp.Enabled = True
                            mdi.B_spo.Enabled = True
                            mdi.B_pr.Enabled = True
                            mdi.B_cl.Enabled = True
                        End If

                    Else
                        MsgBox("Compte Bloqué SVP Contacter L'Admin")
                    End If
                Else
                    MsgBox("Code Invalide")
                    T1.Text = Nothing

                End If
            End If
        Next
        mdi.b_login.Enabled = False
        mdi.b_logout.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pro.Value = pro.Value + 10
        If pro.Value >= 99 Then
            Timer1.Enabled = False
            Me.Hide()
            mdi.Show()
            'login.MnConnecter.Enabled = False
            'MDIParent1.MnDéconnecter.Enabled = True
        End If
    End Sub
End Class