Imports System.Media

Module Settings
    Dim save As New SoundPlayer(My.Resources.done)
    Dim clic As New SoundPlayer(My.Resources.click)

    Public difficulté As Integer = 2
    Public temps As Integer = 60
    Public son As Boolean = True
    Public sombre As Boolean = False

    Sub charge(f As Parametres) 'On définit les paramètres de défaut à la charge du formulaire ou ceux définis dans sauvegarde si le formulaire est rechargé
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
        If Settings.son Then
            save.Play()
        End If

        Select Case True 'On attribue une difficulté selon le radioButton coché
            Case f.RadioButton1.Checked
                difficulté = 1
            Case f.RadioButton2.Checked
                difficulté = 2
            Case Else
                difficulté = 3
        End Select

        If CInt(f.Temps_tb.Text) >= 30 Then
            temps = CInt(f.Temps_tb.Text) 'On définit un temps supérieur au moins à 30 secondes pour éviter des temps de partie trop minimals
        Else
            MsgBox("Veuillez saisir un temps supérieur à 30 secondes.")
            Exit Sub
        End If

        If f.CheckBox1.Checked Then 'Application du thème sombre ou non
            sombre = True
        Else
            sombre = False
        End If

        If f.CheckBox2.Checked Then 'Sons on ou off
            son = True
        Else
            son = False
        End If

        MsgBox("Paramètres enregistrés.")

    End Sub

    Sub themeSombre(f As Form)
        f.BackColor = Color.FromArgb(44, 47, 51)

        For Each ctrl As Control In f.Controls
            If TypeOf ctrl Is ListBox Then
                ctrl.BackColor = Color.FromArgb(64, 68, 75)
                ctrl.ForeColor = Color.White
            ElseIf TypeOf ctrl Is Button Then
                If ctrl.ForeColor = Color.Black Then
                    ctrl.ForeColor = Color.FromArgb(244, 244, 244)
                    ctrl.BackColor = Color.FromArgb(64, 68, 75)
                End If
            ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is GroupBox Then
                ctrl.ForeColor = Color.White
                If ctrl.BackColor = Color.White Then
                    ctrl.BackColor = Color.FromArgb(64, 68, 75)
                End If
            ElseIf TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Then
                ctrl.BackColor = Color.FromArgb(64, 68, 75)
                ctrl.ForeColor = Color.White
            End If
        Next

    End Sub

    Sub themeClair(f As Form)
        f.BackColor = Color.FromArgb(245, 245, 245)

        For Each ctrl As Control In f.Controls
            If TypeOf ctrl Is ListBox Then
                ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
            ElseIf TypeOf ctrl Is Button Then
                If ctrl.ForeColor = Color.FromArgb(244, 244, 244) Then
                    ctrl.ForeColor = Color.Black
                    ctrl.BackColor = Color.White
                End If
            ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is GroupBox Then
                ctrl.ForeColor = Color.Black
                If ctrl.BackColor = Color.FromArgb(64, 68, 75) Then
                    ctrl.BackColor = Color.White
                End If
            ElseIf TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Then
                ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
            End If
        Next
    End Sub


End Module
