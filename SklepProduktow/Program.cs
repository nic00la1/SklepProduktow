using SklepProduktow.Classes;
using System;

namespace SklepProduktow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SKLEP Produktów ===\n");

            Produkt produkt = new Produkt();
            produkt.WyswietlInformacjeOProdukcie();

            // Kupowanie produktów
            produkt.ZakupProdukt();


        }
    }
}