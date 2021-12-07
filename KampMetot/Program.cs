using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 85;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] uruns = new Urun[]
            {
                urun1,urun2
            };
            foreach (var urun in uruns)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");


            }
            Console.WriteLine("-----------Metotlar---------------");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12);
            Console.ReadLine();
        }
    }
}
