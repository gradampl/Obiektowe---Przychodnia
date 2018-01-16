using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Lekarz: Osoba
    {
        string specjalnosc;
        public Lekarz()
        {

        }
        
        public Lekarz(string imie,string nazwisko, string specjalnosc)
            :base(imie,nazwisko)
        {
            this.specjalnosc = specjalnosc;
        }

        public override string ToString()
        {
            return "Lekarz. imie i nazwisko:" +" "+"{"+imie+"}"+" "+"{"+nazwisko+"},"+" "+"specjalność"+" "+"{"+specjalnosc+"}";
        }
    }
}
