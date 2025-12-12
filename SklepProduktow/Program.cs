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

            // Kupowanie produktu
            produkt.ZakupProdukt();

            // Uzupełnianie produktu - (dostawa do sklepu)
            produkt.UzupelnijProdukt(7);
        }
    }
}