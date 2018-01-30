using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        public string Navn { get; }
        public int Fødselsmåned { get; }
        public int Fødselsdag { get; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            if (fødselsmåned > 12 || fødselsmåned < 1)
            {
                throw new ArgumentException("Invalid month. Enter a month from 1-12");
            }

            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        public string Birthday()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
               return "Vinter";
            }
            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                return "Forår";

            }
            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                return "Sommer";
            }
            else
            {
                return "Efterår";
            }

            
        }
    }
    


    

    
}
