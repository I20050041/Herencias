using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPlay
{
    class PlayStation2 : PlayStation1
    {
        protected string headset;

        public string Headset
        {
            get
            {
                return headset;
            }
            set
            {
                headset = value;
            }
        }
        public PlayStation2() : base()
        {
            headset = "";

        }
        public override string ToString()
        {
            return headset + " " + base.ToString();
        }
    }
}
