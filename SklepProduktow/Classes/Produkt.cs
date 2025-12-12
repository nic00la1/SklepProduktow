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

        public void WyswietlInformacjeOProdukcie()
        {
            Console.WriteLine("1. INFO o Produkcie ");

            Console.WriteLine($"Nazwa: {_nazwa}, Kwota: {_kwota}zł, Dostępna Ilość: {_ilosc}\n");
        }

        public void ZakupProdukt()
        {
            Console.WriteLine("2. Zakup produktu");

            if (_ilosc > 0)
            {
                _ilosc--;
                Console.WriteLine($"Zakupiono produkt pomyślnie! Liczba produktów: {_ilosc}\n");
            }
            else
            {
                Console.WriteLine("Ilość produktów jest za mała by ją odjąć!\n");
            }
        }

        public void UzupelnijProdukt(int ilosc)
        {
            Console.WriteLine("3. Dostawa produktu");

            _ilosc += ilosc;
            Console.WriteLine($"Dostarczono produkt w ilości: {ilosc}\n");
        }

        public void ZmienCeneProduktu(double cena)
        {
            Console.WriteLine("4. Zmiana ceny produktu ");

            if (cena > 0)
            {
                _kwota = cena;
                Console.WriteLine($"Nowa cena produktu wynosi: {_kwota}zł\n");
            }
            else
            {
                Console.WriteLine("Cena produktu jest spoza zakresu! Nie może być wartością ujemną!\n");
            }

        }
    }
}
