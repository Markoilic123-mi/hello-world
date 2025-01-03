using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
// 
namespace ConsoleApp3
{
    public static class Aplikacija
    {
        public static void Start()
        {
            while (true)
            {
                Console.Write("Unesite opciju: ");
                string unetiBroj = Console.ReadLine();
                if (unetiBroj == "1")
                {
                    DodatiProizvodi();
                }
                else if (unetiBroj == "2")
                {
                    Izlistavanje();

                }
                else if (unetiBroj == "3")
                {
                    IzlazakIzKonzole();
                    return;
                }
                else
                {
                    PojavaGreske();
                }

            }
        }

        private static void DodatiProizvodi()
        {//pitaj me za model i za marku
            Auto auto = new Auto();
            Console.Write("Dodajte novu marku automobila: ");
            auto.Marka = Console.ReadLine();
            Console.Write("Unesite model automobila: ");
            auto.Model = Console.ReadLine();

            Baza.Proizvodi.Add(auto);
        }

        private static void Izlistavanje()
        {
            foreach (Auto p in Baza.Proizvodi)
                p.Ispisi();
        }

        private static void PojavaGreske()
        {
            Console.WriteLine("Greska, pokusaj ponovo.");
        }
        private static void IzlazakIzKonzole()
        {
            Console.WriteLine("Izlazak iz Konzole.");
        }
    }
}
