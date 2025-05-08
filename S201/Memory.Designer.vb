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
        Me.pause_pb = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pause_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Abandonner_btn
        '
        Me.Abandonner_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abandonner_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abandonner_btn.Location = New System.Drawing.Point(398, 9)
        Me.Abandonner_btn.Name = "Abandonner_btn"
        Me.Abandonner_btn.Size = New System.Drawing.Size(106, 37)
        Me.Abandonner_btn.TabIndex = 0
        Me.Abandonner_btn.Text = "Abandonner"
        Me.Abandonner_btn.UseVisualStyleBackColor = True
        '
        'Joueur_lab
        '
        Me.Joueur_lab.AutoSize = True
        Me.Joueur_lab.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joueur_lab.Location = New System.Drawing.Point(23, 18)
        Me.Joueur_lab.Name = "Joueur_lab"
        Me.Joueur_lab.Size = New System.Drawing.Size(58, 17)
        Me.Joueur_lab.TabIndex = 1
        Me.Joueur_lab.Text = "Joueur :"
        '
        'Nom_Lab
        '
        Me.Nom_Lab.AutoSize = True
        Me.Nom_Lab.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_Lab.Location = New System.Drawing.Point(87, 18)
        Me.Nom_Lab.Name = "Nom_Lab"
        Me.Nom_Lab.Size = New System.Drawing.Size(47, 17)
        Me.Nom_Lab.TabIndex = 2
        Me.Nom_Lab.Text = "Joueur"
        '
        'Temps_Lab
        '
        Me.Temps_Lab.AutoSize = True
        Me.Temps_Lab.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temps_Lab.Location = New System.Drawing.Point(174, 19)
        Me.Temps_Lab.Name = "Temps_Lab"
        Me.Temps_Lab.Size = New System.Drawing.Size(107, 17)
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
        Me.Timer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer.Location = New System.Drawing.Point(287, 19)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(46, 17)
        Me.Timer.TabIndex = 4
        Me.Timer.Text = "Temps"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(26, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 329)
        Me.Panel1.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pause_pb
        '
        Me.pause_pb.Location = New System.Drawing.Point(348, 19)
        Me.pause_pb.Name = "pause_pb"
        Me.pause_pb.Size = New System.Drawing.Size(20, 20)
        Me.pause_pb.TabIndex = 8
        Me.pause_pb.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(529, 417)
        Me.Controls.Add(Me.pause_pb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Temps_Lab)
        Me.Controls.Add(Me.Nom_Lab)
        Me.Controls.Add(Me.Joueur_lab)
        Me.Controls.Add(Me.Abandonner_btn)
        Me.Name = "Memory"
        Me.Text = "Jeu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pause_pb, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pause_pb As PictureBox
    Friend WithEvents Button1 As Button
End Class
