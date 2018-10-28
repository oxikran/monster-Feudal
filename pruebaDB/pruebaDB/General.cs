using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDB
{
    public class General
    {

        public string ida;
        public string vuelta;

        public General(){
}

        public string getida()
        {

            return ida;

        }

        public string getVuelta()
        {

            return vuelta;

        }

        public void setIda(String input)
        {

            ida = input;

        }

        public void setVuelta(String input)
        {

            vuelta = input;

        }


    }
}
