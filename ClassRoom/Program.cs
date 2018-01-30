using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            var klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3A";
            klasseRum.SemesterStart = new DateTime(2017, 08, 28);
            klasseRum.KlasseListe = new List<Studerende>()
            {
                new Studerende("Mervan", 04, 21),
                new Studerende("John", 01, 01)
            };

            Console.WriteLine(klasseRum);
            Console.WriteLine("Studerende:");
            foreach (var studerende in klasseRum.KlasseListe)
            {
                Console.WriteLine($"\t{studerende.Navn}");
            }

            Console.WriteLine();

            klasseRum.Birthdays();

            Console.ReadKey();
        }
    }
}
