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
        String guardar;
        String Clave;
        String ruta;
        String active;
        int ancho;
        int indactivo;
        String nArch;
        Boolean edita;
        Boolean nuevo;

        public aramoxiDB(String serie)
        {

            //if (serie == "DEMO")
            //{



            //}
            //else
            //{



            //}

        }

        public void OpenDB(String archivo)
        {

            guardar = archivo;

            archivo = archivo + ".axdb";

            ruta = separar(archivo);

            nArch = separar2(archivo);

            if (File.Exists(archivo))
            {

                archivoCargado = File.ReadAllText(archivo).Split(Convert.ToChar("~"));

                Clave = archivoCargado[0];

                File.WriteAllText(ruta + "Data" + nArch + ".txt", archivoCargado[3]);
                File.WriteAllText(ruta + "Index" + nArch + ".txt", archivoCargado[2]);
                File.WriteAllText(ruta + "cab" + nArch + ".txt", archivoCargado[1]);

                Array.Clear(archivoCargado, 0, 4);

            }


        }

        public void closedb()
        {

            File.WriteAllText(guardar + ".axdb", Clave + File.ReadAllText(ruta + "cab" + nArch + ".txt") + File.ReadAllText(ruta + "Index" + nArch + ".txt") + File.ReadAllText(ruta + "Data" + nArch + ".txt"));

            Array.Clear(archivoCargado, 0, archivoCargado.Length);
            guardar = "";
            Clave = "";
            ruta = "";
            active = "";
            ancho = 0;
            indactivo = 0;
            nArch = "";
            edita = false;
            nuevo = false;

        }

        public void add(int Field, String Data)
        {

            editar(Field, Data);

        }

        public void addnew()
        {

            nuevo = true;

            active = new string(Convert.ToChar(" "), ancho);

        }

        public void CrearCabeceras(String Cabeceras)
        {

            File.WriteAllText(ruta + "cab" + nArch + ".txt", kripto(Cabeceras));

        }

        public void addCabecera(int id, String Cabecera, int maxAncho)
        {

            String cab;

            cab = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt"));

            cab = cab + "|" + id + "|" + Cabecera + "|" + maxAncho + "$";

            File.WriteAllText(ruta + "cab" + nArch + ".txt", kripto(cab));

        }

        public void update()
        {
            if (edita)
            {

                edita = false;

                String temp = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt"));

                temp = temp.Remove(indactivo, ancho).Insert(indactivo, active);

                File.WriteAllText(ruta + "Data" + nArch + ".txt", kripto(temp));

            }
            else if (nuevo)
            {

                nuevo = false;

                String temp = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt"));

                temp = temp + active;
                //File.AppendText(ruta + "Data" + nArch + ".txt");

                File.WriteAllText(ruta + "Data" + nArch + ".txt", kripto(temp));

            }

        }

        public void deleteReg()
        {

            active = new string(Convert.ToChar(" "), active.Length);

        }

        public void deleteItem(int Field)
        {

            if (edita)
            {

                editar(Field, "");

            }

        }

        public void movenext()
        {

            if (ancho <= 0)
            {

                setancho();

            }

            indactivo += ancho;

            if (indactivo >= File.ReadAllText(ruta + "Data" + nArch + ".txt").Length)
            {

                indactivo = indactivo - ancho;

                throw new System.IndexOutOfRangeException("ha llegado al límite de la base de datos");

            }
            else
            {

                active = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt").Substring(indactivo, ancho));

            }

            edita = false;

        }

        public void MovePrevous()
        {

            if (ancho <= 0)
            {

                setancho();

            }

            indactivo -= ancho;

            if (indactivo <= 0)
            {

                indactivo = indactivo + ancho;

                throw new System.IndexOutOfRangeException("indice = 0");

            }
            else
            {

                active = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt").Substring(indactivo, ancho));

            }

            edita = false;

        }

        public void movelast()
        {

            if (ancho <= 0)
            {

                setancho();

            }

            indactivo = File.ReadAllText(ruta + "Data" + nArch + ".txt").Length - ancho;

            active = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt").Substring(indactivo, ancho));

            edita = false;

        }

        public void movefirst()
        {

            if (ancho <= 0)
            {

                setancho();

            }

            indactivo = 0;

            active = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt").Substring(indactivo, ancho));

            edita = false;

        }


        private void setancho()
        {

            int index = 0;
            String[] aux;

            ancho = 0;

            archivoCargado = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt")).Split(Convert.ToChar("€"));


            for (index = 0; index <= archivoCargado.Length; index++)
            {

                aux = archivoCargado[index].Split(Convert.ToChar("|"));

                ancho += Convert.ToInt32(aux[2]);

            }

            Array.Clear(archivoCargado, 0, archivoCargado.Length);

        }

        public void editar(int Field, String Data)
        {

            int cual = Convert.ToInt32(Field);
            int index = 0;
            int inicio = 0;
            int cuanto = 0;
            int x = 0;
            String[] aux;

            if (edita)
            {

                archivoCargado = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt")).Split(Convert.ToChar("€"));

                for (index = 0; index <= cual; index++)
                {

                    aux = archivoCargado[index].Split(Convert.ToChar("|"));

                    if (index == cual)
                    {

                        cuanto = Convert.ToInt32(aux[2]);

                    }
                    else
                    {

                        inicio += Convert.ToInt32(aux[2]);

                    }


                }

                if (Data.Length > cuanto)
                {

                    x = cuanto - Data.Length;

                    Data += new String(Convert.ToChar(" "), x);

                }
                else
                {

                    active.Replace(active.Substring(inicio, cuanto), Data.Substring(0, cuanto));

                }


            }
            else
            {

                archivoCargado = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt")).Split(Convert.ToChar("€"));

                for (index = 0; index <= cual; index++)
                {

                    aux = archivoCargado[index].Split(Convert.ToChar("|"));

                    if (index == cual)
                    {

                        cuanto = Convert.ToInt32(aux[2]);

                    }
                    else
                    {

                        inicio += Convert.ToInt32(aux[2]);

                    }


                }

                if (Data.Length > cuanto)
                {

                    x = cuanto - Data.Length;

                    Data += new String(Convert.ToChar(" "), x);

                }
                else
                {

                    active.Replace(active.Substring(inicio, cuanto), Data.Substring(0, cuanto));

                }

            }

        }

        public void edit()
        {

            //modo editar
            edita = true;
            nuevo = false;

        }

        public void findbyid(int id)
        {
            String[] aux;
            int len = 0;
            long index = 0;
            String output = "";

            archivoCargado = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt")).Split(Convert.ToChar("€"));

            for (index = 0; index < archivoCargado.Length; index++)
            {

                aux = archivoCargado[index].Split(Convert.ToChar("|"));

                len += Convert.ToInt16(aux[2]);

            }

            archivoCargado = Unkripto(File.ReadAllText(ruta + "Index" + nArch + ".txt")).Split(Convert.ToChar("€"));

            for (index = 0; index < archivoCargado.Length; index++)
            {

                aux = archivoCargado[index].Split(Convert.ToChar("|"));

                if (Convert.ToString(id) == aux[0])
                {

                    output = Unkripto(File.ReadAllText(ruta + "Data" + nArch + ".txt")).Substring(Convert.ToInt32(aux[1]), len);

                    break;
                }

            }

            Array.Clear(archivoCargado, 1, archivoCargado.Length);

            active = output;

        }

        public String oxifield(String num)
        {

            String[] aux;
            int index = 0;
            int inicio = 0;
            int final = 0;
            String output;
            archivoCargado = Unkripto(File.ReadAllText(ruta + "cab" + nArch + ".txt")).Split(Convert.ToChar("€"));

            for (index = 0; index < Convert.ToInt32(num); index++)
            {

                aux = archivoCargado[index].Split(Convert.ToChar("|"));

                if (index == Convert.ToInt32(num) - 1)
                {

                    final = Convert.ToInt32(aux[2]);//inicio + Convert.ToInt32(aux[2]);

                }
                else
                {

                    inicio = inicio + Convert.ToInt32(aux[2]);

                }

            }

            Array.Clear(archivoCargado, 0, archivoCargado.Length);

            output = active.Substring(inicio, final);

            return output;

        }

        public String Unkripto(String input)
        {

            String orden = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ|€ ";
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

            String random = "qwertyuiopasdfghjklzxcvbnmñQWERTYUIOPASDFGHJKLZXCVBNMÑ1234567890=-+!¡?¿()[]%^&@#/.,:áéíóúÁÉÍÓÚ|€$ ";
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

            for (index = 0; index < separado.Length - 1; index++)
            {

                output += archivo[index] + "\\";

            }

            return output;

        }
        private string separar2(string archivo)
        {

            String[] separado;

            separado = archivo.Split(Convert.ToChar("\\"));
            return separado[separado.Length];

        }
    }
}

