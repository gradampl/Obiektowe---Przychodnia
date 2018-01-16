using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Program
    {
        private static char klawisz;
        static Przychodnia przychodnia = new Przychodnia();
        static void Main(string[] args)
        {

            Wykonaj();
        }
        private static void WczytajKlawisz()
        {
            Console.WriteLine("A - dodaj lekarza.");
            Console.WriteLine("B - dopisz do kolejki.");
            Console.WriteLine("C - wykonaj poradę.");
            Console.WriteLine("D - wykonaj badanie.");
            Console.WriteLine("E - generuj raport.");
            Console.WriteLine("X - wyjdź z programu.");
            klawisz=Convert.ToChar(Console.ReadLine());
            Console.Clear();
        }
        public static void Wykonaj()
        {
            while(true)
            {
                WczytajKlawisz();
                switch(klawisz)
                {
                    case'A':
                    case 'a': Ustaw(); Continue(); break;
                    case'B':
                    case 'b': Dodaj(); Continue(); break;
                    case'C':
                    case 'c': Console.WriteLine(przychodnia.WykonajPorade()); Continue(); break;
                    case'D':
                    case 'd': Console.WriteLine(przychodnia.WykonajBadanie()); Continue(); break;
                    case'E':
                    case 'e': Console.WriteLine(przychodnia.ToString()); przychodnia.GenerujRaport(); Continue(); break;
                    case'X':
                    case 'x': return;
                    default: Console.WriteLine("Nie przewidziano takiego przycisku."); Continue(); break;
                }
            }
        }

        private static void Continue()
        {
            Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Ustaw()
        {
            do
            {
                Console.Write("Podaj imię lekarza: ");
                string imie = Console.ReadLine();
                Console.Write("Podaj nazwisko lekarza: ");
                string nazwisko = Console.ReadLine();
                Console.Write("Podaj specjalność lekarza: ");
                string specjalnosc = Console.ReadLine();
                przychodnia.UstawLekarza(imie, nazwisko, specjalnosc);
            } while (!przychodnia.CzyLekarz());
            
            
        }

        public static void Dodaj()
        {
            string imie,nazwisko,choroba;
            int wiek;
            do
            {
                Console.Write("Podaj imie pacjenta: ");
                imie = Console.ReadLine();
            } while (string.IsNullOrEmpty(imie));

            do
            {
                Console.Write("Podaj nazwisko pacjenta: ");
                nazwisko = Console.ReadLine();
            } while (string.IsNullOrEmpty(nazwisko));

            do
            {
                Console.Write("Podaj wiek pacjenta: ");
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek >= 120 || wiek <= 0) Console.WriteLine("Podano błędny wiek pacjenta.");
            } while (wiek>=120||wiek<=0);
            
            do
            {
                Console.Write("Podaj chorobę pacjenta: ");
                choroba = Console.ReadLine();
            } while (string.IsNullOrEmpty(choroba));
            
            przychodnia.DodajDoKolejki(imie, nazwisko, wiek,choroba);
        }
    }
}
