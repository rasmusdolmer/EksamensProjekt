using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Folie
    {
        public string Navn { get; set; }

        public Folie()
        {
            
        }

        public Folie(string navn)
        {
            Navn = navn;
        }

        public override string ToString()
        {
            return $"{Navn}";
        }
    }
}
