namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodavnica p1 = new Prodavnica();
            p1.Ime = "Prodavnica1";
            p1.proizvodi = [
                new Proizvod()
                {
                    Ime = "Proizvod 1",
                    Boja = "Zuta"
                },
                new Proizvod()
                {
                    Ime = "Proizvod 2",
                    Boja = "Zelena"
                }
            ];
            

                p1.Ispisi();


                Prodavnica p2 = new Prodavnica();
                p2.Ime = "Prodavnica2";
                p2.proizvodi = [
                    new Proizvod()
                {
                    Ime = "Proizvod 3",
                    Boja = "Plava"
                },
                new Proizvod()
                {
                    Ime = "Proizvod 4",
                    Boja = "Crna"
                }
                ];
                p2.Ispisi();
            
        }
    }
}
