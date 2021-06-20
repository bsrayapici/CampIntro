using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = 12345;
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demirog";
            musteri1.TcNo = "12345678";
            musteri1.MusteriNo = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ıd = 2;
            musteri2.MusteriNo = 54321;
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "12345678";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager.Add(musteri1);
            CustomerManager.Add(musteri2);

          
             

        }
    }
}
