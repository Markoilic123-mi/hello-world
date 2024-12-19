using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prodavnica
    {
        public string Ime;
        public Proizvod[] proizvodi;

        public void Ispisi()
        {
            Console.WriteLine(Ime);
            foreach (Proizvod i in proizvodi)
            {
                i.Ispisi();
            }
        }
    }
}
