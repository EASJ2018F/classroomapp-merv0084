using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> KlasseListe { get; set; }
        public DateTime SemesterStart { get; set; }

        public void Birthdays()
        {
            var seasonsBirthdays = from s in KlasseListe
                group s by s.Fødselsmåned into k
                select new
                {
                    Date = k.Key,
                    Count = (from s in k select s.Fødselsmåned).Distinct().Count()
                };

            foreach (var birthday in seasonsBirthdays)
            {
                Console.WriteLine(birthday);
            }
        }

        public override string ToString()
        {
            return $"Klasse Navn: {KlasseNavn} \nSemester Start: {SemesterStart}";
        }
    }
}
