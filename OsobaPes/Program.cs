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
            // azor je instance třídy Pes.
            Pes azor = new Pes("Azor", 1);

            // lenka a karel jsou instance třídy Osoba.
            Osoba lenka = new Osoba("Lenka", azor);
            Osoba karel = new Osoba("Karel", azor);

            // Vypíše jméno psa a jeho počáteční věk.
            Console.WriteLine("{0} ({1} let)", azor, azor.VypisVek());
            // Nechám psa dvakrát zestárnout.
            azor.Zestarni();
            azor.Zestarni();
            // Vypíše jméno Lenčina psa a jeho aktuální věk.
            Console.WriteLine("{0} ({1} let)", lenka.pes, lenka.pes.VypisVek());

            Console.ReadKey();
        }
    }
}
