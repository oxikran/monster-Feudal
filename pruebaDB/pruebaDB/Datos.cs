using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace pruebaDB
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog OF = new OpenFileDialog();

            OF.Filter = "*.xlsx|*.xlsx";
            OF.ShowDialog();
            textBox1.Text = OF.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDB.LiteDatabase(@"Pokes.db"))
            {

                Microsoft.Office.Interop.Excel.Application obj;
                Microsoft.Office.Interop.Excel.Workbook hoja;
                Microsoft.Office.Interop.Excel.Worksheet Sheet;

                obj = new Microsoft.Office.Interop.Excel.Application();

                hoja = obj.Workbooks.Open(textBox1.Text);

                Sheet = (Microsoft.Office.Interop.Excel.Worksheet)hoja.ActiveSheet;

                var todo = db.GetCollection<pokemon>("pokemons");
                for (int index = 2; index < 89; index++)
                {
                    var pok = new pokemon
                    {

                        ID = Convert.ToString(Sheet.Cells[index, 2].Value),
                        NombrePok = Convert.ToString(Sheet.Cells[index, 1].Value),
                        HPpok = Convert.ToString(Sheet.Cells[index, 3].Value),
                        ATKpok = Convert.ToString(Sheet.Cells[index, 4].Value),
                        DEFpof = Convert.ToString(Sheet.Cells[index, 5].Value),
                        SATKpok = Convert.ToString(Sheet.Cells[index, 6].Value),
                        SDEFpok = Convert.ToString(Sheet.Cells[index, 7].Value),
                        VELpok = Convert.ToString(Sheet.Cells[index, 8].Value)
                    };
                    todo.Insert(pok);
                }
            }

            MessageBox.Show("Fin");

        }

        private void button3_Click(object sender, EventArgs e)
        {

           

            using (var db = new LiteDB.LiteDatabase(@"Pokes.db"))
            {
                var collection = db.GetCollection<pokemon>("pokemons");
                var pokemons = collection.Find(LiteDB.Query.EQ("NombrePok",textBox1.Text));//collection.FindById(textBox1.Text);
                
                foreach(var algo in pokemons)
                {

                    var loca = algo.ID;

                }



                var yo = "yo";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDB.LiteDatabase(@"Moves.db"))
            {

                Microsoft.Office.Interop.Excel.Application obj;
                Microsoft.Office.Interop.Excel.Workbook hoja;
                Microsoft.Office.Interop.Excel.Worksheet Sheet;

                obj = new Microsoft.Office.Interop.Excel.Application();

                hoja = obj.Workbooks.Open(textBox2.Text);

                Sheet = (Microsoft.Office.Interop.Excel.Worksheet)hoja.ActiveSheet;

                var todo = db.GetCollection<Moves>("Moves");
                for (int index = 2; index < 89; index++)
                {
                    var mov = new Moves
                    {

                        Id = Convert.ToInt64(Sheet.Cells[index, 1].Value),
                        Nombre = Convert.ToString(Sheet.Cells[index, 2].Value),
                        Tipo = Convert.ToString(Sheet.Cells[index, 3].Value),
                        Categoria = Convert.ToString(Sheet.Cells[index, 4].Value),
                        Damage = Convert.ToString(Sheet.Cells[index, 5].Value),
                        Potencia = Convert.ToString(Sheet.Cells[index, 6].Value),
                        Presicion = Convert.ToString(Sheet.Cells[index, 7].Value),
                        Estado = Convert.ToString(Sheet.Cells[index, 8].Value),
                        Provabilidad_Estado = Convert.ToInt64(Sheet.Cells[index, 9].Value),
                        PP_Min = Convert.ToInt64(Sheet.Cells[index, 10].Value),
                        PP_Max = Convert.ToInt64(Sheet.Cells[index, 11].Value),
                        Objetivo = Convert.ToString(Sheet.Cells[index, 12].Value),
                        Prioridad = Convert.ToInt64(Sheet.Cells[index, 13].Value),
                        Contacto = Convert.ToString(Sheet.Cells[index, 14].Value),
                        Min_Golpes = Convert.ToInt64(Sheet.Cells[index, 15].Value),
                        Max_Golpes = Convert.ToInt64(Sheet.Cells[index, 16].Value),
                        Min_turnos = Convert.ToInt64(Sheet.Cells[index, 17].Value),
                        Max_turnos = Convert.ToInt64(Sheet.Cells[index, 18].Value),
                        Drenado = Convert.ToInt64(Sheet.Cells[index, 19].Value),
                        Recuperacion_Vida = Convert.ToInt64(Sheet.Cells[index, 20].Value),
                        Critico = Convert.ToInt64(Sheet.Cells[index, 21].Value),
                        Retroceso = Convert.ToInt64(Sheet.Cells[index, 22].Value),
                        Stat = Convert.ToInt64(Sheet.Cells[index, 23].Value),
                        Descripcion_Menu = Convert.ToInt64(Sheet.Cells[index, 24].Value)

                    };
                    todo.Insert(mov);
                }
            }

            MessageBox.Show("Fin");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog OF = new OpenFileDialog();

            OF.Filter = "*.xlsx|*.xlsx";
            OF.ShowDialog();
            textBox2.Text = OF.FileName;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDB.LiteDatabase(@"Moves.db"))
            {
                var collection = db.GetCollection<Moves>("moves");
                var moves = collection.FindById(textBox2.Text);

                MessageBox.Show(moves.Nombre);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            OpenFileDialog OF = new OpenFileDialog();

            OF.Filter = "*.xlsx|*.xlsx";
            OF.ShowDialog();
            textBox3.Text = OF.FileName;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDB.LiteDatabase(@"Tipos.db"))
            {

                Microsoft.Office.Interop.Excel.Application obj;
                Microsoft.Office.Interop.Excel.Workbook hoja;
                Microsoft.Office.Interop.Excel.Worksheet Sheet;

                obj = new Microsoft.Office.Interop.Excel.Application();

                hoja = obj.Workbooks.Open(textBox2.Text);

                Sheet = (Microsoft.Office.Interop.Excel.Worksheet)hoja.ActiveSheet;

                var todo = db.GetCollection<tipos>("Tipos");
                for (int index = 2; index < 89; index++)
                {
                    var mov = new tipos
                    {

                        id = Convert.ToString(Sheet.Cells[index, 1].Value),
                        name = Convert.ToString(Sheet.Cells[index, 2].Value),
                        efectividades = Convert.ToString(Sheet.Cells[index,3].Value),
                        neutro = Convert.ToString(Sheet.Cells[index, 4].Value),
                        inmune = Convert.ToString(Sheet.Cells[index, 5].Value),
                        poco = Convert.ToString(Sheet.Cells[index, 6].Value)

                    };
                    todo.Insert(mov);
                }
            }

            MessageBox.Show("Fin");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDB.LiteDatabase(@"Tipos.db"))
            {
                var collection = db.GetCollection<tipos>("tipos");
                var types = collection.FindById(textBox3.Text);

                var salida = collection.Find(LiteDB.Query.GTE("Nombre", textBox3.Text));

                //MessageBox.Show(salida.);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.ShowDialog();

            textBox4.Text = dialog.SelectedPath + "\\" ;

        //Dim dialog As New FolderBrowserDialog

        //'dialog.RootFolder = "C:\Users\oxikr\Source\Repos\monster Feudal\DB"

        //dialog.ShowDialog()

        //CarpetaText.Text = dialog.SelectedPath & "\"

        }

        private void button12_Click(object sender, EventArgs e)
        {

            string[] archivos;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = new Microsoft.Office.Interop.Excel.Workbook();
            string[] aux;

            archivos = Directory.GetFiles(textBox4.Text);
             foreach(string archivo in archivos)
            {

                wb = Excel.Workbooks.Open(archivo);

                foreach(Worksheet sheet in wb.Worksheets)
                {

                    aux = archivo.Split(Convert.ToChar("\\"));

                    using (var db = new LiteDB.LiteDatabase(aux[aux.Length] + ".db")) {

                        var todo = db.GetCollection<aprendizage>("Apredizage");

                        for (int index = 2; index < 635569; index++){

                            if (sheet.Cells[index, 1].Value = "")
                            {

                                break;

                            };

                            var apr = new aprendizage
                            {

                                Id = index,
                                Move = sheet.Cells[index, 1].Value,
                                Como = sheet.Cells[index, 2].Value

                            };
                            todo.Insert(apr);

                        };

                    };
                };

            };


        }
    }
}
