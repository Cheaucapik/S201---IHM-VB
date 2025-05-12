Imports System.Media

Public Class Parametres
    Dim clic As New SoundPlayer(My.Resources.click)
    Dim difficulté As String() = {"Facile", "Moyen", "Difficile"}
    Private Sub Paramètres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Difficulté_GB.Controls.Count - 1
            Difficulté_GB.Controls(i).Text = difficulté(i) 'Affichage pour chaque radioButton
        Next i

        If sombre Then
            Settings.themeSombre(Me)
        Else
            Settings.themeClair(Me)
        End If

        Settings.charge(Me) 'On charge les paramètres mis

        Retour_btn.BackColor = Color.FromArgb(255, 99, 71)
        Retour_btn.ForeColor = Color.White
        save_btn.BackColor = Color.FromArgb(51, 154, 255)
        save_btn.ForeColor = Color.White
    End Sub

    Private Sub RadioButton1_MouseEnter(sender As Object, e As EventArgs) Handles RadioButton1.MouseEnter, RadioButton2.MouseEnter, RadioButton3.MouseEnter, CheckBox1.MouseEnter, CheckBox2.MouseEnter, Retour_btn.MouseEnter
        sender.cursor = Cursors.Hand
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click 'On sauvegarde les paramètres
        Settings.sauvegarde(Me)
        'Le thème sombre est appliqué aux forms déjà ouverts
        If Settings.sombre Then
            For Each f In Application.OpenForms
                Settings.themeSombre(f)
                Accueil.Param_pb.Image = My.Resources.settings_blanc
                If TypeOf f Is Memory Then
                    Dim memoryForm As Memory = CType(f, Memory)
                    If memoryForm.pause Then
                        memoryForm.pause_pb.Image = My.Resources.play_blanc
                    Else
                        memoryForm.pause_pb.Image = My.Resources.pause_blanc
                    End If
                End If
            Next
        Else
            For Each f In Application.OpenForms
                Settings.themeClair(f)
                Accueil.Param_pb.Image = My.Resources.settings
                If TypeOf f Is Memory Then
                    Dim memoryForm As Memory = CType(f, Memory)
                    If memoryForm.pause Then
                        memoryForm.pause_pb.Image = My.Resources.play
                    Else
                        memoryForm.pause_pb.Image = My.Resources.pause
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Retour_btn_Click(sender As Object, e As EventArgs) Handles Retour_btn.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, CheckBox1.Click, CheckBox2.Click, Retour_btn.Click
        If Settings.son Then
            clic.Play()
        End If
    End Sub
End Class