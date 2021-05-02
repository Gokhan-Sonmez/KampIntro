using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri: " + musteri.Adi + " " + musteri.SoyAdi + " " + "Eklendi!");
            Console.WriteLine("------------------------------");
            


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri: " + musteri.Adi + " " + musteri.SoyAdi + " " + "Silindi!");
            Console.WriteLine("------------------------------");
        }
        public void Listele(Musteri[] musteriler)
        {

         
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(musteri.Id + ". Müşteri");
                Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi);
                Console.WriteLine("Email: " + musteri.Email);
                Console.WriteLine("Telefon: " + musteri.Telefon);
                Console.WriteLine("Adress: " + musteri.Adres);
                Console.WriteLine("------------------------------");
            }
           
        }
    }
}
