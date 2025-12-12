using SklepProduktow.Classes;
using System;

namespace SklepProduktow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SKLEP Produktów ===");

            Produkt produkt = new Produkt();
            produkt.WyswietlInformacjeOProdukcie();
        }
    }
}