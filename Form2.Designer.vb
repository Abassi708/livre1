﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst_isbn = New System.Windows.Forms.ListBox()
        Me.lst_titre = New System.Windows.Forms.ListBox()
        Me.lst_auteur = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(609, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Auteur"
        '
        'lst_isbn
        '
        Me.lst_isbn.FormattingEnabled = True
        Me.lst_isbn.ItemHeight = 16
        Me.lst_isbn.Location = New System.Drawing.Point(23, 113)
        Me.lst_isbn.Name = "lst_isbn"
        Me.lst_isbn.Size = New System.Drawing.Size(159, 340)
        Me.lst_isbn.TabIndex = 3
        '
        'lst_titre
        '
        Me.lst_titre.FormattingEnabled = True
        Me.lst_titre.ItemHeight = 16
        Me.lst_titre.Location = New System.Drawing.Point(295, 113)
        Me.lst_titre.Name = "lst_titre"
        Me.lst_titre.Size = New System.Drawing.Size(159, 340)
        Me.lst_titre.TabIndex = 4
        '
        'lst_auteur
        '
        Me.lst_auteur.FormattingEnabled = True
        Me.lst_auteur.ItemHeight = 16
        Me.lst_auteur.Location = New System.Drawing.Point(590, 113)
        Me.lst_auteur.Name = "lst_auteur"
        Me.lst_auteur.Size = New System.Drawing.Size(159, 340)
        Me.lst_auteur.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 542)
        Me.Controls.Add(Me.lst_auteur)
        Me.Controls.Add(Me.lst_titre)
        Me.Controls.Add(Me.lst_isbn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
End Class