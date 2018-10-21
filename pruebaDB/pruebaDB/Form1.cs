using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aramoxi_2._0;
using Microsoft.Office.Interop;


namespace pruebaDB
{
    public partial class Form1 : Form
    {

        aramoxiDB db;

        public Form1()
        {
            InitializeComponent();
        }

        private void import_Click(object sender, EventArgs e)
        {

            String archivo = "";
            OpenFileDialog fd = new OpenFileDialog();
            int col;
            int row;
            Boolean primera = true;


            fd.InitialDirectory = @"C:\";

            fd.Title = "Elija el fichero Excel";

            fd.Filter = "Excel(*.xls)|*.xls";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelobj = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook hoja;

                hoja = excelobj.Workbooks.Open(fd.FileName);

                foreach(Microsoft.Office.Interop.Excel.Worksheet sheet in hoja.Worksheets)
                {

                    Microsoft.Office.Interop.Excel.Range last = sheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                    col = last.Column;
                    row = last.Row;

                    for(int index = 1;index <= row;index++)
                    {

                        for (int index2 = 1; index<= col;index++)
                        {



                        }

                    }

                }


            }

        }
    }
}
