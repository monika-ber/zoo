namespace Zoo
{
    class Ptak : Zwierze
    {
        public Ptak(string imie, string gatunek, int wiek) : base(imie, gatunek, wiek)
        {}

        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Imie} z gatunku {Gatunek} zaśpiewał.");
        }
    }
}