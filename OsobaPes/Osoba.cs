using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaPes
{
    internal class Osoba
    {
        private string jmeno;
        public Pes pes;

        public Osoba(string jmeno, Pes pes)
        {
            this.jmeno = jmeno;
            this.pes = pes;
        }
        public override string ToString()
        {
            return jmeno;
        }
    }
}
