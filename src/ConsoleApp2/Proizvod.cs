using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Proizvod
    {
        public string Ime;
        public string Boja;
        public void Ispisi()
        {
            for (int m = 0; m < 1; m++)
            {
                if (m == 0)
                {
                    Console.Write("-");
                    
                }
                
            }

            Console.WriteLine($"{Ime}-{Boja}");
        }
      
    }
}
