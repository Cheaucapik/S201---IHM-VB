Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Module Settings

    Public difficulté As Integer = 2
    Public temps As Integer = 60
    Public son As Boolean = True
    Public sombre As Boolean = False

    Sub charge(f As Parametres)
        Select Case difficulté
            Case 1
                f.RadioButton1.Checked = True
            Case 2
                f.RadioButton2.Checked = True
            Case 3
                f.RadioButton3.Checked = True
        End Select

        f.Temps_tb.Text = temps.ToString()

        f.CheckBox1.Checked = sombre

        f.CheckBox2.Checked = son
    End Sub

    Sub sauvegarde(f As Parametres)

        Select Case True
            Case f.RadioButton1.Checked
                difficulté = 1
            Case f.RadioButton2.Checked
                difficulté = 2
            Case Else
                difficulté = 3
        End Select

        If CInt(f.Temps_tb.Text) >= 30 Then
            temps = CInt(f.Temps_tb.Text)
        Else
            MsgBox("Veuillez saisir un temps supérieur à 30 secondes.")
        End If

        If f.CheckBox1.Checked Then
            sombre = True
        Else
            sombre = False
        End If

        If f.CheckBox2.Checked Then
            son = True
        Else
            son = False
        End If

        MsgBox("Paramètres enregistrés.")

    End Sub


End Module
