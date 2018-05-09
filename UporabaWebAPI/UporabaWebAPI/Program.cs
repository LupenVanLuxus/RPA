using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UporabaWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Poženi().Wait();
            Console.ReadLine();
        }
        static async Task Poženi()
        {
            using (HttpClient klient = new HttpClient())
            {
                klient.BaseAddress = new Uri("http://localhost:2246/");
                klient.DefaultRequestHeaders.Accept.Clear();
                klient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage odgovor =await klient.GetAsync("api/Produkt/1");
                if (odgovor.IsSuccessStatusCode)
                {
                    Produkt p = await odgovor.Content.ReadAsAsync<Produkt>();
                    Console.WriteLine("Produkt "+p.Id+" "+p.Ime+" "+p.Kategorija+" "+p.Cena);
                }
            }
        }
    }
}
