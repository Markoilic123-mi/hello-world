using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class App1
    {
        Telefon[] ppp = [
            new Telefon() {
                marka = "Samsung",
                boja = "ljubicasta",
            },
            new Telefon(){
                marka = "Huavei",
                boja = "crna",
            },
        ];
       
        public void Start()
        {
            foreach(Telefon tel in ppp)
            {
                tel.Ispisi();
            }
        }
    }
}


