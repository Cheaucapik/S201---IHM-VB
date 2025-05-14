Imports System.IO
Imports System.Media

Module Enregistrement
    Dim nom As String
    Dim score As Integer
    Dim record As Integer
    Dim nbPartie As Integer
    Dim temps As Integer
    Dim clic As New SoundPlayer(My.Resources.click)
    Public Structure Joueur
        <VBFixedString(30)> Public Nom As String
        Public Score As Integer
        Public RecordTemps As Integer
        Public NbPartie As Integer
        Public Temps As Integer

        Public Sub New(n As String, s As Integer, r As Integer, np As Integer, t As Integer)
            Nom = n
            Score = s
            RecordTemps = r
            NbPartie = np
            Temps = t
        End Sub
    End Structure

    Public TJOUEUR() As Joueur = {}

    Sub afficher(f As Stat)
        'On clear tout ce qui se trouve dans les listBox pour pas rajouter des éléments en trop, tout cela de manière à mettre les données selon l'odre demandé
        f.Nom_lb.Items.Clear()
        f.BestScore_lb.Items.Clear()
        f.Temps_lb.Items.Clear()
        f.NbPartie_lb.Items.Clear()
        f.TempsCumul_lb.Items.Clear()

        'On ajoute les données à toutes les listBox pour chaque joueur 
        For i As Integer = 0 To TJOUEUR.Length - 1
            nom = TJOUEUR(i).Nom
            f.Nom_lb.Items.Add(nom)
            score = TJOUEUR(i).Score
            f.BestScore_lb.Items.Add(score)
            record = TJOUEUR(i).RecordTemps
            f.Temps_lb.Items.Add(record)
            nbPartie = TJOUEUR(i).NbPartie
            f.NbPartie_lb.Items.Add(nbPartie)
            temps = TJOUEUR(i).Temps
            f.TempsCumul_lb.Items.Add(temps)
        Next
    End Sub

    Sub Ajout(temps_écoulé As Integer)
        Dim n As String = Accueil.ComboBox1.Text.Trim()
        Dim s As Integer = Jeu.score
        Dim r As Integer = temps_écoulé
        Dim np As Integer = 1
        Dim t As Integer = temps_écoulé

        Dim i As Integer = Verification(n) 'On vérifie si le joueur existe déjà

        If (i >= 0) Then 'Si c'est positif c'est que le joueur existe déjà, il ne faut pas le rajouter, on modifie cependant ses statistiques, si nécessaire
            With TJOUEUR(i)
                .NbPartie += 1
                .Temps += temps_écoulé
                If s > .Score Then
                    .Score = s
                    .RecordTemps = r
                End If
                If s = .Score Then
                    If .RecordTemps > r Then
                        .RecordTemps = r
                    End If
                End If
            End With
            TJOUEUR(i) = TJOUEUR(i)
            Exit Sub
        End If

        ReDim Preserve TJOUEUR(TJOUEUR.Length) 'Si le joueur est nouveau on le rajoute dans le tableau TJOUEUR sans modifier les joueurs précédents et on rajoute +1 par rapport à la longueur du tableau
        TJOUEUR(TJOUEUR.Length - 1) = New Joueur(n, s, r, np, t) 'On ajoute le joueur selon des paramètres de défaut et son score

        Accueil.ComboBox1.Text = "" 'une fois la partie terminée on remet à 0 la comboBox de l'accueil, si un autre joueur veut jouer
        Accueil.ComboBox1.Items.Clear() 'On clear tous les items de comboBox pour éviter les doublons puis on les rajoute
        For j As Integer = 0 To TJOUEUR.Length - 1
            Accueil.ComboBox1.Items.Add(TJOUEUR(j).Nom)
        Next
    End Sub
    Function Verification(n As String) As Integer 'On vérifie si le nom existe déjà
        n = n.Trim() 'On enlève les espaces dûs à la mise dans un fichier
        For i As Integer = 0 To TJOUEUR.Length - 1
            If TJOUEUR(i).Nom.Trim() = n Then
                Return i
            End If
        Next
        Return -1
    End Function



    Sub fichier()
        If File.Exists("score.dat") Then 'Si le fichier existe on le supprime pour en créer un autre, avec les nouvelles statistiques
            File.Delete("score.dat")
        End If

        Dim num As Integer = FreeFile()
        FileOpen(num, "score.dat", OpenMode.Random, , , Len(New Joueur()))
        For i As Integer = 0 To TJOUEUR.Length - 1
            FilePut(num, TJOUEUR(i), i + 1) 'On met toutes les statistiques de TJOUEUR dans le fichier
        Next

        FileClose(num)
    End Sub

    Sub chargerFichier()
        Dim num As Integer = FreeFile()

        If File.Exists("score.dat") Then 'Si le fichier existe on prend les données
            FileOpen(num, "score.dat", OpenMode.Random, , , Len(New Joueur()))

            Dim TJOUEUR2() As Joueur = {} 'On crée un nouveau tableau où on va mettre toutes les nouvelles données
            Dim i As Integer = 0
            While Not EOF(num)
                Dim joueurTemp As New Joueur 'On passe par une variable temporaire
                FileGet(num, joueurTemp)
                ReDim Preserve TJOUEUR2(i) 'On ajoute au TJOUEUR2
                TJOUEUR2(i) = joueurTemp
                i += 1
            End While

            TJOUEUR = TJOUEUR2 'On affecte TJOUEUR avec les valeurs de TJOUEUR2, pour avoir les statistiques précédentes
            FileClose(num)

            'On ajoute aux ComboBox les noms en enlevant les espaces

            Accueil.ComboBox1.Items.Clear()
            Stat.ComboBox1.Items.Clear()

            For Each joueur In TJOUEUR
                Accueil.ComboBox1.Items.Add(joueur.Nom.Trim)
                Stat.ComboBox1.Items.Add(joueur.Nom.Trim)
            Next

        End If
    End Sub




End Module
