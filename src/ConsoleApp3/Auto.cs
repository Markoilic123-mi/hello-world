using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//klasu auto prosiri sa metodom koja se zove ispisi metoda ne vraca nista vec ispisuje u konzoli tekst u formatu model razmak marka. koristi ovu metodu prilikom ispisivanja teksa
namespace ConsoleApp3
{
    public class Auto
    {
        public string Marka;
        public string Model;

        public void Ispisi()
        {
            Console.WriteLine(Marka + " " + Model);   
        }
    }
}
