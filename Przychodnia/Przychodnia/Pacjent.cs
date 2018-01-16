using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Pacjent:Osoba
    {
        string choroba;
        int wiek;

        public Pacjent(string imie,string nazwisko,int wiek,string choroba)
            :base(imie,nazwisko)
        {
            this.wiek = wiek;
            this.choroba = choroba;
        }

        public override string ToString()
        {
            return "Pacjent. imię i nazwisko: "+"{"+imie+"}"+" "+"{"+nazwisko+"}, "+"wiek: "+"{"+wiek+"} "+"choroba: "+"{"+choroba+"}";
        }
    }
}
