using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Projekt
{
    class Kunde
    {
        public int Id { get; set; }
        public int CVRnummer { get; set; }
        public string Navn { get; set; }
        public string Firma { get; set; }
        public string Adresse { get; set; }
        public string By { get; set; }
        public int Postnr { get; set; }
        public string Mail { get; set; }
        public string Telefonnr { get; set; }
        public static int count = 1;

        public Kunde()
        {
            
        }

        public Kunde(int cvRnummer, string navn, string firma, string adresse, string @by, int postnr, string mail, string telefonnr)
        {
            Id = count++;
            CVRnummer = cvRnummer;
            Navn = navn;
            Firma = firma;
            Adresse = adresse;
            By = @by;
            Postnr = postnr;
            Mail = mail;
            Telefonnr = telefonnr;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(CVRnummer)}: {CVRnummer}, {nameof(Navn)}: {Navn}, {nameof(Firma)}: {Firma}, {nameof(Adresse)}: {Adresse}, {nameof(By)}: {By}, {nameof(Postnr)}: {Postnr}, {nameof(Mail)}: {Mail}, {nameof(Telefonnr)}: {Telefonnr}";
        }
    }
}
