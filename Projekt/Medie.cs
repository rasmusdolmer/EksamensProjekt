using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Medie
    {
        public string Navn { get; set; }

        public Medie()
        {
            
        }

        public Medie(string navn)
        {
            Navn = navn;
        }

        public override string ToString()
        {
            return $"{Navn}";
        }
    }
}
