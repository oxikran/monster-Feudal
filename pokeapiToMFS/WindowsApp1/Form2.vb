Public Class Form2
    Private Sub pokButton_Click(sender As Object, e As EventArgs) Handles pokButton.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        dialog.Filter = "Excel|pok*.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        PokemonText.Text = dialog.FileName

    End Sub

    Private Sub StatButton_Click(sender As Object, e As EventArgs) Handles StatButton.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        dialog.Filter = "Excel|pok*.csv"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        StatsText.Text = dialog.FileName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        dialog.Filter = "Excel|pok*.xslx"

        dialog.RestoreDirectory = False

        dialog.ShowDialog()

        TextBox1.Text = dialog.FileName

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim pokemons As String()
        Dim ids As String()
        Dim nombres As String()
        Dim index As Long
        Dim index2 As Long
        Dim pokes As String
        Dim aux As String()
        Dim salida As String
        Dim stats As String()
        Dim resto As String()
        Dim bool As Boolean

        pokes = "Absol,Awabu,Bakabu,Mizubu,Barboach,Whiscash,Buizel,Floatzel,Deino,Zweilous,Hydreigon,Dratini,Dragonair,Dragonite(S),Drowzee,Hypno,Dunsparce,Duskull,Dusclops,Dusknoir,Electrike,Manectric,Elekid,Electabuzz,Electivire,Exeggcute,Exeggutor,Farfetch_d,Farfetch_d(SO),Farfetch_d(SI),Frillish(S),Jellicent(S),Gastly,Haunter,Gengar,Gligar,Gliscor,Growlithe,Arcanine,Heobi,Hekubi,Heakabi,Humanos,Kartana,Krabby,Krabby(S),Kingler,Kingler(S),Legendarios,Lickitung,Lickilicky,Litwick,Lampent,Chandelure(S),Lotad,Lombre,Ludicolo,Magby,Magmar(S),Magmortar(S),Magikarp(Todos),Gyarados,Gyarados(S),Mawile,Meowth,Persian,Misdreavus,Mismagius,Munchlax(S),Snorlax(S),Mundofantasmal,Munna(S),Musharna(S),Ondoha,Onjiga,Ondomori,Poochyena,Mightyena,Sawk,Sawk(S),Seedot,Nuzleaf,Shiftry,Seviper,Seviper(S),Shellos(S),Gastrodon(S),Shuppet,Banette,Slakoth,Vigoroth,Slaking,Slowpoke,Slowbro,Slowking,Smoochum,Jynx,Sneasel,Weavile,Snorunt,Glalie,Froslass,Spearow(S),Fearow(S),Spinarak,Ariados,Stantler,Stantler(S),Swablu,Altaria,Tauros,Tauros(S),Teddiursa(S),Ursaring(S),Throh,Throh(S),Venipede,Whirlipede,Scolipede,Scolipede(S),Vulpix,Ninetales,Wailmer(S),Wailord(S),Wooper,Quagsire,Zigzagoon,Linoone,Zorua,Zoroark"

        nombres = Split(pokes, ",")

        pokemons = Split(My.Computer.FileSystem.ReadAllText(PokemonText.Text), vbCrLf)

        stats = Split(My.Computer.FileSystem.ReadAllText(StatsText.Text), vbCrLf)

        ReDim ids(UBound(nombres))
        ReDim resto(UBound(nombres))

        For index = 1 To UBound(pokemons) - 1

            aux = pokemons(index).Split(",")

            For index2 = 0 To UBound(nombres)

                If aux(1).Trim.ToUpper = nombres(index2).Trim.ToUpper Then

                    ids(index2) = aux(0)

                End If

            Next

        Next

        For index = 0 To UBound(ids)

            For index2 = 1 To UBound(stats) - 1

                aux = stats(index2).Split(",")

                If aux(0) = ids(index) Then

                    bool = True

                    resto(index) = resto(index) & aux(2) & vbTab

                Else

                    If bool Then

                        Exit For

                    End If

                End If

            Next

            bool = False

        Next

        For index = 0 To UBound(nombres)

            salida = salida & nombres(index) & vbTab & ids(index) & vbTab & resto(index) & vbCrLf

        Next



        My.Computer.FileSystem.WriteAllText("C:\algo\excel.txt", salida, False)



        MessageBox.Show("he terminado mi señor")

    End Sub
End Class