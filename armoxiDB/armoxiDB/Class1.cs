using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace armoxiDB
{
    public class aramoxi
    {
        String[] Filtro;
        String[] Relacion;
        String[] actual;
        String activo;
        int registro;
        String[] Archivo;
        String[] Campos;
        String rutaT;
        String Clave;

        public aramoxi()
        {


        }

        public int OpenDB(String BD)
        {
            rutaT = BD;

            //try
            //{
            Archivo = Unkrypto(File.ReadAllText(BD + ".axdb"));
            CargaInfo();
            return 2;
            //}
            //catch{

            //return 1;

            //}
        }

        private void CargaInfo()
        {

            Campos = getindex();
            //Array.Resize(ref actual, Campos.Length);


        }

        public int createindex(long Clave, String nombreCampo, long Longitud)
        {
            try
            {
                if (!File.Exists(rutaT + ".axid"))
                {

                    File.Create(rutaT + ".axid").Close();

                }

                File.AppendAllText(rutaT + ".axid", Clave + "," + nombreCampo + "," + Longitud + "|");

                return 1;

            }
            catch
            {

                return 2;
            }
        }


        public void edit(int field, String Data)
        {
            String[] aux;
            int inicio;

            inicio = 0;

            aux = Campos[field].Split(Convert.ToChar(","));

            Data = Data.Substring(0, Convert.ToInt16(aux[2]));

            for (int index = 0; index < field; index++)
            {

                aux = Campos[index].Split(Convert.ToChar(","));

                inicio += Convert.ToInt16(aux[0]);



            }

            activo = activo.Replace(activo.Substring(inicio, Convert.ToInt16(aux[2])), Data);

        }

        public void update()
        {

            int index = 0;

            for (index = 0; index < actual.Length; index++)
            {

                activo = activo + actual[index];

            }

            MoveLastestToFill();

            Archivo[registro] = activo;

            activo = "";

        }

        private void MoveLastestToFill()
        {

            Array.Resize(ref Archivo, Archivo.Length + 1);





            //activo = Filtro[Filtro.Length - 1];

            registro = Archivo.Length - 1;



        }

        public int recordCount()
        {



            return Filtro.Length;

        }

        public String OxiField(int num)
        {


            String[] aux;
            int inicio;
            String salida;
            inicio = 0;
            salida = "";



            for (int index = 0; index < num; index++)
            {

                aux = Campos[index].Split(Convert.ToChar(","));

                inicio += Convert.ToInt16(aux[2]);



            }

            aux = Campos[num].Split(Convert.ToChar(","));

            salida = activo.Substring(inicio, Convert.ToInt16(aux[2]));

            return salida;

        }

        public void addData(int key, String data)
        {

            CargaInfo();

            int index = 0;
            String datos;
            String[] aux;

            datos = "";

            if (data == null)
            {

                data = "";

            }

            for (index = 0; index <= Campos.Length - 1; index++)
            {

                aux = Campos[index].Split(Convert.ToChar(","));

                if (aux[0] == Convert.ToString(key))
                {
                    if (data.Length <= Convert.ToInt16(aux[2]))
                    {

                        datos = data.PadRight(Convert.ToInt16(aux[2]));

                    }
                    else
                    {

                        datos = data.Substring(0, Convert.ToInt16(aux[2]));

                    }

                    break;

                }


            }

            Array.Resize(ref actual, Campos.Length);

            actual[key] = datos;

        }

        public void registrar()
        {

            saveData();
            OpenDB(rutaT);

        }

        public int createBD(String ruta, String nombredb)
        {



            try
            {

                if (File.Exists(ruta))
                {

                    return 1;

                }
                else
                {

                    File.Create(ruta + nombredb + ".axdb").Close();

                    return 2;

                }

            }
            catch
            {

                return 3;

            }


        }

        public String[] getindex()
        {

            String[] Output;

            Output = "".Split(Convert.ToChar("."));

            try
            {

                Output = Convert.ToString(File.ReadAllText(rutaT + ".axid")).Split(Convert.ToChar("|"));


                return Output;

            }
            catch
            {
                return Output;
            }
            finally
            {



            }


        }

        public void delete()
        {

            Filtro[registro] = "";

        }

        public int deleteindex(String Clave)
        {
            String[] aux;
            String[] Claves = getindex();
            long index = 0;

            for (index = 0; index <= Claves.LongLength; index++)
            {

                aux = Claves[index].Split(Convert.ToChar(","));
                if (aux[0] == Clave)
                {

                    Claves[index] = "";

                    break;

                }
            }

            grabarindices(Claves);

            return 1;

        }



        public void CloseDB()
        {

            saveData();

            Array.Clear(Filtro, 0, Filtro.Length);
            activo = "";
            registro = 0;
            Array.Clear(Campos, 0, Campos.Length);
            Array.Clear(Archivo, 0, Archivo.Length);
            rutaT = "";

        }

        private void saveData()
        {

            long index;
            String grabar;

            grabar = "";

            index = 0;



            for (index = 0; index <= Archivo.LongLength - 1; index++)
            {

                if (Archivo[index] == "") { }
                else
                {
                    grabar = grabar + Krypto(Archivo[index]) + "€";
                }
            }

            File.WriteAllText(rutaT + ".axdb", grabar);


        }

        public void DeleteDB()
        {
            try
            {
                File.Delete(rutaT + ".axid");
                File.Delete(rutaT + ".axdb");

            }
            catch
            {

                MessageBox.Show("Error al eliminar");

                //messa( "error al eliminar");

            }

        }

        public void movefirst()
        {


            if (Filtro == null)
            {

                Filtro = Archivo;

                activo = Filtro[0];

                registro = 0;

            }
            else if (Filtro.Length > 0)
            {

                activo = Filtro[0];

                registro = 0;

            }
            else
            {

                Filtro = Archivo;

                activo = Filtro[0];

                registro = 0;


            }

        }


        public void MoveLastest()
        {


            if (Filtro == null)
            {

                Filtro = Archivo;

                activo = Filtro[Filtro.Length - 1];

                registro = Filtro.Length - 1;

            }
            else if (Filtro.Length > 0)
            {

                activo = Filtro[Filtro.Length - 1];

                registro = Filtro.Length - 1;

            }
            else
            {

                Filtro = Archivo;

                activo = Filtro[Filtro.Length - 1];

                registro = Filtro.Length - 1;


            }


        }

        public void MoveNext()
        {

            if (registro == Filtro.Length)
            {

                MessageBox.Show("Se encuentra en el final del archivo");

            }
            else
            {

                activo = Filtro[registro + 1];
                registro += 1;

            }

        }

        public void MoveLast()
        {

            if (registro == 0)
            {

                MessageBox.Show("Se encuentra en el inicio del archivo");

            }
            else
            {

                activo = Filtro[registro - 1];
                registro -= 1;

            }

        }

        private int grabarindices(string[] claves)
        {
            try
            {

                int index;

                for (index = 0; index <= claves.LongLength; index++)
                {

                    if (claves[index] != "")
                    {

                        File.AppendAllText(rutaT + ".axid", claves[index] + "|");

                    }

                }

                return 1;

            }
            catch
            {
                return 2;
            }
        }

        private String Krypto(String Input)
        {
            String Output;
            int size;
            int index;
            Output = "";
            size = Input.Length;

            for (index = 0; index <= size - 1; index++)
            {

                if (index == size)
                {

                    Output = Output + Convert.ToString(Convert.ToDecimal((int)Convert.ToChar(Input.Substring(index, 1))) * 8);

                }
                else
                {
                    Output = Output + Convert.ToString(Convert.ToDecimal((int)Convert.ToChar(Input.Substring(index, 1))) * 8) + "|";
                }
            }

            return Output;

        }

        private String[] Unkrypto(String Input)
        {
            String[] Output;
            String[] aux;
            String temp;
            char separador;
            char retorno;
            long index;
            long index2;
            index = 0;
            index2 = 0;
            separador = Convert.ToChar("|");
            retorno = Convert.ToChar("€");


            temp = "";

            if (Input.Length == 0)
            {

                Output = "4".Split(Convert.ToChar("4"));

            }
            else
            {

                Output = Input.Split(retorno);

                for (index = 0; index <= Output.LongLength - 1; index++)
                {

                    aux = Output[index].Split(separador);
                    temp = "";

                    for (index2 = 0; index2 <= aux.LongLength - 1; index2++)
                    {

                        if (aux[index2] == "")
                        {

                        }
                        else
                        {
                            temp = temp + Convert.ToString(char.ConvertFromUtf32(Convert.ToChar(Convert.ToInt16(aux[index2]) / 8)));

                        }

                        //Convert.ToDecimal(aux[index]) / 8;

                    }

                    if (temp == "")
                    {


                    }
                    else
                    {

                        Output[index] = temp;

                    }


                }

                //aux = Input.Split( separador );
                //for (index = 0; index <= aux.LongLength; index ++ ){

                //    if (aux[index] == "€"){



                //    }else{

                //        Output = Output + Convert.ToString(char.ConvertFromUtf32(Convert.ToChar(Convert.ToDecimal(aux[index]) / 8)));

                //    }

                //    //Convert.ToDecimal(aux[index]) / 8;

                //}

            }



            return Output;
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

                for (int index3 = 0; index3 <= abecedario.Length -1 ; index3++)
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

            for (x = 0; x <= aleatorio.Length -1; x++)
            {

                lugar = r.Next(0, aleatorio.Length -1);

                if (aleatorio[lugar] != "~")
                {

                    Clave = Clave + aleatorio[lugar];

                    aleatorio[lugar] = "~";

                }
                else
                {

                    for (int index = 0; index <= aleatorio.Length -1; index++)
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
    }
}
