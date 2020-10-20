using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPlay
{
    class PlayStation4 : PlayStation3
    {
        protected string sensormovimiento;
        public string Sensormovimiento
        {
            get
            {
                return sensormovimiento;
            }
            set
            {
                sensormovimiento = value;
            }
        }
        public PlayStation4() : base()
        {
            sensormovimiento = "";

        }
        public override string ToString()
        {
            return sensormovimiento + " " + base.ToString();
        }
    }
}
