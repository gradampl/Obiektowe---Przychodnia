using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba() { }

        public Osoba(string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public abstract override string ToString();
    }
}
