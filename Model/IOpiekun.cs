namespace Zoo
{
    interface IOpiekun
    {
        public void DodajZwierze(Zwierze zwierze);
        public void UsunZwierze(int IdZwierzecia);
        public void WyswietlWszystkieZwierzęta();
    }
}