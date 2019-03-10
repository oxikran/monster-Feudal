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
        public int diferencia;

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

            comboBox2.Text = "1";
            comboBox3.Text = "1";
            comboBox4.Text = "1";
            comboBox5.Text = "1";
            comboBox6.Text = "1";
            comboBox7.Text = "1";

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

        private void EV1_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV1.Text) > 252)
                {

                    EV1.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV1.Text = Convert.ToString(Convert.ToInt32(EV1.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {

                    

                }
                else
                {
                    e.Handled = true;
                }
            }

            refrescaLabels();

        }

        private void EV2_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV2.Text) > 252)
                {

                    EV2.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV2.Text = Convert.ToString(Convert.ToInt32(EV2.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {

                    

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void EV3_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV3.Text) > 252)
                {

                    EV3.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV3.Text = Convert.ToString(Convert.ToInt32(EV3.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {

                   

                }
                else
                {
                    e.Handled = true;
                }
            }


        }

        private void EV4_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV4.Text) > 252)
                {

                    EV4.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV4.Text = Convert.ToString(Convert.ToInt32(EV4.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {

                   

                }
                else
                {
                    e.Handled = true;
                }
            }


        }

        private void EV5_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV5.Text) > 252)
                {

                    EV5.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV5.Text = Convert.ToString(Convert.ToInt32(EV5.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {
                    

                }
                else
                {
                    e.Handled = true;
                }
            }


        }

        private void EV6_Keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV6.Text) > 252)
                {

                    EV6.Text = "252";

                }

                if (revisaCuentas())
                {

                }
                else
                {
                    EV6.Text = Convert.ToString(Convert.ToInt32(EV6.Text) - diferencia);
                }

                SendKeys.Send("{TAB}");

            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {

                    

                }
                else
                {
                    e.Handled = true;
                }
            }


        }

        private bool revisaCuentas()
        {

            int primero=0;
            int segundo=0;
            int tercero=0;
            int cuarto=0;
            int quinto=0;
            int sexto=0;
            int total=0;
            int suma=0;
            bool respuesta = false;

            diferencia = 0;

            if (EV1.Text != "") {
            primero = Convert.ToInt32(EV1.Text);
            }
            if (EV2.Text != "")
            {
                segundo = Convert.ToInt32(EV2.Text);
            }
            if (EV3.Text != "")
            {
                tercero = Convert.ToInt32(EV3.Text);
            }
            if (EV4.Text != "")
            {
                cuarto = Convert.ToInt32(EV4.Text);
            }
            if (EV5.Text != "")
            {
                quinto = Convert.ToInt32(EV5.Text);
            }
            if (EV6.Text != "")
            {
                sexto = Convert.ToInt32(EV6.Text);
            }
            suma = primero + segundo + tercero + cuarto + quinto + sexto;

            total = 510;

            if(suma > total)
            {

                respuesta = false;
                diferencia = suma - total;

            }
            else
            {

                respuesta = true;

            }

            return respuesta;

        }

        private void text9_keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (Convert.ToInt32(EV5.Text) > 100)
                {

                    EV5.Text = "100";

                }


            }
            else
            {

                if (char.IsDigit(e.KeyChar))
                {


                }
                else
                {
                    e.Handled = true;
                }
            }

            refrescaLabels();
        }

        private void refrescaLabels()
        {
            ////textBox9.Text = "0";
            ////EV1.Text = "0";
            ////EV2.Text = "0";
            ////EV3.Text = "0";
            ////EV4.Text = "0";
            ////EV5.Text = "0";
            ////EV5.Text = "0";
            ////EV6.Text = "0";

            //(((2 * Base * Nivel / 100) + 5) + IV + (EV / 4)) * Naturaleza
            //((2*Base*Nivel)+Nivel+10)+IV+(EV/4)


        }


    }


}
