Imports System.Data.OleDb

Imports System.Net.Mail
Imports System.IO
Imports System.Web
Imports System.Drawing.Image
Public Class client
    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from condidat", con)
    Private dtset As New DataSet
    Private x As DialogResult
    Dim openDlg As OpenFileDialog = New OpenFileDialog
    Dim filename As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.ace.oledb.12.0.0;data source=client.accdb"
        con.Open()
        dtadapter.Fill(dtset, "condidat")
        Grid1.DataSource = dtset.Tables("condidat")
        C1.Focus()
        For s = 0 To Me.grid1.RowCount - 2
            C1.Items.Add(Me.grid1.Item(0, s).Value)
        Next
        PictureBox1.Image = PictureBox1.BackgroundImage
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        If Me.grid1.RowCount - 1 = 0 Then
            C1.Text = 1
        Else
            C1.Text = Me.grid1.Item(0, Me.grid1.RowCount - 2).Value + 1

        End If

        'con.Close()
    End Sub

    Private Sub fermer_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ajouter_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub raz_Click(sender As Object, e As EventArgs)
        C1.Text = Nothing
        T_no.Text = Nothing
        t_pr.Text = Nothing
        t_em.Text = Nothing
        PictureBox1.Image = PictureBox1.BackgroundImage
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        f.Checked = False
        m.Checked = False


    End Sub

    Private Sub C1_SelectedIndexChanged(sender As Object, e As EventArgs)
        For s = 0 To Me.Grid1.RowCount - 2
            If c1.Text = Me.Grid1.Item(0, s).Value Then
                T_no.Text = Me.Grid1.Item(1, s).Value
                t_pr.Text = Me.Grid1.Item(2, s).Value
                t_em.Text = Me.Grid1.Item(7, s).Value
                If Me.Grid1.Item(3, s).Value = 1 Then
                    f.Checked = True
                End If
                If Me.Grid1.Item(3, s).Value = 2 Then
                    m.Checked = True
                End If

                PictureBox1.Image = ConvertToImage(Grid1.Item(5, s).Value)
                Qr1.Image = ConvertToImage(Grid1.Item(6, s).Value)
            End If

        Next


    End Sub

    Public Function ConvertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)

    End Function

    Public Function ConvertToData(ByVal myImage As Image) As Byte()
        Dim ms As New MemoryStream()
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Qr1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim myBytes(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(myBytes, 0, ms.Length)
        Return myBytes
    End Function


    Private Sub parcourir_Click(sender As Object, e As EventArgs) Handles parcourir.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.PictureBox1.ImageLocation = Me.OpenFileDialog1.FileName
        End If
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'Affecte un Nom au Fichier QR Code Exemple T3.text = CIN
        SaveFileDialog1.FileName = T_no.Text

        'Convertir Qr Code Format JPG
        Qr1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'Enregistrer en Tant que Objet Server Local « Debug »
        SaveFileDialog1.InitialDirectory = "C:\Users\amal\Desktop"
        'Enregistrement du Path pour Faciliter l’envoi pièce jointe    
        path.Text = "C:\Users\amal\Desktop\TEST QR CODE\WindowsApplication1\inscription\bin\Debug\" + SaveFileDialog1.FileName + ".jpg"

    End Sub




    Private Sub recherche_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub base(ByVal adapter As OleDbDataAdapter, ByVal table As String)

        Dim cmdbuilder As OleDbCommandBuilder
        cmdbuilder = New OleDb.OleDbCommandBuilder(adapter)
        adapter.UpdateCommand = cmdbuilder.GetUpdateCommand
        adapter.Update(dtset, table)
    End Sub


    Private Sub modifer_Click(sender As Object, e As EventArgs)
        Dim sw As Integer
        sw = 0
        Dim x As Integer
        For s = 0 To Me.Grid1.RowCount - 2
            If C1.Text = Me.Grid1.Item(0, s).Value Then
                sw = 1
                x = s
            End If
        Next
        If sw = 1 Then
            Dim ligneencours As Integer
            ligneencours = x
            Dim cle As String
            cle = Grid1.Item(0, ligneencours).Value
            Dim matable As DataTable
            matable = dtset.Tables("condidat")
            Dim laligne As DataRow()
            laligne = matable.Select("id=" & cle)
            laligne(0).Item(1) = T_no.Text
            laligne(0).Item(7) = t_pr.Text
            laligne(0).Item(2) = t_em.Text

            If f.Checked = True Then

                laligne(0).Item(3) = 1
            End If
            If m.Checked = True Then
                laligne(0).Item(3) = 2
            End If

            laligne(0).Item(5) = ConvertToData(Me.PictureBox1.Image)
            base(dtadapter, "condidat")
            MsgBox("la modification effectuer", MsgBoxStyle.Information)
        Else
            MsgBox("Référence N’Existe Pas", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub supprime_Click(sender As Object, e As EventArgs)
        x = MessageBox.Show("Voulez Vous Vraiment Supprimer Cet Enregistrement", "produit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            Dim x As Integer
            For s = 0 To Me.Grid1.RowCount - 2
                If C1.Text = Me.Grid1.Item(0, s).Value Then
                    x = s
                End If
            Next
            Dim ligneencours As Integer
            ligneencours = x
            Dim cle As String


            cle = Grid1.Item(0, ligneencours).Value
            Dim ligne As DataRow()
            ligne = dtset.Tables("condidat").Select("id=" & cle)
            ligne(0).Delete() 'Code uniquement pour la suppression dans la base de donnée locale
            C1.Text = Nothing
            T_no.Text = Nothing
            t_pr.Text = Nothing
            t_em.Text = Nothing

            f.Checked = False
            m.Checked = False


            PictureBox1.Image = PictureBox1.BackgroundImage
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

            MsgBox("Suppression Effectuée dans la base de données Locale", MsgBoxStyle.Information)
            'con.Open() 'ici nous allons ouvrir la connexion pour accéder et utiliser la base de données distante 
            Dim cmdbuilder As OleDbCommandBuilder
            cmdbuilder = New OleDb.OleDbCommandBuilder(dtadapter)
            dtadapter.DeleteCommand = cmdbuilder.GetDeleteCommand
            dtadapter.Update(dtset, "condidat")
            MsgBox("Suppression Effectuée dans la base de données Distante", MsgBoxStyle.Information)
        End If


        con.Close()
    End Sub


    Private Sub recherche_Click_1(sender As Object, e As EventArgs) Handles recherche.Click

    End Sub

    Private Sub supprime_Click_1(sender As Object, e As EventArgs) Handles supprime.Click
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        Dim sw As Integer = 0
        For s = 0 To Me.Grid1.RowCount - 2
            If c1.Text = Me.Grid1.Item(0, s).Value Then
                sw = 1
                t_no.Text = Me.Grid1.Item(1, s).Value
                t_pr.Text = Me.Grid1.Item(2, s).Value
                t_em.Text = Me.Grid1.Item(7, s).Value


                If Me.Grid1.Item(3, s).Value = 1 Then
                    f.Checked = True
                End If
                If Me.Grid1.Item(3, s).Value = 2 Then
                    m.Checked = True
                End If

                PictureBox1.Image = ConvertToImage(Grid1.Item(5, s).Value)
                Qr1.Image = ConvertToImage(Grid1.Item(6, s).Value)




            End If
        Next

        If sw = 0 Then
            MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub modifer_Click_1(sender As Object, e As EventArgs) Handles modifer.Click

    End Sub

    Private Sub Fermer_Click_1(sender As Object, e As EventArgs) Handles Fermer.Click

    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles ButtonX5.Click
        Me.Close()
    End Sub

    Private Sub ajouter_Click_1(sender As Object, e As EventArgs) Handles ajouter.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ajt.Click
        Dim x As Integer = 0
        For s = 0 To Me.Grid1.RowCount - 2
            If c1.Text = Me.Grid1.Item(0, s).Value Then
                x = 1
            End If
        Next
        If x = 0 Then
            If c1.Text <> "" And t_no.Text <> "" Then
                Dim newligne As DataRow
                newligne = dtset.Tables("condidat").NewRow
                newligne(0) = c1.Text
                newligne(1) = t_no.Text
                newligne(2) = t_pr.Text
                If f.Checked = True Then
                    newligne(5) = 1
                End If
                If m.Checked = True Then
                    newligne(5) = 2
                End If
                Dim rnd As Random
                Dim number As Integer
                rnd = New Random
                number = rnd.Next(999, 10000)
                newligne(4) = number.ToString
                newligne(6) = 0
                newligne(7) = ConvertToData(Me.PictureBox1.Image)

                Qr1.Text = "NOM :" + t_no.Text() & vbCrLf & "ville :" + t_pr.Text() & vbCrLf & "mail :" + t_em.Text()
                newligne(8) = ConvertToData(Me.Qr1.Image)
                newligne(3) = t_em.Text
                'Dim mail As New MailMessage()
                'Dim smtpserver As New SmtpClient
                'smtpserver.Credentials = New Net.NetworkCredential("amal2013_medo@hotmail.com", "amoula123")
                'smtpserver.Port = 587
                ''Le Compte Gmail comme Source d’envoi
                'smtpserver.Host = "smtp.hotmail.com"
                'smtpserver.EnableSsl = True
                ''T3.text Contient Adresse E.Mail Destinataire
                'mail.To.Add(T_mail.Text)
                'mail.From = New MailAddress(T_mail.Text)
                ''T4.text Contient Objet Envoi Destinataire
                'mail.Subject = "Bienvenue Notre Chère Client"
                ''T5.text Contient Contenu E.Mail Destinataire
                'mail.Body = "Votre Login Est : " + C1.Text + " Votre Mot De Passe Est : " + number.ToString
                'smtpserver.Send(mail)
                'MsgBox("Votre Message est Envoyé", MsgBoxStyle.Information)



                dtset.Tables("condidat").Rows.Add(newligne)
                Dim cmdbuild As OleDb.OleDbCommandBuilder
                cmdbuild = New OleDb.OleDbCommandBuilder(dtadapter)
                dtadapter.InsertCommand = cmdbuild.GetInsertCommand
                dtadapter.Update(dtset, "condidat")


                con.Close()
                MsgBox("ajouter bien")
            Else
                MsgBox("remplier tt ")
            End If
        Else
            MsgBox("deja exit ")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub
End Class

