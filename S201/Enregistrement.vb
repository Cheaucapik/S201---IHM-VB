Module Enregistrement
    Private Structure Joueur
        Public Nom As String
        Public Score As Integer
        Public Record As Double
        Public NbPartie As Integer
        Public Temps As Double
    End Structure

    Dim listJoueur As New List(Of Joueur)

    Sub Ajout()
        listJoueur.Add(New Joueur With {.Nom = Accueil.ComboBox1.Text, .Score = Jeu.score, Record = , NbPartie = , Temps = })

    End Sub

End Module
