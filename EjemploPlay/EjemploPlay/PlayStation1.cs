using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPlay
{
    class PlayStation1
    {
        protected string consola;
        protected int control;
        protected string memoria;
        public PlayStation1()
        {
            consola = "";
            control = 0;
            memoria = "";
        }
        public string Consola
        {
            get
            {
                return consola;
            }
            set
            {
                consola = value;
            }
        }
        public int Control
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
            }
        }
        public override string ToString()
        {
            return consola + control + "" + memoria + "";
        }
        public string Memoria
        {
            get
            {
                return memoria;
            }
            set
            {
                memoria = value;
            }

        }

    }
}
