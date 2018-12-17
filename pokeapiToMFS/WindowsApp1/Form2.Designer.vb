<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PokemonText = New System.Windows.Forms.TextBox()
        Me.StatsText = New System.Windows.Forms.TextBox()
        Me.pokButton = New System.Windows.Forms.Button()
        Me.StatButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "pokemons"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "stats"
        '
        'PokemonText
        '
        Me.PokemonText.Location = New System.Drawing.Point(61, 2)
        Me.PokemonText.Name = "PokemonText"
        Me.PokemonText.Size = New System.Drawing.Size(548, 20)
        Me.PokemonText.TabIndex = 2
        '
        'StatsText
        '
        Me.StatsText.Location = New System.Drawing.Point(61, 28)
        Me.StatsText.Name = "StatsText"
        Me.StatsText.Size = New System.Drawing.Size(548, 20)
        Me.StatsText.TabIndex = 3
        '
        'pokButton
        '
        Me.pokButton.Location = New System.Drawing.Point(615, 2)
        Me.pokButton.Name = "pokButton"
        Me.pokButton.Size = New System.Drawing.Size(17, 23)
        Me.pokButton.TabIndex = 4
        Me.pokButton.Text = "?"
        Me.pokButton.UseVisualStyleBackColor = True
        '
        'StatButton
        '
        Me.StatButton.Location = New System.Drawing.Point(615, 28)
        Me.StatButton.Name = "StatButton"
        Me.StatButton.Size = New System.Drawing.Size(17, 23)
        Me.StatButton.TabIndex = 5
        Me.StatButton.Text = "?"
        Me.StatButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(615, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(17, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(548, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Excel Poke"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(645, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 65)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Reemplazar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatButton)
        Me.Controls.Add(Me.pokButton)
        Me.Controls.Add(Me.StatsText)
        Me.Controls.Add(Me.PokemonText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PokemonText As TextBox
    Friend WithEvents StatsText As TextBox
    Friend WithEvents pokButton As Button
    Friend WithEvents StatButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
