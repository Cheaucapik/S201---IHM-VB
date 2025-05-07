Public Class Accueil

    Dim longueur As Boolean
    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click
        Dim Choix = MsgBox("Êtes-vous sûr de vouloir quitter l'application ?", vbYesNo + vbDefaultButton2)
        If Choix = vbYes Then
            End
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        longueur = ComboBox1.Text.Length >= 3
    End Sub

    Private Sub Jouer_btn_Click(sender As Object, e As EventArgs) Handles Jouer_btn.Click
        If longueur = True Then
            Dim Jeu As New Memory()
            Jeu.Show()
        Else
            MsgBox("Veuillez sélectionner un élément avec au moins 3 caractères.")
        End If
    End Sub

    Private Sub Score_btn_Click(sender As Object, e As EventArgs) Handles Score_btn.Click
        Dim Score As New Score()
        Score.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Param_btn.Click
        Dim Param As New Paramètres()
        Param.Show()
    End Sub

End Class
