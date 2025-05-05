Imports System.Reflection.Emit

Public Class Memory
    Public temps_restant As Integer
    Dim nbCarrés = 20
    Dim nCarré = nbCarrés / 4
    Dim temps_écoulé As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temps_restant = 60
        Jeu.score = 0
        Me.FormBorderStyle = FormBorderStyle.Sizable

        Timer1.Start()
        Timer.Text = temps_restant.ToString()
        Nom_Lab.Text = Accueil.ComboBox1.Text
        Jeu.ajout(20, Panel1)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If temps_restant = 0 Or Jeu.score = nCarré Then
            Timer1.Stop()
            temps_écoulé = 60 - temps_restant
            finPartie(Jeu.score, temps_écoulé)
            Me.Close()
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
End Class