namespace Zoo
{
    class Gad : Zwierze
    {
        public Gad(string imie, string gatunek, int wiek) : base(imie, gatunek, wiek)
        {}

        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Imie} z gatunku {Gatunek} zasyczał.");
        }
    }
}