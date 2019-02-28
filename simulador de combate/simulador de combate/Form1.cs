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
    public partial class Form1 : Form
    {

        // stats (((2*Base*Nivel/100)+5)+IV+(EV/4))*Naturaleza
        //vida ((2*Base*Nivel)+Nivel+10)+IV+(EV/4)

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            rellenadatos form = new rellenadatos();

            form.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");
            pictureBox6.Image = Image.FromFile(@"C:\Users\oxikr\source\repos\pokeapi\data\v2\sprites\pokemon\1.png");

        }
    }
}
