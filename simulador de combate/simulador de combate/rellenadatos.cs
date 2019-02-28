using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador_de_combate
{
    public partial class rellenadatos : Form
    {
        public rellenadatos()
        {
            InitializeComponent();
        }

        private void rellenadatos_Load(object sender, EventArgs e)
        {

            ID.Visible = false;

            int index = 1;


            for(index =1; index<= 31; index++)
            {

                comboBox2.Items.Add(index);
                comboBox3.Items.Add(index);
                comboBox4.Items.Add(index);
                comboBox5.Items.Add(index);
                comboBox6.Items.Add(index);
                comboBox7.Items.Add(index);

            }

            using (var db = new LiteDB.LiteDatabase(@"C:\DBS\Pokes.db"))
            {
                var collection = db.GetCollection<pokemon>("pokemons");
                var pokemons = collection.FindAll().OrderBy(x=> x.NombrePok);//Find(LiteDB.Query.EQ("NombrePok", textBox1.Text));//collection.FindById(textBox1.Text);

                foreach (var algo in pokemons)
                {

                    comboBox1.Items.Add(algo.NombrePok);

                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox1.Text;

            using (var db = new LiteDB.LiteDatabase(@"C:\DBS\Pokes.db"))
            {
                var collection = db.GetCollection<pokemon>("pokemons");
                var pokemons = collection.Find(LiteDB.Query.EQ("NombrePok", textBox1.Text));//collection.FindById(textBox1.Text);

                foreach (var algo in pokemons)
                {

                    textBox3.Text = algo.HPpok;
                    textBox4.Text = algo.ATKpok;
                    textBox5.Text = algo.DEFpof;
                    textBox6.Text = algo.SATKpok;
                    textBox7.Text = algo.SDEFpok;
                    textBox8.Text = algo.VELpok;
                    if (checkBox1.Checked)
                    {

                        pictureBox1.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\shiny\" + algo.ID + ".png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\" + algo.ID + ".png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    ID.Text = algo.ID;

                }

                

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\shiny\" + ID.Text + ".png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {

                pictureBox1.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\" + ID.Text + ".png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
