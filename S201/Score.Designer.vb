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
        Me.OrderNom_btn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OrderScore_btn = New System.Windows.Forms.Button()
        Me.OrderTempsRecord_btn = New System.Windows.Forms.Button()
        Me.OrderNbPartie_btn = New System.Windows.Forms.Button()
        Me.OrderTempsTotal_btn = New System.Windows.Forms.Button()
        Me.Retour_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nom_lb
        '
        Me.Nom_lb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom_lb.FormattingEnabled = True
        Me.Nom_lb.Location = New System.Drawing.Point(26, 141)
        Me.Nom_lb.Name = "Nom_lb"
        Me.Nom_lb.Size = New System.Drawing.Size(140, 182)
        Me.Nom_lb.TabIndex = 0
        '
        'BestScore_lb
        '
        Me.BestScore_lb.BackColor = System.Drawing.SystemColors.Window
        Me.BestScore_lb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BestScore_lb.FormattingEnabled = True
        Me.BestScore_lb.Location = New System.Drawing.Point(172, 141)
        Me.BestScore_lb.Name = "BestScore_lb"
        Me.BestScore_lb.Size = New System.Drawing.Size(140, 182)
        Me.BestScore_lb.TabIndex = 1
        '
        'Temps_lb
        '
        Me.Temps_lb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Temps_lb.FormattingEnabled = True
        Me.Temps_lb.Location = New System.Drawing.Point(318, 141)
        Me.Temps_lb.Name = "Temps_lb"
        Me.Temps_lb.Size = New System.Drawing.Size(140, 182)
        Me.Temps_lb.TabIndex = 2
        '
        'NbPartie_lb
        '
        Me.NbPartie_lb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NbPartie_lb.FormattingEnabled = True
        Me.NbPartie_lb.Location = New System.Drawing.Point(464, 141)
        Me.NbPartie_lb.Name = "NbPartie_lb"
        Me.NbPartie_lb.Size = New System.Drawing.Size(140, 182)
        Me.NbPartie_lb.TabIndex = 3
        '
        'TempsCumul_lb
        '
        Me.TempsCumul_lb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TempsCumul_lb.FormattingEnabled = True
        Me.TempsCumul_lb.Location = New System.Drawing.Point(610, 141)
        Me.TempsCumul_lb.Name = "TempsCumul_lb"
        Me.TempsCumul_lb.Size = New System.Drawing.Size(140, 182)
        Me.TempsCumul_lb.TabIndex = 4
        '
        'OrderNom_btn
        '
        Me.OrderNom_btn.BackColor = System.Drawing.SystemColors.Control
        Me.OrderNom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderNom_btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderNom_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OrderNom_btn.Location = New System.Drawing.Point(26, 112)
        Me.OrderNom_btn.Name = "OrderNom_btn"
        Me.OrderNom_btn.Size = New System.Drawing.Size(140, 23)
        Me.OrderNom_btn.TabIndex = 14
        Me.OrderNom_btn.Text = "Nom"
        Me.OrderNom_btn.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(218, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "🏆 TABLEAU DES SCORES"
        '
        'OrderScore_btn
        '
        Me.OrderScore_btn.BackColor = System.Drawing.Color.White
        Me.OrderScore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderScore_btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderScore_btn.Location = New System.Drawing.Point(172, 112)
        Me.OrderScore_btn.Name = "OrderScore_btn"
        Me.OrderScore_btn.Size = New System.Drawing.Size(140, 23)
        Me.OrderScore_btn.TabIndex = 19
        Me.OrderScore_btn.Text = "Score"
        Me.OrderScore_btn.UseVisualStyleBackColor = False
        '
        'OrderTempsRecord_btn
        '
        Me.OrderTempsRecord_btn.BackColor = System.Drawing.Color.White
        Me.OrderTempsRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderTempsRecord_btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTempsRecord_btn.Location = New System.Drawing.Point(318, 112)
        Me.OrderTempsRecord_btn.Name = "OrderTempsRecord_btn"
        Me.OrderTempsRecord_btn.Size = New System.Drawing.Size(140, 23)
        Me.OrderTempsRecord_btn.TabIndex = 20
        Me.OrderTempsRecord_btn.Text = "Temps"
        Me.OrderTempsRecord_btn.UseVisualStyleBackColor = False
        '
        'OrderNbPartie_btn
        '
        Me.OrderNbPartie_btn.BackColor = System.Drawing.Color.White
        Me.OrderNbPartie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderNbPartie_btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderNbPartie_btn.Location = New System.Drawing.Point(464, 112)
        Me.OrderNbPartie_btn.Name = "OrderNbPartie_btn"
        Me.OrderNbPartie_btn.Size = New System.Drawing.Size(140, 23)
        Me.OrderNbPartie_btn.TabIndex = 21
        Me.OrderNbPartie_btn.Text = "Nombre de parties"
        Me.OrderNbPartie_btn.UseVisualStyleBackColor = False
        '
        'OrderTempsTotal_btn
        '
        Me.OrderTempsTotal_btn.BackColor = System.Drawing.Color.White
        Me.OrderTempsTotal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderTempsTotal_btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTempsTotal_btn.Location = New System.Drawing.Point(610, 112)
        Me.OrderTempsTotal_btn.Name = "OrderTempsTotal_btn"
        Me.OrderTempsTotal_btn.Size = New System.Drawing.Size(140, 23)
        Me.OrderTempsTotal_btn.TabIndex = 22
        Me.OrderTempsTotal_btn.Text = "Temps total"
        Me.OrderTempsTotal_btn.UseVisualStyleBackColor = False
        '
        'Retour_btn
        '
        Me.Retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Retour_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour_btn.Location = New System.Drawing.Point(675, 341)
        Me.Retour_btn.Name = "Retour_btn"
        Me.Retour_btn.Size = New System.Drawing.Size(75, 31)
        Me.Retour_btn.TabIndex = 23
        Me.Retour_btn.Text = "Retour"
        Me.Retour_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(134, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 28)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "✅"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 384)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Retour_btn)
        Me.Controls.Add(Me.OrderTempsTotal_btn)
        Me.Controls.Add(Me.OrderNbPartie_btn)
        Me.Controls.Add(Me.OrderTempsRecord_btn)
        Me.Controls.Add(Me.OrderScore_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.OrderNom_btn)
        Me.Controls.Add(Me.TempsCumul_lb)
        Me.Controls.Add(Me.NbPartie_lb)
        Me.Controls.Add(Me.Temps_lb)
        Me.Controls.Add(Me.BestScore_lb)
        Me.Controls.Add(Me.Nom_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents OrderNom_btn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OrderScore_btn As Button
    Friend WithEvents OrderTempsRecord_btn As Button
    Friend WithEvents OrderNbPartie_btn As Button
    Friend WithEvents OrderTempsTotal_btn As Button
    Friend WithEvents Retour_btn As Button
    Friend WithEvents Button1 As Button
End Class
