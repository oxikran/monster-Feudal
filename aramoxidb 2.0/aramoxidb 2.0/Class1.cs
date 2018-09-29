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
        String ruta;

        public void OpenDB(String archivo)
        {


            archivo = archivo + ".axdb";

            ruta = separar(archivo);

            if (File.Exists(archivo))
            {

                archivoCargado = File.ReadAllText(archivo).Split(Convert.ToChar("~"));

                Clave = archivoCargado[0];

                File.WriteAllText(ruta + "Data.txt", archivoCargado[3]);
                File.WriteAllText(ruta + "Index.txt", archivoCargado[2]);
                File.WriteAllText(ruta + "cab.txt",archivoCargado[1]);

                Array.Clear(archivoCargado, 0, 4);

            }


        }

        public string find(int id)
        {

            archivoCargado = Unkripto(File.ReadAllText(ruta + "Index.txt")).Split(Convert.ToChar("€"));

            return "";

        }

        public String Unkripto(String input)
        {

            String orden = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ€ ";
            String[] abecedario = new string[Clave.Length];
            String output = "";
            int x = 0;
            int index = 0;

            foreach (char c in Clave)
            {

                abecedario[x] = Convert.ToString(c);
                x += 1;

            }

            x = 0;

            foreach (char d in input)
            {

                for (index = 0; index <= orden.Length; index++)
                {

                    if (Convert.ToString(d) == abecedario[index])
                    {

                        output += orden.Substring(index, 1);
                        break;

                    }

                }

            }

            return output;

        }


        public String getClave()
        {

            return Clave;

        }

        public String kripto(String input)
        {

            String random = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ€ ";
            String[] abecedario = new string[random.Length];
            string output = "";
            int x = 0;


            foreach (char c in random)
            {

                abecedario[x] = Convert.ToString(c);
                x += 1;

            }

            if (Clave == "" || Clave == null)
            {

                generaClave(abecedario);

            }

            x = 0;

            foreach (char c in random)
            {

                abecedario[x] = Convert.ToString(c);


                x += 1;



            }

            for (int index2 = 0; index2 <= input.Length - 1; index2++)
            {

                for (int index3 = 0; index3 <= abecedario.Length - 1; index3++)
                {

                    if (input.Substring(index2, 1) == abecedario[index3])
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

            for (x = 0; x <= aleatorio.Length - 1; x++)
            {

                lugar = r.Next(0, aleatorio.Length - 1);

                if (aleatorio[lugar] != "~")
                {

                    Clave = Clave + aleatorio[lugar];

                    aleatorio[lugar] = "~";

                }
                else
                {

                    for (int index = 0; index <= aleatorio.Length - 1; index++)
                    {

                        if (aleatorio[index] != "~")
                        {

                            Clave = Clave + aleatorio[index];

                            aleatorio[index] = "~";

                            break;

                        }

                    }

                }

            }
        }

        private string separar(string archivo)
        {
            String output = "";
            String[] separado;
            int index = 0;

            separado = archivo.Split(Convert.ToChar("\\"));

            for(index=0; index < separado.Length - 1; index++)
            {

                output += archivo[index] + "\\";

            }

            return output;

        }
    }
}
