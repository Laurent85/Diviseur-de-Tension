<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Vin = New System.Windows.Forms.TextBox()
        Me.Vout = New System.Windows.Forms.TextBox()
        Me.Précision = New System.Windows.Forms.ComboBox()
        Me.Tableau = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tableau1 = New System.Windows.Forms.RichTextBox()
        Me.Tableau2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vin
        '
        Me.Vin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Vin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vin.ForeColor = System.Drawing.Color.Red
        Me.Vin.Location = New System.Drawing.Point(30, 102)
        Me.Vin.Name = "Vin"
        Me.Vin.Size = New System.Drawing.Size(44, 21)
        Me.Vin.TabIndex = 0
        Me.Vin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vout
        '
        Me.Vout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Vout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vout.ForeColor = System.Drawing.Color.Red
        Me.Vout.Location = New System.Drawing.Point(279, 211)
        Me.Vout.Name = "Vout"
        Me.Vout.Size = New System.Drawing.Size(44, 21)
        Me.Vout.TabIndex = 1
        Me.Vout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Précision
        '
        Me.Précision.FormattingEnabled = True
        Me.Précision.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.4", "0.5"})
        Me.Précision.Location = New System.Drawing.Point(552, 360)
        Me.Précision.Name = "Précision"
        Me.Précision.Size = New System.Drawing.Size(45, 21)
        Me.Précision.TabIndex = 5
        '
        'Tableau
        '
        Me.Tableau.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tableau.Location = New System.Drawing.Point(440, 93)
        Me.Tableau.Name = "Tableau"
        Me.Tableau.Size = New System.Drawing.Size(276, 261)
        Me.Tableau.TabIndex = 6
        Me.Tableau.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(530, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "à"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "volts près"
        '
        'Tableau1
        '
        Me.Tableau1.Location = New System.Drawing.Point(657, 13)
        Me.Tableau1.Name = "Tableau1"
        Me.Tableau1.Size = New System.Drawing.Size(72, 65)
        Me.Tableau1.TabIndex = 14
        Me.Tableau1.Text = ""
        Me.Tableau1.Visible = False
        '
        'Tableau2
        '
        Me.Tableau2.Location = New System.Drawing.Point(578, 12)
        Me.Tableau2.Name = "Tableau2"
        Me.Tableau2.Size = New System.Drawing.Size(73, 66)
        Me.Tableau2.TabIndex = 15
        Me.Tableau2.Text = ""
        Me.Tableau2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diviseur_de_tension.My.Resources.Resources.Diviseur
        Me.PictureBox1.Location = New System.Drawing.Point(12, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 314)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(230, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Le pont diviseur de tension"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(493, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Solutions possibles (série E24)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "V"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "V"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tableau2)
        Me.Controls.Add(Me.Tableau1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tableau)
        Me.Controls.Add(Me.Précision)
        Me.Controls.Add(Me.Vout)
        Me.Controls.Add(Me.Vin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Pont diviseur de tension"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vin As System.Windows.Forms.TextBox
    Friend WithEvents Vout As System.Windows.Forms.TextBox
    Friend WithEvents Précision As System.Windows.Forms.ComboBox
    Friend WithEvents Tableau As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tableau1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Tableau2 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
