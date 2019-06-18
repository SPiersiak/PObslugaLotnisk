using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    /// <summary>
    /// Klasa za pomocą której przekazywane są dane do poszczególnych okien
    /// </summary>
    /// <param name="id">id użytkownika</param>
    /// <param name="typ">Typ konta użytkownika</param>
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
