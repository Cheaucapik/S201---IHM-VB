Public Class Score
    Dim nom As String
    Dim score As Integer
    Dim record As Integer
    Dim nbPartie As Integer
    Dim temps As Integer
    Dim ordreScore As Boolean = True
    Dim ordreTempsRecord As Boolean = False
    Dim ordreNom As Boolean = True
    Dim ordrePartie As Boolean = True
    Dim ordreTempsTotal As Boolean = False

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
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        For j As Integer = 0 To TJOUEUR.Length - 1
            ComboBox1.Items.Add(TJOUEUR(j).Nom)
        Next

        OrderNom_btn.BackColor = Color.FromArgb(51, 154, 255)
        OrderNom_btn.ForeColor = Color.White

        OrderScore_btn.BackColor = Color.FromArgb(51, 154, 255)
        OrderScore_btn.ForeColor = Color.White

        OrderTempsRecord_btn.BackColor = Color.FromArgb(51, 154, 255)
        OrderTempsRecord_btn.ForeColor = Color.White

        OrderNbPartie_btn.BackColor = Color.FromArgb(51, 154, 255)
        OrderNbPartie_btn.ForeColor = Color.White

        OrderTempsTotal_btn.BackColor = Color.FromArgb(51, 154, 255)
        OrderTempsTotal_btn.ForeColor = Color.White

        Retour_btn.BackColor = Color.FromArgb(255, 99, 71)
        Retour_btn.ForeColor = Color.White
    End Sub

    Private Sub Nom_lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom_lb.SelectedIndexChanged, Temps_lb.SelectedIndexChanged, BestScore_lb.SelectedIndexChanged, TempsCumul_lb.SelectedIndexChanged, NbPartie_lb.SelectedIndexChanged
        Dim position As Integer = Nom_lb.SelectedIndex
        BestScore_lb.SelectedIndex = position
        TempsCumul_lb.SelectedIndex = position
        NbPartie_lb.SelectedIndex = position
        Temps_lb.SelectedIndex = position
        ComboBox1.Text = Nom_lb.Items(position)
    End Sub

    Private Sub OrderScore_btn_Click(sender As Object, e As EventArgs) Handles OrderScore_btn.Click
        If ordreScore = True Then
            ordreScore = False
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.Score).ThenBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordreScore = True
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Score).ThenBy(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderTemps_btn_Click(sender As Object, e As EventArgs) Handles OrderTempsRecord_btn.Click
        If ordreTempsRecord = True Then
            ordreTempsRecord = False
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.RecordTemps).ToArray()
        Else
            ordreTempsRecord = True
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.RecordTemps).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderNom_btn_Click(sender As Object, e As EventArgs) Handles OrderNom_btn.Click
        If ordreNom = True Then
            ordreNom = False
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.Nom).ToArray()
        Else
            ordreNom = True
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Nom).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrderNbPartie_btn_Click(sender As Object, e As EventArgs) Handles OrderNbPartie_btn.Click
        If ordrePartie = True Then
            ordrePartie = False
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.NbPartie).ToArray()
        Else
            ordrePartie = True
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.NbPartie).ToArray()
        End If
        afficher()
    End Sub

    Private Sub OrdreTempsTotal_btn_Click(sender As Object, e As EventArgs) Handles OrderTempsTotal_btn.Click
        If ordreTempsTotal = True Then
            ordreTempsTotal = False
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderBy(Function(j) j.Temps).ToArray()
        Else
            ordreTempsTotal = True
            Enregistrement.TJOUEUR = Enregistrement.TJOUEUR.OrderByDescending(Function(j) j.Temps).ToArray()
        End If
        afficher()
    End Sub



    Private Sub Retour_btn_Click(sender As Object, e As EventArgs) Handles Retour_btn.Click
        Me.Close()
    End Sub

    Private Sub OrderNom_btn_MouseEnter(sender As Object, e As EventArgs) Handles OrderNom_btn.MouseEnter, OrderNbPartie_btn.MouseEnter, OrderScore_btn.MouseEnter, OrderTempsRecord_btn.MouseEnter, OrderTempsTotal_btn.MouseEnter, Retour_btn.MouseEnter
        sender.cursor = Cursors.Hand
    End Sub

    Private Sub Nom_lb_MouseMove(sender As Object, e As MouseEventArgs) Handles Nom_lb.MouseMove
        Dim index As Integer = Nom_lb.IndexFromPoint(e.Location)

        If index >= 0 Then
            Nom_lb.Cursor = Cursors.Hand
        Else
            Nom_lb.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer = ComboBox1.SelectedIndex
        If index >= 0 Then
            MsgBox("📊 Statistiques" & vbCrLf & vbCrLf &
               "👤 Nom : " & Enregistrement.TJOUEUR(index).Nom & vbCrLf &
               "🏆 Meilleur Score : " & Enregistrement.TJOUEUR(index).Score & vbCrLf &
               "⏱️ Temps record : " & Enregistrement.TJOUEUR(index).RecordTemps & vbCrLf &
               "🎮 Nombre de parties : " & Enregistrement.TJOUEUR(index).NbPartie & vbCrLf &
               "🕒 Temps joué : " & Enregistrement.TJOUEUR(index).Temps)
        End If

    End Sub
End Class