using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Przychodnia
{
    class Przychodnia:IPrzychodnia
    {
        Lekarz lekarz;
        Queue<Pacjent> pacjenci=new Queue<Pacjent>();
        string imie, nazwisko, specjalnosc,napis;

        public void UstawLekarza(string imie, string nazwisko, string specjalnosc)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.specjalnosc = specjalnosc;
            lekarz = new Lekarz(imie, nazwisko, specjalnosc);
        }
        
        public void DodajDoKolejki(string imie, string nazwisko, int wiek, string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imie, nazwisko, wiek, choroba));
        }

        public string WykonajPorade()
        {
            return string.Format("Wykonano poradę! {0}", pacjenci.Dequeue());
        }

        public string WykonajBadanie()
        {
            return "Wykonano badanie! " + pacjenci.Peek();
        }

        public int CzasOczekiwania()
        {
            return (pacjenci.Count / 4);
        }

        public override string ToString()
        {
            napis=lekarz.ToString()+Environment.NewLine;
            napis += "Pacjenci w kolejce:" + Environment.NewLine;
            foreach(var i in pacjenci)
            {
                napis+=i.ToString()+Environment.NewLine;
            }
            napis += "Czas oczekiwania = " + CzasOczekiwania();
            return napis;
        }

        public void GenerujRaport()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string name = "Raport" + hour + minute + day+month + year + ".txt";
            FileStream fs = new FileStream(name, FileMode.CreateNew);
            using (StreamWriter sw = new StreamWriter(fs)) { sw.WriteLine(napis); sw.WriteLine("Zakończono generowanie raportu."); }
        }

        public bool CzyLekarz()
        {
            bool pusteImie = string.IsNullOrEmpty(imie);
            bool pusteNazwisko = string.IsNullOrEmpty(nazwisko);
            bool pustaSpec = string.IsNullOrEmpty(specjalnosc);
            if (pusteImie || pusteNazwisko || pustaSpec)
                return false;
            else
                return true;
        }
    }
}
