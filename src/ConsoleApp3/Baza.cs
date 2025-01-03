namespace ConsoleApp3
{// dodaj novi proizvod/ izlistaj proizvode/ iz konzole se unose proizvodi i preko konzole da se izlistaju svi proizvodi
    public static class Baza
    {
        public static List<Auto> Proizvodi = new List<Auto>()
        {
            new Auto()
            {
                Marka = "BMW",
                Model = "520",
            },
            new Auto()
            {
                Marka = "Mercedes",
                Model = "170",
            }
        }; 
    }
}


