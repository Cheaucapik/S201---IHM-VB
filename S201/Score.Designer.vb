<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Nom_lb = New System.Windows.Forms.ListBox()
        Me.BestScore_lb = New System.Windows.Forms.ListBox()
        Me.Temps_lb = New System.Windows.Forms.ListBox()
        Me.NbPartie_lb = New System.Windows.Forms.ListBox()
        Me.TempsCumul_lb = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nom_lb
        '
        Me.Nom_lb.FormattingEnabled = True
        Me.Nom_lb.Location = New System.Drawing.Point(26, 84)
        Me.Nom_lb.Name = "Nom_lb"
        Me.Nom_lb.Size = New System.Drawing.Size(140, 251)
        Me.Nom_lb.TabIndex = 0
        '
        'BestScore_lb
        '
        Me.BestScore_lb.FormattingEnabled = True
        Me.BestScore_lb.Location = New System.Drawing.Point(201, 84)
        Me.BestScore_lb.Name = "BestScore_lb"
        Me.BestScore_lb.Size = New System.Drawing.Size(140, 251)
        Me.BestScore_lb.TabIndex = 1
        '
        'Temps_lb
        '
        Me.Temps_lb.FormattingEnabled = True
        Me.Temps_lb.Location = New System.Drawing.Point(378, 84)
        Me.Temps_lb.Name = "Temps_lb"
        Me.Temps_lb.Size = New System.Drawing.Size(140, 251)
        Me.Temps_lb.TabIndex = 2
        '
        'NbPartie_lb
        '
        Me.NbPartie_lb.FormattingEnabled = True
        Me.NbPartie_lb.Location = New System.Drawing.Point(567, 84)
        Me.NbPartie_lb.Name = "NbPartie_lb"
        Me.NbPartie_lb.Size = New System.Drawing.Size(140, 251)
        Me.NbPartie_lb.TabIndex = 3
        '
        'TempsCumul_lb
        '
        Me.TempsCumul_lb.FormattingEnabled = True
        Me.TempsCumul_lb.Location = New System.Drawing.Point(750, 84)
        Me.TempsCumul_lb.Name = "TempsCumul_lb"
        Me.TempsCumul_lb.Size = New System.Drawing.Size(140, 251)
        Me.TempsCumul_lb.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(564, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre de parties"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(747, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Temps Total"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TempsCumul_lb)
        Me.Controls.Add(Me.NbPartie_lb)
        Me.Controls.Add(Me.Temps_lb)
        Me.Controls.Add(Me.BestScore_lb)
        Me.Controls.Add(Me.Nom_lb)
        Me.Name = "Score"
        Me.Text = "Tableau des scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom_lb As ListBox
    Friend WithEvents BestScore_lb As ListBox
    Friend WithEvents Temps_lb As ListBox
    Friend WithEvents NbPartie_lb As ListBox
    Friend WithEvents TempsCumul_lb As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
