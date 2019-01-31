using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace pruebaDB
{

    

    class DataBase
    {

            
  
    }

    public class aprendizage
    {

        public string Nombre { get; set; }
        public string Aprendizaje { get; set; }


    }

    public class Moves
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public Boolean Damage { get; set; }
        public string Potencia { get; set; }
        public string Presicion { get; set; }
        public string Estado { get; set; }
        public int Provabilidad_Estado { get; set; }
        public int PP_Min { get; set; }
        public int PP_Max { get; set; }
        public string Objetivo { get; set; }
        public int Prioridad { get; set; }
        public Boolean Contacto { get; set; }
        public int Min_Golpes { get; set; }
        public int Max_Golpes { get; set; }
        public int Min_turnos { get; set; }
        public int Max_turnos { get; set; }
        public int Drenado { get; set; }
        public int Recuperacion_Vida { get; set; }
        public int Critico { get; set; }
        public int Retroceso { get; set; }
        public int Stat { get; set; }
        public string Descripcion_Menu { get; set; }

    }

    public class pokemon
    {

        public string ID { get; set; }
        public string NombrePok { get; set; }
        public string HPpok { get; set; }
        public string ATKpok { get; set; }
        public string DEFpof { get; set; }
        public string SATKpok { get; set; }
        public string SDEFpok { get; set; }
        public string VELpok { get; set; }

    }

    public class tipos
    {

        public string id { get; set; }
        public string name { get; set; }
        public string efectividades { get; set; }
        public string neutro { get; set; }
        public string inmune { get; set; }
        public string poco { get; set; }

    }

}
