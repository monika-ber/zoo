namespace Zoo
{
    abstract class Zwierze : IZwierze
    {
        public int IdZwierzecia { get; private set; }
        public int Wiek { get; set; }
        public string Imie { get; set; }
        public string Gatunek { get; set; }
        public int? IdOpiekuna { get; set; }
        private static int najwiekszeID = 0;

        public Zwierze(string imie, string gatunek, int wiek)
        {
            Imie = imie;
            Gatunek = gatunek;
            Wiek = wiek;
            IdOpiekuna = null;
            najwiekszeID++;
            IdZwierzecia = najwiekszeID;
        }
        public void Jedz()
        {
            Console.WriteLine($"{Imie} z gatunku {Gatunek} je");
        }
        public void Spij()
        {
            Console.WriteLine($"{Imie} z gatunku {Gatunek} idzie spać");
        }
        public virtual void WydajDzwiek()
        {
            Console.WriteLine($"Zwierzę o imieniu {Imie} z gatunku {Gatunek} wydało dżwięk");
        }
    }
}