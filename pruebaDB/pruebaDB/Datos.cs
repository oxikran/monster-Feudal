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

            using(var db = new LiteDB.LiteDatabase(@"Pokes.db")) {

                Microsoft.Office.Interop.Excel.Application obj;
                Microsoft.Office.Interop.Excel.Workbook hoja;
                Microsoft.Office.Interop.Excel.Worksheet Sheet;

                obj = new Microsoft.Office.Interop.Excel.Application();

                hoja = obj.Workbooks.Open(textBox1.Text);

                Sheet = (Microsoft.Office.Interop.Excel.Worksheet)hoja.ActiveSheet;

                var todo = db.GetCollection<pokemon>("pokemons");
                for (int index = 2;index < 89; index++) { 
                    var pok = new pokemon {

                        ID = Convert.ToString(Sheet.Cells[index,2].Value),
                        NombrePok = Convert.ToString(Sheet.Cells[index, 1].Value),
                        HPpok= Convert.ToString(Sheet.Cells[index, 3].Value),
                        ATKpok = Convert.ToString(Sheet.Cells[index, 4].Value),
                        DEFpof = Convert.ToString(Sheet.Cells[index, 5].Value),
                        SATKpok= Convert.ToString(Sheet.Cells[index,6].Value),
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
                var pokemons = collection.FindById(textBox1.Text);
                
                MessageBox.Show(pokemons.NombrePok);
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
                    var pok = new Moves
                    {

                        Id = Convert.ToInt64(Sheet.Cells[index, 1].Value),
                        Nombre = Convert.ToString(Sheet.Cells[index, 2].Value),
                        Tipo = Convert.ToString(Sheet.Cells[index, 3].Value),
                        Categoria = Convert.ToString(Sheet.Cells[index, 4].Value)
                    };
                    todo.Insert(pok);
                }
            }

            MessageBox.Show("Fin");

            //public int Id { get; set; }
            //public string Nombre { get; set; }
            //public string Tipo { get; set; }
            //public string Categoria { get; set; }
            //public Boolean Damage { get; set; }
            //public string Potencia { get; set; }
            //public string Presicion { get; set; }
            //public string Estado { get; set; }
            //public int Provabilidad_Estado { get; set; }
            //public int PP_Min { get; set; }
            //public int PP_Max { get; set; }
            //public string Objetivo { get; set; }
            //public int Prioridad { get; set; }
            //public Boolean Contacto { get; set; }
            //public int Min_Golpes { get; set; }
            //public int Max_Golpes { get; set; }
            //public int Min_turnos { get; set; }
            //public int Max_turnos { get; set; }
            //public int Drenado { get; set; }
            //public int Recuperacion_Vida { get; set; }
            //public int Critico { get; set; }
            //public int Retroceso { get; set; }
            //public int Stat { get; set; }
            //public string Descripcion_Menu { get; set; }
        }
    }
}
