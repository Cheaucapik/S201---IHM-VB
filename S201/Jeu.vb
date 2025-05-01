Imports System.Reflection.Emit

Public Class Jeu
    Dim temps_restant As Integer = 60
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer.Text = temps_restant.ToString()
        Carte_Lab.Image = Image.FromFile("img\dos-bleu.png")
        Nom_Lab.Text = Accueil.ComboBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If temps_restant > 0 Then
            temps_restant -= 1
            Timer.Text = temps_restant.ToString()
        End If
    End Sub

    Private Sub Abandonner_btn_Click(sender As Object, e As EventArgs) Handles Abandonner_btn.Click
        Dim choix = MsgBox("Êtes-vous sûr de vouloir arrêter le jeu ?", vbYesNo + vbDefaultButton2)
        If choix = vbYes Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class