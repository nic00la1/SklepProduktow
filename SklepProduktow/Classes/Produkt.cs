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
        public int Id => _id;
        private static int _licznik;
        protected int _ilosc;
        protected int Ilosc
        {
            get => _ilosc;
            set 
            { 
                if (_ilosc != value) 
                { 
                    Console.WriteLine($"Wartość pola Ilość z {_ilosc} została zmieniona na {value}.");
                    _ilosc = value;
                }
            }
        }
        public string _nazwa;
        public string Nazwa
        {
            get => _nazwa;
            set
            {
                if (_nazwa != value)
                {
                    Console.WriteLine($"Wartość pola Nazwa została zmieniona z {_nazwa} na: {value}.");
                    _nazwa = value;
                }
            }
        }
        public double _kwota;
        public double Kwota
        {
            get => _kwota;
            set
            {
                if (_kwota != value)
                {
                    Console.WriteLine($"Wartość pola Kwota została zmieniona z {_kwota}zł na: {value}zł.");
                    _kwota = value;
                }
            }
        }

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
            Console.WriteLine($"--- INFO o Produkcie ---");

            Console.WriteLine($"ID: {Id}\nNazwa: {Nazwa}\nKwota: {Kwota} zł\nDostępna Ilość: {Ilosc}\n");
        }

        public void ZakupProdukt()
        {
            Console.WriteLine("2. Zakup produktu");

            if (Ilosc > 0)
            {
                Ilosc -= 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Zakupiono produkt pomyślnie! Liczba produktów: {Ilosc}\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Ilość produktów jest za mała by ją odjąć!\n");
                Console.ResetColor();
            }
        }

        public void UzupelnijProdukt(int ilosc)
        {
            Console.WriteLine("3. Dostawa produktu");

            if (ilosc > 0)
            {
                Ilosc += ilosc;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Dostarczono produkt w ilości: {ilosc}\n");
                Console.ResetColor();
            } 
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Twoja dostawa musi być dodatnia! Nie możesz wpisywać ujemnej kwoty!");
                Console.ResetColor();
            }
        }

        public void ZmienCeneProduktu(double cena)
        {
            Console.WriteLine("4. Zmiana ceny produktu ");

            if (cena > 0)
            {
                Kwota = cena;
                Console.WriteLine($"Nowa cena produktu wynosi: {Kwota}zł\n");
            }
            else
            {
                Console.WriteLine("Cena produktu jest spoza zakresu! Nie może być wartością ujemną!\n");
            }
        }
    }
}
