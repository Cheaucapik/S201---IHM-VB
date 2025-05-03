Module cartes

    Dim cartes As New List(Of Image)
    Dim cartesShuffled As New List(Of Image)
    Dim carré As Integer = 4
    Dim carteRetournée() As Boolean 
    Public Sub ajout(nbcartes As Integer, destination As Control)
        Dim nbCol As Integer = 5
        Dim nbRow As Integer = nbcartes / nbCol
        Dim marge As Integer = 5
        Dim largeur As Integer = 91
        Dim hauteur As Integer = 130

        ReDim carteRetournée(nbcartes)
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

            pb.Tag = i

            carteRetournée(i) = True

            destination.Controls.Add(pb)

            AddHandler pb.Click, AddressOf click
        Next i

    End Sub

    Public Sub cartes_ajout(nbcartes As Integer)
        cartes.Clear()
        cartesShuffled.Clear()
        Dim ncarré = nbcartes / carré
        For i As Integer = 0 To carré - 1
            cartes.Add(My.Resources.rossit)
            cartes.Add(My.Resources.poitrenaud)
            cartes.Add(My.Resources.fessy)
            cartes.Add(My.Resources.cantel)
            cartes.Add(My.Resources.paviot)
        Next

        Dim rnd As New Random()
        cartesShuffled = cartes.OrderBy(Function(x) rnd.Next()).ToList()
    End Sub

    Private Sub click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        Dim index As Integer = CInt(pb.Tag)

        If carteRetournée(index) = False Then
            pb.Image = My.Resources.dos_bleu
            carteRetournée(index) = True
        Else
            pb.Image = cartesShuffled(index)
            carteRetournée(index) = False
        End If
    End Sub

End Module
