using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class KlasseRum
    {
        public string KlasseNavn { get; }
        public List<Studerende> KlasseListe { get; }
        public DateTime SemesterStart { get; }

        public KlasseRum()
        {
            
        }

    
    }
}
