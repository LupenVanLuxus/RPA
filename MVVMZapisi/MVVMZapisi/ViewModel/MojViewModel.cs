using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Windows.UI;

namespace MVVMZapisi
{
    class MojViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string imeLastnosti = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(imeLastnosti));
            }
        }
        public ObservableCollection<MojZapis> Zapisi { get; set; }
        private MojZapis trenutni;
        public MojZapis Trenutni
        {
            get { return trenutni; }
            set { trenutni = value; OnPropertyChanged();
                NarediZelenoUkaz.RaiseCanExecuteChanged();
            }
        }
        public string Naslov { get; set; }
        public DelegateCommand NarediZelenoUkaz { get; set; }
        public MojViewModel()
        {
            Zapisi = new ObservableCollection<MojZapis>();
            for (int k = 1; k <= 10; k++)
            {
                Zapisi.Add(new MojZapis { Ime = k.ToString(), Barva = Colors.Orange });
            }
            trenutni = Zapisi.First();
            Naslov = "Moji zapisi";
            NarediZelenoUkaz = new DelegateCommand(
                (p) => { Trenutni.Barva = Colors.Green; },
                (p) => { return Trenutni != null; }
                );
        }
    }
}
