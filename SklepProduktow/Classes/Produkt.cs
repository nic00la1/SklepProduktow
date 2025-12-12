using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepProduktow.Classes
{
    public class Produkt
    {
        private int _id;
        private static int _licznik;
        protected int _ilosc;
        public string _nazwa;
        public double _kwota;

        public Produkt()
        {
            _nazwa = "Nieznane";
            _kwota = 0.00;
            _ilosc = 0;

            _licznik++;
            _id = _licznik;
        }

        public Produkt(string nazwa, double kwota)
        {
            _nazwa = nazwa;
            _kwota = kwota;
            _ilosc = 1;

            _licznik++;
            _id = _licznik;
        }

        public Produkt(string nazwa, double kwota, int ilosc)
        {
            _nazwa = nazwa;
            _kwota = kwota;
            _ilosc = ilosc;

            _licznik++;
            _id = _licznik;
        }
    }
}
