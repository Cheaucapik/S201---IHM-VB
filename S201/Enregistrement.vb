Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Enregistrement

    Public listNom As New List(Of String)
    Public Structure Joueur
        Public Nom As String
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

    Sub Ajout(temps_écoulé As Integer)
        Dim n As String = Accueil.ComboBox1.Text
        Dim s As Integer = Jeu.score
        Dim r As Integer = temps_écoulé
        Dim np As Integer = 1
        Dim t As Integer = temps_écoulé
        Dim i As Integer = Verification(n)

        If (i >= 0) Then
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

        ReDim Preserve TJOUEUR(TJOUEUR.Length)
        TJOUEUR(TJOUEUR.Length - 1) = New Joueur(n, s, r, np, t)

        listNom.Clear()

        For j As Integer = 0 To TJOUEUR.Length - 1
            listNom.Add(TJOUEUR(j).Nom)
        Next

        Accueil.ComboBox1.Text = ""
        Accueil.ComboBox1.Items.Clear()
        For j As Integer = 0 To TJOUEUR.Length - 1
            Accueil.ComboBox1.Items.Add(TJOUEUR(j).Nom)
        Next

    End Sub
    Function Verification(n As String)
        For Each nom In listNom
            If n = nom.ToString() Then
                Return listNom.IndexOf(nom)
            End If
        Next
        Return -1
    End Function

End Module
