using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPlay
{
    class PlayStation3 : PlayStation2
        {
            protected string online;

            public string Online
            {
                get
                {
                    return online;
                }
                set
                {
                    online = value;
                }
            }
            public PlayStation3() : base()
            {
                online = "";

            }
            public override string ToString()
            {
                return online + " " + base.ToString();


            }
        }
}
