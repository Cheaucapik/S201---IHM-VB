Imports System.Media

Public Class Accueil
    Dim clic As New SoundPlayer(My.Resources.click)
    Dim seeYou As New SoundPlayer(My.Resources.see_you)
    Dim longueur As Boolean
    Dim jouer As New SoundPlayer(My.Resources.done)
    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click
        If Settings.son Then
            clic.Play()
        End If
        Dim Choix = MsgBox("Êtes-vous sûr de vouloir quitter l'application ?", vbYesNo + vbDefaultButton2) 'affiche une msgBox pour confirmer que le joueur souhaite quitter l'application
        If Choix = vbYes Then
            If Settings.son Then
                seeYou.PlaySync() 'met un son pour indiquer la sortie du joueur, si le son est activé
            End If
            End
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        longueur = ComboBox1.Text.Length >= 3 'si le pseudo doit faire au moins 3 caractères
        If ComboBox1.Text <> "" Then
            pseudo_lb.Visible = False 'si la combobox a au moins un caractère le label disparaît
        Else
            pseudo_lb.Visible = True 'ajoute un label pour indiquer que la combobox doit contenir un pseudo
        End If
    End Sub

    Private Sub Jouer_btn_Click(sender As Object, e As EventArgs) Handles Jouer_btn.Click
        If longueur = True Then
            If Settings.son Then
                jouer.Play()
            End If
            Dim Jeu As New Memory() 'lance le jeu si la condition est respectée
            Jeu.Show()
        Else
            MsgBox("Le pseudo doit contenir au moins 3 caractères.") 'Si le pseudo fait moins de 3 caractères une Msg Box s'affiche
        End If
    End Sub

    Private Sub Score_btn_Click(sender As Object, e As EventArgs) Handles Score_btn.Click
        If Settings.son Then
            clic.Play()
        End If
        Dim Score As New Score()
        Score.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Param_pb.BackgroundImage = My.Resources.settings

        Jouer_btn.BackColor = Color.FromArgb(51, 154, 255)
        Jouer_btn.ForeColor = Color.White

        Quitter_btn.BackColor = Color.FromArgb(255, 99, 71)
        Quitter_btn.ForeColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Param_pb.Click
        If Settings.son Then
            clic.Play()
        End If
        Dim Param As New Parametres()
        Param.Show()
    End Sub

    Private Sub pseudo_lb_Click(sender As Object, e As EventArgs) Handles pseudo_lb.Click
        ComboBox1.Focus()
    End Sub

    Private Sub Param_lb_MouseEnter(sender As Object, e As EventArgs) Handles Param_pb.MouseEnter, Quitter_btn.MouseEnter, Jouer_btn.MouseEnter, Score_btn.MouseEnter
        sender.cursor = Cursors.Hand 'Si l'on rentre dans des zones cliquables, on change le curseur par défaut en main pour indiquer que c'est cliquable
    End Sub
    Private Sub ComboBox1_MouseEnter(sender As Object, e As EventArgs) Handles pseudo_lb.MouseEnter
        sender.cursor = Cursors.IBeam 'On change le curseur pour l'esthétisme et indiquer que c'est une box dans laquelle on peut écrire
    End Sub
End Class
