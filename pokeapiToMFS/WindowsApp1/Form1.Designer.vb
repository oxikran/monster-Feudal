﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.rutaApi = New System.Windows.Forms.TextBox()
        Me.apiBut = New System.Windows.Forms.Button()
        Me.excelText = New System.Windows.Forms.TextBox()
        Me.ExcelBut = New System.Windows.Forms.Button()
        Me.comenzarBut = New System.Windows.Forms.Button()
        Me.movText = New System.Windows.Forms.TextBox()
        Me.moviminetosBut = New System.Windows.Forms.Button()
        Me.SeguirBut = New System.Windows.Forms.Button()
        Me.terceraBut = New System.Windows.Forms.Button()
        Me.CuartaBut = New System.Windows.Forms.Button()
        Me.eternoText = New System.Windows.Forms.TextBox()
        Me.EternoBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rutaApi
        '
        Me.rutaApi.Location = New System.Drawing.Point(28, 20)
        Me.rutaApi.Name = "rutaApi"
        Me.rutaApi.Size = New System.Drawing.Size(640, 22)
        Me.rutaApi.TabIndex = 0
        '
        'apiBut
        '
        Me.apiBut.Location = New System.Drawing.Point(674, 16)
        Me.apiBut.Name = "apiBut"
        Me.apiBut.Size = New System.Drawing.Size(24, 30)
        Me.apiBut.TabIndex = 1
        Me.apiBut.Text = "?"
        Me.apiBut.UseVisualStyleBackColor = True
        '
        'excelText
        '
        Me.excelText.Location = New System.Drawing.Point(28, 65)
        Me.excelText.Name = "excelText"
        Me.excelText.Size = New System.Drawing.Size(640, 22)
        Me.excelText.TabIndex = 2
        '
        'ExcelBut
        '
        Me.ExcelBut.Location = New System.Drawing.Point(674, 61)
        Me.ExcelBut.Name = "ExcelBut"
        Me.ExcelBut.Size = New System.Drawing.Size(24, 30)
        Me.ExcelBut.TabIndex = 3
        Me.ExcelBut.Text = "?"
        Me.ExcelBut.UseVisualStyleBackColor = True
        '
        'comenzarBut
        '
        Me.comenzarBut.Location = New System.Drawing.Point(28, 183)
        Me.comenzarBut.Name = "comenzarBut"
        Me.comenzarBut.Size = New System.Drawing.Size(360, 49)
        Me.comenzarBut.TabIndex = 4
        Me.comenzarBut.Text = "comenzar"
        Me.comenzarBut.UseVisualStyleBackColor = True
        '
        'movText
        '
        Me.movText.Location = New System.Drawing.Point(28, 109)
        Me.movText.Name = "movText"
        Me.movText.Size = New System.Drawing.Size(640, 22)
        Me.movText.TabIndex = 5
        '
        'moviminetosBut
        '
        Me.moviminetosBut.Location = New System.Drawing.Point(674, 109)
        Me.moviminetosBut.Name = "moviminetosBut"
        Me.moviminetosBut.Size = New System.Drawing.Size(24, 30)
        Me.moviminetosBut.TabIndex = 6
        Me.moviminetosBut.Text = "?"
        Me.moviminetosBut.UseVisualStyleBackColor = True
        '
        'SeguirBut
        '
        Me.SeguirBut.Location = New System.Drawing.Point(428, 183)
        Me.SeguirBut.Name = "SeguirBut"
        Me.SeguirBut.Size = New System.Drawing.Size(360, 49)
        Me.SeguirBut.TabIndex = 7
        Me.SeguirBut.Text = "Segunda Parte"
        Me.SeguirBut.UseVisualStyleBackColor = True
        '
        'terceraBut
        '
        Me.terceraBut.Location = New System.Drawing.Point(28, 238)
        Me.terceraBut.Name = "terceraBut"
        Me.terceraBut.Size = New System.Drawing.Size(360, 49)
        Me.terceraBut.TabIndex = 8
        Me.terceraBut.Text = "Tercera Parte"
        Me.terceraBut.UseVisualStyleBackColor = True
        '
        'CuartaBut
        '
        Me.CuartaBut.Location = New System.Drawing.Point(428, 238)
        Me.CuartaBut.Name = "CuartaBut"
        Me.CuartaBut.Size = New System.Drawing.Size(360, 49)
        Me.CuartaBut.TabIndex = 9
        Me.CuartaBut.Text = "Cuarta Parte"
        Me.CuartaBut.UseVisualStyleBackColor = True
        '
        'eternoText
        '
        Me.eternoText.Location = New System.Drawing.Point(28, 149)
        Me.eternoText.Name = "eternoText"
        Me.eternoText.Size = New System.Drawing.Size(640, 22)
        Me.eternoText.TabIndex = 10
        '
        'EternoBut
        '
        Me.EternoBut.Location = New System.Drawing.Point(674, 145)
        Me.EternoBut.Name = "EternoBut"
        Me.EternoBut.Size = New System.Drawing.Size(24, 30)
        Me.EternoBut.TabIndex = 11
        Me.EternoBut.Text = "?"
        Me.EternoBut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EternoBut)
        Me.Controls.Add(Me.eternoText)
        Me.Controls.Add(Me.CuartaBut)
        Me.Controls.Add(Me.terceraBut)
        Me.Controls.Add(Me.SeguirBut)
        Me.Controls.Add(Me.moviminetosBut)
        Me.Controls.Add(Me.movText)
        Me.Controls.Add(Me.comenzarBut)
        Me.Controls.Add(Me.ExcelBut)
        Me.Controls.Add(Me.excelText)
        Me.Controls.Add(Me.apiBut)
        Me.Controls.Add(Me.rutaApi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rutaApi As TextBox
    Friend WithEvents apiBut As Button
    Friend WithEvents excelText As TextBox
    Friend WithEvents ExcelBut As Button
    Friend WithEvents comenzarBut As Button
    Friend WithEvents movText As TextBox
    Friend WithEvents moviminetosBut As Button
    Friend WithEvents SeguirBut As Button
    Friend WithEvents terceraBut As Button
    Friend WithEvents CuartaBut As Button
    Friend WithEvents eternoText As TextBox
    Friend WithEvents EternoBut As Button
End Class
