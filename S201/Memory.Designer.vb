<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memory
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
        Me.components = New System.ComponentModel.Container()
        Me.Abandonner_btn = New System.Windows.Forms.Button()
        Me.Joueur_lab = New System.Windows.Forms.Label()
        Me.Nom_Lab = New System.Windows.Forms.Label()
        Me.Temps_Lab = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Abandonner_btn
        '
        Me.Abandonner_btn.Location = New System.Drawing.Point(429, 13)
        Me.Abandonner_btn.Name = "Abandonner_btn"
        Me.Abandonner_btn.Size = New System.Drawing.Size(75, 23)
        Me.Abandonner_btn.TabIndex = 0
        Me.Abandonner_btn.Text = "Abandonner"
        Me.Abandonner_btn.UseVisualStyleBackColor = True
        '
        'Joueur_lab
        '
        Me.Joueur_lab.AutoSize = True
        Me.Joueur_lab.Location = New System.Drawing.Point(23, 18)
        Me.Joueur_lab.Name = "Joueur_lab"
        Me.Joueur_lab.Size = New System.Drawing.Size(45, 13)
        Me.Joueur_lab.TabIndex = 1
        Me.Joueur_lab.Text = "Joueur :"
        '
        'Nom_Lab
        '
        Me.Nom_Lab.AutoSize = True
        Me.Nom_Lab.Location = New System.Drawing.Point(84, 18)
        Me.Nom_Lab.Name = "Nom_Lab"
        Me.Nom_Lab.Size = New System.Drawing.Size(39, 13)
        Me.Nom_Lab.TabIndex = 2
        Me.Nom_Lab.Text = "Joueur"
        '
        'Temps_Lab
        '
        Me.Temps_Lab.AutoSize = True
        Me.Temps_Lab.Location = New System.Drawing.Point(214, 18)
        Me.Temps_Lab.Name = "Temps_Lab"
        Me.Temps_Lab.Size = New System.Drawing.Size(83, 13)
        Me.Temps_Lab.TabIndex = 3
        Me.Temps_Lab.Text = "Temps restant : "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer
        '
        Me.Timer.AutoSize = True
        Me.Timer.Location = New System.Drawing.Point(303, 18)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(39, 13)
        Me.Timer.TabIndex = 4
        Me.Timer.Text = "Temps"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Location = New System.Drawing.Point(26, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 77)
        Me.Panel1.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(529, 189)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Temps_Lab)
        Me.Controls.Add(Me.Nom_Lab)
        Me.Controls.Add(Me.Joueur_lab)
        Me.Controls.Add(Me.Abandonner_btn)
        Me.Name = "Memory"
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Abandonner_btn As Button
    Friend WithEvents Joueur_lab As Label
    Friend WithEvents Nom_Lab As Label
    Friend WithEvents Temps_Lab As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
End Class
