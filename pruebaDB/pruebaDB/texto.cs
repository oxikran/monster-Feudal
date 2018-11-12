using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebaDB;

namespace pruebaDB
{
    public partial class texto : Form
    {
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        int AA;

        public texto(int arranque)
        {
            InitializeComponent();

            AA = arranque;
        }

        private void texto_Load(object sender, EventArgs e)
        {

            switch(AA){


                case 1:
                    Label1Id.Text = "Nombre BD:";
                    break;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.InitialDirectory = @"C:\";

            fd.Title = "Elija bd";

            fd.Filter = "AramoxiDb(*.axdb)|*.axdb";//"AramoxiDb(*.axdb)|*.axdb";

            fd.ShowDialog();

            textBox1.Text = fd.FileName;
        }
    }
}
