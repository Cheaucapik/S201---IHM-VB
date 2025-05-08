Public Class Parametres
    Dim difficulté As String() = {"Facile", "Moyen", "Difficile"}
    Private Sub Paramètres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Difficulté_GB.Controls.Count - 1
            Difficulté_GB.Controls(i).Text = difficulté(i)
        Next i

        Settings.charge(Me)

        Retour_btn.BackColor = Color.FromArgb(255, 99, 71)
        Retour_btn.ForeColor = Color.White
        save_btn.BackColor = Color.FromArgb(51, 154, 255)
        save_btn.ForeColor = Color.White
    End Sub

    Private Sub RadioButton1_MouseEnter(sender As Object, e As EventArgs) Handles RadioButton1.MouseEnter, RadioButton2.MouseEnter, RadioButton3.MouseEnter, CheckBox1.MouseEnter, CheckBox2.MouseEnter, Retour_btn.MouseEnter
        sender.cursor = Cursors.Hand
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Settings.sauvegarde(Me)
    End Sub

    Private Sub Retour_btn_Click(sender As Object, e As EventArgs) Handles Retour_btn.Click
        Me.Close()
    End Sub
End Class