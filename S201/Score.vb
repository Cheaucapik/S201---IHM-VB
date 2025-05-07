Public Class Score
    Dim nom As String
    Dim score As Integer
    Dim record As Integer
    Dim nbPartie As Integer
    Dim temps As Integer
    Dim ordreScore As Boolean = True
    Dim ordreTempsRecord As Boolean = True
    Dim ordreNom As Boolean = True
    Dim ordrePartie As Boolean = True
    Dim ordreTempsTotal As Boolean = True

    Private Sub afficher()
        Nom_lb.Items.Clear()
        BestScore_lb.Items.Clear()
        Temps_lb.Items.Clear()
        NbPartie_lb.Items.Clear()
        TempsCumul_lb.Items.Clear()

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
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Score).ThenBy(Function(j) j.RecordTemps).ToArray()
        afficher()
    End Sub

    Private Sub Nom_lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom_lb.SelectedIndexChanged, Temps_lb.SelectedIndexChanged, BestScore_lb.SelectedIndexChanged, TempsCumul_lb.SelectedIndexChanged, NbPartie_lb.SelectedIndexChanged
        Dim position As Integer = Nom_lb.SelectedIndex
        BestScore_lb.SelectedIndex = position
        TempsCumul_lb.SelectedIndex = position
        NbPartie_lb.SelectedIndex = position
        Temps_lb.SelectedIndex = position

    End Sub

    Private Sub OrderScore_btn_Click(sender As Object, e As EventArgs) Handles OrderScore_btn.Click
        If ordreScore = True Then
            ordreScore = False
            OrderScore_btn.Text = "Décroissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.Score).ThenBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordreScore = True
            OrderScore_btn.Text = "Croissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Score).ThenBy(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderTemps_btn_Click(sender As Object, e As EventArgs) Handles OrderTemps_btn.Click
        If ordreTempsRecord = True Then
            ordreTempsRecord = False
            OrderTemps_btn.Text = "Décroissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.RecordTemps).ThenBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordreTempsRecord = True
            OrderTemps_btn.Text = "Croissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.RecordTemps).ThenBy(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderNom_btn_Click(sender As Object, e As EventArgs) Handles OrderNom_btn.Click
        If ordreNom = True Then
            ordreNom = False
            OrderNom_btn.Text = "Décroissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.Nom).ThenBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordreNom = True
            OrderNom_btn.Text = "Croissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Nom).ThenBy(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderNbPartie_btn_Click(sender As Object, e As EventArgs) Handles OrderNbPartie_btn.Click
        If ordrePartie = True Then
            ordrePartie = False
            OrderNbPartie_btn.Text = "Décroissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.NbPartie).ThenBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordrePartie = True
            OrderNbPartie_btn.Text = "Croissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.NbPartie).ThenBy(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrdreTempsTotal_btn_Click(sender As Object, e As EventArgs) Handles OrderTempsTotal_btn.Click
        If ordreTempsTotal = True Then
            ordreTempsTotal = False
            OrderTempsTotal_btn.Text = "Décroissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.NbPartie).ThenBy(Function(j) j.Temps).ToArray()
        Else
            ordreTempsTotal = True
            OrderTempsTotal_btn.Text = "Croissant"
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.NbPartie).ThenBy(Function(j) j.Temps).ToArray()
        End If
        afficher()
    End Sub
End Class