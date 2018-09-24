using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aramoxi_2._0
{
    public class aramoxiDB
    {

        String[] archivoCargado;
        String Clave;

        public void OpenDB(String archivo){

            archivo = archivo + ".axdb";

            if (File.Exists(archivo ))
            {

                archivoCargado = File.ReadAllText(archivo).Split(Convert.ToChar("~"));

            }

        }

        private String kripto(String input)
        {

            String random = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ";
            String[] aleatorio = new string[random.Length -1];
            int x = 0;
            Random r = new Random();
            int lugar;


            foreach (char c in random)
            {

                aleatorio[x] = Convert.ToString(c);

                x += 1;

            }  
            
            for(x=0;x <= aleatorio.Length; x++)
            {

                lugar = r.Next(0, aleatorio.Length);

                if(aleatorio[lugar] != "~")
                {

                    Clave = Clave + aleatorio[lugar];

                }
                else
                {

                    for (int index = 0; index <= aleatorio.Length; index++)
                    {

                        if(aleatorio[index] != "~")
                        {

                            Clave = Clave + aleatorio[index];

                            break;

                        }

                    }

                }

            }

            return "";

        }

    }
}
