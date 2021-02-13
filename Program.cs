using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //class içinde tanımladığımız metotları kulanmmaız için
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Filiz";
            musteri1.Soyad = "Kahrıman";
            musteri1.Sehir = "İstanbul";

            musteriManager.Ekle(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Dilan";
            musteri2.Soyad = "Kaya";
            musteri2.Sehir = "Ardahan";

            musteriManager.Ekle(musteri2);

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Mustafa";
            musteri3.Soyad = "Keleş";
            musteri3.Sehir = "Adıyaman";

            musteriManager.Ekle(musteri3);
            Console.WriteLine("---------------------------");

            //Listele metodunun parametresi dizi türünde, onu tanımladım
            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};
            Console.WriteLine("Musteriler Listeleniyor.");
            musteriManager.Listele(musteriler);

            Console.WriteLine("---------------------------");

            Console.WriteLine("Musteri Siliniyor.");
            musteriManager.Sil(musteri3);

            Console.WriteLine("---------------------------");

            musteriler = new Musteri[] {musteri1, musteri2};
            Console.WriteLine("Musteriler Listeleniyor.");
            musteriManager.Listele(musteriler);



        }
    }
}
