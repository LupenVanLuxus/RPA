using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZaKonzola.Models;

namespace ZaKonzola.Controllers
{
    public class ProduktController : ApiController
    {
        Produkt[] produkti = new Produkt[]
            {
                new Produkt{ Id=1,Ime="Paradižnikova juha",Kategorija="Jedi",Cena=1},
                new Produkt{ Id=2,Ime="Žoga",Kategorija="Igrače",Cena=3.75m},
                new Produkt{ Id=3,Ime="Kladivo",Kategorija="Železnina",Cena=18.99m}
            };
        public IEnumerable<Produkt> GetProdukt()
        {
            return produkti;
        }
        public Produkt GetProdukt(int id)
        {
            return produkti.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
