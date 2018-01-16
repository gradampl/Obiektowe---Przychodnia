using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    interface IPrzychodnia
    {
        int CzasOczekiwania();
        void DodajDoKolejki(string imie, string nazwisko, int wiek, string choroba);
        void GenerujRaport();
        void UstawLekarza(string imie, string nazwisko, string specjalnosc);
        string WykonajBadanie();
        string WykonajPorade();
    }
}
