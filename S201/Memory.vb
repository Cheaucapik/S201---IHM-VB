Imports System.Media

Public Class Memory
    Dim temps_restant As Integer
    Dim nbCarrés As Integer
    Dim nCarré As Integer
    Dim temps_écoulé As Integer
    Public temps_initial As Integer = paramJeu.temps
    Public pause As Boolean = False
    Dim succes As New SoundPlayer(My.Resources.successful)
    Dim clic As New SoundPlayer(My.Resources.click)
    Dim fail As New SoundPlayer(My.Resources.failure)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Visible = False 'bouton pour avancer la partie

        'définit le nb de carrés selon la difficulté

        If paramJeu.difficulté = 2 Then
            nbCarrés = 20
        ElseIf paramJeu.difficulté = 1 Then
            nbCarrés = 28
        Else
            nbCarrés = 12
        End If

        nCarré = nbCarrés / 4
        'On calcule le nombre de carrés à déterminer

        'On initialise les variables pour débuter le jeu
        temps_restant = temps_initial
        Jeu.score = 0

        'On lance le timer
        Timer1.Start()
        Timer.Text = temps_restant.ToString() + "s"
        Nom_Lab.Text = Accueil.ComboBox1.Text 'On affiche le pseudo selon ce que l'on a rentré précédemment
        Jeu.ajout(nbCarrés, Panel1) 'On ajoute les cartes au pannel

        'Esthétisme
        Abandonner_btn.BackColor = Color.FromArgb(255, 99, 71)
        Abandonner_btn.ForeColor = Color.White

        If paramJeu.sombre Then
            Settings.themeSombre(Me)
            pause_pb.Image = My.Resources.pause_blanc
        Else
            Settings.themeClair(Me)
            pause_pb.Image = My.Resources.pause
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temps_restant -= 1
        'Si le timer est inférieur à 10 on met le temps restant en rouge 
        If temps_restant <= 10 Then
            Timer.ForeColor = Color.Red
        End If
        If temps_restant = 0 Or Jeu.score = nCarré Then 'Le jeu est considéré comme fini si le timer atteint 0 ou que le score max est atteint
            Timer1.Stop()
            RemoveHandler Timer1.Tick, AddressOf Timer1_Tick
            temps_écoulé = temps_initial - temps_restant 'On définit le temps passé sur la partie
            If Jeu.score <> nCarré AndAlso paramJeu.son Then
                fail.Play()
            End If
            If Jeu.score = nCarré AndAlso paramJeu.son Then
                succes.Play()
            End If
            finPartie(Jeu.score, temps_écoulé) 'On affiche les résultats de la partie
            Me.Close()
            Enregistrement.Ajout(temps_écoulé)
        End If
        Timer.Text = temps_restant.ToString() + "s" 'On actualise à chaque tick le temps restant 
    End Sub

    Private Sub Abandonner_btn_Click(sender As Object, e As EventArgs) Handles Abandonner_btn.Click
        If paramJeu.son Then
            clic.Play()
        End If
        Dim choix = MsgBox("Êtes-vous sûr de vouloir arrêter le jeu ?", vbYesNo + vbDefaultButton2)
        If choix = vbYes Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Bouton avançant la partie
        temps_restant = 1
    End Sub

    Private Sub pause_pb_Click(sender As Object, e As EventArgs) Handles pause_pb.Click
        If paramJeu.son Then
            clic.Play()
        End If
        If pause = False Then
            Panel1.Enabled = False
            Timer1.Stop() 'On pause le timer quand on appuie sur pause
            pause = True
            If paramJeu.sombre Then
                pause_pb.Image = My.Resources.play_blanc
            Else
                pause_pb.Image = My.Resources.play
            End If
            Jeu.pause() 'retourne les cartes quand on met pause
        Else
            pause = False
            Timer1.Start()
            Panel1.Enabled = True
            If paramJeu.sombre Then
                pause_pb.Image = My.Resources.pause_blanc
            Else
                pause_pb.Image = My.Resources.pause
            End If
        End If

    End Sub

    Private Sub Abandonner_btn_MouseEnter(sender As Object, e As EventArgs) Handles Abandonner_btn.MouseEnter, pause_pb.MouseEnter
        sender.cursor = Cursors.Hand
    End Sub

End Class