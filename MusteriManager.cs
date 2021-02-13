using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Musteri class adi 
      public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} Id'li müşteri eklendi.", musteri.Id);
        }

      public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşteri Şehir: " + musteri.Sehir);
                Console.WriteLine("------------------------------");
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} Id'li müşteri siliniyor.",musteri.Id);
        }
    }
}
