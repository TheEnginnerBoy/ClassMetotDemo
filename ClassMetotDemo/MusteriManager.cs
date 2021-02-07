using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:" + musteri.ad +" "+musteri.soyad);
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Nolu musteri: "+musteri.ad + " " + musteri.soyad+" listeden silindi"); 
        }

        public void MusteriListeleme(Musteri[] musteriDizisi)
        {
            foreach (Musteri musteri in musteriDizisi)
            {
                Console.WriteLine();

                Console.WriteLine("---------------------------");

                Console.WriteLine("Müşteri Sırasi : " + musteri.Id);

                Console.WriteLine("Müşteri İsmi : " + musteri.ad);

                Console.WriteLine("Müşteri Soyadı : " + musteri.soyad);

                Console.WriteLine("Müşteri Yaşı: " + musteri.yas);

                Console.WriteLine("------------------------------");

            }
        }
    }
}
