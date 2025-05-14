Imports System.IO
Imports System.Media

Module Settings
    Dim save As New SoundPlayer(My.Resources.done)
    Dim clic As New SoundPlayer(My.Resources.click)

    Public Structure param
        Public difficulté As Integer
        Public temps As Integer
        Public son As Boolean
        Public sombre As Boolean
    End Structure

    Public paramJeu As param

    Sub fichierSettings()
        If File.Exists("settings.dat") Then 'Si le fichier existe on le supprime pour en créer un autre, avec les nouveaux paramètres
            File.Delete("settings.dat")
        End If

        Dim num As Integer = FreeFile()
        FileOpen(num, "settings.dat", OpenMode.Random, , , Len(paramJeu))
        FilePut(num, paramJeu, 1)
        FileClose(num)
    End Sub

    Sub chargerParametres()
        If File.Exists("settings.dat") Then 'Charge les paramètres à chaque fois si le fichier existe sinon ca lance les paramètres de défaut
            Dim num As Integer = FreeFile()
            FileOpen(num, "settings.dat", OpenMode.Random, , , Len(paramJeu))
            FileGet(num, paramJeu, 1)
            FileClose(num)
        Else
            initialiserParametres()
        End If
    End Sub

    Sub initialiserParametres()
        paramJeu.temps = 60 'On initialise par des paramètres de défaut quand il n'y a pas de fichier
        paramJeu.difficulté = 2
        paramJeu.son = True
        paramJeu.sombre = False
    End Sub

    Sub charge(f As Parametres) 'Charge les paramètres avec les données dans la struct, pour l'affichade du form paramètres
        Select Case paramJeu.difficulté
            Case 1
                f.RadioButton1.Checked = True
            Case 2
                f.RadioButton2.Checked = True
            Case 3
                f.RadioButton3.Checked = True
        End Select

        f.Temps_tb.Text = paramJeu.temps.ToString()

        f.CheckBox1.Checked = paramJeu.sombre

        f.CheckBox2.Checked = paramJeu.son
    End Sub


    Sub sauvegarde(f As Parametres) 'On sauvegarde les paramètres quand on appuie sur le bouton
        If paramJeu.son Then
            save.Play()
        End If

        Select Case True 'On attribue une difficulté selon le radioButton coché
            Case f.RadioButton1.Checked
                paramJeu.difficulté = 1
            Case f.RadioButton2.Checked
                paramJeu.difficulté = 2
            Case Else
                paramJeu.difficulté = 3
        End Select

        If CInt(f.Temps_tb.Text) >= 30 Then
            paramJeu.temps = CInt(f.Temps_tb.Text) 'On définit un temps supérieur au moins à 30 secondes pour éviter des temps de partie trop minimals
        Else
            MsgBox("Veuillez saisir un temps supérieur à 30 secondes.")
            Exit Sub
        End If

        If f.CheckBox1.Checked Then 'Application du thème sombre ou non
            paramJeu.sombre = True
        Else
            paramJeu.sombre = False
        End If

        If f.CheckBox2.Checked Then 'Sons on ou off
            paramJeu.son = True
        Else
            paramJeu.son = False
        End If

        MsgBox("Paramètres enregistrés.")

    End Sub

    'Thèmes de couleur
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
