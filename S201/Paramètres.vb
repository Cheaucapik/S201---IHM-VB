Public Class Paramètres
    Public Tmps As String
    Dim difficulté As String() = {"Facile", "Moyen", "Difficile"}
    Dim formulaire As Form() = {Accueil, Me, Memory, Score}
    Private Sub Paramètres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Difficulté_GB.Controls.Count - 1
            Difficulté_GB.Controls(i).Text = difficulté(i)
        Next i
        RadioButton1.Checked = True

    End Sub

End Class