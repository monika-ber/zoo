namespace Zoo
{
    class Opiekun : IOpiekun
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdOpiekuna { get; private set; }
        public List<Zwierze> zwierzeta = new List<Zwierze>();
        private static int najwiekszeID = 0;
        public Opiekun (string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            najwiekszeID++;
            IdOpiekuna = najwiekszeID;
            
        }

        public void DodajZwierze(Zwierze zwierze)
        {
            zwierze.IdOpiekuna = IdOpiekuna;
            zwierzeta.Add(zwierze);
            Console.WriteLine("Zwierzę dostało dodane");
            
        }

        public void UsunZwierze(int idZwierzecia)
        {
            try 
            {
                Zwierze z = zwierzeta.First(z => z.IdZwierzecia == idZwierzecia);
                if (z != null)
                {
                    zwierzeta.Remove(z);
                    Console.WriteLine("Zwierze zostało usunięte");
                }
            }
            catch
            {
                Console.WriteLine("Nie odnaleziono zwierzęcia o podanym numerze ID, sprawdź czy podane ID jest poprawne.");
            }
            
        }

        public void WyswietlWszystkieZwierzęta()
        {
            foreach (Zwierze z in zwierzeta)
            {
                Console.WriteLine($"{z.IdZwierzecia}: gatunek: {z.Gatunek}, imię: {z.Imie}, wiek: {z.Wiek} lat. ID opiekuna: {z.IdOpiekuna}");
            }
        }
    }
}