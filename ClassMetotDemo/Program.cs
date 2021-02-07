using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.ad = "ismail";
            musteri1.soyad = "bozkut";
            musteri1.yas = 35;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.ad = "mehmet";
            musteri2.soyad = "alakuş";
            musteri2.yas = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.ad = "kenan";
            musteri3.soyad = "kenanoglu";
            musteri3.yas = 28;

            Musteri[] musteriDizisi = new Musteri[] {musteri1,musteri2,musteri3};
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriListeleme(musteriDizisi);
            musteriManager.musteriEkleme(musteri1);
            musteriManager.MusteriSilme(musteri2);


        }
    }
}
