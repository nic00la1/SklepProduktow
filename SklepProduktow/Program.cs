using SklepProduktow.Classes;
using System;

namespace SklepProduktow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SKLEP Produktów ===\n");

            Produkt produkt1 = new ("Laptop HP EliteBook", 7149.00, 10);
            Produkt produkt2 = new ("Bieżnia Domyos T900D 18km/h", 2999.00, 7);
            Produkt produkt3 = new ("Witryna VALTIMO dąb/czarny", 1699.00, 4);
            Produkt produkt4 = new ("Deska SUP PRO TSUNAMI paddle board 350cm T13", 974.99, 2);

            produkt1.WyswietlInformacjeOProdukcie();

            // Kupowanie produktu
            produkt1.ZakupProdukt();

            // Uzupełnianie produktu - (dostawa do sklepu)
            produkt1.UzupelnijProdukt(7);
        }
    }
}