using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class BazaClass
    {
        private int id;
            public int Id
            {
                get
                {
                return id;
                }
                set
                {
                    id = value;
                }
            }
        private int typ;
            public int Typ
            {
                get
                {
                    return typ;
                }
                set
                {
                    typ = value;
                }
            }

        public BazaClass()
        {
             
        }
    }
}
