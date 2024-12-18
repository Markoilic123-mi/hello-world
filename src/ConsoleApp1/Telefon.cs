using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Telefon
    {
        public string marka;
        public string boja;

        public void Ispisi()
        {
            Console.WriteLine($"{marka} - {boja}");
        }
    }
}
