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

        public void OpenDB(String archivo)
        {

            archivo = archivo + ".axdb";

            if (File.Exists(archivo))
            {

                archivoCargado = File.ReadAllText(archivo).Split(Convert.ToChar("~"));

            }

        }

        private String kripto(String input)
        {

            String random = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ ";
            String[] abecedario = new string[random.Length - 1];
            string output = "";
            int x = 0;


            foreach (char c in random)
            {

                abecedario[x] = Convert.ToString(c);
                x += 1;

            }

            if(Clave == "")
            {

                generaClave(abecedario);

            }
               
            for(int index2 = 0; index2 <= input.Length -1; index2 ++)
            {

               for(int index3 = 0;index3 <= abecedario.Length; index3++)
                {

                    if(input.Substring(index2,1) == abecedario[index3])
                    {

                        output = output + Clave.Substring(index3, 1);

                        break;

                    }

                }

            }

            return output;

        }

        private void generaClave(string[] aleatorio)
        {

            int x = 0;
            Random r = new Random();
            int lugar;

            for (x = 0; x <= aleatorio.Length; x++)
            {

                lugar = r.Next(0, aleatorio.Length);

                if (aleatorio[lugar] != "~")
                {

                    Clave = Clave + aleatorio[lugar];

                }
                else
                {

                    for (int index = 0; index <= aleatorio.Length; index++)
                    {

                        if (aleatorio[index] != "~")
                        {

                            Clave = Clave + aleatorio[index];

                            break;

                        }

                    }

                }

            }
        }
    }
}
