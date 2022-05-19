using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaPes
{
    internal class Pes
    {
        private string jmeno;
        private int vek;

        public Pes(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }
        public override string ToString()
        {
            return jmeno;
        }
        public int Zestarni()
        {
            return vek++;
        }
        public int VypisVek()
        {
            return vek;
        }
    }
}