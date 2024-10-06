using System.Reflection.Metadata.Ecma335;

namespace Zoo
{
    class Program
    {
        static void Main()
        {
            Zoo zoo = new Zoo();
            
            Console.WriteLine("Witamy w systemie zarządzania zoo");
            DisplayInstructions();
            readUserInput(out int userInput);

            while(true)
            {
                switch(userInput)
                {
                    case 1:
                        case1(zoo);
                        break;
                    case 2:
                        Console.WriteLine("Wpisz ID zwierzęcia, które chcesz usunąć");
                        readUserInput(out int idZwierzecia);
                        zoo.UsunZwierze(idZwierzecia);
                        break;
                    case 3:
                        Console.WriteLine("Wpisz imię opiekuna");
                        string? imie = Console.ReadLine();
                        Console.WriteLine("Wpisz nazwisko opiekuna");
                        string? nazwisko = Console.ReadLine();
                        zoo.DodajOpiekuna(new Opiekun(imie, nazwisko));
                        break;
                    case 4:
                        Console.WriteLine("Wpisz ID opiekuna, którego chcesz usunąć");
                        readUserInput(out int idOpiekuna);
                        zoo.UsunOpiekuna(idOpiekuna);
                        break;
                    case 5:
                        Console.WriteLine("Wyświetlanie wszystkich opiekunów");
                        zoo.WyswietlWszystkichOpiekunow();
                        break;
                    case 6:
                        Console.WriteLine("Wyświetlanie wszystkich zwierząt");
                        zoo.WyswietlWszystkieZwierzeta();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                readUserInput(out userInput);
            }
            
        }

        static void case1(Zoo zoo)
        {
            Console.WriteLine("Podaj ID opiekuna, do którego chcesz przypisać zwierzę");
            readUserInput(out int idOpiekuna);
            Console.WriteLine("Podaj typ zwierzęcia, które chcesz dodać");
            Enum typ = (TypyZwierzat)Enum.Parse(typeof(TypyZwierzat), Console.ReadLine());
            Console.WriteLine("Wpisz imię zwierzęcia");
            string? imie = Console.ReadLine();
            Console.WriteLine("Wpisz gatunek zwierzęcia");
            string? gatunek = Console.ReadLine();
            Console.WriteLine("Wpisz wiek zwierzęcia");
            int wiek;
            readUserInput(out wiek);
            switch(typ)
            {
                case TypyZwierzat.Ssak:
                    zoo.DodajZwierze(idOpiekuna, new Ssak(imie, gatunek, wiek));
                    break;
                case TypyZwierzat.Ptak:
                    zoo.DodajZwierze(idOpiekuna, new Ptak(imie, gatunek, wiek));
                    break;
                case TypyZwierzat.Gad:
                    zoo.DodajZwierze(idOpiekuna, new Gad(imie, gatunek, wiek));
                    break;
            }          
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("1 - Dodaj zwierzę");
            Console.WriteLine("2 - Usuń zwierzę");
            Console.WriteLine("3 - Dodaj opiekuna");
            Console.WriteLine("4 - Usuń opiekuna");
            Console.WriteLine("5 - Wyświetlenie wszystkich opiekunów");
            Console.WriteLine("6 - Wyświetlenie wszystkich zwierzat");
            Console.WriteLine("7 - Zamknij aplikację");
        }
        static void readUserInput(out int inputNumber)
        {
            while(!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Incorrect format of input. Please input a integer number");
            }
        }
    }
}