using SKL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKL.ViewModel
{
    class LigaViewModel
    {
        public EkipaViewModel EkipaJimmy { get; set; }
        public EkipaViewModel EkipaJanez { get; set; }
        public LigaViewModel()
        {
            Ekipa janez = new Ekipa("Bomberji",DobiBomberje());
            EkipaJanez = new EkipaViewModel(janez);
            Ekipa jimmy = new Ekipa("Fantastični", DobiFantastične());
            EkipaJimmy = new EkipaViewModel(jimmy);
        }

        private IEnumerable<Igralec> DobiFantastične()
        {
            List<Igralec> x = new List<Igralec>()
            {
                new Igralec("Jimmy",31,true),
                new Igralec("Henry",23,true),
                new Igralec("Bob",6,true),
                new Igralec("Lucinda",0,true),
                new Igralec("Kim",42,true),
                new Igralec("Berta",32,false),
                new Igralec("Ed",8,false)
            };
            return x;
        }

        private IEnumerable<Igralec> DobiBomberje()
        {
            List<Igralec> x = new List<Igralec>()
            {
                new Igralec("Brian",31,true),
                new Igralec("Lloyd",23,true),
                new Igralec("Katarina",6,true),
                new Igralec("Mike",0,true),
                new Igralec("Joe",42,true),
                new Igralec("Herb",32,false),
                new Igralec("Goran",8,false)
            };
            return x;
        }
    }
}
