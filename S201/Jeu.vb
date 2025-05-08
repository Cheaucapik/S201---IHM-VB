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
        Dim marge As Integer = 5
        Dim largeur As Integer = 91
        Dim hauteur As Integer = 130

        cartes_ajout(nbcartes)

        For i As Integer = 0 To nbcartes - 1
            Dim pb As New PictureBox()
            pb.Width = largeur
            pb.Height = hauteur
            pb.Image = My.Resources.dos_bleu
            pb.SizeMode = PictureBoxSizeMode.StretchImage

            Dim nRow = i \ nbCol
            Dim nCol = i Mod nbCol
            pb.Left = nCol * (pb.Width + marge)
            pb.Top = nRow * (pb.Height + marge)

            pb.Tag = i ' on associe une picture à un tag i donc cahque picture box est dans l'ordre

            destination.Controls.Add(pb)

            AddHandler pb.Click, AddressOf click
            AddHandler pb.MouseEnter, AddressOf curseur
        Next i

    End Sub

    Public Sub cartes_ajout(nbcartes As Integer)
        listCartes.Clear()
        cartesShuffled.Clear()

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

        Dim rnd As New Random()
        cartesShuffled = listCartes.OrderBy(Function(x) rnd.Next()).ToList() ' on mélange la liste pour que ce soit aléatoire
    End Sub

    Private Sub click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)

        If cartesRetournées.Contains(pb) Then Exit Sub

        Dim index As Integer = CInt(pb.Tag) ' l'index est égal au tag d'une picture box, donc on sait quelle picture box est retournée


        If clickPoss = True Then
            pb.Image = cartesShuffled(index).cartes ' pour la picture box 1 on va avoir l'image associée
            cartesRetournées.Add(pb)
            vérifier()
        Else
        End If

    End Sub

    Private Sub vérifier()
        If cartesRetournées.Count < 2 Then Exit Sub

        Dim identifiant As Integer = cartesShuffled(CInt(cartesRetournées(0).Tag)).id ' donne en premier l'index de la carte mélangée puis son id et on utilise son id
        Dim identiques As Boolean = True
        clickPoss = False

        For Each c In cartesRetournées
            c.Enabled = False
            If identifiant <> cartesShuffled(CInt(c.Tag)).id Then
                AddHandler attenteTimer.Tick, AddressOf time
                attenteTimer.Start()
                identiques = False
            End If
        Next
        If identiques = True Then
            clickPoss = True
        End If
        If identiques = True AndAlso cartesRetournées.Count = 4 Then
            AddHandler trouveTimer.Tick, AddressOf time2
            trouveTimer.Start()
            Memory.Panel1.Enabled = False
            clickPoss = False
        End If
    End Sub

    Private Sub time(sender As Object, e As EventArgs)
        For Each pb In cartesRetournées
            pb.Image = My.Resources.dos_bleu
            pb.Enabled = True
        Next

        cartesRetournées.Clear()
        attenteTimer.Stop()
        RemoveHandler attenteTimer.Tick, AddressOf time

        clickPoss = True
    End Sub

    Private Sub time2(sender As Object, e As EventArgs)
        For Each pb In cartesRetournées
            pb.Image = Nothing
            pb.Enabled = False
        Next
        trouveTimer.Stop()
        RemoveHandler trouveTimer.Tick, AddressOf time2
        Memory.Panel1.Enabled = True
        clickPoss = True
        cartesRetournées.Clear()
        score += 1
    End Sub

    Sub finPartie(s As Integer, t As Integer)
        MsgBox("Score : " & s & ". Temps : " & t & " secondes")
    End Sub

    Sub pause()
        For Each pb In cartesRetournées
            pb.Image = My.Resources.dos_bleu
            pb.Enabled = True
        Next
        cartesRetournées.Clear()
    End Sub

    Sub curseur(sender As Object, e As EventArgs)
        sender.cursor = Cursors.Hand
    End Sub

End Module
