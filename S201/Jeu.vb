Imports System.Reflection.Emit

Public Class Jeu
    Public temps_restant As Integer = 60

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MinimumSize = New Size(400, 300)

        Timer1.Start()
        Timer.Text = temps_restant.ToString()
        Nom_Lab.Text = Accueil.ComboBox1.Text
        Cartes.ajout(20, Panel1)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If temps_restant > 0 Then
            temps_restant -= 1
            Timer.Text = temps_restant.ToString()
        Else
            MsgBox("Votre temps est écoulé vous avez fait un score de : ", )
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