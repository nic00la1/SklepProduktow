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

            TestujProdukt(produkt1, 7, -2444);
            produkt1.Nazwa = "Laptop Lenovo";
            produkt1.Kwota = 2442.33;

            TestujProdukt(produkt2, 2, 3999.44);
            TestujProdukt(produkt3, -3, 1888.55);
            TestujProdukt(produkt4, 2, 1200.77);
        }

        static void TestujProdukt(Produkt p, int dostawa, double nowaCena)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"       Test Produktu #{p.Id}");
            Console.WriteLine("===================================");

            p.WyswietlInformacjeOProdukcie();
            p.ZakupProdukt();
            p.UzupelnijProdukt(dostawa);
            p.ZmienCeneProduktu(nowaCena);
            p.WyswietlInformacjeOProdukcie();
            Console.WriteLine("===================================");

        }
    }
}