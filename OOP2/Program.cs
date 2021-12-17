using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "NASUH";
            musteri1.Soyadi = "YAŞA";
            musteri1.TcNo = "12345678999";



            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "NOSOFTWARE";
            musteri2.VergiNo = "1234567890";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManeger musteriManeger = new MusteriManeger();
            musteriManeger.Ekle(musteri1);
            
            
        }
    }
}
