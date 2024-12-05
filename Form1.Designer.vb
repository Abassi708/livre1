<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_isbn = New System.Windows.Forms.TextBox()
        Me.txt_titre = New System.Windows.Forms.TextBox()
        Me.txt_auteur = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(62, 81)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 40)
        Me.label1.TabIndex = 0
        Me.label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Auteur"
        '
        'txt_isbn
        '
        Me.txt_isbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn.Location = New System.Drawing.Point(184, 84)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(209, 38)
        Me.txt_isbn.TabIndex = 3
        '
        'txt_titre
        '
        Me.txt_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titre.Location = New System.Drawing.Point(184, 199)
        Me.txt_titre.Name = "txt_titre"
        Me.txt_titre.Size = New System.Drawing.Size(209, 38)
        Me.txt_titre.TabIndex = 4
        '
        'txt_auteur
        '
        Me.txt_auteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auteur.Location = New System.Drawing.Point(184, 308)
        Me.txt_auteur.Name = "txt_auteur"
        Me.txt_auteur.Size = New System.Drawing.Size(209, 38)
        Me.txt_auteur.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(79, 426)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(147, 63)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_afficher
        '
        Me.btn_afficher.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_afficher.Location = New System.Drawing.Point(270, 426)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(147, 63)
        Me.btn_afficher.TabIndex = 7
        Me.btn_afficher.Text = "Afficher"
        Me.btn_afficher.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 529)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.txt_auteur)
        Me.Controls.Add(Me.txt_titre)
        Me.Controls.Add(Me.txt_isbn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
End Class
