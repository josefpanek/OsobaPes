using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaPes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pes azor = new Pes("Azor", 1);

            Osoba lenka = new Osoba("Lenka", azor);
            Osoba karel = new Osoba("Karel", azor);

            Console.WriteLine("{0} ({1} let)", azor, azor.VypisVek());
            azor.Zestarni();
            azor.Zestarni();
            Console.WriteLine("{0} ({1} let)", lenka.pes, azor.VypisVek());

            Console.ReadKey();
        }
    }
}
