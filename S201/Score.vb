Public Class Score
    Dim nom As String
    Dim score As Integer
    Dim record As Integer
    Dim nbPartie As Integer
    Dim temps As Integer
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Enregistrement.listNom.Count - 1
            nom = Enregistrement.TJOUEUR(i).Nom
            Nom_lb.Items.Add(nom)
            score = Enregistrement.TJOUEUR(i).Score
            BestScore_lb.Items.Add(score)
            record = Enregistrement.TJOUEUR(i).RecordTemps
            Temps_lb.Items.Add(record)
            nbPartie = Enregistrement.TJOUEUR(i).NbPartie
            NbPartie_lb.Items.Add(nbPartie)
            temps = Enregistrement.TJOUEUR(i).Temps
            TempsCumul_lb.Items.Add(temps)
        Next
    End Sub
End Class