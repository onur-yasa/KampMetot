using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Ali";
            musteri1.LastName = "Veli";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Name = "Ayça";
            musteri2.LastName = "Beğen";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.Name = "Ekin";
            musteri3.LastName = "Beğen";

            Musteri[] musteris = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };

            foreach (var musteriler in musteris)
            {
                //Console.WriteLine(musteriler.Id);
                //Console.WriteLine(musteriler.Name);
                //Console.WriteLine(musteriler.LastName);

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            musteriManager.MusteriDel(musteri2);
            musteriManager.MusteriList(musteri3);
        }
    }
}
