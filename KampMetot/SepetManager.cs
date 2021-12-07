using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampMetot
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyat)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
