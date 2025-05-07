Imports System.Reflection.Emit

Public Class Memory
    Dim temps_restant As Integer
    Dim nbCarrés As Integer = 20
    Dim nCarré As Integer = nbCarrés / 4
    Dim temps_écoulé As Integer
    Public temps_initial As Integer = 60

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temps_restant = temps_initial
        Jeu.score = 0

        Timer1.Start()
        Timer.Text = temps_restant.ToString()
        Nom_Lab.Text = Accueil.ComboBox1.Text
        Jeu.ajout(20, Panel1)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If temps_restant = 0 Or Jeu.score = nCarré Then
            Timer1.Stop()
            temps_écoulé = temps_initial - temps_restant
            finPartie(Jeu.score, temps_écoulé)
            Me.Close()
            Enregistrement.Ajout(temps_écoulé)
        End If
        temps_restant -= 1
        Timer.Text = temps_restant.ToString()
    End Sub

    Private Sub Abandonner_btn_Click(sender As Object, e As EventArgs) Handles Abandonner_btn.Click
        Dim choix = MsgBox("Êtes-vous sûr de vouloir arrêter le jeu ?", vbYesNo + vbDefaultButton2)
        If choix = vbYes Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temps_restant = 0
    End Sub
End Class