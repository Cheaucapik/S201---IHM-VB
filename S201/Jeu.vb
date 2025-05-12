Module Jeu
    Structure CartesInfo
        Dim cartes As Image
        Dim id As Integer
    End Structure

    Dim listCartes As New List(Of CartesInfo)
    Dim cartesShuffled As New List(Of CartesInfo)
    Dim carré As Integer = 4
    Dim cartesRetournées As New List(Of PictureBox)
    Dim attenteTimer As New Timer With {.Interval = 1000}
    Dim trouveTimer As New Timer With {.Interval = 300}
    Dim clickPoss As Boolean = True
    Public score As Integer = 0

    Public Sub ajout(nbcartes As Integer, destination As Control)
        Dim nbCol As Integer = 5
        Dim nbRow As Integer = nbcartes / nbCol
        Dim margeh As Integer = 10
        Dim margel As Integer = 30
        Dim largeur As Integer = 91
        Dim hauteur As Integer = 130

        cartes_ajout(nbcartes)

        For i As Integer = 0 To nbcartes - 1 'On crée nbCartes selon le niveau de difficulté choisi
            Dim pb As New PictureBox()
            'On définit la taille d'une Picture Box 
            pb.Width = largeur
            pb.Height = hauteur
            pb.Image = My.Resources.dos_bleu 'On attribue son dos de carte
            pb.SizeMode = PictureBoxSizeMode.StretchImage

            'On indique les coordonnées de la pictureBox
            Dim nRow = i \ nbCol
            Dim nCol = i Mod nbCol
            'On positionne la picture box selons ses coordonnées et ses marges (pour espacer les cartes entre elles)
            pb.Left = nCol * (pb.Width + margel)
            pb.Top = nRow * (pb.Height + margeh)

            pb.Tag = i 'On associe le tag d'une picture box à i donc chaque picture box est dans l'ordre

            'On ajoute la picture Box au panel1 du form Memory.vb
            destination.Controls.Add(pb)

            'On ajoute des handlers pour permettre au joueur de cliquer sur les cartes
            AddHandler pb.Click, AddressOf click
            AddHandler pb.MouseEnter, AddressOf curseur
        Next i

    End Sub

    Public Sub cartes_ajout(nbcartes As Integer)
        'On réinitialise le jeu entre chaque partie
        listCartes.Clear()
        cartesShuffled.Clear()

        'Selon le niveau de difficulté il va y avoir plus au moins de cartes

        If nbcartes = 20 Then
            For i As Integer = 0 To carré - 1
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.rossit, .id = 1})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.poitrenaud, .id = 2})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.cantel, .id = 3})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.fessy, .id = 4})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.paviot, .id = 5})
            Next
        ElseIf nbcartes = 12 Then
            For i As Integer = 0 To carré - 1
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.rossit, .id = 1})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.poitrenaud, .id = 2})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.cantel, .id = 3})
            Next
        Else
            For i As Integer = 0 To carré - 1
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.rossit, .id = 1})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.poitrenaud, .id = 2})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.cantel, .id = 3})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.fessy, .id = 4})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.paviot, .id = 5})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.mesatfa, .id = 6})
                listCartes.Add(New CartesInfo With {.cartes = My.Resources.darche, .id = 7})
            Next
        End If

        'On mélange les cartes de manière aléatoire, et on fait une nouvelle liste des cartes mélangées (ici seulement les images)
        Dim rnd As New Random()
        cartesShuffled = listCartes.OrderBy(Function(x) rnd.Next()).ToList()
    End Sub

    Private Sub click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox) 'On tranforme le sender en type pictureBox

        If cartesRetournées.Contains(pb) Then Exit Sub 'Si la carte est déjà retournée on ne peut pas cliquer pour éviter d'ajouter à chaque fois la même carte

        Dim index As Integer = CInt(pb.Tag) 'l'index est égal au tag d'une picture box, donc on sait quelle picture box est retournée


        If clickPoss = True Then
            pb.Image = cartesShuffled(index).cartes 'pour la picture box 1 on va avoir l'image associée
            cartesRetournées.Add(pb) 'On ajoute à la liste des picture Box retournées 
            vérifier() 'On vérifie les cartes retournées sont identiques
        Else
        End If

    End Sub

    Private Sub vérifier()
        If cartesRetournées.Count < 2 Then Exit Sub 'S'il y a moins de 2 picture box à comparer, on quitte le sub

        Dim identifiant As Integer = cartesShuffled(CInt(cartesRetournées(0).Tag)).id 'donne en premier l'index de la carte mélangée puis son id et on utilise son id pour comparer avec toutes les autres cartes
        Dim identiques As Boolean = True
        clickPoss = False 'On enlève la possibilité de cliquer sur toutes les cartes pendant la vérification

        For Each c In cartesRetournées 'Pour chaque cartes dans la liste de cartes retournées on vérifie si les id correspondent
            c.Enabled = False 'On enlève la possibilité de cliquer sur les cartes déjà retournées pour pas causer de bug et ajouter des cartes dans cette liste
            If identifiant <> cartesShuffled(CInt(c.Tag)).id Then 'si non, on a un timer d'une seconde
                AddHandler attenteTimer.Tick, AddressOf time
                attenteTimer.Start()
                identiques = False
            End If
        Next
        If identiques = True Then 'Si c'est identique on autorise le clic
            clickPoss = True
        End If
        If identiques = True AndAlso cartesRetournées.Count = carré Then 'Si 4 cartes sont identiques, on lance un timer de 300ms le temps de montrer au joueur qu'il a trouvé un carré
            AddHandler trouveTimer.Tick, AddressOf time2
            trouveTimer.Start()
            Memory.Panel1.Enabled = False 'On désactive tout le panel pour pas cliquer pendant ce lapse de temps
            clickPoss = False
        End If
    End Sub

    Private Sub time(sender As Object, e As EventArgs)
        For Each pb In cartesRetournées
            pb.Image = My.Resources.dos_bleu 'On retourne chaque carte au bout d'une seconde
            pb.Enabled = True 'On peut à nouveau cliquer 
        Next

        cartesRetournées.Clear()
        attenteTimer.Stop()
        RemoveHandler attenteTimer.Tick, AddressOf time

        clickPoss = True
    End Sub

    Private Sub time2(sender As Object, e As EventArgs)
        'On enlève la possiblité de voir les cartes trouvées
        For Each pb In cartesRetournées
            pb.Image = Nothing
            pb.Enabled = False
        Next
        trouveTimer.Stop()
        RemoveHandler trouveTimer.Tick, AddressOf time2
        Memory.Panel1.Enabled = True
        clickPoss = True
        cartesRetournées.Clear()
        score += 1 'On incrémente le score car un carré de trouvé
    End Sub

    Sub finPartie(s As Integer, t As Integer)
        MsgBox("Score : " & s & ". Temps : " & t & " secondes") 'Indique que la partie est finie
    End Sub

    Sub pause() 'Met le jeu en pause : on ne peut plus interagir avec les cartes 
        For Each pb In cartesRetournées
            pb.Image = My.Resources.dos_bleu 'On retourne les cartes pour éviter toute triche
            pb.Enabled = True 'On les met en enable true si l'on enlève la pause, on peut recliquer dessus
        Next
        cartesRetournées.Clear() 'On clear en conséquence les cartes retournées
    End Sub

    Sub curseur(sender As Object, e As EventArgs)
        sender.cursor = Cursors.Hand
    End Sub

End Module
