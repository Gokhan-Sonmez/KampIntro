using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                Adi= "Hira",
                SoyAdi = "Deniz",
                Telefon = "111-222-333",
                Email = "hira@email.com",
                Adres = "Istanbul"
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Adi = "Kira",
                SoyAdi = "Dimova",
                Telefon = "121-212-313",
                Email = "kira@email.com",
                Adres = "Odessa"
            };
            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Adi = "Asil",
                SoyAdi = "Koc",
                Telefon = "112-223-331",
                Email = "asil@email.com",
                Adres = "Ankara"
            };

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };


            Console.WriteLine("---------Müşteri Ekle---------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("---------Müşteri Listele---------");

            musteriManager.Listele(musteriler);


            Console.WriteLine("---------Müşteri Sil---------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
