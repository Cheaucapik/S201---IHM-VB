Public Class Accueil

    Dim longueur As Boolean
    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click
        Dim Choix = MsgBox("Êtes-vous sûr de vouloir quitter l'application ?", vbYesNo + vbDefaultButton2)
        If Choix = vbYes Then
            End
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        longueur = ComboBox1.Text.Length >= 3
        If ComboBox1.Text <> "" Then
            pseudo_lb.Visible = False
        Else
            pseudo_lb.Visible = True
        End If
    End Sub

    Private Sub Jouer_btn_Click(sender As Object, e As EventArgs) Handles Jouer_btn.Click
        If longueur = True Then
            Dim Jeu As New Memory()
            Jeu.Show()
        Else
            MsgBox("Le pseudo doit contenir au moins 3 caractères.")
        End If
    End Sub

    Private Sub Score_btn_Click(sender As Object, e As EventArgs) Handles Score_btn.Click
        Dim Score As New Score()
        Score.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Param_pb.BackgroundImage = My.Resources.settings

        Jouer_btn.BackColor = Color.FromArgb(51, 154, 255)
        Jouer_btn.ForeColor = Color.White

        Quitter_btn.BackColor = Color.FromArgb(255, 99, 71)
        Quitter_btn.ForeColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Param_pb.Click
        Dim Param As New Paramètres()
        Param.Show()
    End Sub

    Private Sub pseudo_lb_Click(sender As Object, e As EventArgs) Handles pseudo_lb.Click
        ComboBox1.Focus()
    End Sub
End Class
