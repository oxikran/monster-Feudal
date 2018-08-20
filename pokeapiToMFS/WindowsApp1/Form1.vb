Imports System.Windows.Forms.CommonDialog
Imports Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub apiBut_Click(sender As Object, e As EventArgs) Handles apiBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\Usuario\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|move_names.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        rutaApi.Text = dialog.FileName

    End Sub

    Private Sub ExcelBut_Click(sender As Object, e As EventArgs) Handles ExcelBut.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\Usuario\Source\Repos\aramoxidb\armoxiDB\armoxiDB\extra\MFS"

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

        dialog.InitialDirectory = "C:\Users\Usuario\Source\Repos\pokeapi\data\v2\csv"

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

        dialog.InitialDirectory = "C:\Users\Usuario\Source\Repos\pokeapi\data\v2\csv"

        dialog.Filter = "csv|move_flag_map.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        eternoText.Text = dialog.FileName

    End Sub
End Class
