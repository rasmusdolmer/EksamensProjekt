using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Ordre
    {
        public int OrdreNr { get; set; }
        private static int count = 1; 
        public Medie Medie { get; set; }
        public Folie Folie { get; set; }
        public string Farve { get; set; }
        public string Længde { get; set; }
        public string Bredde { get; set; }
        public string Antal { get; set; }
        public bool Laminering { get; set; }
        public bool Fragt { get; set; }
        public bool OpTil10 { get; set; }
        public bool Montering { get; set; }
        public bool Afhentes { get; set; }
        public string Kommentar { get; set; }
        public string KundeFirma { get; set; }

        public Ordre()
        {
              
        }

        public Ordre(Medie medie, Folie folie, string farve, string længde, string bredde, string antal, bool laminering, bool fragt, bool opTil10, bool montering, bool afhentes, string kommentar)
        {
            OrdreNr = count++;
            Medie = medie;
            Folie = folie;
            Farve = farve;
            Længde = længde;
            Bredde = bredde;
            Antal = antal;
            Laminering = laminering;
            Fragt = fragt;
            OpTil10 = opTil10;
            Montering = montering;
            Afhentes = afhentes;
            Kommentar = kommentar;
        }

        public override string ToString()
        {
            return $"{nameof(OrdreNr)}: {OrdreNr}, {nameof(Medie)}: {Medie}, {nameof(Folie)}: {Folie}, {nameof(Farve)}: {Farve}, {nameof(Længde)}: {Længde}, {nameof(Bredde)}: {Bredde}, {nameof(Antal)}: {Antal}, {nameof(Laminering)}: {Laminering}, {nameof(Fragt)}: {Fragt}, {nameof(OpTil10)}: {OpTil10}, {nameof(Montering)}: {Montering}, {nameof(Afhentes)}: {Afhentes}, {nameof(Kommentar)}: {Kommentar}";
        }
    }
}
