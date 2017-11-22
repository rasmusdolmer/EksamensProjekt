using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using Projekt.Annotations;

namespace Projekt
{
    class KundeViewModel : INotifyPropertyChanged
    {
        #region MyRegion
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ObservableCollection<Kunde> KundeCollection { get; set; }
        public int Id { get; set; }
        public int CVRnummer { get; set; }
        public string Navn { get; set; }
        public string Firma { get; set; }
        public string Adresse { get; set; }
        public string By { get; set; }
        public int Postnr { get; set; }
        public string Mail { get; set; }
        public string Telefonnr { get; set; }

        public KundeViewModel()
        {
            KundeCollection = new ObservableCollection<Kunde>();
        }

        public KundeViewModel(ObservableCollection<Kunde> kundeCollection, int id, int cvRnummer, string navn, string firma, string adresse, string @by, int postnr, string mail, string telefonnr)
        {
            KundeCollection = kundeCollection;
            Id = id;
            CVRnummer = cvRnummer;
            Navn = navn;
            Firma = firma;
            Adresse = adresse;
            By = @by;
            Postnr = postnr;
            Mail = mail;
            Telefonnr = telefonnr;
        }

        public void OpretKunde()
        {
            KundeCollection.Add(new Kunde(CVRnummer, Navn, Firma, Adresse, By, Postnr, Mail, Telefonnr));
            OnPropertyChanged();
        }

        
    }
}
