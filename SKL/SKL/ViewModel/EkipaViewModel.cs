using SKL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SKL.ViewModel
{
    class EkipaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string imeL=null)
        {
            PropertyChangedEventHandler pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(imeL));
        }
        private string imeEkipe;
        public string ImeEkipe
        {
            get { return imeEkipe; }
            set {
                imeEkipe = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Igralec> Starters { get; set; }
        public ObservableCollection<Igralec> Klop { get; set; }
        Ekipa ekipa;
        public EkipaViewModel(Ekipa e)
        {
            ekipa = e;
            ImeEkipe = e.ImeEkipe;
            Starters = new ObservableCollection<Igralec>();
            var začetni = from i in ekipa.Igralci
                          where i.Starter
                          select i;
            Starters.Clear();
            foreach (var x in začetni)
            {
                Starters.Add(new Igralec(x.Ime, x.Številka, true));
            }

            Klop = new ObservableCollection<Igralec>();
            var klop = from i in ekipa.Igralci
                          where !i.Starter
                          select i;
            Klop.Clear();
            foreach (var x in klop)
            {
                Klop.Add(new Igralec(x.Ime, x.Številka, false));
            }
        }
    }
}
