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


        public General ui = new General();
        aramoxiDB db = new aramoxiDB("");

        public Form1()
        {
            InitializeComponent();
        }

        private void import_Click(object sender, EventArgs e)
        {

            String archivo = "";
            int col;
            Boolean primero = true;
            int row;
            String Cabeceras = "";
            String info = "";
            Boolean primera = true;

            OpenFileDialog fd = new OpenFileDialog();

            fd.InitialDirectory = @"C:\";

            fd.Title = "Elija el fichero Excel";

            fd.Filter = "Excel(*.xls)|*.xls";

            ui.setIda("1");

            texto f2 = new texto(1);
            var result = f2.ShowDialog();

            if(result == DialogResult.OK) {
                db.OpenDB(f2.ReturnValue1);
            
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

                            if (index > 1)
                            {

                                db.addnew();
                            
                            }

                            for (int index2 = 1; index2<= col-6;index2 ++)
                            {

                                if(index == 1)
                                {
                                    if (primero)
                                    {

                                        Cabeceras = Cabeceras + index2 + "|" + sheet.Cells[index,index2].Value  ;

                                        primero = false;

                                    }
                                    else
                                    {

                                        Cabeceras = Cabeceras + "€" + index2 + "|" + sheet.Cells[index, index2].Value ;

                                    }

                                }
                                else
                                {

                                    db.add(index2, Convert.ToString(sheet.Cells[index,index2].Value));  

                                }

                            }

                            if(index== 1)
                            {

                                db.CrearCabeceras(Cabeceras);

                            }
                            else
                            {

                                db.update();

                            }

                        }

                    }


                }
                db.closedb();
            }
        }
    }
}
