Public Class Paramètres
    Public Tmps As String
    Dim difficulté As String() = {"Facile", "Moyen", "Difficile"}
    Dim formulaire As Form() = {Accueil, Me, Memory, Score}
    Private Sub Paramètres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Difficulté_GB.Controls.Count - 1
            Difficulté_GB.Controls(i).Text = difficulté(i)
        Next i
        RadioButton1.Checked = True
        RadioButton5.Checked = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        For Each f In formulaire
            If RadioButton4.Checked = True Then
                f.BackColor = Color.FromArgb(30, 30, 30)
                f.ForeColor = Color.White
            Else
                f.BackColor = Color.FromArgb(240, 240, 240)
                f.ForeColor = Color.Black
            End If
        Next
    End Sub

End Class