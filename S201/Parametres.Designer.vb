<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parametres
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Difficulté_GB = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Temps_lb = New System.Windows.Forms.Label()
        Me.Temps_tb = New System.Windows.Forms.TextBox()
        Me.Retour_btn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Difficulté_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Difficulté_GB
        '
        Me.Difficulté_GB.Controls.Add(Me.RadioButton3)
        Me.Difficulté_GB.Controls.Add(Me.RadioButton2)
        Me.Difficulté_GB.Controls.Add(Me.RadioButton1)
        Me.Difficulté_GB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulté_GB.Location = New System.Drawing.Point(12, 69)
        Me.Difficulté_GB.Name = "Difficulté_GB"
        Me.Difficulté_GB.Size = New System.Drawing.Size(158, 135)
        Me.Difficulté_GB.TabIndex = 0
        Me.Difficulté_GB.TabStop = False
        Me.Difficulté_GB.Text = "Difficulté"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(15, 102)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(15, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(15, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "⚙️ PARAMETRES"
        '
        'Temps_lb
        '
        Me.Temps_lb.AutoSize = True
        Me.Temps_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temps_lb.Location = New System.Drawing.Point(247, 188)
        Me.Temps_lb.Name = "Temps_lb"
        Me.Temps_lb.Size = New System.Drawing.Size(49, 13)
        Me.Temps_lb.TabIndex = 7
        Me.Temps_lb.Text = "Temps : "
        '
        'Temps_tb
        '
        Me.Temps_tb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temps_tb.Location = New System.Drawing.Point(334, 182)
        Me.Temps_tb.Name = "Temps_tb"
        Me.Temps_tb.Size = New System.Drawing.Size(29, 22)
        Me.Temps_tb.TabIndex = 8
        '
        'Retour_btn
        '
        Me.Retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Retour_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour_btn.Location = New System.Drawing.Point(288, 225)
        Me.Retour_btn.Name = "Retour_btn"
        Me.Retour_btn.Size = New System.Drawing.Size(75, 31)
        Me.Retour_btn.TabIndex = 24
        Me.Retour_btn.Text = "Retour"
        Me.Retour_btn.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(250, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "Mode sombre"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(250, 121)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.Text = "Son"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(13, 225)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(111, 31)
        Me.save_btn.TabIndex = 27
        Me.save_btn.Text = "Sauvegarder"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(250, 154)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox3.TabIndex = 28
        Me.CheckBox3.Text = "Pause"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 273)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Retour_btn)
        Me.Controls.Add(Me.Temps_tb)
        Me.Controls.Add(Me.Temps_lb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Difficulté_GB)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Parametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.Difficulté_GB.ResumeLayout(False)
        Me.Difficulté_GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Difficulté_GB As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Temps_lb As Label
    Friend WithEvents Temps_tb As TextBox
    Friend WithEvents Retour_btn As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents save_btn As Button
    Friend WithEvents CheckBox3 As CheckBox
End Class
