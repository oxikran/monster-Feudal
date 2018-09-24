Imports armoxiDB
Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub apiBut_Click(sender As Object, e As EventArgs) Handles apiBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|move_names.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        rutaApi.Text = dialog.FileName

    End Sub

    Private Sub ExcelBut_Click(sender As Object, e As EventArgs) Handles ExcelBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        dialog.Filter = "Excel|Lista de movimientos*.xlsx"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        excelText.Text = dialog.FileName

    End Sub

    Private Sub comenzarBut_Click(sender As Object, e As EventArgs) Handles comenzarBut.Click

        Dim excel As New Application
        Dim workbook As Workbook
        Dim data() As String
        Dim aux() As String
        Dim index As Long
        Dim index2 As Long
        index = 0
        index2 = 2

        data = My.Computer.FileSystem.ReadAllText(rutaApi.Text).Split(vbCrLf)
        workbook = excel.Workbooks.Open(excelText.Text)


        For Each sheet As Worksheet In workbook.Worksheets
            For index2 = 2 To 63559


                For index = 1 To data.Length - 2

                    aux = data(index).Split(",")

                    If UCase(aux(2).Trim) = UCase(Trim(sheet.Cells(index2, 2).Value)) Then

                        sheet.Cells(index2, 1) = aux(0)

                        Exit For

                    End If

                Next

                'index2 += 1

                If sheet.Cells(index2, 2).Value = "" Then

                    Exit For

                End If

            Next
        Next


        workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        MessageBox.Show("he acabado")

    End Sub

    Private Sub SeguirBut_Click(sender As Object, e As EventArgs) Handles SeguirBut.Click

        Dim excel As New Application
        Dim workbook As Workbook
        Dim data() As String
        Dim aux() As String
        Dim index As Long

        index = 0

        data = My.Computer.FileSystem.ReadAllText(movText.Text).Split(vbLf)
        workbook = excel.Workbooks.Open(excelText.Text)

        For Each sheet As Worksheet In workbook.Worksheets

            For index = 2 To 63359

                If sheet.Cells(index, 2).value = "" Then

                    Exit For

                End If

                aux = data(Replace(sheet.Cells(index, 1).value, vbLf, "")).Split(",")

                If aux.Length > 0 Then

                    sheet.Cells(index, 6) = aux(4)

                    sheet.Cells(index, 10) = aux(5)

                    sheet.Cells(index, 7) = aux(6)

                    sheet.Cells(index, 13) = aux(7)

                    sheet.Cells(index, 12) = aux(8)

                End If


            Next

        Next


        workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        MessageBox.Show("he acabado")

    End Sub

    Private Sub moviminetosBut_Click(sender As Object, e As EventArgs) Handles moviminetosBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|moves.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        movText.Text = dialog.FileName

    End Sub

    Private Sub terceraBut_Click(sender As Object, e As EventArgs) Handles terceraBut.Click

        '1,specific-move
        '2,selected-pokemon-me-first
        '3,ally
        '4,users-field
        '5,user-Or-ally
        '6,opponents-field
        '7,user
        '8,random-opponent
        '9,all-other-pokemon
        '10,selected-pokemon
        '11,all-opponents
        '12,entire-field
        '13,user-And-allies
        '14,all-pokemon

        Dim excel As New Application
        Dim workbook As Workbook
        Dim cambio(14) As String
        Dim index As Long

        cambio(1) = "E"
        cambio(2) = 1
        cambio(3) = "A"
        cambio(4) = "CU"
        cambio(5) = "UA"
        cambio(6) = "CR"
        cambio(7) = "U"
        cambio(8) = "R"
        cambio(9) = "AL"
        cambio(10) = "1"
        cambio(11) = "ALR"
        cambio(12) = "ALC"
        cambio(13) = "UA"
        cambio(14) = "ALU"


        workbook = excel.Workbooks.Open(excelText.Text)

        For Each sheet As Worksheet In workbook.Worksheets

            For index = 2 To 65539

                If sheet.Cells(index, 2).value = "" Then

                    Exit For

                End If

                sheet.Cells(index, 12) = cambio(sheet.Cells(index, 12).value)

            Next

        Next

        workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        MessageBox.Show("he acabado")
    End Sub

    Private Sub CuartaBut_Click(sender As Object, e As EventArgs) Handles CuartaBut.Click

        Dim excel As New Application
        Dim workbook As Workbook
        Dim index As Long
        Dim bool As Boolean
        Dim index2 As Long
        Dim aux() As String
        Dim datos() As String

        index = 0
        index2 = 0
        bool = False


        datos = decodifica()
        workbook = excel.Workbooks.Open(excelText.Text)

        For Each sheet As Worksheet In workbook.Worksheets

            For index = 2 To 65539

                If sheet.Cells(index, 2).Value = "" Then

                    Exit For

                End If

                aux = datos(sheet.Cells(index, 1).value).Split("|")

                For index2 = 0 To aux.Length - 1

                    If aux(index2) = "" Then

                        bool = False

                    ElseIf aux(index2) = 1 Then

                        bool = True

                        Exit For

                    Else

                        bool = False

                    End If

                Next

                If bool Then

                    sheet.Cells(index, 14) = "S"

                Else

                    sheet.Cells(index, 14) = "N"

                End If


            Next

        Next

        workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        MessageBox.Show("he acabado")

    End Sub

    Private Function decodifica() As String()

        Dim Output() As String
        Dim aux() As String
        Dim temp() As String
        Dim index As Long
        Dim index2 As Long
        Dim Separar As String
        index = 1
        index2 = 1

        Separar = ","

        aux = My.Computer.FileSystem.ReadAllText(eternoText.Text).Split(vbCr & vbLf)

        For index = 1 To 710

            For index2 = 1 To aux.LongLength

                temp = aux(index2).Split(",")

                If temp(0) = "" Then


                ElseIf temp(0).Replace(vbLf, "") = index Then

                    Separar = Separar & temp(1) & "|"

                    aux(index2) = ""

                Else

                    Separar = Separar & ","

                    Exit For

                End If

            Next

        Next

        Output = Separar.Split(",")

        Return Output

    End Function

    Private Sub EternoBut_Click(sender As Object, e As EventArgs) Handles EternoBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|move_flag_map.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        eternoText.Text = dialog.FileName

    End Sub

    Private Sub metaBut_Click(sender As Object, e As EventArgs) Handles metaBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|move_meta.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        metaText.Text = dialog.FileName

    End Sub

    Private Sub QuinBut_Click(sender As Object, e As EventArgs) Handles QuinBut.Click

        Dim excel As New Application
        Dim workbook As Workbook
        Dim data() As String
        Dim aux() As String
        Dim ailment(25) As String
        Dim critico(4) As Integer
        Dim index As Long

        data = My.Computer.FileSystem.ReadAllText(metaText.Text).Split(vbCrLf)

        critico(0) = 4
        critico(1) = 13
        critico(2) = 50
        critico(3) = 75
        critico(4) = 100

        ailment(0) = "" 'Nada
        ailment(1) = "PAR" 'Paralizado
        ailment(2) = "DOR" 'Dormido
        ailment(3) = "CON" 'Congelado
        ailment(4) = "QUE" 'Quemado
        ailment(5) = "VEN" 'Veneno
        ailment(6) = "PSY" 'Confuso
        ailment(7) = "ENA" 'Enamorado
        ailment(8) = "ATR" 'Atrapado
        ailment(9) = "PES" 'Pesadilla
        ailment(12) = "TOR" 'TILLA 'Tomento
        ailment(13) = "DES" 'Desactivasdo
        ailment(14) = "BOS" 'Bostezo
        ailment(15) = "NSC" 'No Se Cura
        ailment(17) = "NIT" 'No Inmunidad de Tipo
        ailment(18) = "DRE" 'Drenadoras
        ailment(19) = "EMB" 'Embargo
        ailment(20) = "CAM" 'Canto Mortal
        ailment(21) = "ARR" 'Arraigo
        ailment(24) = "SIL" 'Silencio
        ailment(25) = "ESP" 'en resumen los vagos de la pokeapi no lo han determinado

        workbook = excel.Workbooks.Open(excelText.Text)
        index = 0

        For Each sheet As Worksheet In workbook.Worksheets

            For index = 2 To 63559

                If sheet.Cells(index, 2).value = "" Then

                    Exit For

                End If

                If sheet.Cells(index, 1).value = Nothing Then

                    Stop

                Else
                    aux = data(sheet.Cells(index, 1).value).Split(",")

                    If aux(1) = 0 Or aux(1) = 4 Or aux(1) = 6 Or aux(1) = 7 Or aux(1) = 8 Then

                        sheet.Cells(index, 5) = "S"

                    Else

                        sheet.Cells(index, 5) = "N"

                    End If

                    If aux(2) = -1 Then

                        sheet.Cells(index, 8) = ailment(25)

                    Else

                        sheet.Cells(index, 8) = ailment(aux(2))

                    End If

                    If aux(3) = "" Then

                        sheet.Cells(index, 15) = 0

                    Else

                        sheet.Cells(index, 15) = aux(3)

                    End If

                    If aux(4) = "" Then

                        sheet.Cells(index, 16) = 0

                    Else

                        sheet.Cells(index, 16) = aux(4)

                    End If

                    If aux(5) = "" Then

                        sheet.Cells(index, 17) = 0

                    Else

                        sheet.Cells(index, 17) = aux(5)

                    End If

                    If aux(6) = "" Then

                        sheet.Cells(index, 18) = 0

                    Else

                        sheet.Cells(index, 18) = aux(6)

                    End If

                    If aux(7) = "" Then

                        sheet.Cells(index, 19) = 0

                    Else

                        sheet.Cells(index, 19) = aux(7)

                    End If

                    If aux(8) = "" Then

                        sheet.Cells(index, 20) = 0

                    Else

                        sheet.Cells(index, 20) = aux(8)

                    End If


                    If aux(9) > 4 Then

                        sheet.Cells(index, 21) = critico(4)

                    Else

                        sheet.Cells(index, 21) = critico(aux(9))

                    End If

                    If aux(10) = "" Then

                        sheet.Cells(index, 9) = 0

                    Else

                        sheet.Cells(index, 9) = aux(10)

                    End If

                    If aux(11) = "" Then

                        sheet.Cells(index, 22) = 0

                    Else

                        sheet.Cells(index, 22) = aux(11)

                    End If

                    If aux(12) = "" Then

                        sheet.Cells(index, 23) = 0

                    Else

                        sheet.Cells(index, 23) = aux(12)

                    End If

                End If

            Next

        Next


        workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        MessageBox.Show("he acabado")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim DB As New aramoxi
        Dim aux() As String
        Dim excel As New Application
        Dim index As Integer
        Dim index2 As Integer
        Dim x As Integer
        Dim workbook As Workbook

        index = 0
        index2 = 0
        x = 0

        workbook = excel.Workbooks.Open(excelText.Text)

        DB.createBD("C:\Users\oxikr\Source\Repos\monster Feudal\DB\final\", "moves")
        DB.OpenDB("C:\Users\oxikr\Source\Repos\monster Feudal\DB\final\moves")

        For Each Sheet As Worksheet In workbook.Worksheets

            For index = 1 To 63559

                If Sheet.Cells(1, index).value <> "" Then

                    aux = Sheet.Cells(1, index).value.Split("|")

                    DB.createindex(index - 1, aux(0), aux(1))

                Else

                    index2 = index

                    Exit For

                End If

            Next

            For index = 2 To 63559

                If Sheet.Cells(index, 2).value <> "" Then

                    For x = 1 To index2 - 1

                        DB.addData(x - 1, Sheet.Cells(index, x).value)

                    Next

                    DB.update()
                    DB.registrar()

                Else

                    Exit For

                End If

            Next

        Next

        'DB.createindex(0, "COD", 3)
        'DB.createindex(1, "Nombre", 30)
        'DB.createindex(2, "Tipo", 10)
        'DB.createindex(3, "Categoria", 8)

        'DB.addData(1, "100")
        'DB.addData(2, "algo")
        'DB.update()


        'workbook.Save()

        workbook.Close()
        workbook = Nothing

        excel.Workbooks.Close()
        excel = Nothing

        DB.movefirst()

        MessageBox.Show(DB.OxiField(1))


        DB.CloseDB()

    End Sub

    Private Sub PrimeButton_Click(sender As Object, e As EventArgs) Handles PrimeButton.Click

        Dim DB As New aramoxi

        'DB.createBD("C:\Users\oxikr\Source\Repos\monster Feudal\DB\final\", "moves")
        DB.OpenDB("C:\Users\oxikr\Source\Repos\monster Feudal\DB\final\moves")

        DB.movefirst()
        MessageBox.Show(DB.OxiField(0) & " , " & DB.OxiField(1))


    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        Dim DB As New aramoxi
        Dim index As Integer

        DB.OpenDB("C:\Users\oxikr\Source\Repos\monster-Feudal\DB\final\moves")

        DB.movefirst()

        For index = 0 To DB.recordCount - 1

            If UCase(Codigo.Text).Trim = UCase(DB.OxiField(0)).Trim Then

                Exit For

            Else

                DB.MoveNext()


            End If

        Next


        MsgBox(DB.OxiField(1))

        DB.CloseDB()

    End Sub

    Private Sub Carpeta_Click(sender As Object, e As EventArgs) Handles Carpeta.Click

        Dim dialog As New FolderBrowserDialog

        'dialog.RootFolder = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        dialog.ShowDialog()

        CarpetaText.Text = dialog.SelectedPath & "\"

    End Sub

    Private Sub reemplazo_Click(sender As Object, e As EventArgs) Handles reemplazo.Click

        Dim excel As New Application
        Dim excel2 As New Application
        Dim workbook As Workbook
        Dim wb2 As Workbook
        Dim existe As Boolean
        Dim data() As String
        Dim ids(374) As Integer
        Dim Files() As String
        Dim file As String
        Dim existen(374) As Boolean
        Dim movimientos(374) As String
        Dim index As Integer
        Dim pokemons As String
        Dim errores As String

        Files = Directory.GetFiles(CarpetaText.Text)

        wb2 = excel2.Workbooks.Open(excelText.Text)

        For Each sheet2 As Worksheet In wb2.Worksheets

            For index = 2 To 376

                movimientos(index - 2) = sheet2.Cells(index, 2).value
                existen(index - 2) = False
                ids(index - 2) = sheet2.Cells(index, 1).value

            Next

        Next

        wb2.Save()

        wb2.Close()
        wb2 = Nothing

        excel2.Workbooks.Close()

        For Each file In Files

            workbook = excel.Workbooks.Open(file)


            For Each sheet As Worksheet In workbook.Worksheets





                For index2 As Integer = 2 To 635569
                    If sheet.Cells(index2, 1).value = "" Then

                        Exit For
                    End If
                    For index3 As Integer = 0 To UBound(movimientos)

                        If UCase(movimientos(index3).Trim) = UCase(sheet.Cells(index2, 1).value.trim) Then
                            sheet.Cells(index2, 1) = ids(index3)
                            existe = True
                            existen(index3) = True
                            Exit For
                        End If
                    Next

                Next
            Next



            workbook.Save()

            workbook.Close()
            workbook = Nothing

            excel.Workbooks.Close()


        Next


        MsgBox("fin")

    End Sub

    Private Sub compBut_Click(sender As Object, e As EventArgs) Handles compBut.Click

        Dim excel As New Application
        Dim workbook As Workbook
        Dim file As String
        Dim files() As String
        Dim pokemons As String
        Dim existen(374) As Boolean
        Dim errores As String
        Dim movimientos(374) As String
        Dim sheet As Worksheet

        files = Directory.GetFiles(CarpetaText.Text)

        workbook = excel.Workbooks.Open(excelText.Text)

        sheet = workbook.ActiveSheet

        For index = 2 To 376

            movimientos(index - 2) = sheet.Cells(index, 1).value
            existen(index - 2) = False

        Next

        workbook.Close()

        For Each file In Files

            Workbook = excel.Workbooks.Open(file)

            For Each sheet2 As Worksheet In workbook.Worksheets

                For index2 As Integer = 0 To UBound(movimientos)
                    For index5 As Integer = 2 To 635569


                        If existen(index2) Then

                            Exit For

                        ElseIf sheet2.Cells(index5, 1).value = movimientos(index2) Then

                            existen(index2) = True

                        ElseIf sheet2.cells(index5, 1).value = Nothing Then

                            Exit For

                        End If

                    Next

                Next

            Next

            ''workbook.Save()

            workbook.Close()
            workbook = Nothing

            excel.Workbooks.Close()

        Next

        For index4 As Integer = 0 To UBound(existen)

            If Not existen(index4) Then

                errores = errores & movimientos(index4) & vbCrLf

            End If

        Next

        '''If pokemons.Trim <> "" Then

        '''    My.Computer.FileSystem.WriteAllText("C:\Users\oxikr\source\repos\monster-Feudal\DB\Tablas de aprendizaje de movimientos\Terminadas\erroresPokes.txt", pokemons, False)

        '''End If

        If errores.Trim <> "" Then

            My.Computer.FileSystem.WriteAllText("C:\Users\oxikr\source\repos\monster-Feudal\DB\Tablas de aprendizaje de movimientos\Terminadas\errores.txt", errores, False)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim DB As New aramoxi

        MsgBox(DB.kripto(""))

    End Sub
End Class
