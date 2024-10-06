namespace Zoo
{
    class Zoo
    {
        public List<Opiekun> opiekunowie = new List<Opiekun>();

        public void DodajOpiekuna(Opiekun opiekun)
        {
            opiekunowie.Add(opiekun);
        }

        public void DodajZwierze(int idOpiekuna, Zwierze zwierze)
        {
            try 
            {
                Opiekun o = opiekunowie.First(o => o.IdOpiekuna == idOpiekuna);
                if (o != null)
                {
                    o.DodajZwierze(zwierze);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Nie odnaleziono opiekuna o podanym numerze ID, " +
                "sprawdź czy podane ID jest poprawne.", e.Message);
            }
        }

        public void UsunZwierze(int idZwierzecia)
        {
            try 
            {
                Opiekun o = opiekunowie.First(o => o.zwierzeta.Any(z => z.IdZwierzecia == idZwierzecia));
                if (o != null)
                {
                    o.UsunZwierze(idZwierzecia);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Nie odnaleziono opiekuna o podanym numerze ID, " +
                "sprawdź czy podane ID jest poprawne.", e.Message);
            }
        }

        public void UsunOpiekuna(int idOpiekuna)
        {
            try 
            {
                Opiekun o = opiekunowie.First(o => o.IdOpiekuna == idOpiekuna);
                if (o != null)
                {
                    opiekunowie.Remove(o);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Nie odnaleziono opiekuna o podanym numerze ID, sprawdź czy podane ID jest poprawne.", e.Message);
            }
        }

        public void WyswietlWszystkichOpiekunow()
        {
            foreach (Opiekun o in opiekunowie)
            {
                Console.WriteLine($"{o.IdOpiekuna} Opiekun: {o.Imie} {o.Nazwisko}");
            }
        }

        public void WyswietlWszystkieZwierzeta()
        {
            foreach (Opiekun o in opiekunowie)
            {
                o.WyswietlWszystkieZwierzęta();
            }
        }
    }
}