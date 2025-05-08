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
        Me.Param_pb = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pseudo_lb = New System.Windows.Forms.Label()
        CType(Me.Param_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Jouer_btn
        '
        Me.Jouer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Jouer_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jouer_btn.Location = New System.Drawing.Point(131, 122)
        Me.Jouer_btn.Name = "Jouer_btn"
        Me.Jouer_btn.Size = New System.Drawing.Size(111, 29)
        Me.Jouer_btn.TabIndex = 1
        Me.Jouer_btn.Text = "Jouer"
        Me.Jouer_btn.UseVisualStyleBackColor = True
        '
        'Score_btn
        '
        Me.Score_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Score_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_btn.Location = New System.Drawing.Point(131, 157)
        Me.Score_btn.Name = "Score_btn"
        Me.Score_btn.Size = New System.Drawing.Size(111, 29)
        Me.Score_btn.TabIndex = 2
        Me.Score_btn.Text = "Score"
        Me.Score_btn.UseVisualStyleBackColor = True
        '
        'Quitter_btn
        '
        Me.Quitter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quitter_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Quitter_btn.Location = New System.Drawing.Point(132, 192)
        Me.Quitter_btn.Name = "Quitter_btn"
        Me.Quitter_btn.Size = New System.Drawing.Size(110, 29)
        Me.Quitter_btn.TabIndex = 3
        Me.Quitter_btn.Text = "Quitter"
        Me.Quitter_btn.UseVisualStyleBackColor = True
        '
        'Param_pb
        '
        Me.Param_pb.Location = New System.Drawing.Point(21, 19)
        Me.Param_pb.Name = "Param_pb"
        Me.Param_pb.Size = New System.Drawing.Size(30, 30)
        Me.Param_pb.TabIndex = 4
        Me.Param_pb.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MEMORY GAME"
        '
        'pseudo_lb
        '
        Me.pseudo_lb.AutoSize = True
        Me.pseudo_lb.BackColor = System.Drawing.Color.White
        Me.pseudo_lb.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pseudo_lb.Location = New System.Drawing.Point(162, 97)
        Me.pseudo_lb.Name = "pseudo_lb"
        Me.pseudo_lb.Size = New System.Drawing.Size(46, 15)
        Me.pseudo_lb.TabIndex = 6
        Me.pseudo_lb.Text = "Pseudo"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 258)
        Me.Controls.Add(Me.pseudo_lb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Param_pb)
        Me.Controls.Add(Me.Quitter_btn)
        Me.Controls.Add(Me.Score_btn)
        Me.Controls.Add(Me.Jouer_btn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        CType(Me.Param_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Jouer_btn As Button
    Friend WithEvents Score_btn As Button
    Friend WithEvents Quitter_btn As Button
    Friend WithEvents Param_pb As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pseudo_lb As Label
End Class
