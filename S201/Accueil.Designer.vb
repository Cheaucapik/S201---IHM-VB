<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Jouer_btn = New System.Windows.Forms.Button()
        Me.Score_btn = New System.Windows.Forms.Button()
        Me.Quitter_btn = New System.Windows.Forms.Button()
        Me.Param_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Jouer_btn
        '
        Me.Jouer_btn.Location = New System.Drawing.Point(155, 115)
        Me.Jouer_btn.Name = "Jouer_btn"
        Me.Jouer_btn.Size = New System.Drawing.Size(75, 23)
        Me.Jouer_btn.TabIndex = 1
        Me.Jouer_btn.Text = "Jouer"
        Me.Jouer_btn.UseVisualStyleBackColor = True
        '
        'Score_btn
        '
        Me.Score_btn.Location = New System.Drawing.Point(155, 170)
        Me.Score_btn.Name = "Score_btn"
        Me.Score_btn.Size = New System.Drawing.Size(75, 23)
        Me.Score_btn.TabIndex = 2
        Me.Score_btn.Text = "Score"
        Me.Score_btn.UseVisualStyleBackColor = True
        '
        'Quitter_btn
        '
        Me.Quitter_btn.Location = New System.Drawing.Point(260, 170)
        Me.Quitter_btn.Name = "Quitter_btn"
        Me.Quitter_btn.Size = New System.Drawing.Size(75, 23)
        Me.Quitter_btn.TabIndex = 3
        Me.Quitter_btn.Text = "Quitter"
        Me.Quitter_btn.UseVisualStyleBackColor = True
        '
        'Param_btn
        '
        Me.Param_btn.Location = New System.Drawing.Point(54, 170)
        Me.Param_btn.Name = "Param_btn"
        Me.Param_btn.Size = New System.Drawing.Size(75, 23)
        Me.Param_btn.TabIndex = 4
        Me.Param_btn.Text = "Paramètres"
        Me.Param_btn.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 258)
        Me.Controls.Add(Me.Param_btn)
        Me.Controls.Add(Me.Quitter_btn)
        Me.Controls.Add(Me.Score_btn)
        Me.Controls.Add(Me.Jouer_btn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Jouer_btn As Button
    Friend WithEvents Score_btn As Button
    Friend WithEvents Quitter_btn As Button
    Friend WithEvents Param_btn As Button
End Class
