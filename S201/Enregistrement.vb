Module Enregistrement
    Private Structure Joueur
        Public Nom As String
        Public Score As Integer
        Public Record As Double
        Public NbPartie As Integer
        Public Temps As Double

        Public Sub New(Nom As String, Score As Integer, Record As Double, NbPartie As Integer, Temps As Double)
            Me.Nom = Nom
            Me.Score = Score
            Me.Record = Record
            Me.NbPartie = NbPartie
            Me.Temps = Temps
        End Sub
    End Structure

    Dim TJOUE As Joueur()

    Sub Ajout()

    End Sub

End Module
